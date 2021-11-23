using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa!"); //msg de boas-vidas
            Menu1();
        }
        public static void Menu1() //menu Menu1 dentro desta apresenta tudo o que esta na Menu1

        {   
            int escolha,  option=1, opcao; //declarar as variaveis do tipo inteiro 
            while(option != 0) //caso a opção for diferente de zero 
            { 
                Console.WriteLine("Escolha uma das seguintes opções :\n 1 - Calculadora\n 2 - Lista de númeos\n 3 - Calendario\n 4 - Parimpar\n 5 - Sair"); //imprimir o numero de opçoes possiveis 
                escolha = int.Parse(Console.ReadLine());  //armazenar escolha em tipo inteiro   
                if (escolha == 1) //se opção for a 1
                {
                    calculadora(); //ir para o menu calculadora
                    
                }
                else if (escolha == 2) //se opção for a 2
                {
                    lista();//ir para o menu lista
                }
                else if (escolha == 3)//se opção for a 3
                {
                    calendario();//ir para o menu calendario

                }
                else if (escolha == 4) //se opção for a 4
                {
                    parimpar();//ir para o menu parimpar
                }


                else if (escolha == 5) //se opção for a 5
                    //Console.Clear();
                {
                    Console.Clear(); //apagar no que esta na consola

                    Console.WriteLine("Deseja fechar o programa ?\n 1-Sim\n 2-Não"); // escrever as varias opções possiveis 
                    opcao = int.Parse(Console.ReadLine()); //armazenar na variavel opcao do tipo inteiro

                    if (opcao == 1)//se o valor for 1
                    {
                        Environment.Exit(0); //sair dirretamente da consola
                    }
                    else if (opcao == 2) //se o valor for 2
                    {
                        Console.Clear();//apagar no que esta na consola
                        Menu1();//ir para o menu 1 
                    }
                    else //caso as opçoes de cima n forem validas 
                    {
                        
                        Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                        Thread.Sleep(2000); //tempo de espera de 2.0s
                        Console.Clear();//apagar no que esta na consola
                        Menu1();//ir para o menu 1 
                    }
                    Console.Clear(); //apagar no que esta na consola
                }
            }
        }

        private static void parimpar() //menu parimpar dentro desta apresenta tudo o que esta na parimpar
        {
            double a; //declarar o mp em double  
            int mp; //declarar o mp em int 
            Console.Clear();//apagar no que esta na consola
            Console.WriteLine("Insira o numero que deseja"); //pedir ao utilizador o valor que deseja 
            a = double.Parse(Console.ReadLine()); //armazenar a variavel a double 
            if (a % 2 == 0) //calcula se o numero é par, sendo par quando nao tem resto 
            {
                Console.WriteLine("\nO número é par"); //apresentar que o numero é par
                Console.WriteLine("\n\nPara voltar ao menu principal clique no 0 (caso não queira volte clique noutra)");//caso o user pretenda voltar ao menu principal clique no 0
                mp = int.Parse(Console.ReadLine());//ler e armazenar em "mp"
                Console.Clear();//limpar a consola toda
                if (mp == 0)//se mp for igual a 0
                {
                    Menu1();//volta para o menu principal
                }
            }
            else//se nao 
            {
                Console.WriteLine("\nO número é impar");//apresentar que o numero é impar
                Console.WriteLine("\n\nPara voltar ao menu principal clique no 0 (caso não queira volte clique noutra)");//caso o user pretenda voltar ao menu principal clique no 0
                mp = int.Parse(Console.ReadLine());//ler e armazenar em "mp"
                Console.Clear();//limpar a consola toda
                if (mp == 0)//se mp for igual a 0
                {
                    Menu1();//ir para o menu 1 
                }
            }

        }

        private static void calendario()//menu calendario dentro desta apresenta tudo o que esta na calendario
        {
            
            int local; //delcrar uma variavel do tipo inteiro 
            Console.Clear ();//apagar no que esta na consola
            Console.WriteLine("Entras-te no calendario "); //msg de boas bem-vindas para o calendario 
            Console.WriteLine("Escolha uma das seguintes opções :\n 1 - Verificar se o ano é bissexto \n 2 - Transformar  dias em anos, semanas e dias.\n 3 - Voltar ao menu anterior "); //apresentar o menu de opções 
            local = int.Parse(Console.ReadLine()); //armazenar a escolha em local em tipo inteiro 

            
            if (local == 1)//se o valor for 1 
            {
                Console.Clear();//apagar no que esta na consola
                int ano; //declar a varivel do tipo inteiro 
                Console.WriteLine("Escolha um ano"); // pedir ao utilizador um ano 
                ano = int.Parse(Console.ReadLine()); // armazenar na varivel ano 

                if (ano % 4 == 0) //verificar se o ano é bissexto
                {
                    Console.WriteLine("O ano é bissexto");// imprimir o ano é bissexto
                }
                else // se não 
                {
                    Console.WriteLine("O ano não é bissexto"); // imprimir o ano n é bissexto
                }
                Thread.Sleep(2500);//tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
            }
            else if (local == 2)//se o valor for 2 
            {
                Console.Clear();//apagar no que esta na consola
                int dias, anos, semanas, dias2, anos2; // declarar variaveis do tipo inteiro
                Console.WriteLine("Insira o valor de dias:"); //pedir ao utilziador o valor de dias 
                dias = int.Parse(Console.ReadLine()); //armazenar na variavel dias 

                anos = dias / 365; // calcular os anos 
                anos2 = dias % 365; // calcular os dias que sobram
                semanas = anos2 / 7; // calcular as semanas 
                dias2 = anos2 % 7; // calcular os dias que sobram

                Console.Clear();//apagar no que esta na consola

                Console.WriteLine("Tem " + anos + " ano/s , tem " + semanas + " semana/s e tem " + dias2 + " dias. "); //imprimir or resultado 
                Thread.Sleep(2500);//tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola

            }


            else if (local == 3) //se o valor for 3
            {
                Console.Clear();//apagar no que esta na consola
                Menu1();//ir para o menu 1 
            }
            else //se todas as outras opçoes n forem executadas 
            {

                Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1(); //ir para o menu 1 
            }

        }

        public static void lista()//menu lista dentro desta apresenta tudo o que esta na lista
        {
            Console.Clear(); //apagar no que esta na consola
            Console.WriteLine("Entraste na lista"); //msg de bem-vindo ao programa 

            int var1, var2, en;
            Console.WriteLine("Insira o primeiro numero");//pedir ao utilzador o primeiro valor 
            var1 = int.Parse(Console.ReadLine());//armazenar em var2 com inteiro 
            Console.WriteLine("Insira o sugundo numero");//pedir ao utilzador o segudno valor 
            var2 = int.Parse(Console.ReadLine());//armazenar em var2 com inteiro 

            if (var1 < var2) //se var1 for menor do que var2

            {
                Console.WriteLine("Os numeros entre " +var1+ " e " +var2+ " são");//concatenar o reusltado e apresentar os valores 

                for (int i = var1; i < var2; i++)// ciclo for os numeros tem de ser iguais ao cvar 2 e tem de ser menores do que var1
                {
                    Console.WriteLine(i);//imprimir o i (valores entre a var2 e var2)
                }
                Thread.Sleep(3000);//tempo de espera de 3.0s
                Console.Clear();//apagar no que esta na consola


            }
            else if (var2 < var1)//se var2 for menor do que var1
            {
                Console.WriteLine("Os numeros entre " + var2 + " e " + var1 + " são"); //concatenar o reusltado e apresentar os valores 
                for (int i = var2; i < var1; i++)// ciclo for os numeros tem de ser iguais ao var 1 e tem de ser menores do que var2
                {
                    Console.WriteLine(i); //imprimir o i (valores entre a var2 e var1)
                }
                Thread.Sleep(3000);//tempo de espera de 3.0s
                Console.Clear();//apagar no que esta na consola


            }
            else if ( var2 == var1)
            {
                Console.WriteLine("Os valores são iguais");//imprimir os valores são iguais pq tem o mesmo valor 
                Thread.Sleep(3000);//tempo de espera de 3.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();//ir para o menu 1 

            }
            else 
            {

                Console.WriteLine("Não existe este menu. Tente outro "); //imprimir se houver algum erro
                Thread.Sleep(3000); //tempo de espera de 3.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();//ir para o menu 1 
            }


        }

        public static void calculadora() //menu calculadora dentro desta apresenta tudo o que esta na calculadora
        {
            Console.Clear();//apagar no que esta na consola
            int operadores; //declarar a variavel operadores do tipo inteiro 
            Console.WriteLine("Entraste na calculadora."); //msg de ben-vindo a calculadora
            Console.WriteLine("Escolha uma das seguintes opções :\n 1 - Somar \n 2 - Subtrair\n 3 - Multiplação\n 4 - Divisão\n 5 - Raiz Quadrada \n 6 - Elevado \n 0 - Voltar ao menu anterior "); //print para escolher o menu 
            operadores = int.Parse(Console.ReadLine()); //armazenar a escolha que pretende fazer 
            double  n1 , n2, contas; //declarar as variveis n1, n2 , contas do tipo double 
            Console.Clear();//apagar no que esta na consola
            if (operadores == 1) //se o valor for 1

            {
                Console.WriteLine("Insira o primeiro numero"); //pedir ao utilzador o primeiro valor 
                n1 = double.Parse(Console.ReadLine());//armazenar em n1 com double 
                Console.WriteLine("Insira o sugundo numero");//pedir ao utilzador o segundo valor 
                n2 = double.Parse(Console.ReadLine());//armazenar em n2 com double 
                contas = n1 + n2; //algoritmo de adição
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine(+n1 + " + " + n2 + " = " + contas);// apresentar o resultado concatenado
                Thread.Sleep(2500);//tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menu1(); //ir para o menu 1 

            }

            else if (operadores == 2) //se o valor for 2

            {
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine("Insira o primeiro numero");//pedir ao utilzador o primeiro valor 
                n1 = double.Parse(Console.ReadLine());//armazenar em n1 com double 
                Console.WriteLine("Insira o segundo numero");//pedir ao utilzador o segundo valor 
                n2 = double.Parse(Console.ReadLine());//armazenar em n2 com double 
                contas = n1 - n2;//algoritmo de subtração
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine(+n1 + " - " + n2 + " = " + contas);// apresentar o resultado concatenado
                Thread.Sleep(2500);//tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menu1(); //ir para o menu 1 

            }
            else if (operadores == 3) //se o valor for 3

            {
                Console.Clear(); //apagar no que esta na consola
                Console.WriteLine("Insira o primeiro numero");//pedir ao utilzador o primeiro valor 
                n1 = double.Parse(Console.ReadLine()); //armazenar em n1 com double 
                Console.WriteLine("Insira o segundo numero");//pedir ao utilzador o segundo valor 
                n2 = double.Parse(Console.ReadLine()); //armazenar em n2 com double 
                contas = n1 * n2;//algoritmo de multiplicação
                Console.Clear(); //apagar no que esta na consola
                Console.WriteLine(+n1+ " x " +n2+ " = "  + contas); // apresentar o resultado concatenado
                Thread.Sleep(2500); //tempo de espera de 2.5s
                Console.Clear(); //apagar no que esta na consola
                Menu1(); //ir para o menu 1 

            }
            else if (operadores == 4) //se o valor for 4 

            {
                Console.Clear(); //apagar no que esta na consola
                Console.WriteLine("Insira o primeiro numero"); //pedir ao utilzador o primeiro valor 
                n1 = double.Parse(Console.ReadLine()); //armazenar em n1 com double 
                Console.WriteLine("Insira o segundo numero"); //pedir ao utilzador o segundo valor 
                n2 = double.Parse(Console.ReadLine()); //armazenar em n2 com double 
                contas = n1 / n2; //algoritmo de divisão
                Console.Clear();//apagar no que esta na consola
                Console.WriteLine(+n1 + " / " + n2 + " = " + contas);// apresentar o resultado concatenado
                Thread.Sleep(2500); //tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menu1(); //ir para o menu 1 
            }

            else if (operadores == 5) //se o valor for 5 raiz quadrada 
            {
                Console.Clear(); //apagar no que esta na consola
                double raiz; //defclara a variavel raiz do tipo double
                Console.WriteLine("Insira o primeiro numero"); //pedir ao utilzador o primeiro valor 
                n1 = double.Parse(Console.ReadLine()); //armazenar em n1 com double 

                raiz = Math.Sqrt(n1); //calculo da raiz quadrada

                Console.Clear();//apagar no que esta na consola
                Console.WriteLine("A raiz quadrada de " +n1+ " é " + raiz);// apresentar o resultado concatenado
                Thread.Sleep(2500); //tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menu1(); //ir para o menu 1 
            }
            else if (operadores == 6) //se o valor for 5 raiz quadrada 
            {
                Console.Clear(); //apagar no que esta na consola
                double elevado; //declarar a variavel elvado do tipo double
                Console.WriteLine("Insira o primeiro numero"); //pedir ao utilzador o primeiro valor 
                n1 = double.Parse(Console.ReadLine()); //armazenar em n1 com double 
                Console.WriteLine("Insira o valor do expoente"); //pedir ao utilzador o segundo valor 
                n2 = double.Parse(Console.ReadLine()); //armazenar em n2 com double 

                elevado = Math.Pow(n1, n2); //calculo do elevado

                Console.Clear();//apagar no que esta na consola
                Console.WriteLine(+n1+ " elavado a " +n2+ " = " + elevado);// apresentar o resultado concatenado
                Thread.Sleep(2500); //tempo de espera de 2.5s
                Console.Clear();//apagar no que esta na consola
                Menu1(); //ir para o menu 1 
            }
            else if (operadores == 0)  //se o valor for 0 
            {
                
                Menu1(); //ir para o menu 1 
                Console.Clear(); //apagar no que esta na consola
            }
        }
    }
}