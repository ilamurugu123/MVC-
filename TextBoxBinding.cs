using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPartialView.Models
{
    public class TextBoxBinding
    {
        public TextBoxBinding()
        {
            ValueHolders = new List<ValueHolder>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public List<ValueHolder> ValueHolders { get; set; } // List of TextboxValues
    }

    public class ValueHolder
    {
        public int ID { get; set; }
        public string ValueProperty { get; set; }
    }

}