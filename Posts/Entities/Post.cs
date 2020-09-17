using System.Runtime.CompilerServices;
using System.Text;
using System;
using System.Collections.Generic;

namespace Posts.Entities{
    public class Post{

        public DateTime Momento { get; set; }
        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public int Likes { get; set; }

        public List<Comentario> Comentarios { get; set; }

        public Post(DateTime momento, string titulo, string conteudo){
                this.Momento = momento;
                this.Titulo = titulo;
                this.Conteudo = conteudo;
        }

        public void AddLike(){
            this.Likes ++;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (Comentario item in Comentarios)
            {
               //sb.Append("\n");
               sb.AppendLine(item.Texto);
               
            }

            return $"Criacao: {Momento}, Titulo: {Titulo}, Conteudo: {Conteudo}, Likes: {Likes}, {sb}";
        }

        public void AddComentario(Comentario comentario){
            this.Comentarios.Add(comentario);
        }

        public void RemoverComentario(Comentario comentario){
            this.Comentarios.Remove(comentario);
        }
            
        public Comentario ConsultarComentario(string conteudo){
            return Comentarios.Find(x => x.Texto.ToUpper().Contains(conteudo.ToUpper()));
        }
    }
}