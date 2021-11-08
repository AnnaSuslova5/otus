using System;

namespace ConsoleApp1
{
    class TaskTickets : Itask
    {
        int n;
        int count;
        public string Run(string[] data)
        {
            n = int.Parse(data[0]);
            count = 0;
            NextDigits(0, 0, 0);
            //if (data[0] == "3")                return Lucky3().ToString();
            return count.ToString();
        }

        public int Lucky3()
        {
            int count = 0;
            for (int a1 = 0; a1 <= 9; a1++)
                for (int a2 = 0; a2 <= 9; a2++)
                    for (int a3 = 0; a3 <= 9; a3++)
                        for (int b1 = 0; b1 <= 9; b1++)
                            for (int b2 = 0; b2 <= 9; b2++)
                                for (int b3 = 0; b3 <= 9; b3++)
                                    if (a1 + a2 + a3 == b1 + b2 + b3)
                                        count++;
            return count;
        }

        private void NextDigits(int DigitNr, int sum1, int sum2)
        {
            if (DigitNr == n)
            {
                if (sum1 == sum2)
                    count++;
                return;
            }
            for (int a = 0; a <= 9; a++)
                for (int b = 0; b <= 9; b++)
                    NextDigits(DigitNr + 1, sum1 + a, sum2 + b);
        }
    }
}
