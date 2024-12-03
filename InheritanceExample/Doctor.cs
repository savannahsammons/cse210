
class Doctor : Person
{
    private string _tools;
    public Doctor(string firstName, string lastName, int age, string tools) : base(firstName, lastName, age)
    {
        _tools = tools;
    }
    public string GetDoctorInformation()
    {
        return $"Tools: {_tools}, {GetPersonInfo()}";
    }
    public override string GetPersonInfo()
    {
        return $"I am a doctor, my favorite weapon is: {_tools}, My info is: {base.GetPersonStats}";
    }
}