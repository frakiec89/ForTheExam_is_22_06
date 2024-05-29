using ForTheExam_is_22_06.DB;
using System.Windows;

// track

namespace ForTheExam_is_22_06.MyWPF
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

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            SqlContext context = new SqlContext();
            try
            {
                User us = context.Users.SingleOrDefault(x => x.Login == tbLogin.Text 
                && x.Password == tbPassword.Text);
                if (us != null)
                {
                  MessageBox.Show("привет " + us.Name);
                }
                else { MessageBox.Show("Пользователь не найден"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowsAddUser windows = new WindowsAddUser();
            windows.ShowDialog();
        }
    }
}