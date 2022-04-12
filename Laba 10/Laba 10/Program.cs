StreamReader sr = new("Inlet.txt");
StreamWriter sw = new("Outlet.txt");
int n = Convert.ToInt32(sr.ReadLine());
void vvodmas(int n, int i, ref int[] a)
{
    if (i < n)
    {
        a[i] = Convert.ToInt32(sr.ReadLine());
        vvodmas(n, i + 1, ref a);
    }
}
int f = 0;
void search(int i, int f1, int f2, int k, ref int[] a, ref int[] b)
{
    if(f <= n)
    {
        f = f1 + f2;
        if (f == i)
        {
            b[k] = a[i];
            k++;
            if (f1 <= f2) f1 = f;
            else f2 = f;  
            Console.WriteLine(f);
        }
        search(i+1, f1, f2, k, ref a, ref b);   
    } 
}
static void vyvod(int i, int[] b, ref string strv)
{
    if (i < b.Length)
    {
        if (b[i] == 0)
        {
        }
        else strv += " " + b[i];
        vyvod(i + 1, b, ref strv);
    }
}
int[] c = new int[n];
int[] a = new int[n];
int[] b = new int[n];
vvodmas(n, 1, ref a);
search(1, 0, 1, 0, ref a, ref b);
string str_vyvod = "";
vyvod(0, b, ref str_vyvod);
str_vyvod = str_vyvod.Trim();
sw.Write(str_vyvod);
sr.Close();
sw.Close();

