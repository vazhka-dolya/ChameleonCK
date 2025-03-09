using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using M64MM.Additions;
using M64MM.Utils;
using ChameleonCK.Properties;
using System.Diagnostics;

namespace ChameleonCK
{
    public class Module : IModule
    {
        static mainForm frmMain = new mainForm();

        public string SafeName => "ChameleonCK";

        public string Description => "Easily configurable chroma key.";

        public Image AddonIcon => Resources.cck_logo;

        public void Close(EventArgs e)
        {

        }

        public List<ToolCommand> GetCommands()
        {
            List<ToolCommand> tcl = new List<ToolCommand>();
            ToolCommand tcOpen = new ToolCommand("Open ChameleonCK");
            tcOpen.Summoned += (a, b) => openForm();
            tcl.Add(tcOpen);
            return tcl;
        }

        public void openForm()
        {
            if (frmMain == null || frmMain.IsDisposed)
            {
                frmMain = new mainForm();
            }
            frmMain.Show();
        }

        public void Initialize()
        {
        }

        public void OnBaseAddressFound()
        {
        }

        public void OnBaseAddressZero()
        {
        }

        public void Reset()
        {
        }

        public void Update()
        {
        }

        public void OnCoreEntAddressChange(uint addr)
        {
            // :P
        }
    }
}
