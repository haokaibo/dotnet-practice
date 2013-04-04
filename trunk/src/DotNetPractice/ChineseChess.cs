namespace DotNetPractice
{

    struct Pos
    {
        public byte a;
        public byte b;
    }
    class ChineseChess
    {


        public void FindOutAllTheUnCheckmatedPos1()
        {
            byte b;
            for (b = 1; b <= 9; b++)
            {
                // 255 - 16 + 1 
                for (b = (byte)(b + 16); (b & 240) >> 4 <= 9; b = (byte)(b + 16))
                {
                    if ((b & 15) % 3 != ((b & 240) >> 4) % 3)
                    {
                        System.Console.WriteLine("A={0}, B={1}", b & 15, ((b & 240) >> 4));
                    }
                }
                b = (byte)(b & 15);
            }

        }

        public void FindOutAllTheUnCheckmatedPos2()
        {
            byte i = 81;
            while (0 != (i--))
            {
                if (i / 9 % 3 == i % 9 % 3)
                {
                    continue;
                }
                else
                {
                    System.Console.WriteLine("A={0}, B={1}", i / 9 + 1, i % 9 + 1);
                }
            }
        }

        public void FindOutAllTheUnCheckmatedPos3()
        {
            Pos p = new Pos();
            for (p.a = 1; p.a <= 9; p.a++)
            {
                for (p.b = 1; p.b <= 9; p.b++)
                {
                    if (p.a % 3 != p.b % 3)
                    {
                        System.Console.WriteLine("A={0}, B={1}", p.a, p.b);
                    }
                }
            }
        }
    }
}
