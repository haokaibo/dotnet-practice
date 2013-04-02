
using System;
namespace DotNetPractice
{
    class PrefixSorting
    {
        private int m_nCakeCount = 0;
        private int m_nMaxSwap = 0;

        private int[] m_CakeArray; //烙饼信息数组
        int[] m_SwapArray; // 交换结果数组

        int[] m_ReverseCakeArray; // 当前翻转烙饼信息数组
        int[] m_ReverseCakeSwapArray; // 当前翻转烙饼交换结果数组
        int m_nSearch; // 当前搜索次数信息

        public PrefixSorting(int[] cakeArray)
        {
            if (null == cakeArray)
            {
                throw new ArgumentNullException("cakeArray", "Please input a cake array which contains cake!");
            }
            else
            {
                m_CakeArray = cakeArray.Clone() as int[];
                m_nCakeCount = m_CakeArray.Length;

                m_nMaxSwap = UpperBound(m_nCakeCount);

                m_SwapArray = new int[m_nMaxSwap + 1];
                m_ReverseCakeArray = m_CakeArray.Clone() as int[];
                m_ReverseCakeSwapArray = new int[m_nMaxSwap + 1];

            }
        }

        public void Run()
        {
            m_nSearch = 0;
            Search(0);
        }

        public void Output()
        {
            Console.WriteLine("Search Times: {0}", m_nSearch);
            Console.WriteLine("Total Swap Times: {0}", m_nMaxSwap);
            Console.WriteLine("Orgigin Array:");
            Console.Write("\t");
            for (int i = 0; i < m_CakeArray.Length; i++)
            {
                Console.Write("{0} ", m_CakeArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Steps:");
            m_ReverseCakeArray = m_CakeArray.Clone() as int[];
            for (int i = 0; i < m_nMaxSwap; i++)
            {
                Reverse(0, m_SwapArray[i]);
                Console.Write("{0}: \t", m_SwapArray[i]);
                for (int j = 0; j < m_ReverseCakeArray.Length; j++)
                {
                    Console.Write("{0} ", m_ReverseCakeArray[j]);
                }
                Console.WriteLine();
            }
        }

        private int UpperBound(int nCakeCount)
        {
            return nCakeCount * 2;
        }

        private int LowerBound(int[] cakeArray)
        {
            int cakeArrayLen = cakeArray.Length;
            int t, result = 0;
            for (int i = 1; i < cakeArrayLen; i++)
            {
                t = cakeArray[i] - cakeArray[i - 1];
                // The nEstimate algorithm should be refined. The situation that the [8 9 7 6 5 4 3 2 1 0] can not be covered.
                if (t == 1 || t == -1)
                {
                    continue;
                }
                else
                {
                    result++;
                }
            }
            return result;
        }

        bool IsSorted(int[] cakeArray)
        {
            int cakeCount = cakeArray.Length;
            for (int i = 1; i < cakeCount; i++)
            {
                if (cakeArray[i - 1] > cakeArray[i])
                {
                    return false;
                }
            }
            return true;
        }

        void Reverse(int begin, int end)
        {
            if (end > begin)
            {
                for (int i = begin, j = end, t; i < j; i++, j--)
                {
                    t = m_ReverseCakeArray[i];
                    m_ReverseCakeArray[i] = m_ReverseCakeArray[j];
                    m_ReverseCakeArray[j] = t;
                }
            }
        }

        void Search(int step)
        {
            int nEstimate;
            m_nSearch++;

            nEstimate = LowerBound(m_ReverseCakeArray);


            if (step + nEstimate > m_nMaxSwap)
            {
                return;
            }

            if (IsSorted(m_ReverseCakeArray))
            {
                if (step < m_nMaxSwap)
                {
                    m_nMaxSwap = step;
                    for (int i = 0; i < m_nMaxSwap; i++)
                    {
                        m_SwapArray[i] = m_ReverseCakeSwapArray[i];
                    }
                }
                return;
            }

            for (int i = 1; i < m_nCakeCount; i++)
            {
                Reverse(0, i);
                m_ReverseCakeSwapArray[step] = i;
                Search(step + 1);

                Reverse(0, i);
            }
        }

        ~PrefixSorting()
        {
            if (m_CakeArray != null)
            {
                m_CakeArray = null;
            }
            if (m_SwapArray != null)
            {
                m_SwapArray = null;
            }
            if (m_ReverseCakeArray != null)
            {
                m_ReverseCakeArray = null;
            }
            if (m_ReverseCakeSwapArray != null)
            {
                m_ReverseCakeSwapArray = null;
            }
        }
    }
}
