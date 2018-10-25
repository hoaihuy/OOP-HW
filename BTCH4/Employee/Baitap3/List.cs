using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class List
    {
        Employee data;
        List next;

        public List() { next = this; }
        ~List()
        {
            if (next == null)		// prevent run-away recursion
                return;

            // deallocate the entire list
            List l = this.next;

            while (l != this)
            {
                List t = l;
                l = l.next;
                t.next = null;
                //delete data of t
                t.data = null;
            }

            this.next = null;
        }

        public Employee Insert(Employee key)
        {
	        List l;

	        // search for key in list
	        for (l = this; l.next != this && (string.Compare(l.next.data.Name, key.Name) < 0); l = l.next)
		        ;

	        if (l.next.data != null && string.Compare(key.Name, l.next.data.Name) == 0)	// key is in list
		        return l.next.data;
	
	        // insert key
	        List t = new List();
	        t.data = key;
	        t.next = l.next;
	        l.next = t;

	        return t.data;
        }

        public Employee Remove(Employee key)
        {
	        List l;

	        // search for key in the list
	        for (l = this; l.next != this && !(l.next.data.Name.Equals(key.Name)); l = l.next)
		        ;

	        if (l.next.data != null && l.next.data.Name.Equals(key.Name))
	        {
		        List t = l.next;
		        Employee d = t.data;
		        l.next = t.next;
		        t.next = null;
		        t = null;
		        return d;
	        }
	        else
		        return null;
        }

        public Employee	Search(Employee key)
        {
	        for (List l = this.next; l != this; l = l.next)
		        if (l.data.Name.Equals(key.Name))
			        return l.data;
	        return null;
        }

        public void PrintList()
        {
	        for (List l = this.next; l != this; l = l.next)
		        Console.WriteLine(l.data.DisplayStat());
        }
    }
}
