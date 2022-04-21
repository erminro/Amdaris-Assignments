using System.Diagnostics;

namespace ExceptionHandelingAndDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            User user= new User() { Name="Ermin",Age=21,Cards=new List<Card>()};
            User user1 = new User() { Name="Andreea",Age =16,Cards=new List<Card>()};
            Card card = new Card(){Name="BT",Balance=281};
            Card card1 = new Card() { Name = "American", Balance = 10 };
            Card card2 = new Card() { Name = "Revolut", Balance = 100 };
            Card card3 = null;
            try
            {
                createCreditCard(user,card);
                //createCreditCard(user, card3); //null exception
                createCreditCard(user, card1);
                //createCreditCard(user1,card2); //age exception
                //pay(user.Cards[1], 100); // insufficient founds exception
                pay(user.Cards[0], 100);
            }
            catch(ArgumentNullException ex)
            {
                Debug.WriteLine("NullParameter");
                Console.WriteLine(ex.Message);
            }catch(ExeptionCreateCreditCardAgeLimit ex)
            {
                Debug.WriteLine("User age <18");
                Console.WriteLine(ex.Message);
            }catch(PayWithCardInsufficientBalanceException ex)
            {
                Debug.WriteLine("Not enough money in card");
                Console.WriteLine(ex.Message);
            }catch (Exception ex)
            {
                Debug.WriteLine("Program crashed");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Card created and first purchase completed");
            }

        }

        public static void createCreditCard(User user, Card card)
        {
                if (user.Age > 18)
                {
                    if (card != null)
                    {
                        user.Cards.Add(card);
                    }
                    else {
                        throw new ArgumentNullException("Card is null");
                    }
                }
                else
                {
                    
                    throw new ExeptionCreateCreditCardAgeLimit(user.Name + " cannot create card because age is not 18");
                }

        }
        public static void pay(Card card, int amount)
        {
            if (card.Balance > amount)
            {
                card.Balance -= amount;
            }
            else
            {
                throw new PayWithCardInsufficientBalanceException("Card:" + card.Name + " got declined insufficient founds");
            }
        }
    }
}