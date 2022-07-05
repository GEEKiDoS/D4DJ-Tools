# D4DJ Tools
Tools for processing D4DJ files
## AssetTool
- Decrypt .enc files
- Dump (mostly) Master.msgpack.enc files into json
- Dump ResourceList.msgpack into json
- Dump/Encoding charts

### Usage
- Drag files or directories on to this tools
- Profit

## MusicRenamer
- Rename music_XXXXXXX.mp3 to real name and add infomations

### Usage
- Dump MusicMaster and UnitMaster to json with AssetTool
- ```MusicRenamer.exe <MusicMaster.json> <UnitMaster.json> [mp3 files to rename]```

## Chart Previewer
Link: [Chart Previewer](https://girlsband.party/d4dj/chart-previewer/)

### Usage
- Open chart that dumped by asset tool

## Chart Editor
- Modified from bangbangboom editor
Link: [Chart Editor](https://girlsband.party/d4dj/editor/)

## Requirements
- .NET 5.0 (Actually change to older versions should works too, but we just love newer version don't we?)

## Special Thanks
- [@RayFirefist](https://github.com/RayFirefist) - For tips on messagepack

## Disclaimer
- This project is only for research purposes 
- I'm not responsible for ANY illegal usage for this tool.
