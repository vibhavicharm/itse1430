using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Nile
{
    public static class Verify
    {
        public static void IsNotNullandValid<T> (string name, T value) where T : class, IValidatableObject
        {
            IsNotNull(name, value);

            Validator.ValidateObject(value, new ValidationContext(value), true);
        }

        public static void IsNotNull<T> (string name, T value) where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void IsGreaterThanZero( string name, int value ) => IsGreaterThan(name, value, 0);

        public static void IsGreaterThan<T>( string name, T value, T minValue ) where T : IComparable<T>
        {
            if (value.CompareTo(minValue) <= 0)
                throw new ArgumentOutOfRangeException(name, $"{name} must be greater than {minValue}.");
        }
    }
}
