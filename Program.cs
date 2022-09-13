using System.Linq;




List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
string input = Console.ReadLine();
while (input != "end")
{
    switch (input)
    {
        case "add":
            for (int i = 0; i < ints.Count(); i++)
            {
                ints[i] += 1;
            }
            break;
        case "multiply":
            for (int i = 0; i < ints.Count(); i++)
            {
                ints[i] *= 2;
            }
            break;
        case "substract":
            for (int i = 0; i < ints.Count(); i++)
            {
                ints[i] -= 1;
            }
            break;
        case "print":
            Console.WriteLine(String.Join(" ", ints));
            break;
        default:
            break;
    }
    input = Console.ReadLine();
}