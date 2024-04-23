// Name: Kazuhide Watanabe, Alex Patton, Alivia Contini
// email: watanake@mail.uc.edu, pattona6@mail.uc.edu, continam@mail.uc.edu
// Assignment Title: Final Project
// Due Date: 04/23
// Course: IS 3050
// Semester/Year: Spring/2024
// Brief Description: This is a class created to later instantiate the Number Complement leetcode problem in the .aspx.cs file. 
// Citations: Chatgpt
// Anything else that's relevant: There are many answers that an AI model can give, but some can be much more wordy compared to others. Some are more efficient than others.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group2_FinalProject
{
    public class Number_Complement
    {
        public int FindComplement(int num)
        {
            int mask = 1;
            while (mask < num)
            {
                mask = (mask << 1) | 1;

            }
            return ~num & mask;
        }
    }
}