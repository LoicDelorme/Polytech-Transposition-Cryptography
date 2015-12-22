using System;

namespace CryptographyModel
{
    public interface ICryptographyAlgorithm
    {
        string encrypt(String message);

        string decrypt(String message);
    }
}
