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

        /// <summary>
        /// Bónuszkártya osztály
        /// </summary>
        class Bonuscard
        {
            /// <summary>
            /// rejtett adattagok
            /// </summary>
            private float balance;
            private string cardNumber;
            private Status cardStatus;

            /// <summary>
            /// konstruktorok
            /// </summary>
            /// <param name="balance"></param>
            /// <param name="cardNumber"></param>
            /// <param name="cardStatus"></param>
            public Bonuscard(string cardNumber, Status cardStatus, float balance)
            {
                this.Balance = balance;
                this.CardNumber = cardNumber;
                this.CardStatus = cardStatus;
            }

            public float Balance { get => balance; set => balance = value; }
            public string CardNumber { get => cardNumber; set => cardNumber = value; }
            public Status CardStatus { get => cardStatus; set => cardStatus = value; }

            public bool Useable
            {
                get
                {
                    if (balance > 0 && cardStatus == Status.Active)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }

            public override string ToString()
            {
                string result = "Bonusz kártya adatai: ";
                result += "\nBonusz kártya kártyaszáma: " + cardNumber;
                result += "\nBonusz kártya egyenlege: " + balance;
                if (Useable)
                {
                    result += "\nA bonusz kártya használható.";
                }
                else
                {
                    result += "\nA bonusz kártya nem használható";
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
