StreamReader sr = new("Inlet.txt");
int n = Convert.ToInt32(sr.ReadLine()); ;
int i, j;
int[][] mas = new int[n][];
for (i = 0; i < n; i++)
    mas[i] = new int[n];
for (i = 0; i < n; i++)
{
    string mat = sr.ReadLine().Trim();
    string[] mat_mas = mat.Split(' ');
    int[] tim = new int[n];
    for (j = 0; j < n; j++)
        tim[j] = Int16.Parse(mat_mas[j]);
    mas[i] = tim;
}
sr.Close();
int k = 0;
bool bl = true;
StreamWriter sw = new StreamWriter("Outlet.txt");
for (i = 0; i < n; i++)
{
    for (k = 0; k < n; k++)
    {
        if (mas[i][k]!=mas[k][i] && bl)
        {
            sw.WriteLine('N');
            bl = false;
            break;
        }
    }
}
if (bl) sw.WriteLine("Y");
sw.Close();
