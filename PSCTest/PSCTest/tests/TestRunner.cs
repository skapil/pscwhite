using System;
using TestStack.White;
using TestStack.White.UIItems.Finders;
using PSCTest.core;
using pscWindow = TestStack.White.UIItems.WindowItems.Window;
using Application = TestStack.White.Application;
using PSCTest.utilities;
using Thread = System.Threading.Thread;

namespace PSCTest.tests
{
    class TestRunner
    {
        //All class variables which will be used in all the tests
        Application launchapp;
        Application application = null;
        static pscWindow currentWindow;
        static SearchPage search = null;
        StandardOperations standard;
        Tabs tabs;

        public TestRunner()
        {
            launchapp = Setup.launchPSC();
            application = Setup.attachPSC();
            currentWindow = Setup.getWindow(application);
            search = new SearchPage(currentWindow);
            standard = new StandardOperations(currentWindow);
            tabs = new Tabs(currentWindow);
        }

    }
}
