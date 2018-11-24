using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("guangchao", "male");
            Person p2 = (Person)p1.Clone();
            Person p3 = p1.DeepCopy();


            SalesPerson sp1 = new SalesPerson();
            SalesPerson sp2 = sp1;

            p1.name = "gc";
            Console.WriteLine("p1 name:{0}", p1.name);
            Console.WriteLine("p1 name:{0}", p3.name);
            Console.WriteLine("p1 name:{0}", p3.name);
            Console.ReadLine();
            Object ob = new object();
        }
    }

    public class Person : ICloneable
    {
        public string name;
        public string sex;

        public SalesPerson sp = new SalesPerson();

        public Person(string name, string sex)
        {
            this.name = name;
            this.sex = sex;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person p = (Person)this.MemberwiseClone();
            p.name = this.name;
            p.sex = this.sex;
            return p;
        }
    }

    public class SalesPerson
    {

    }

    public class Singleton
    {
        private static Singleton instance;

        private static readonly Object locker = new Object();
        private Singleton()
        {

        }
        private static Singleton GetInstance()
        {
            if(instance == null)
            {
                lock (locker)
                {
                    if(instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;

        }
    }
}
