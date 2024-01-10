using System.Text;

var sum = 0;
try
{
    using var sr = new StreamReader("input.txt");
    while (!sr.EndOfStream)
    {
        var tempString = sr.ReadLine();
        var resultString = new StringBuilder();
        for (var i = 0; i < tempString!.Length; i++)
            if (char.IsNumber(tempString[i]))
                resultString.Append(tempString[i]);
        var temp = resultString[0] + resultString[^1].ToString();
        var number = int.Parse(temp);
        sum += number;
    }

    Console.WriteLine(sum);
}
catch (IOException e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}