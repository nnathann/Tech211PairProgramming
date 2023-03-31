using System.Drawing;

namespace CodeKataDanyal_Nathan
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(MoneyProblem("43.32"));
        }
        //TODO
        //Given a amount of money, return the number of bills/coins of each denomination required.Use the lowest possible total number of bills and coins.
        public static string MoneyProblem(string money) {
            int twenty = 0, ten = 0, five = 0, two = 0, one = 0, fiftyP = 0, twentyP = 0, tenP = 0, fiveP = 0, oneP = 0;
            if (!money.Contains("."))
            {
                throw new ArgumentException("Incorrect format -> Needs to be in decimals e.g. 00.00");
            }
            if (Convert.ToDouble(money) > 0)
            {
                int index = money.IndexOf(".");
                int maxLength = money.Length - 1;
                int wholeNumber = Convert.ToInt32(money.Substring(0, index));
                Console.WriteLine(money[0] + " " + money[index + 1]);
                Console.WriteLine(money[index + 1] + " " + money[maxLength]);

                while (wholeNumber > 0)
                {
                    twenty = wholeNumber / 20;
                    wholeNumber -= (twenty * 20);
                    ten = wholeNumber / 10;
                    wholeNumber -= (ten * 10);
                    five = wholeNumber / 5;
                    wholeNumber -= (five * 5);
                    two = wholeNumber / 2;
                    wholeNumber -= (two * 2);
                    one = wholeNumber;
                    wholeNumber -= (one);
                }

                int decimalNumber = Convert.ToInt32(money.Substring(index + 1));

                while (decimalNumber > 0)
                {
                    fiftyP = decimalNumber / 50;
                    decimalNumber -= (fiftyP * 50);
                    twentyP = decimalNumber / 20;
                    decimalNumber -= (twentyP * 20);
                    tenP = decimalNumber / 10;
                    decimalNumber -= (tenP * 10);
                    fiveP = decimalNumber / 5;
                    decimalNumber -= (fiveP * 5);
                    oneP = decimalNumber;
                    decimalNumber -= (oneP);
                }
            }
            return $"$20: {twenty}, $10: {ten}, $5: {five}, $2: {two}, $1: {one}, $0.50: {fiftyP}, $0.20: {twentyP}, $0.10: {tenP}, $0.05: {fiveP}, $0.01: {oneP}";
        }
    }
}