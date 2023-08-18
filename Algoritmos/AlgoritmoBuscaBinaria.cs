namespace BuscaBinariaRecursiva.App.Algoritmos
{
    public static class AlgoritmoBuscaBinaria
    {
        public static int FazerBuscaBinariaRecursiva(int[] arr, int esquerda, int direita, int x)
        {
            if (direita >= esquerda)
            {
                int metade = esquerda + (direita - esquerda) / 2;
                if (arr[metade] == x)
                {
                    return metade;
                }
                if (arr[metade] > x)
                {
                    return FazerBuscaBinariaRecursiva(arr, esquerda, metade - 1, x);
                }
                return FazerBuscaBinariaRecursiva(arr, metade + 1, direita, x);
            }
            return -1;
        }
    }
}