namespace Want2Learn.ClassAndObjects
{
    public interface IStringAlgorithms
    {
        string VigenereDecryption(string text, string key);
        string VigenereEncryption(string text, string key);
    }
}