using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanaban501app
{
    public partial class Kanaban501 : Form
    {
        /// <summary>
        /// Model representation of the Kanaban board
        /// </summary>
        private Model model;

        /// <summary>
        /// Current Activity selected by the ListBoxes
        /// </summary>
        private Activity selectedActivity;
        
        /// <summary>
        /// Initializes the Kanaban Board
        /// </summary>
        public Kanaban501()
        {
            InitializeComponent();
            model = new Model();
            uxToDo.DataSource = model.ToDoList;
            uxToDo.DrawMode = DrawMode.OwnerDrawFixed;
            uxToDo.DrawItem += new DrawItemEventHandler(ToDo_DrawItem);
            uxWorkingOn.DataSource = model.WorkingOnList;
            uxWorkingOn.DrawMode = DrawMode.OwnerDrawFixed;
            uxWorkingOn.DrawItem += new DrawItemEventHandler(WorkingOn_DrawItem);
            uxDone.DataSource = model.DoneList;
            uxDone.DrawMode = DrawMode.OwnerDrawFixed;
            uxDone.DrawItem += new DrawItemEventHandler(Done_DrawItem);
            DisableChecker();
            _ = CheckDates();
        }

        /// <summary>
        /// Refreshes the ListBoxes every minute to check for overdue
        /// </summary>
        private async Task CheckDates()
        {
            while(true)
            {
                uxToDo.Refresh();
                uxWorkingOn.Refresh();
                uxDone.Refresh();
                await Task.Delay(60000);
            }
        }

        /// <summary>
        /// Creates a new activity through the AddEdit Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxNewButton_Click(object sender, EventArgs e)
        {
            Activity newActivity = new Activity();
            using (AddEdit newDialog = new AddEdit(newActivity, model, true))
            {
                if(newDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectActivity(model.AddActivity(newActivity));
                    model.UpdateTextFile();
                    DisableChecker();
                }
            }
        }

        /// <summary>
        /// Edit Button Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEditButton_Click(object sender, EventArgs e)
        {
            ActivityStatus oldStatus = selectedActivity.Status;
            using (AddEdit newDialog = new AddEdit(selectedActivity, model, false))
            {
                if (newDialog.ShowDialog() == DialogResult.OK)
                {
                    SelectActivity(model.EditActivity(selectedActivity, oldStatus));
                    model.UpdateTextFile();
                    DisableChecker();
                }
            }
        }

        /// <summary>
        /// Event handler for deleting an object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDeleteButton_Click(object sender, EventArgs e)
        {
            model.RemoveActivity(selectedActivity);
            model.UpdateTextFile();
            DisableChecker();
        }

        /// <summary>
        /// Event Handler for Drawing items in the ToDo ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToDo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                Activity a = (Activity)uxToDo.Items[e.Index];
                Brush b = Brushes.Black;
                if (a.CompleteBy < DateTime.Now)
                {
                    b = Brushes.Red;
                }

                e.Graphics.DrawString(a.Name, e.Font, b, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        /// <summary>
        /// Event Handler for Drawing items in the WorkingOn ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WorkingOn_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                Activity a = (Activity)uxWorkingOn.Items[e.Index];
                Brush b = Brushes.Black;
                if (a.CompleteBy < DateTime.Now)
                {
                    b = Brushes.Red;
                }

                e.Graphics.DrawString(a.Name, e.Font, b, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        /// <summary>
        /// Event Handler for Drawing items in the ToDo ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                Activity a = (Activity)uxDone.Items[e.Index];
                Brush b = Brushes.Black;
                if (a.CompleteBy < DateTime.Now)
                {
                    b = Brushes.Red;
                }

                e.Graphics.DrawString(a.Name, e.Font, b, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            }
        }

        /// <summary>
        /// Event handler that makes sure only one activity is selected at a time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxToDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = uxToDo.SelectedIndex;
            uxWorkingOn.ClearSelected();
            uxDone.ClearSelected();
            selectedActivity = (Activity)uxToDo.SelectedItem;
            uxToDo.SelectedIndex = index;
            DisableChecker();


        }
        /// <summary>
        /// Event handler that makes sure only one activity is selected at a time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxWorkingOn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = uxWorkingOn.SelectedIndex;
            uxToDo.ClearSelected();
            uxDone.ClearSelected();
            selectedActivity = (Activity)uxWorkingOn.SelectedItem;
            uxWorkingOn.SelectedIndex = index;
            DisableChecker();

        }
        /// <summary>
        /// Event handler that makes sure only one activity is selected at a time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDone_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = uxDone.SelectedIndex;
            uxWorkingOn.ClearSelected();
            uxToDo.ClearSelected();
            selectedActivity = (Activity)uxDone.SelectedItem;
            uxDone.SelectedIndex = index;
            DisableChecker();
        }

        /// <summary>
        /// Helper Function to disable buttons when needed
        /// </summary>
        private void DisableChecker()
        {
            if(uxToDo.SelectedItem == null && uxWorkingOn.SelectedItem == null && uxDone.SelectedItem == null)
            {
                uxEditButton.Enabled = false;
                uxDeleteButton.Enabled = false;
            } else
            {
                uxEditButton.Enabled = true;
                uxDeleteButton.Enabled = true;
            }

            if(uxToDo.Items.Count >= 15)
            {
                uxNewButton.Enabled = false;
            } else
            {
                uxNewButton.Enabled = true;
            }

        }

        /// <summary>
        /// Helper function to select the activity that was just added or edited
        /// </summary>
        /// <param name="activity"></param>
        private void SelectActivity(Activity activity)
        {
            switch(activity.Status)
            {
                case ActivityStatus.ToDo:
                    uxWorkingOn.ClearSelected();
                    uxDone.ClearSelected();
                    uxToDo.SelectedItem = activity;
                    break;
                case ActivityStatus.WorkingOn:
                    uxToDo.ClearSelected();
                    uxDone.ClearSelected();
                    uxWorkingOn.SelectedItem = activity;
                    break;
                case ActivityStatus.Done:
                    uxWorkingOn.ClearSelected();
                    uxToDo.ClearSelected();
                    uxDone.SelectedItem = activity;
                    break;
            }
            selectedActivity = activity;
        }
    }
}
