using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace HastaneArsiv
{
    public partial class Scanners : Form
    {
        public Scanners()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                if (myPrinters.SetDefaultPrinter(PrinterSettings.InstalledPrinters[i]))
                {//Printer atandıktan sonra o printer e ait olan formlar listelensin. 
                    

                    PrintDocument pD = new PrintDocument();
                    for (int j = 0; j < pD.PrinterSettings.PaperSizes.Count; j++)
                    {
                        
                    }
                }
            }
        }
    }
    public static class myPrinters
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);
    }
}
