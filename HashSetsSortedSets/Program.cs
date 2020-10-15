using System.Collections.Generic;
using System;

namespace HashSetsSortedSets
{
    class Program
    {
        static void Main(string[] args)
        {
           /* var hashSet = new HashSet<string>();
            hashSet.Add("Eduardo");
            hashSet.Add("Renata");
            hashSet.Add("Moacir");
            hashSet.Add("Dete");

           // hashSet.Remove("Eduardo");
            //hashSet.RemoveWhere(c => c.IndexOf("na") > 0);

            //hashSet.RemoveWhere(d => d.Contains("e"));

            //hashSet.Clear();

           System.Console.Write(hashSet.GetType()); 
        
           ListaColecoes<string>(hashSet);

            var a = new SortedSet<int>(){0, 2, 4, 5, 6, 8, 10};
            var b = new SortedSet<int>(){2, 12, 1, 9, 65, 87, 11};

            //Unindo Listas
            System.Console.WriteLine("Unindo Listas");
            var c = new SortedSet<int>(a);
            c.UnionWith(b);

           ListaColecoes<int>(c);

          //Somente retorna o comum entre as listas
          System.Console.WriteLine("Comum entre as listas");
          var d = new SortedSet<int>(a);
          d.IntersectWith(b);

          ListaColecoes<int>(d);
        
        System.Console.WriteLine("O que tem em a que nao tem em b");
          var e = new SortedSet<int>(a);
            e.ExceptWith(b);

            ListaColecoes<int>(e); */

            var hashProd = new HashSet<Product>();
            hashProd.Add(new Product("Iphone XR", 500.00));
            hashProd.Add(new Product("Macbook Pro", 8500.00));

                var prod = new Product("Macbook Pro", 8500.00);

                System.Console.WriteLine($"HashProd possui prod? {hashProd.Contains(prod)}");

                var hashPointA = new HashSet<Point>();
                hashPointA.Add(new Point(3,4));
                hashPointA.Add(new Point(5,10));

                var point = new Point(5, 1);

                System.Console.WriteLine($"HashPointA possui Point? {hashPointA.Contains(point)}");

                
        }

        public static void ListaColecoes<T>(IEnumerable<T> lista){
            foreach (T item in lista)
            {
                System.Console.WriteLine(item);
            }
        }

        public static void LerColecoes(IEnumerable<int> lista){
            foreach (int item in lista)
            {
                System.Console.Write(item);
            }
        }
    }

    public struct Point{
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y){
            X = x;
            Y = y;
        }
    }

    public class Product{
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price){
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Product))
                throw new ArgumentException("Object is not a Product!");

                var prod = obj as Product;

            return 
                   Name == prod.Name &&
                   Price == prod.Price;
        }

        public override int GetHashCode()
        {
            
            return HashCode.Combine(Name, Price);
        }
    }
}
