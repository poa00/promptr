﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace PromptrAddIn
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            MessageBox.Show("AddIn läuft");
            Globals.ThisAddIn.Application.SlideShowBegin += ShowActivePresentation;
            Globals.ThisAddIn.Application.SlideShowNextSlide += Application_SlideShowNextSlide;
            
        }

        private void Application_SlideShowNextSlide(PowerPoint.SlideShowWindow Wn)
        {
            //
        }

        private void ShowActivePresentation(PowerPoint.SlideShowWindow wn)
        {
            MessageBox.Show(Globals.ThisAddIn.Application.ActivePresentation.Name);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}