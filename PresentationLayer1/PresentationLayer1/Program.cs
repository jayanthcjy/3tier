using BLLayer;
public class PresentationClass
{
    public static void Main()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("For login enter 1\nFor Sign Up enter 2");
        string userInput = Console.ReadLine();

        BALayerClass user = new BALayerClass();

        while (true)
        {

            if (userInput == "1")
            {
                user.Login();
            }
            else if (userInput == "2")
            {

                user.SignUp();
            }

            else
            {
                Console.WriteLine("Please enter valid input");

            }
        }

    }
}