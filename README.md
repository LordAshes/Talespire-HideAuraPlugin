# Hide Aura Plugin

This unofficial TaleSpire plugin for synchronizing the visibility state of auras with the hide
state of the mini. This allows the creation of aura minis (which can have transparency and other
features) without losing hide functionality.  

## Change Log

```
1.0.1: Added the missing Aura Hearts assets. No plugin change.
1.0.0: Initial release
```

## Install

Install using R2ModMan or similar. The plugin is then available for any parent plugin to use it.

## Usage

To create a mini compatible with this plugin, the process is a two step process similar to how
CMP works. The steps are as follows:

```
1. Spawn a Aura Heart mini from the Support folder. The Aura Heart mini looks like an empty base
   with a tiny cube in it.
2. Select the Aura Heart mini.
3. Select the desired creature mini from the library while holding ALT.
```

This covers the Aura Heart with the desired creature mini. Since the creature mini was spawned
using the Aura option (holding ALT), it can make use of transparency and other features not
available when using the TS/Creature shader. Without this plugin, when such a creature was used,
the Hide function (including LOS hide and height bar) did not hide the mini. This plugin fixes
that issue by syncing up the hide status of the Aura Heart and the aura.

There are two Aura Heart bases. One of them has the Aura Heart cube hidden in the base. The other
has the Aura Heart cube 0.5 tiles distance in the air. The second Aura Heart base will be more
accurate for LOS and height bar but depending on the shape of the mini, the cube could be visible.
The first base will be a little less accurate with LOS and height bar but the cube will be hidden
regardless of the mini shape.  


## Limitations

Since the plugin uses the Aura Heart to determine if the aura should be hidden or not and the
Aura Heart is much smaller than the actual aura mini, it can have some impact on LOS visibility
and height bar visibility.
