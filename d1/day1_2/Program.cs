using System.Text;

var sum = 0;
try
{
    using var sr = new StreamReader("input.txt");
    while (!sr.EndOfStream)
    {
        var str = new StringBuilder();
        str.Append(sr.ReadLine());
        //replace alphabetic digit with number

        for (var i = 0; i < str.Length; i++)
            switch (str[i])
            {
                case 'o': //one
                    if (str.Length - 3 >= i && str.ToString().Substring(i,3)=="one")
                    {
                        str.Replace('o', '1', i, 1);
                        i += "one".Length - 2;
                    }

                    break;
                case 't': //two 
                    if (str.Length - 3 >= i && str.ToString().Substring(i, 3) == "two")
                    {
                        str.Replace('t', '2', i, 1);
                        i += "two".Length - 2;
                    }
                    //three
                    else if (str.Length - 5 >= i  && str.ToString().Substring(i, 5) == "three")
                    {
                        str.Replace('t', '3', i, 1);
                        i += "three".Length - 2;
                    }

                    break;
                case 'f': //four 
                    if (str.Length - 4 >= i && str.ToString().Substring(i, 4) == "four")
                    {
                        str.Replace('f', '4', i, 1);
                        i += "four".Length - 2;
                    }

                    else if //five 
                        (str.Length - 4 >= i && str.ToString().Substring(i, 4) == "five")
                    {
                        str.Replace('f', '5', i, 1);
                        i += "five".Length - 2;
                    }

                    break;
                case 's': //six
                    if (str.Length - 3 >= i && str.ToString().Substring(i, 3) == "six")
                    {
                        str.Replace('s', '6', i, 1);
                        i += "six".Length - 2;
                    }
                    else if //seven
                        (str.Length - 5 >= i && str.ToString().Substring(i, 5) == "seven")
                    {
                        str.Replace('s', '7', i, 1);
                        i += "seven".Length - 2;
                    }

                    break;
                case 'e': //eight
                    if (str.Length - 5 >= i && str.ToString().Substring(i, 5) == "eight")
                    {
                        str.Replace('e', '8', i, 1);
                        i += "eight".Length - 2;
                    }

                    break;
                case 'n': //nine
                    if (str.Length - 4 >= i && str.ToString().Substring(i, 4) == "nine")
                    {
                        str.Replace('n', '9', i, 1);
                        i += "nine".Length - 2;
                    }

                    break;
            }


        var resultString = new StringBuilder();
        for (var i = 0; i < str.Length; i++)
            if (char.IsNumber(str[i]))
                resultString.Append(str[i]);
        var temp = resultString[0] + resultString[^1].ToString();
        var number = int.Parse(temp);
        sum += number;
    }
}
catch (IOException e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}


Console.WriteLine(sum);