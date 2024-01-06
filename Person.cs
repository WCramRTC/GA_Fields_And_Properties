using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Fields_And_Properties
{
    public class Person
    {
        // Private field: Encapsulates the data to prevent direct external access
        private string _name;

        // Public property for the _name field with both getter and setter
        public string Name
        {
            get { return _name; } // Getter: Returns the value of _name
            set
            {
                // Validation: Check if the provided value is not null or empty
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    throw new ArgumentException("Name cannot be null or empty");
            }
        }

        // Read-only property: Only includes a getter
        public string ReadOnlyName
        {
            get { return _name; }
        }

        // Write-only property: Only includes a setter
        public string WriteOnlyName
        {
            set { _name = value; }
        }
    }
}
