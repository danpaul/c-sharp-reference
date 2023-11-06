using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Course
    {
        public string Name;
        public int TheoryGrade;
        public PracticalGrade PracticalGrade;

        public bool Passed() {
            return TheoryGrade >= 55 && (PracticalGrade == PracticalGrade.Sufficient || PracticalGrade == PracticalGrade.Good);
        }
        public bool CumLaude() {
            return Passed() && TheoryGrade >= 80;
        }

    }



}
