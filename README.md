# Yakuza MT Texture Creator
![Total Downloads](https://img.shields.io/github/downloads/PixelIndieDev/Yakuza-MT-Texture-Creator/total?style=flat)

Yakuza MT Texture Creator is a Windows tool for Yakuza/Like a Dragon game modders and anyone who wants to combine multiple PNG images into a single texture. It allows you to merge up to three PNGs into the RGB channels of one PNG file while providing channel labels compatible with different Yakuza engines.

![Screenshot of the program](/ReadMeImages/previewimage_program.png)

## Features
* Merge three PNG images into a single output PNG:
    * Red channel: Specular
    * Green channel: Ambient Occlusion
    * Blue channel: Specular Power Multiplier
* Automatic alpha handling: Transparent pixels affect channel intensity proportionally.
* Switch between Old Engine and Dragon Engine channel labels.

![How it works](/ReadMeImages/previewimage_process.png)

## Requirements

* Windows OS
* .NET Framework (.NET 8.0)
* PNG input files only
* All inputs have the same dimensions and size
* Optional: Input greyscale images

## Usage Instructions
* Click the Specular, Ambient Occlusion, and Specular Power Multiplier buttons to load PNGs.
* Optionally, switch between Old Engine and Dragon Engine labeling.
* Click Export to generate the combined PNG.

> [!TIP]
> I recommend to use greyscale images as inputs

> [!IMPORTANT]
> * Each color channel is always grayscale. Saving full-color data into channels is not supported.
> * Transparent pixels are multiplied with the grayscale channel to maintain correct intensity.
> * The program is designed primarily for Yakuza texture modding, but it can be used for any image channel merging workflow.

## References
Channel usage and MT implementation based on this website: [Yakuza Material Documentation](https://sites.google.com/view/yakuzatexturedoc/general-info)

## Keywords

Yakuza modding, Yakuza texture tool, PNG channel merge, Specular map, Ambient Occlusion map, Specular Power map, Old Engine, Dragon Engine, grayscale texture, image channel combiner, modder tools, game modding utility



