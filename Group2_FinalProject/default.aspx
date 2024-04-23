<!--
# Name: Kazuhide Watanabe, Alex Patton, Alivia Contini
# email: watanake@mail.uc.edu, pattona6@mail.uc.edu, continam@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 04/23
# Course: IS 3050
# Semester/Year: Spring/2024
# Brief Description: This is the client-side code that provides a user interface for selecting a LeetCode problem and displaying its details when confirmed. 
# Citations: Chatgpt
# Anything else that's relevant: Something interesting we learned to incorporated was some CSS code to make a bullet point (.dot). 
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Group2_FinalProject._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" >
    <title>LeetCode Problems List</title>
    <style>
        .problem-details{
            display: none;
        }
        .paragraph-gap{
            margin-bottom: 18px;
        }
        .dot{
            font-size: 18px;
            color: #000;
            display: inline-block;
            width: 5px;
            height: 5px;
            border-radius: 50%;
            margin-right: 6px;
            background-color: #000;
            vertical-align: middle;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LeetCode Problems List</h1> 
            <div>
                <input type="radio" id="rdoProblem1" name="problem" value="1" />
                <label for="rdoProblem1">Number Complement</label>
            </div>
            <div>
                <input type="radio" id="rdoProblem2" name="problem" value="2" />
                <label for="rdoProblem2">My Calendar 1</label>
            </div>
            <div>
                <input type ="radio" id="rdoProblem3" name="problem" value="3" />
                <label for="rdoProblem3">Tallest Billboard</label>
            </div>
            <br />
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm Problem" OnClick="btnConfirm_Click" />
            <div class="problem-details" id="problemDetailsContainer" runat="server">
                <h2 id="lblProblemTitle" runat="server"></h2>
                <p id="lblProblemDescription" runat="server"></p>
                <p id="lblProblemConstraints" runat="server"></p>   
                <p id="lblSolution" runat="server"></p>
            </div>
        </div>
    </form>
</body>
</html>
