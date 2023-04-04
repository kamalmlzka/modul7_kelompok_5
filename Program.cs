using System.Text.Json;

public class program
{
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
    }

    public static Mahasiswa ReadJSON(string filename)
    {
        string posisifolder = ".";
        string LetakFile = File.ReadAllText(posisifolder+"\\"+filename);
        return JsonSerializer.Deserialize<Mahasiswa>(LetakFile);
    }
}
