// Name: Kazuhide Watanabe, Alex Patton, Alivia Contini
// email: watanake@mail.uc.edu, pattona6@mail.uc.edu, continam@mail.uc.edu
// Assignment Title: Final Project
// Due Date: 04/23
// Course: IS 3050
// Semester/Year: Spring/2024
// Brief Description: This is a class created to later instantiate the MyCalendar leetcode problem in the .aspx.cs file. 
// Citations: Chatgpt
// Anything else that's relevant: There are many answers that an AI model can give, but some can be much more wordy compared to others. Some are more efficient than others.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group2_FinalProject
{
    public class MyCalendar
    {
        private List<int[]> bookedEvents;
        public MyCalendar()
        {
            bookedEvents = new List<int[]>();
        }

        public bool Book(int start, int end)
        {
            if (start < 0 || start >= end || end > Math.Pow(10, 9))
                return false;

            foreach (var evt in bookedEvents)
            {
                if (evt[0] < end && start < evt[1])
                {
                    return false;
                }
            }

            bookedEvents.Add(new int[] { start, end });
            bookedEvents.Sort((a, b) => a[0].CompareTo(b[0]));
            return true;
        }
    }
}    