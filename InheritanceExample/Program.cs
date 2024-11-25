// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hey bob");
        Person Bob = new ("Bob", "Billy", 37);

        Console.WriteLine(Bob.GetPersonInfo());

        Doctor doctorBob = new Doctor("Bob", "Budge", 37, "Hack Saw");
        Console.WriteLine(doctorBob.GetDoctorInformation());
        Console.WriteLine(doctorBob.GetPersonInfo());

        Police policeDoug = new Police("Doug", "Denver", 40, "Taser");
        Console.WriteLine(policeDoug.GetPoliceInformation());
        Console.WriteLine(policeDoug.GetPersonInfo());
    }
}