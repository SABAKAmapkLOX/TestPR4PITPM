namespace TestLib
{
    public class Tasks
    {
        public static List<int> TaskOne()
        {
            List<int> numberList = new List<int>();
            for (int i = 1000; i <= 9999; i++)
            {
                int numberOne = i / 1000;
                int numberTwo = (i % 1000) / 100;
                int numberThree = (i % 100) / 10;
                int numberFour = i % 10;
                if (numberOne != numberTwo && numberTwo != numberThree && numberThree != numberFour)
                {
                    numberList.Add(i);
                }
            }
            return numberList;
        }
        public static List<int> TaskTwo()
        {
            List<int> numberList = new List<int>();
            int number = 0;
            for (int numberOne = 0; numberOne <= 9; numberOne++)
            {
                for (int numberTwo = 0; numberTwo <= 9; numberTwo++)
                {
                    if (numberOne != numberTwo)
                    {
                        for (int numberThree = 0; numberThree <= 9; numberThree++)
                        {
                            if (numberThree != numberTwo && numberThree != numberOne)
                            {
                                for (int numberFour = 0; numberFour <= 9; numberFour++)
                                {
                                    if (numberFour != numberThree && numberThree != numberTwo && numberTwo != numberOne)
                                    {
                                        number = numberOne * 1000 + numberTwo * 100 + numberThree * 10 + numberFour;
                                        numberList.Add(number);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return numberList;
        }
    }
}
