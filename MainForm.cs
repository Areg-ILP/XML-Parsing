using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Testing_XML
{
    public partial class MainForm : Form
    {
        private string path = @"C:\Users\Areg\Source\Repos\Testing_XML\Data.xml";
        private XMLManager xManager;

        public MainForm()
        {
            InitializeComponent();
            xManager = new XMLManager(path);
            LoadData();            
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            User user = new User(NameBox.Text, SureNameBox.Text);
            if(ValidateUser(user))
            {
                DialogResult result = MessageBox.Show("Do you really want to add this user?",
                    "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.OK:
                        xManager.AddNode(user);
                        LoadData();
                        ClearTextBoxs();
                        break;
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(DataGridCastom.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("Do you really want to delete this user?",
                    "Exclamation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.OK:
                        xManager.Delete(DataGridCastom.SelectedCells[0].Value.ToString());
                        LoadData();
                        ClearTextBoxs(); 
                        break;
                }
            }
            else if(DataGridCastom.SelectedRows.Count > 1)
            {
                //List<string> ids = new List<string>();
                //for (int i = 0; i < DataGridCastom.SelectedRows.Count; i++)
                //{
                    
                //}
            }
            else
                MessageBox.Show("Select Cell", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            User user = new User(NameBox.Text, SureNameBox.Text) { Id = _id };
            if (ValidateUser(user))
            {
                DialogResult result = MessageBox.Show("Do you really want to edit this user?",
                    "Exclamation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                switch(result)
                {
                    case DialogResult.OK:
                        xManager.Edit(user);
                        LoadData();
                        ClearTextBoxs();
                        break;
                }
            }
        }

        private void LoadData()
        {
            List<User> users = xManager.GetAll();
            try
            {
                DataGridCastom.DataSource = users;
            }
            catch(Exception ex)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("logs.txt", FileMode.OpenOrCreate | FileMode.Append))
                {
                    formatter.Serialize(fs, ex.Message);
                    formatter.Serialize(fs, users);                 
                }
            }                           
        }

        private void ClearTextBoxs()
        {
            NameBox.Text = string.Empty;
            SureNameBox.Text = string.Empty;
        }

        private bool ValidateUser(User user)
        {            
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            string errors = string.Empty;
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    errors += error.ErrorMessage + "\n";
                }
                MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private string _id;
        private void DataGridCastom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _id = DataGridCastom.Rows[e.RowIndex].Cells[0].Value.ToString();
                NameBox.Text = DataGridCastom.Rows[e.RowIndex].Cells[1].Value.ToString();
                SureNameBox.Text = DataGridCastom.Rows[e.RowIndex].Cells[2].Value.ToString();
                EditBtn.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Please click content", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
