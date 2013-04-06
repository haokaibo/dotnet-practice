using System;
namespace DotNetPractice
{
    public class SortHelper
    {
        private int[] m_TargetArray;
        private int[] m_SortedArray;
        public SortHelper(int[] targetArray)
        {
            if (null == targetArray || 0 == targetArray.Length)
            {
                throw new ArgumentNullException("'targetArray' should not be null and the length of it should not be 0.");
            }
            m_TargetArray = targetArray;
            m_SortedArray = m_TargetArray.Clone() as int[];
        }

        private void QuickSort(int beginIndex, int endIndex)
        {
            if (beginIndex >= endIndex)
            {
                return;
            }
            int targetNum = m_SortedArray[beginIndex];
            int i, j;
            for (i = endIndex; i > beginIndex; i--)
            {
                if (m_SortedArray[i] < targetNum)
                {
                    m_SortedArray[beginIndex] = m_SortedArray[i];
                    m_SortedArray[i] = targetNum;
                    break;
                }
            }
            for (j = beginIndex + 1; j < endIndex; j++)
            {
                if (m_SortedArray[j] > targetNum)
                {
                    m_SortedArray[i] = m_SortedArray[j];
                    m_SortedArray[j] = targetNum;
                    break;
                }
            }
            if (j >= i)
            {
                QuickSort(beginIndex, i - 1);
                QuickSort(i + 1, endIndex);
            }
            else
                QuickSort(j, i);
        }

        public int[] QuickSort()
        {
            QuickSort(0, m_SortedArray.Length - 1);
            return m_SortedArray;
        }

    }
}
