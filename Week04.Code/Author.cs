using System;

namespace Week04.Code
{
    public class Author
    {
        public Author()
        {
            CountOfInstances++;
        }

        public static int CountOfInstances { get; set; }

        public static void IncreaseNoOfInstances()
        {
            CountOfInstances++;
        }

        public void DisplayCurrentNoOfInstances()
        {
            var x = CountOfInstances;
            Console.WriteLine(x);
        }

        public static void X()
        {
            var x = CountOfInstances;
        }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
