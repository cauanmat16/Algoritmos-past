using System.Runtime.ConstrainedExecution;

bool Resposta()
{
    inicioPergunta:
    string resposta = Console.ReadLine();

    if(resposta == "s")
    {
        return true;
    }
    else if(resposta == "n")
    {
        return false;
    }
    else
    {
        Console.WriteLine(" Não entendi, responda apenas s/n:");
        goto inicioPergunta;
    }
}
    
//inicialização
Console.WriteLine("Quer jogar um jogo? s/n");
if(Resposta() == false)
{
    goto finalJogo;
}

inicioJogo:

int menor = 0;
int maior = 100;
int numTentativas = 10;
bool jogoRodando = true;

Random rand = new Random();
int sorteado = rand.Next(menor, maior +1);
Console.WriteLine($"Pensei em um número {menor} e {maior}. Tente adivinhar!");

while(jogoRodando)
{
    Console.Write($"Tentativa {numTentativas}: !");
    int numDigitando = int.Parse(Console.ReadLine());
    if(numDigitando < sorteado)
{
    Console.Write("Muito baixo. ");
    numTentativas--;
}
else if(numDigitando > sorteado)
{
    Console.Write("Muito alto. ");
    numTentativas--;
}
else
{
    Console.WriteLine("Parabéns! você acertou!");
    jogoRodando = false;
}

if(numTentativas == 0)
{
    Console.WriteLine("Acabaram suas tentativas. ");
    jogoRodando = false;
}
}

//Finalização

Console.WriteLine("Quer jogar de novo? s/n");
if (Resposta() == true)
{
    goto inicioJogo;
}
finalJogo:
Console.WriteLine("Então até a próxima!");