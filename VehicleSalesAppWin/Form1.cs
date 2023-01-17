
using VehicleSalesStore;
using VehicleSalesStore.Models;

namespace VehicleSalesAppWin
{
    public partial class Form1 : Form
    {

        BindingSource vehicleInventoryBindingSource = new BindingSource();
        BindingSource cartBindigSource = new BindingSource();
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

            Vehicle vehicle = new Vehicle(txt_maker.Text,txt_model.Text,txt_year.Text,txt_price.Text);
            MessageBox.Show("Vehicle details\nMaker: " + vehicle.maker + "\nModel: " + vehicle.model + "\nYear: " + vehicle.year + "\nPrice: " + vehicle.price);

          /*  List<Vehicle> list = new List<Vehicle>();
            ShowAndAdd.vehicleList.Add(vehicle);*/
            
        }

        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {

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

        }
    }
}