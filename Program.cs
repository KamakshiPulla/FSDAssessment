//using System;
//using System.Collections;
//using System.IO;
//using System.Collections.Generic;




//namespace dotnetassessment
//{
//    public class Teacherdata
//    {
//        class Teacher
//        {
//            public int ID { get; set; }
//            public string Name { get; set; }
//            public string Teachingclass { get; set; }
//            public string Section { get; set; }
//        }
//        class Teacherdata1
//        {
//            private int iD;
//            private string name;
//            private string teachingclass;
//            private string section;

//            public System.Collections.ArrayList myList = new ArrayList();


//            public int ID
//            {
//                get { return iD; }
//                set { iD = value; }
//            }
//            public string Name
//            {
//                get { return name; }
//                set { name = value; }
//            }

//            public string Teachingclass
//            {
//                get { return teachingclass; }
//                set { teachingclass = value; }
//            }

//            public string Section
//            {
//                get { return section; }
//                set { section = value; }
//            }

//            public void ShowList()
//            {
//                for (int i = 0; i < myList.Count; i++)
//                {
//                    Console.WriteLine("" + myList[i] + "\n|");
//                }
//            }

//            public void AddToList()
//            {
//                myList.Add("ID:  " + iD + " Name: " + name + " Teachingclass: " + teachingclass + " Section: " + section);

//            }

            
//        }
//        static void Main(string[] args)
//        {
//            //string[] lines = File.ReadAllLines("Teacherdata.txt");

//            List<String> arrayList = new List<String>();

          
//            using (FileStream fStream = File.OpenRead("Teacherdata.txt"))
//            {
//                using (TextReader reader = new StreamReader(fStream))
//                {
//                    string line = "";
//                    while (!String.IsNullOrEmpty(line = reader.ReadLine()))
//                    {
//                        arrayList.Add(line);
//                        arrayList.Sort();
//                    }
//                    foreach (var items in arrayList)
//                        Console.WriteLine(items);
//                }
//            }


//        }

//    }
//}
