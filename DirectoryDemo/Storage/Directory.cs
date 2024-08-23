using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class Directory
    {
        public Directory()
        {

        }

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string ParentDirectory
        {
            get
            {
                return ParentDirectory;
            }
            set
            {
                ParentDirectory = value;
            }
        }

        public string Contents
        {
            get
            {
                return Contents;
            }
            set
            {
                Contents = value;
            }
        }

        public bool Type
        {
            get
            {
                return Type;
            }
            set
            {
                Type = value;
            }
        }

        public void ChangeParent(string Parent1, string Parent2)
        {

        }

        public void AddChild(string Parent, string Child)
        {

        }

        public void RemoveChild(string Parent, string Child)
        {

        }

        public void ReadContents(string Path)
        {

        }

        public void WriteContents(string Path, string Contents)
        {

        }
    }
}
