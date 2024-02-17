while (true)
{
    string MyMsg = ReadMsg("Введите целое число");
    if (MyMsg == "q")
    {
        return;
    }
    else
    {
        int number = Convert.ToInt32(MyMsg);

        int summOf = SumOfDigits(number);
        Console.Write(summOf);
        bool condition = IsSumEven(summOf);
        if (condition)
        {

            return;
        }
    }


    string ReadMsg(string msg)
    {
        Console.WriteLine(msg);
        return Console.ReadLine();
    }

    int SumOfDigits(int number)
    {
        int sumOf = 0;
        while (number != 0)
        {
            sumOf = sumOf + number % 10;
            number = number/ 10;

        }
        return sumOf;
    }

    bool IsSumEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else { return false; }
    }
}