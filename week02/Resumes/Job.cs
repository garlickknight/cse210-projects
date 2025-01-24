using System.ComponentModel.DataAnnotations;

public class Job 
{
    public string _jobTitle ="";
    public int _startYear = 0;
    public int _endYear = 0;
    public string _company = "";

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}