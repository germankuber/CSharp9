using System;

TestResult testResult = new Positive();
//Type patterns

var result = testResult switch 
{
    Positive => "Result positive",
    Negative => "Result negative",
    _ => "I do not know it"
};

//Relational Pattern
var resultRelational = testResult switch 
{
    (<10, true)=> "Newer than 10 days",
    Positive (>10, true)=> "Result positive",
    Negative => "Result negative",
    _ => "I do not know it"
};

//And Pattern

var resultAnd = testResult switch 
{
    Positive and (<10 and >5, _) and { NumberOfTests: >5 }=> "Newer than 10 days",
    (<10 and >5, _)=> "Newer than 10 days",
    Positive (>10, true)=> "Result positive",
    Negative => "Result negative",
    _ => "I do not know it"
};

//Or Pattern

var resultOr = testResult switch 
{
    Positive and (10 or 15, true) or (20, false)=> "",
    Positive (>10, true)=> "Result positive",
    Negative => "Result negative",
    _ => "I do not know it"
};


//Parenthesized Pattern

var resultParenthesized = testResult switch 
{
    Positive and (10 or 15, true) or (Negative and (20, false)) => "",
    Positive (>10, true)=> "Result positive",
    Negative => "Result negative",
    _ => "I do not know it"
};


//Not Pattern

var resultNot= testResult switch 
{
    not (_, true)=> "Result No",
    Negative => "Result negative",
    _ => "I do not know it"
};

public class TestResult{
    public int NumberOfTests { get; set; }
    public bool IsValid { get; set; }
    public DateTimeOffset TestedOn { get; set; }

    public void Deconstruct(out int daysSinceTest, out bool isValid)
    {
        daysSinceTest = (int)(DateTimeOffset.UtcNow - TestedOn).TotalDays;
        isValid = IsValid;
    }
}

public class Negative: TestResult{}
public class Positive: TestResult{}