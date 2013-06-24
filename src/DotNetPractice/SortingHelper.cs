using System;

namespace DotNetPractice
{
    public class SortingHelper
    {
        private int[] m_originArray = { };
        private int[] m_sortedArray = { };

        public int[] QuickSortArray(int[] originArray)
        {
            if (originArray == null)
            {
                throw new ArgumentNullException("originArray", "The param can not be null!");
            }
            if (originArray.Length == 0)
            {
                return originArray;
            }
            m_sortedArray = m_sortedArray = originArray;
            return QuickSortArray(0, originArray.Length - 1);
        }

        private int[] QuickSortArray(int low, int high)
        {
            if (m_sortedArray.Length == 0 || low >= high)
            {
                return m_sortedArray;
            }
            int i = low, j = high;
            for (int key = m_sortedArray[low]; i < j; j--)
            {
                while (key < m_sortedArray[j] && i < j)
                {
                    j--;
                }
                m_sortedArray[i] = m_sortedArray[j];
                m_sortedArray[j] = key;
                while (key > m_sortedArray[i] && i < j)
                {
                    i++;
                }
                m_sortedArray[j] = m_sortedArray[i];
                m_sortedArray[i] = key;
            }

            QuickSortArray(low, i - 1);
            QuickSortArray(i + 1, high);

            return m_sortedArray;
        }

        public int[] InsertionSort(int[] originArray)
        {
            int[] sortedArray = originArray;
            if (null != sortedArray)
            {
                for (int i = 0, arrayLength = sortedArray.Length; i < arrayLength - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        int temp = sortedArray[j];
                        sortedArray[j] = sortedArray[j - 1];
                        sortedArray[j - 1] = temp;
                    }
                }
            }
            return sortedArray;
        }
    }
}
