namespace DIExample.DISimple
{
    public class Configurator
    {
        public static void Configure()
        {
            // No DI
            Client c = new Client();

            // DI by class
            ClassABC abc = new ClassABC();
            c = new Client(abc);

            // DI by (sub)class
            ClassABCv2 abcv2 = new ClassABCv2();
            c = new Client(abcv2);

            // DI by interface
            InterfaceB b = new ClassABC();
            c = new Client(b);
        }
    }
}