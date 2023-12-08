namespace csharp_poo;

public interface IUser {
    string Register(string email, string password, string username);
    string Login();
}

public class Person(string name, string cpf, int age) {
    public string? Name { get; set; } = name;
    public string? CPF { get; set; } = cpf;
    public int Age { get; set; } = age;
}

public class User(string name, string cpf, int age) : Person(name, cpf, age), IUser {
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? Username { get; set; }

    public string Login()
    {
        string text = Username + " Logado com sucesso";
        return text;
    }

    public string Register(string email, string password, string username)
    {
        Email = email;
        Password = password;
        Username = username;
        return "Usuário registrado com sucesso";
    }
}