
# react-native-gymnastics-wonderful-moment-show

## Getting started

`$ npm install react-native-gymnastics-wonderful-moment-show --save`

### Mostly automatic installation

`$ react-native link react-native-gymnastics-wonderful-moment-show`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-gymnastics-wonderful-moment-show` and add `RNGymnasticsWonderfulMomentShow.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNGymnasticsWonderfulMomentShow.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNGymnasticsWonderfulMomentShowPackage;` to the imports at the top of the file
  - Add `new RNGymnasticsWonderfulMomentShowPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-gymnastics-wonderful-moment-show'
  	project(':react-native-gymnastics-wonderful-moment-show').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-gymnastics-wonderful-moment-show/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-gymnastics-wonderful-moment-show')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNGymnasticsWonderfulMomentShow.sln` in `node_modules/react-native-gymnastics-wonderful-moment-show/windows/RNGymnasticsWonderfulMomentShow.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Gymnastics.Wonderful.Moment.Show.RNGymnasticsWonderfulMomentShow;` to the usings at the top of the file
  - Add `new RNGymnasticsWonderfulMomentShowPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNGymnasticsWonderfulMomentShow from 'react-native-gymnastics-wonderful-moment-show';

// TODO: What to do with the module?
RNGymnasticsWonderfulMomentShow;
```
  