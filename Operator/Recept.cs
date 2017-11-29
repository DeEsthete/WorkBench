using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    public class Recept
    {
        private string _name;
        private Material[] _resourceLocation = new Material[9];

        public Recept(string name, Material[] resourceLocaion)
        {
            _name = name;
            _resourceLocation = resourceLocaion;
        }

        public Recept()
        {
            _name = "NULL";
        }

        public string GetName()
        {
            return (_name);
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public Material[] GetResourceLocation()
        {
            return _resourceLocation;
        }

        public void SetResourceLocation(Material[] material)
        {
            _resourceLocation = material;
        }

        public Material GetResourceLocation(int x)
        {
            return _resourceLocation[x];
        }

        public void SetResourceLocation(int x, Material material)
        {
            _resourceLocation[x].Copy(material);
        }
    }
}
