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
                if (SkaiciusInt > 19 || SkaiciusInt < -19)
                {
                    NumbersToText20_90(ref SkaiciusZodziais, SkaiciusInt * (-2) + SkaiciusInt);
                    OnesAndTensToText(ref SkaiciusZodziais, (SkaiciusInt * (-2) + SkaiciusInt)%10);
                }
                else
                {
                    OnesAndTensToText(ref SkaiciusZodziais, SkaiciusInt * (-2) + SkaiciusInt);
                }
            }
            else
            {
                SkaiciusInt = StringToInt(SkaiciusString);
                Console.WriteLine(IsNumberInInterval(SkaiciusInt));
                if (SkaiciusInt > 19 || SkaiciusInt < -19)
                {
                    NumbersToText20_90(ref SkaiciusZodziais, SkaiciusInt);
                    OnesAndTensToText(ref SkaiciusZodziais, SkaiciusInt % 10);
                }
                else
                {
                    OnesAndTensToText(ref SkaiciusZodziais, SkaiciusInt);
                }
            }
            Console.WriteLine(SkaiciusZodziais);
            
        }
    }
    static void OnesAndTensToText(ref string Zodziais, int Skaicius)
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
            case 10:
                Zodziais = Zodziais + " desimt";
                break;
            case 11:
                Zodziais = Zodziais + " vienuolika";
                break;
            case 12:
                Zodziais = Zodziais + " dvylika";
                break;
            case 13:
                Zodziais = Zodziais + " trylika";
                break;
            case 14:
                Zodziais = Zodziais + " keturiolika";
                break;
            case 15:
                Zodziais = Zodziais + " penkiolika";
                break;
            case 16:
                Zodziais = Zodziais + " sesiolika";
                break;
            case 17:
                Zodziais = Zodziais +  " septyniolika";
                break;
            case 18:
                Zodziais = Zodziais + " astuoniolika";
                break;
            case 19:
                Zodziais = Zodziais + " devyniolika";
                break;
        }
    }
    static void NumbersToText20_90(ref string Zodziais, int Skaicius)
    {
        switch (Skaicius / 10)
        {
            case 2:
                Zodziais = Zodziais + " dvidesimt";
                break;
            case 3:
                Zodziais = Zodziais + " trisdesimt";
                break;
            case 4:
                Zodziais = Zodziais + " keturiasdesimt";
                break;
            case 5:
                Zodziais = Zodziais + " penkiasdesimt";
                break;
            case 6:
                Zodziais = Zodziais + " sesiasdesimt";
                break;
            case 7:
                Zodziais = Zodziais + " septyniasdesimt";
                break;
            case 8:
                Zodziais = Zodziais + " astuoniasdesimt";
                break;
            case 9:
                Zodziais = Zodziais + " devyniasdesimt";
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
