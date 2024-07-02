[![NuGet version (ImageJ.NET)](https://img.shields.io/nuget/v/ImageJ.NET.svg)](https://www.nuget.org/packages/ImageJ.NET/154.0.0)
[![NuGet version (ImageJ.NET)](https://img.shields.io/nuget/dt/ImageJ.NET?color=g)](https://www.nuget.org/packages/ImageJ.NET/154.0.0)
# ImageJ.NET
 ImageJ control using C# and IKVM 8.9.0 pre-release.

# Building 
- Get IKVM 8.9.0 or the [developer pre-release](https://github.com/ikvmnet/ikvm/actions/runs/9238355862/artifacts/1537937356).
- Then use ImageJ in C# with ij namespace.
```
ij.ImageJ ijm = new ij.ImageJ();
ImagePlus image = new ImagePlus("C:/test.jpeg");
// Process the image
image.getProcessor().invert();
// Save the processed image
string outputPath = "C:/ImageJ/test.jpeg"; // Replace with your output path
ij.IJ.save(image, outputPath);
```
- ImageJ should then open up with your image and save the resulting image.
  - Note if working with the pre-release ImageJ button texts will appear in Chinese.

![image](https://github.com/BiologyTools/ImageJControl/assets/84872500/1749b84e-90a8-4ef4-ab7b-6d84220b7ea9)

