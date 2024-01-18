using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Iroda
{
    public string Kód { get; set; }
    public string Kezdet { get; set; }
    public List<int> Irodak { get; set; }

    public Iroda(string sor)
    {
        Irodak = new List<int>();
        var tmp = sor.Split(" ");
        Kód = tmp[0];
        Kezdet = tmp[1];
        for (int i = 2; i < tmp.Length; i++)
        {
            Irodak.Add(int.Parse(tmp[i]));
        }
    }

    public override string ToString()
    {
        string returns = $" {Kód}, {Kezdet}, ";
        foreach (var j in Irodak) returns += j + " ";
        return returns;
    }
}

