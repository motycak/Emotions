using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForm2
{
    public class Emotion : Microsoft.ProjectOxford.Common.Contract.Emotion
    {

        public Emotion()
        { }

        public void SetEmotion(float anger, float contempt, float disgust, float fear, float happiness, float neutral, float surprise)
        {
            base.Scores = new Microsoft.ProjectOxford.Common.Contract.EmotionScores();
            base.Scores.Anger = anger;
            base.Scores.Contempt = contempt;
            base.Scores.Disgust = disgust;
            base.Scores.Fear = fear;
            base.Scores.Happiness = happiness;
            base.Scores.Neutral = neutral;
            base.Scores.Surprise = surprise;
        }

    }
}
