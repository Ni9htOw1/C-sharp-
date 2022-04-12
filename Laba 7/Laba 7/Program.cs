StreamReader read = new("Inlet.txt");
int n = Convert.ToInt32(read.ReadLine()); ;
int[] mas_a = new int[n];
for (int i = 0; i < n; i++)
{
	mas_a[i] = Convert.ToInt32(read.ReadLine());
}
read.Close();
int k=0;
for (int i = 0; i < n; i++)
{
	if (mas_a[i]%2==1) k++;
}
StreamWriter write = new("Outlet.txt");
write.WriteLine(k);
write.Close();

