using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zipse_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Creates a new box object
        myBox myJob = new myBox();

        //Instantiates the random variable used to generate the boxes
        Random rnd = new Random();

        //Creates queue used to represent created boxes on the conveyor
        MyQueue myq = new MyQueue();

        //Creates a list of the boxes on the conveyor
        List<MyQueue> MyArrayList = new List<MyQueue>();

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                btnStart.Text = "START";

            }
            else
            {
                timer1.Enabled = true;
                btnStart.Text = "STOP";
                btnStart.BackColor = Color.OrangeRed;
                myMain();
            }
        }
        public void myMain()
        {
            change_colors();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (myJob.myCounter % 10 == 0)
            {
                
                //If the counter is at a 10 second interval, create a new box
                myJob.zipcode = rnd.Next(1, 11);

                //creates the trigger based on when it was created and the zipcode
                myq.trigger = myJob.myCounter + (ulong)myJob.zipcode * 10;

                //Making the zipcode look like an actual zip code on the queue.
                if (myJob.zipcode == 10)
                {
                    myq.zipcode = "02000";
                }
                else
                {
                    myq.zipcode = string.Concat(myJob.zipcode.ToString() + "0000");
                }
                //Adds the box to the conveyor
                MyArrayList.Add(new MyQueue()
                {
                    lane = myJob.zipcode,
                    trigger = myq.trigger,
                    zipcode = myq.zipcode,
                    ID = myJob.myCounter.ToString()
                });
                //Sorts the array
                MyArrayList.Sort();
                copy_array_listbox();
            }
                change_colors();
                calc_lane();
                myJob.myCounter++;
                counter.Text = myJob.myCounter.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Start";
            timer1.Enabled = false;
            myJob.myCounter = 0;
            counter.Text = myJob.myCounter.ToString();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            MyArrayList.Clear();
        }


        //Displays the boxes, sorted by when they need to be removed
        void copy_array_listbox()
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            foreach (var myentry in MyArrayList)
            {
                String myString = String.Concat(myentry.ID, "     ",
                    myentry.lane.ToString(), "       ",
                    myentry.trigger.ToString(), "         ",
                    myentry.zipcode);
                listBox1.Items.Add(myString);
            }
        }

        //When the timer reaches the value required for a box to be
        //Pushed off of its lane, it removes the box from the arraylist
        //Then it resorts the array list 
        public void calc_lane()
        {
            
            if (!(MyArrayList.Count == 0))
            {
                ulong my_trigger = MyArrayList[0].trigger;
                while (myJob.myCounter == my_trigger)
                {
                    remove_box(MyArrayList[0].lane);
                    MyArrayList.RemoveAt(0);
                    MyArrayList.Sort();
                    copy_array_listbox();
                    my_trigger = MyArrayList[0].trigger;
                    
                }
            }
           
        }
        //This is the code for flashing the lights when a box is removed
        public void remove_box(int lane)
        {
            switch (lane)
            {
                case 1:
                    lane1.BackColor = Color.Red;
                    break;
                case 2:
                    lane2.BackColor = Color.Red;
                    break;
                case 3:
                    lane3.BackColor = Color.Red;
                    break;
                case 4:
                    lane4.BackColor = Color.Red;
                    break;
                case 5:
                    lane5.BackColor = Color.Red;
                    break;
                case 6:
                    lane6.BackColor = Color.Red;
                    break;
                case 7:
                    lane7.BackColor = Color.Red;
                    break;
                case 8:
                    lane8.BackColor = Color.Red;
                    break;
                case 9:
                    lane9.BackColor = Color.Red;
                    break;
                case 10:
                    lane10.BackColor = Color.Red;
                    break;

            }

           
                
        }

        public void change_colors()
        {
            // I just threw this in here to play with it.
            lane1.BackColor = Color.Yellow;
            lane2.BackColor = Color.Yellow;
            lane3.BackColor = Color.Yellow;
            lane4.BackColor = Color.Yellow;
            lane5.BackColor = Color.Yellow;
            lane6.BackColor = Color.Yellow;
            lane7.BackColor = Color.Yellow;
            lane8.BackColor = Color.Yellow;
            lane9.BackColor = Color.Yellow;
            lane10.BackColor = Color.Yellow;
            
        }

        private void lane1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Green;
            btnReset.BackColor = Color.DeepSkyBlue;
        }
    }
}
