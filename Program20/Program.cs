using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program20
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Two main parts of security: authentication and authorization.

            //Authentication: the process of making sure a user is authentic. 
            //  The most common method of authentication is to require the use of a username and password.

            //Authorization: the act of ensuring that a user has the authority to perform specific tasks. 
            //  The most common example of authorization is only administrator users can access to some files.
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
