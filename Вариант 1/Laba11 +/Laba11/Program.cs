string[] word;
StreamReader sr = new("Inlet.txt");
StreamWriter sw = new("Outlet.txt");
string str = sr.ReadToEnd();
sr.Close();
word = str.Split(' ');
int kol = word.Length+1;
sw.WriteLine(kol);
sw.Close();
