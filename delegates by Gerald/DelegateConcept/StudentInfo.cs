using System;
using System.Collections;
using System.Collections.Generic;

namespace DelegateConcept
{
    /// <summary>
    /// this is the use of delegates
    /// </summary>
 
    public delegate String StudentDetails(String name);
    public delegate int StudentId(int id);
    class StudentInfo
    {
        String studAdress;
        static void Main(string[] args)
        {
            String name1 = "Twinamatsiko Gerald";
            int idNo = 74564234;
            string studentID = idNo.ToString();
            
            StudentDetails objStudentDetails = new StudentDetails(getStudentName);
            StudentId objstudentId = new StudentId(studId);
            Console.WriteLine("This is the student's Name:  "+ objStudentDetails(name1));
            Console.WriteLine("This is the student's idNo:  "+objstudentId(idNo));

            StudentInfo objstudentinfo = new StudentInfo();
            objstudentinfo.StudentAddress = "Wandegeya";

            Console.WriteLine("The student's Address is:  "+objstudentinfo.StudentAddress);


            
            Dictionary<string, string> objdictionary = new System.Collections.Generic.Dictionary<string, string>();
            objdictionary.Add("Student's ID:      ", studentID);
            objdictionary.Add("Student's Name: ", name1);
            objdictionary.Add("Student's Address: ", objstudentinfo.StudentAddress);
            Console.WriteLine();
            ICollection objcollection = objdictionary.Keys;
            foreach(String a in objcollection)
            {
                Console.WriteLine(a+"\t"+objdictionary[a]);
            }



        }
public static String getStudentName(String studName)
        {
            return studName;
        }
        public static int studId(int id)
        {
            return id;
        }
        /// <summary>
        /// This is a property Thank you
        /// </summary>

        public String StudentAddress
        {
            get
            {
                return studAdress;
            }

            set
            {
                studAdress = value;
            }
        }
    }
}
