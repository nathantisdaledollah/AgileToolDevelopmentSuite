﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgileDevelopmentToolsSuite
{
    public partial class SkillSetForm : Form
    {
        public SkillSetForm()
        {
            InitializeComponent();
        }

        private void SkillSetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(" bye Skill SetForm ");
            Application.Exit();

        }
    }
}
