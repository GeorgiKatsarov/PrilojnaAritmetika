int n = int.Parse(Console.ReadLine());
List<double> listDeviders = Console.ReadLine().Split().Select(double.Parse).ToList();
List<int> list = new List<int>();
List<int> finalList = new List<int>();

for (int i = 1; i <= n; i++)
{
    list.Add(i);
}
for (int i = 0; i < list.Count(); i++)
{
    if (list[i]%listDeviders[0]== 0 && list[i] % listDeviders[1] == 0 && list[i] % listDeviders[2] == 0 && list[i] % listDeviders[3] == 0)
    {
        finalList.Add(list[i]);
    }
}
Console.WriteLine(String.Join(" ", finalList.Distinct()));