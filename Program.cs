namespace GA_Fields_And_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class
            Person person = new Person();

            // Test setting and getting the Name property
            person.Name = "John Doe"; // Testing setter with validation
            Console.WriteLine(person.Name); // Testing getter

            // Test the read-only property
            Console.WriteLine(person.ReadOnlyName); // Testing read-only property

            // Uncomment the line below to test write-only property
            // person.WriteOnlyName = "Jane Doe";

        } // End Main

    } // class

} // namespace
