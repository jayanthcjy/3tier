using DALayer;
namespace BLLayer
{
    public class BALayerClass
    {
       
            DALayerClass data=new DALayerClass();
            public bool Login()
            {
                Console.WriteLine("Enter the following details");
                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                data.FetchData(email, password);
                return true;
            }
            public bool SignUp()
            {
                Console.WriteLine("For creating the account enter the following details");
                Console.WriteLine("Enter the Name");
                string newName = Console.ReadLine();
                Console.WriteLine("Enter the mail");
                string newEmail = Console.ReadLine();
                Console.WriteLine("Enter the password");
                string newPassword = Console.ReadLine();
            data.SaveData(newName, newEmail, newPassword);
            return true;

            }


        }


  
}