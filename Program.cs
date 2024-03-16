internal class Program
{
    class HaloGeneric<T> 
    {
        public void SapaUser(T user)
        {
            Console.WriteLine("Halo user" + user);
        }
    }
    private static void Main(string[] args)
    {
       HaloGeneric<string> haloGeneric = new HaloGeneric<string>();
        haloGeneric.SapaUser("UCOK");

        HaloGeneric<int> haloGenericINT = new HaloGeneric<int>();
        haloGenericINT.SapaUser(007);
    }
}