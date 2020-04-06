
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Student_Enquiry1
{
    public partial class Form1 : Form
    {
        SortedList<string, string[]> programs;

        string[] ITPrograms = { "Programming", "Security", "Networking" };
        string[] EngineeringPrograms = { "Electrical", "Mechanical" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            programs = new SortedList<string, string[]>
            {
                {"Information Technology", ITPrograms },
                {"Engineering", EngineeringPrograms },

            };

            // This combobox has DropDownStyle=DropDownList, user can only pici one of the available choices 
            cbxDepartment.Items.AddRange(programs.Keys.ToArray());
            cbxDepartment.SelectedIndex = 0; // Select the first choice

            // This combobox has DropDownStyle = DropDown, so user can  enter their own text
            cbxHowDidYouHear.Items.Add("Another student");
            cbxHowDidYouHear.Items.Add("Another school");
            cbxHowDidYouHear.Items.Add("Internet search");

        }
               
        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDegrees.Items.Clear();

            string department = cbxDepartment.Text;

            if(department != null) 
            {
                //Fetch the Array of degrees from the SortedList, show in ListBox
                // Remember the keys in the SortedList are the names of programs
                //The value for each key, is an array of degrees for that program
                string[] degrees = programs[department];
                lstDegrees.Items.AddRange(degrees);
            }

        }
    }
}
