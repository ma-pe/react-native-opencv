# react-native-opencv

**Currently being developed :)**

React Native Bindings for openCV.
**Yet there are no React Native bindings.**

Though you can already use this library to manage your OpenCV dependencies for your **native code**. You will then be able to use the framework in your **native code**.

## Integrate OpenCV into iOS

1. Add this lib to your project:
`yarn add https://github.com/ma-pe/react-native-opencv#master`

2. Add the OpenCV framework to your .xcodeproject's framework searchpaths (Build Settings / Framework Search Paths):
`${PROJECT_DIR}/../node_modules/react-native-opencv/ios/Frameworks`

I'd like to recommend these tutorials for OpenCV / Objective-C starters: [OpenCV iOS¶](https://docs.opencv.org/2.4/doc/tutorials/ios/table_of_content_ios/table_of_content_ios.html)

## Integrate OpenCV into Android

1. Add this lib to your project:
`yarn add https://github.com/ma-pe/react-native-opencv#master`

2. Import OpenCV module in Android Studio (File / New / Import Module):
`/../node_modules/react-native-opencv/android/openCVLibrary340`

3. Configure Module as dependency:
File / Project Structure / app / Tab: Dependencies / + / Module Dependency / openCVLibrary340

4. Change app's build.gradle:
`implementation project(':openCVLibrary340')` to `compile project(':openCVLibrary340')`

5. Copy the contents of `/../node_modules/react-native-opencv/android/app` into `./app` (those are the actual android binary files that are required).

You are good to go.
