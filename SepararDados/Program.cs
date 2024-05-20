string dadosBrutos;
double numerico;
string[] dadosSeparados;
List<string> listaTexto = new List<string>();
List<double> listaNumerico = new List<double>();

Console.WriteLine("Digite os dados: ");
dadosBrutos = Console.ReadLine();

dadosSeparados = dadosBrutos.Split(',');

// Loop para pegar cada dado isoladamente
foreach (string dado in dadosSeparados)
{
    // Try Catch para tentar transformar o dado em número (em caso de erro devolve em string)
    // Usando o trim para remover os espaços entre as vírgulas
    try
    {
        numerico = double.Parse(dado.Trim());
        listaNumerico.Add(numerico);
    }
    catch
    {
        listaTexto.Add(dado.Trim());
    }
}

// Saída dos dados organizados
Console.WriteLine("Lista de Strings: ");
foreach (string texto in listaTexto)
{
    Console.WriteLine(texto);
}

Console.WriteLine();

Console.WriteLine("Lista de Números: ");
foreach (double numero in listaNumerico)
{
    Console.WriteLine(numero);
}