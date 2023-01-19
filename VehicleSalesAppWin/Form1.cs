

using CarClassLibrary;

namespace VehicleSalesAppWin
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_create_car_Click(object sender, EventArgs e)
        {
            Car car = new Car(txt_maker.Text, txt_model.Text, txt_year.Text, decimal.Parse(txt_price.Text));
           // string carDetails = $"Maker:{car.Maker}, Model:{car.Model}, Year:{car.Year}, Price:{car.Price}";
            //MessageBox.Show(carDetails);
            myStore.carList.Add(car);
            carInventoryBindingSource.ResetBindings(false);

            //Array to clear the list 
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
            myStore.shoppingList.Add(selected);

            //update the list box control
            cartBindingSource.ResetBindings(false);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_total.Text = "$" + total.ToString();
            cartBindingSource.ResetBindings(false);
        }

        private void lst_inventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_cart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            carInventoryBindingSource.DataSource = myStore.carList;
            cartBindingSource.DataSource = myStore.shoppingList;


            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = "ToString";

            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}