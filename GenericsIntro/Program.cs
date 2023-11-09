//4. Gün

using GenericsIntro;

MyList<String> isimler = new MyList<String>();
isimler.Add("Engin");

Console.WriteLine(isimler.Length);

isimler.Add("Kerem");

Console.WriteLine(isimler.Length);

foreach (var item in isimler.Items)
{
    Console.WriteLine(item);
}