ExibirInfo();

void ExibirInfo()
{
    Divisa();
    Console.WriteLine("\nSeja bem-vindo! Aqui eu testo algumas habilidades em OOP!");
    Divisa();

}

void Divisa()
{
    Console.WriteLine("\n=================================================================================");  
}

void Menu()
{
    //string numeroOpcao = Console.ReadLine()!;
    //int numeroOpcaoInt = int.Parse(numeroOpcao);

    Console.WriteLine("\nDigite 1 para acessar os Dados Pessoais");
    Console.WriteLine("Digite 2 para acessar os Formação");
    Console.WriteLine("Digite 3 para acessar os Conhecimento");
    Console.WriteLine("\nDigite sua opção:");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: DadosPessoais();    break;
        case 2: Formacao();         break;
        case 3: Conhecimento();      break;

        //case 3: Console.WriteLine("Fim de papo"); break;
    }


}

void DadosPessoais()
{
    //Tipagem de dados
    string nome = "Fellipi Borges";
    int idade = 28;
    string endereco = "Aviso de Privacidade e de Proteção de Dados Pessoais";
    string numeroEndereco = "71";

    Console.Clear();

    Console.WriteLine($"Nome: {nome}, {idade}");
    Console.WriteLine($"Endereço: {endereco}, {numeroEndereco}");

    Menu();
    Console.Clear();
}

void Formacao()
{
    //Atribuindo valores a variaveis
    var faculdade = "Estácio de Sá";
    var graduacao = "Analise e Desenvolvimento de Sistemas";
    var anoGraduacao = 2025;
    double coeficiente = 8.5;

    Console.Clear();

    Console.WriteLine($"Faculdade: {faculdade}, Graduação: {graduacao}");
    Console.WriteLine($"Ano Graduação: {anoGraduacao}");
    Console.WriteLine($"CR: {coeficiente}");    
    
    Menu();
    Console.Clear();
}
        
void Conhecimento()
{
    Console.Clear();

    List<string> cursos = new List<string>();
    cursos.Add("Modelagem de Dados - Alura(04-08-2023)");
    cursos.Add("Git & GitHub: repositório, commit e versões - Alura(16-11-2022)");
    cursos.Add("SQL Server 2022: Manipulando dados - Alura(07-08-2022)");

    foreach(string c in cursos)
    {
        Console.WriteLine("Curso: {0}", c);
    }

    Menu();
    Console.Clear();

}

Menu();



