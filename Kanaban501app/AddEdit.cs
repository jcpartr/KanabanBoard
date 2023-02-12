using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanaban501app
{
    public partial class AddEdit : Form
    {
        private Activity _activity;
        /// <summary>
        /// Initializes the form to have the data of the given activity displayed
        /// For adding a new activity pass in a blank activity object
        /// </summary>
        /// <param name="activity">Object to display</param>
        public AddEdit(Activity activity, Model model, bool isNew)
        {
            InitializeComponent();
            _activity = activity;
            uxNameTB.Text = _activity.Name;
            uxResourcesTB.Text = _activity.Resources;
            uxCompleteBy.Value = _activity.CompleteBy;
            switch(_activity.Status)
            {
                case ActivityStatus.ToDo:
                    uxToDoRB.Checked = true;
                    break;
                case ActivityStatus.WorkingOn:
                    uxWorkingOnRB.Checked = true;
                    break;
                case ActivityStatus.Done:
                    uxDoneRB.Checked = true;
                    break;
            }

            if(model.ToDoList.Count >= 15)
            {
                uxToDoRB.Enabled = false;
                if (isNew)
                {
                    uxToDoRB.Checked = false;
                    uxWorkingOnRB.Checked = true;
                }
            }
            if(model.WorkingOnList.Count >= 3)
            {
                uxWorkingOnRB.Enabled = false;
                if (isNew)
                {
                    uxDoneRB.Checked = true;
                    uxWorkingOnRB.Checked = false;
                    if (!(model.ToDoList.Count >= 15))
                    {
                        uxToDoRB.Checked = true;
                    }
                }
            }

            if(activity.Status == ActivityStatus.ToDo && !isNew)
            {
                uxToDoRB.Enabled = true;
            }
            if(activity.Status == ActivityStatus.WorkingOn && !isNew)
            {
                uxWorkingOnRB.Enabled = true;
            }


        }

        /// <summary>
        /// Updates the activity object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Ok_Click(object sender, EventArgs e)
        {
            _activity.Name = uxNameTB.Text;
            _activity.Resources = uxResourcesTB.Text;
            _activity.CompleteBy = uxCompleteBy.Value;
            if (uxWorkingOnRB.Checked)
            {
                _activity.Status = ActivityStatus.WorkingOn;
            }
            else if (uxDoneRB.Checked)
            {
                _activity.Status = ActivityStatus.Done;
            }
            else _activity.Status = ActivityStatus.ToDo;
        }

    }
}
