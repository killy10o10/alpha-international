//float score;
//string answer = "YES";
//int totalPasses = 0;
//int totalFails = 0;
//while (answer.Equals("Yes", StringComparison.OrdinalIgnoreCase)) ;
//{
//    Console.WriteLine("Enter student score below:");
//    score = float.Parse(Console.ReadLine());
//    if(score >= 80)
//    {
//        Console.WriteLine($"student scored {score}, they passed!!🥂");
//        totalPasses += 1;
//    }
//    else
//    {
//        Console.WriteLine($"too bad😞 student scored {score}, they failed!");
//        totalFails += 1;
//    }
//    Console.WriteLine("Is there any other student? (yes/no)");
//    answer = Console.ReadLine();
//}

Console.WriteLine("***>>>> Welcome to Alpha Int. school <<<<<***");

List<Student> students = new List<Student>();
List<Tuple<string, double>> failed = new List<Tuple<string, double>>();
List<Tuple<string, double>> passed = new List<Tuple<string, double>>();
string input;

do
{
    Console.WriteLine("Enter student's name: ");
    string name = Console.ReadLine();
    double score;
    do
    {
        Console.WriteLine("Enter the student's score:");
        input = Console.ReadLine();
    }while (!double.TryParse(input, out score));
    students.Add(new Student() { Name = name, Score = score });
    if (score < 80)
    {
        failed.Add(new Tuple<string, double>(name, score));
    }
    else { passed.Add(new Tuple<string, double>(name, score)); }

    Console.WriteLine(("Do you have another student to enter? (yes/no)"));
    input = Console.ReadLine().ToLower();

    while(input != "yes" && input != "no")
    {
        Console.WriteLine("invalid input, Please enter 'yes' or 'no' ");
        input = Console.ReadLine().ToLower();
    }  
}

while (input != "no");

Console.WriteLine("students who failed:");

foreach (var studentName in failed)
{
    Console.WriteLine($"Name: {studentName.Item1}, Score: {studentName.Item2}");
}

Console.WriteLine("Students who passed:");
foreach (var studentName in passed)
{
    Console.WriteLine($"Name: {studentName.Item1}, Score: {studentName.Item2}");
}

class Student
{
    public string Name { get; set; }
    public double Score { get; set; }
}