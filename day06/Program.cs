namespace day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input data
            List<int> lanternFish = new List<int>() { 3, 4, 3, 1, 2, };

            //Counter for the total number of fish withing each daycycle
            long zeroDay = 0;
            long oneDay = 0;
            long twoDay = 0;
            long threeDay = 0;
            long fourDay = 0;
            long fiveDay = 0;
            long sixDay = 0;
            long sevenDay = 0;
            long eightDay = 0;

            //Sets the number of fishes within each daycycle from the input data
            foreach (int day in lanternFish)
            {
                switch (day)
                {
                    case 0:
                        zeroDay += 1;
                        break;
                    case 1:
                        oneDay += 1;
                        break;
                    case 2:
                        twoDay += 1;
                        break;
                    case 3:
                        threeDay += 1;
                        break;
                    case 4:
                        fourDay += 1;
                        break;
                    case 5:
                        fiveDay += 1;
                        break;
                    case 6:
                        sixDay += 1;
                        break;
                    case 7:
                        sevenDay += 1;
                        break;
                    case 8:
                        eightDay += 1;
                        break;
                    default:
                        break;
                }
            }
            //Loops through the days
            for (int i = 0; i < 265; i++)
            {
                //Temporary variables to shift value -1 day
                long zeroTemp = oneDay;
                long oneTemp = twoDay;
                long twoTemp = threeDay;
                long threeTemp = fourDay;
                long fourTemp = fiveDay;
                long fiveTemp = sixDay;
                long sixTemp = sevenDay + zeroDay;
                long sevenTemp = eightDay;
                long eightTemp = zeroDay;

                //Setting the new value to each daycycle
                zeroDay = zeroTemp;
                oneDay = oneTemp;
                twoDay = twoTemp;
                threeDay = threeTemp;
                fourDay = fourTemp;
                fiveDay = fiveTemp;
                sixDay = sixTemp;
                sevenDay = sevenTemp;
                eightDay = eightTemp;
            }
            long totalFish = zeroDay + oneDay + twoDay + threeDay + fourDay + fiveDay + sixDay + sevenDay + eightDay;
            Console.WriteLine(totalFish);
            Console.ReadLine();
        }
    }
}

