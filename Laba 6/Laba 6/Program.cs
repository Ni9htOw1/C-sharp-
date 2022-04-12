using static System.Math;
double f_Summ(int n, int k, double slag)
{
	double result;
	if (n <= k)
		result = slag + f_Summ(n + 1, k, 1/(Pow(2*n,3)-8*Pow(n,2)+2*n));
	else
		result = 0;
	return result;
}
StreamReader read = new StreamReader("Inlet.txt");
int k;
k = Convert.ToInt32(read.ReadLine());
read.Close();
double summ = 2*f_Summ(1, k, 1/2);
StreamWriter write = new("Outlet.txt");
write.Write(summ);
write.Close();
