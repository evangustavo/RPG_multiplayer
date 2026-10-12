# Project RPG Game dengan sistem multiplayer menggunakan UGS
# Sistem Lobby - Host

![Banner](Documentation/Images/Banner.png)
<br><br>

###  Made with and Including Utilities for Netcode for GameObjects
<br>

[![UnityVersion](https://img.shields.io/badge/Unity%20Version:-6000.0.52f1%20LTS-57b9d3.svg?logo=unity&color=2196F3)](https://unity.com/releases/editor/whats-new/6000.0.52)
[![NetcodeVersion](https://img.shields.io/badge/Netcode%20Version:-2.4.3-57b9d3.svg?logo=unity&color=2196F3)](https://github.com/Unity-Technologies/com.unity.netcode.gameobjects/releases/tag/v2.4.3)
[![LatestRelease](https://img.shields.io/badge/Latest%20Github%20Release:-v3.0.0-57b9d3.svg?logo=github&color=brightgreen)](https://github.com/Unity-Technologies/com.unity.multiplayer.samples.coop/releases/tag/v3.0.0)
<br><br>

Boss Room is a fully functional co-op multiplayer RPG made with Unity Netcode. It is an educational sample designed to showcase typical netcode [patterns](https://docs-multiplayer.unity3d.com/netcode/current/learn/bossroom/bossroom-actions/index.html) that are frequently featured in similar multiplayer games.
<br><br>

# Boss Room Sample Overview

Boss Room is designed to be used in its entirety to help you explore the concepts and patterns behind a multiplayer game flow; such as character abilities, casting animations to hide latency, replicated objects, RPCs, and integration with [Multiplayer Services sessions](https://docs.unity.com/ugs/en-us/manual/mps-sdk/manual) and [Authentication](https://unity.com/products/authentication) services.

You can use the project as a reference starting point for your own Unity game or use elements individually.
<br><br>

---

### 💡 Utilities Package
This repository also contains a [Utilities](Packages/com.unity.multiplayer.samples.coop) package, containing reusable sample scripts. You can install it using the following manifest file entry:
<br>
`"com.unity.multiplayer.samples.coop": "https://github.com/Unity-Technologies/com.unity.multiplayer.samples.coop.git?path=/Packages/com.unity.multiplayer.samples.coop",`

---


<br>

For more information on the art of Boss Room, see [ART_NOTES.md](Documentation/ART_NOTES.md).


![](Documentation/Images/Boss.png)
<br><br>
  
-----

## Readme Contents and Quick Links
<!-- TOC generated from https://luciopaiva.com/markdown-toc/ -->
<details open>
<summary> <b>Click to expand/collapse contents</b> </summary>

- ### [Getting the project](#getting-the-project-1)
  - [Direct download](#direct-download)
  - [Installing Git LFS to clone locally](#installing-git-lfs-to-clone-locally)
- ### [Requirements](#requirements-1)
  - [Min Spec Devices](#boss-rooms-min-spec-devices-are)
- ### [Opening the project for the first time](#opening-the-project-for-the-first-time-1) 
- ### [Exploring the project](#exploring-the-project-1)
  - [Registering with Unity Gaming Services (UGS)](#registering-the-project-with-unity-gaming-services-ugs)
- ### [Testing multiplayer](#testing-multiplayer-1) 
  - [Local Multiplayer Setup](#local-multiplayer-setup)
  - [Multiplayer over Internet](#multiplayer-over-internet)
  - [Multiplayer Services Setup](#multiplayer-services-setup) 
- ### [Index of resources in this project](#index-of-resources-in-this-project-1)
  - [Gameplay](#gameplay)
  - [Game Flow](#game-flow)
  - [Connectivity](#connectivity)
  - [Services (Sessions and Authentication)](#services-sessions-authentication)
  - [Tools and Utilities](#tools-and-utilities)
- ### [Troubleshooting](#troubleshooting-1)
  - [Bugs](#bugs)
  - [Documentation](#documentation)
- ### [License](#license-1)
- ### [Contributing](#contributing-1)
- ### [Community](#community-1)
- ### [Feedback Form](#feedback-form-1)
- ### [Other samples](#other-samples-1)
  - [Bitesize Samples](#bitesize-samples)
</details>

------
<br>

## Getting the project
### Direct download
 - You can download the latest version of Boss Room from our [Releases](https://github.com/Unity-Technologies/com.unity.multiplayer.samples.coop/releases) page. 
 - __Alternatively:__ click the green `Code` button and then select the 'Download Zip' option.  Please note that this will download the branch that you are currently viewing on Github.  
 - __Windows users:__ Using Windows' built-in extraction tool may generate an "Error 0x80010135: Path too long" error window which can invalidate the extraction process. A workaround for this is to shorten the zip file to a single character (eg. "c.zip") and move it to the shortest path on your computer (most often right at C:\\) and retry. If that solution fails, another workaround is to extract the downloaded zip file using [7zip](https://www.7-zip.org/).
<br><br>

## Requirements

BossRoom is compatible with the latest Unity Long Term Support (LTS) editor version, currently [6000.0 LTS](https://unity.com/releases/editor/archive). Please include standalone support for Windows/Mac in your installation.

**PLEASE NOTE:** You will also need Netcode for Game Objects to use these samples. See the [Installation Documentation](https://docs-multiplayer.unity3d.com/netcode/current/installation) to prepare your environment. You can also complete the [Get Started With NGO](https://docs-multiplayer.unity3d.com/netcode/current/tutorials/get-started-ngo) tutorial to familiarize yourself with Netcode For Game Objects.
<br><br>

#### Boss Room has been developed and tested on the following platforms:
- Windows
- Mac
- iOS
- Android <br>

#### Boss Room's min spec devices are:
- iPhone 6S
- Samsung Galaxy J2 Core 
<br><br>

### Installing Git LFS to clone locally

Boss Room uses Git Large Files Support (LFS) to handle all large assets required locally. See [Git LFS installation options](https://github.com/git-lfs/git-lfs/wiki/Installation) for Windows and Mac instructions. This step is only needed if cloning locally. You can also just download the project which will already include large files.
<br><br>



## Opening the project for the first time

Once you have downloaded the project, follow the steps below to get up and running:
 - Check that you have installed the most recent [LTS editor version](https://unity.com/releases/unity-6-releases).
 	- Include standalone support for Windows/Mac in your installation. 
 - Add the project to the _Unity Hub_ by clicking on the **Add** button and pointing it to the root folder of the downloaded project.
 	- __Please note :__ the first time you open the project Unity will import all assets, which will take longer than usual.

 - Hit the **Play** button. You can then host a new game or join an existing one using the in-game UI.

  ![](Documentation/Images/StartupScene.png)
<br><br><br>

## Exploring the project
BossRoom is an eight-player co-op RPG game experience, where players collaborate to fight imps, and then a boss. Players can select between classes that each have skills with didactically interesting networking characteristics. Control model is click-to-move, with skills triggered by a mouse button or hotkey.

One of the eight clients acts as the host/server. That client will use a compositional approach so that its entities have both server and client components.

- The game is server-authoritative, with latency-masking animations. 
- Position updates are carried out through NetworkTransform that sync position and rotation. 

Code is organized in domain-based assemblies. See the [Boss Room architecture documentation](https://docs-multiplayer.unity3d.com/netcode/current/learn/bossroom/bossroom-architecture) file for more details.
<br><br>

### Registering the project with Unity Gaming Services (UGS)

Boss Room leverages several services from UGS to facilitate connectivity between players. To use these services inside your project, you must [create an organization](https://support.unity.com/hc/en-us/articles/208592876-How-do-I-create-a-new-Organization-) inside the Unity Dashboard. Otherwise, you can still use Boss Room without UGS.
<br><br><br>
 
## Testing multiplayer

In order to see the multiplayer functionality in action we can either run multiple instances of the game locally on your computer - using either Multiplayer Play Mode or builds - or choose to connect to a friend over the internet. See [how to test](https://docs-multiplayer.unity3d.com/netcode/current/tutorials/testing/testing_locally) for more info.
<br><br>

### Local multiplayer setup

First, build an executable by clicking **'File/Build Settings'** in the menu bar, and then click **'Build'**.<br>  
![](Documentation/Images/BuildProject.png)

Once the build has completed you can launch several instances of the built executable in order to both host and join a game. When using several instances locally, you will have to set different profiles for each instance for authentication purposes, by using the **'Change Profile'** button. <br>  

---

💡  **Mac users:** To run multiple instances of the same app, you need to use the command line. Run `open -n BossRoom.app`

---

<br>

### Multiplayer over Internet

To play over internet, first build an executable that is shared between all players - as above.

It is possible to connect between multiple instances of the same executable OR between executables and the editor that produced it.

Running the game over internet currently requires setting up a relay. 
  
  
### Multiplayer Services Setup
 
- Boss Room uses the Multiplayer Services Package to integrate [Sessions](https://docs.unity.com/ugs/en-us/manual/mps-sdk/manual) for grouping and connecting players.

- Alternatively you can use Port Forwarding. The https://portforward.com/ site has guides on how to enable port forwarding on a huge number of routers.
- Boss Room uses `UDP` and needs a `9998` external port to be open. 
- Make sure your host's address listens on 0.0.0.0 (127.0.0.1 is for local development only).
<br><br><br>

-----

  
  ![](Documentation/Images/Players.png)

