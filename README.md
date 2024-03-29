# StresslessHeadless

A [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) mod for [Resonite](https://resonite.com/) that disables frequent and heavy calculations on certain components from running on Headless clients. 

**Disclaimer: this may occasionally cause irregular behavior in some sessions, config options are provided in the event issues occur.**

The following cases are known to cause irregular behavior:
- Requiring the host to provide the output of a driven value from a component that's disabled by this mod.
- Making the host run the async call in a "Bake Meshes" node


## What gets disabled:

- AutoLookAtUser
- DynamicBoneChain
- EyeManager
- LookAt
- LookAtUser
- Panner1D-4D
- Procedural Meshes
- Spinner
- VRIK
- VRIKAvatar
- Wiggler
- Wobbler1D-4D

## Requirements
- [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) 2.6.0 or later

## Installation
1. Install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader).
2. Place [StresslessHeadless.dll](https://github.com/Raidriar796/StresslessHeadless/releases/latest/download/StresslessHeadless.dll) into your `rml_mods` folder inside of the Headless installation. You can create it if it's missing, or if you launch the game once with ResoniteModLoader installed it will create the folder for you.
3. Start the game. If you want to verify that the mod is working you can check your Resonite logs.
