int lenght = int.Parse(Console.ReadLine());
List<string> list = Console.ReadLine().Split().ToList();
for (int i = 0; i < list.Count; i++)
{
    if (list[i].Length > lenght)
    {
        list.Remove(list[i]);
    }
    else
    {
        Console.WriteLine(list[i]);
    }
}