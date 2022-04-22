StreamReader sr = new("Inlet.txt");
string text = sr.ReadToEnd();
sr.Close();
string[] str = text.Split('\n','\r', System.StringSplitOptions.RemoveEmptyEntries);
int i = str.Length-1;
string[] search_word = new string[i];
char lit = char.Parse(str[i]);
for (int j = 0; j < i; j++)
{
    string[] word_i_str = str[j].Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
    if (word_i_str.Length > 1)
    {
        search_word[j] = word_i_str[word_i_str.Length - 2];
    }
    else
        search_word[j] = "";
}
int k = -1;
foreach (string word in search_word)
    if (word == "") // Ничего делать не надо
    {
    }
    else // Подсчет букв
    {
        if (k == -1) k = 0;
        foreach (char word_lit in word)
            k += lit == word_lit ? 1 : 0;
    }
StreamWriter sw = new("Outlet.txt");
sw.Write(k);
sw.Close();

