namespace EventSourcing.obj
{
    public class Pessoa
    {
        public string Nome {get; protected set;}

        public string Apelido {get; set;}
    }

    public class Funcionario : Pessoa
    {
        public double Salario {get; private set;}


    }

    public async void DefinirCargo(Funcionario peao)
    {
        var joao = Funcionario;

     


    }

    
}