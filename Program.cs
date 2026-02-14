namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe TicTac = new TicTacToe("Ahmed", "Kareem");
            TicTac.Play();
            Console.ReadLine();
        }
    }

   
}