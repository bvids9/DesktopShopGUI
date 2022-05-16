using ItemClassLibrary;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inventory parameters
            // Load from the database
            myStore.ItemList = SqliteDataAccess.loadProducts();
            refresh_Lists();

        }

        private void refresh_Lists()
        {
            // Function to refresh lists

            // Inventory list
            carInventoryBindingSource.DataSource = myStore.ItemList;
            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            // Cart list

            cartBindingSource.DataSource = myStore.ShoppingList;
            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            decimal price;
            try
            {
                price = decimal.Parse(txt_Price.Text);
                Product c = new Product(txt_Make.Text, txt_Model.Text, price);
                // myStore.ItemList.Add(c);
                SqliteDataAccess.saveProduct(c);

                carInventoryBindingSource.ResetBindings(false);

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid price.");
            }

            txt_Make.Clear();
            txt_Model.Clear();
            txt_Price.Clear();
            refresh_Lists();
            // MessageBox.Show(c.ToString());



        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            // Get the selected item from inventory
            Product selected = lst_inventory.SelectedItem as Product;

            // add to cart
            if(selected != null)
            {
                myStore.ShoppingList.Add(selected);
                cartBindingSource.ResetBindings(false);
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal totalPrice = myStore.Checkout();
            lbl_price.Text = totalPrice.ToString("C");

            cartBindingSource.ResetBindings(false);
        }

        private void btn_cartremove_Click(object sender, EventArgs e)
        {
            Product selected = lst_cart.SelectedItem as Product;
            if( selected != null)
            {
                myStore.ShoppingList.Remove(selected);
                cartBindingSource.ResetBindings(false);
            }
        }
    }
}