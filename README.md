# teleops360
Live stream RICOH Theta V 360 video to Unity 3D and HTC Vive VR headset.
A project done with Real Robotics at the University of Leeds.

# Hardware Requirements

1. HTC Vive Pro
2. RICOH Theta V 360 Camera with firmware 2.11.1 or higher
3. VR-ready PC with (3) USB ports and (1) display port  
4. Micro USB to USB cable

# Software Requirements

1. Unity 3D Version 2019.3.6f1 (https://store.unity.com/#plans-individual)
2. SteamVR Plugin for Unity ([https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647](https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647))
3. RICOH Theta V Live Streaming Driver 1.0.1-64 bit ([https://topics.theta360.com/en/faq/c_06_v/304_1/](https://topics.theta360.com/en/faq/c_06_v/304_1/))

# Instructions

1. Install all software and hardware components
2. Set up HTC Vive VR HMD as instructed (one lighthouse is enough tracking the user's front)
3. Download (clone) the Teleops360 repository on GitHub ([https://github.com/paulbaniqued/teleops360](https://github.com/paulbaniqued/teleops360))
4. Open Unity and open the project "teleops360" by locating the scene file in the cloned GitHub repository: 
    1. teleops360 > Assets > Scenes > **wc-test2.unity**
5. Turn on the RICOH Theta V camera and set to Live Streaming Video Mode (a videocamera icon with the word LIVE should be displayed)
6. Play the Unity Scene and wear the HTC Vive VR HMD
7. You should now see the live camera stream from the VR HMD as a 360 environment

# Additional Notes

1. The blender sphere in Unity is inverted with a scale of -175,-175,-175 (x,y,z). You can adjust the scale of this to adjust the size perception for the user. Make sure that the values are uniformed so the sphere (and the real world objects) don't appear distorted.
2. The blender sphere also has rotation values of 0,-90,0 (x,y,z) as a default.
3. The console log in Unity will display the number of cameras attached to the PC during game mode (when the scene is played). Make sure that the camera name being used is "RICOH Theta V 4K" in the **webCamDetect.js** script in the Assets > Scripts folder. To change this, simply change line 14 in the script to the appropriate number assiged to RICOH Theta V:

    ```jsx
    string camName = devices[3].name;
    ```

    Note: The camera number in the PC where this application was made is [3]. Change this if "RICOH Theta V 4K" has a different value assigned to it.

4. SteamVR will show an error message if the VR headset is not installed properly. To test the live stream of the 360 camera without VR, please open the other scene file in the same Assets > Scenes folder. Filename: **wc-test1.unity**

# Credits

1. RICOH THETA V with HTC Vive Using SteamVR ([https://github.com/codetricity/theta-v-htc-vive-steamvr](https://github.com/codetricity/theta-v-htc-vive-steamvr))
2. RICOH THETA Z1 and V with Unity in 2021 for 360 Video Streaming ([https://youtu.be/63lxR0aBrZM](https://youtu.be/63lxR0aBrZM))
