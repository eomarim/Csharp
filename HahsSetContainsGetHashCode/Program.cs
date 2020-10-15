using System.IO;
using System;
using System.Collections.Generic;

namespace HahsSetContainsGetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.ShowUsers();
        }
    }

    public class User{
        public string Name { get; set; }
        public DateTime AccessDate { get; set; }

        private HashSet<User> HsUser;
        private const string PathTxtFile = @"/Users/eduardomarim/Programacao/CSharp/HahsSetContainsGetHashCode/usersLogAcess.txt";

        public User(){
          
        }
        public User(string name, DateTime accessDate):this(){
            Name = name;
            AccessDate = accessDate;

            
        }
        private void ReadTxtFile(){
                HsUser = new HashSet<User>();
            using (var reader = new StreamReader(PathTxtFile)){
                while (!reader.EndOfStream)
                {
                    string[] objUser = reader.ReadLine().Split(";");
                    HsUser.Add(new User(objUser[0].Trim(), DateTime.Parse(objUser[1])));    
                }
            }
        }
        public void ShowUsers(){

              ReadTxtFile();

            foreach (User usr in HsUser)
            {
                System.Console.WriteLine(usr);
            }
        }

        public override bool Equals(object obj)
        {
            if(!(obj is User)){
                return false;
            }
            var other = obj as User;

            return 
                   Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Access Date:{AccessDate}";
        }
    }
    
        
}
