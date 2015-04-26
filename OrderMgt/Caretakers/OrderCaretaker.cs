using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class OrderCaretaker
    {
        private static OrderCaretaker instance; 
        private OrderMemento _memento;

        private OrderCaretaker() { }

        public static OrderCaretaker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderCaretaker();
                }
                return instance;
            }
        }
    
    public OrderMemento OrderMemento
    {
      set { _memento = value; }
      get { return _memento; }
    }
  }
}