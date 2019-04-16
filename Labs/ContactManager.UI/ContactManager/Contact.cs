using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact : IValidatableObject
    {
        private int v;

        public string name { get; set; }

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();

            if (string.IsNullOrEmpty(name))
                items.Add(new ValidationResult("Name is required.", new[] { nameof(name) }));

            return items;
        }

        public Contact() { }

        public Contact(string name ) : this(name, 0) { }

        public Contact( string name, int v )
        {
            this.name = name;
            this.v = v;
        }

        internal object FirstOrDefault()
        {
            throw new NotImplementedException();
        }
    }
}
