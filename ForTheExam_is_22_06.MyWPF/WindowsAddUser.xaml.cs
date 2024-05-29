using ForTheExam_is_22_06.DB;

using System.Windows;
// track
namespace ForTheExam_is_22_06.MyWPF
{
    /// <summary>
    /// Логика взаимодействия для WindowsAddUser.xaml
    /// </summary>
    public partial class WindowsAddUser : Window
    {
        public WindowsAddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = tbName.Text;

           
            string login = tbLogin.Text;

            string passsword = tbPassword.Text;
            string passsword2 = tbPassword2.Text;

            if(passsword != passsword2 )
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }


            SqlContext context = new SqlContext();
            try
            {
                context.Users.Add(new User { Login = login, Name = name, Password = passsword });
                context.SaveChanges();
                MessageBox.Show("Пользователь  сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
