using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program18
{
    //Q&A: Do we use callback/delegate a lot?

    public partial class Form1 : Form
    {
        //1. Declare the delegate:
        delegate void UpdateProgressCallback();

        public Form1()
        {
            InitializeComponent();
        }

        //DoSomething
        private void UpdateProgressHelper(UpdateProgressCallback updateProgress)
        {
            int duration = 10000;
            int updateInterval = duration / 10;

            for (int i = 0; i < duration; i++)
            {
                //Update every tenth of the duration.
                if ((i % updateInterval) == 0 && updateProgress != null)
                {
                    //4. "Invoke" the delegate to help do the job:
                    updateProgress();
                }

                if (updateProgress != null)
                {
                    updateProgress();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //2. Create an instance of the delegate type:
            UpdateProgressCallback updateProgress = new UpdateProgressCallback(this.DoUpdate);

            //3. Pass the delegate instance to a workhorse method that knows how to update the bar.
            UpdateProgressHelper(updateProgress);

            //Reset: Clear the bar so that it can be used again.
            progressBar1.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Build-in Function
            Close();
        }

        //Callback method: The delegate will call this method.
        private void DoUpdate()
        {
            //Tells progress bar to update itself: Next Step!

            //5. Invoking the delegate invokes the callbakc method:
            progressBar1.PerformStep();
        }
    }
}
