
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using MonefyApp.ClassFiles;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MonefyApp.TestCases.HomePageTestCases
{
    /// <summary>
    /// Description of HomePageTestCases.
    /// </summary>
    [TestModule("21E94F39-FEC4-4C77-946F-B74AC39C388E", ModuleType.UserCode, 1)]
    public class ToValidateNewExpenseIsAddedSuccessfullyByTappingMinusSign : ITestModule
    {
        
        public ToValidateNewExpenseIsAddedSuccessfullyByTappingMinusSign()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Open New Expense page
            HomePage.OpenNewExpensePage();
            
            // Add new expense
            HomePage.AddNewExpenseByTappingMinusSign("200");
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
    
    [TestModule("21E94F39-FEC4-4C77-946F-B74AC39C389E", ModuleType.UserCode, 1)]
    public class ToValidateNewExpenseIsAddedSuccessfullyBySelectingExpenseImageFromHomePage : ITestModule
    {
        
        public ToValidateNewExpenseIsAddedSuccessfullyBySelectingExpenseImageFromHomePage()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Select expense category
            HomePage.SelectCategoryImage();
            
            // Add new expense
            HomePage.AddNewExpenseBySelectingExpenseImage("100");
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
    
    [TestModule("21E94F39-FEC4-4C77-946F-B74AC39C387E", ModuleType.UserCode, 1)]
    public class ToValidateNewIncomeIsAddedSuccessfullyByTappingPlusSign : ITestModule
    {
        
        public ToValidateNewIncomeIsAddedSuccessfullyByTappingPlusSign()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Select expense category
            HomePage.OpenNewIncomePage();
            
            // Add new expense
            HomePage.AddNewIncomeByTappingPlusSign("1000");
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
    
    [TestModule("21E94F39-FEC4-4C77-946F-B74AC39C383E", ModuleType.UserCode, 1)]
    public class ToValidateUserIsAbleToEditExpenseAdded : ITestModule
    {
        
        public ToValidateUserIsAbleToEditExpenseAdded()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Select expense to be edited
            HomePage.SelectExpenseToEdit();
            
            // Edit expense
            HomePage.EditExpense("100");
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
    
    [TestModule("21E94F39-FEC4-4C77-946F-B74AC39C384E", ModuleType.UserCode, 1)]
    public class ToValidateUserIsAbleToEditIncomeAdded : ITestModule
    {
        
        public ToValidateUserIsAbleToEditIncomeAdded()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Select income to be edited
            HomePage.SelectIncomeToEdit();
            
            // Edit income
            HomePage.EditIncome("600");
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
    
    [TestModule("21E94F39-FEC4-4C77-946F-B74AC39C382E", ModuleType.UserCode, 1)]
    public class ValidateLeftMenuOptionsAreDisplayed : ITestModule
    {
        
        public ValidateLeftMenuOptionsAreDisplayed()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Open left menu
            LeftMenu.OpenLeftMenu();
            
            // Validate menu options
            LeftMenu.ValideLeftMenuOptions();
            
            // Close menu
            LeftMenu.CloseLeftMenu();
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
    
    [TestModule("21E94F39-FEC4-4C77-946F-B74AC39C381E", ModuleType.UserCode, 1)]
    public class ToCheckUserIsAbleToDeleteExpenseAdded : ITestModule
    {
        
        public ToCheckUserIsAbleToDeleteExpenseAdded()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Delete expense 
            HomePage.SelectExpenseToDelete();
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
    
    [TestModule("21E94F39-FEC4-4C77-946F-B74AC39C380E", ModuleType.UserCode, 1)]
    public class ToCheckUserIsAbleToDeleteIncomeAdded : ITestModule
    {
        
        public ToCheckUserIsAbleToDeleteIncomeAdded()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Delete income 
            HomePage.SelectIncomeToDelete();
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
    
    [TestModule("21E94F39-FEC4-4C77-946F-B74AC39C385E", ModuleType.UserCode, 1)]
    public class ToCheckBalanceFieldDisplaysIncomeAndExpenseDifference : ITestModule
    {
        
        public ToCheckBalanceFieldDisplaysIncomeAndExpenseDifference()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Get income value from pie chart
            decimal incomeAmt = Convert.ToDecimal(MonefyAppRepository.Instance.MonefyAppElements.HomePage.GreenBalanceAmount.TextValue.Replace("₹", ""));
            Report.Log(ReportLevel.Info, "Income Amount is " +incomeAmt);
            
            // Get expense value from pie chart
            decimal expenseAmt = Convert.ToDecimal(MonefyAppRepository.Instance.MonefyAppElements.HomePage.RedBalanceAmount.TextValue.Replace("₹", ""));
            Report.Log(ReportLevel.Info, "Income Amount is " +expenseAmt);
            
            // Difference between income and expense
            decimal Amt = (incomeAmt-expenseAmt);
            Report.Log(ReportLevel.Info, "The difference of income and expense is " +Amt);
            
            // Get balance amount from home page
            decimal balAmt = Convert.ToDecimal(MonefyAppRepository.Instance.MonefyAppElements.HomePage.BalanceButton.TextValue.Replace("Balance ₹", ""));
            Report.Log(ReportLevel.Info, "Balance Amount visible in pie chart is " +balAmt);
            
            // Validate the difference amount is same as displayed in balance field
            Validate.AreEqual(Amt,balAmt);
            Report.Log(ReportLevel.Info, "Balance amount displayed in pie chart is correct " +balAmt);
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
}
