using System.Text.Json;

namespace ATV4_CJ3022501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exer;
            Console.WriteLine("Qual exercício você deseja executar: ");
            Console.WriteLine("Exercício 1 \nExercício 2 \nExercício 3 \nExercício 4 \nExercício 5 \nExercício 6 \nExercicio 7");
            exer = int.Parse(Console.ReadLine());

            switch (exer)
            {
                case 1:
                    int n, n2, operacao;
                    Console.WriteLine("Digite dois números separados por enter:");
                    n = int.Parse(Console.ReadLine());
                    n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("escolha uma das opções abaixo");
                    Console.WriteLine("1 = adição\n2 = subtração\n3 = multiplicação\n4 = divisão");
                    operacao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (operacao)
                    {
                        case 1:
                            Console.WriteLine(n + n2);
                            break;

                        case 2:
                            Console.WriteLine(n - n2);
                            break;
                        case 3:
                            Console.WriteLine(n * n2);
                            break;
                        case 4:
                            Console.WriteLine(n / n2);
                            break;

                        default:
                            Console.WriteLine("opção inválida");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine();

                    /* Escreva um programa que pede para o usuário entrar com um número correspondente a um dia  da  semana(1  a  7)
                    * e  então  apresente  na  tela  o dia  equivalente  da  semana por  extenso utilizando o comando switch.
                    */

                    int semana;
                    Console.WriteLine("escolha um número referente ao dia da semana (1 - 7)");
                    semana = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (semana)
                    {
                        case 1:
                            Console.WriteLine("o dia da semana é: domingo");
                            break;
                        case 2:
                            Console.WriteLine("o dia da semana é: segunda-feira");
                            break;
                        case 3:
                            Console.WriteLine("o dia da semana é: tercça-feira");
                            break;
                        case 4:
                            Console.WriteLine("o dia da semana é: quarta-feira");
                            break;
                        case 5:
                            Console.WriteLine("o dia da semana é: quinta-feira");
                            break;
                        case 6:
                            Console.WriteLine("o dia da semana é: sexta-feira");
                            break;
                        case 7:
                            Console.WriteLine("o dia da semana é: sabado");
                            break;

                        default: Console.WriteLine("não esxite esse dia da semana");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine();

                    /*Crie um programa que receba o valor total de uma compra, calcule e exiba o valor final a ser pago  de  acordo  com  a  forma  de  pagamento:
                     * 15%  de  desconto  à  vistano  dinheiro 10%  de desconto à vistano PIX, 
                     * 5% de acréscimo na compra no débito e 10% de acréscimo na compra com cartão de crédito.
                     * */

                    float compra;
                    int pagamento;
                    Console.WriteLine("digite quanto ficou a compra total:");
                    compra = float.Parse(Console.ReadLine());
                    Console.WriteLine("Qual será a forma de pagamento?" +
                        "\n1- À vista no dinheiro" +
                        "\n2- À vista no pix" +
                        "\n3- Cartão débito" +
                        "\n4- cartão crédito");
                    pagamento = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (compra)
                    {

                        case 1:
                            compra -= (compra / 100) * 15;
                            Console.WriteLine("O valor total de uma compra é de:{0}", compra);

                            break;

                        case 2:
                            compra -= (compra / 100) * 10;
                            Console.WriteLine("O valor total de uma compra é de:{0}", compra);
                            break;
                        case 3:
                            compra += (compra / 100) * 5;
                            Console.WriteLine("O valor total de uma compra é de:{0}", compra);
                            break;
                        case 4:
                            compra += (compra / 100) * 10;
                            Console.WriteLine("O valor total de uma compra é de:{0}", compra);
                            break;

                        default: Console.WriteLine("essa opção não é válida");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine();
                    /*Crie um programa em C# utilizando o comando switch para imprimir por extenso o nome de um mês e a quantidade de dias que ele possui.
                     * Atenção, se o ano for bissexto, o número de dias do mês de fevereiro poderá apresentar diferenças. */

                    int mes, ano;
                    Console.WriteLine("Escolha um mês que deseje consultar (1 - 12)");
                    mes = int.Parse(Console.ReadLine());
                    switch (mes)
                    {

                        case 1:
                            Console.WriteLine("O mês escolhido foi janeiro, ele contém 31 dias.");
                            break;

                        case 2:
                            Console.WriteLine("digite o ano em que deseja consultar:");
                            ano = int.Parse(Console.ReadLine());
                            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
                            { Console.WriteLine("O ano é bissexto, logo fevereiro tem 29 dias");
                                break;
                            }
                            else
                            { Console.WriteLine("Fevereiro tem 28 dias");
                                break;
                            }
                        case 3:
                            Console.WriteLine("O mês escolhido foi março, ele contém 31 dias.");
                            break;
                        case 4:
                            Console.WriteLine("O mês escolhido foi abril, ele contém 30 dias.");
                            break;
                        case 5:
                            Console.WriteLine("O mês escolhido foi maio, ele contém 31 dias.");
                            break;
                        case 6:
                            Console.WriteLine("O mês escolhido foi junho, ele contém 30 dias.");
                            break;
                        case 7:
                            Console.WriteLine("O mês escolhido foi julho, ele contém 31 dias.");
                            break;
                        case 8:
                            Console.WriteLine("O mês escolhido foi agosto, ele contém 31 dias.");
                            break;
                        case 9:
                            Console.WriteLine("O mês escolhido foi setembro, ele contém 30 dias.");
                            break;
                        case 10:
                            Console.WriteLine("O mês escolhido foi outubro, ele contém 31 dias.");
                            break;
                        case 11:
                            Console.WriteLine("O mês escolhido foi novembro, ele contém 30 dias.");
                            break;
                        case 12:
                            Console.WriteLine("O mês escolhido foi dezembro, ele contém 31 dias.");
                            break;
                        default: Console.WriteLine("O mês é inválido");
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine();
                    /*Codifique um programa que faça a leitura de dois números inteiros. Seu programa deverá ler um  caractere,  
                     * que  deve  ser  +, -,  *, /ou  ^realizando  em  seguida  o  cálculo  da  aplicação  da operação  informada  sobre  os  dois  números  previamente  lidos.
                     * Você  deve  utilizar  o  switch para o desenvolvimento do programa.*/
                    int nun, nun2;
                    char oper;
                    Console.WriteLine("Digite dois numeros para fazer as operações:");
                    nun = int.Parse(Console.ReadLine());
                    nun2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("escolha a sua operação:" +
                        "+, -, * ou /");
                    oper = char.Parse(Console.ReadLine());

                    switch (oper)
                    {
                        case '+': Console.WriteLine(nun + nun2);
                            break;
                        case '-': Console.WriteLine(nun - nun2);
                            break;
                        case '*':
                            Console.WriteLine(nun * nun2);
                            break;
                        case '/':
                            Console.WriteLine(nun / nun2);
                            break;
                    }
                    break;
                case 6:
                    Console.WriteLine();
                    /*A  empresa Instituto  Tecnológico  da  Montanha concederá  um  aumento  de  salário  aos  seus colaboradores,variável de acordo com o
                     * cargo, conforme a tabela abaixo. Faça um programa que  leia  o  salário  e  o  cargo  de  um  funcionário e  calcule  o  novo  salário.
                     * Se  o  cargo  do funcionário  não  estiver  na  tabela,  ele  deverá,  então,  receber  43,5%  de  aumento.  
                     * Mostre  o salário antigo, o novo salário e a diferença.*/

                    double salario, novoSalario, aumento, diferenca;
                    string cargo;

                    Console.WriteLine("Digite o salário do funcionário:");
                    salario = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite o cargo do funcionário:");
                    cargo = (Console.ReadLine());

                    switch (cargo)
                    {
                        case "Professor":
                            aumento = salario * 0.075;
                            break;
                        case "Secretário":
                            aumento = salario * 0.097;
                            break;
                        case "Publicitário":
                            aumento = salario * 0.117;
                            break;
                        case "Jornalista":
                            aumento = salario * 0.089;
                            break;
                        case "Mecânico":
                            aumento = salario * 0.1324;
                            break;
                        case "Estagiário":
                            aumento = salario * 0.104;
                            break;
                        case "Técnico de TI":
                            aumento = salario * 0.146;
                            break;
                        default:
                            aumento = salario * 0.435;
                            break;
                    }

                    novoSalario = salario + aumento;
                    diferenca = novoSalario - salario;

                    Console.WriteLine($"Salário antigo: R$ {salario:F2}");
                    Console.WriteLine($"Novo salário: R$ {novoSalario:F2}");
                    Console.WriteLine($"Diferença: R$ {diferenca:F2}");
                    break;
                case 7:
                    Console.WriteLine();
                    /*Foi dada a largada para a declaração do Imposto de Renda dos cidadãos brasileiros. 
                     * Crie um programa que dado o salário mensal de um trabalhador, consiga calcular e informar a quantia que deverá ser recolhida em impostos.
                     * Apresente também qual será o salário líquido (após o desconto do imposto).*/

                    int faixa;
                    float salario1;
                    Console.WriteLine("Qual o seu salário?");
                    salario1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a faixa salaríal:" +
                        "\n1 - R$1903,98"+
                        "\n2 - Entre R$ 1.903,99 e R$ 2.826,65" +
                        "\n3 - Entre R$ 2.826,66 e R$ 3.751,05" +
                        "\n4 - Entre R$ 3.751,06 e R$ 4.664,68" +
                        "\n5 - Acima de R$ 4.664,68");
                    faixa = int.Parse(Console.ReadLine());

                    switch (faixa)
                    {
                        case 1: Console.WriteLine("Não precisa pagar imposto");
                            break;
                        case 2:
                            salario1 -= ((salario1 / 100) * 7.5f);
                            Console.WriteLine("O salário líquido é de: {0}", salario1);
                            break;
                        case 3:
                            salario1 -= ((salario1 / 100) * 15);
                            Console.WriteLine("O salário líquido é de: {0}", salario1);
                            break;
                        case 4:
                            salario1 -= ((salario1 / 100) * 22.5f);
                            Console.WriteLine("O salário líquido é de: {0}", salario1);
                            break;
                        case 5:
                            salario1 -= ((salario1 / 100) * 27.5f);
                            Console.WriteLine("O salário líquido é de: {0}", salario1);
                            break;
                    }

                    break;
            }
        }


    } 
}
