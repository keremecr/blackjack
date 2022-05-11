using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace blackjack2
{
    class Program
    {
        static void Main(string[] args)
        {
            int playermoney1 = 1000;

            Dictionary<string, int> Cards = new Dictionary<string, int>();
            Cards.Add("Sinek2", 2);
            Cards.Add("Sinek3", 3);
            Cards.Add("Sinek4", 4);
            Cards.Add("Sinek5", 5);
            Cards.Add("Sinek6", 6);
            Cards.Add("Sinek7", 7);
            Cards.Add("Sinek8", 8);
            Cards.Add("Sinek9", 9);
            Cards.Add("Sinek10", 10);
            Cards.Add("Sinekjoker", 10);
            Cards.Add("Sinekqueen", 10);
            Cards.Add("Sinekking", 10);
            Cards.Add("Sinekas", 11);
            Cards.Add("Karo2", 2);
            Cards.Add("Karo3", 3);
            Cards.Add("Karo4", 4);
            Cards.Add("Karo5", 5);
            Cards.Add("Karo6", 6);
            Cards.Add("Karo7", 7);
            Cards.Add("Karo8", 8);
            Cards.Add("Karo9", 9);
            Cards.Add("Karo10", 10);
            Cards.Add("Karojoker", 10);
            Cards.Add("Karoqueen", 10);
            Cards.Add("Karoking", 10);
            Cards.Add("Karoas", 11);
            Cards.Add("Maça2", 2);
            Cards.Add("Maça3", 3);
            Cards.Add("Maça4", 4);
            Cards.Add("Maça5", 5);
            Cards.Add("Maça6", 6);
            Cards.Add("Maça7", 7);
            Cards.Add("Maça8", 8);
            Cards.Add("Maça9", 9);
            Cards.Add("Maça10", 10);
            Cards.Add("Maçajoker", 10);
            Cards.Add("Maçaqueen", 10);
            Cards.Add("Maçaking", 10);
            Cards.Add("Maçaas", 11);
            Cards.Add("Kupa2", 2);
            Cards.Add("Kupa3", 3);
            Cards.Add("Kupa4", 4);
            Cards.Add("Kupa5", 5);
            Cards.Add("Kupa6", 6);
            Cards.Add("Kupa7", 7);
            Cards.Add("Kupa8", 8);
            Cards.Add("Kupa9", 9);
            Cards.Add("Kupa10", 10);
            Cards.Add("Kupajoker", 10);
            Cards.Add("Kupaqueen", 10);
            Cards.Add("Kupaking", 10);
            Cards.Add("Kupaas", 11);

            List<string> cards = new List<string>();
            cards.Add("Sinek2");
            cards.Add("Sinek3");
            cards.Add("Sinek4");
            cards.Add("Sinek5");
            cards.Add("Sinek6");
            cards.Add("Sinek7");
            cards.Add("Sinek8");
            cards.Add("Sinek9");
            cards.Add("Sinek10");
            cards.Add("Sinekjoker");
            cards.Add("Sinekqueen");
            cards.Add("Sinekking");
            cards.Add("Sinekas");
            cards.Add("Karo2");
            cards.Add("Karo3");
            cards.Add("Karo4");
            cards.Add("Karo5");
            cards.Add("Karo6");
            cards.Add("Karo7");
            cards.Add("Karo8");
            cards.Add("Karo9");
            cards.Add("Karo10");
            cards.Add("Karojoker");
            cards.Add("Karoqueen");
            cards.Add("Karoking");
            cards.Add("Karoas");
            cards.Add("Maça2");
            cards.Add("Maça3");
            cards.Add("Maça4");
            cards.Add("Maça5");
            cards.Add("Maça6");
            cards.Add("Maça7");
            cards.Add("Maça8");
            cards.Add("Maça9");
            cards.Add("Maça10");
            cards.Add("Maçajoker");
            cards.Add("Maçaqueen");
            cards.Add("Maçaking");
            cards.Add("Maçaas");
            cards.Add("Kupa2");
            cards.Add("Kupa3");
            cards.Add("Kupa4");
            cards.Add("Kupa5");
            cards.Add("Kupa6");
            cards.Add("Kupa7");
            cards.Add("Kupa8");
            cards.Add("Kupa9");
            cards.Add("Kupa10");
            cards.Add("Kupajoker");
            cards.Add("Kupaqueen");
            cards.Add("Kupaking");
            cards.Add("Kupaas");


            Player player1 = new Player();
            Player player2 = new Player();

            int playertotal1 = 0;
            int playertotal2 = 0;


            while (cards.Count > 0)
            {





                List<string> playercards1 = new List<string>();
                List<string> playercards2 = new List<string>();



                Random rnd = new Random();
                int rastgele = rnd.Next(0, cards.Count);
                playertotal1 = player1.ekleme(playertotal1, Cards[cards[rastgele]]);
                playercards1.Add(cards[rastgele]);
                cards.Remove(cards[rastgele]);
                int rastgele2 = rnd.Next(0, cards.Count);
                playertotal2 = player2.ekleme(playertotal2, Cards[cards[rastgele2]]);
                playercards2.Add(cards[rastgele2]);
                cards.Remove(cards[rastgele2]);


                int rastgele3 = rnd.Next(0, cards.Count);
                playertotal1 = player1.ekleme(playertotal1, Cards[cards[rastgele3]]);
                playercards1.Add(cards[rastgele3]);
                cards.Remove(cards[rastgele3]);
                int rastgele4 = rnd.Next(0, cards.Count);
                playertotal2 = player2.ekleme(playertotal2, Cards[cards[rastgele4]]);
                playercards2.Add(cards[rastgele4]);
                cards.Remove(cards[rastgele4]);

                Console.WriteLine("Senin çektiğin kartlar:");
                foreach (var card in playercards1)
                {
                    Console.WriteLine(card);
                }

                Console.WriteLine("Bilgisayarın çektiği kartlar:");
                Console.WriteLine(playercards2[0]);

                while (true)
                {
                    string istek;
                    Console.Write("Kart çekmek istiyor musun:(E/H)");
                    istek = Console.ReadLine();
                    if (istek == "H")
                    {
                        break;
                    }
                    else if (istek == "E")
                    {
                        playertotal1 = player1.ekleme(playertotal1, Cards[cards[rnd.Next(0, cards.Count)]]);
                        cards.Remove(cards[rnd.Next(0, cards.Count)]);
                        playercards1.Add(cards[rnd.Next(0, cards.Count)]);
                        Console.WriteLine(playercards1[2]);
                    }
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir yanıt girin");
                    }
                }

                if (playertotal1 < 21 && playertotal2 < 21)
                {
                    if (playertotal1 < playertotal2)
                    {
                        Console.WriteLine("Computer won");
                        playermoney1 -= 100;
                    }
                    else if (playertotal1 > playertotal2)
                    {
                        Console.WriteLine("You won");
                        playermoney1 += 100;
                    }
                    else
                    {
                        Console.WriteLine("Kimse kazanmadı");
                    }
                }
                else if(playertotal1==21 && playertotal2!=21)
                {
                    Console.WriteLine("You won");
                    playermoney1 += 100;
                }
                else if (playertotal2 == 21 && playertotal1 != 21)
                {
                    Console.WriteLine("Computer won");
                    playermoney1 -= 100;
                }
                else if (playertotal1 > 21 && playertotal2 > 21)
                {
                    if (playertotal1 < playertotal2)
                    {
                        Console.WriteLine("You won");
                        playermoney1 += 100;
                    }
                    else if (playertotal1 > playertotal2)
                    {
                        Console.WriteLine("Computer won");
                        playermoney1 -= 100;
                    }
                    else
                    {
                        Console.WriteLine("Kimse kazanmadı");
                    }
                }
                else if (playertotal1>21 && playertotal2<21)
                {
                    Console.WriteLine("Computer won");
                    playermoney1 -= 100;
                }
                else if (playertotal1 < 21 && playertotal2 > 21)
                {
                    Console.WriteLine("You won");
                    playermoney1 += 100;
                }

                playercards1.Clear();
                playercards1.Clear();
                Console.WriteLine("{0} TL paran var", playermoney1);
                System.Threading.Thread.Sleep(2000);







            }
        }


       
        public class Player
        {
            public int ekleme(int cardtotal, int eklenecek)
            {
                cardtotal += eklenecek;

                return cardtotal;
            }
        }


    }
}
