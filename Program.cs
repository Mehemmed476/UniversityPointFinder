float gpa = 83.5f;

switch (gpa)
{
    case float n when (n >= 51.0f && n < 61.0f):
        Console.WriteLine("E");
        break;
    case float n when (n >= 61.0f && n < 71.0f):
        Console.WriteLine("D");
        break;
    case float n when (n >= 71.0f && n < 81.0f):
        Console.WriteLine("C");
        break;
    case float n when (n >= 81.0f && n < 91.0f):
        Console.WriteLine("B");
        break;
    case float n when (n >= 91.0f && n <= 100.0f):
        Console.WriteLine("A");
        break;
    default:
        Console.WriteLine("you are disqualified");
        break;
}