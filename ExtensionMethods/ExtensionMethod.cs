namespace System{
 public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj){
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            string formato = string.Empty;

            if(duration.TotalHours < 24)
                formato = duration.TotalHours.ToString("F1") + " Horas";
            else
                formato = duration.TotalDays.ToString("F1") + " Dias";

            return formato;
        }

        public static string Cortar(this string thisObj, int corte){
            
            string temp = thisObj.Substring(0, corte) + "...";
            
            return temp;
        }
        public static int ContarPalavras(this string thisObj){
            return thisObj.Split(new char[]{' ', ',', ';', '.'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int Somar(this int thisObj, int num){
            return thisObj + num;
        }
    }
}