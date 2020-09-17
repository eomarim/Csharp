using System.Text;
using System;

namespace Posts.Entities{
    public class Comentario{
        public string Texto { get; set; }

        public Comentario(string texto){
            this.Texto = texto;
        }

        public override string ToString()
        {
            return $"Comentarios: {Texto}";
        }

        
    }
}