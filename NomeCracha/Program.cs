string[] listaNomes = new string[150];
string[] palavrasRemover = { "de", "da", "das", "do", "dos", "e" };
string nome, ultimoSobrenome;
int tamanho;

for (int i = 0; i < 150; i++)
{
    // Resetando as iniciais para não acumular no próximo loop
    string iniciais = "";

    Console.WriteLine("Digite o nome do colaborador: ");
    nome = Console.ReadLine();

    // Checando se as palavras proibidas aparecem no nome
    foreach (string palavra in palavrasRemover)
    {
        if (nome.Contains(palavra))
        {
            nome = nome.Replace($" {palavra} ", " ");
        }
    }

    // Separando o nome em uma array
    string[] partesNome = nome.Split(' ');
    ultimoSobrenome = partesNome.Last() + ", ";
    tamanho = partesNome.Length;

    // Pegando as iniciais do nome e sobrenome
    for (int j = 0; j < tamanho - 1; j++)
    {
        iniciais += partesNome[j].Substring(0, 1) + ". ";
    }

    listaNomes[i] = ultimoSobrenome + iniciais;

    // Saída do nome formatado
    Console.WriteLine(listaNomes[i]);
}