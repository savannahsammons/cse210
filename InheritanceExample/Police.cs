
class Police : Person
{
    private string _weapons;
    public Police(string firstName, string lastName, int age, string weapons) : base(firstName, lastName, age)
    {
        _weapons = weapons;
    }
    public string GetPoliceInformation()
    {
        return $"Tools: {_weapons}, {GetPersonInfo()}";
    }

    public override string GetPersonInfo()
    {
        return $"I am a policeman, my favorite weapon is: {_weapons}, My info is: {base.GetPersonStats}";
    }
}