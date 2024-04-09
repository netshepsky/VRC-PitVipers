## Setup Guide
1. Add the following community repositories to your VRChat Creator Companion app (go to each of the below URL's and click "Add to VCC")
    - VRCFury - `https://vcc.vrcfury.com`
    - voxel's VPM registry - `https://vpm.voxint.net`
    - Poiyomi Toon Shader - `https://poiyomi.github.io/vpm`
      - *Warning: If you already have Poiyomi installed from a .unitypackage, installing the VCC package will remove it!*
2. Go to "Manage Project", then click the plus button next to the following packages:
    - VRCFury
    - Poiyomi Toon Shader
    - Pit Vipers
3. Open the project in Unity
4. In your Project pane, go to the Prefabs folder (`Packages -> Pit Vipers -> Assets -> Prefabs`)

5. Find the existing model specific prefab under the `Prefabs` folder. Existing model specific prefabs include:
    - Novabeast
    - _If your model isn't listed, use the `Pit Vipers (Poseable)` prefab instead_
6. *Drag the desired prefab object into the root of your scene heirarchy first. Then drag it under your avatar root*

7. If you're using the `Default` prefab:
    - Turn on the disabled "Pit Vipers" object (so you can see what you're doing)
    - Move/scale the game object until the glasses are in the desired spot
    - Turn the pit vipers game object back off (the child object, not the one with the VRCFury component on it)

9. (Optional) Change the color of different parts of the glasses using one of the provided materials in the "Materials" folder (or make your own, I don't care lol)
9. ???
10. PROFIT! NOW YOU LOOK SICK AS FUCK (toggle them on in your radial menu, under Clothing -> Pit Vipers)

# Sources
Original glasses model by [Linnaeus](https://sketchfab.com/3d-models/pit-viper-style-glasses-5a4c994f0b7342f48783325f4b001731)
Remesh/UV mapping work by @netshepsky

# Licensing
- Glasses 3D model - [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.en)
- Everything else - [GNU LGPLv3](https://choosealicense.com/licenses/lgpl-3.0/)

# Known issues
- The UV map for the frame arms needs work as it's really only good for solid colors right now
- This model uses 3 materials instead of 1 because I'm too lazy to fix the masking for the material. If someone decides to optimize this themselves, I'm open to accepting a PR to include it in this repo.

# Disclaimer
This is a fan-made project and is in no way associated with Pit Viper, LLC. The Pit Viper logo and other registered trademarks belong to their respective copyright owners.