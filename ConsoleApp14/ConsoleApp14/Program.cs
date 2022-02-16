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

    class matrix
    {
        public float[,] contains;
        public int str;
        public int stolb; 

        public matrix(int l, int h)
        {
            str = l;
            stolb = h;
            contains = new float[l, h];
            Random r = new Random();

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    contains[i, j] = r.Next(0, 4);
                }
            }
        }

        public matrix()
        {

        }

        public matrix(int l, int h, int a)
        {
            str = l;
            stolb = h;
            contains = new float[l, h];
        }

        public void print()
        {
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    Console.Write(contains[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void multiply(float n)
        {
            for (int i = 0; i < stolb; i++)
            {
                for (int j = 0; j < str; j++)
                {
                    contains[i, j] *= n;
                }
            }
        }

        public void sum(matrix newMatrix)
        {
            if (newMatrix.str == str && newMatrix.stolb == stolb)
            {
                for (int i = 0; i < stolb; i++)
                {
                    for (int j = 0; j < str; j++)
                    {
                        contains[i, j] += newMatrix.contains[i, j];
                    }
                }
            }
        }

        public matrix multiplyTwoMatrix(matrix newMatrix)
        {
            var res = new matrix();

            if (this.str != newMatrix.stolb)
            {
                res = new matrix(0, 0, 0);
            }            
            else
            {
                res = new matrix(this.str, newMatrix.stolb, 0);

                for (int i = 0; i < newMatrix.stolb; i++)
                {
                    for (int j = 0; j < this.str; j++)
                    {
                        for (int k = 0; k < this.stolb; k++)
                        {
                            res.contains[i, j] += this.contains[i, k] * newMatrix.contains[k, j];
                        }
                    }
                }
            }

            return res;
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
        static void Main(string[] args)
        {
            var matrix1 = new matrix(2, 3);
            var matrix2 = new matrix(3, 2);

            matrix1.print();
            Console.WriteLine();
            matrix2.print();
            Console.WriteLine();

            var res = matrix1.multiplyTwoMatrix(matrix2);
            res.print();
        }
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