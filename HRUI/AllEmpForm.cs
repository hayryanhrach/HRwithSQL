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
    public partial class AllEmpForm : Form
    {

        public AllEmpForm()
        {
            InitializeComponent();
            LoadGrid();
        }

        public void LoadGrid()
        {
            Methods methods = new Methods();
            List<Employee> employees = methods.AllFromDBtoList();
            foreach (var item in employees)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell codeCell = new DataGridViewTextBoxCell();
                DataGridViewCell firstNameCell = new DataGridViewTextBoxCell();
                DataGridViewCell lastNameCell = new DataGridViewTextBoxCell();
                DataGridViewCell departmentIDCell = new DataGridViewTextBoxCell();
                codeCell.Value = item.EmployeCode;
                firstNameCell.Value = item.FirstName;
                lastNameCell.Value = item.LastName;
                departmentIDCell.Value = item.Department;
                row.Cells.Add(codeCell);
                row.Cells.Add(firstNameCell);
                row.Cells.Add(lastNameCell);
                row.Cells.Add(departmentIDCell);
                AllEmpDataGridView.Rows.Add(row);
            }
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelateAll_Click(object sender, EventArgs e)
        {

        }
    }
}
