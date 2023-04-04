using System.Runtime.CompilerServices;
using System.Text.Json;

public class program
{
    public static Mahasiswa ReadJSON(string filename)
    {
        string posisifolder = ".";
        string LetakFile = File.ReadAllText(posisifolder+"\\"+filename);
        return JsonSerializer.Deserialize<Mahasiswa>(LetakFile);
    }
    
    public static Member readJSON(string filename)
    {
        string posisifolder = ".";
        string hasilbaca = File.ReadAllText(posisifolder + "\\" + filename);
        return JsonSerializer.Deserialize<Member>(hasilbaca);
    }
    
    private static void Main(string[] args)
    {
        Mahasiswa Mhs = ReadJSON("Jurnal7_1_1302210104.json");
        
        Console.WriteLine("Name : " + Mhs.firstName + " " + Mhs.lastName);
        Console.WriteLine("Gender : " + Mhs.gender);
        Console.WriteLine("Umur : " + Mhs.age);
        Console.WriteLine("Alamat : " + Mhs.address.streetAddress + ", " + Mhs.address.city + ", " + Mhs.address.state);
        Console.WriteLine("Courses : ");
        for(int i = 0; i< Mhs.courses.Count; i++)
        {
            Console.WriteLine("Mata Kuliah " + (i + 1) + " : " + Mhs.courses[i].code + " " + Mhs.courses[i].name);
        }
        
        Member Members = readJSON("jurnal7_2_1302213058.json");
        for(int i = 0; i < Members.members.Count; i++)
        {
            Console.WriteLine("Nama Awal: " + Members.members[i].firstName + " Nama akhir: " + Members.members[i].lastName + " Kelamin: " + Members.members[i].gender + " Umur: " + Members.members[i].age + " Nim: " + Members.members[i].nim);
        }
    }
}