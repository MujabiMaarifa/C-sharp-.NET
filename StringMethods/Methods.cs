//removing extra and unnecessary spacing
//trimming words

string greeting = "       Hello World!       ";
string treemed = greeting.Trim();
string start = greeting.TrimStart();
string end = greeting.TrimEnd();

Console.WriteLine(start);
Console.WriteLine(end);
Console.WriteLine(treemed);

string replaced=greeting.Replace("Hello", "Hi");
Console.WriteLine(replaced);

string upper = start.ToUpper();
Console.WriteLine(upper);

string lower=upper.ToLower();
Console.WriteLine(lower);

