//membuat class List untuk mengakses json dan mengakses class Members
public class Member
{
	public List<Members> members { get; set; }

    public Member(List<Members> members)
    {
        this.members = members;
    }
}
//membuat class members untuk pengimplementasian code dari json 
public class Members
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
    //membuat konstruktor bertipe, untuk memenuhi kebutuhan class 
    public Members(string firstName, string lastName, string gender, int age, string nim)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.age = age;
        this.nim = nim;
    }
    //membuat konstruktor default untuk meminimalisir error code
    public Members() { }
}
