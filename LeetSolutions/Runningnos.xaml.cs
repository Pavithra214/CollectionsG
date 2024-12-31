using System.Windows;

namespace LeetSolutions
{
    /// <summary>
    /// Interaction logic for Runningnos.xaml
    /// </summary>
    public partial class Runningnos : Window
    {
        public Runningnos()
        {
            InitializeComponent();
            int a,b,c;
        }
      

        private void problmsolving_Click(object sender, RoutedEventArgs e)
        {
            string s = "Hello World";
            int last = s.LastIndexOf(" ");
            string result = s.Substring(last);
            int cont = result.Length;
            cont--;
            MessageBox.Show(cont.ToString());
        }
    }
}
