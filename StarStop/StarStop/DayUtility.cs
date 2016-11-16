using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarStop
{
    class DayUtility
    {
        static public int[] calculateDays(DateTime startDay, DateTime endDay, List<DateTime> holidayList)
        {
            int[] week = { 0, 0, 0, 0, 0, 0, 0 };
            DateTime now = startDay.Date;
            DateTime then = endDay.AddDays(1).Date;
            for(; !now.Equals(then); now = now.AddDays(1))
            {
                if (!holidayList.Contains(now))
                {
                    week[(int)now.DayOfWeek]++;
                }
            }
            return week;
        }

        static public void updateDays(DateTime startDay, DateTime endDay, List<DateTime> holidayList)
        {
            int[] dayCount = DayUtility.calculateDays(startDay, endDay, holidayList);
            for (int i = 0; i < Program.mainForm.days.Length; i++)
            {
                Program.mainForm.days[i].Text = dayCount[i+1].ToString();
                Program.mainForm.nights[i].Text = dayCount[i+1].ToString();
            }
        }
    }
}
