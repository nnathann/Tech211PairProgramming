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
        //Modulus
        //
        public static string MoneyProblem(string money) {
            int twenty = 0, ten = 0, five = 0, two = 0, one = 0, fiftyP = 0, twentyP = 0, tenP = 0, fiveP = 0, oneP = 0;
            int index = money.IndexOf(".");
            int maxLength = money.Length - 1;
            Console.WriteLine(index);
            int wholeNumber = Convert.ToInt32(money.Substring(0, index));

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

            //int decimalNumber = Convert.ToInt32(money.Substring(index, maxLength));
            //Console.WriteLine(decimalNumber);

            return $"$20: {twenty}, $10: {ten}, $5: {five}, $2: {two}, $1: {one}, $0.50: {fiftyP}, $0.20: {twentyP}, $0.10: {tenP}, $0.05: {fiveP}, $0.01: {oneP}";
        }

        
    }
}