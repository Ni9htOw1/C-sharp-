using static System.Math;
StreamReader read = new("Inlet.txt");
int n, c;
string num = read.ReadLine();
string [] rnum = num.Split(' ');
n = Convert.ToInt32(rnum[0]);
c = Convert.ToInt32(rnum[1]);
int[] mas_a = new int [n];
int[] mas_b = new int [n];
for(int i=0; i<n; i++)
{
	mas_a[i]= Convert.ToInt32(read.ReadLine());
}
read.Close();
int j = 0;
int q;
int k = 0;
int s = 0;
while (Pow(c, j) <= n)
{
	q = Convert.ToInt32(Pow(c, j));
	mas_b[k] = mas_a[q - 1];
	j++;
	k++;
	s++;
}
StreamWriter write = new("Outlet.txt");
for (int i = 0; i < s; i++)
{
    write.Write(mas_b[i]+" ");
}
write.Close();
