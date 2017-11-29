using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    public class Workbench
    {
        private Recept[] _recept;
        private Material[] _material;

        public Workbench(Recept[] recept, Material[] material)
        {
            _recept = recept;
            _material = material;
        }

        public Workbench()
        {
            for (int i = 0; i < 9; i++)
            {
                _recept[i] = new Recept();
            }

            int z = _recept.Length;
        }

        public void MainFunction()
        {
            // 1,2      1,4     1,6
            // 3,2      3,4     3,6
            // 5,2      5,4     5,6
            string[] worbench = new string[7];
            worbench[0] = "-------";
            worbench[1] = "| | | |";
            worbench[2] = "-------";
            worbench[3] = "| | | |";
            worbench[4] = "-------";
            worbench[5] = "| | | |";
            worbench[6] = "-------";
            bool switchForWhile = true;
            while (switchForWhile)
            {

            }
            Console.Clear();
        }

        public void AddRecept(Recept temp)
        {
            Array.Resize(ref _recept, (_recept.Length + 1));
            _recept[_recept.Length - 1].SetName(temp.GetName());
            _recept[_recept.Length - 1].SetResourceLocation(temp.GetResourceLocation());
        }

        public void AddMaterial(Material temp)
        {
            Array.Resize(ref _material, (_material.Length + 1));
            _material[_material.Length - 1].SetName(temp.GetName());
            _material[_material.Length - 1].SetId(temp.GetId());
        }
    }
}
