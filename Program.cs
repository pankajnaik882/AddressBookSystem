namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Contact c1 = new Contact();
            //String[] names = { "Sagar", "Krishna", "Pankaj", "Dharani" };
            //c1.change(names);

            //CreateContactBuiltArray createContactBuiltArray = new CreateContactBuiltArray();
            //createContactBuiltArray.addContact("sagar","shahu","nag","sss","sss","15544555","444454","sss@gmail.com");
            //createContactBuiltArray.run();

            AddressBookMain.AddContact();
            AddressBookMain.Display();

        }

    }
}