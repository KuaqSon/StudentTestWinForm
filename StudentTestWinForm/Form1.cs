using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace StudentTestWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bttNew.Click += BttNew_Click;
            bttSave.Click += BttSave_Click;
            bttExport.Click += BttExport_Click;
            bttBrowser.Click += BttBrowser_Click;
            gridStudent.CellClick += GridStudent_CellClick;
            txtId.Enabled = false;
   
    }

        List<Student> students = new List<Student>();
        Student editStudent = null;
        StudentContext Context = new StudentContext();

        private void GridStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var id = (int)gridStudent.Rows[e.RowIndex].Cells[0].Value;

            //Convert.ToInt32();

            editStudent = students.First(x => x.Id == id);

            txtId.Text = editStudent.Id.ToString();
            txtName.Text = editStudent.Name;
            txtDob.Text = editStudent.Dob.ToString("MM/dd/yyyy");
            txtScore.Text = editStudent.Score.ToString();

        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            students = Context.Students.ToList();
            gridStudent.DataSource = students;
        }

        private void BttBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog XmlFile = new OpenFileDialog();
            XmlFile.Filter = "XML Files (*.xml)|*.xml";
            XmlFile.FilterIndex = 0;
            XmlFile.DefaultExt = "xml";
        
            
            if (XmlFile.ShowDialog() == DialogResult.OK)
            {
                if (!String.Equals(Path.GetExtension(XmlFile.FileName), ".xml", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Not XML file.", "Invalid File Type", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                }
                else
                {
                    XElement doc = XElement.Load(XmlFile.FileName);

                    students = doc.Elements("Student").Select(x =>
                                                                    new Student
                                                                    {
                                                                        Id = int.Parse(x.Element("ID").Value),
                                                                        Name = x.Element("Name").Value,
                                                                        Dob = DateTime.Parse(x.Element("DOB").Value),
                                                                        Score = int.Parse(x.Element("Score").Value)     
                                                                    }
                                                                ).ToList();

                    gridStudent.DataSource = new List<Student>(students);
                }
            }
        }

        private void BttExport_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("Data Empty, Export fail!");
                return;
            }
                
            try
            {
                var xEle = new XElement("Students",
                            from std in students
                            select new XElement("Student",
                                         //new XAttribute("ID", std.Id),
                                           new XElement("ID", std.Id),
                                           new XElement("Name", std.Name),
                                           new XElement("DOB", std.Dob.ToString("MM/dd/yyyy")),
                                           new XElement("Score", std.Score)
                                       ));

                xEle.Save(".\\student.xml");
                MessageBox.Show("Done !");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BttSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Invalid Data!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDob.Text))
            {
                MessageBox.Show("Invalid Data!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Invalid Data!");
                return;
            }

            Student student = null;

            if (editStudent == null)
            {
                student = new Student();
                students.Add(student);
                Context.Students.Add(student);                
                student.Id = students.Count;
            }
            else
            {
                student = editStudent;
                var std = Context.Students.Find(editStudent.Id);
                std = editStudent;
                Context.Entry(std).State = EntityState.Modified;
            }

            student.Name = txtName.Text;
            student.Dob = DateTime.Parse(txtDob.Text);
            student.Score = int.Parse(txtScore.Text);

            Context.SaveChanges();
            gridStudent.DataSource = new List<Student>(students);
            editStudent = null;

            Clear();
        }

        private void BttNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear(bool Focus = true)
        {
            if (Focus)
                txtName.Focus();
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtDob.Text = string.Empty;
            txtScore.Text = string.Empty;
        }


    }
}
