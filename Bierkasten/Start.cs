using Bierkasten;

namespace Bierkasten;

public class Start
{
    public int[] KastenGroeßen = { 11, 12, 20, 24 };
    public static string[] KastenTypesList { get; set; } = { "Cola", "Bier", "Apfelsaft", "Wasser" };
    public static List<Kasten> KastenListe { get; set; } = new List<Kasten>();

    static void Main()
    {
        Kasten myKasten = new Kasten();
        AbfrageKasten AbfrageKasten = new AbfrageKasten();
        int AnzahlKasten = AbfrageKasten.AbfrageKastenAnzahl();
        legeKastenElementInListe(myKasten, AnzahlKasten);
        ausgebenKasten(AnzahlKasten);
        Kasten meinKasten = AbfrageKasten.FrageKastenAb(KastenListe);

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

    public void ListeAlleMöglichkeiten(string Möglichkeit)
    {
        if (Möglichkeit.Equals("KastenTypesList"))
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(i + ". " + KastenTypesList[i - 1]);
            }
        }
        else
        {
            ListeKastenGroeßen();
        }
    }

    public void ListeKastenGroeßen()
    {
        Console.WriteLine("1. extra kleiner Kasten: " + KastenGroeßen[0]);
        Console.WriteLine("2. kleiner Kasten: " + KastenGroeßen[1]);
        Console.WriteLine("3. mittlerer Kasten: " + KastenGroeßen[2]);
        Console.WriteLine("4. großer Kasten: " + KastenGroeßen[3]);
    }
}