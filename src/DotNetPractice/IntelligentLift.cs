using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetPractice
{
    public struct BestFloor
    {
        public BestFloor(int targetFloor, int minFloor)
        {
            nTargetFloor = targetFloor;
            nMinFloor = minFloor;
        }
        public int nTargetFloor;
        public int nMinFloor;
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is BestFloor)
            {
                return this.Equals((BestFloor)(obj));
            }
            else
                return false;
        }
        public bool Equals(BestFloor right)
        {
            if (this.nMinFloor == right.nMinFloor && this.nTargetFloor == right.nTargetFloor)
            {
                return true;
            }
            return false;
        }
    }

    public class IntelligentLift
    {
        private int m_FloorCount = 0;
        private int[] m_PersonTargets;

        /// <summary>
        /// The constructor of the IntelligentLift
        /// </summary>
        /// <param name="N">Floor count</param>
        /// <param name="personTargets">The count of the person who go to the target floor</param>
        public IntelligentLift(int N, int[] personTargets)
        {
            m_FloorCount = N;
            m_PersonTargets = personTargets as int[];
        }

        public BestFloor GetTheBestFloor1()
        {
            BestFloor bf = new BestFloor() { nTargetFloor = -1 };

            int personTargetCount = m_PersonTargets.Length;
            for (int i = 1; i <= m_FloorCount; i++)
            {
                int nFloor = 0;
                for (int j = 1; j < personTargetCount; j++)
                {
                    nFloor += Math.Abs((j - i) * m_PersonTargets[j]);
                }
                if (bf.nTargetFloor == -1 || nFloor < bf.nMinFloor)
                {
                    bf.nTargetFloor = i;
                    bf.nMinFloor = nFloor;
                }
            }
            return bf;
        }

        public BestFloor GetTheBestFloor2(){
            return new BestFloor();
        }
    }
}
