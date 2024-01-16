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
                    if (str.Length - 3 >= i && str[i + 1] == 'n' && str[i + 2] == 'e')
                    {
                        str.Replace('o', '1', i, 1);
                        i += "one".Length - 2;
                    }

                    break;
                case 't': //two 
                    if (str.Length - 3 >= i && str[i + 1] == 'w' && str[i + 2] == 'o')
                    {
                        str.Replace('t', '2', i, 1);
                        i += "two".Length - 2;
                    }
                    //three
                    else if (str.Length - 5 >= i && str[i + 1] == 'h' && str[i + 2] == 'r' && str[i + 3] == 'e' && str[i + 4] == 'e')
                    {
                        str.Replace('t', '3', i, 1);
                        i += "three".Length - 2;
                    }

                    break;
                case 'f': //four 
                    if (str.Length - 4 >= i && str[i + 1] == 'o' && str[i + 2] == 'u' && str[i + 3] == 'r')
                    {
                        str.Replace('f', '4', i, 1);
                        i += "four".Length - 2;
                    }

                    else if //five 
                        (str.Length - 4 >= i && str[i + 1] == 'i' && str[i + 2] == 'v' && str[i + 3] == 'e')
                    {
                        str.Replace('f', '5', i, 1);
                        i += "five".Length - 2;
                    }

                    break;
                case 's': //six
                    if (str.Length - 3 >= i && str[i + 1] == 'i' && str[i + 2] == 'x')
                    {
                        str.Replace('s', '6', i, 1);
                        i += "six".Length - 2;
                    }
                    else if //seven
                        (str.Length - 5 >= i && str[i + 1] == 'e' && str[i + 2] == 'v' && str[i + 3] == 'e' && str[i + 4] == 'n')
                    {
                        str.Replace('s', '7', i, 1);
                        i += "seven".Length - 2;
                    }

                    break;
                case 'e': //eight
                    if (str.Length - 5 >= i && str[i + 1] == 'i' && str[i + 2] == 'g' && str[i + 3] == 'h' && str[i + 4] == 't')
                    {
                        str.Replace('e', '8', i, 1);
                        i += "eight".Length - 2;
                    }

                    break;
                case 'n': //nine
                    if (str.Length - 4 >= i && str[i + 1] == 'i' && str[i + 2] == 'n' && str[i + 3] == 'e')
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