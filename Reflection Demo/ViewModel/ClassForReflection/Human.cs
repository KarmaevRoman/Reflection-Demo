using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection_Demo.ViewModel.ClassForReflection
{
    public class Human : BaseViewModel
    {
        public Human()
        {

        }
        public Human(string name, int age)
        {
            var fullName = name.Split(' ');
            Surname = fullName[0];
            FirstName = fullName[1];
            SecondName = fullName[2];

            Age = age;
        }

        public string FirstName { get; }

        public string Surname { get; }

        public string SecondName { get; }
        
        public int Age { get; }
    }
}
