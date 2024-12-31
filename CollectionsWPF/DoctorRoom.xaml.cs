using System.Windows;
using System.Collections;

namespace CollectionsWPF
{
    /// <summary>
    /// Interaction logic for Doctor_Room.xaml
    /// </summary>
    public partial class Doctor_Room : Window
    {
        Queue name;
        int i=1;
 
        public Doctor_Room(Queue oqueue)
        {
            InitializeComponent();
            lbltokenno.Content = i++;
            name = oqueue;
            lblpatientname.Content = name.Peek().ToString();
            name.Dequeue();
        }

        private void patientbtn_Click(object sender, RoutedEventArgs e)
        {
            if(name.Count==0)
            {
                MessageBox.Show("Done");
            }
            else
            {
                //   int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //   int count = values.Length;
                //for(int i=0;i<count;i++)
                //   {
                //       lbltokenno.Content = values[i].ToString();

                //   }

                lbltokenno.Content = i++;
                lblpatientname.Content = name.Peek().ToString();
                name.Dequeue();
            }
        
        }
    }
}
