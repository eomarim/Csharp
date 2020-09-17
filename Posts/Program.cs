using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
using Posts.Entities;

namespace Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstComentarios = new List<Comentario>();

            lstComentarios.Add(new Comentario("Conteudo muito bom sobre string builder"));
            lstComentarios.Add(new Comentario("Usando StringBuilder"));
            lstComentarios.Add(new Comentario("Como instanciar string builder?"));

            var post = new  Post(DateTime.Parse("2012-03-02 10:30"), "Programacao", "Post sobre como Programar em dot.net");
            post.Comentarios = lstComentarios;
            post.AddLike();
            post.AddLike();
            post.AddLike();

            System.Console.WriteLine(post);

            var comentario = new Comentario("Dicas muito legais");
            post.AddComentario(new Comentario("Muito obrigado pelas dicas!!!"));
            post.AddComentario(comentario);
            System.Console.WriteLine(post);

            post.RemoverComentario(comentario);

            System.Console.WriteLine(post);

            Comentario coment = post.ConsultarComentario("OBRigado");

            System.Console.WriteLine(coment);

        }

 
    }
}
