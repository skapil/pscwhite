using System;
using TestStack.White;
using TestStack.White.UIItems.Finders;
using PSCTest.core;
using pscWindow = TestStack.White.UIItems.WindowItems.Window;
using Application = TestStack.White.Application;
using PSCTest.utilities;
using Thread = System.Threading.Thread;
using NUnit.Framework;


namespace PSCTest.tests
{
    class AddPatientTest : TestRunner
    {
       /* //SampleTEst Class Variables
        Application launchapp;
        Application application = null;
        static pscWindow currentWindow;
        static SearchPage search = null;
        StandardOperations standard;
        Tabs tabs; */

        //SampleTest Class Constructor to launch PSC and get the current window of PSC
        public void SetupTest()
        {
            Super();
            /*launchapp = Setup.launchPSC();
            application = Setup.attachPSC();
            currentWindow = Setup.getWindow(application);
            search = new SearchPage(currentWindow);
            standard = new StandardOperations(currentWindow);
            tabs = new Tabs(currentWindow);*/
        } 

        public void A_LoginPSC()
        {
            Login.loginPSC(currentWindow);
            Thread.Sleep(5000);
            Screenshot screen = new Screenshot();
        }

        public void B_Search()
        {
            search.SearchPatient(1);
            Thread.Sleep(5000);
            if (search.IsSearchEmpty())
            {
                Console.WriteLine("Not able to search the patient, So adding the patient");
                search.AddNewPatient();
            }
            else
            {
                Console.WriteLine("Patient Found");
                search.SelectFirstSearchRecord();
            }
        }
        
 /*       public static void Main(string[] args)
        {
            SampleTest test = new SampleTest();
            Login.loginPSC(currentWindow);
            Thread.Sleep(5000);
            Screenshot screen = new Screenshot();
            screen.GetScreenshot("temp.png");
            search.SearchPatient(1);
            Thread.Sleep(5000);
            bool flag = search.IsSearchEmpty();
            if (flag == true)
            {
                Console.WriteLine("Not able to search the patient, So adding the patient");
                search.AddNewPatient();
                test.ProvideNewPatientInformation();
            }
            else if (flag == false)
            {
                Console.WriteLine("Patient Found");
                search.SelectFirstSearchRecord();
            }
            //test.InputAdditionInfo();
            //test.AddGuardianInformation();
            //test.PerformOperations();
            //test.AddInsuranceInfo();
            //test.AddNewPatient(); 
        }

        public void InputAdditionInfo()
        {
            AdditionalInfoPage aip = new AdditionalInfoPage(currentWindow);
            standard.Next();
            Thread.Sleep(5000);
            aip.ProvideMailingAddress(1);
            Thread.Sleep(2000);
           // aip.SameAsMailingAddress("No");
           // aip.ProvideBillingAddress(1);
            
        }

        public void AddInsuranceInfo()
        {
            for (int i = 0; i < 10; i++)
                standard.Back();

            Thread.Sleep(5000);
            AdditionalInfoPage aip = new AdditionalInfoPage(currentWindow);            
            Thread.Sleep(2000);
            aip.AddInsurance(1);
        }

        public void AddGuardianInformation()
        {
            //standard.Next();
            standard.Next();
            Thread.Sleep(5000);
            AdditionalInfoPage aip = new AdditionalInfoPage(currentWindow);
            //aip.AddGuardian(1);
            aip.AddEmergencyContact(1);
            Thread.Sleep(1000);
            standard.Delete();
            Thread.Sleep(2000);
            standard.Ok();
            //standard.Delete();
        }

        public void PerformOperations()
        {            
            //StandardOperations standard = new StandardOperations(currentWindow);
            Thread.Sleep(5000);
            tabs.Dashboard();
            Thread.Sleep(5000);
            standard.Cancel();
            Thread.Sleep(5000);
            tabs.Dashboard();
            Thread.Sleep(5000);
            standard.Ok();           
            Console.ReadLine();
        }*/

        public void C_AddNewPatientInformation()
        {
            Thread.Sleep(5000);
            BasicInfoPage bip = new BasicInfoPage(currentWindow);
            bip.ProvideBasicInformation(9);
            Thread.Sleep(2000);
            standard.Save();
        }
    }
 }


