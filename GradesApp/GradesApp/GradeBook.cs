using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApp
{
    class GradeBook
    {
        
        //constructore ctor
        public GradeBook()
        {
            grades = new List<double>();  
        }

        public GradeStatistics ComputerStatistics() {


            // type variable GradeStatistics
            GradeStatistics stats = new GradeStatistics();
            stats.HightsGrade = 0; 

            float sum = 0;

            foreach (float grade in grades) {

                if (grade > stats.HightsGrade) {
                    stats.HightsGrade = grade; 
                }
                sum += grade; 
            }

            stats.AvarageGrade = sum / grades.Count;
            stats.HightsGrade = sum / grades.Count;
            stats.LowGrade = sum / grades.Count; 
            return stats;  
        }
        //variables definition 
        public void AddGrade(double grade){

            grades.Add(grade); 
        }

        //Colections
        List<double> grades; 
    }
}
