namespace PalindromeProject
{
    class Program
    {
        static void Main(String[] args)
        {
            // taking input
            Console.Write("Enter a number:");
            string Userinput = Console.ReadLine();
            // conversion to int
            int ConvertedUsrInp = Convert.ToInt32(Userinput);

                // intializing a variable to temporarily store the input to be called later
                int TemporaryNum = 0;
                int SetAsideUsrInp = ConvertedUsrInp;

            while (SetAsideUsrInp > 0)
            { 
                //reverse logic
                int LastNum = SetAsideUsrInp % 10;
                int TemporaryNum = (TemporaryNum * 10) + LastNum;
                int FinalNum = SetAsideUsrInp / 10;

                //debugging check
                Console.Write("SetAsideUsrInp: {0}, LastNum: {1}, RevNum: {2}, FinalNum: {3}", SetAsideUsrInp, LastNum, RevNum, FinalNum);
                
            }

            Console.ReadLine();

        }
    }
}