using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Monon
{

    public partial class FormMain : Form
    {

        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            // Legacy flag, should not be used.
            // ES_USER_PRESENT = 0x00000004
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        public FormMain()
        {
            InitializeComponent();
        }

        private void keepOnSw_CheckedChanged(object sender, EventArgs e)
        {
            prevent_screensaver(keepOnSw.Checked);
        }

        private void prevent_screensaver(bool sw)
        {
            if (sw) 
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS);
            }
            else
            {
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            keepOnSw.Checked = true;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            prevent_screensaver(false);
        }

    }
}
