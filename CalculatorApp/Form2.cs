using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace CalculatorApp
{
    public partial class Form2 : Form
    {
        private static readonly ResourceManager resourceManager = Properties.Resources.ResourceManager;
        private static readonly Random random = new Random();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Change the text to "Change Image" when invoked, right now images is blank until the button is pressed
            if (pictureBox1.Image == null)
            {
                button1.Text = "Change Image";
            }

            string resourceName = "_" + random.Next(1, 6);
            pictureBox1.Image = (Bitmap)resourceManager.GetObject(resourceName);

            // Obtain Image size so we can resize the form to fit the image
            var imageSizeWidth = pictureBox1.Image.Size.Width;
            var imageSizeHeight = pictureBox1.Image.Size.Height;

            // Resize the form to fit the image
            this.Size = new Size(imageSizeWidth + 50, imageSizeHeight + 125);

        }
    }
}
