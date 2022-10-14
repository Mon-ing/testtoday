class StudentUniversity: Person
{
    private string StudentID;
    private bool Check;
    private string Email;
    private string Password;
    public StudentUniversity(string gender,string name,string surname,int age,string lose,string religious,string StudentID,bool Check,string Email,string Password)
    : base(gender,name,surname,age, lose,religious)
    {
        this.StudentID = StudentID;
        this.Check = false;
        this.Email = Email;
        this.Password = Password;
    }
    public string GetStudentID()
    {
        return this.StudentID;
    }
    public string GetMail()
    {
        return this.Email;
    }
}