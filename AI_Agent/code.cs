using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Agent
{
    // Class defining a software module or component structure.
    public class ModuleDefinition
    {
        // The final name of the module or application.
        public string Name { get; set; }

        // Conceptual description detailing the module's purpose.
        public string Description { get; set; }

        // The expected interface code (signature) for this module.
        public string InterfaceCode { get; set; }

        // The actual implementation code that fulfills the interface.
        public string ImplementationCode { get; set; } // Type corrected to 'string'

        // Quality score (e.g., test coverage, from 0.0 to 1.0).
        public double QualityScore { get; set; }

        // List of other modules required by this module (dependencies).
        public ModuleDefinition[] Dependencies { get; set; }
    }
}