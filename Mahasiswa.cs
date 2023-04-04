using System;

public class Mahasiswa
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public address address { get; set; }
    public List<Course> courses { get; set; }

    public Mahasiswa(string firstname, string lastname, string gender, int age, address address, List<Course> courses)
    {
        this.firstName = firstname;
        this.lastName = lastname;
        this.gender = gender;
        this.age = age;
        this.address = address;
        this.courses = courses;
    }

    public Mahasiswa() { }

}

public class address
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }

    public address(string streetaddress, string city, string state)
    {
        this.city = city;
        this.state = state;
        this.streetAddress = streetaddress;
    }

    public address() { }
}

public class Course
{
    public string name { get; set; }
    public string code { get; set; }

    public Course() { }
    public Course(string name, string code)
    {
        this.name = name; 
        this.code = code;
    }
}
