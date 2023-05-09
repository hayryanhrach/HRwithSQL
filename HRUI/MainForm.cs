using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addForm=new AddForm();
            addForm.Show();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllEmpForm allEmpForm = new AllEmpForm();
            allEmpForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
