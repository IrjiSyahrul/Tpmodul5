internal class Program
{

class DataGeneric<T>
    {
        public T Data { get; set; }
        public DataGeneric(T data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan : " + Data);
        }
    }
    private static void Main(string[] args)
    {
        DataGeneric<string> dataString = new DataGeneric<string>("Ini adalah data rahasia kode nuklir");
        dataString.PrintData();
        DataGeneric<int> dataInt = new DataGeneric<int> (1302220088);
        dataInt.PrintData();
    }
}