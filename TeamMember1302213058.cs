
public class Member
{
	public List<Members> members { get; set; }

    public Member(List<Members> members)
    {
        this.members = members;
    }
}

public class Members
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }

    public Members(string firstName, string lastName, string gender, int age, string nim)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.age = age;
        this.nim = nim;
    }
    public Members() { }
}
