using System;

class Program
{

    
    static void Main()
    {
        Console.WriteLine("Iveskite skaiciu: ");
        string Skaicius = Console.ReadLine();
        Console.WriteLine(SkaiciusArNe(Skaicius));
    }
    static bool SkaiciusArNe(string Tekstas)
    {
        for (int i = 0; i < Tekstas.Length; i++)
        {
            if (Tekstas[i] != '9' && Tekstas[i] != '8' && Tekstas[i] != '7'  && Tekstas[i] != '6' && Tekstas[i] != '5' && Tekstas[i] != '4' && Tekstas[i] != '3' && Tekstas[i] != '2' && Tekstas[i] != '1' && Tekstas[i] != '0' && Tekstas[i]!= '-'|| Tekstas[0] == '0')
            {
                return false;
            }
        }
        return true;
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
