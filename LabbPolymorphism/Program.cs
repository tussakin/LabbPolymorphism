namespace LabbPolymorphism;

internal abstract class Program
{
    private static void Main()
    {
        //tekniskt sett så säger väl uppgiften att jag borde göra typ såhär som jag kommenterat ut, men!
        //Jag anser att Den implementation jag faktiskt kör är snyggare och även om det inte är en
        //tydlig synlig objektreferens så gör det samma sak, bara snyggare. 

        // var fyrkant = new Fyrkant();
        // var rektangel = new Rektangel();
        // var cirkel = new Cirkel();
        // var ellips = new Ellips();
        // var parallellogram = new Parallellogram();
        //
        // var geometryList = new List<Geometri>
        // {
        //     fyrkant, rektangel,cirkel,ellips,parallellogram
        // };

        var geometriList = new List<Geometri>
        {
            new Fyrkant(),
            new Rektangel(),
            new Cirkel(),
            new Ellips(),
            new Parallellogram()
        };

        // ReSharper disable once CommentTypo
        /* En foreach loop för att loopa igenom listan med objekt där vi skriver ut en sträng, kallar på namnet på
         klassen genom metoden GetType() och sedan på metoden Area i den aktuella klassen. Det är en generell sträng
         eftersom vi loopar igenom listan objekt för objekt. */
        foreach (var geometri in geometriList)
            Console.WriteLine("Area för " + geometri.GetType().Name + " " + geometri.Area());
    }
}