// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Text.Json;

public class program
{
    public static Member readJSON(string filename)
    {
        string posisifolder = ".";
        string hasilbaca = File.ReadAllText(posisifolder + "\\" + filename);
        return JsonSerializer.Deserialize<Member>(hasilbaca);
    }

    private static void Main(string[] args)
    {
        Member Members = readJSON("jurnal7_2_1302213058.json");
        for(int i = 0; i < Members.members.Count; i++)
        {
            Console.WriteLine("Nama Awal: " + Members.members[i].firstName + " Nama akhir: " + Members.members[i].lastName + " Kelamin: " + Members.members[i].gender + " Umur: " + Members.members[i].age + " Nim: " + Members.members[i].nim);
        }
    }
}
 