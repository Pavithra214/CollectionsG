using System.Collections;
using System.Collections.Specialized;
using System.Windows;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for CollectionTypes.xaml
    /// </summary>
    public partial class CollectionTypes : Window
    {
        List<Student> students;
        ArrayList al;
        Dictionary<string, Student> dict;
        Stack<Student> studlist;
        Queue<Customer> customers;

        public CollectionTypes()
        {
            InitializeComponent();
        }

        private void ArrayListbtn_Click(object sender, RoutedEventArgs e)
        {
            al = new ArrayList();
            al.Add("Pavithra");
            al.Add(1000);
            al.Add(true);
            al.Insert(0, "Welcome");
            
            //int count = al.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    MessageBox.Show(al[i].ToString());
            //}
           
            foreach (object item in al)
            {
                MessageBox.Show(item.ToString());
               }
        }

        private void HashTablebtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stackbtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Queuebtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StringColl_Click(object sender, RoutedEventArgs e)
        {
            StringCollection ostring = new StringCollection();
            ostring.Add(txtname.Text);
            ostring.Add("State");
            ostring.Add("City");
            ostring.Add("Area");
        }

        private void GenericList_Click(object sender, RoutedEventArgs e)
        {
            if (students == null)
            {
                students = new List<Student>
                {
  new Student{age=20,name="Kabil",mobileno=9876578907,address="Singapore"},
new Student{age=50,name="Selvi",mobileno=8668933356,address="Malaysia"}
                };
            }
            if ((String.IsNullOrWhiteSpace(txtname.Text)) || (String.IsNullOrWhiteSpace(txtage.Text)) || (String.IsNullOrWhiteSpace(txtmobile.Text)) || String.IsNullOrWhiteSpace(txtaddress.Text))
            {
               
                MessageBox.Show("Kindly enter all the fields");
            }
            else
            {
               
                students.Add(new Student { age = Convert.ToInt32(txtage.Text), name = txtname.Text, mobileno = Convert.ToInt64(txtmobile.Text), address = txtaddress.Text });
            }
            }

        private void GenericHashtable_Click(object sender, RoutedEventArgs e)
        {
            if(dict==null)
            {
                dict = new Dictionary<string, Student>();
            }
           
            dict.Add("Item1",new Student { name= "Pavitra",age=30,mobileno=98765678,address="CBE"});
            dict.Add("Item2", new Student { name = "Naveen", age = 30, mobileno = 6786754634, address = "TUP" });

            dict.Add("Item",new Student { name=txtname.Text,age=Convert.ToInt32(txtage.Text),mobileno=Convert.ToInt64(txtmobile.Text),address=txtaddress.Text});

           foreach(KeyValuePair<string, Student> kvp in dict)
            {
                MessageBox.Show(kvp.Key);
                Student v= kvp.Value;
                
            }

        }

        

        private void GenericsStack_Click(object sender, RoutedEventArgs e)
        {
            if ((studlist==null))
            {
                studlist = new Stack<Student>();
            }
          
            studlist.Push(new Student {name=txtname.Text,age=Convert.ToInt32(txtage.Text),mobileno=Convert.ToInt64(txtmobile.Text),address=txtaddress.Text});
        }

        private void GenericQueue_Click(object sender, RoutedEventArgs e)
        {
            if(customers==null)
            {
                customers = new Queue<Customer>();
            }
           
      customers.Enqueue(new Customer {name=txtname.Text,age=Convert.ToInt32(txtage.Text),mobileno = Convert.ToInt64(txtmobile.Text), address=txtaddress.Text});
        }

        private void GenericSortedList_Click(object sender, RoutedEventArgs e)
        {
            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("NOP", 2);
            sl.Add("XYZ", 3);
            sl.Add("ABC", 1);
        }

        private void GenericSortedDict_Click(object sender, RoutedEventArgs e)
        {
            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
            sd.Add("NOP", 2);
            sd.Add("XYZ", 3);
            sd.Add("ABC", 1);
        }
    }
    public class Student
    {
        public int age;
        public string name;
        public long mobileno;
        public string address;
    }
    public class Customer
    {
        public int age;
        public string name;
        public long mobileno;
        public string address;
    }
}
