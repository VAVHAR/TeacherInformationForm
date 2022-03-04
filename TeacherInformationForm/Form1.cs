using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherInformationForm
{
    public partial class Form1 : Form
    {

        private Teacher oteacher = new Teacher();
        private List<Teacher> liteacher = new List<Teacher>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWritedata_Click(object sender, EventArgs e)
        {
            oteacher.WriteTechData();
        }

        private void buttonReadData_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Teacher Id: " + oteacher.TeacherID + "\n" + "First Name" + oteacher.FirstName + "\n" + "Last name:" + oteacher.LastName, "Teacers Info");
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            liteacher = oteacher.AddTechTOList();
            MessageBox.Show("Data Added to list Succesfully");

        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listViewTeacher.Items.Clear();
            foreach (Teacher teacher in liteacher)
            {
                ListViewItem listitem = new ListViewItem(teacher.TeacherID.ToString());
                listitem.SubItems.Add(teacher.FirstName);
                listitem.SubItems.Add(teacher.LastName);
                listViewTeacher.Items.Add(listitem);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Teacher tech = new Teacher();
            tech = tech.SearchRecordCusId(liteacher, Convert.ToInt32(textBoxTeacherId.Text));

            if (tech != null)
            {
                listViewTeacher.Items.Clear();
                /*MessageBox.Show("Teacher ID:" + tech.TeacherID + "\nFirst Name : " + tech.FirstName + "\nLast Name: " + tech.LastName, "Message");*/
                ListViewItem litem = new ListViewItem(tech.TeacherID.ToString());
                litem.SubItems.Add(tech.FirstName);
                litem.SubItems.Add(tech.LastName);
                listViewTeacher.Items.Add(litem);
                textBoxTeacherId.Clear();
            }
            else
            {
                MessageBox.Show("Customer not found");
                textBoxTeacherId.Clear();
                textBoxTeacherId.Focus();

            }
        }
    }
}
