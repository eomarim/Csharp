using System.Threading;
using System;

namespace TimeSpans
{
    class Program
    {
        static void Main(string[] args)
        {
            const long ts = TimeSpan.TicksPerDay;
            System.Console.WriteLine(ts);

            const long tsh = TimeSpan.TicksPerHour;
            System.Console.WriteLine(tsh);

            const long tsm = TimeSpan.TicksPerMinute;
            System.Console.WriteLine(tsm);

            const long tss = TimeSpan.TicksPerSecond;
            System.Console.WriteLine(tss);

            const long tsms =  TimeSpan.TicksPerMillisecond;
            System.Console.WriteLine(tsms);

            TimeSpan ts2 = TimeSpan.Zero;
            System.Console.WriteLine(ts2.ToString()); 
            
            TimeSpan ts3 = ts2.Add(new TimeSpan(10, 20, 05));
            System.Console.WriteLine(ts3.ToString());

            TimeSpan inicio = new TimeSpan(10, 20, 10);

            TimeSpan termino = new TimeSpan(10000000000);

            TimeSpan result = inicio.Subtract(termino); //Diferenca 

            System.Console.WriteLine(result);
            
            System.Console.WriteLine(termino.ToString()); //Quantidade em horas

            System.Console.WriteLine(termino.Hours.ToString());
            System.Console.WriteLine(termino.Minutes.ToString());
            System.Console.WriteLine(termino.Seconds.ToString());
            System.Console.WriteLine(termino.Milliseconds.ToString());
            System.Console.WriteLine(termino.TotalDays.ToString());
            System.Console.WriteLine(termino.TotalHours.ToString());
            System.Console.WriteLine(termino.TotalMinutes.ToString());
            System.Console.WriteLine(termino.TotalSeconds.ToString());
            System.Console.WriteLine(termino.TotalMilliseconds.ToString());
            System.Console.WriteLine(termino.Ticks.ToString());
            TimeSpan tsDur = termino.Duration(); 
            System.Console.WriteLine(tsDur.ToString());

            TimeSpan tsDiv =  tsDur.Divide(2);
            System.Console.WriteLine(tsDiv);

            TimeSpan tsSub = new TimeSpan(00, 04, 10);

            System.Console.WriteLine(tsSub);

            TimeSpan resultSub = tsDur.Subtract(tsSub);

            System.Console.WriteLine(resultSub);

            TimeSpan tsMulti = new TimeSpan(30, 10, 10, 10);

            System.Console.WriteLine(tsMulti.Multiply(2).ToString());

            DateTime td = new DateTime(1985, 11, 28);

            DateTime dtAtual = DateTime.Now;

            System.Console.WriteLine(td.ToString());
            System.Console.WriteLine(dtAtual.ToString());

            TimeSpan dtResultado = dtAtual.Subtract(td);

            int totalDias = (int) dtResultado.TotalDays; //Arredondando

            System.Console.WriteLine(totalDias);

            int totalAnos = dtAtual.Year - td.Year;

            System.Console.WriteLine(totalAnos.ToString());

            

        }
    }
}
