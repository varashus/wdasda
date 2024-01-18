List<Iroda> lista = new();


using (var sr = new StreamReader(@"..\..\..\src\irodahaz.txt"))
{
    

    while (!sr.EndOfStream)
    {
        var line = sr.ReadLine();
        var iroda = new Iroda(line);
        lista.Add(iroda);

    }
}


foreach (var item in lista)
{
    Console.WriteLine(item.Kód);
}
Console.ReadLine();


Console.WriteLine();
Console.WriteLine("8.Feladat:");
var max = lista.Max(x => x.Irodak.Count());
Console.WriteLine(max + 1);

Console.WriteLine();
Console.WriteLine("9.Feladat:");
var kilenc = lista.Where(x => x.Irodak.Contains(9));
foreach (var item in kilenc)
{
    Console.WriteLine(item.ToString());
}
Console.WriteLine("10.Feladat:");
var otneltobb = lista.Count(i => i.Irodak.Any(x => x > 5));
Console.WriteLine($"10. {otneltobb} irodában vannak ötnél többen.");

Console.WriteLine("11.Feladat:");
using (var sw = new StreamWriter(@"..\..\..\src\uresIrodak.txt"))
{
    
}

var logmeinAtlagosLetszam = lista.Where(i => i.Kód == "LOGMEIN").SelectMany(i => i.Irodak).Average();
Console.WriteLine($"12. A LOGMEIN kódú cég irodáiban átlagosan {Math.Round(logmeinAtlagosLetszam)} személy dolgozik.");


using (var sw = new StreamWriter(@"..\..\..\src\uresIrodak.txt", true))
{
    sw.WriteLine("\n\n13. Emeleteken dolgozók száma:");

    var emeletiLetszamokCsoportositva = emeletiLetszamok.GroupBy((szemelyek, index) => index / 12 + 1)
                                                       .Select(g => $"{g.Key}. emelet: {g.Sum()} dolgozó");

    foreach (var emelet in emeletiLetszamokCsoportositva)
    {
        sw.WriteLine(emelet);
    }
}
Console.WriteLine("13. Az emeleteken dolgozók száma kiírva a 'uresIrodak.txt' fájlba.");


var osszLetszam = lista.SelectMany(i => i.Irodak).Sum();
Console.WriteLine($"14. Az irodaházban összesen {osszLetszam} fő dolgozik.");




Console.ReadLine();











































//foreach (var iroda in lista)
//{
//    var uresIrodak = iroda.Irodak.Select((szemelyek, index) => new { Szemelyek = szemelyek, IrodaSzam = index + 1 })
//                                 .Where(x => x.Szemelyek == 0)
//                                 .Select(x => $"{iroda.Kód} {x.IrodaSzam}");

//    foreach (var uresIroda in uresIrodak)
//    {
//        sw.WriteLine(uresIroda);
//    }