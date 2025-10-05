
namespace lab7Firsova_Alekseeva
{
    internal class CardPicker
    {
        static Random random= new Random();
        private static int numberofCards;

        public static string [] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberofCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            throw new NotImplementedException();
            int value = random.Next(1, 5);
            if (value == 1) return "пик";
            if (value == 2) return "червей";
            if (value == 3) return "треф";
            return "бубен";
        }

        private static string RandomValue()
        {
            throw new NotImplementedException();
            int value = random.Next(1, 14);
            if (value == 1) return "Туз";
            if (value == 11) return "Валет";
            if (value == 12) return "Дама";
            if (value == 13) return "Король";
            return value.ToString();
        }
    }
}

