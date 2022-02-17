using System;
using System.Collections.Generic;

namespace ConsoleApp14
{ 
    class Student
    {
        public string name;
        public string surname;
        private float avgMath;
        private float avgPhys;
        private float avgInf;

        public Student(string studName, float m, float p, float i)
        {
            string[] inp = studName.Split();
            name = inp[0];
            surname = inp[1];
            Random r = new Random();
            avgMath = m;
            avgPhys = p;
            avgInf = i;
        }
        public Student(int i)
        {            
            Random r = new Random();
            name = "name" + i.ToString();
            surname = "surname" + i.ToString();
            avgMath = r.Next(10, 51) / 10f;
            avgPhys = r.Next(10, 51) / 10f;
            avgInf = r.Next(10, 51) / 10f;
        }

        public Student()
        {

        }

        public float avg()
        {
            return (avgInf + avgMath + avgPhys) / 3;
        }

        public int TheBest(List<Student> students)
        {
            float max = 0;
            int i = 0;
            int maxI = 0;
            foreach (var stud in students)
            {
                float avg = stud.avg();
                if (avg > max)
                {
                    max = avg;
                    maxI = i;
                }
                i++;
            }

            return maxI;
        }

        public void print()
        {
            Console.WriteLine(name + " " + surname);
            Console.WriteLine(avgMath + " " + avgPhys + " " + avgInf);
            Console.WriteLine("{0:0.00}", avg());
            Console.WriteLine();
        }
    }

    class Soda
    {
        string addition;

        public Soda(string a)
        {
            addition = a;
        }

        public void ShowMyDrink()
        {
            if (addition != "")
            {
                Console.WriteLine("газировка и " + addition);
            }
            else
            {
                Console.WriteLine("обычная газировка");
            }
        }
    }

    class Avgustin
    {
        public int age;
        public string name;

        public Avgustin(int age, string name)
        {
            this.age = age;
            this.name = name;
            if (name != "августин")
            {
                Console.WriteLine("я не " + name + ", я августин");
            }
        }
    }

    class Program
    {
        //public static int Best(List<Student> students)
        //{
        //    float max = 0;
        //    int i = 0;
        //    int maxI = 0;
        //    foreach (var stud in students)
        //    {
        //        float avg = stud.avg();
        //        if (avg > max)
        //        {
        //            max = avg;
        //            maxI = i;
        //        }
        //        i++;
        //    }

        //    return maxI;
        //}
        //static int sum1(int a, int b)
        //{
        //    return a + b;
        //}
        //static void sum2(int a, int b, out int c)
        //{
        //    c = a + b;
        //}
    }
}
            //var students = new List<Student>();
            //for (int i = 0; i < 10; i++)
            //{
            //    students.Add(new Student(i));   
            //}

            //foreach (var student in students)
            //{
            //    student.print();    
            //}

            //var st = new Student();

            //students[Best(students)].print();