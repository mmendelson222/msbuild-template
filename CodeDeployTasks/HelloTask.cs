using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace CodeDeployTasks
{
    /// <summary>
    /// Execute a custom tasks that will log a simple message
    /// </summary>
    public class HelloTask : Task
    {
        // Optional property
        public string Prop { get; set; }

        // Required property indicated by Required attribute
        [Required]
        public string RequiredProp { get; set; }

        /// <summary>
        /// This method is called automatically when the task is run.
        /// </summary>
        /// <returns>Boolean to indicate if the task was sucessful.</returns>
        public override bool Execute()
        {
            Log.LogCommandLine(Prop);
            Log.LogCommandLine(RequiredProp);
            return true;
        }
    }
}
