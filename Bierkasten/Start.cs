using Bierkasten;

namespace Bierkasten;

public class Start
{
    public int[] KastenGroeßen = { 11, 12, 20, 24 };
    public string[] KastenTypesList { get; set; } = { "Cola", "Bier", "Apfelsaft", "Wasser" };
    public static List<Kasten> KastenListe { get; set; } = new List<Kasten>();

    static void Main()
    {
        Kasten myKasten = new Kasten();
        AbfrageKasten AbfrageKasten = new AbfrageKasten();

        int AnzahlKasten = AbfrageKasten.AbfrageKastenAnzahl();
        legeKastenElementInListe(myKasten, AnzahlKasten);
        ausgebenKasten(AnzahlKasten);
        Kasten MeinAusgewaehlterKasten = AbfrageKasten.FrageKastenAb(KastenListe);
        MeinAusgewaehlterKasten.TakeBottle();
        ausgebenKasten(AnzahlKasten);
    }

    private static void legeKastenElementInListe(Kasten myKasten, int AnzahlKasten)
    {
        for (int i = 0; i < AnzahlKasten; i++)
        {
            KastenListe.Add(myKasten.ErstellenKastenObjekt(i));
        }
    }

    private static void ausgebenKasten(int KastenAnzahl)
    {
        for (int i = 0; i < KastenAnzahl; i++) {
            if (KastenListe[i].NumberBottles >= 20)
            {
                Console.WriteLine(KastenListe[i].KastenType);
                KastenListe[i].CreateKasten(KastenListe[i].NumberBottles);
            }
            else
            {
                Console.WriteLine(KastenListe[i].KastenType);
                KastenListe[i].CreateSmallKasten(KastenListe[i].NumberBottles);
            }
        }
    }

    public static void ListeAlleMöglichkeiten(string Möglichkeit)
    {
        if (Möglichkeit.Equals("KastenTypesList"))
        {
            ListeKastenTypen();
        }
        else
        {
            ListeKastenGroeßen();
        }
    }

    public static void ListeKastenGroeßen()
    {
        Start myStart  = new Start();
        for (int i = 0; i < myStart.KastenGroeßen.Length; i++) 
        {
            Console.WriteLine( (i+1) + " . " + myStart.KastenGroeßen[i]);
        }
    }

    public static void ListeKastenTypen() 
    {
        Start myStart = new Start();
        for (int i = 0; i < myStart.KastenTypesList.Length; i++)
        {
            Console.WriteLine((i + 1) + " . " + myStart.KastenTypesList[i]);
        }
    }
}