﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG_223_PROJECT_GROUP35
{
    public partial class FormGuests : Form
    {
        public FormGuests()
        {
            InitializeComponent();
        }

        private void btnAddNewGuest_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Guest successfully added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
