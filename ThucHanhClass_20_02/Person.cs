using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhClass_20_02
{
    public class Person
    {
        private string Name;
        public int height;
        public int weight;
        public bool ismale;
        //Ham khoi tao
        public Person( string _Name,int _height,int _weight, bool _ismale )
        {
            this.Name = _Name;
            this.height = _height;
            this.weight = _weight;
            this.ismale = _ismale;
        }
        public string getName() 
        { 
            string Ten=this.Name;
            return Ten;
        }
    }
}
