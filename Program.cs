namespace Object_Oriented_Programming
{
    public class Mainly
    {
       public static void Main(String[] args)
        {
            Student std1 = new Student();
            std1.firstname = "Obinna";
            std1.lastname = "Kings";
            std1.age = 20;

            Student std2 = new Student();
            std2.firstname = "Buhari";
            std2.lastname = "Mumu";
            std2.age = 90;

            Console.WriteLine("Your Name is " + std1.firstname + " " + std1.lastname + " " + std1.age);
            Console.ReadLine();
        } 
    }

}