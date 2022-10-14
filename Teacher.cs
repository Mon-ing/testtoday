class Teacher: Person
{
    private string studentID;
    public Teacher(string gender,string name,string surname,int age,string lose,string religious,bool admistrator)
    :base(gender,name,surname,age,lose,religious)
    {
        this.studentID = studentID;
    }
    public string GetStudentID()
    {
        return this.studentID;
    }
}