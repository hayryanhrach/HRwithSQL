using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRForms;

namespace HRForms
{
    public partial class AddForm : Form
    {
        Methods methods = new Methods();
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numIDValue = 0;
            if (Methods.IsNumber(txtCodeValue.Text))
            {
                numIDValue = int.Parse(txtCodeValue.Text);
            }
            else
            {
                MessageBox.Show("Կոդը պետք է լինի թիվ");
            }
            methods.Add(numIDValue, txtFirstNameValue.Text, txtLastNameValue.Text, txtDepartmentValue.Text);
            txtCodeValue.Clear();
            txtFirstNameValue.Clear();
            txtLastNameValue.Clear();
            txtDepartmentValue.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCodeValue.Clear();
            txtFirstNameValue.Clear();
            txtLastNameValue.Clear();
            txtDepartmentValue.Clear();
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.Close();
            AllEmpForm allEmpForm = new AllEmpForm();
            allEmpForm.Show();
        }
    }
}
