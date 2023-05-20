using System;
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
    public partial class CreateAccountPage : Form
    {
        public CreateAccountPage()
        {
            InitializeComponent();

            for (int i = 1950; i < 2024; i++)
            {
                yearPicker.Items.Add(i.ToString());
            }
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            LoginDesign loginDesign = new LoginDesign();
            loginDesign.Show();
            this.Close();
        }

        private void monthPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthPicker.Text == "February")
            {
                dayPicker.Items.Clear();
                for (int i = 1; i < 30; i++)
                {
                    dayPicker.Items.Add(i.ToString());
                }
            }
            else if (monthPicker.Text == "April" || monthPicker.Text == "June" || monthPicker.Text == "September" || monthPicker.Text == "November")
            {
                dayPicker.Items.Clear();
                for (int i = 1; i < 31; i++)
                {
                    dayPicker.Items.Add(i.ToString());
                }
            }
            else
            {
                dayPicker.Items.Clear();
                for (int i = 1; i < 32; i++)
                {
                    dayPicker.Items.Add(i.ToString());
                }
            }
        }

        private void stepOneNextBtn_Click(object sender, EventArgs e)
        {
            TextBox[] textBox = { createAccUserBox, createAccPassBox };
            ComboBox[] comboBox = { monthPicker, dayPicker, yearPicker };

            foreach (TextBox txt in textBox)
            {
                if (string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Please fill in username / password");
                    break;
                }
            }

            foreach (ComboBox cb in comboBox)
            {
                if (cb.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a value on month / day / year");
                    break;
                }
            }

            foreach (TextBox txt in textBox)
            {
                if (string.IsNullOrEmpty(txt.Text) == false)
                {
                    if (monthPicker.SelectedIndex >= 0 && dayPicker.SelectedIndex >= 0 && yearPicker.SelectedIndex >= 0)
                    {
                        InfoFillPage ifp = new InfoFillPage();
                        ifp.Show();
                        this.Close();
                    }
                }
            }
        }                
    }
}
