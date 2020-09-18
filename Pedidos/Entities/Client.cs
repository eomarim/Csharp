using System.Text;
using System;

namespace  Pedidos.Entities
{
    public class Client{
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(){

        }

        public Client(string name, string email, DateTime birthDate){
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public override string  ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Nome Client: ");
            sb.AppendLine(this.Name);
            sb.Append("Email:");
            sb.AppendLine(this.Email);
            sb.Append("Aniversario:" );
            sb.AppendLine(this.BirthDate.ToString());
            
            return sb.ToString();
        }

        
    }
}