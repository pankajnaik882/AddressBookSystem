namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreatContact c1 = new CreatContact();
            //String[] names = { "Sagar", "Krishna", "Pankaj", "Dharani" };
            //c1.change(names);

            //CreateContactBuiltArray createContactBuiltArray = new CreateContactBuiltArray();
            //createContactBuiltArray.addContact("Pankaj","Naik","nasd","ssasds","sefwefss",323345","4324232344","sAC@gmail.com");
            //createContactBuiltArray.run();

            AddressBookMain.AddContact();

            AddressBookMain.Display();

        }

    }
}