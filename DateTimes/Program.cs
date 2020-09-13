using System.Globalization;
using System;

namespace DateTimes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now; //Instanciando com a data e hora atual no formato padrao;

            System.Console.WriteLine(d1);
            System.Console.WriteLine(d1.Ticks); //ticks em nanosegundos desde que comecou o ano.

            DateTime d2 = new DateTime(2020, 11, 25); //Passando data no construtor
            System.Console.WriteLine(d2);

            DateTime d3 = new DateTime(2020, 11, 20, 23, 20, 10); //passando data e hora no construtor
            System.Console.WriteLine(d3);

            DateTime d4 = new DateTime(2020, 11, 20, 23, 20, 10, 500);//data, hora, minutos e milisegundos
            System.Console.WriteLine(d4);

            DateTime d5 = DateTime.Today; //Data atual com hora as 12:00
            System.Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow; // Data atual com horario de greenwich
            System.Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-11-28 01:00");
            System.Console.WriteLine(d7);

            DateTime d8 = DateTime.ParseExact("2000-11-28 13:00:10", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);//Alterando o formato da data
            System.Console.WriteLine(d8);

            string formato = d8.ToString("dd-MM-yy HH:mm:ss"); //Formatando como String
            System.Console.WriteLine(formato);

            DateTime dti;
            System.Console.WriteLine(DateTime.TryParse(formato, out dti)); //Tentando parse 
        
            System.Console.WriteLine(DateTime.Today.ToLongDateString());
            System.Console.WriteLine(DateTime.Today.ToLongTimeString());

             DateTime dtLong = DateTime.Parse(DateTime.Today.ToLongDateString());
             System.Console.WriteLine(dtLong);

            DateTime dtAdd = dtLong.AddDays(10d).AddHours(12).AddYears(100);

            System.Console.WriteLine(dtAdd);

            DateTime dataUniversal = DateTime.UtcNow; //Data universal de Greenwich

            DateTime dataLocal = DateTime.Now; //Data Local

            DateTime convertUniversalParaLocal = dataUniversal.ToLocalTime();

            System.Console.WriteLine($"Universal {dataUniversal}, Convertido para Local: {convertUniversalParaLocal}");

            DateTime converteDeLocalToUniversal = dataLocal.ToUniversalTime();
            System.Console.WriteLine($"Local {dataLocal} para Universal {converteDeLocalToUniversal}");

            DateTime dtManualLocal = new DateTime(2020, 11, 28, 10, 10, 10, DateTimeKind.Local); //Deixando explicito o padrao

            DateTime dtManualUtc = new DateTime(2020, 11, 28, 10, 10, 10, DateTimeKind.Utc); //Padrao explicito

            System.Console.WriteLine($"Data Universal: {dataUniversal}");
            System.Console.WriteLine($"Data Local: {dataLocal}");

            DateTime dateTimeReajustado = new DateTime();

            if(dtManualLocal.Kind == DateTimeKind.Local)
                dateTimeReajustado = dtManualLocal.ToUniversalTime();

            System.Console.WriteLine(dateTimeReajustado);
<<<<<<< HEAD

            System.Console.WriteLine("Acrescentado encerramento do programa");
=======
>>>>>>> 33fe3449c5b8c55d51436f958073659487085b3d

        }
    }
}
