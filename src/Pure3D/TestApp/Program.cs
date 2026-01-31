using System;

class Program
{
    static void Main()
    {
        var file = new Pure3D.File();
        file.Load("l1r1.p3d");

        PrintHierarchy(file.RootChunk, 0);

        Console.ReadKey();
    }

    static void PrintHierarchy(Pure3D.Chunk chunk, int indent)
    {
        Console.WriteLine("{1}{0}", chunk.ToString(), new string('\t', indent));

        foreach (var child in chunk.Children)
            PrintHierarchy(child, indent + 1);
    }
}