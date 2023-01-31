namespace Remove_Element;
class Program
{
    public int ContarElemento(int[] vetor, int removedor){

        int contador = 0; //o contador irá nos mostrar quantos números existem no vetor

        for (int i=0; i<= vetor.Length-1; i++){
            if (vetor[i] != removedor){
                contador = contador + 1;
            }
        }
        return contador;
    }
    static void Main(string[] args)
    {
        Program resultado = new Program();
        int[] vetor = {2, 2, 3, 1, 2, 3};
        int tamanho = vetor.Length;
        int removedor; //definimos removedor como o número a ser removido
        removedor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(resultado.ContarElemento(vetor, removedor)); //aqui, estamos chamando a função!
    }
}
