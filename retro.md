# Setup Guide for Retro Cross-Platform Sync
This setup guide with take you step-by-step on setting up cross-platform (Android <-> Windows) cloud sync using existing technology.

### Prerequisites
The following is a list of prerequisites that may need to be installed before Retro Cross-Platform Sync to work.
```
Google Drive or Dropbox
RetroArch
Windows, Android, or Linux
```

### Install Google Drive, Dropbox or OneDrive
We recommend following this type of directory structure within Google Drive/Dropbox.

Create the following directories within Google Drive/Dropbox. These directories should be blank at this time.

Google Drive/Dropbox = "G$"

```
ROMS = G$/Games/RetroBit.Games/roms/
SAVES = G$/Games/RetroBit.Games/saves/
SAVE_STATES = G$/Games/RetroBit.Games/states/
CONFIG = G$/Games/RetroBit.Games/config/
```

### Install DriveSync for Google Drive, AutoSync for Dropbox or Autosync for OneDrive
If you want to sync your states and saves to Android you must download and use DriveSync. DriveSync will allow real-time monitoring for your files to pull data from the cloud to your Android device.

1. Synced Folders -> Enable Autosync enabled
2. Remote folder in Google Drive
```
/Games/RetroBit.Games/roms
```
3. Local folder in device
```
/storage/emulated/0/RetroBit.Games/roms
```
4. Synced Folders -> Two-way enabled
## RetroArch Setup
This is the most important step within the configuration of Cross-Platform syncs. You must change where RetroArch is pulling your save files and state files. Please see below on how to configure each platform.

#### Windows

#### Android
