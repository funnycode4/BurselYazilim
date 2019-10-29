namespace BurselYazilimCore.Classes
{
    public static partial class BWebHelperStrings
    {
        public static string AsTitle(this string gelenDeger)
        {
            return $"{SiteAyarlari.SiteAdi.AllCapitalize()} | {gelenDeger.AllCapitalize()}";
        }
    }
}