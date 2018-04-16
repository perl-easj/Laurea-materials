namespace DIExample.DISimple
{
    public class Client
    {
        private ClassABC _abc;
        private InterfaceB _b;

        public Client()
        {
            _abc = new ClassABC();
        }

        public Client(ClassABC abc)
        {
            _abc = abc;
        }

        public Client(InterfaceB b)
        {
            _b = b;
        }


        // Use _abc for something
    }
}