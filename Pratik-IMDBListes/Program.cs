using Pratik_IMDBListes;

List<Film> films = new List<Film>();

bool devamet = true;
while (devamet)
{
    Console.Write("Film adı: ");
    string filmAdi = Console.ReadLine();

    Console.Write("IMDb puanı: ");
    double imdbPuani;
    while (!double.TryParse(Console.ReadLine(), out imdbPuani))
    {
        Console.WriteLine("Geçerli bir IMDb puanı girin: ");
    }
    Film yeniFilm = new Film(filmAdi, imdbPuani);
    films.Add(yeniFilm);

    Console.Write("Yeni bir film eklemek ister misiniz? (evet/hayır): ");
    string cevap = Console.ReadLine().ToLower();
    if (cevap== "evet")
    {
        
    }
    else if (cevap == "hayır")
    {
        devamet = false;
    }
}
Console.WriteLine("\nBütün filmler:");
foreach (var film in films)
{
    Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
}
Console.WriteLine("\nIMDb puanı 4 ile 9 arasında olan filmler:");
var filtrelenmisFilmler = films.Where(f => f.ImdbPuani >= 4 && f.ImdbPuani <= 9);
foreach (var film in filtrelenmisFilmler)
{
    Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
}


Console.WriteLine("\nİsmi 'A' ile başlayan filmler:");
var aIleBaslayanFilmler = films.Where(f => f.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase));
foreach (var film in aIleBaslayanFilmler)
{
    Console.WriteLine($"Film: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
}