using System;
using TestStack.White;
using pscWindow = TestStack.White.UIItems.WindowItems.Window;
using TestStack.White.UIItems.Finders;
using TextBox = TestStack.White.UIItems.TextBox;
using Button = TestStack.White.UIItems.Button;

namespace PSCTest.core
{
    class Input
    {
        //This method Type the value which passed to this method
        public static void Type(TestStack.White.UIItems.WindowItems.Window window, string elementid, string value)
        {
            try
            {
                TextBox textbox = window.Get<TextBox>(SearchCriteria.ByAutomationId(elementid));
                textbox.Text = value;
            }
            catch (Exception e)  {
                try
                {
                    TextBox textbox = window.Get<TextBox>(SearchCriteria.ByText(elementid));
                    textbox.Text = value;
                }
                catch (Exception e1)
                {
                    try
                    {
                        TextBox textbox = window.Get<TextBox>(SearchCriteria.ByClassName(elementid));
                        textbox.Text = value;
                    }
                    catch (Exception e3)
                    {
                        Console.WriteLine("Not able to find the element");
                    }
                }

             }
         }

        //This method select perticular button on the page
        public static void Select(TestStack.White.UIItems.WindowItems.Window window, string elementid)
        {
            try
            {
                Console.WriteLine("Trying to access the element using automation id");
                Button button = window.Get<Button>(SearchCriteria.ByAutomationId(elementid));
                button.Click();
            }
            catch (Exception e)    {
                try {
                    Console.WriteLine("Trying to access the element using Name of element");
                    Button button = window.Get<Button>(SearchCriteria.ByText(elementid));
                    button.Click();
                }
                catch (Exception e1)  {
                    try {
                        Console.WriteLine("Trying to access the element using ClassName id");
                        Button button = window.Get<Button>(SearchCriteria.ByClassName(elementid));
                        button.Click(); }
                    catch (Exception e2) {
                        Console.WriteLine("Not able to find out the element id");  }
                      }
              } 
        } 
    }
}

