

using System.ComponentModel;

namespace Belka_project_uml_diagram
{
    public class MethodUML
    {
        [DisplayName("Accessibility")]
        public string E { get; set; }
        public string Name { get; set; }
        [DisplayName("Return Data Type")]
        public string returnDataType { get; set; }

        public MethodUML(string e, string name, string returnDatatype) 
        { 
            E = e;
            Name = name;
            returnDataType = returnDatatype;
        }

        public override string ToString()
        {
            return $"{E}{Name}(): {returnDataType}";
        }
    }
}
