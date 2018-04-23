using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramDataControllerBehavior.Data
{
    public class ClassData
    {
        public string ClassName { get; set; }
        public ClassType Type { get; set; }
    }
    public enum ClassType
    {
        Class,
        Interface,
        AbstractClass,
    }

    public class ConnectionData
    {
        public object ConnectedFrom { get; set; }
        public object ConnectedTo { get; set; }
    }
}
