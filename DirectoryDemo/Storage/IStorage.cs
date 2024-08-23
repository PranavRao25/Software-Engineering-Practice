using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public interface IStorage
    {
        public string ParentDirectory { get; }

        public string Name { get; }

        public string Contents { get; }

        public bool Type {  get; }


        public void ChangeParent(string Parent1, string Parent2);
        
        public void AddChild(string Parent, string Child);
        
        public void RemoveChild(string Parent, string Child);

        public void ReadContents(string Path);

        public void WriteContents(string Path, string Contents);
    }
}
