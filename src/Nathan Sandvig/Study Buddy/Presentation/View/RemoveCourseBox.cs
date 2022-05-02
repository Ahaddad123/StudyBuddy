using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation.View
{
    //---------------------------------------------------------------------
    // This user control provides a list of courses and a button to remove
    // a selected course.  Note that all events are passed to the parent 
    // form to be handled.
    //---------------------------------------------------------------------
    public partial class RemoveCourseBox : UserControl
    {
        //---------------------------------------------------------------------
        // Properties : 
        // StatusUpdated : An event handler created when a dynamically
        // generated button is clicked.  Is "bubbled" to the parent form for
        // handling the button click event
        //---------------------------------------------------------------------
        public EventHandler StatusUpdated { get; set; }

        //---------------------------------------------------------------------
        // Default constructor
        //---------------------------------------------------------------------
        public RemoveCourseBox()
        {
            InitializeComponent();
            this.groupBox2.Size = new System.Drawing.Size(1000, 545);
        }

        //---------------------------------------------------------------------
        // Event Handler for clicking "remove course" button.
        // Triggers creation of dynamic event handler that is "bubbled" to
        // parent form
        //---------------------------------------------------------------------
        private void removeCourseButton_Click(object sender, EventArgs e)
        {
            this.StatusUpdated(this.courseListBox.Text, new EventArgs());
            this.courseListBox.Text = "";
            this.successMessage.Text = "Succesfully removed " + courseListBox.Text;
        }

        //---------------------------------------------------------------------
        // Loads the passed list of courses into the comboBox
        // courses : the list of courses being passed
        //---------------------------------------------------------------------
        public void LoadCourses(List<Course> courses)
        {
            courseListBox.Items.Clear();
            foreach (Course c in courses)
            {
                courseListBox.Items.Add(c.name);
            }
        }

        //---------------------------------------------------------------------
        // Clears the selected item from the comboBox
        //---------------------------------------------------------------------
        public void Clear()
        {
            this.courseListBox.SelectedItem = null;
        }
    }
}
