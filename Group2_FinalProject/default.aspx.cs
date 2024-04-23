using System;
// Name: Kazuhide Watanabe, Alex Patton, Alivia Contini
// email: watanake@mail.uc.edu, pattona6@mail.uc.edu, continam@mail.uc.edu
// Assignment Title: Final Project
// Due Date: 04/23
// Course: IS 3050
// Semester/Year: Spring/2024
// Brief Description: This is the server-side code that manages the functionality of the asp.net web form page, including handling user interactions, displaying problem details, invoking solutions, and presenting the solution results.  
// Citations: Chatgpt
// Anything else that's relevant: We learned how to add different html styling such as the indents and dots we created in the CSS styling. 

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group2_FinalProject
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

            }
        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            int selectedProblemId;
            if (int.TryParse(Request.Form["problem"], out selectedProblemId))
            {
                problemDetailsContainer.Style["display"] = "block";

                ShowProblemDetails(selectedProblemId);

                DisplaySolution(selectedProblemId);
            }
        }

        private void ShowProblemDetails(int problemId)
        {
            switch (problemId)
            {
                case 1:
                    lblProblemTitle.InnerHtml = "Number Complement <span style='color: #0D9276; '>(Easy)</span>";
                    lblProblemDescription.InnerHtml = "<strong>Description:</strong><p class='paragraph-gap'>&emsp; The complement of an integer is the integer you get when you flip all the 0's and 1's and all the 1's to 0's in its binary representation. Given an integer num, return <i>its complement</i>.</p>";
                    lblProblemConstraints.InnerHtml = "<strong>Constraints:</strong><br>&emsp; <span class='dot'></span> 1 <= num < 2^31";
                    break;
                case 2:
                    lblProblemTitle.InnerHtml = "My Calendar 1 <span style='color: #FFB534;'>(Medium)</span>";
                    lblProblemDescription.InnerHtml = "<strong>Description:</strong><p class='paragraph-gap'>&emsp; You are implementing a program to use as your calendar. We can add a new event if adding the new event will not cause a double booking.</p><p class='paragraph-gap'>&emsp; A double booking happens when two events have some non-empty intersection (i.e., some moment is common to both events.)</p><p class='paragraph-gap'>&emsp; The event can be represented as a pair of integers start and end that represents as a pair of integers start and end that represents a booking on the half-open interval [start, end), the range of real numbers x such taht start <= x < end.</p><p class='paragraph-gap'>&emsp; Implement the MyCalendar class:<br>&emsp;&emsp; <span class='dot'></span>MyCalendar() Initializes the calendar object.<br>&emsp;&emsp; <span class='dot'></span>boolean book(int start, int end) Returns true if the event can be added to the calendar successfully without causing a double booking. Otherwise, return false and do not add the event to the calendar.</p>";
                    lblProblemConstraints.InnerHtml = "<strong> Constraints:</strong><br>&emsp; <span class='dot'></span> 0 <= start < end <= 10^9<br>&emsp; <span class='dot'></span> At most 1000 calls will be made to book.";
                    break;
                case 3:
                    lblProblemTitle.InnerHtml = "Tallest Billboard <span style='color: #B31312;'>(Hard)</span>";
                    lblProblemDescription.InnerHtml = "<strong>Description:</strong><p class='paragraph-gap'>&emsp; You are installing a billboard and want it to have the largest height. The billboard will have two steel supports, one on each side. Each steel support must be equal height.</p><p class='paragraph-gap'>&emsp; You are given a collection of rods that can be welded together. For example, if you have rods of lengths 1, 2, and 3, you can weld them together to make a support of length 6.</p><p class='paragraph-gap'>&emsp; Return <i>the largest possible height of your billboard installation</i>. If you cannot support the billboard, return 0.</p>";
                    lblProblemConstraints.InnerHtml = "<strong> Constraints:</strong><br>&emsp; <span class='dot'></span> 1 <= rods.length <= 20<br>&emsp; <span class='dot'></span> 1 <= rods[i] <= 1000<br>&emsp; <span class='dot'></span> sum(rods[i]) <= 5000";
                    break;
                default:
                    break;
            }
        }

        private void DisplaySolution(int problemId)
        {
            switch (problemId)
            {
                case 1:
                    Solution1();
                    break;
                case 2:
                    Solution2();
                    break;
                case 3:
                    Solution3();
                    break;
                default:
                    break;
            }
        }

        private void Solution1()
        {
            Number_Complement solution = new Number_Complement();
            int num = 5;
            int complement = solution.FindComplement(num);

            lblSolution.InnerHtml = $"<strong>Test Case:</strong><br>&emsp;Input: num = {num}<br>&emsp;Solution: {complement}</br>";
        }
        private void Solution2()
        {
            MyCalendar calendar = new MyCalendar();

            var testCases = new List<(int start, int end)>
            {
                (0, 0),
                (10, 20),
                (15, 25),
                (20, 30)
            };

            StringBuilder solutionHtml = new StringBuilder();
            foreach (var testCase in testCases)
            {
                bool isBookingSuccessful = calendar.Book(testCase.start, testCase.end);
                solutionHtml.Append($"&emsp;&emsp;Booking for ({testCase.start}, {testCase.end}) is successful: {isBookingSuccessful} <br/>");
            }

            lblSolution.InnerHtml = $"<strong>Test Case:</strong><br>&emsp;Input: [(,), (10,20), (15,25), (20,30)] <br>&emsp;Solutions:<br>" + solutionHtml.ToString();
        }

        private void Solution3()
        {
            Tallest_Billboard solution = new Tallest_Billboard();

            int[] rods = { 1, 2, 3, 4, 5, 6 };

            int result = solution.TallestBillboard(rods);

            string testCaseInput = string.Join(",", rods);

            lblSolution.InnerHtml = $"<strong>Test Case:</strong><br>&emsp;Input: rods = ({testCaseInput})<br>&emsp;Solution: {result}<br>";
        }

    }
}