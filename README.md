## Setup Guide
1. Add the following community repositories to your VRChat Creator Companion app (go to each of the below URL's and click "Add to VCC")
   - VRCFury - `https://vcc.vrcfury.com`
   - voxel's VPM registry - `https://vpm.voxint.net`
   - Poiyomi Toon Shader - `https://poiyomi.github.io/vpm`
      - ***Warning: If you already have Poiyomi installed from a .unitypackage, installing the VCC package will remove it! You can skip this step if it's already installed!***
2. Go to "Manage Project", then click the plus button next to the following packages:
   - VRCFury
   - Poiyomi Toon Shader (skip if already installed from .unitypacakge)
   - Pit Vipers
3. Open the project in Unity
4. In your Project pane, go to the Prefabs folder (`Packages -> Pit Vipers -> Assets -> Prefabs`)

5. Find the existing model specific prefab under the `Prefabs` folder. Existing model specific prefabs include:
   - Novabeast
   - _If your model isn't listed, use the `Pit Vipers (Poseable)` prefab instead_
6. **Drag the desired prefab object into the root of your scene hierarchy first. Then drag it under your avatar's head bone**

7. If you're using the default prefab:
   - Unpack the prefab completely (Right-click `Pit Vipers (Poseable)` in the hierarchy, then Prefab -> Unpack completely)
   - Move/scale the parent game object until the glasses are in the desired spot
   - Adjust the blendshapes on the `Pit Vipers` child object until you have the desired look
   - Finally, right click on `Pit Vipers` in the hierarchy, then Mesh Baker -> Bake mesh
     - Name the exported file and put it somewhere in your assets folder. It doesn't really matter where
     - If you hate performance and want to waste an extra skinned mesh renderer slot, then skip this step I guess lol
8. If you want your glasses to be poseable, click `Glasses Bone`, then drag the `Pit Vipers` child object from the hierarchy into `Element 0` under the Ignore Transforms section
   - If you have Gesture Manager installed, you may wish to put the scene in play mode at this point and make sure the glasses pivot as you intend
9. (Optional) Change the color of different parts of the glasses using one of the provided materials in the "Materials" folder or make your own
10. ???
11. PROFIT! NOW YOU LOOK SICK AS FUCK (toggle them on in your radial menu, under Clothing -> Pit Vipers)

# Sources
Original glasses model by [Linnaeus](https://sketchfab.com/3d-models/pit-viper-style-glasses-5a4c994f0b7342f48783325f4b001731)
Remeshing/UV mapping work by @netshepsky

# Licensing
- Glasses 3D model - [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/deed.en)
- Everything else - [GNU LGPLv3](https://choosealicense.com/licenses/lgpl-3.0/)

# Known issues
- The UV map for the frame arms needs work as it's really only good for solid colors right now
- This model uses 3 materials instead of 1 because I'm too lazy to fix the masking for the material. If someone decides to optimize this themselves, I'm open to accepting a PR to include it in this repo.

# Disclaimer
This is a fan-made project and is in no way associated with Pit Viper, LLC. The Pit Viper logo and other registered trademarks belong to their respective copyright owners.