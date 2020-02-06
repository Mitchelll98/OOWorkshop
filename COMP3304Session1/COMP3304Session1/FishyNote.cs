﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    public partial class FishyNote : Form
    {
        // Variables

        bool _isCollasped = false;


        public FishyNote()
        {
            InitializeComponent();
        }

        private void textNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void FishyNote_Load(object sender, EventArgs e)
        {

        }

        private void ExitNote_Click(object sender, EventArgs e)
        {
            // Disposes of Current Note
            this.Dispose();
        }

        private void ActionNote_Click(object sender, EventArgs e)
        {

            if (!_isCollasped)
            {
                // Collaspe Note
                this.Size = new Size(this.Size.Width, 90);
                textNote.Visible = false;
                _isCollasped = true;
            }
            else
            {
                // Enlarge Note
                this.Size = new Size(this.Size.Width, 280);
                textNote.Visible = true;
                _isCollasped = false;
            }


            

        }
    }
}
