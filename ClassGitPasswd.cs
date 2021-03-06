﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GitForce
{
    /// <summary>
    /// Manages git HTTPS password helper file
    /// </summary>
    public class ClassGitPasswd
    {
        /// <summary>
        /// A file that provides password for HTTPS operations
        /// </summary>
        private readonly string _pathPasswordBatchHelper;

        /// <summary>
        /// Constructor creates a shell executable file that echoes the PASSWORD
        /// environment variable when called. When GIT_ASKPASS is present, Git
        /// obtains a password for its HTTPS operations by calling it.
        /// </summary>
        public ClassGitPasswd()
        {
            // WAR: Do a different kind of shell script dependent on the OS)
            if( ClassUtils.IsMono())
            {
                // Mono: Use the Shell script
                _pathPasswordBatchHelper = Path.Combine(App.AppHome, "passwd.sh");
                File.WriteAllText(_pathPasswordBatchHelper, "echo $PASSWORD" + Environment.NewLine);

                // Set the execute bit
                if (Exec.Run("chmod", "+x " + _pathPasswordBatchHelper).Success() == false)
                    App.PrintLogMessage("ClassGitPasswd: Unable to chmod +x on " + _pathPasswordBatchHelper);
            }
            else
            {
                // Windows: Use the CMD BAT script
                // Note: Using "App.AppHome" directory to host the batch helper file
                //       fails on XP where that directory has spaces in the name ("Documents and Settings")
                //       which git cannot handle in this context. Default Temp path seem to be OK.
                _pathPasswordBatchHelper = Path.Combine(Path.GetTempPath(), "passwd.bat");
                File.WriteAllText(_pathPasswordBatchHelper, "@echo %PASSWORD%" + Environment.NewLine);
            }
            ClassUtils.AddEnvar("GIT_ASKPASS", _pathPasswordBatchHelper);

            App.PrintLogMessage("Created HTTP password helper file: " + _pathPasswordBatchHelper);
        }
    }
}
