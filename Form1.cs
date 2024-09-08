using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Code_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new EcommerceDbContext())
                {

                    var products = await (from product in db.Products
                                          select product).ToListAsync();
                    foreach (var product in products)
                    {
                        MessageBox.Show($"Id: {product.Id}, Name: {product.Name}, Stock: {product.Stock}");
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
