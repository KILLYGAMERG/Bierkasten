using Bierkasten;
namespace Bierkasten;

public class AbfrageKasten
{
    Start MyMain = new Start();
    Kasten MyKasten = new Kasten();

    public int AbfrageKastenAnzahl()
    {
        Console.WriteLine("Wie viele Kästen möchtest du haben?");
        return Convert.ToInt32(Console.ReadLine());
    }

    public Kasten FrageKastenAb(List<Kasten> MeineKastenListe) {
        Console.WriteLine("Was für ein getränk möchtest du haben?");
        
        string EingegebenerName = Console.ReadLine();
        if (ProgrammSafeString(EingegebenerName))
        {
            return MyKasten.findeKasten(EingegebenerName);
        }
        else 
        {
            Console.WriteLine("Dieses Getränk hast du Leider nicht zur Auswahl.");
            Console.WriteLine("Probiere es erneut!");
            FrageKastenAb(MeineKastenListe);    
        }
        return MeineKastenListe[0].KastenType;
    }
    
    public int AbfrageKastenGroeße(int NummerKasten)
    {
        Console.WriteLine("Wie Groß soll der " + (NummerKasten  + 1) + " Kasten sein?");
        MyMain.ListeAlleMöglichkeiten("KastenSize");
        Console.WriteLine("Schreibe die Nummer rein die du haben willst");
        int Nummer = Convert.ToInt32(Console.ReadLine());
        if (ProgrammSafeInt(Nummer))
        {
            return Nummer;
        }
        else
        {
            Console.WriteLine("Probiere es erneut");
            AbfrageKastenGroeße(NummerKasten);
        }
        return 1;
    }

    public int AbfrageKastenArt(int NummerKasten)
    {
        Console.WriteLine("Was für Getränke soll der " + (NummerKasten + 1) + " Kasten haben");
        MyMain.ListeAlleMöglichkeiten("KastenTypesList");
        Console.WriteLine("Schreibe die Nummer rein die du haben willst");
        int Nummer = Convert.ToInt32(Console.ReadLine());
        if (ProgrammSafeInt(Nummer))
        {
            return Nummer;
        }
        else
        {
            Console.WriteLine("Probiere es erneut");
            AbfrageKastenArt(NummerKasten);
        }
        return 1;
    }

    public bool ProgrammSafeInt(int Zahl)
    {
        if (Zahl < 1 || Zahl > 4)
        {
            return false;
        }
        return true;
    }

    public bool ProgrammSafeString(string Name)
    {
        if (vergleicheStringMitNamen(Name))
        {
            return true;
        }
        return false;
    }

    public bool vergleicheStringMitNamen(string Name)
    {
        return Name.Equals("Cola") || Name.Equals("Bier") || Name.Equals("Apfelsaft") || Name.Equals("Wasser");
    }
}

