using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_e_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstProd = new List<Produto>();
            lstProd.Add(new Produto("TV", 4500.00));
            lstProd.Add(new Produto("Notebook", 5200.00));
            lstProd.Add(new Produto("Macbook", 3100.00));
            lstProd.Add(new Produto("Mouse", 99.00));

            lstProd.Sort();

            //passando um delegate Action para o metodo ForEach
           lstProd.ForEach(AtualizaPreco);
        
           foreach (var item in lstProd)
           {
               System.Console.WriteLine(item);
           }
           //Usando o delegate action
            var pr = new Produto("Relogio", 225.00);
           Action<Produto> act = new Action<Produto>(AtualizaPreco);
           //act.Invoke(pr);

           //Outra forma de chamar o delegate action
           Action<Produto> acProd = AtualizaPreco;
           //acProd.Invoke(pr);

            //Outra forma passando uma funcao lambda para o delegate Action
           Action<Produto> delProd = (pr =>
           {
               pr.Preco += pr.Preco * 0.1;
           });
           delProd.Invoke(pr);
           System.Console.WriteLine(pr);

           Func<Produto, string> func = ConverterProdutoCaixaAlta;
                                            //Passando uma func para o Select - Linq
            // List<string> prodsCaixaAlta = lstProd.Select(func).ToList();

            //Passando expressao lambda para o delegate;
            Func<Produto, string> fun = (p => p.Descricao.ToUpper());
            List<string> prodsCaixaAlta = lstProd.Select(fun).ToList();

             //Passando expressao lambda
             //List<string> prodsCaixaAlta = lstProd.Select(prod => prod.Descricao.ToUpper()).ToList();

             foreach (var item in prodsCaixaAlta)
             { 
                 System.Console.WriteLine(item);
             }
            //Delegate Func trabalhando com duas Listas
             Func<List<Produto>, List<Produto>> func2 = ConverteCaixaAltaList;

             List<Produto> lstProd2 = func2.Invoke(lstProd);

             foreach (var item in lstProd2)
             {
                 System.Console.WriteLine(item);
             }
        }
        public static void AtualizaPreco(Produto prod){
            if (prod is null)
            {
                throw new ArgumentNullException(nameof(prod));
            }

            prod.Preco += (prod.Preco * 0.1);
        }

        public static string ConverterProdutoCaixaAlta(Produto p) =>  p.Descricao.ToUpper();

        public static List<Produto> ConverteCaixaAltaList(List<Produto> lstProd){
            foreach (var item in lstProd)
            {
                item.Descricao = item.Descricao.ToUpper();
            }

            return lstProd;
        }
    
    }
        public class Produto : IComparable{
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto(string descricao, double preco)
        {
            this.Descricao = descricao; 
            this.Preco = preco;
        } 
    
        public override string ToString() => $"Descricao:{Descricao}, Preco:{Preco}";

        public override int GetHashCode() => HashCode.Combine(Descricao);
        
        public override bool Equals(object obj)
        {            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
                var objProd = obj as Produto;
                

            return Descricao.Equals(objProd.Descricao);
        }

        public int CompareTo(object obj){
            if(obj != null && obj.GetType() != this.GetType())
                return 0;

            var objProd = obj as Produto;

            return Descricao.CompareTo(objProd.Descricao);
        }


    }
}
