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
        /*
         * 4.1	
         * Create two data structures using the LinkedList<T> class from the C# Systems.Collections.Generic
         * namespace. The data must be of type “double”; you are not permitted to use any additional classes,
         * nodes, pointers or data structures (array, list, etc) in the implementation of this application. The two
         * LinkedLists of type double are to be declared as global within the “public partial class”.
         */
        LinkedList<double> listSensorA = new LinkedList<double>();
        LinkedList<double> listSensorB = new LinkedList<double>();
        public DataProcessingForm()
        {
            InitializeComponent();
        }
        private void DataProcessingForm_Load(object sender, EventArgs e)
        {
            textBoxSearchA.Text = muNumUpDown.Value.ToString();
            textBoxSearchB.Text = muNumUpDown.Value.ToString();
        }
        /* 4.4	
         * Create a button and associated click method that will call the LoadData and ShowAllSensorData 
         * methods. The input parameters are empty, and the return type is void.
         */
        private void buttonLoadSensorData_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowAllSensorData();
        }
        /*
         * 4.2
         * Copy the Galileo.DLL file into the root directory of your solution folder and add the appropriate 
         * reference in the solution explorer. Create a method called “LoadData” which will populate both 
         * LinkedLists. Declare an instance of the Galileo library in the method and create the appropriate loop
         * construct to populate the two LinkedList; the data from Sensor A will populate the first LinkedList, 
         * while the data from Sensor B will populate the second LinkedList. The LinkedList size will be 
         * hardcoded inside the method and must be equal to 400. The input parameters are empty, and the 
         * return type is void.
         */
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
        /* 4.3	
         * Create a custom method called “ShowAllSensorData” which will display both LinkedLists in a 
         * ListView. Add column titles “Sensor A” and “Sensor B” to the ListView. The input parameters 
         * are empty, and the return type is void.
         */
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
        #endregion globals

        #region utility methods
        /* 4.5	
         * Create a method called “NumberOfNodes” that will return an integer which is the number of 
         * nodes(elements) in a LinkedList. The method signature will have an input parameter of type 
         * LinkedList, and the calling code argument is the linkedlist name.
         */
        private int NumberOfNodes(LinkedList<double> linkedList)
        {
            return linkedList.Count;
        }
        /* 4.6	
         * Create a method called “DisplayListboxData” that will display the content of a LinkedList inside
         * the appropriate ListBox. The method signature will have two input parameters; a LinkedList, and the 
         * ListBox name.  The calling code argument is the linkedlist name and the listbox name.
         */
        private void DisplayListBoxData(LinkedList<double> linkedList, ListBox listBox)
        {
            listBox.Items.Clear();
            listBox.ClearSelected();
            foreach (double sensorData in linkedList)
            {
                listBox.Items.Add(sensorData);
            }
        }
        #endregion utility methods

        #region sort and search methods
        /* 4.7	
         * Create a method called “SelectionSort” which has a single input parameter of type LinkedList, while
         * the calling code argument is the linkedlist name. The method code must follow the pseudo code 
         * supplied below in the Appendix. The return type is Boolean.
         */
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
        /*
         *  4.8	
         *  Create a method called “InsertionSort” which has a single parameter of type LinkedList, while the 
         *  calling code argument is the linkedlist name. The method code must follow the pseudo code supplied 
         *  below in the Appendix. The return type is Boolean.
         */
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
        /*
         * 4.9	
         * Create a method called “BinarySearchIterative” which has the following four parameters: LinkedList, 
         * SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist element 
         * from a successful search or the nearest neighbour value. The calling code argument is the linkedlist
         * name, search value, minimum list size and the number of nodes in the list. The method code must 
         * follow the pseudo code supplied below in the Appendix.
         */
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
        /*
         *  4.10	
         *  Create a method called “BinarySearchRecursive” which has the following four parameters: LinkedList, 
         *  SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist element
         *  from a successful search or the nearest neighbour value. The calling code argument is the linkedlist
         *  name, search value, minimum list size and the number of nodes in the list. The method code must 
         *  follow the pseudo code supplied below in the Appendix.
         */
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
        #endregion sort and search methods

        #region UI button methods
        /*
         *  4.11	
         *  Create four button click methods that will search the LinkedList for a value entered into a textbox on 
         *  the form. The four methods are: 
         *  1.	Method for Sensor A and Binary Search Iterative
         *  2.	Method for Sensor A and Binary Search Recursive
         *  3.	Method for Sensor B and Binary Search Iterative
         *  4.	Method for Sensor B and Binary Search Recursive
         *  The search code must check to ensure the data is sorted, then start a stopwatch before calling the
         *  search method. Once the search is complete the stopwatch will stop and the number of ticks will be 
         *  displayed in a read only textbox. Finally, the code will call the “DisplayListboxData” method and 
         *  highlight the appropriate number (or the next closest number).
         */
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

        /*
         * 4.12	
         * Create four button click methods that will sort the LinkedList using the Selection and Insertion
         * methods. The four methods are:
         * 1.	Method for Sensor A and Selection Sort
         * 2.	Method for Sensor A and Insertion Sort
         * 3.	Method for Sensor B and Selection Sort
         * 4.	Method for Sensor B and Insertion Sort
         * The button method must start a stopwatch before calling the sort method. Once the sort is complete 
         * the stopwatch will stop and the number of milliseconds will be displayed in a read only textbox.
         * Finally, the code will call the “ShowAllSensorData” method and “DisplayListboxData” for the 
         * appropriate sensor.
         */
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
        /*
         * 4.14	
         * Add two textboxes for the search value; one for each sensor, ensure only numeric values can be 
         * entered.
         */
        private void textBoxSearchA_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSearchA.Text, out int resultNum))
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
        #endregion UI button methods
    }
}
