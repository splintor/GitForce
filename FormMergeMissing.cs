﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GitForce
{
    public partial class FormMergeMissing : Form
    {
        public FormMergeMissing()
        {
            InitializeComponent();
        }

        /// <summary>
        /// User clicked on a link to a merge utility, open it up in a web browser.
        /// </summary>
        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClassUtils.OpenWebLink((sender as LinkLabel).Tag.ToString());
        }
    }
}
