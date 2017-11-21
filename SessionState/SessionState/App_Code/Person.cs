using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionState
{
    public class PersonObject
    {
       public string name;
       public int age;
        
        public PersonObject()
        {

        }

        public override string ToString()
        {
            return name + age;
        }
    }
}