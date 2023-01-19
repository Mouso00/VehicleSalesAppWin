

using CarClassLibrary;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace VehicleSalesAppWin
{
    public partial class Form1 : Form
    {
        //myStore object of the Store class manages the cars in the inventory and cart.
        Store myStore = new Store();

    /*  carInventoryBindingSource object of BindingSource class 
        links the inventory cars list to list box control in the user interface   */
        BindingSource carInventoryBindingSource = new BindingSource();


/*      cartBindingSource object of BindingSource class
        links the inventory cars list to list box control in the user interface   */
        BindingSource cartBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            // creating new car usin users input from textboxes 
            Car car = new Car(txt_maker.Text, txt_model.Text, txt_year.Text, decimal.Parse(txt_price.Text));
            //adds it to a list of cars
            myStore.carList.Add(car);
            //updates the data binding.
            carInventoryBindingSource.ResetBindings(false);

            //Array clears the text in the textboxes
            TextBox[] textlist = { txt_maker, txt_model, txt_year, txt_price };
            foreach (TextBox txt in textlist)
            {
                txt.Clear();
            }
        }

        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {
             // get the selected item from inventory
             Car selected = (Car) lst_inventory.SelectedItem;

            //add the item to cart 
            myStore.inventoryList.Add(selected);

            //update the list box control
            cartBindingSource.ResetBindings(false);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            // calculates total cost of items in the cart
            decimal total = myStore.Checkout();
            //displays the total cost on a label
            lbl_total.Text = "$" + total.ToString();
            //updates the cart data binding
            cartBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connects data from myStore to carList
            carInventoryBindingSource.DataSource = myStore.carList;
            //connects data from myStore to carList inventoryList".
            cartBindingSource.DataSource = myStore.inventoryList;
            //sets the data source for "lst_inventory" to "carInventoryBindingSource".
            lst_inventory.DataSource = carInventoryBindingSource;
            //default string representation of object in list will be displayed in list box
            lst_inventory.DisplayMember = "ToString";
            // connecting a list box to a data source list box will be filled with data from the cartBindingSource
            lst_cart.DataSource = cartBindingSource;

            //way data is displayed in lst_cart, it uses the default string representation of the data source.
            lst_cart.DisplayMember = ToString();
        }

    }
}