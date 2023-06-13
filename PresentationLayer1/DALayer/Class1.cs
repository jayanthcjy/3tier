namespace DALayer
{
    public class DALayerClass
    {
        
        public static List<List<string>> storage= new List<List<string>>();
        public bool SaveData(string name,string email,string password)
        {

            storage.Add(new List<string> { name,email,password});
            Console.WriteLine("Your account has created");
            return true;

        }
        public bool FetchData(string email,string password)
        {
            for(int i=0; i<storage.Count; i++)
            {
               
                if (!storage[i].Contains(email))
                {
                    Console.WriteLine("User does not exist");
                    return true;
                                        
                }
                else if (storage[i].Contains(email) && storage[i].Contains(password))
                {

                    Console.WriteLine("You have Successfully Logined");
                    return true;

                }
                else if (storage[i].Contains(email) && !storage[i].Contains(password))
                {

                    Console.WriteLine("Enterd incorrect password");
                    return true;

                }

            }
            return true;

        }

    }
}