using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace See4urselfAnimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            lstAnimalList.Items.Add(lstNewAnimals.SelectedItem);

        }

        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int index = lb.IndexFromPoint(e.X, e.Y);

            if (index != -1 && lb != lstAnimalList)
            {
                DragDropEffects effect = lb.DoDragDrop(lb.Items[index].ToString(),
                    DragDropEffects.Copy);
            }
        }


        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.Move;
        }

        private void lstAnimalList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                if (lstAnimalList.Items.Contains(e.Data.GetData(DataFormats.Text)))
                {
                    lstAnimalList.AllowDrop = false;
                    lstAnimalList.AllowDrop = true;
                }
                else
                {

                    int index = lstAnimalList.IndexFromPoint(lstAnimalList.PointToClient(
                                                                new Point(e.X, e.Y)));
                    if (index >= 0 && index < lstAnimalList.Items.Count)
                    {
                        lstAnimalList.Items.Insert(index,
                         e.Data.GetData(DataFormats.Text));
                    }
                    else
                    {
                        // add the selected string to bottom of list
                        lstAnimalList.Items.Add(e.Data.GetData(DataFormats.Text));
                    }
                }
            }
        }

        private void Save(object sender, EventArgs e)
        {
            // Open file
            StreamWriter write = new StreamWriter("AnimalsList.txt");
            if (write == null) return;
            foreach (var item in lstAnimalList.Items)
                write.WriteLine(item.ToString());
            write.Close();
        }


        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {

            StreamReader reader = new StreamReader("NewAnimals.txt");
            if (reader == null) return;
            string input;
            while ((input = reader.ReadLine()) != null)
            {
                lstNewAnimals.Items.Add(input);
            }
            reader.Close();

            using (StreamReader rs = new StreamReader("AnimalList.txt"))
            {
                input = null;
                while ((input = rs.ReadLine()) != null)
                {
                    lstAnimalList.Items.Add(input);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("Bây giờ là {0}:{1}:{2} {3}-{4}-{5}",
                                        DateTime.Now.Hour,
                                        DateTime.Now.Minute,
                                        DateTime.Now.Second,
                                        DateTime.Now.Month,
                                        DateTime.Now.Day,
                                        DateTime.Now.Year);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            lstAnimalList.Items.Remove(lstAnimalList.SelectedItem);
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            StreamWriter write = new StreamWriter("AnimalsList.txt");
            if (write == null) return;
            foreach (var item in lstAnimalList.Items)
                write.WriteLine(item.ToString());
            write.Close();
        }
    }

}
