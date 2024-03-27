using System;
using System.IO;
using System.Windows.Forms;

namespace TypeConversion
{
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
            Init();
        }

        #region methods
        private void Init()
        {
            cbxBirthPlace.SelectedIndex = 0;
            rdbUnknown.Checked = true;
            LoadClients();
        }

        private bool InputValidation(string clientId, string firstName, 
            string lastName, DateTime date, bool isUpdate)
        {
            if (!string.IsNullOrEmpty(clientId) &&
                !string.IsNullOrEmpty(firstName) &&
                !string.IsNullOrEmpty(lastName))
            {
                int id = ConvertClientId(clientId);
                int age = CalculateAge(date);

                if (!isUpdate)
                {
                    if (!ValidClientId(txtClientId.Text)) return false;
                }

                if (id != -1 && age >= 18)
                {
                    return true;
                }

                return false;
            }
            return false;
        }

        private int ConvertClientId(string s)
        {
            try
            {
                int i = Convert.ToInt32(s);
                return i;
            }
            catch
            {
                return -1;
            }
        }

        private int CalculateAge(DateTime date)
        {
            DateTime today = DateTime.Now;
            int iAge = today.Year - date.Year;
            if (today.DayOfYear > date.DayOfYear)
            {
                return iAge;
            }
            return (iAge - 1);
        }

        private string GetGender(bool isMale, bool isFemale)
        {
            if (isMale) return "Man";
            if (isFemale) return "Vrouw";
            return "Onbekend";
        }

        private bool AddClient(int clientId, string firstName,
            string lastName, int age, string birthPlace, string gender, DateTime date)
        {
            try
            {
                grid.Rows.Add(clientId, firstName, lastName,
                    age, birthPlace, gender, date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void DeleteClients()
        {
            foreach (DataGridViewRow item in grid.SelectedRows)
            {
                grid.Rows.RemoveAt(item.Index);
            }
        }

        private bool ValidClientId(string id)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[0].Value.ToString() == id) return false;
            }
            return true;
        }

        private void LoadClients()
        {
            // pad aanpassen indien nodig
            string path = @"D:\klantenbeheer\klanten.txt";

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    string[] splitLine = line.Split(';');
                    AddClient(Convert.ToInt32(splitLine[0]), splitLine[1], splitLine[2], Convert.ToInt32(splitLine[3]),
                        splitLine[4], splitLine[5], Convert.ToDateTime(splitLine[6]));
                }
            }            
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (InputValidation(txtClientId.Text, txtFirstName.Text,
                    txtLastName.Text, dtpBirthDate.Value, false))
            {
                if (AddClient(Convert.ToInt32(txtClientId.Text), txtFirstName.Text, 
                        txtLastName.Text, CalculateAge(dtpBirthDate.Value), 
                        cbxBirthPlace.SelectedItem.ToString(), GetGender(rdbMale.Checked, 
                            rdbFemale.Checked), dtpBirthDate.Value))
                {
                    MessageBox.Show("Klant toegevoegd", "Toegevoegd",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    grid.ClearSelection();
                    grid.Rows[grid.Rows.Count-1].Selected = true;
                } 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                DialogResult d = MessageBox.Show("Klanten verwijderen?", "Bevestig verwijderen",
                    MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    DeleteClients();
                }
            }
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grid.SelectedRows[0];
                txtClientId.Text = row.Cells[0].Value.ToString();
                txtFirstName.Text = row.Cells[1].Value.ToString();
                txtLastName.Text = row.Cells[2].Value.ToString();
                dtpBirthDate.Value = (DateTime)row.Cells[6].Value;
                //cbxBirthPlace.SelectedIndex = cbxBirthPlace.FindStringExact(row.Cells[4].Value.ToString());
                cbxBirthPlace.SelectedItem = row.Cells[4].Value;
                switch (row.Cells[5].Value.ToString())
                {
                    case "Man":
                        rdbMale.Checked = true;
                        break;
                    case "Vrouw":
                        rdbFemale.Checked = true;
                        break;
                    case "Onbekend":
                        rdbUnknown.Checked = true;
                        break;
                }
            }                   
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grid.SelectedRows[0];

            if (InputValidation(txtClientId.Text, txtFirstName.Text,
                    txtLastName.Text, dtpBirthDate.Value, true))
            {
                row.Cells[0].Value = txtClientId.Text;
                row.Cells[1].Value = txtFirstName.Text;
                row.Cells[2].Value = txtLastName.Text;
                row.Cells[3].Value = CalculateAge(dtpBirthDate.Value);
                row.Cells[4].Value = cbxBirthPlace.SelectedItem.ToString();
                row.Cells[5].Value = GetGender(rdbMale.Checked, rdbFemale.Checked);
                row.Cells[6].Value = dtpBirthDate.Value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] lines = new string[grid.RowCount];
            
            for (int i  = 0; i < grid.RowCount; i++)
            {
                DataGridViewRow row = grid.Rows[i];
                lines[i] = row.Cells[0].Value + ";"
                    + row.Cells[1].Value + ";"
                    + row.Cells[2].Value + ";"
                    + row.Cells[3].Value + ";"
                    + row.Cells[4].Value + ";"
                    + row.Cells[5].Value + ";"
                    + row.Cells[6].Value;
            }

            // pad aanpassen indien nodig
            string path = @"D:\klantenbeheer\";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path += "klanten.txt";

            File.WriteAllLines(path, lines);
        }
    }
}
