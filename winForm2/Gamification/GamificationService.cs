using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winForm2;

namespace Emotions.Gamification
{
    class GamificationService
    {

        public GamificationService()
        {
            NewRound();
        }

        public PhotoStripList PhotoStripList { get; private set; } = new PhotoStripList();

        public eEmotions ActualEmotion = eEmotions.Neutral;

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
                case eEmotions.Happines:
                    ActualEmotion = eEmotions.Anger;
                    break;
                case eEmotions.Anger:
                    ActualEmotion = eEmotions.Sadness;
                    break;
                case eEmotions.Sadness:
                    ActualEmotion = eEmotions.Surprise;
                    break;
                case eEmotions.Surprise:
                    ActualEmotion = eEmotions.Disgust;
                    break;
                default:
                    NewRound();
                    break;
            }
        }

        private int GetMaxActualEmotion(IList<Person> data, eEmotions emotions)
        {
            if (data.Any())
            {
                return (int)Math.Ceiling(data.Max(p => GetPersonActualEmotion(p,emotions)));
            }
            return 0;
        }

        private decimal GetPersonActualEmotion(Person person, eEmotions emotions)
        {
            switch (emotions)
            {
                case eEmotions.Anger:
                    return person.Anger;
                case eEmotions.Contempt:
                    return person.Contempt;
                case eEmotions.Disgust:
                    return person.Disgust;
                case eEmotions.Fear:
                    return person.Fear;
                case eEmotions.Happines:
                    return person.Happiness;
                case eEmotions.Neutral:
                    return person.Neutral;
                case eEmotions.Sadness:
                    return person.Sadness;
                case eEmotions.Surprise:
                    return person.Surprise;
            }
            return 0;
        }

        private void SetEmotionPhoto(Image image)
        {
            switch (ActualEmotion)
            {
                case eEmotions.Happines:
                    PhotoStripList.Last.Photo1 = image;
                    break;
                case eEmotions.Anger:
                    PhotoStripList.Last.Photo2 = image;
                    break;
                case eEmotions.Sadness:
                    PhotoStripList.Last.Photo3 = image;
                    break;
                case eEmotions.Surprise:
                    PhotoStripList.Last.Photo4 = image;
                    break;
                case eEmotions.Disgust:
                    PhotoStripList.Last.Photo5 = image;
                    break;
            }
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
            Anger       = GetMaxActualEmotion(data, eEmotions.Anger);
            Contempt     = GetMaxActualEmotion(data, eEmotions.Contempt);
            Disgust      = GetMaxActualEmotion(data, eEmotions.Disgust);
            Fear         = GetMaxActualEmotion(data, eEmotions.Fear);
            Happiness    = GetMaxActualEmotion(data, eEmotions.Happines);
            Neutral      = GetMaxActualEmotion(data, eEmotions.Neutral);
            Surprise     = GetMaxActualEmotion(data, eEmotions.Surprise);
            Sadness = GetMaxActualEmotion(data, eEmotions.Sadness);
        }

        public void NewGame()
        {
            PhotoStripList.Clear();
            NewRound();
        }

        public void NewRound()
        {
            ActualEmotion = eEmotions.Happines;
            PhotoStripList.AddNew();
        }

        public void ResetRound()
        {
            ActualEmotion = eEmotions.Happines;
            PhotoStripList.Last.Photo1 = null;
            PhotoStripList.Last.Photo2 = null;
            PhotoStripList.Last.Photo3 = null;
            PhotoStripList.Last.Photo4 = null;
            PhotoStripList.Last.Photo5 = null;
        }

        public void Stop()
        {
            ActualEmotion = eEmotions.None;
        }

        public enum eEmotions
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
                case GamificationService.eEmotions.Anger:
                    return "BUĎ NAHNEVANÝ !!!";
                case GamificationService.eEmotions.Happines:
                    return "BUĎ ŠŤASTNÝ !!!";
                case GamificationService.eEmotions.Sadness:
                    return "BUĎ SMUTNÝ !!!";
                case GamificationService.eEmotions.Surprise:
                    return "BUĎ PREKVAPENÝ !!!";
                case GamificationService.eEmotions.Disgust:
                    return "BUĎ ZNECHUTENÝ !!!";
                default:
                    return "Game on!";

            }
        }
    }
}
