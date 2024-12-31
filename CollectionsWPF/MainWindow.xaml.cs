using System.Windows;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void arraylistbtn_Click(object sender, RoutedEventArgs e)
        {
        //    al=new ArrayList();
        //    MessageBox.Show(al.Count.ToString());
        //    al.Add("Nithya");
        //    MessageBox.Show(al.Count.ToString());
        //    al.Add("1");
        //    al.Insert(0, "Nithya");
        //    MessageBox.Show(al.Count.ToString());
        }



        private void getALbtn_Click(object sender, RoutedEventArgs e)
        {
        //    al = new ArrayList();
        //    al.Add("Pavithra");
        //    al.Add(1000);
        //    al.Add(true);
        //    //int count = al.Count;
        //    //for (int i = 0; i < count; i++)
        //    //{
        //    //    MessageBox.Show(al[i].ToString());
        //    //}
        //    cmbarraylist.ItemsSource = al;
        //    cmbarraylist.SelectedIndex = 0;
        //    foreach (object item in al)
        //    {
        //        MessageBox.Show(item.ToString());
        //    }

        }
        private void hashtablebtn_Click(object sender, RoutedEventArgs e)
        {
        //  Hashtable ht = new Hashtable();
        //    ht.Add("sname","Magizhan");
        //    ht.Add("ssalary",2000);
        //    ht.Add("sage",1);

        //    //cmbhashtable.DisplayMemberPath = "Value";
        //    //cmbhashtable.SelectedValuePath = "Key";
        //    cmbhashtable.DisplayMemberPath = "Key";
        //    cmbhashtable.SelectedValuePath = "Value";

        //    cmbhashtable.ItemsSource = ht;
        //    cmbhashtable.SelectedIndex = 0;

        //    //ht.Add("sage", 2); WIll thrown an error since the key is repeated
        //    //if(ht.ContainsKey("sname"))
        //    //{
        //    //    MessageBox.Show(ht["sname"].ToString());
        //    //}

        //    //foreach(object item in ht.Keys)
        //    //{
        //    //    MessageBox.Show(item.ToString());
        //    //}

        //    //foreach (object item in ht.Values)
        //    //{
        //    //    MessageBox.Show(item.ToString());
        //    //}

        //    //foreach (DictionaryEntry item in ht)
        //    //{
        //    //    MessageBox.Show(item.Key.ToString()+":"+item.Value.ToString());
        //    //}
        }

        private void cmbhashtable_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
        //    //MessageBox.Show(cmbhashtable.SelectedItem.ToString());
        //    MessageBox.Show(cmbhashtable.SelectedValue.ToString());
        }

        private void btnstack_Click(object sender, RoutedEventArgs e)
        {
        //    Stack ostack = new Stack();
        //    ostack.Push("Stack Item 1");
        //    ostack.Push("Stack Item 2");
        //    ostack.Push("Stack Item 3");
        //    ostack.Push("Stack Item 4");
        //    ostack.Push("Stack Item 5");

        //    MessageBox.Show(ostack.Peek().ToString());
        //    ostack.Pop();
        //    foreach (object item in ostack)
        //    {
        //        MessageBox.Show(item.ToString());
        //    }
        //    ostack.Clear();


        }

        private void btnqueue_Click(object sender, RoutedEventArgs e)
        {
        //    Queue oq= new Queue();
        //    oq.Enqueue("Queue Item 1");
        //    oq.Enqueue("Queue Item 2");
        //    oq.Enqueue("Queue Item 3");
        //    oq.Enqueue("Queue Item 4");
        //    oq.Enqueue("Queue Item 5");
        //    MessageBox.Show(oq.Peek().ToString());
        //    foreach(object item in oq)
        //    { 
        //        MessageBox.Show(item.ToString()); 
        //    }
        //    oq.Clear();


        }
    }
}