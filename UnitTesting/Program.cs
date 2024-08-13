int result = CountMaxUnequalSequence("abcc12234!");

Console.WriteLine(result);

static int CountMaxUnequalSequence(string? input)
{
    if (string.IsNullOrEmpty(input)) return 0;

    int currentIndex = 1;

    int maxNumber = 1;

    for (int i = 1; i < input.Length; i++)
    {
        if (input[i] != input[i - 1])
        {
            currentIndex++;
        }

        else
        {
            if (currentIndex > maxNumber)
            {
                maxNumber = currentIndex;
            }
            currentIndex = 1;
        }
    }

    if (currentIndex > maxNumber)
    {
        maxNumber = currentIndex;
    }

    return maxNumber;
}
