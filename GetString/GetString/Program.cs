using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internal;

namespace Test
{
    class Program
    {

        public abstract class MyClass
        {
            private String myString;

            public String MyString
            {
                set
                {
                    myString = Console.ReadLine();
                }

            }


            public virtual String GetString()
            {

                return MyString;
            }

        }


        public class MyDerivedClass : MyClass
        {

            public virtual String GetString()
            {

                // return MyString + " appended from derived class";

            }
        }
    }
}
