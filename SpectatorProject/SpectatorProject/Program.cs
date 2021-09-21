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

            /// <summary>
            /// konstruktorok
            /// </summary>
            /// <param name="name"></param>
            /// <param name="creditCard"></param>
            /// <param name="bonusCard"></param>
            public Spectator(Name name, Creditcard creditCard, Bonuscard bonusCard)
            {
                this.name = name;
                this.creditCard = creditCard;
                this.bonusCard = bonusCard;
            }

            public override string ToString()
            {
                string result = "Néző adatai: \n";
                result += name + "\n" + creditCard + "\n" + bonusCard;
                return result;
            }
        }

        static void Main(string[] args)
        {
            Name name = new Name("László", "Látó");
            Console.WriteLine("Teljes név tulajdonság: " + name.FullName);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
            DateTime expiredDate = new DateTime(2022, 3, 15);
            string dateString = expiredDate.ToString();
            Creditcard creditCard = new Creditcard("11", expiredDate);
            if (creditCard.Expired)
            {
                Console.WriteLine("Lejárat tulajdonság: Lejárt");
            }
            else
            {
                Console.WriteLine("Lejárat tulajdonság: Nem Lejárt");
            }
            Status status = Status.Active;
            Bonuscard bonusCard = new Bonuscard("12", status, 30000);
            if (bonusCard.Useable)
            {
                Console.WriteLine("Próba: a bónuszkártya használható");
            }
            Spectator spectator = new Spectator(name, creditCard, bonusCard);
            Console.WriteLine(spectator);



            Console.ReadKey();
        }


    }


}
