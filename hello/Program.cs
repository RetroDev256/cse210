Console.Write("Input a number: ");
string inp = Console.ReadLine();
int inp_int = int.Parse(inp);

string prefix = $"The number: {inp} is ";
string suffix;
if (inp_int > 0) {
    suffix = "more than zero.";
} else if (inp_int < 0) {
    suffix = "less than zero.";
} else {
    suffix = "equal to zero.";
}

Console.WriteLine($"{prefix}{suffix}");