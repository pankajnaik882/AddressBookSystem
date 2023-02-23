namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Contact c1 = new Contact();
            String[] names = { "Sagar", "Krishna", "Pankaj", "Dharani" };
            c1.change(names);
        }
    }
}