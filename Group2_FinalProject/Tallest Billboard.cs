using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Name: Kazuhide Watanabe, Alex Patton, Alivia Contini
// email: watanake@mail.uc.edu, pattona6@mail.uc.edu, continam@mail.uc.edu
// Assignment Title: Final Project
// Due Date: 04/23
// Course: IS 3050
// Semester/Year: Spring/2024
// Brief Description: This is a class created to later instantiate the Tallest Billboard leetcode problem in the .aspx.cs file. 
// Citations: Chatgpt
// Anything else that's relevant: There are many answers that an AI model can give, but some can be much more wordy compared to others. Some are more efficient than others.

namespace Group2_FinalProject
{
    public class Tallest_Billboard
    {
        public int TallestBillboard(int[] rods)
        {
            int n = rods.Length;
            int sum = 0;
            foreach (int rod in rods)
                sum += rod;

            int[] dp = new int[sum + 1];

            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = -1;
            }

            dp[0] = 0;

            for (int i = 0; i < n; i++)
            {
                int[] currDp = (int[])dp.Clone(); // Copy the dp array to avoid concurrent modification issues
                for (int j = 0; j <= sum - rods[i]; j++)
                {
                    if (dp[j] >= 0)
                    {
                        currDp[j + rods[i]] = Math.Max(currDp[j + rods[i]], dp[j]); // Use the rod on the higher side
                        currDp[Math.Abs(j - rods[i])] = Math.Max(currDp[Math.Abs(j - rods[i])], dp[j] + Math.Min(j, rods[i])); // Use the rod on the lower side
                    }
                }
                dp = currDp;
            }

            return dp[0];
        }
    }
}