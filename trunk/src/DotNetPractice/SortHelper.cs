using System;
namespace DotNetPractice
{
    public class SortingHelper
    {
        private int[] m_TargetArray;
        public SortingHelper(int[] targetArray)
        {
            if (null == targetArray || 0 == targetArray.Length)
            {
                throw new ArgumentNullException("'targetArray' should not be null and the length of it should not be 0.");
            }
            m_TargetArray = targetArray;
        }

        public void QuickSort(int targetNum, int targetIndex)
        {
            for (int i = m_TargetArray.Length - 1; i >= targetIndex; i--)
            {
                if (targetNum > m_TargetArray[i])
                {
                    m_TargetArray[targetIndex] = m_TargetArray[i];
                    for (int j = targetIndex + 1; j < i; j++)
                    {
                        if (targetNum < m_TargetArray[j])
                        {
                            m_TargetArray[i] = m_TargetArray[j];
                        }
                    }
                }
            }
        }

        public void QuickSort()
        {
            int targetNum = m_TargetArray[0];
            QuickSort(targetNum, 0);
        }

    }
}
