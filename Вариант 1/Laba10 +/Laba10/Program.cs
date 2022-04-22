using static System.Math; 
StreamReader sr= new("Inlet.txt");
StreamWriter sw = new("Outlet.txt");
int q = 0;
void vvodmas(int n, int i, ref int[] a)
{
    if (i < n)
    {
        a[i] = Convert.ToInt32(sr.ReadLine());
        vvodmas(n, i + 1, ref a);
    }
}
void search(int n, int c, int q, int i, int j, ref int[] a, ref int[] b)
{
    if (Pow(c, j) < n)
    {
        q = Convert.ToInt32(Pow(c, j));
        b[i] = a[q];
        search(n, c, q, i + 1, j + 1, ref a, ref b);
    }
}
static void vyvod(int i, int[] b, ref string strv)
{
    if (i < b.Length)
    {
        if(b[i] == 0)
        {
        }
        else strv += " " + b[i]; 
        vyvod(i + 1, b, ref strv);
    }
}
string str = sr.ReadLine();
string[] num = str.Split(' ');
int n =Convert.ToInt32(num[0]);
int c = Convert.ToInt32(num[1]);
int[] a = new int[n];
int[] b = new int[n];
vvodmas(n, 1, ref a);
search(n, c, q, 1, 0, ref a, ref b);
string str_vyvod = "";
vyvod(0, b, ref str_vyvod);
str_vyvod = str_vyvod.Trim();
sw.Write(str_vyvod);
sr.Close();
sw.Close();

