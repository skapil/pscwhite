using System;
using TestStack.White;
using TestStack.White.UIItems.Finders;
using PSCTest.core;
using pscWindow = TestStack.White.UIItems.WindowItems.Window;
using Application = TestStack.White.Application;

namespace PSCTest.tests
{
    class SampleTest
    {
        public static void Main(string[] args)
        {
            Application launchapp = Setup.launchPSC();
            Application application = Setup.attachPSC();
            pscWindow currentWindow = Setup.getWindow(application);
            Login.loginPSC(currentWindow);
        }
    }
}
