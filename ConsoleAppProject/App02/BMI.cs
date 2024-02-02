namespace ConsoleAppProject.App02
{
    public static void Main()
    {   //Variables to be declaired
        int weight;
        int height;
        int bmi;


        Console.WriteLine("Please Enter your height in inches: "); //Asks user for their height in inches
        height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your weight in pounds: "); //Asks user for their weight in pounds
        weight = Convert.ToInt32(Console.ReadLine());


        bmi = (weight * 703) / (height * height); //Actual BMI calculation

        if (bmi >= 18 && bmi <= 30) //Tests the users input, tells the user what their BMI is 
    {
    }
}
