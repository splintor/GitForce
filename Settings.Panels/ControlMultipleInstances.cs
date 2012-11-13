using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitForce.Settings.Panels
{
    public partial class ControlMultipleInstances : UserControl, IUserSettings
    {
        public ControlMultipleInstances()
        {
            InitializeComponent();
        }

        public void Init(string[] config)
        {
            chkWarnMultipleInstances.Checked = Properties.Settings.Default.WarnMultipleInstances;
        }

        public void Focus(bool focused)
        {
        }

        public void ApplyChanges()
        {
            Properties.Settings.Default.WarnMultipleInstances = chkWarnMultipleInstances.Checked;
        }
    }
}
