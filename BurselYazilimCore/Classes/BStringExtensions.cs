namespace BurselYazilimCore.Classes
{
    public  static partial class BStringExtensions
    {
        
         
        public static string Capitalize(this string gelenDeger)
        {
            if (string.IsNullOrEmpty(gelenDeger)) return string.Empty;
            if(gelenDeger.Length == 1 ) return gelenDeger.ToUpper();
            return $"{gelenDeger.Substring(0, 1).ToUpper()}{gelenDeger.Substring(1).ToLower()}";
            
        }

        
        

        public static string AllCapitalize(this string gelenDeger)
        {
            if (string.IsNullOrEmpty(gelenDeger)) return string.Empty;
            if (gelenDeger.IndexOf(' ') < 0) return gelenDeger.Capitalize();
            var dizicik = gelenDeger.Split(' ');
            var returner = string.Empty;
            foreach (var eleman in dizicik)
            {
                returner += eleman.Capitalize();
            }

            return returner;
        }
    }
}