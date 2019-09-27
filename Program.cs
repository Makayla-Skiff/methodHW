using System;

namespace methodsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.myhomework();

            prog.Myhomework2(1400, 12);


        }

        public void myhomework()
        {
            Console.WriteLine("Homework is cool");
        }
        public void Myhomework2(float param1f, float param2f)
        {
            var average = param1f / param2f;
            Console.WriteLine(average);
        }
        public void loopmethod(int[] lucky)
        {
            foreach (int i in lucky)
            {
                if (i == 7)
                {
                    Console.WriteLine("i is 7");
                } else 
                    {
                    Console.WriteLine("Lucky You");
                }
            }

        }

    }   
}
