using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Timers;
using System.Windows.Forms;

namespace Watch_Dog_v3
{
    public partial class Form1 : Form
    {
        public bool Button2WasClicked;
        public bool Button3WasClicked;
        public bool Button4WasClicked;
        public bool Button5WasClicked;
        public bool Button6WasClicked;
        public bool Button7WasClicked;
        public double TimeToWait = 1000;

        public Form1()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();

            //Write Processes to checklistbox1
            Process[] allProc = Process.GetProcesses();
            foreach (Process p in allProc)
            {
            checkedListBox1.Items.Add(p.ProcessName);
            }

            //Gets Info about the Processes and passes it to strings
            var wmiQueryString = "SELECT ProcessID, Name, ExecutablePath, CommandLine FROM Win32_Process";
            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
            using (var results = searcher.Get())
            {
                var query = from p in Process.GetProcesses()
                    join mo in results.Cast<ManagementObject>()
                    on p.Id equals (int) (uint) mo["ProcessID"]
                    select new
                    {
                        Process = p,
                        exe = (string) mo["Name"],
                        Path = (string) mo["ExecutablePath"],
                        CommandLine = (string) mo["CommandLine"]
                    };

                //Writes the path of all running Processes to checkedlistbox2
                foreach (var item in query)
                {
                    try
                    {
                        List<string> procPathList = new List<string> {item.Path};
                        object procPathArray = procPathList.ToArray();
                        checkedListBox2.Items.AddRange((object[]) procPathArray);
                    }
                    catch
                    {
                        //ignore
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.CheckedItems.Count == 0 || checkedListBox2.CheckedItems.Count == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path Selected!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }
            //writes selected Processes to textboxes
            textBox1.Clear();
            textBox2.Clear();
            Button2WasClicked = true;
            if (Button2WasClicked)
            {
                foreach (var processOne in checkedListBox1.CheckedItems)
                {
                    string processToCheck = processOne.ToString();
                    textBox1.Text = processToCheck;
                }
                foreach (var checkedItem in checkedListBox2.CheckedItems)
                {
                    string processToCheck = checkedItem.ToString();
                    textBox2.Text = processToCheck;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (checkedListBox1.CheckedItems.Count == 0 || checkedListBox2.CheckedItems.Count == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path Selected!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            textBox3.Clear();
            textBox4.Clear();
            Button3WasClicked = true;
            if (Button3WasClicked)
            {
                foreach (var processOne in checkedListBox1.CheckedItems)
                {
                    string processToCheck = processOne.ToString();
                    textBox3.Text = processToCheck;
                }
                foreach (var checkedItem in checkedListBox2.CheckedItems)
                {
                    string processToCheck = checkedItem.ToString();
                    textBox4.Text = processToCheck;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0 || checkedListBox2.CheckedItems.Count == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path Selected!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            textBox5.Clear();
            textBox6.Clear();
            Button4WasClicked = true;
            if (Button4WasClicked)
            {
                foreach (var processOne in checkedListBox1.CheckedItems)
                {
                    string processToCheck = processOne.ToString();
                    textBox5.Text = processToCheck;
                }
                foreach (var checkedItem in checkedListBox2.CheckedItems)
                {
                    string processToCheck = checkedItem.ToString();
                    textBox6.Text = processToCheck;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0 || checkedListBox2.CheckedItems.Count == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path Selected!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            textBox7.Clear();
            textBox8.Clear();
            Button5WasClicked = true;
            if (Button5WasClicked)
            {
                foreach (var processOne in checkedListBox1.CheckedItems)
                {
                    string processToCheck = processOne.ToString();
                    textBox7.Text = processToCheck;
                }
                foreach (var checkedItem in checkedListBox2.CheckedItems)
                {
                    string processToCheck = checkedItem.ToString();
                    textBox8.Text = processToCheck;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0 || checkedListBox2.CheckedItems.Count == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path Selected!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            textBox9.Clear();
            textBox10.Clear();
            Button6WasClicked = true;
            if (Button6WasClicked)
            {
                foreach (var processOne in checkedListBox1.CheckedItems)
                {
                    string processToCheck = processOne.ToString();
                    textBox9.Text = processToCheck;
                }
                foreach (var checkedItem in checkedListBox2.CheckedItems)
                {
                    string processToCheck = checkedItem.ToString();
                    textBox10.Text = processToCheck;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0 || checkedListBox2.CheckedItems.Count == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path Selected!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            textBox11.Clear();
            textBox12.Clear();
            Button7WasClicked = true;
            if (Button7WasClicked)
            {
                foreach (var processOne in checkedListBox1.CheckedItems)
                {
                    string processToCheck = processOne.ToString();
                    textBox11.Text = processToCheck;
                }
                foreach (var checkedItem in checkedListBox2.CheckedItems)
                {
                    string processToCheck = checkedItem.ToString();
                    textBox12.Text = processToCheck;
                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path in textbox!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }


            var aTimer = new System.Timers.Timer();
                aTimer.Elapsed += OnTimedEvent;
                aTimer.Interval = TimeToWait;
                aTimer.Enabled = true;

            void OnTimedEvent(object source, ElapsedEventArgs elapsed)
            {

                var retVal = Process.GetProcesses().Any(p => p.ProcessName.Contains(textBox1.Text));

                if (retVal.Equals(true))
                {
                    listBox1.Items.Add(textBox1.Text + " is running" + DateTime.Now);
                }
                if (retVal.Equals(false))
                {
                    Process.Start(textBox2.Text);
                    listBox1.Items.Add(textBox1.Text + " is not running attempting to start from path:" + textBox2.Text + " " + DateTime.Now);
                }
            }
        }
        
        public void textBox13_TextChanged(object sender, EventArgs e)
        {
           // double timeToWaitPublic = double.Parse(textBox13.Text);
        }   

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path in textbox!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var aTimer = new System.Timers.Timer();
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Interval = TimeToWait;
            aTimer.Enabled = true;

            void OnTimedEvent(object source, ElapsedEventArgs elapsed)
            {

                var retVal = Process.GetProcesses().Any(p => p.ProcessName.Contains(textBox3.Text));

                if (retVal.Equals(true))
                {
                    listBox1.Items.Add(textBox3.Text + " is running" + DateTime.Now);
                }
                if (retVal.Equals(false))
                {
                    Process.Start(textBox4.Text);
                    listBox1.Items.Add(textBox3.Text + " is not running attempting to start from path:" + textBox4.Text + " " + DateTime.Now);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 0 || textBox6.Text.Length == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path in textbox!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var aTimer = new System.Timers.Timer();
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Interval = TimeToWait;
            aTimer.Enabled = true;

            void OnTimedEvent(object source, ElapsedEventArgs elapsed)
            {

                var retVal = Process.GetProcesses().Any(p => p.ProcessName.Contains(textBox5.Text));

                if (retVal.Equals(true))
                {
                    listBox1.Items.Add(textBox5.Text + " is running" + DateTime.Now);
                }
                if (retVal.Equals(false))
                {
                    Process.Start(textBox6.Text);
                    listBox1.Items.Add(textBox5.Text + " is not running attempting to start from path:" + textBox6.Text + " " + DateTime.Now);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.Length == 0 || textBox8.Text.Length == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path in textbox!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var aTimer = new System.Timers.Timer();
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Interval = TimeToWait;
            aTimer.Enabled = true;

            void OnTimedEvent(object source, ElapsedEventArgs elapsed)
            {

                var retVal = Process.GetProcesses().Any(p => p.ProcessName.Contains(textBox7.Text));

                if (retVal.Equals(true))
                {
                    listBox1.Items.Add(textBox7.Text + " is running" + DateTime.Now);
                }
                if (retVal.Equals(false))
                {
                    Process.Start(textBox8.Text);
                    listBox1.Items.Add(textBox7.Text + " is not running attempting to start from path:" + textBox8.Text + " " + DateTime.Now);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.Length == 0 || textBox10.Text.Length == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path in textbox!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var aTimer = new System.Timers.Timer();
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Interval = TimeToWait;
            aTimer.Enabled = true;

            void OnTimedEvent(object source, ElapsedEventArgs elapsed)
            {

                var retVal = Process.GetProcesses().Any(p => p.ProcessName.Contains(textBox9.Text));

                if (retVal.Equals(true))
                {
                    listBox1.Items.Add(textBox9.Text + " is running" + DateTime.Now);
                }
                if (retVal.Equals(false))
                {
                    Process.Start(textBox10.Text);
                    listBox1.Items.Add(textBox9.Text + " is not running attempting to start from path:" + textBox10.Text + " " + DateTime.Now);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox11.Text.Length == 0 || textBox12.Text.Length == 0)
            {
                const string message = "Continue Anyway?";
                const string caption = "No Process and/or Path in textbox!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var aTimer = new System.Timers.Timer();
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Interval = TimeToWait;
            aTimer.Enabled = true;

            void OnTimedEvent(object source, ElapsedEventArgs elapsed)
            {

                var retVal = Process.GetProcesses().Any(p => p.ProcessName.Contains(textBox11.Text));

                if (retVal.Equals(true))
                {
                    listBox1.Items.Add(textBox11.Text + " is running" + DateTime.Now);
                }
                if (retVal.Equals(false))
                {
                    Process.Start(textBox12.Text);
                    listBox1.Items.Add(textBox11.Text + " is not running attempting to start from path:" + textBox12.Text + " " + DateTime.Now);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you want to kill the selected processes";
            const string caption = "Kill Processes";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            foreach (object itemChecked in checkedListBox1.CheckedItems)

            foreach (Process proc in Process.GetProcessesByName(itemChecked.ToString()))
            {
                proc.Kill();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var sPath = "results" + " " + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".txt";

            System.IO.StreamWriter saveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listBox1.Items)
            {
                saveFile.WriteLine(item);
            }
            saveFile.Close();
            listBox1.Items.Add("File saved" + @" " + DateTime.Now);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
                checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            }

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked && checkedListBox2.CheckedItems.Count > 0)
            {
                asdasdasdasd
                checkedListBox2.ItemCheck -= checkedListBox2_ItemCheck;
                checkedListBox2.SetItemChecked(checkedListBox2.CheckedIndices[0], false);
                checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            }
        }
    }
}
