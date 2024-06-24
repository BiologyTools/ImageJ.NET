using ij.plugin.filter;
using ij;

namespace ImageJTest
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();
            ij.ImageJ ijm = new ij.ImageJ();
            ImagePlus image = new ImagePlus("C:/corgi.jpeg");
            // Process the image
            image.getProcessor().invert();
            // Save the processed image
            string outputPath = "C:/Fiji/test.jpeg"; // Replace with your output path
            ij.IJ.save(image, outputPath);
        }
    }
}