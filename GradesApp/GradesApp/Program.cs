﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(80.5);

            GradeStatistics stats = book.ComputerStatistics();

            GradeBook book2 = book;
            book2.AddGrade(75);
        }
    }
}