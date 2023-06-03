﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GigisCakesAndPastriesGUI
{
    public partial class DeleteConfirmationPage : Form
    {
        public static DeleteUser deleteUser = new DeleteUser();
        public static DeletePrompt deletePrompt = new DeletePrompt();
        public DeleteConfirmationPage()
        {
            InitializeComponent();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            Visible = false;
            deleteUser.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            deletePrompt.Show();
            deletePrompt.idHidee.Text = idHide.Text;
        }
    }
}
