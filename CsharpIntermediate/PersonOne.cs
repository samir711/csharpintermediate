using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
    public class PersonOne
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; }

        public PersonOne(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
       

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        //var person = new PersonOne(new DateTime(1982, 1, 1));
        //Console.WriteLine(person.Age);
    }
}
