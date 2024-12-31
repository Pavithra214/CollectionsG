using System.Collections;
using System.IO;
using System.Windows;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for Token.xaml
    /// </summary>
    public partial class Token : Window
    {
        Queue oq;
        string Rootpath;
        List<Patient> patients;
        public Token()
        {
            InitializeComponent();
            Rootpath=System.Environment.SpecialFolder.CommonApplicationData.ToString();
            Rootpath = Path.Join(Rootpath, "CollectionsWPF");
            if(!Directory.Exists(Rootpath))
            {
                Directory.CreateDirectory(Rootpath);
            }
            CollectionsWPF.Properties.Settings.Default.Rootpath = Rootpath;
            CollectionsWPF.Properties.Settings.Default.Save();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            if (oq == null)
            {
                oq = new Queue();
            }
            if(oq.Count<10)
            {
                oq.Enqueue(txtname.Text);
                lbltokenno.Content = oq.Count.ToString();
                string directoryname = Path.Join(Rootpath, "Patient Details");
                if (!Directory.Exists(directoryname))
                {
                    
                    Directory.CreateDirectory(directoryname);
                }
                string filename = Path.Join(directoryname, txtname.Text + ".txt");
                string content =$"{ txtname.Text }|{ txtage.Text}|{txtmobile.Text }|{txtaddress.Text}";
                File.WriteAllText(filename, content);
                txtname.Text = "";
                txtage.Clear();
                txtmobile.Clear();
                txtaddress.Clear();
            }
            else
            {
                MessageBox.Show("The token is full.Please come on next day");
                btnsave.IsEnabled = false;
            }
           

        }

        private void drroombtn_Click(object sender, RoutedEventArgs e)
        {
            Doctor_Room dr=new Doctor_Room(oq);
            dr.Show();
        }

        private void gencollbtn_Click(object sender, RoutedEventArgs e)
        {
            //List<string> list = new List<string>();
            //list.Add("Coimbatore");
            //list.Add("Tirupur");
            //list.Add("Chennai");
            //list.Add("Ooty");
            if(patients==null)
            {
                patients = new List<Patient>
                {
new Patient{age=20,name="Kabil",mobileno=9876578907,address="Singapore"},
new Patient{age=50,name="Selvi",mobileno=8668933356,address="Malaysia"},
                };
            }

            //Through user input
            patients.Add(new Patient { age = Convert.ToInt32(txtage.Text), name = txtname.Text, mobileno = Convert.ToInt64(txtmobile.Text), address = txtaddress.Text });
            //Patient objp=new Patient();
            //objp.age = Convert.ToInt32(txtage.Text);
            //objp.name = txtname.Text;
            //objp.mobileno = Convert.ToInt64(txtmobile.Text);
            //objp.address = txtaddress.Text;
            //patients.Add(objp);

            //Patient objp1 = new Patient();
            //objp1.age = 28;
            //objp1.name = "Pavithra";
            //objp1.mobileno = 9876789876;
            //objp1.address = "Coimbatore";
            //patients.Add(objp1);
        }
    }
public class Patient
    {
        public int age;
        public string name;
        public string address;
        public long mobileno;
    }

}

