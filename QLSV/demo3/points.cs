using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    class points
    {
        public int intStudentId;
        public int intSubjectsId;
        public int examTimes;
        public string examDate;
        public double point;
        public points(int pStudentId, int pSubjectId, int pExamTimes, string pExamDate, double pPoint)
        {
            this.intStudentId = pStudentId;
            this.intSubjectsId = pSubjectId;
            this.examTimes = pExamTimes;
            this.examDate = pExamDate;
            this.point = pPoint;
        }
    }
}
