using CollectionsWPF.Model;
using Newtonsoft.Json;
using System.Windows;
using System.IO;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        List<Employee> employees;
        
        public Reg()
        {
            InitializeComponent();
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists("C:\\Users\\PAVITHRA\\AppData\\Roaming\\CollectionsWPF"))
            {
                Directory.CreateDirectory("C:\\Users\\PAVITHRA\\AppData\\Roaming\\CollectionsWPF");
            }

            string filepath = Path.Join(path, "CollectionsWPF", "userdata.txt");
            string readdata = File.ReadAllText(filepath);
            employees = JsonConvert.DeserializeObject<List<Employee>>(readdata);


        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            if (employees == null)
            {
                employees= new List<Employee>();
            }
            int idvalue = employees.Count + 1;
            int age=Convert.ToInt32(txtage.Text);
            employees.Add(new Employee { Id = idvalue,Name=txtname.Text,UserName=txtusername.Text,Age=age,Password=pbpassword.Password });
           
            
            //JSON CONVERSION
            string userdata=JsonConvert.SerializeObject(employees);

            //File Path
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists("C:\\Users\\PAVITHRA\\AppData\\Roaming\\CollectionsWPF"))
            {
                Directory.CreateDirectory("C:\\Users\\PAVITHRA\\AppData\\Roaming\\CollectionsWPF");
            }
            
     string filepath=Path.Join(path,"CollectionsWPF","userdata.txt");
            File.WriteAllText(filepath, userdata);
             
            Listuser.ItemsSource = null;
            Listuser.ItemsSource = employees;
        }

        private void Listuser_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
Employee emp=Listuser.SelectedItem as Employee;
            if (emp != null)
            {
                txtname.Text = emp.Name;
                txtusername.Text = emp.UserName;
                txtage.Text = emp.Age.ToString();
                pbpassword.Password = emp.Password;

            }
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Close();

            //LINQ
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            var listnum=from x in numbers
                        where (x%2==0)
                        orderby x descending
                        select x;
            int[] result = listnum.ToArray();
            int count = result.Count();


            //Lamba expression
              var numlam=numbers.Where(x=>x%2==0);
              int[] reslam=numlam.ToArray();

            //LINQ
              //int[] numbers= { 1, 50, 45, 3, 98, 100, 5000 };
              //var num=from x in numbers
              //        where x > 50
              //        select x;
              //int[] numarray = num.ToArray();

            //Lambda Expression
               //var result1 = numbers.Where(x => x > 5);
               //int[] result2 = result1.ToArray();
           


            //foreach (int number in numbers)
            //{
            //    if(number>50)
            //    {
            //        MessageBox.Show(number.ToString());
            //    }
            //}

        }
    }
}
