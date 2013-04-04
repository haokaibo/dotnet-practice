
namespace DotNetPractice
{
    class SearchHelper
    {
        private int[] m_TargetArray;
        private int m_TargetArrayLength;
        private int m_SearchNum;
        public SearchHelper(int[] targetArray, int searchNum)
        {
            m_TargetArray = targetArray.Clone() as int[];
            m_SearchNum = searchNum;
            m_TargetArrayLength = m_TargetArray.Length;
        }
        /// <summary>
        /// Search the array by dividend method
        /// </summary>
        /// <param name="lowerBound">The lower bound of the search range</param>
        /// <param name="upperBound">The upper bound of the search range</param>
        /// <returns>The target index of the position where the n should insert.</returns>
        private int DividendSearch(int lowerBound, int upperBound)
        {
            if (m_TargetArrayLength == 0)
            {
                return 0;
            }
            if (lowerBound == upperBound - 1)
            {
                return lowerBound;
            }
            if (m_SearchNum > m_TargetArray[(lowerBound + upperBound) / 2])
            {
                return DividendSearch((lowerBound + upperBound) / 2, upperBound);
            }
            else
            {
                return DividendSearch(lowerBound, (lowerBound + upperBound) / 2);
            }
        }

        public int DividendSearch()
        {
            return DividendSearch(0, m_TargetArrayLength);
        }
    }
}
