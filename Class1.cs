using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace dotnetassessment
{
    class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Teachingclass { get; set; }
        public string Section { get; set; }
    }
    class Teacherdata
    {
        private int iD;
        private string name;
        private string teachingclass;
        private string section;

        public System.Collections.ArrayList myList = new ArrayList();


        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Teachingclass
        {
            get { return teachingclass; }
            set { teachingclass = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }

        public void ShowList()
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("" + myList[i] + "\n|");
            }
        }

        public void AddToList()
        {
            myList.Add("ID:  " + iD + " Name: " + name + " Teachingclass: " + teachingclass + " Section: " + section);

        }

    }



    class Basicteacherdata
    {
        static void Main(string[] args)
        {
            List<Teacher> teacherdata = new List<Teacher>();
            Teacher teacherdata1 = new Teacher { ID = 1234, Name = "Abhi", Teachingclass = "1st class", Section = "A" };
            teacherdata.Add(teacherdata1);
            Teacher teacherdata2 = new Teacher { ID = 3456, Name = "bhuwan", Teachingclass = "2nd class", Section = "B" };
            teacherdata.Add(teacherdata2);
            Teacher teacherdata3 = new Teacher { ID = 5678, Name = "charle", Teachingclass = "3rd class", Section = "A" };
            teacherdata.Add(teacherdata3);
            Teacher teacherdata4 = new Teacher { ID = 2789, Name = "david", Teachingclass = "4th class", Section = "B" };
            teacherdata.Add(teacherdata4);
            Teacher teacherdata5 = new Teacher { ID = 1111, Name = "Marcin", Teachingclass = "5th class", Section = "B" };
            teacherdata.Add(teacherdata5);
            Teacher teacherdata6 = new Teacher { ID = 3333, Name = "Bumrah", Teachingclass = "2nd class", Section = "A" };
            teacherdata.Add(teacherdata6);
            Console.WriteLine("Before Sorting the data");
            foreach (Teacher data in teacherdata)
            {
                Console.WriteLine("ID:  " + data.ID + " Name: " + data.Name + " Teachingclass: " + data.Teachingclass + " Section: " + data.Section);
            }

            //// sorting teacher data by ID

            //Console.WriteLine("Sort data by ID");

            //teacherdata.Sort(delegate (Teacher t1, Teacher t2) { return t1.ID.CompareTo(t2.ID); });


            //foreach (Teacher data in teacherdata)
            //{
            //    Console.WriteLine("ID:  " + data.ID + " Name: " + data.Name + " Teachingclass: " + data.Teachingclass + " Section: " + data.Section);
            //}


            // Writing to text file
            using (StreamWriter sw = new StreamWriter("Teacherdata.txt"))
            {
                foreach (Teacher data in teacherdata)
                {
                    sw.WriteLine("ID:  " + data.ID + " Name: " + data.Name + " Teachingclass: " + data.Teachingclass + " Section: " + data.Section);
                }

            }

            // Converting text file to list and reading the file and sorting the data

            List<String> arrayList = new List<String>();

            using (FileStream fStream = File.OpenRead("Teacherdata.txt"))
            {
                using (TextReader reader = new StreamReader(fStream))
                {
                    string line = "";
                    while (!String.IsNullOrEmpty(line = reader.ReadLine()))
                    {
                        arrayList.Add(line);
                        arrayList.Sort();                       
                        
                    }
                    fStream.Close();

                    using (StreamWriter sw = new StreamWriter("Teacherdata.txt"))
                    {
                        
                        foreach (var items in arrayList)
                        {
                            sw.WriteLine(items);
                        }
                    }

                    Console.WriteLine("After Sorting Teachers data.");
                    foreach (var items in arrayList)
                        Console.WriteLine(items);

                }
                
            }
            //Updating/Replacing bhuvan name with Dravid
            string text = File.ReadAllText("Teacherdata.txt");
            text = text.Replace("bhuwan", "Dravid");
            File.WriteAllText("Teacherdata.txt", text);
            Console.WriteLine("Updating bhuvan name with dravid");
            Console.WriteLine(text);

            //        // Example how write list to a file. 
            //        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
            //{
            //    foreach (string listItem in list)
            //    {
            //        file.WriteLine(line);

        }
    }
            







        }







