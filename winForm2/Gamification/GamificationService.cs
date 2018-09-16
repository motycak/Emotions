﻿using System;
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

        public eEmotions ActualEmotion = eEmotions.None;

        public int LastEmotionValue { get; private set; }

        #region "Private"

        public void NextEmotion()
        {
            switch (ActualEmotion)
            {
                case eEmotions.Happines:
                    ActualEmotion = eEmotions.Anger;
                    break;
                case eEmotions.Anger:
                    ActualEmotion = eEmotions.Fear;
                    break;
                case eEmotions.Fear:
                    ActualEmotion = eEmotions.Surprise;
                    break;
                default:
                    NewRound();
                    break;
            }
        }

        private int GetMaxActualEmotion(IList<Person> data)
        {
            if (data.Any())
            {
                return (int)Math.Ceiling(data.Max(p => GetPersonActualEmotion(p)));
            }
            return 0;
        }

        private decimal GetPersonActualEmotion(Person person)
        {
            switch (ActualEmotion)
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
                case eEmotions.Surprise:
                    return person.Surprise;
            }
            return 0;
        }

        private void SetEmotionPhoto(Image image)
        {
            switch (ActualEmotion)
            {
                case eEmotions.Anger:
                    PhotoStripList.Last.Photo4 = image;
                    break;
                case eEmotions.Fear:
                    PhotoStripList.Last.Photo2 = image;
                    break;
                case eEmotions.Happines:
                    PhotoStripList.Last.Photo1 = image;
                    break;
                case eEmotions.Surprise:
                    PhotoStripList.Last.Photo3 = image;
                    break;
            }
        }

        #endregion

        public void ProcessEmotions(IList<Person> data, Image image)
        {
            LastEmotionValue = GetMaxActualEmotion(data);
            if(LastEmotionValue == 100)
            {
                SetEmotionPhoto(image);
                NextEmotion();
            }
        }

        public void NewGame()
        {
            PhotoStripList.Clear();
            NewRound();
        }

        private void NewRound()
        {
            ActualEmotion = eEmotions.Happines;
            PhotoStripList.AddNew();
        }

        public enum eEmotions
        {
            None = 0,
            Anger = 1,
            Contempt = 2,
            Disgust = 3,
            Fear = 4,
            Happines = 5,
            Neutral = 6,
            Surprise = 7
        }
    }
}