using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonChinaApp.Entities
{
    public partial class Registration
    {
        //public double SumScore
        //{
        //    get
        //    {
        //        var scores = Scores.ToList();
        //        double sumScores = 0;
        //        //for (int i = 0; i < scores.Count; i++) 
        //        //{
        //        //    sumScores = sumScores + scores[i].Quantity;
        //        //}

        //        foreach (var score in scores)
        //        {
        //            sumScores += score.Quantity;
        //        }

        //        //sumScores = scores.Sum(p => p.Quantity);
        //        return sumScores;
        //    }
        //}
        public double SumScore => Scores.ToList().Sum(p => p.Quantity);
    }
}
