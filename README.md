# Workshop
Workshop for university students

#Starter package
Clone or download the package to your latops


# Requirements

We use windows workstation and work with Xamarin,Android platform for this workshop. Since we need a MAC to see an IOS app ,we wont do IOS in this workshop.

Thus as of now following should be installed
    
Windows 7, Windows 8, Windows 8.1, or Windows 10,
Java JDK 8 (1.8),
Xamarin Platform,
Xamarin studio

Note:
All these installation instructiona  can be found in following Xamarin developer site.I just copied the instructions for your easy

https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/



# Installtion and prepare your devlopment environment

You can follow either universal installation or Manual instalation


# Universal Installer

The first step is to download the Xamarin unified installer, which can be found at http://www.xamarin.com/Download:

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/Images/download.png)

Select the I already have Visual Studio Installed checkbox, you will be offered the option of downloading Xamarin through the Xamarin universal installer


1) Open the installer to begin the installation process:

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/Images/downloadstart.png)


2) The first step in the installation requires you to review and accept the license in order to proceed. To do this, click the checkbox and press Next:

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/Images/installer2.png)

3) Identify the Required Components

Next, the installer will inspect the system to determine which, if any, required components are missing and need to be downloaded and installed. You can select which products you wish to download here:

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/Images/installer3.png)

4) Install the Components

After identifying missing components, the Xamarin installer will download and execute the installers for the platform dependencies, as shown in the screenshots below.

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/Images/installer4.png)

The Xamarin unified installer will start the download and install process of the selected items:

1{alt tag] (https://developer.xamarin.com/guides/android/getting_started/installation/windows/Images/installer6.png)


5) Configure Xamarin.Android

Finally, after we’ve installed the different parts, we can configure them to complete our installation:

Configure the SDKs – Once we’ve installed the SDK prerequisites listed above, we will need to configure the paths to the SDK directories in Xamarin Studio.

Configure the Emulator – In order to run and debug our Xamarin.Android applications, we need to use the Android Virtual Device (AVD) Manager to create and configure devices. 
Instructions for this can be found in the Configuring the Emulator guide(https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/debug-on-emulator/android-sdk-emulator/#Configuring_Virtual_Devices).

Open the Xamarin Studio ,In the menu bar, navigate to Tools > Options > Projects > SDK Locations > Android as illustrated in the screenshot below:
		
![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image14.png)


JDK: Xamarin Studio will target the default location for the Java JDK. If the JDK was previously installed or was installed to a location other than the default, you can configure that path by clicking Browse and then navigating to the correct location.

Android SDK: In the Android SDK section, specify the installation path to the Android SDK by clicking Browse and then navigating to the Android SDK directory. Make sure that the correct path to the Android NDK is also specified.




#  Manual installation

# 1)JDK 

Download Java 1.8 from follwing link.Download the Java vesion as menytioned in the Image

http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image1.png)

If you are using a 64-bit version of Windows, install 64-bit version of JDK 8 (1.8) If you are using a 32-bit version of Windows, install the 32-bit version of the JDK 8(1.8).


# 2)Install the Android SDK 
Download the ANDROID SDK in following Link

https://developer.android.com/studio/index.html#downloads

The SDK can be downloaded from the above Android Studio website and will have a file name like tools_r[x].[x].[x]-windows.zip. 
It is not necessary to download the entire Android Studio bundle as we only need the SDK. Select the Windows zip file under Get just the command line tools as illustrated below:

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image2.png)

After downloading the SDK you will need to extract it. We recommend extracting the zip to C:\Program Files (x86)\Android\android-sdk however you can use another preferred location on your disk.



# 3)Install the Android NDK

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image4.png)

Once downloaded, extract the NDK to the same location as the SDK (C:\Program Files (x86)\Android). This should create a directory named android-ndk, potentially with a version number in the name.



# 4) Install required tools and API


![alt tag] (https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image6.png)

4.1) Navigate to your Android SDK directory in Explorer and double click on SDK Manager.exe to run it as metioned above

4.2) Install the required SDK Tools and APIs – Once launched, we can use the Android SDK manager to select the relevant components for installation. The latest version of the following components must always be selected:

    		Android SDK Tools
    		Android SDK Platform-tools
    		Android SDK Build-tools.

4.3) These selections are indicated in the screenshot below:
![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image7.png)

4.4) To start installation, click the Install [x] packages button, accept the Android SDK licenses on the following screen and click Install, as displayed below:

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image9.png)

4.5) Install more Android Platforms.Deciding which platforms to install is entirely up to you, although it is recommended that at least the most popular platforms in the Android Dashboard be installed. 
	
![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image10.png)

# 5) Install Xamarin 

5.1) Create a Xamrin account in following link

https://www.xamarin.com/account/login?returnUrl=http://www.xamarin.com/

5.2) Login to the account and download the Xamarin anroid ,Xamarin IOS
To install login the above page and navigate to Downloads. Then, in the Windows dropdown under Xamarin.Android, download the latest version and install those downloaded Exe

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image13.png)

Dowload the Xamarin.IOS as wells

5.3) Install Xamarin Studio for Window
	
5.3.1) Download & Install GTK 

It can be downloaded from the Download section on the follwing website. 

http://www.mono-project.com/download/#download-win
		
![alt tag] (https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image11.png)


5.3.2)Install Xamarin Studio
To download Xamarin Studio, log in to your Xamarin account agian with credentials you already created.And navigate to the Downloads page.
Download the latest version from the Windows dropdown under Xamarin Studio

![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image12.png)

Once downloaded, click on the .exe file to install the product, and follow the Installation Wizard.

# 6) Configure Xamarin.Android

Finally, after we’ve installed the different parts, we can configure them to complete our installation:

Configure the SDKs – Once we’ve installed the SDK prerequisites listed above, we will need to configure the paths to the SDK directories in Xamarin Studio.

Configure the Emulator – In order to run and debug our Xamarin.Android applications, we need to use the Android Virtual Device (AVD) Manager to create and configure devices. 
Instructions for this can be found in the Configuring the Emulator guide(https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/debug-on-emulator/android-sdk-emulator/#Configuring_Virtual_Devices).

Open the Xamarin Studio ,In the menu bar, navigate to Tools > Options > Projects > SDK Locations > Android as illustrated in the screenshot below:
		
![alt tag](https://developer.xamarin.com/guides/android/getting_started/installation/windows/manual_installation/Images/image14.png)


JDK: Xamarin Studio will target the default location for the Java JDK. If the JDK was previously installed or was installed to a location other than the default, you can configure that path by clicking Browse and then navigating to the correct location.

Android SDK: In the Android SDK section, specify the installation path to the Android SDK by clicking Browse and then navigating to the Android SDK directory. Make sure that the correct path to the Android NDK is also specified.

