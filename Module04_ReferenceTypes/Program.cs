namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonStruct p1;
            p1.Id = 1;

            PersonStruct p2 = new PersonStruct();
            p2.Id = 2;

            p1 = p2;    // Kopierer værdier fra p2 til p1.

            PersonClass p3;
            p3 = new PersonClass();
            p3.Id = 3;

            PersonClass p4 = new PersonClass();
            p4.Id = 4;

            p3 = p4;    // Kopierer reference, ikke værdi
            System.Console.WriteLine(p3.Id);

            int[] arr = new int[1];
            arr[0].GetType();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    struct PersonStruct
    {
        public int Id;
    }

    class PersonClass
    {
        public int Id;
    }
}
