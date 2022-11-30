using System;
namespace Tumakov10
{
    interface ICipher
    {
        string Encoding(string text, int k);
        string Decoding(string text, int k);
    }
}
