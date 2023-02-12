using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanaban501app
{   
    /// <summary>
    /// Enumerator to determine what state the Activity is in
    /// </summary>
    public enum ActivityStatus
    {
        ToDo,
        WorkingOn,
        Done
    }
    /// <summary>
    /// Class representing an activity for the Kanuban Board
    /// </summary>
    public class Activity
    {
        /// <summary>
        /// Status of the Activity
        /// </summary>
        public ActivityStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private ActivityStatus _status;

        /// <summary>
        /// Date to complete the Activity by
        /// </summary>
        public DateTime CompleteBy
        {
            get { return _completeby; }
            set { _completeby = value; }
        }

        private DateTime _completeby;
        
        /// <summary>
        /// Name Property of the Activity
        /// </summary>
        public string Name { 
           get { return _name; }
           set { _name = value; }
        }
        private string _name;

        /// <summary>
        /// Resources Property of the Activity
        /// </summary>
        public string Resources { 
            get { return _resources; } 
            set { _resources = value; } 
        }
        private string _resources;
        
        /// <summary>
        /// Creates a default activity
        /// </summary>
        public Activity()
        {
            Name = String.Empty;
            Resources = String.Empty;
            Status = ActivityStatus.ToDo;
            CompleteBy = DateTime.Today;
        }

        /// <summary>
        /// Creates a string for txt file storage
        /// </summary>
        /// <returns>String with each property displayed on separate lines</returns>
        public override string ToString()
        {
            return Name;
        }
        /// <summary>
        /// Generates a hash code for the activity
        /// </summary>
        /// <returns>Hash Code</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
