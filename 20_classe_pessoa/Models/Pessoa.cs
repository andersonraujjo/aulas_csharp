namespace _20_classe_pessoa.Models

{public class Pessoa
    {
        private string _nome;
        private int _idade;

        

        public string Nome {
        get
            {
                return _nome.ToUpper();
            }

        
        set //atribuir valor
        {
            if (value == "")
                {
                    throw new ArgumentException ("O nome não pode ser vazio."); // famoso try except
                    
                } 
            _nome = value;
        }
        
        }
        
        public string Sobrenome {get;set;}
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        // aqui o => (body expression) substitui as seguintes linhas:
        // public string NomeCompleto {
        // get
        //     {
        //      return $"{Nome} {Sobrenome}";
        //      }
        //  }



        public int Idade {
            get => _idade;
            set
            {
                if (value <0)
                {throw new ArgumentException ("A idade não pode ser menor que 0.");}
                
                _idade = value;

            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }

}