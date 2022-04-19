StreamReader sr = new("Inlet.txt");
int n = Convert.ToInt32(sr.ReadLine());
string[] mas_str = sr.ReadToEnd().Split(new char[] { '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
int j = 0;
sr.Close();
StreamWriter sw = new StreamWriter("Outlet.txt");
for (int i=0; i<n; i++)
{
    string[] str = mas_str[i].Split(' ');
    var result = str.Distinct();
    foreach (string s in result)
    {
        j++;
    }
    sw.WriteLine(j);
    j = 0;
}
sw.Close();
