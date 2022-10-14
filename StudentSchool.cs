class StudentSchool: Person
{
    private bool HaveCars;
    private string School;
    public StudentSchool(string gender,string name,string surname,int age,string lose,string religious,string studentID,bool check,string Email,string password)
     : base(gender,name,surname,age, lose,religious)
    {
        this.HaveCars = HaveCars;
        this.School = School;
    }
    public string Getschool()
    {
        return this.School;
    }
    public bool GetHaveCars()
    {
        return this.HaveCars;
    }

}    