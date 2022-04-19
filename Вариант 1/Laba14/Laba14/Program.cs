StreamReader sr = new("Inlet.txt");
string[] str = sr.ReadToEnd().Split(new char[] { '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
sr.Close();
int[] mas = new int[str.Length];
for(int i=0; i < str.Length; i++)
{
    mas[i] = Convert.ToInt32(str[i]);
}
StreamWriter sw = new("Outlet.txt");
Array.Sort(mas);
Stack<int> num = new(mas);
Stack<int> num_dop = new(mas);
int razm = num.Count;
num_dop.Pop();
bool have = true;
for (int i = 0; i < razm-1; i++)
{
    int first = num.Pop();
    int second = num_dop.Pop();
    Console.WriteLine($"{first}={second}");
    if (first == second)
    {
        Console.WriteLine("No");
        sw.Write("No");
        have = false;
        break;
    }
}
if (have) sw.Write("Yes");
sw.Close();

