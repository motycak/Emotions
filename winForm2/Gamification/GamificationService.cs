using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emotions.Gamification
{
    class GamificationService
    {

        public GamificationService()
        {
            NewRound();
        }

        public PhotoStripList PhotoStripList { get; private set; } = new PhotoStripList();

        public EnumEmotions ActualEmotion = EnumEmotions.Neutral;

        public int LastEmotionValue { get; private set; }

        public int Anger  { get; private set; }
        public int Contempt { get; private set; }
        public int Disgust  { get; private set; }
        public int Fear  { get; private set; }
        public int Happiness { get; private set; }
        public int Neutral  { get; private set; }
        public int Surprise { get; private set; }
        public int Sadness   { get; private set; }

        #region "Private"

        public void NextEmotion()
        {
            switch (ActualEmotion)
            {
                case EnumEmotions.Happines:
                    ActualEmotion = EnumEmotions.Anger;
                    break;
                case EnumEmotions.Anger:
                    ActualEmotion = EnumEmotions.Sadness;
                    break;
                case EnumEmotions.Sadness:
                    ActualEmotion = EnumEmotions.Surprise;
                    break;
                case EnumEmotions.Surprise:
                    ActualEmotion = EnumEmotions.Disgust;
                    break;
                default:
                    ActualEmotion = EnumEmotions.None;
                    break;
            }
        }

        private int GetMaxActualEmotion(IList<Person> data, EnumEmotions emotions)
        {
            if (data.Any())
            {
                return (int)Math.Ceiling(data.Max(p => GetPersonActualEmotion(p,emotions)));
            }
            return 0;
        }

        private decimal GetPersonActualEmotion(Person person, EnumEmotions emotions)
        {
            switch (emotions)
            {
                case EnumEmotions.Anger:
                    return person.Anger;
                case EnumEmotions.Contempt:
                    return person.Contempt;
                case EnumEmotions.Disgust:
                    return person.Disgust;
                case EnumEmotions.Fear:
                    return person.Fear;
                case EnumEmotions.Happines:
                    return person.Happiness;
                case EnumEmotions.Neutral:
                    return person.Neutral;
                case EnumEmotions.Sadness:
                    return person.Sadness;
                case EnumEmotions.Surprise:
                    return person.Surprise;
            }
            return 0;
        }

        private void SetEmotionPhoto(Image image)
        {
            switch (ActualEmotion)
            {
                case EnumEmotions.Happines:
                    PhotoStripList.Last.Photo1 = PreprocessImage(image);
                    break;
                case EnumEmotions.Anger:
                    PhotoStripList.Last.Photo2 = PreprocessImage(image);
                    break;
                case EnumEmotions.Sadness:
                    PhotoStripList.Last.Photo3 = PreprocessImage(image);
                    break;
                case EnumEmotions.Surprise:
                    PhotoStripList.Last.Photo4 = PreprocessImage(image);
                    break;
                case EnumEmotions.Disgust:
                    PhotoStripList.Last.Photo5 = PreprocessImage(image);
                    break;
            }
        }

        private Image PreprocessImage(Image image)
        {
            int size = Math.Min(image.Width, image.Height);
            Rectangle cropRect = new Rectangle((image.Width - size) / 2, (image.Height - size) / 2, size, size);
            return new ImageProcessor.ImageFactory().Load(image).Crop(cropRect).Image;
        }

        #endregion

        public void ProcessEmotions(IList<Person> data, Image image)
        {
            SetMaxEmotionValues(data);
            if (LastEmotionValue == 100)
            {
                SetEmotionPhoto(image);
                NextEmotion();
            }
        }

        private void SetMaxEmotionValues(IList<Person> data)
        {
            LastEmotionValue = GetMaxActualEmotion(data, ActualEmotion);
            Anger       = GetMaxActualEmotion(data, EnumEmotions.Anger);
            Contempt     = GetMaxActualEmotion(data, EnumEmotions.Contempt);
            Disgust      = GetMaxActualEmotion(data, EnumEmotions.Disgust);
            Fear         = GetMaxActualEmotion(data, EnumEmotions.Fear);
            Happiness    = GetMaxActualEmotion(data, EnumEmotions.Happines);
            Neutral      = GetMaxActualEmotion(data, EnumEmotions.Neutral);
            Surprise     = GetMaxActualEmotion(data, EnumEmotions.Surprise);
            Sadness = GetMaxActualEmotion(data, EnumEmotions.Sadness);
        }

        public void NewGame()
        {
            PhotoStripList.Clear();
            NewRound();
        }

        public void NewRound()
        {
            ActualEmotion = EnumEmotions.Happines;
            PhotoStripList.AddNew();
        }

        public void ResetRound()
        {
            ActualEmotion = EnumEmotions.Happines;
            PhotoStripList.Last.Photo1 = null;
            PhotoStripList.Last.Photo2 = null;
            PhotoStripList.Last.Photo3 = null;
            PhotoStripList.Last.Photo4 = null;
            PhotoStripList.Last.Photo5 = null;
        }

        public void Stop()
        {
            ActualEmotion = EnumEmotions.None;
        }

        public enum EnumEmotions
        {
            None = 0,
            Anger = 1,
            Contempt = 2,
            Disgust = 3,
            Fear = 4,
            Happines = 5,
            Neutral = 0,
            Surprise = 6,
            Sadness = 7
        }

        public string GetGameEmotionText()
        {
            switch (ActualEmotion)
            {
                case GamificationService.EnumEmotions.Anger:
                    return "BUĎ NAHNEVANÝ !!!";
                case GamificationService.EnumEmotions.Happines:
                    return "BUĎ ŠŤASTNÝ !!!";
                case GamificationService.EnumEmotions.Sadness:
                    return "BUĎ SMUTNÝ !!!";
                case GamificationService.EnumEmotions.Surprise:
                    return "BUĎ PREKVAPENÝ !!!";
                case GamificationService.EnumEmotions.Disgust:
                    return "BUĎ ZNECHUTENÝ !!!";
                default:
                    return "PLAY EMOTIONS !!!";

            }
        }
    }
}
