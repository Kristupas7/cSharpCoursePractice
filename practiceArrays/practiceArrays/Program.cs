using System;


class Program
{
    static void Main()
    {
        int[] Skaicius;
        int[] Skaicius2;
        for (int i = 100000; i < 200000; i++)
        {
            Skaicius = NumberToArray(i);
            Skaicius2 = NumberToArray(i * 2);
            if (AreNumbersDifferent(Skaicius) && AreNumbersDifferent(Skaicius2) && MasyvuPanasumas(Skaicius, Skaicius2))
            {
                Skaicius2 = NumberToArray(i * 3);
                if (MasyvuPanasumas(Skaicius, Skaicius2))
                {
                    Skaicius2 = NumberToArray(i * 4);
                    if (MasyvuPanasumas(Skaicius, Skaicius2))
                    {
                        Skaicius2 = NumberToArray(i * 5);
                        if (MasyvuPanasumas(Skaicius, Skaicius2))
                        {
                            Skaicius2 = NumberToArray(i * 6);
                            if (MasyvuPanasumas(Skaicius, Skaicius2))
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                }
            }
        }
    }
    static bool AreNumbersDifferent(int[] eile)
    {
        for (int i = 0; i < eile.Length; i++)
        {
            for (int j = i + 1; j < eile.Length; j++)
            {
                if (eile[i] == eile[j])
                {
                    return false;
                }

            }
        }
        return true;
    }
    static int[] NumberToArray(int Sk)
    {
        int[] gdp = new int[6];
        gdp[0] = Sk / 100000;
        gdp[1] = Sk % 100000 / 10000;
        gdp[2] = Sk % 10000 / 1000;
        gdp[3] = Sk % 1000 / 100;
        gdp[4] = Sk % 100 / 10;
        gdp[5] = Sk % 10;
        return gdp;
    }
    static bool MasyvuPanasumas(int[] eile, int[] eile2)
    {
        int Kiek = 0;
        for (int i = 0; i < eile.Length; i++)
        {
            Kiek = 0;
            for (int j = 0; j < eile2.Length; j++)
            {
                if (eile[i] == eile2[j])
                {
                    Kiek++;
                }
            }
            if (Kiek != 1)
            {
                return false;
            }
        }
        return true;
    }



}

