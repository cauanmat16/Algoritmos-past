/*void Mensagem()
{
    Console.WriteLine("olá, senhor Cauan");
}

//Mensagem();

void Escreva(string msg){
    Console.WriteLine(msg);
}

Escreva("olá, senhor Cauan");

string minhaMsg = "testando...";

Escreva(minhaMsg);

void MostrarIdade(string name, int idade)
{
    Escreva($"{name} tem {idade} anos");
}

MostrarIdade("cauan", 16);
MostrarIdade("Henrique seu", 15);


void CalcularIdade(string nome, int ano)
{
    int idade = 2024 - ano;
    MostrarIdade(nome,idade);
}

CalcularIdade("Henrique rico", 2009);


int MaiorEntre(int a, int b){

    if(a >= b)    
    {
        return a;
        }
        else        
        {
    return b;
        }
}
Console.WriteLine(MaiorEntre(99,200));
Console.WriteLine(MaiorEntre(12,15));
Console.WriteLine(MaiorEntre(75,790));

//exemplo de repetição

float resultado;

resultado = (2*100 + 3*50) / 5f;
Console.WriteLine("a média é: " + resultado);

resultado = (2*70 + 2*50) / 5f;
Console.WriteLine("a média é: " + resultado);

resultado = (2*99 + 2*33) / 5f;
Console.WriteLine("a média é: " + resultado);

void CalcularMédia(int a, int b)
{
    float resultado = (2*a + 3*b)/5f;
    Console.WriteLine("a média é:" + resultado);
}
CalcularMédia(255,50);
CalcularMédia(99,54);
CalcularMédia(99,33);
*/

using System.Runtime.CompilerServices;

void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} - {b} = {resultado}");
}


void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} * {b} = {resultado}");
}

void Divisao(float a,float b){
    if(b == 0){
        Console.WriteLine("Erro de divisão por zero");
        return;
}
float resultado = a / b;
Console.WriteLine($"{a} /{b}= {resultado}");
}

//variaveis globais
float a;
float b;

void DigitarAeB(string operacao){
    Console.WriteLine(operacao);
    

Console.WriteLine("Diditar o valor de a:");

    a = float.Parse(Console.ReadLine());

    Console.WriteLine("Digitar o valor de b:");

    b = float.Parse(Console.ReadLine());
}

//MENU
Console.WriteLine("--- Calculadora ---");
Console.WriteLine(" |1 - Soma");
Console.WriteLine(" |2 - Subtração");
Console.WriteLine(" |3 - Multiplicação");
Console.WriteLine(" |4 - Divisão");
Console.WriteLine(" |5 - Sair");
Console.WriteLine("------------------");
Console.WriteLine("Digitar a opção desejada");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    DigitarAeB("Soma");
    Soma(a,b);
}
else if(opcao == 2){
    DigitarAeB("Subtração");
    Subtracao(a,b);
}
else if(opcao == 3){
    DigitarAeB("Multiplicação");
    Multiplicacao(a,b);
}
else if(opcao == 4){
    DigitarAeB("Divisão");
    Divisao(a,b);
}
else if(opcao == 5){
    Console.WriteLine("Saindo...");
}
else{
    Console.WriteLine(" Opção invalida ");
}







