// See https://aka.ms/new-console-template for more information
enum RegisterMenu
{
    RegisterNewStudent = 1,
    RegisterNewScholar = 2,
    RegisterNewTeacher = 3,
}
enum ChooseMenu
{
    RegisterMenu = 1,
    LoginMenu = 2,
    Exhibitor_statistic = 3
}
class Program
{
    static PersonList personList;
    public static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        InputMenu();
    }
    public static void InputMenuFromKeyboard()
    {
        Console.WriteLine("Welcome Everyone to our Idea camp Registration");
        RegisterPannel();
        ChooseMenu menu = (ChooseMenu)(int.Parse(Console.ReadLine()));
        InputKeyboard();
    }
    public static void InputKeyboard()
    {
        Console.WriteLine("Please Choose your role");
        RolePannel();
        RegisterMenu register = (RegisterMenu)(int.Parse(Console.ReadLine()));
        RoleChooseMenu(register);
    }
    static void ChooseMenuSwtich(ChooseMenu choose)
    {
        switch(choose)
        {
            case ChooseMenu.RegisterMenu:
            InputMenuFromKeyboard();
            break;
            case ChooseMenu.LoginMenu:
            break;
            case ChooseMenu.Exhibitor_statistic:
            break;
        }
    }

    static void RoleChooseMenu(RegisterMenu register)
    {
        switch(register)
        {

            case RegisterMenu.RegisterNewScholar:
            break;    
            case RegisterMenu.RegisterNewStudent:
            break;
            case RegisterMenu.RegisterNewTeacher:
            break;
        }
    }
    
    static void RegisterPannel()
    {
        Console.Clear();
        Console.WriteLine("Choose your Menu");
        Console.WriteLine("********************************");
        Console.WriteLine("1.Register Menu");
        Console.WriteLine("2.Login Menu");
        Console.WriteLine("3.Exhibitor_statistics");
        Console.WriteLine("********************************");
    }
    static void RolePannel()
    {
        Console.Clear();
        Console.WriteLine("Choose your role");
        Console.WriteLine(" 1.Scholar ");
        Console.WriteLine(" 2.Student ");
        Console.WriteLine(" 3.Teacher ");
        Console.WriteLine("********************************");
    }
    static void InputMenu()
    {
        Console.Clear();
        PrintHeaderScholar();
    }
    public static void PrintHeaderStudent()
    {
        Console.Clear();
        Console.WriteLine("Register New Student");
        Console.WriteLine("********************************");
    }
    public static void PrintHeaderScholar()
    {
        Console.Clear();
        Console.WriteLine("Register New Scholar");
        Console.WriteLine("********************************");
    }
    static void PrintHeaderTeacher()
    {
        Console.Clear();
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("********************************");
    }
    public static string ChooseGender()
    {
        Console.WriteLine("Choose your prefix");
        Console.WriteLine("1. Mr.");
        Console.WriteLine("2. Ms.");
        Console.WriteLine("3. Mrs.");
        int Choose = int.Parse(Console.ReadLine());
        return GenderChose(Choose);
    }
    public static string GenderChose(int chooser)
    {
        if(chooser==1)
        {
            return "Mr.";
        }
        else if(chooser == 2)
        {
            return "Ms.";
        }
        else if(chooser == 3)
        {
            return "Mrs.";
        }
        else
        {
            Console.WriteLine("Please Choose again");
            return ChooseGender();
        }
    }
    public static string InputName()
    {
        Console.Write("Please input Name: ");
        return Console.ReadLine();
    }
    public static string InputSurname()
    {
        Console.Write("Please input Surname: ");
        return Console.ReadLine();
    }
    public static string InputScholarId()
    {
        Console.Write("Please input ScholarID:");
        return Console.ReadLine();
    }
    public static string InputstudentId()
    {
        Console.Write("Please input StudentID: ");
        return Console.ReadLine();
    }
    public static string InputAge()
    {
        Console.Write("Please input Age");
        return Console.ReadLine();
    }
    public static string InputLose()
    {
        Console.Write("Please input Lose : ");
        return Console.ReadLine();
    }
    public static string InputSchool()
    {
        Console.Write("Please input School : ");
        return Console.ReadLine();
    }
    public static string InputReligion()
    {
        Console.Clear();
        Console.WriteLine("Please Choose Religion");
        Console.WriteLine("************************************");
        Console.WriteLine("1.Buddhist");
        Console.WriteLine("2.Christian");
        Console.WriteLine("3.Islam");
        Console.WriteLine("4.Other");
        Console.WriteLine("************************************");
        int Chooser = int.Parse(Console.ReadLine());
        return ReligionChose(Chooser);
    }

    public static string ReligionChose(int choose)
    {
        if(choose == 1)
        {
            return "Buddhist";
        }
        else if (choose == 2)
        {
            return "Christian";
        }
        else if (choose == 3)
        {
            return "Islam";
        }
        else if (choose == 4)
        {
            Console.Write("Other:");
            return Console.ReadLine();
        }
        else
        {
            Console.Write("Please Input again: ");
            return InputReligion();
        }
    }
    public static void AddNewPeople()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("1.M/4");
        Console.WriteLine("2.M/5");
        Console.WriteLine("3.M/6");
        Console.Write("Level : ");
        Console.WriteLine("************************************");
    }
    public static string ChooseGeade()
    {
        Console.Clear();
        Console.WriteLine("Please Choose Grade");
        Console.WriteLine("************************************");
        Console.WriteLine("1.Grade 10");
        Console.WriteLine("2.Grade 11");
        Console.WriteLine("3.Grade 12");
        Console.WriteLine("************************************");
        int chooser = int.Parse(Console.ReadLine());
        return GradeInput(chooser);
    }
    public static string GradeInput(int chose)
    {
        if(chose == 1)
        {
            return "Grade 10";
        }
        else if(chose == 2)
        {
            return "Grade 11";
        }
        else if(chose == 3)
        {
            return "Grade 12";
        }
        else if (chose == 4)
        {
            Console.WriteLine("Please choose grade again");
        }return "";
    }
    static bool ConditionCar()
    {
        Console.WriteLine("Do you have car (Y/N) : ");
        char chose = char.Parse(Console.ReadLine());
        return GetCarUse(chose);
    }
    static bool GetCarUse(char chose)
    {
        if(chose == 'Y' || chose == 'y')
        {
            return true;
        }
        else if (chose == 'N' || chose == 'n')
        {
            return false;
        }
        else
        {
            Console.WriteLine("Pardon?");
            return ConditionCar();
        }
    }
    static string Carnum(bool check)
    {
        if(check)
        {
            Console.WriteLine("Your Car registeation:");
            return Console.ReadLine();
        }
        return null;
    }
    static void AddNewpeople()
    {
        Console.Write("Are you admin? (Y/N)");
    }
    static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personList = new PersonList();
    }
}
    
