namespace DirectoryManagement
{
    public class DirectoryReader
    {
        private string _Graph;

        public DirectoryReader(string Source)
        {
            _Graph = Source;
        }

        public void Move(string Source, string Target)
        {

        }

        public void Create(string ResourceName)
        {

        }

        public void Delete(string ResourceName)
        {

        }

        public void Rename(string ResourceName)
        {

        }

        public string Search(string ResourceName)
        {
            return _Graph;
        }

        private string SearchItem(string ResourceName)
        {
            return _Graph;
        }

        public string Open(string ResourceName)
        {
            return _Graph;
        }
    }
}
