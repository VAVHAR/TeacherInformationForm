using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace TeacherInformationForm
{
    public class Teacher
    {
        public Teacher()
        {

        }

        public Teacher(int techid, string Fname, string Lname)
        {
            TeacherID = techid;
            FirstName = Fname;
            LastName = Lname;
        }
        public int TeacherID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void WriteTechData()
        {
            TeacherID = 2222;
            FirstName = "Thomas";
            LastName = "Moore";

            MessageBox.Show("Data Addes SucessFully");
        }

        public List<Teacher> AddTechTOList()
        {
            List<Teacher> ltech = new List<Teacher>();

            Teacher tech = new Teacher(TeacherID = 2222, FirstName = "Thomas", LastName = "Moore");
            ltech.Add(tech);

            Teacher tech1 = new Teacher(TeacherID = 3333, FirstName = "Thomas", LastName = "Green");
            ltech.Add(tech1);

            Teacher tech2 = new Teacher(TeacherID = 4444, FirstName = "Thomas", LastName = "Brown");
            ltech.Add(tech2);

            return ltech;

        }

        public Teacher SearchRecordCusId(List<Teacher> techlist, int techid)
        {
            Teacher teacher = new Teacher();
            bool found = false;
            foreach (Teacher teach in techlist)
            {

                if (teach.TeacherID == techid)
                {
                    teacher.TeacherID = teach.TeacherID;
                    teacher.FirstName = teach.FirstName;
                    teacher.LastName = teach.LastName;
                    found = true;
                    return teacher;
                }

            }

            if (!found)
            {
                teacher = null;

            }

            return teacher;



        }

    }
}
