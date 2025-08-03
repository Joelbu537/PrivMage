# PrivMage
This application allows you to encrypt and view images. Currently supported formats are:
- PNG
- JPG/JPEG
- BMP (not tested)

Planned formats:
- GIF
- WEBP (Automatic conversion to jpeg)

## Features
- Create image albums with a title, cover image, tags and images contained within it.
- Browse your albums, and view the images inside of them.
- Export images from your albums to ordinary files.
> [!NOTE]
> Data leak included free of charge! Not really a "leak", however the RAM still gets bloated for whatever reasons.

## Planned Features
- Deleting and editing albums
- Sorting the Items in Select
- Custom preferences (Like default directory)
- File Size info

## Encryption
All Data is stored in multiple JSON Files that are encrypted with AES256 using your password and a locally stored salt to prevent raindow table attacks.
Album data is collectively stored in a single library file, whereas the contents of each album are stored in a seperate file with a random id.

**Folder Structure:**
PrivMage/  
├── PrivMage.exe&nbsp;&nbsp;The application  
├── lib&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;The library file  
├── 743820156&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Album  
├── 1384291207&nbsp;&nbsp;&nbsp;&nbsp;Album  
├── 1952740528&nbsp;&nbsp;&nbsp;&nbsp;Album  
└── 2031508933&nbsp;&nbsp;&nbsp;&nbsp;Album  
