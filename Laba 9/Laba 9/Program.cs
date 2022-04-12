StreamReader sr = new("Inlet.txt");
string text = sr.ReadToEnd();
sr.Close();
string[] word_i_str = text.Split(new char[] { ' ', '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
int i = word_i_str.Length-1;
int k = Convert.ToInt32(word_i_str[i]);
int kol = 0;
for (int j = 0; j < i; j++)
{
    char[] word = word_i_str[j].ToCharArray();
    if (word.Length >= k)
    {
        kol++;
    }
}
if (kol == 0) kol = -1;
StreamWriter sw = new("Outlet.txt");
sw.Write(kol);
sw.Close();
