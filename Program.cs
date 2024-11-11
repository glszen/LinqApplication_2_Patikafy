using LinqApplication_2_Patikafy;

string check = "S";

List<Artists> artists = new List<Artists>() //Artist list has been created.
{
    new Artists
    {
        FirstNameLastName = "Ajda Pekkan",
        Genre = "Pop",
        ReleaseYear = 1968,
        AlbumSales = 20000000,
    },

    new Artists
    {
        FirstNameLastName = "Sezen Aksu",
        Genre = "Türk Halk Müziği/Pop",
        ReleaseYear = 1971,
        AlbumSales = 10000000,
    },

    new Artists
    {
        FirstNameLastName = "Funda Arar",
        Genre = "Pop",
        ReleaseYear = 1999,
        AlbumSales = 3000000,
    },

    new Artists
    {
        FirstNameLastName = "Sertab Erener",
        Genre = "Pop",
        ReleaseYear = 1994,
        AlbumSales = 5000000,
    },

    new Artists
    {
        FirstNameLastName = "Sıla",
        Genre = "Pop",
        ReleaseYear = 2009,
        AlbumSales = 3000000,
    },

    new Artists
    {
        FirstNameLastName = "Serdar Ortaç",
        Genre = "Pop",
        ReleaseYear = 1994,
        AlbumSales = 10000000,
    },

    new Artists
    {
        FirstNameLastName = "Tarkan",
        Genre = "Pop",
        ReleaseYear = 1992,
        AlbumSales = 40000000,
    },

    new Artists
    {
        FirstNameLastName = "Hande Yener",
        Genre = "Pop",
        ReleaseYear = 1999,
        AlbumSales = 7000000,
    },

    new Artists
    {
        FirstNameLastName = "Hadise",
        Genre = "Pop",
        ReleaseYear = 2005,
        AlbumSales = 5000000,
    },

    new Artists
    {
        FirstNameLastName = "Gülben Ergen",
        Genre = "Pop/Türk Halk Müziği",
        ReleaseYear = 1997,
        AlbumSales = 10000000,
    },

    new Artists
    {
        FirstNameLastName = "Neşet Ertaş",
        Genre = "Pop/Türk Sanat Müziği",
        ReleaseYear = 1960,
        AlbumSales = 2000000,
    },

};

var FilterName = artists.Where(artist => artist.FirstNameLastName.StartsWith("S")).ToList(); //Singers whose names start with 'S'.

foreach (var filter in FilterName)
{
        Console.WriteLine("Singer whose names start with 'S':  " + filter.FirstNameLastName);
}

Console.WriteLine("\n-------------------\n");

var FilterSales = artists.Where(artist => artist.AlbumSales > 10000000).ToList(); //Singers with album sales over 10 million.

foreach (var filter2 in FilterSales)
{
        Console.WriteLine("Singer with album sales over 10 million: " + filter2.FirstNameLastName);
}

Console.WriteLine("\n-------------------\n");

var FilterYearGroup = artists.GroupBy(artist => artist.ReleaseYear < 2000); //Singers who debuted before 2000 and made pop music. (Alphabetical)

foreach (var filter3 in FilterYearGroup)
{
   foreach (var artist in filter3.OrderBy(artist => artist.FirstNameLastName))
    {
        Console.WriteLine(artist.FirstNameLastName + " " + artist.ReleaseYear);
    }
}

Console.WriteLine("\n-------------------\n");
    
var MaxSales = artists.Max(artist => artist.AlbumSales); //Best selling singer.

foreach (var artist in artists.Where(x => x.AlbumSales == MaxSales))
{
    Console.WriteLine("Best selling singer: " + artist.FirstNameLastName + ", " + "Sales amount: " + MaxSales);
}

Console.WriteLine("\n-------------------\n");

var NewRelease = artists.Max(artist => artist.ReleaseYear); //Newest release singer.

foreach (var artist in artists.Where(x => x.ReleaseYear == NewRelease))
{
    Console.WriteLine("Newest release singer: " + artist.FirstNameLastName + ", " + "Release Year: " + NewRelease);
}

Console.WriteLine("\n-------------------\n");

var OldRelease = artists.Min(artist => artist.ReleaseYear); //Oldest release singer.

foreach (var artist in artists.Where(x => x.ReleaseYear == OldRelease))
{
    Console.WriteLine("Oldest release singer: " + artist.FirstNameLastName + ", " + "Release Year: " + OldRelease);
}
