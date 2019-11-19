using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class CreateClassForm : Form
    {
        private ClassManagement Business;
        public CreateClassForm()
        {
            InitializeComponent();
            this.Business = new ClassManagement();
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtName.Text;
            var description = this.txtDescription.Text;
            this.Business.AddClass(name, description);
            MessageBox.Show("Create class successfully.");
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
    }
}
