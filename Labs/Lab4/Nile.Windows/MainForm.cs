/* Vibhavi Jayasinghe
 * ITSE 1430
 */
using System;
using System.Linq;
using System.Windows.Forms;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            UpdateList();
        }

        #region Event Handlers
        
        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Handle errors
            try
            {
                _database.Add(child.Product);
                //break;
            } catch(Exception ex)
            {
                DisplayError("Add Failed", ex.Message);
            }
            //Save product
           // _database.Add(child.Product);
            UpdateList();
        }

        private void DisplayError( string title, string message ) => MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void OnProductEdit( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available.");
                return;
            };

            EditProduct(product);
        }        

        private void OnProductDelete( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);
        }        
                
        private void OnEditRow( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);
			
			//Don't continue with key
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Private Members

        private void DeleteProduct ( Product product )
        {
            var child = GetSelectedProduct();
            if (child == null)
                return;

            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //TODO: Handle errors
            try
            {
                _database.Remove(product.Id);
            } catch (Exception ex)
            {
                DisplayError("Delete Failed", ex.Message);
            }
            //Delete product
           // _database.Remove(product.Id);
            UpdateList();
        }

        private void EditProduct ( Product product )
        {
            var child = new ProductDetailForm("Edit Product");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Handle errors
            try
            {
                _database.Update(child.Product);
                
            }catch(Exception ex)
            {
                DisplayError("Update Failed", ex.Message);
            }
            //Save product
            //_database.Update(child.Product);
            UpdateList();
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList ()
        {
            //TODO: Handle errors
            try
            {
                var product = _database.GetAll().OrderBy(c => c.Name);

            } catch(Exception ex)
            {
                DisplayError("Load Failed", ex.Message);
            }
            _bsProducts.DataSource = _database.GetAll();
        }

        private readonly IProductDatabase _database = new Nile.Stores.MemoryProductDatabase();
        #endregion

        private void _miHelpAbout_Click( object sender, EventArgs e )
        {
            var form = new AboutBox1();
            form.ShowDialog();
        }

        private void productToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void MainForm_Load( object sender, EventArgs e )
        {

        }
    }
}
