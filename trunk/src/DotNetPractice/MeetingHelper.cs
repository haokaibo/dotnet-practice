// Description: The example code for the 1.9 of the Beauty of programming
// Author: Kaibo
// Date: 20130405
using System;
namespace DotNetPractice
{
    public struct Meeting
    {
        public DateTime BeginTime;
        public DateTime EndTime;
        public Meeting(DateTime beginTime, DateTime endTime)
        {
            BeginTime = beginTime;
            EndTime = endTime;
        }
    }

    public class MeetingHelper
    {
        private Meeting[] m_Meetings;
        public MeetingHelper(Meeting[] meetings)
        {
            if (null == meetings || meetings.Length == 0)
            {
                throw new ArgumentNullException("meetings should not be null and there should be more than one meeting in the array.");
            }
            m_Meetings = meetings;
        }

        public int[] GetMinimumMeetRooms()
        {
            int meetingCount = m_Meetings.Length;
            int[] roomNums = new int[meetingCount];
            int[] forbiddenRooms = new int[meetingCount];
            for (int i = 0; i < meetingCount; i++)
            {
                // clear all the forbidden rooms which is occupied by the previous rooms
                for (int j = 0; j < forbiddenRooms.Length; j++)
                {
                    forbiddenRooms[j] = 0;
                }
                // search all the unavailable rooms
                for (int k = 0; k < i; k++)
                {
                    if (m_Meetings[i].BeginTime >= m_Meetings[k].BeginTime && m_Meetings[i].BeginTime < m_Meetings[k].EndTime ||
                        m_Meetings[i].EndTime > m_Meetings[k].BeginTime && m_Meetings[i].EndTime < m_Meetings[k].EndTime)
                    {
                        forbiddenRooms[roomNums[k] - 1] = 1;
                    }
                }
                // try to get the avaiable room
                for (int l = 0; l < forbiddenRooms.Length; l++)
                {
                    if (forbiddenRooms[l] == 0)
                    {
                        roomNums[i] = l + 1;
                        break;
                    }
                }
            }
            return roomNums;
        }
    }
}
