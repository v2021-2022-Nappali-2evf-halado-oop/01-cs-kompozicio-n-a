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

        /// <summary>
        /// Hitelkártya osztály
        /// </summary>
        class Creditcard
        {
            /// <summary>
            /// rejtett adattagok
            /// </summary>
            private DateTime expiredDate;
            private string cardNumber;

            /// <summary>
            /// konstruktorok
            /// </summary>
            /// <param name="expiredDate"></param>
            /// <param name="cardNumber"></param>
            public Creditcard(string cardNumber, DateTime expiredDate)
            {
                this.ExpiredDate = expiredDate;
                this.CardNumber = cardNumber;
            }

            public DateTime ExpiredDate { get => expiredDate; set => expiredDate = value; }
            public string CardNumber { get => cardNumber; set => cardNumber = value; }

            /// <summary>
            /// Kártya lejárásának vizsgálata
            /// </summary>
            public bool Expired
            {
                get
                {
                    //ha lejárt
                    if (expiredDate < DateTime.Now)
                    {
                        return true;
                    }
                    //ha nem járt le
                    else
                    {
                        return false;
                    }

                }
            }

            public override string ToString()
            {
                string result = "Hitelkártya adatai: " + cardNumber;
                result += "\nLejárati dátum: " + expiredDate;

                if (Expired)
                {
                    result += "\nA kártya lejárt.";
                }
                else
                {
                    result += "\nA kártya nem járt le.";
                }
                return result;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }


}
