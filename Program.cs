using System;

namespace IlbizGoTask
{
    public class Ilbiz
    {
        public int Height;
        public int Go = 5;
        public int Back = 4;
        public int Day = 0;

        public int GetIlbiz(int height)
        {
            Height = height;
            int sum = 0;

            while (sum < Height)
            {
                sum += Go;
              
                Day++;

                if (sum >= Height)
                    break;
                sum -= Back;
            }

            return Day;
        }

        static void Main(string[] args)
        {
            Ilbiz ilbiz = new Ilbiz();
            Console.WriteLine(ilbiz.GetIlbiz(20));//15+5 metr   15+1//gun
        }
    }
}
