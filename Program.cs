using csharp_poo;

User user01 = new(
    name: "Matheus",
    cpf: "122.215.936-85",
    age: 28
);

string reg = user01.Register(
    email: "santos95.mat@gmail.com",
    password: "Mortadela@5",
    username: "santos95mat"
);

Console.WriteLine(user01.Email);