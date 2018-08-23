using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x <= 5; x++)
            {
                listBox1.Items.Add("Directory" + x.ToString() + "        >");
                if (x == 0 || x == 3)
                {
                    listBox5.Items.Add("Directory" + x.ToString() + "        >");
                }

                if (x == 1 || x == 4)
                {
                    listBox7.Items.Add("Directory" + x.ToString() + "        >");
                }

                if (x == 2 || x == 5)
                {
                    listBox9.Items.Add("Directory" + x.ToString() + "        >");
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (listBox2.Items.Count >= 5)
                {
                    for (int i = listBox2.Items.Count - 1; i >= 0; i--)
                    {
                        // do with listBox1.Items[i]
                        listBox2.Items.RemoveAt(i);
                    }
                }

                for (int x = 0; x <= 4; x++)
                {
                    listBox2.Items.Add("Directory" + listBox1.SelectedIndex + x.ToString() + "        >");
                }
        }
        
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            for (int x = 0; x <= 2; x++)
            {
                if (listBox2.SelectedIndex == 0|| listBox2.SelectedIndex == 1 || listBox2.SelectedIndex == 2 || listBox2.SelectedIndex == 3 || listBox2.SelectedIndex == 4 )
                {
                    listBox3.Items.Add("Directory" + listBox1.SelectedIndex + listBox2.SelectedIndex + x.ToString() + ".txt");
                }
            }
        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (listBox4.Items.Count >= 1)
                {
                    for (int i = listBox4.Items.Count - 1; i >= 0; i--)
                    {
                        // do with listBox1.Items[i]
                        listBox4.Items.RemoveAt(i);
                    }
                }

                if (listBox3.SelectedIndex == 0|| listBox3.SelectedIndex == 1|| listBox3.SelectedIndex == 2)
                {
                    listBox4.Items.Add("Content for text file number "+ listBox1.SelectedIndex+ listBox2.SelectedIndex+ listBox3.SelectedIndex);
                }
        }
        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox6.Items.Count >= 5)
            {
                for (int i = listBox6.Items.Count - 1; i >= 0; i--)
                {
                    // do with listBox1.Items[i]
                    listBox6.Items.RemoveAt(i);
                }
            }
            for (int x = 0; x <= 4; x++)
            {
                if (listBox5.SelectedIndex == 0)
                {
                    listBox6.Items.Add("Directory" + listBox5.SelectedIndex + x.ToString() + "       >");
                }

                else if (listBox5.SelectedIndex == 1)
                {
                    listBox6.Items.Add("Directory3"  + x.ToString() + "       >");
                }
            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox11.Items.Clear();
            for (int x = 0; x <= 2; x++)
            {
                if (listBox6.SelectedIndex == 0 || listBox6.SelectedIndex == 1 || listBox6.SelectedIndex == 2 || listBox6.SelectedIndex == 3 || listBox6.SelectedIndex == 4)
                {
                    if (listBox5.SelectedIndex == 0)
                    {
                        listBox11.Items.Add("Directory" + listBox5.SelectedIndex + listBox6.SelectedIndex + x.ToString() + ".txt");
                    }

                    else if (listBox5.SelectedIndex == 1)
                    {
                        listBox11.Items.Add("Directory3" +listBox6.SelectedIndex + x.ToString() + ".txt");
                    }
                    
                }
            }
        }
        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox8.Items.Count >= 5)
            {
                for (int i = listBox8.Items.Count - 1; i >= 0; i--)
                {
                    // do with listBox1.Items[i]
                    listBox8.Items.RemoveAt(i);
                }
            }
            for (int x = 0; x <= 4; x++)
            {
                if (listBox7.SelectedIndex == 0)
                {
                    listBox8.Items.Add("Directory1" + x.ToString() + "       >");
                }

                else if (listBox7.SelectedIndex == 1)
                {
                    listBox8.Items.Add("Directory4" + x.ToString() + "       >");
                }
            }
        }
        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox12.Items.Clear();
            for (int x = 0; x <= 2; x++)
            {
                if (listBox8.SelectedIndex == 0 || listBox8.SelectedIndex == 1 || listBox8.SelectedIndex == 2 || listBox8.SelectedIndex == 3 || listBox8.SelectedIndex == 4)
                {
                    if (listBox7.SelectedIndex == 0)
                    {
                        listBox12.Items.Add("Directory1"+ listBox8.SelectedIndex + x.ToString() + ".txt");
                    }

                    else if (listBox7.SelectedIndex == 1)
                    {
                        listBox12.Items.Add("Directory4" + listBox8.SelectedIndex + x.ToString() + ".txt");
                    }
                }
            }
        }
        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox10.Items.Count >= 5)
            {
                for (int i = listBox10.Items.Count - 1; i >= 0; i--)
                {
                    // do with listBox1.Items[i]
                    listBox10.Items.RemoveAt(i);
                }
            }

            for (int x = 0; x <= 4; x++)
            {
                if (listBox9.SelectedIndex == 0)
                {
                    listBox10.Items.Add("Directory2" + x.ToString() + "       >");
                }

                else if (listBox9.SelectedIndex == 1)
                {
                    listBox10.Items.Add("Directory5" + x.ToString() + "       >");
                }
            }
        }
        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox13.Items.Clear();
            for (int x = 0; x <= 2; x++)
            {
                if (listBox10.SelectedIndex == 0 || listBox10.SelectedIndex == 1 || listBox10.SelectedIndex == 2 || listBox10.SelectedIndex == 3 || listBox10.SelectedIndex == 4)
                {
                    if (listBox9.SelectedIndex == 0)
                    {
                        listBox13.Items.Add("Directory2" + listBox10.SelectedIndex + x.ToString() + ".txt");
                    }

                    else if (listBox9.SelectedIndex == 1)
                    {
                        listBox13.Items.Add("Directory5" + listBox10.SelectedIndex + x.ToString() + ".txt");
                    }
                }
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( listBox1.SelectedIndex == 0 ||  listBox1.SelectedIndex == 3 )
            {
                for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    string selecteditem = listBox3.SelectedItem.ToString();
                    listBox11.Items.Remove(selecteditem);
                    listBox3.Items.RemoveAt(listBox3.SelectedIndices[i]);
                }
            }

            if ( listBox1.SelectedIndex == 1 || listBox1.SelectedIndex == 4 )
            {
                for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    string selecteditem = listBox3.SelectedItem.ToString();
                    listBox12.Items.Remove(selecteditem);
                    listBox3.Items.RemoveAt(listBox3.SelectedIndices[i]);
                }
            }

            if ( listBox1.SelectedIndex == 2 || listBox1.SelectedIndex == 5)
            {
                for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                {                   
                    string selecteditem = listBox3.SelectedItem.ToString();
                    listBox13.Items.Remove(selecteditem);
                    listBox3.Items.RemoveAt(listBox3.SelectedIndices[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count == 0)
            {
                MessageBox.Show("Select Directory first!");
            }
            if (listBox3.Items.Count > 0)
            {
                listBox3.Items.Add(textBox1.Text);
                listBox4.Items.Clear();
                listBox4.Items.Add("Content for text file number " + textBox1.Text);
                if (listBox1.SelectedIndex == 0 || listBox1.SelectedIndex == 3 && listBox11.Items.Count > 0 && listBox2.SelectedIndex == listBox6.SelectedIndex)
                {
                    listBox11.Items.Add(textBox1.Text);
                }
                if (listBox1.SelectedIndex == 1 || listBox1.SelectedIndex == 4 && listBox12.Items.Count > 0 && listBox2.SelectedIndex == listBox8.SelectedIndex)
                {
                    listBox12.Items.Add(textBox1.Text);
                }
                if (listBox1.SelectedIndex == 2 || listBox1.SelectedIndex == 5 && (listBox13.Items.Count > 0 && listBox2.SelectedIndex == listBox10.SelectedIndex))
                {
                    listBox13.Items.Add(textBox1.Text);
                } 
            }
            textBox1.Clear();

        }
    }
}
