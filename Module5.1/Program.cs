using System;
using System.Collections.Generic;

namespace Module5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Browser myBrowser = new Browser;

            myBrowser.AddPage("www.spotify.com");
            myBrowser.AddPage("www.theChive.com");
            myBrowser.AddPage("www.youtube.com");

            myBrowser.PrintPages();
            myBrowser.UndoPage();
            myBrowser.PrintPages();
        }
    }


    public class Browser
    {
        private Stack<string> PagesStack = new Stack<string>();

    private Stack<string> undoPagesStack = new Stack<string>();

        public void AddPage(string newPage)
        {
            PagesStack.Push(newPage);
        }

        public void PrintPages()
        {
            foreach (var item in PagesStack)
            {
                Console.WriteLine("The page is the following: "
                                  + item);
            }
        }


        public void UndoPage()
        {
            string lastPage = PagesStack.Pop();

            PagesStack.Push(lastPage);
        }

        public void PrintPageAgain()
        {
            foreach (var item in undoPagesStack)
            {
                Console.WriteLine("The page is the following: "
                                  + item);
            }
        }

        public void RedoPage()
        {
            string lastPage = undoPagesStack.Pop();

            PagesStack.Push(lastPage);
        }
    }
}
