﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitForce.Settings.Panels
{
    public partial class ControlStatus : UserControl, IUserSettings
    {
        public ControlStatus()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize pertinent settings
        /// </summary>
        /// <param name="options">All git global settings</param>
        public void Init(string[] options)
        {
            checkBoxShowGitCommands.Checked = Properties.Settings.Default.logCommands;
            checkBoxShowTimestamp.Checked = Properties.Settings.Default.logTime;
            checkBoxUse24HourClock.Checked = Properties.Settings.Default.logTime24;
        }

        /// <summary>
        /// Control received a focus (true) or lost a focus (false)
        /// </summary>
        public void Focus(bool focused)
        {
        }

        /// <summary>
        /// Apply changed settings
        /// </summary>
        public void ApplyChanges()
        {
            Properties.Settings.Default.logCommands = checkBoxShowGitCommands.Checked;
            Properties.Settings.Default.logTime = checkBoxShowTimestamp.Checked;
            Properties.Settings.Default.logTime24 = checkBoxUse24HourClock.Checked;
        }
    }
}
