using CollectionsWPF.Model;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using Newtonsoft.Json;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        List<Employee> employees;
        public Search()
        {
            InitializeComponent();
            string path=System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string filepath = Path.Join(path, "Collectionswpf", "Userdata.txt");
            string readdata=File.ReadAllText(filepath);
            employees = JsonConvert.DeserializeObject<List<Employee>>(readdata);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
           
            string cs = combosearch.Text;
                if (employees != null)
                {
                    if (cs == "Name")
                    {
                    var list = from emp in employees
                               where emp.Name.ToLower().Contains(searchtxt.Text.ToLower())

                               //sort by ascending order: order
                                    //orderby emp.Name ascending
                               //will group the members by their age
                                     group emp by emp.Age.ToString();
                        Listuser.ItemsSource = null;
                        Listuser.ItemsSource = list.ToList();
                    }
                   else if(cs=="UserName")
                    {
                    //LINQ
                        //var list = from emp in employees
                        //           where emp.UserName.ToLower().Contains(searchtxt.Text.ToLower())
                        //           select emp;

                    //LAMBDA
                    var listlamba=employees.Where(emp => emp.UserName.ToLower().Contains(searchtxt.Text.ToLower()));
                        
                        Listuser.ItemsSource = null;
                        Listuser.ItemsSource = listlamba.ToList();
                    }
                    else if (cs == "Age")
                    {
                    //LINQ
                    //var list = from emp in employees
                    //           where emp.Age==Convert.ToInt32(searchtxt.Text)
                    //           select emp;

                    //LAMBDA
                    var listlambda = employees.Where(emp => emp.Age == Convert.ToInt32(searchtxt.Text));
                        
                        Listuser.ItemsSource = null;
                        Listuser.ItemsSource = listlambda.ToList();
                    }
                }

            
        }

        private void Listuser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void combosearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
