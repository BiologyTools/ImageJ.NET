[![NuGet version (ImageJ.NET)](https://img.shields.io/nuget/v/ImageJ.NET.svg)](https://www.nuget.org/packages/ImageJ.NET/154.0.0)
[![NuGet version (ImageJ.NET)](https://img.shields.io/nuget/dt/ImageJ.NET?color=g)](https://www.nuget.org/packages/ImageJ.NET/154.0.0)
# ImageJ.NET
Controlling ImageJ using C# and IKVM 8.9.1.
```
ij.ImageJ ijm = new ij.ImageJ();
ImagePlus image = new ImagePlus("C:/test.jpeg");
// Process the image
image.getProcessor().invert();
// Save the processed image
string outputPath = "C:/ImageJ/test.jpeg"; // Replace with your output path
ij.IJ.save(image, outputPath);
```
