﻿using System;
using System.Collections.Generic;

namespace P2
{
    class studentStat
    {
        private List<debtStat> student;
        private int totalDebt;

        public int indexMostBurden()
        {
            int maxBurden = 0;
            int most = new int();

            foreach (debtStat element in student)
            {
                int count = 0;
                int curBurden = 0;
                curBurden = student[count].getBurden();

                if (curBurden > maxBurden)
                {
                    maxBurden = curBurden;
                    most = count;
                }
                ++count;
            }

            return most;
        }

        public int numInactive()
        {
            int count = new int();
            count = 0;
            foreach (debtStat element in student)
            {
                int index = 0;
                if (student[index].isActive())
                    ++count;
            }
            return count;
        }

        public int totalBurden()
        {
            int total = new int();
            total = 0;
            foreach (debtStat element in student)
            {
                int index = 0;
                total += student[index].getBurden();
                ++index;
            }
            return total;
        }

        }
    }
}