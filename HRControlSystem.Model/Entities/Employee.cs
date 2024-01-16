namespace HRControlSystem.Model.Entities;

public class Employee : Base
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Department { get; set; }
    public DateTime HiringTime { get; set; }
    public DateTime BirthDate { get; set; }
    public bool MilitaryStatus { get; set; }
    public bool IsActive { get; set; }
}