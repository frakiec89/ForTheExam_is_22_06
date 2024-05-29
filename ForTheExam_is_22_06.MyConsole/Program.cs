using ForTheExam_is_22_06.DB;
// track
while (true)
{
    Menu();
}



void Menu()
{
    Console.WriteLine("Набор команд");
    Console.WriteLine("Авторизация - A");
    Console.WriteLine("Регистрация - R");


    Console.WriteLine("Введите команду:");



    switch (Console.ReadLine())
    {
        case "A": AuthorizationConsole(); break;
        case "R": RegistrationConsole();  break;
        default : Console.WriteLine("Не верная команда");
            break;
    }
}

void RegistrationConsole()
{
    Console.WriteLine("Регистрация пользователя");


    Console.WriteLine("Введите  имя");
    string name = Console.ReadLine();

    Console.WriteLine("Придумайте логин");
    string login = Console.ReadLine();

    string passsword =   GetPassword();
    SqlContext  context = new SqlContext();
    try
    {
        context.Users.Add(new User { Login = login, Name = name, Password = passsword });
        context.SaveChanges();
        Console.WriteLine("Пользователь  сохранен");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
   
}

void AuthorizationConsole()
{

    Console.WriteLine("Введите  логин");
    string login = Console.ReadLine();

    Console.WriteLine("Введите  пароль");
    string  password = Console.ReadLine();
    SqlContext context = new SqlContext();
    try
    {
        User us =  context.Users.SingleOrDefault(x => x.Login == login && x.Password == password);
        if(us != null)
        {
            Console.WriteLine("привет " + us.Name);
        }
        else { Console.WriteLine("Пользователь не найден"); }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


static string GetPassword()
{
    Console.WriteLine("придумайте пароль");
    string password = Console.ReadLine();

    Console.WriteLine("повторите пароль");

    string password2 = Console.ReadLine();

    if (password != password2)
    { 
        Console.WriteLine("Пароли не совподают");
        GetPassword();
    }
    return password;


}