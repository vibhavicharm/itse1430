/* Vibhavi Jayasinghe
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {        
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        public Product Add ( Product product )
        {
            //TODO: Check arguments
            Verify.IsNotNullandValid(nameof(product), product);

            var existing = GetCore(product.Id);
            
            //TODO: Validate product
            if(existing != null)
            {
                throw new ArgumentException("Contact already exist");
            }
            //Emulate database by storing copy
            return AddCore(product);
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get ( int id )
        {
            //TODO: Check arguments
            Verify.IsGreaterThanZero(nameof(id), id);
            return GetCore(id);
        }
        
        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll ()
        {
            return GetAllCore();
        }
        
        /// <summary>Removes the product.</summary>
        /// <param name="id">The product to remove.</param>
        public void Remove ( int id )
        {
            //TODO: Check arguments
            Verify.IsGreaterThanZero(nameof(id), id);
            RemoveCore(id);
        }
        
        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update (Product product )
        {
            //TODO: Check arguments
            Verify.IsNotNullandValid(nameof(product), product);

            //Get existing product
            var existing = GetCore(product.Id);

            //TODO: Validate product
            if (existing == null)
                throw new ArgumentException("Product does not exist", nameof(product));

            var existingName = GetCore(product.Id);
            if (existingName != null && existingName.Id != product.Id)
                throw new ArgumentException("Product already exist with the given name.", nameof(product));


            return UpdateCore(existing, product);
        }

        #region Protected Members

        protected abstract Product GetCore( int id );

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract void RemoveCore( int id );

        protected abstract Product UpdateCore( Product existing, Product newItem );

        protected abstract Product AddCore( Product product );
        #endregion
    }
}
