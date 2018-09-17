using Microsoft.ProjectOxford.Common.Contract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emotions
{
    class CoreRecalc
    {

        public event EventHandler<IList<Person>> ImageProcessingFinished;

        public async void RecalcImage(Image image, BindigListData actualPersons)
        {
            // ! Face
            Task<List<Face>> faceEmotion = FaceApi.MakeFaceRequest(image);
            List<Face> face = await faceEmotion;
            this.RecalcFaces(face, actualPersons, image);
            // dam von vediet ze obrazok sa spracoval
            ImageProcessingFinished.Invoke(image,actualPersons.Data);
        }

        private void RecalcFaces(List<Face> faces, BindigListData actualPersons, Image recalcImage)
        {
            this.SetActualEmotion(faces, actualPersons, recalcImage);
        }


        private void SetActualEmotion(List<Face> faces, BindigListData actualPersons, Image recalcImage)
        {
            actualPersons.ClearPersons();
            foreach (var face in faces)
            {
                Person person = actualPersons.GetActualPerson(face.FaceId);

                if (person == null)
                {
                    Rectangle cropRect = new Rectangle(face.FaceRectangle.Left - 7, face.FaceRectangle.Top - 7, face.FaceRectangle.Width + 14, face.FaceRectangle.Height + 14);
                    Bitmap target = new Bitmap(face.FaceRectangle.Width, face.FaceRectangle.Height);
                    using (Graphics g = Graphics.FromImage(target))
                    {
                        g.DrawImage(recalcImage,
                                    new Rectangle(0, 0, target.Width, target.Height),
                                    cropRect, GraphicsUnit.Pixel);
                    }
                    //target.Save(Application.StartupPath + @"\FaceGroups\1\aaa.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    
                    person = new Person();
                    person.FaceID = face.FaceId;
                    person.GroupId = 1;
                    actualPersons.AddPerson(person);

                    person.Image = target;
                }


                this.SetEmotion(face.FaceAttributes.Emotion, person);
            }
        }


        private void SetEmotion(EmotionScores emotion, Person person)
        {
            person.Anger = this.GetRecalculateEmotion(emotion.Anger, 0.4);
            person.Contempt = this.GetRecalculateEmotion(emotion.Contempt, 0.5);
            person.Disgust = this.GetRecalculateEmotion(emotion.Disgust, 0.4);
            person.Fear = this.GetRecalculateEmotion(emotion.Fear, 0.3);
            person.Happiness = this.GetRecalculateEmotion(emotion.Happiness, 1);
            person.Sadness = this.GetRecalculateEmotion(emotion.Sadness, 0.8);
            person.Surprise = this.GetRecalculateEmotion(emotion.Surprise, 0.6);
            person.Neutral = this.GetRecalculateEmotion(emotion.Neutral, 1);
        }

        private decimal GetRecalculateEmotion(double emotion, double coefficient)
        {
            return Math.Min( Math.Round(((decimal)emotion / (decimal)coefficient) * 100, 4), 100);
        }

    }
}
