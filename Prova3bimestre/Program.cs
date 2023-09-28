using Prova3bimestre;

while (true)
{
    Console.WriteLine("Deseja realizar o cadastro de 1- Medico ou 2- Funcionario administrativo?");
    int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

    if (opcaoDesejada == 1)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        Console.Write("Matricula: ");
        int matricula = Convert.ToInt32(Console.ReadLine());

        Console.Write("Data de nascimento: ");
        int dataNasc = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sexo: ");
        string sexo = Console.ReadLine();

        Console.Write("Salario: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("CRM: ");
        string crm = Console.ReadLine();

        Console.Write("Especialidade: ");
        string espec = Console.ReadLine();

        Console.Write("Valor de hora extra: ");
        double valorExtra = Convert.ToDouble(Console.ReadLine());



        Medico m = new Medico();
        m.Nome = nome;
        m.CPF = cpf;
        m.Matricula = matricula;
        m.DataNascimento = dataNasc;
        m.Sexo = sexo;
        m.Salario = salario;
        m.CRM = crm;
        m.especialidade = espec;
        m.ValorHoraExtra = valorExtra;

        List<Medico> listaMedico = new List<Medico>();
        listaMedico.Add(m);

        Console.WriteLine($"O salario é {salario + (salario*0.22)}");
    }

    else if (opcaoDesejada == 2)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        Console.Write("Matricula: ");
        int matricula = Convert.ToInt32(Console.ReadLine());

        Console.Write("Data de nascimento: ");
        int dataNasc = Convert.ToInt32(Console.ReadLine());


        Console.Write("Sexo: ");
        string sexo = Console.ReadLine();

        Console.Write("Salario: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Função: ");
        string funcao = Console.ReadLine();

        Administrador adm = new Administrador();
        adm.Nome = nome;
        adm.CPF = cpf;
        adm.Matricula = matricula;
        adm.DataNascimento = dataNasc;
        adm.Sexo = sexo;
        adm.Salario = salario;
        adm.funcao = funcao;

        List<Administrador> listaAdm = new List<Administrador>();
        listaAdm.Add(adm);
    }
}

   
    



