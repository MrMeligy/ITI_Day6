namespace ConsoleApp1
{
    //task3
    class student
    {
        int ssn;
        string name;
        int age;
        string phone;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();


            //tassk2
            Console.Write("Enter Id: ");
            int EmpId = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            string EmpName = Console.ReadLine();
            Console.Write("Enter Age: ");
            int EmpAge = int.Parse(Console.ReadLine());
            while (EmpAge < 1)
            {
                Console.WriteLine("Plz Enter Real Age: ");
                EmpAge = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"EmpId: {EmpId}");
            Console.WriteLine($"EmpName: {EmpName}");
            Console.WriteLine($"EmpAge: {EmpAge}");

            //task 1
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

        }
    }
}
