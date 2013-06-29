using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPractice
{
    public class ForumHelper
    {
        private int[] m_IdList;
        public ForumHelper(int[] idList)
        {
            m_IdList = idList;
        }

        public int FindForumBestInvolver()
        {
            int candidate = 0, nTimes = 0;
            for (int i = 0, listLength = m_IdList.Length; i < listLength; i++)
            {
                if (nTimes == 0)
                {
                    candidate = m_IdList[i];
                    nTimes = 1;
                }
                else
                {
                    if (candidate == m_IdList[i])
                        nTimes++;
                    else
                        nTimes--;
                }
            }
            return candidate;
        }
    }
}
