using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class EmployeeCollection
    {
        Dictionary<string, Employee> arr = new Dictionary<string, Employee>();
        public EmployeeCollection() { }

        public EmployeeCollection(Dictionary<string, Employee> e)
        {
            this.arr = e;
        }

        public Employee this[string name]
        {
            get
            {
                if (arr.ContainsKey(name))
                    return arr[name];
                return null;
            }
            set
            {
                arr[name] = value;
            }
        }

        public Employee this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                    return (arr.Values.ToList<Employee>())[index];
                return null;
            }
        }

        public int Count
        {
            get { return arr.Count; }
        }
    
    }
}
