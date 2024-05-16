DH-Parameters
===
A Unity3D application using ARToolKitUWP for tracking links on a Fanuc LR Mate 200iD to display D-H Coordinate Frames. It has already imported ```ARToolKitUWP.unitypackage``` and ```ARToolKitUWP-Sample.unitypackage``` from [HoloLensARToolKit - Long Qian](https://github.com/qian256/HoloLensARToolKit).

Author: [Kaden Wince](https://github.com/k-wince) - Computer Engineering ONU 2025

Date: 2024-05-15

## Overview

This folder contains the versions of the DH Parameters tracking program. located at:

* Version 0.5:
	* ```Scenes/DHParametersV0.5```

## Build to HoloLens

1. Choose a scene based on the Version
3. Open ```File / Build Settings```, and verify that
	* Build target is **Universal Windows Platform**
	* The selected sample scene is added for build
	* Target Device is **Any Device**
	* Architecture is set to **ARM64** for HoloLens 2
	* Other general settings for HoloLens project should apply
4. If uploading via USB:
	* Hit **Build**, and specify a path for the Visual Studio solution
	* Open the Visual Studio Solution, and change the following settings:
		* Configuration is set to **Release, ARM64** for HoloLens 2
		* Deploy to **Device** or **Remote Machine**
5. If uploading via Wi-Fi:
	* Build and Run on is **Remote Device (via Device Portal)**
	* Build Configuration is **Release**
	* Input the Address, Username, and Password like you would to access Device Portal
	* Hit **Build and Run**, and specify a path for the Visual Studio solution
6. The Unity application will automatically start on the device

## Compatibility

The following versions of the software are used for development.

* Unity 2019.4.17f1
* Windows 10 SDK 10.10240.0 +
* Visaul Studio 2019 for deployment to HoloLens 2

---
