StreamReader reader = File.OpenText("Program.cs");
while (true)
{
    var s = reader.ReadLine();
    if (s == null)
    {
        break;
    }
    Console.WriteLine(s);
}
Console.ReadKey();