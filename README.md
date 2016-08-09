# RN-openCV-demo
This is a 'pokemon' style AR app written using React Native.

![screenshot](https://s-media-cache-ak0.pinimg.com/236x/2c/1e/18/2c1e180a3e8f9f53a5f0031d42fc5ebd.jpg)

Use this as a template / guide, for building your own AR apps using React Native and Three.js.

It consists of Video passthrough, RN-openCV component, webView/webGL, and React-Native !

### How it works
1. The video feed is fed into openCV, which detects the {position, directionVector and scale} of a QR-code.  
2. The {result} is fed into a wkWebView via the javascript bridge.
3. The webView renders the 3D creature using three.js/webGL at the given {position, direction and scale}.
4. The webView canvas is overlayed over the live-camera canvas, using a transparent background.


### Installation
1. command line

> npm install [github / react-native-opencv](https://github.com/dadevelopers/react-native-opencv)

2. read chapter 2.

[Mastering OpenCV with Practical Computer Vision Projects [pdf]](pdf/MasteringOpenCV.pdf)

3. look at source code example: [book/ chapter2/ src/](https://github.com/MasteringOpenCV/code/blob/master/Chapter2_iPhoneAR/Example_MarkerBasedAR/Example_MarkerBasedAR/VideoSource.mm)

### Dependencies
[github / react-native-opencv](https://github.com/dadevelopers/react-native-opencv)
