using System.Drawing;

namespace CodeKataDanyal_Nathan
{
    public class Program
    {
        static void Main()
        {
        }
        //TODO
        //Given a amount of money, return the number of bills/coins of each denomination required.Use the lowest possible total number of bills and coins.
        //Modulus
        //
        public static string MoneyProblem(string money) {
            int twenty = 0, ten = 0, five = 0, two = 0, one = 0, fiftyP = 0, twentyP = 0, tenP = 0, fiveP = 0, oneP = 0;

            string wholenumber = money[0]: money.IndexOf(".");
            
            return $"$20: {twenty}, $10: {ten}, $5: {five}, $2: {two}, $1: {one}, $0.50: {fiftyP}, $0.20: {twentyP}, $0.10: {tenP}, $0.05: {fiveP}, $0.01: {oneP}";
        }

        //given 43

        
    }
}