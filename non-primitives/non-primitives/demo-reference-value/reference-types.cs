namespace ReferenceTypes
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            // number's value is still 1, because the number inside Increment is a different one
        
            var person = new Person() { Age = 20 };
            MakeOld(person);
            // person's value is 30, because we're using its reference inside the method. And thus we change its value everywhere
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}