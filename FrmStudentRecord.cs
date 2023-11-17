using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTextFile2
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void uploadBTN_Click(object sender, EventArgs e)
        {
            listview.Items.Clear();
            MessageBox.Show("Successfully Uploaded!");
        }

        private void findBTN_Click(object sender, EventArgs e)
        {
            OpenFile.InitialDirectory = "./Records";
            OpenFile.Title = "Browse for Text Files";
            OpenFile.DefaultExt = "txt";
            OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFile.ShowDialog();
            string path = OpenFile.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {

                string getText = "";
                while ((getText = streamReader.ReadLine()) != null)
                {
                    ListViewItem item = new ListViewItem(getText);
                    item.SubItems.Add(getText);
                    listview.Items.Add(item);
                }
            }
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            RegistrationForm rbtn = new RegistrationForm();
            rbtn.ShowDialog();
        }
    }
}
