StreamReader sr = new StreamReader("Inlet.txt");
StreamWriter sw = new StreamWriter("Outlet.txt");
string tabl = sr.ReadToEnd();
string[] str = tabl.Split('\n', System.StringSplitOptions.RemoveEmptyEntries);
int kol_students = str.Length/2;
Student[] group = new Student[kol_students];
string[] surname = new string[kol_students]; ;
int fio = 0, igr = 1, j=0;
string[] gr_str;
int[] gr;
for (int i = 0; i < kol_students; i++)
{
    surname[i] = str[fio].Trim();
    fio += 2;
}
Array.Sort(surname);
for (int number = 0; number < kol_students; number++)
{
    group[number].Surname = surname[j];
    j++;
    gr_str = str[igr].Trim().Split(' ');
    igr += 2;
    gr = new int[5];
    for (int i = 0; i < 5; i++)
    {
        gr[i] = int.Parse(gr_str[i]);
    }
    group[number].Results = gr;
}
int kol = 0;
for (int i = 0; i < group.Length - 1; i++)
{
    kol += !group[i].Neud ? 1 : 0;
}
kol += !group[group.Length - 1].Neud ? 1 : 0;
foreach (Student студент in group)
{
    sw.WriteLine(студент.Surname);
}
sw.Write(kol);
sw.Close();
struct Student
{
    string FIO;
    int[] grads;
    public string Surname
    {
        get
        {
            return FIO;
        }
        set
        {
            FIO = value;
        }
    }
    public int[] Results
    {
        set
        {
            grads = new int[5];
            grads = value;
        }
    }
    public bool Neud
    {
        get
        {
            bool have = false;
            foreach (int grad in grads)
            {
                have = have || grad < 4;
            }
            return have;
        }
    }
}


