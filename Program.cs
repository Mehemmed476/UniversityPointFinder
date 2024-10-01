float gpa = 76.5f;

switch (gpa)
{
    case float n when (n >= 51f && n < 61f):
        Console.WriteLine("E");
        break;
    case float n when (n >= 61f && n < 71f):
        Console.WriteLine("D");
        break;
    case float n when (n >= 71f && n < 81f):
        Console.WriteLine("C");
        break;
    case float n when (n >= 81f && n < 91f):
        Console.WriteLine("B");
        break;
    case float n when (n >= 91f && n <= 100f):
        Console.WriteLine("A");
        break;
    default:
        Console.WriteLine("you are disqualified");
        break;
}