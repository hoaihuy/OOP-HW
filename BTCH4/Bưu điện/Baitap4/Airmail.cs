using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    abstract class Airmail
    {
        public string address;
        public string receiver;


        public virtual string Address
        {
            get { return address; }
            set { address = value; }
        }

        public virtual string Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }

        public virtual void Input()
        {
            Console.Write("Enter Address: ");
            this.address = Console.ReadLine();
           
            Console.Write("Enter Reciever: ");
            this.receiver = Console.ReadLine();
            
        }
        public virtual void Displate()
        {
            Console.WriteLine("Address {0} - Receiver {1}", address, receiver);
        }
        
    }
}
