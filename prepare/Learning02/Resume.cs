
class Resume
{
    private string name;
    private Job job1;
    private Job job2;

    public Resume(string name)
    {
        this.name = name;
        job1 = new Job("The Church of Jesus Christ of Latter-Day Saints", "Volunteer Representative", 2021, 2023);
        job2 = new Job("SAF Guarding", "Pool Monitor", 2021, 2021);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");
        job1.Display();
        job2.Display();
    }
}