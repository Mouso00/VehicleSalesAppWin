

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

            carInventoryBindingSource.DataSource = myStore.carList;

            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = "ToString";

        }
    }
}