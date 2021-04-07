
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using MonefyApp.ClassFiles;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MonefyApp.TestCases.RightMenuOptionsTestCases
{
    /// <summary>
    /// Description of RightMenuOptionsTestCases.
    /// </summary>
    [TestModule("7E207F5A-8121-42EB-B56C-0AA6A8EB30A3", ModuleType.UserCode, 1)]
    public class ValidateRightMenuOptions : ITestModule
    {
        
        public ValidateRightMenuOptions()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Open right side menu
            RightMenu.OpenAndCloseRightMenu(true,false);
            
            // Validate right hand side menu options
            RightMenu.ValidateRightHandSideMenuItems();
            
            // Close right side menu
            RightMenu.OpenAndCloseRightMenu(false,true);
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
    
    [TestModule("7E207F5A-8121-42EB-B56C-0AA6A8EB30A4", ModuleType.UserCode, 1)]
    public class ToVerifyUserIsAbleToAddNewAccountDetails : ITestModule
    {
        
        public ToVerifyUserIsAbleToAddNewAccountDetails()
        {
            // Do not delete - a parameterless constructor is required!
        }
        
        void ITestModule.Run()
        {
            // Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Open right side menu
            RightMenu.OpenAndCloseRightMenu(true,false);
            
            // Open New Account Page
            RightMenu.OpenNewAccountPage();
            
            // Add account details
            RightMenu.AddNewAccountDetails("Test", "500");
                       
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
}
