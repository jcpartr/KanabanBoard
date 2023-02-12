using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanaban501app
{
    /// <summary>
    /// Model representing the Kanaban board
    /// </summary>
    public class Model
    {
        /// <summary>
        /// Path of the application data folder
        /// </summary>
        private static string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"Kanaban501");
        
        /// <summary>
        /// Path of the database text file
        /// </summary>
        private static string filePath= Path.Combine(folderPath,"GoalActivity.txt");
        public Model()
        {
            ToDoList = new BindingList<Activity>();
            WorkingOnList = new BindingList<Activity>();
            DoneList = new BindingList<Activity>();
            ReadTextFile();
        }

        /// <summary>
        /// Reads the text file database and converts it to activities
        /// </summary>
        private void ReadTextFile()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            if(File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    Activity a = new Activity();
                    a.Name = sr.ReadLine();

                    int resLen = Convert.ToInt32(sr.ReadLine());
                    StringBuilder sb = new StringBuilder();
                    for(int i = 0; i < resLen; i++)
                    {
                        sb.AppendLine(sr.ReadLine());
                    }
                    a.Resources = sb.ToString();
                    switch (sr.ReadLine())
                    {
                        case ("WorkingOn"):
                            a.Status = ActivityStatus.WorkingOn;
                            break;
                        case ("Done"):
                            a.Status = ActivityStatus.Done;
                            break;
                        default:
                            a.Status = ActivityStatus.ToDo;
                            break;
                    }
                    a.CompleteBy = DateTime.ParseExact(sr.ReadLine(),"d",CultureInfo.CurrentCulture);
                    AddActivity(a);
                }
                sr.Close();
            }
        }

        /// <summary>
        /// Updates the text file database
        /// </summary>
        public void UpdateTextFile()
        {
            StreamWriter file = new StreamWriter(File.Create(filePath));
            UpdateTextFilerHelper(file, ToDoList);
            UpdateTextFilerHelper(file, WorkingOnList);
            UpdateTextFilerHelper(file, DoneList);
            file.Close();
        }
        /// <summary>
        /// Helper function to write to the file for each ActivityStatus type
        /// </summary>
        /// <param name="file">Streamwriter being used</param>
        /// <param name="activities">List of activities to write</param>
        private void UpdateTextFilerHelper(StreamWriter file, BindingList<Activity> activities)
        {
            foreach(Activity a in activities)
            {
                file.WriteLine(a.Name);
                file.WriteLine(a.Resources.Split('\n').Length); //number of lines in the resources string
                file.WriteLine(a.Resources);
                file.WriteLine(a.Status);
                file.WriteLine(a.CompleteBy.ToShortDateString());
            }
        }

        /// <summary>
        /// List of all activities that are marked ToDo
        /// </summary>
        public BindingList<Activity> ToDoList;

        /// <summary>
        /// List of all activities that are marked WorkingOn
        /// </summary>
        public BindingList<Activity> WorkingOnList;

        /// <summary>
        /// List of all activities that are marked Done
        /// </summary>
        public BindingList<Activity> DoneList;

        /// <summary>
        /// Adds the given activity to the right list
        /// </summary>
        /// <param name="activity"></param>
        /// <returns></returns>
        public Activity AddActivity(Activity activity)
        {
            switch(activity.Status)
            {
                case ActivityStatus.ToDo:
                    ToDoList.Add(activity);
                    break;
                case ActivityStatus.WorkingOn:
                    WorkingOnList.Add(activity);
                    break;
                case ActivityStatus.Done:
                    DoneList.Add(activity);
                    break;
            }
            return activity;
        }

        /// <summary>
        /// Edits an activity and moves it into the correct list
        /// </summary>
        /// <param name="activity">Activity with the edits</param>
        /// <param name="oldStatus">The previous status of the activity</param>
        /// <returns></returns>
        public Activity EditActivity(Activity activity, ActivityStatus oldStatus)
        {
            switch (oldStatus)
            {
                case ActivityStatus.ToDo:
                    ToDoList.Remove(activity);
                    break;
                case ActivityStatus.WorkingOn:
                    WorkingOnList.Remove(activity);
                    break;
                case ActivityStatus.Done:
                    DoneList.Remove(activity);
                    break;
            }
            switch (activity.Status)
            {
                case ActivityStatus.ToDo:
                    ToDoList.Add(activity);
                    break;
                case ActivityStatus.WorkingOn:
                    WorkingOnList.Add(activity);
                    break;
                case ActivityStatus.Done:
                    DoneList.Add(activity);
                    break;
            }
            return activity;

        }

        /// <summary>
        /// Removes an activity
        /// </summary>
        /// <param name="activity">Activity to be removed</param>
        public void RemoveActivity(Activity activity)
        {
            if (activity == null) return;
            switch (activity.Status)
            {
                case ActivityStatus.ToDo:
                    ToDoList.Remove(activity);
                    break;
                case ActivityStatus.WorkingOn:
                    WorkingOnList.Remove(activity);
                    break;
                case ActivityStatus.Done:
                    DoneList.Remove(activity);
                    break;
            }
        }
    }
}
