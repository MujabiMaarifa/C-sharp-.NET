
string song="Did I disappoint you or let you down, should i be feeling guilty or let the judges judge";
string judge = "judge";
string _judge = "Amats";
string start = "Did";
string _start="did";
string lower = song.ToLower();

Console.WriteLine($"{song.Length}");
Console.WriteLine(song.Contains(judge));
Console.WriteLine(song.Contains(_judge));
Console.WriteLine(song.StartsWith(start));
Console.WriteLine(lower.StartsWith(_start));
Console.WriteLine(song.EndsWith(judge));
