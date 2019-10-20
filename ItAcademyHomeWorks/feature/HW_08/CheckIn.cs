using System;

public class CheckIn
{
    private string locationName;

    public CheckIn(string name) => Name = name;

    public string Name
    {
        get => locationName;
        set => locationName = value;
    }

}
