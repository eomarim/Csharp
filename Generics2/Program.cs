using System.Text;
using System.Collections.Generic;
using System;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var lstProd = new List<double>();
            lstProd.Add(100);
                lstProd.Add(10);
                lstProd.Add(5);
                lstProd.Add(50.00);
                lstProd.Add(55);
                lstProd.Add(130.00); 
                
           System.Console.WriteLine($"Maior Valor e: {CompararService.CompararProduto<double>(lstProd)}"); */

           var prod = new Produto(){Descricao = "Iphone", Valor = 1000.00};
           var prod2 = new Produto(){Descricao = "Apple Watch", Valor = 5000.00};
           var prod3 = new Produto(){Descricao = "Macbook", Valor = 7000.00};

           var lstProd = new List<Produto>();
           lstProd.Add(prod);
           lstProd.Add(prod2);
           lstProd.Add(prod3);

           
            System.Console.WriteLine($"Maior Valor e: {CompararService.CompararProduto<Produto>(lstProd)}"); 
        }
    }
    public class CompararService{
        public static T CompararProduto<T>(List<T> listaProd) where T : IComparable {
            if(listaProd == null){
                throw new Exception("Lista Nao foi instanciada");
            }else if(listaProd.Count == 0){
                throw new ArgumentException("Lista vazia!");
            }
            
             T valor =  listaProd[0];
            foreach (T item in listaProd)
            {
                if(item.CompareTo(valor) > 0){
                    valor = item;
                }
                System.Console.WriteLine(item);
            }
            return valor;
        }
    }

     public class Produto : IComparable {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public int CompareTo(object obj) {
        if(!(obj is Produto)){
            throw new ArgumentException("Obj Nao e um produto");
        }
        var prod = obj as Produto;
        
        return Valor.CompareTo(prod.Valor);
    }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Descricao:");
            sb.AppendLine(Descricao);
            sb.Append("Valor:");
            sb.Append(Valor);

            return sb.ToString();
            
        }
    }
}
