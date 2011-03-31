﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace GitForce
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            ClassWinGeometry.Restore(this);

            // Add the version number and the build date from the assembly info file
            labelVersion.Text = "Version " + App.Version;

            Assembly asm = Assembly.GetExecutingAssembly();
            labelBuild.Text = FileVersionInfo.GetVersionInfo(asm.Location).ProductName;

            textLic.Text = 
                "THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR " +
                "IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY," +
                "FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE " +
                "AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER " +
                "LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, " +
                "OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN " +
                "THE SOFTWARE.";
        }

        /// <summary>
        /// Form is closing.
        /// </summary>
        private void FormAboutFormClosing(object sender, FormClosingEventArgs e)
        {
            ClassWinGeometry.Save(this);
        }

        /// <summary>
        /// User clicked on a link label, open a web site
        /// </summary>
        private void LinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((sender as LinkLabel).Tag.ToString());
        }
    }
}
