using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galileo;
using System.Diagnostics;

namespace DataProcessingForm
{
    public partial class DataProcessingForm : Form
    {
        #region globals
        LinkedList<double> listSensorA = new LinkedList<double>();
        LinkedList<double> listSensorB = new LinkedList<double>();
        #endregion globals
        public DataProcessingForm()
        {
            InitializeComponent();
        }


        private void DataProcessingForm_Load(object sender, EventArgs e)
        {
            textBoxSearchA.Text = muNumUpDown.Value.ToString();
            textBoxSearchB.Text = muNumUpDown.Value.ToString();
        }
        
        private void buttonLoadSensorData_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowAllSensorData();
        }
        
        private void LoadData()
        {
            ReadData galileoRD = new ReadData();
            double mu = (double)muNumUpDown.Value;
            double sigma = (double)sigmaNumUpDown.Value;

            listSensorA.Clear();
            listSensorB.Clear();
            int listSize = 400;
            for (int i = 0; i < listSize; i++)
            {
                listSensorA.AddLast(galileoRD.SensorA(mu, sigma));
                listSensorB.AddLast(galileoRD.SensorB(mu, sigma));
            }
        }

        private void ShowAllSensorData()
        {
            double[,] sensorDataArray = new double[listSensorA.Count(), 2];
            int i = 0;
            foreach (double sensorData in listSensorA)
            {
                sensorDataArray[i, 0] = sensorData;
                i++;
            }
            int j = 0;
            foreach (double sensorData in listSensorB)
            {
                sensorDataArray[j, 1] = sensorData;
                j++;
            }

            listView.Items.Clear();
            for (int k = 0; k < sensorDataArray.GetLength(0); k++)
            {
                listView.Items.Add(new ListViewItem(new[] { sensorDataArray[k, 0].ToString(), sensorDataArray[k, 1].ToString() }));
            }
        }


        private void buttonBinSIteA_Click(object sender, EventArgs e)
        {
            if (SelectionSort(listSensorA))
            { }             
                
            int minNode = 0;
            int maxNode = NumberOfNodes(listSensorA);
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            int listIndex = 0;
            listIndex = BinarySearchIterative(listSensorA, Int32.Parse(textBoxSearchA.Text), minNode, maxNode);

            sw.Stop();
            textBoxIteTicksA.Text = sw.ElapsedTicks.ToString() + " ticks";            
            DisplayListBoxData(listSensorA, listBoxSensorA);
            if (listIndex == maxNode)
            {
                listIndex = maxNode - 1;
            }
            listBoxSensorA.SelectedIndex = listIndex;
            listBoxSensorA.TopIndex = listIndex;
            listBoxSensorA.Focus();
        }
        private void buttonBinSIteB_Click(object sender, EventArgs e)
        {
            if (SelectionSort(listSensorB))
            { }

            int minNode = 0;
            int maxNode = NumberOfNodes(listSensorB);
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            int listIndex = 0;
            listIndex = BinarySearchIterative(listSensorB, Int32.Parse(textBoxSearchB.Text), minNode, maxNode);

            sw.Stop();
            textBoxIteTicksB.Text = sw.ElapsedTicks.ToString() + " ticks";
            DisplayListBoxData(listSensorB, listBoxSensorB);
            if (listIndex == maxNode)
            {
                listIndex = maxNode - 1;
            }
            listBoxSensorB.SelectedIndex = listIndex;
            listBoxSensorB.TopIndex = listIndex;
            listBoxSensorB.Focus();
        }
        private int BinarySearchIterative(LinkedList<double> linkedList, int searchInt, int min, int max)
        {
            max = max - 1;
            while (min <= max)
            {
                int mid = ((min + max) / 2);
                if (searchInt == linkedList.ElementAt(mid))
                {
                    return mid;
                }
                else if (searchInt < linkedList.ElementAt(mid))
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return min;
        }

        private void buttonBinSRecA_Click(object sender, EventArgs e)
        {            
            if (SelectionSort(listSensorA))
            { }

            int minNode = 0;
            int maxNode = NumberOfNodes(listSensorA);
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            int listIndex = 0;
            listIndex = BinarySearchRecursive(listSensorA, Int32.Parse(textBoxSearchA.Text), minNode, maxNode - 1);

            sw.Stop();
            textBoxRecTicksA.Text = sw.ElapsedTicks.ToString() + " ticks";
            DisplayListBoxData(listSensorA, listBoxSensorA);
            if (listIndex == maxNode)
            {
                listIndex = maxNode - 1;
            }
            listBoxSensorA.SelectedIndex = listIndex;
            listBoxSensorA.TopIndex = listIndex;            
            listBoxSensorA.Focus();
        }
        private void buttonBinSRecB_Click(object sender, EventArgs e)
        {
            if (SelectionSort(listSensorB))
            { }

            int minNode = 0;
            int maxNode = NumberOfNodes(listSensorB);
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            int listIndex = 0;
            listIndex = BinarySearchRecursive(listSensorB, Int32.Parse(textBoxSearchB.Text), minNode, maxNode - 1);

            sw.Stop();
            textBoxRecTicksB.Text = sw.ElapsedTicks.ToString() + " ticks";
            DisplayListBoxData(listSensorB, listBoxSensorB);
            if (listIndex == maxNode)
            {
                listIndex = maxNode - 1;
            }
            listBoxSensorB.SelectedIndex = listIndex;
            listBoxSensorB.TopIndex = listIndex;
            listBoxSensorB.Focus();            
        }
        private int BinarySearchRecursive(LinkedList<double> linkedList, int searchInt, int min, int max)
        {            
            if (min <= max)
            {
                int mid = ((min + max) / 2);
                if (searchInt == linkedList.ElementAt(mid))
                {
                    return mid;
                }
                else if (searchInt < linkedList.ElementAt(mid))
                {                    
                    return BinarySearchRecursive(linkedList, searchInt, min, mid - 1);
                }
                else
                {                    
                    return BinarySearchRecursive(linkedList, searchInt, mid + 1, max);
                }
            }
            return min;
        }

        private void buttonSelSortA_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            if (SelectionSort(listSensorA))
            {
                sw.Stop();
                textBoxSelSortSecA.Text = sw.ElapsedMilliseconds.ToString() + " milliseconds";                
                DisplayListBoxData(listSensorA, listBoxSensorA);
            }
        }

