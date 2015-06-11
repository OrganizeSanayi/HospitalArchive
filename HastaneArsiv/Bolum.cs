﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HastaneArsiv
{
    public partial class Bolum : Form
    {
        public Bolum()
        {
            InitializeComponent();
        }

        private void txtBolum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBolum.Text))
                {
                    lbBolum.ClearSelected();
                    return;
                }

                bool fnd = false;
                for (int i = 0; i < lbBolum.Items.Count; i++)
                {
                    if (lbBolum.Items[i].ToString().ToLower().Contains(txtBolum.Text.ToLower()))
                    {
                        lbBolum.SelectedValue = i;
                        lbBolum.SetSelected(i, true);
                        fnd = true;
                        return;
                    }
                    if (!fnd)
                        lbBolum.ClearSelected();
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }

        private void txtBolum_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (lbBolum.SelectedItem != null)
                        ((Form1)Application.OpenForms["Form1"]).txtBolum.Text = lbBolum.SelectedItem.ToString();
                    else
                        this.Close();
                }
                if (e.KeyChar == (char)Keys.Escape)
                    this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Bolum_Load(object sender, EventArgs e)
        {
            // Db den verileri çek.
        }
    }
}
