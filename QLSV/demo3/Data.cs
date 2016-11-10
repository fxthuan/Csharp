using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace demo3
{
    class Data
    {
        public static ArrayList Students = new ArrayList();
        public static ArrayList Subjects = new ArrayList();
        public static ArrayList Points = new ArrayList();
        public static void constructor()
        {
            //students
            Students.Add(new student(1, "Ho Mau Tuan Linh"));
            Students.Add(new student(2, "Dong Van Kien"));
            Students.Add(new student(3, "Nguyen Quang Nghia"));
            Students.Add(new student(4, "Nguyen Hong Nhut"));
            
            //subjects
            Subjects.Add(new subjects(1, "Software Requirement"));
            Subjects.Add(new subjects(2, "Software Testing"));
            Subjects.Add(new subjects(3, "Software Architectuer"));

            //points
            Points.Add(new points(1, 3, 1, "20/12/2016", 10));
            Points.Add(new points(1, 2, 1, "20/12/2016", 10));
            Points.Add(new points(1, 1, 1, "20/12/2016", 10));
            Points.Add(new points(2, 1, 1, "20/12/2016", 9));
            Points.Add(new points(2, 3, 1, "20/12/2016", 9));
            Points.Add(new points(3, 2, 1, "20/12/2016", 9));

        }
        public static Boolean createStudent(int pId, string pName )
        {
            //create student
            try
            {
                Students.Add(new student(pId, pName));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean createSubject(int pId, string pName)
        {
            //create subject
            try
            {
                Subjects.Add(new subjects(pId, pName));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean createPoint(int pStudentId, int pSubjectId, int pExamTimes, string pExamDate, double pPoint)
        {
            //create point
            try
            {
                Points.Add(new points(pStudentId, pSubjectId, pExamTimes, pExamDate, pPoint));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
