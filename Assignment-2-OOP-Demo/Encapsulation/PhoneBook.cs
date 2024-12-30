using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_2_OOP_Demo.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attribute
        string[] Name;
        int[] Numbers;
        public int Size {get;set;}
        #endregion

        #region Constructor
        public PhoneBook(int size)
        {
            Name = new string[size];
            Numbers = new int[size];
            Size = size;
        }
        #endregion

        #region Methods
        public void Addperson(int position, string name, int number)
        {
            if (Name is not null && Numbers is not null)
            {
                if (position < Size)
                {
                    Name[position] = name;
                    Numbers[position] = number;
                }
            }
        }
        #endregion

        #region Setter - Getter
        public int Getnumber(string name)
        {
            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] == name)
                {
                    return Numbers[i];
                }
            }
            return -1;
        }

        public void setNumber(string name, int newnumber)
        {
            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] == name)
                {
                    Numbers[i] = newnumber;
                    break;
                }
            }
        }

        #endregion

        #region Indexer
        // have paramter , use keyword this becouse i dont knoe the refrences that refer to object
        public int this[string name]//Notes["mona"]
        {
            get
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (Name[i] == name)
                    {
                        return Numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (Name[i] == name)
                    {
                        Numbers[i] = value;
                        break;
                    }
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return $"{index} :: {Name[index]} :: {Numbers[index]} ";
            }
        }    
        #endregion
    }
}
