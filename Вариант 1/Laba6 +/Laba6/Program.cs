double f_Summ(int n, int k, double bas, double slag)
{
	double result;
	if (n <= k)
		result = slag + f_Summ(n + 1, k, bas, slag / bas);
	else
		result = 0;
	return result;
}
StreamReader read = new StreamReader("Inlet.txt");
int k;
k = Convert.ToInt32(read.ReadLine());
read.Close();
Console.WriteLine(k);
double summ = f_Summ(0, k, 2, 1) / f_Summ(0, k, 3, 1);
FileStream fout = new(@"D:\Учёба\C#\Laba6\Outlet.txt", FileMode.Open);
StreamWriter write = new(fout);
write.Write(summ);
write.Close();

