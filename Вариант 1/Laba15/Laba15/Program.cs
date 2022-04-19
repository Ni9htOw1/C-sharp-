StreamReader sr = new("Inlet.txt");
int n = Convert.ToInt32(sr.ReadLine());
int[] mass = new int[n * 2];
double[] mass_queue = new double[n];
string[] str = sr.ReadLine().Split(' ');
sr.Close();
for (int i = 0; i < n * 2; i++)
{
    mass[i] = Convert.ToInt32(str[i]); 
}
for (int j = 0; j < n; j++)
{
    mass_queue[j] = mass[j] + mass[n * 2 - (j+1)];
}
Queue<double> elem = new(mass_queue);
StreamWriter sw = new("Outlet.txt");
foreach(int i in elem) sw.WriteLine(i);
sw.Close();




