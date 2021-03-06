using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name)
            : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        override public char GetLetterGrade(double averageGrade) {
            if (Students.Count < 5) {
                throw new InvalidOperationException();
            }
            return base.GetLetterGrade(averageGrade);
        }
    }
}