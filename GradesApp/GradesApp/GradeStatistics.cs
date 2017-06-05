using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApp
{

    class GradeStatistics
    {
        public GradeStatistics()
        {
            HightsGrade = 0;
            LowestGrade = float.MaxValue; 
        }
        public float AvarageGrade;
        public float HightsGrade;
        public float LowestGrade; 

    }
}
