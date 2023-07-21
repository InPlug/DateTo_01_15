namespace DateTo_01_15Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTo_01_15.DateTo_01_15 dateTo_01_15 = new DateTo_01_15.DateTo_01_15();
            Console.WriteLine("{0} -> {1}", DateTime.Now, dateTo_01_15.ModifyValue(DateTime.Now));
        }
    }
}