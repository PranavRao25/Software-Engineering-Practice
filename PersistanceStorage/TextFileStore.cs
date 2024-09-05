using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

namespace Persistence
{
    public class TextFileStore : StoreBase, IStore
    {
        private TextWriter _writer;
        private TextReader _reader;

        public TextFileStore()
        {
            string pathName = "TextDataStorage.txt";
            Stream stream = File.Create(pathName);
            _writer = new StreamWriter(stream);
            _reader = new StreamReader(stream);
        }
     
        public override void InsertData(string key, int value)
        {
            bool integrity = CheckDataIntegrity(value);
            if (!integrity)
            {
                throw new ArgumentOutOfRangeException();
            }

            // delimiter is whitespace
            string line = String.Format(
                "{0} {1}", key, value.ToString()
                );
            _writer.WriteLine(line);
        }

        public override int RetrieveData(string key)
        {
            int value = 0;
            return value;
        }

        public bool ModifyData(int key, string text)
        {
            return true;
        }

        public void DeleteData(string key)
        {

        }

        public void ClearData()
        {

        }

        private void IndexData()
        {

        }
    }   
}
