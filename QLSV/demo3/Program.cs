using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.constructor();
            enterKeyController();
            Console.ReadLine();

        }


        private static void createNewStudent()
        {
            //create new student
            Console.WriteLine("please import student id (this is a number):");
            int pId = Convert.ToInt32(Console.ReadLine());
            if (!checkStudentId(pId))
            {
                Console.WriteLine("please import student name:");
                string pName = Console.ReadLine();
                if (Data.createStudent(pId, pName))
                {
                    printStudentList(); //print sutudent list
                }
                else
                {
                    Console.WriteLine("Unable to create new student");
                }
            }
            else
            {
                Console.WriteLine("you can't use id: {0} ",pId);
            }
            enterKeyController(); //enter key controller
        }

        private static void updateStudent()
        {
            //update student
            Console.WriteLine("please import student id you want edit:");
            int pId = Convert.ToInt32(Console.ReadLine());
            if (checkStudentId(pId))
            {
                Console.WriteLine("please import student name:");
                foreach (student item in Data.Students)
                {
                    if (item.intId == pId)
                    {
                        item.stringName = Console.ReadLine();
                    }
                }
                printStudentList(); //print sutudent list
            }
            else
            {
                Console.WriteLine("id does not exit");
            }
            enterKeyController(); //enter key controller
        }

        private static Boolean checkStudentId(int pId)
        {
            //check student id
            foreach (student item in Data.Students)
            {
                if (item.intId == pId)
                {
                    return true;
                }
            }
            return false;
        }

        private static void printStudentList()
        {
            //print student list
            foreach (student item in Data.Students)
            {
                Console.WriteLine("{0}: {1}",item.intId, item.stringName);
            }
        }

        private static void createNewSubject()
        {
            //create new subject
            Console.WriteLine("please import subject id (this is a number):");
            int pId = Convert.ToInt32(Console.ReadLine());
            if (!checkSubjectId(pId))
            {
                Console.WriteLine("please import subject name:");
                string pName = Console.ReadLine();
                if (Data.createSubject(pId, pName))
                {
                    printSubjectList(); //print sutudent list
                }
                else
                {
                    Console.WriteLine("Unable to create new subject");
                }
            }
            else
            {
                Console.WriteLine("you can't use id: {0} ", pId);
            }
            enterKeyController(); //enter key controller
        }

        private static void updateSubject()
        {
            //update student
            Console.WriteLine("please import subject id you want edit:");
            int pId = Convert.ToInt32(Console.ReadLine());
            if (checkSubjectId(pId))
            {
                Console.WriteLine("please import subject name:");
                foreach (subjects item in Data.Subjects)
                {
                    if (item.intSubjectsId == pId)
                    {
                        item.stringSubjectsName = Console.ReadLine();
                    }
                }
                printSubjectList(); //print subject list
            }
            else
            {
                Console.WriteLine("id does not exit");
            }
            enterKeyController(); //enter key controller
        }

        private static Boolean checkSubjectId(int pId)
        {
            //check subject id
            foreach (subjects item in Data.Subjects)
            {
                if (item.intSubjectsId == pId)
                {
                    return true;
                }
            }
            return false;
        }

        private static void printSubjectList()
        {
            //print subject list
            foreach (subjects item in Data.Subjects)
            {
                Console.WriteLine("{0}: {1}", item.intSubjectsId, item.stringSubjectsName);
            }
        }

        private static void createPoint()
        {
            //create new student
            Console.WriteLine("please import student id (this is a number):");
            int pStudentId = Convert.ToInt32(Console.ReadLine());
            if (checkStudentId(pStudentId))
            {
                Console.WriteLine("please import subject id (this is a number):");
                int pSubjectId = Convert.ToInt32(Console.ReadLine());
                if (checkStudentId(pSubjectId))
                {
                    Console.WriteLine("please import exam times (this is a number):");
                    int pExamTimes = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please import exam date:");
                    string pExamDate = Console.ReadLine();
                    Console.WriteLine("please import exam point (this is a number):");
                    double pExamPoint = Convert.ToInt32(Console.ReadLine());
                    if (Data.createPoint(pStudentId, pSubjectId, pExamTimes, pExamDate, pExamPoint))
                    {
                        printPointList(); //print sutudent list
                    }
                    else
                    {
                        Console.WriteLine("Unable to create new point");
                    }
                }
                else
                {
                    Console.WriteLine("subject Id {0} does not exit ", pSubjectId);
                }
            }
            else
            {
                Console.WriteLine("student Id {0} does not exit ", pStudentId);
            }
            enterKeyController(); //enter key controller
        }
        private static void printPointList()
        {
            //print point list
            foreach (points item in Data.Points)
            {
                Console.WriteLine("studentID: {0}, SubjectId: {1}, Exam times: {2}, Exam Date: {3}, Exam Point: {4}", 
                    item.intStudentId, item.intSubjectsId, item.examTimes, item.examDate, item.point);
            }
        }

        private static void exitConsole()
        {
            //exitconsole
            Environment.Exit(0);
        }

        private static void enterKeyController()
        {
            //controller
            Console.WriteLine("------------------Student Management------------------------------------");
            Console.WriteLine("please enter your selection");
            Console.WriteLine("1:Create new student\n2 2:Update student\n 3:Create new subject\n 4:Update subject\n 5:Import point\n 6:exit");
            string keyControll = Console.ReadLine(); //enter controller

            switch (keyControll)
            {
                case "1":
                    createNewStudent();
                    break;
                case "2":
                    updateStudent();
                    break;
                case "3":
                    createNewSubject();
                    break;
                case "4":
                    updateSubject();
                    break;
                case "5":
                    createPoint();
                    break;
                case "6":
                    exitConsole();
                    break;
            }
        }
    }
}
