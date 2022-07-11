Console.WriteLine("Hello, World!");

//startOz("ozymandias");
//startOz("bzoo");
//startOz("oxx");

void startOz(string aString)
{
    if(aString[0] == 'o' && aString[1] == 'z')
    {
        Console.Write(aString[0]);
        Console.WriteLine(aString[1]);
    }
    else if(aString[0] == 'o' && aString[1] != 'z')
    {
        Console.WriteLine(aString[0]);
    }
    else if (aString[0] != 'o' && aString[1] == 'z')
    {
        Console.WriteLine(aString[1]);
    }
    else
    {
        Console.WriteLine(" ");
    }
}


//-----------------------Part2--------------------

//roundSum(12, 11, 11);

void roundSum(int a, int b, int c)
{
    int sum = 0;
    sum = a + b + c;
    if(sum % 10 >= 5)
    {
        Console.WriteLine(roundUp(sum));
    }
    else
    {
        Console.WriteLine(roundDown(sum));
    }
}

int roundUp(int aInt)
{
    int x = aInt % 10;
    int y = 10 - x;
    return aInt + y;
}
int roundDown(int aInt)
{
    int x = aInt % 10;
    return aInt - x;
}

//------------------------Part3--------------------

stringSplosion("Code");

void stringSplosion(string aString)
{
    for(int i = 0; i < aString.Length; i++)
    {
        for(int j = 0; j <= i; j++)
            Console.Write(aString[j]);
    }
}