// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! First number");

String N1 = Console.ReadLine();

Console.WriteLine("Second number");

string N2 = Console.ReadLine();


string sofNum(string N1)
{
    string f = "";
    foreach (char item in N1)
    {
        if (item > 48 && item < 58)
        {
            f += item;
        }
    }
    return f;
}

string sofAdd(string N1, string N2)
{
    string result="";
    int carry = 0;
    int digit1;
    int digit2;
    int nos = 0;
    int tempresult;

    if (N1.Length > N2.Length)
    {
        nos = N1.Length;
        for (int i = N2.Length;i< nos; i++)
        {
            N2 = "0" + N2 ;
        }
    }
    if (N2.Length > N1.Length)
    {
        nos = N2.Length;
        for (int i = N1.Length; i < nos; i++)
        {
            N1 = "0" + N1;
        }
    }
    Console.WriteLine("-First is " + N1);
    Console.WriteLine("Second is " + N2);

    for (int i = nos -1; i >= 0; i--)
    {
        digit1 = int.Parse(N1[i].ToString());


        digit2 = int.Parse(N2[i].ToString());


        tempresult = digit1 + digit2 + carry;

        if(tempresult > 9)
        {
            carry = tempresult / 10;
            tempresult = tempresult % 10;
        }
        else
        {
            carry = 0;
        }
        result = Convert.ToString(tempresult) + result;
    }

    return result;
}


N1 = sofNum(N1);
N2 = sofNum(N2);



Console.WriteLine("-final is " + sofAdd(N1, N2));
//Console.WriteLine("Second is " + N2);