        private void buttonSelSortB_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            if (SelectionSort(listSensorB))
            {
                sw.Stop();
                textBoxSelSortSecB.Text = sw.ElapsedMilliseconds.ToString() + " milliseconds";
                DisplayListBoxData(listSensorB, listBoxSensorB);
            }
        }
        private bool SelectionSort(LinkedList<double> linkedList)
        {
            int minIndex = 0;
            int maxNode = NumberOfNodes(linkedList);
            int j;
            for (int i = 0; i < maxNode; i++)
            {
                minIndex = i;
                for (j = i + 1; j < maxNode; j++)
                {
                    if (linkedList.ElementAt(j) < linkedList.ElementAt(minIndex))
                    {
                        minIndex = j;
                    }
                }
                LinkedListNode<double> currentMin = linkedList.Find(linkedList.ElementAt(minIndex));
                LinkedListNode<double> currentINode = linkedList.Find(linkedList.ElementAt(i));
                double tempValue = currentMin.Value;

                currentMin.Value = currentINode.Value;
                currentINode.Value = tempValue;
            }
            return true;
        }
        private void buttonInsSortA_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            if (InsertionSort(listSensorA))
            {
                sw.Stop();
                textBoxInsSortSecA.Text = sw.ElapsedMilliseconds.ToString() + " milliseconds";                
                DisplayListBoxData(listSensorA, listBoxSensorA);
            }
        }

        private void buttonInsSortB_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            if (InsertionSort(listSensorB))
            {
                sw.Stop();
                textBoxInsSortSecB.Text = sw.ElapsedMilliseconds.ToString() + " milliseconds";
                DisplayListBoxData(listSensorB, listBoxSensorB);
            }
        }
        private bool InsertionSort(LinkedList<double> linkedList)
        {
            int maxNode = NumberOfNodes(linkedList);
            int j;
            for (int i = 0; i < maxNode; i++)
            {
                for (j = i; j > 0; j--)
                {
                    if (linkedList.ElementAt(j - 1) > linkedList.ElementAt(j))
                    {
                        LinkedListNode<double> current = linkedList.Find(linkedList.ElementAt(j));
                        LinkedListNode<double> previous = linkedList.Find(linkedList.ElementAt(j - 1));
                        double tempValue = current.Value;

                        current.Value = previous.Value;
                        previous.Value = tempValue;
                    }
                }
            }
            return true;
        }

        private int NumberOfNodes(LinkedList<double> linkedList)
        {
            return linkedList.Count;
        }

        private void DisplayListBoxData(LinkedList<double> linkedList, ListBox listBox)
        {
            listBox.Items.Clear();
            listBox.ClearSelected();
            foreach (double sensorData in linkedList)
            {
                listBox.Items.Add(sensorData);
            }
        }

        private void textBoxSearchA_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxSearchA.Text, out int resultNum))
            {
                MessageBox.Show("Sensor A search target must be numerics only.");
            }
        }

        private void textBoxSearchB_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSearchB.Text, out int resultNum))
            {
                MessageBox.Show("Sensor B search target must be numerics only.");
            }

        }        
    }
}
