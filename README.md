# StresslessHeadless

A [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) mod for [Resonite](https://resonite.com/) that disables frequent and heavy calculations on certain components from running on Headless clients. 

**Disclaimer: this may occasionally cause irregular behavior in some sessions, config options are provided in the event issues occur.**

The following cases are known to cause irregular behavior:
- Requiring the host to provide the output of a driven value from a component that's disabled by this mod.
- Making the host run the async call in a "Bake Meshes" node

## What gets skipped:

### Assets

- Asset Variant Generation
- All procedural meshes
- All procedural textures

### Avatar/Cosmetic

- DynamicBoneChain
- EyeManager
- VRIK
- VRIKAvatar

### Logs (not skipped by default)

- Errors
- Logs  
- Warnings 

### Protoflux

- UI generation

### Transforms

- AxisAligner
- AutoLookAtUser
- EyeManager
- LookAt
- LookAtUser
- Panner1D/2D/3D/4D
- Spinner
- Wiggler
- Wobbler1D/2D/3D/4D

## Commands added by this mod:

- stress <enable/disable>
  - Allows everything to run, regardless of config settings. Primarily for A/B testing or for quickly checking if StresslessHeadless is causing any issues.

## Why does the headless client do this if it's not needed?

The headless client is, for the most part, the main client with rendering removed and some additions for a functional CLI interface. This means that everything the client runs, the headless runs too. This isn't a bad thing though, as it ensures behavioral parity by making sure everything runs the same on all clients. This may change in the future, though.

A lot of what's skipped here is stuff that's not networked or intended to only run locally, so the headless can simply not run some things without disrupting sessions. This is fine for the most part and will likely never cause issues in social settings but there are some cases where irregular behavior occurs and config options are provided to re-allow whatever may be causing the issue.

## Despite what the name may imply, resource usage on your headless host may increase

With less work to do per update, each update can run quicker, causing more updates to happen, which means increased resource usage. This will vary based on the worlds hosted and user's avatars. A similar thing occured with the switch from Mono to .Net 8, as the new runtime was far more efficient and could run faster, causing more resource usage.

## Requirements
- [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) 2.6.0 or later

## Installation
1. Install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader).
2. Place [StresslessHeadless.dll](https://github.com/Raidriar796/StresslessHeadless/releases/latest/download/StresslessHeadless.dll) into your `rml_mods` folder inside of the Headless installation. You can create it if it's missing, or if you launch the game once with ResoniteModLoader installed it will create the folder for you.
3. Start the game. If you want to verify that the mod is working you can check your Resonite logs.
