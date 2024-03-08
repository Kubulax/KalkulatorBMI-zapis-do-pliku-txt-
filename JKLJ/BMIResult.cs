using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace JKLJ
{
    public class BMIResult
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Weight {get; set;}
        public int Height { get; set;}
        public string Gender { get; set; }
        public float Score { get; set;}
        public string Result { get; set; }


        public BMIResult(string title, DateTime date, int weight, int height, string gender, float score, string result)
        {
            Title = title;
            Date = date;
            Weight = weight;
            Height = height;
            Gender = gender;
            Score = score;
            Result = result;
        }

        public BMIResult() 
        {

        }
    }
}
