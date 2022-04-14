using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFour
{
    public partial class MainForm : Form
    {
        private Task currTask;
        public MainForm()
        {
            //ListDisplay( sender,  ea);

            InitializeComponent();
            InitializeGUI();
            settooltip();
        }


        private void settooltip()
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.dateTimePicker1, "Click to open calander,select time here");
        }


        public void InitializeGUI()
        {

            Text = "To Do Reminder" + "  Abel Magicho";
            currTask = new Task(DateTime.Now);

            cmbPriority.Items.Clear();

            //the default item of the combobox is PriorityType.Normal
            cmbPriority.Items.AddRange(Enum.GetNames(typeof(priorityType)));
            cmbPriority.SelectedIndex = (int)priorityType.Normal;
            cmbPriority.SelectedIndex = cmbPriority.Items.IndexOf("Normal");

            ClockTimer.Start();

            txtDescription.Text = string.Empty;
            //date is displayed on the date and time textbox in  "yyyy-MM-dd  HH:mm" format 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd  HH:mm";
            ToolTip1.ShowItemToolTips = true;
            lstTasks.Items.Clear();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbPriority.SelectedItem = priorityType.Normal;
            cmbPriority.SelectedIndex = (int)priorityType.Normal;

        }

        private void ToolTip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void ReadInput()
        {
            currTask.Priority = (priorityType)cmbPriority.SelectedIndex;
            currTask.Description = txtDescription.Text;
            currTask.Date = dateTimePicker1.Value;





        }
        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this will handle the event as a certain priority type is selected from the combobox
            priorityType selectedPriority = (priorityType)Enum.Parse(typeof(priorityType), cmbPriority.SelectedItem.ToString());

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // show to the user on a listbox
            //ReadInput();
            currTask.Description = txtDescription.Text;

            currTask.Priority = (priorityType)cmbPriority.SelectedIndex;
            if (!string.IsNullOrEmpty(txtDescription.Text))
            {
                lstTasks.Items.Add(currTask.ToString());

            }
            else
            {
                InitializeGUI();
                //lstTasks.Text = string.Empty;
                MessageBox.Show("Please enter to do description", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            // currTask = new Task(daat);




        }


        private void btnChange_Click(object sender, EventArgs e)
        {

            // txtDescription.Text=dateTimePicker1_ValueChanged(sender, e);

            int index = lstTasks.SelectedIndex;
            //txtDescription.Text = lstTasks.des.ToString();
            if (index >= 0)
            {
                ReadInput();
                lstTasks.Items.RemoveAt(index);

                lstTasks.Items.Insert(index, currTask.ToString());
            }
            else
                MessageBox.Show("Select an item from the ListBox!", "Error");
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex >= 0)
            {
                DialogResult dlg = MessageBox.Show("Sure to delete?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    int index = lstTasks.SelectedIndex;
                    if (index >= 0)
                    {
                        ReadInput();
                        lstTasks.Items.RemoveAt(index);
                    }
                }
            }
            else
            {
                //InitializeGUI();
                //lstTasks.Text = string.Empty;
                MessageBox.Show("no element to delete selected", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }



        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 dlgAbout = new AboutBox1();
            dlgAbout.ShowDialog();

        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void openDatafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
            OpenFileAndSaveToLisstBox();
        }

        private void saveDatafileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLisstBoxToFile();
        }

        public void OpenFileAndSaveToLisstBox()
        {
            string fileName = Application.StartupPath + "\\Tasks.txt"; StreamReader reader = null; lstTasks.Items.Clear();
            try
            {
                string textIn; reader = new StreamReader(fileName); while (!reader.EndOfStream)
                {
                    textIn = reader.ReadLine(); lstTasks.Items.Add(textIn);
                }
            }

            catch
            {
                MessageBox.Show("Problem saving data to file!");
            }
        }
        public void SaveLisstBoxToFile()
        {
            string fileName = Application.StartupPath + "\\Tasks.txt"; StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileName);
                for (int i = 0; i < lstTasks.Items.Count; i++)
                {
                    writer.WriteLine(lstTasks.Items[i].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problem saving data to file!" + e.Message);
            }


            finally { if (writer != null) writer.Close(); }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form.close();
            DialogResult dialog = MessageBox.Show("sure to exit program ?", "Think twice", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
           if (dialog==DialogResult.OK)
            {
                
                    // WinForms exit
                    Application.Exit();
                
              
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // initialize the form
            InitializeGUI();
        }

     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          // datetime picker will be changed only on there is a plan 
            if ( string.IsNullOrEmpty(txtDescription.Text)) { 
                
                dateTimePicker1.Value = DateTime.Now ;
                
                    }
            else {
                this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
                txtDescription_TextChanged(sender,  e);
            }
            
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            // this is called by dateTimePicker1_ValueChanged to make sure the time changes along with the plan
            currTask.Date = dateTimePicker1.Value;
        }
    }
}
