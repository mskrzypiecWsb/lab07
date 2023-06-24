DateTime aktualnyCzas = DateTime.Now;
int godziny = aktualnyCzas.Hour;
int minuty = aktualnyCzas.Minute;
int sekundy = aktualnyCzas.Second;

int czasWSekundach = liczCzasWSekundach(godziny, minuty, sekundy);
string czas = liczCzas(czasWSekundach);
Console.WriteLine(czas);

    static int liczCzasWSekundach(int godziny, int minuty, int sekundy)
{
    int czasWSekundach = (godziny * 3600) + (minuty * 60) + sekundy;
    return czasWSekundach;
}

static string liczCzas(int czasWSekundach)
{
    int godziny = czasWSekundach / 3600;
    int minuty = (czasWSekundach % 3600) / 60;
    int sekundy = czasWSekundach % 60;

    string czas = godziny.ToString("D2") + ":" + minuty.ToString("D2") + ":" + sekundy.ToString("D2");
    return czas;
}