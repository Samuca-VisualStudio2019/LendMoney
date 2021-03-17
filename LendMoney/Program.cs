using System;

namespace LendMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Guy object in a variable called joe
            // Set its Name field to "Joe"
            // Set its Cash field to 50
            Guy joe = new Guy() { Name = "Joe", Cash = 50 };

            // Create a new Guy object in a variable called bob
            // Set its Name field to "Bob"
            // Set its Cash field to 100
            Guy bob = new Guy() { Name = "Bob", Cash = 100 };
        }
    }
}
