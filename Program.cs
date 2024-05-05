namespace task2;

class Program
{

    public static List<int> FindCommonDivisors(int[] numbers) {

        List<int> dividers = new() { }; 
        bool checker = true;

        for (int i = 2; i <= numbers.Min(); i++) {

            for (int j = 0; j < numbers.Length; j++) {

                if (numbers[j] % i != 0) {

                    checker = false;
                    break;
                }
            }

            if (!checker) {
                checker = true;
                continue;
            }
            else {
                dividers.Add(i);
            }
        }

        return dividers;
    }

    static void Main(string[] args)
    {

        int[] numbers = {12, 24, 36};

        List<int> dividers = FindCommonDivisors(numbers);

        foreach (var item in dividers)
        {
            Console.Write(item + " ");
        }

    }
}
