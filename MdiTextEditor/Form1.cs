using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiTextEditor
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //this creates a new window, which will be a child form
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var child = new ChildForm();
            child.MdiParent = this;
            child.Show();
        }

        //this exits out of the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //this resets the color of the font to the normal color, 
        //so that more than one color wont be selected
        private void ClearColor()
        {
            blackToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            purpleToolStripMenuItem.Checked = false;
            pinkToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
        }

        //This resets the check for the font size so
        //more than one font size wont be selected
        private void ClearFontSize()
        {
            toolStripMenuItem8.Checked = false;
            toolStripMenuItem10.Checked = false;
            toolStripMenuItem12.Checked = false;
            toolStripMenuItem14.Checked = false;
            toolStripMenuItem16.Checked = false;
            toolStripMenuItem18.Checked = false;
        }

        //this resets the check for the font style so
        //more than one font style wont be selected
        private void ClearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            microsoftSansSerifToolStripMenuItem.Checked = false;
            arialToolStripMenuItem.Checked = false;
            courierNewToolStripMenuItem.Checked = false;
        }

        //this will give the windows a cascade sort
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }


        //this will make it sorted horizontally
        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }


        //This will make it so the windows will be sorted vertically
        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //This will close out each individual window without closing the app
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to close.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //this will set the active child font editor
        //to have black font
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearColor();
                ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Black;
                blackToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have yellow font
        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearColor();
                ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Yellow;
                yellowToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have red font
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearColor();
                ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Red;
                redToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have blue font
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearColor();
                ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Blue;
                blueToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have green font
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearColor();
                ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Green;
                greenToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have orange font
        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearColor();
                ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Orange;
                orangeToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have purple font
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearColor();
                ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Purple;
                purpleToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have pink font
        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearColor();
                ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Pink;
                pinkToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have 8 point font size
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        //this will set the active child font editor
        //to have 10 point font size
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        //this will set the active child font editor
        //to have 12 point font size
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearFontSize();
                ActiveMdiChild.Controls["richTextBox1"].Font = new Font(ActiveMdiChild.Controls["richTextBox1"].Font.Name, int.Parse(sender.ToString()));
                ((ToolStripMenuItem)sender).Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have 14 point font size
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        //this will set the active child font editor
        //to have 16 point font size
        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }

        //this will set the active child font editor
        //to have 18 point font size
        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {

        }

        //this will set the active child font editor
        //to have Times New Roman font style
        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearFont();
                ActiveMdiChild.Controls["richTextBox1"].Font = new Font("Times New Roman", ActiveMdiChild.Controls["richTextBox1"].Font.Size);
                timesNewRomanToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have Microsoft Sans Serif font style
        private void microsoftSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearFont();
                ActiveMdiChild.Controls["richTextBox1"].Font = new Font("Microsoft Sans Serif", ActiveMdiChild.Controls["richTextBox1"].Font.Size);
                microsoftSansSerifToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have Arial font style
        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearFont();
                ActiveMdiChild.Controls["richTextBox1"].Font = new Font("Arial", ActiveMdiChild.Controls["richTextBox1"].Font.Size);
                arialToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //this will set the active child font editor
        //to have Courier New Tool font style
        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this will check to see if there is an open child form
            if (ActiveMdiChild != null)
            {
                ClearFont();
                ActiveMdiChild.Controls["richTextBox1"].Font = new Font("Courier New", ActiveMdiChild.Controls["richTextBox1"].Font.Size);
                courierNewToolStripMenuItem.Checked = true;
            }
            else
            {
                //if not child form is open, print this message in a message box
                MessageBox.Show("No open window to format.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
