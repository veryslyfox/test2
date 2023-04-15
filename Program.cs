string a = new("Ifmmp!xpsme\"".Select(c => (char)(c - 1)).ToArray());
Console.WriteLine(a);
Console.ReadKey();