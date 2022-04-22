int n = 0;
StreamReader sr = new("Inlet.txt");
string num = sr.ReadLine();
string [] num_mas = num.Split(' ');
int m = 0;
n = Convert.ToInt32(num_mas[0]);
m = Convert.ToInt32(num_mas[1]);    
int i, j;
int [][] mas = new int[n][];
for (i=0; i < n; i++)
    mas[i] = new int[m];
for (i = 0; i < n; i++)
{
    string mat = sr.ReadLine().Trim();
    string [] mat_mas = mat.Split(' ');
    int[] tim = new int[m];
    for (j = 0; j < m; j++)
        tim[j] = Int16.Parse(mat_mas[j]);
    mas[i] =tim;
}
sr.Close();
int b;
int k = 0;
for (i = 0; i < n - 1; i++)
{
    for (k = 0; k < n - 1; k++)
    {
        if (mas[k][0] > mas[k + 1][0])
        {
            for (j = 0; j < m; j++)
            {
                b = mas[k][j];
                mas[k][j] = mas[k + 1][j];
                mas[k + 1][j] = b;
            }
        }
    }
}
StreamWriter sw = new StreamWriter("Outlet.txt");
for (i = 0; i < n; i++)
{
    for (j = 0; j < m; j++)
    {
        sw.Write(mas[i][j] + "\t ");
    }
    sw.WriteLine();
}
sw.Close();
