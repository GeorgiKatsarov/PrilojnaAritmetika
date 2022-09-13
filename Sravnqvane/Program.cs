using System.Linq;

List<int> vs = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> newList = vs.OrderBy(x => x % 2 != 0).ThenBy(x => x).ToList();
;
Console.WriteLine(String.Join(" ", newList));