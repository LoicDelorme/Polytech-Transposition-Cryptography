namespace CryptographyModel
{
    public interface ITranspositionAlgorithm : ICryptographyAlgorithm
    {
        string getKey();

        int[] getKeyOffset();
    }
}
