
using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace Belka_project_uml_diagram
{
    public class ClassIUML
    {
        [DisplayName("Accessibility")]
        public string E { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Data type")]
        public string Datatype { get; set; }

        public ClassIUML(string e, string name, string datatype) 
        { 
            E = e;
            Name = name;
            Datatype = datatype;
        }

        public override string ToString()
        {
            return $"{E} {Name}: {Datatype}";
        }
    }
}
