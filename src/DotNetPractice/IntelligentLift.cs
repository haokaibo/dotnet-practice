using System;

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

        public override string ToString()
        {
            return string.Format("Target floor[{0}], Total floors[{1}]", this.nTargetFloor, this.nMinFloor);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
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

        public BestFloor GetTheBestFloor2()
        {
            BestFloor bf = new BestFloor() { nTargetFloor = 1, nMinFloor = 0 };
            int N1 = 0, N2 = m_PersonTargets[1], N3 = 0;
            for (int i = 2; i <= m_FloorCount; i++)
            {
                N3 += m_PersonTargets[i];
                bf.nMinFloor += m_PersonTargets[i] * (i - 1);
            }
            for (int i = 2; i <= m_FloorCount; i++)
            {
                if (N1 + N2 < N3)
                {
                    bf.nTargetFloor = i;
                    bf.nMinFloor += N1 + N2 - N3;
                    N1 += N2;
                    N2 = m_PersonTargets[i];
                    N3 -= m_PersonTargets[i];
                }
                else
                {
                    break;
                }
            }
            return bf;
        }
    }
}
