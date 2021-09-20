using System;

namespace SpectatorProject
{
    class Program
    {
        /// <summary>
        /// Elérhetőség
        /// </summary>
        enum Status
        {
            Inactive,
            Active,
            Expired
        }
        /// <summary>
        /// Név osztály
        /// </summary>
        class Name
        {
            /// <summary>
            /// rejtett adattagok
            /// </summary>
            private string firstName;
            private string lastName;

            //konstruktor
            public Name(string lastName, string firstName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }

            public string FirstName { get => firstName; set => firstName = value; }
            public string LastName { get => lastName; set => lastName = value; }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
