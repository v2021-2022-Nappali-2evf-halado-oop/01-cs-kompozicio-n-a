﻿using System;

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

            public string FullName
            {
                get
                {
                    return firstName + " " + lastName;
                }
            }

            public override string ToString()
            {
                return "Néző neve: " + FullName;
            }
        /// <summary>
        /// Néző osztály
        /// </summary>
        class Spectator
        {
            /// <summary>
            /// rejtett adattagok
            /// </summary>
            private Name name;
            private Creditcard creditCard;
            private Bonuscard bonusCard;
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
