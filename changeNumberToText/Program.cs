using System;

class Program
{

    
    static void Main()
    {
        string SkaiciusZodziais="";
        int SkaiciusInt;
        Console.WriteLine("Iveskite skaiciu: ");
        string SkaiciusString = Console.ReadLine();
        if (SkaiciusArNe(SkaiciusString))
        {
            if (SkaiciusString[0] == '-')
            {
                SkaiciusZodziais = "minus";
                SkaiciusInt = StringToInt(SkaiciusString);
                Console.WriteLine(IsNumberInInterval(SkaiciusInt));
                OnesToText(ref SkaiciusZodziais, SkaiciusInt*(-2)+SkaiciusInt);
            }
            else
            {
                SkaiciusInt = StringToInt(SkaiciusString);
                Console.WriteLine(IsNumberInInterval(SkaiciusInt));
                OnesToText(ref SkaiciusZodziais, SkaiciusInt);
            }
            Console.WriteLine(SkaiciusZodziais);
            
        }
    }
    static void OnesToText(ref string Zodziais, int Skaicius)
    {
        switch (Skaicius)
        {
            case 0:
                Zodziais = Zodziais + " nulis";
                break;
            case 1:
                Zodziais= Zodziais + " vienas";
                break;
            case 2:
                Zodziais = Zodziais + " du";
                break;
            case 3:
                Zodziais = Zodziais + " trys";
                break;
            case 4:
                Zodziais = Zodziais + " keturi";
                break;
            case 5:
                Zodziais = Zodziais + " penki";
                break;
            case 6:
                Zodziais = Zodziais + " sesi";
                break;
            case 7:
                Zodziais = Zodziais + " septyni";
                break;
            case 8:
                Zodziais = Zodziais + " astuoni";
                break;
            case 9:
                Zodziais = Zodziais + " devyni";
                break;
        }
    }

    static bool SkaiciusArNe(string Tekstas)
    {
        for (int i = 0; i < Tekstas.Length; i++)
        {
            if (Tekstas[i] != '9' && Tekstas[i] != '8' && Tekstas[i] != '7'  && Tekstas[i] != '6' && Tekstas[i] != '5' && Tekstas[i] != '4' && Tekstas[i] != '3' && Tekstas[i] != '2' && Tekstas[i] != '1' && Tekstas[i] != '0' && Tekstas[0]!= '-'|| Tekstas[0] == '0')
            {
                Console.WriteLine("Bloga ivestis");
                return false;
            }
        }
        return true;
    }
    static int StringToInt(string Skaicius)
    {
        return Convert.ToInt32(Skaicius);
    }
    static bool IsNumberInInterval(int Skaicius)
    {
        if(Skaicius>=-9 && Skaicius <= 9)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
 }

   
    //Skaiciai zodziais:  
    // "minus"; 
    // "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni"; 
    // "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika"; 
    // "dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt", "astuoniasdesimt", "devyniasdesimt"; 
    // "simtas", "tukstantis", "milijonas", "milijardas"; 
    // "simtai", "tukstanciai", "milijonai", "milijardai"; 
    // "simtu", "tukstanciu", "milijonu", "milijardu"; 
