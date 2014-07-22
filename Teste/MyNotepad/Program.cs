using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClsNotepad;

namespace MyNotepad
{
    static class Program
    {

        public static NotesApp MyNoteApp = new NotesApp();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyNotepad());
        }
    }
}