
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using WinForms = System.Windows.Forms;
using MonefyApp.ClassFiles;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MonefyApp.TestCases.NewScreenTestCases
{
   
    [TestModule("FA9DA1E1-B393-457E-B2DA-3D2E8F6F4C35", ModuleType.UserCode, 1)]
    public class PerformNewTransfer : ITestModule
    {
        
        public PerformNewTransfer()
        {
            // Do not delete - a parameterless constructor is required!
        }

        
        void ITestModule.Run()
        {
        	// Report
            Report.Log(ReportLevel.Info, "Starting TestCase: " + this.ToString());
            
            // Perform New Transfer
            NewTransferScreen.PerformNewTransfer("100");
            
            // Report
            Report.Log(ReportLevel.Info, "Ending TestCase: " + this.ToString());
        }
    }
}
