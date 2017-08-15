# NetStandard Library Template

Looking to start a new repo for a cross-platform .net library?  Use this template to get started.

## What's Included

1. NetStandard library
1. NetStandard Test project
1. Sample Apps (using Xamarin Forms so you only need to write UI once)
    * UWP
    * iOS
    * macOS
    * Android

## Instructions

1. Create your new repo
1. Copy all files from this repo to your new repo (don't forget the hidden files as well, `.gitignore`, `.gitattributes`, `.vscode`)
    * The command will probably look something like this:
    ```bash
    cd MyNewRepo
    cp -r ~/Downloads/NetStandardLibraryTemplate-master/ .
    ```
1. Commit as your initial commit
1. Now update your library name by running the [powershell script](RenameLibrary.ps1)
    ```
    RenameLibrary.ps1 -OldLibraryName "MyAwesomeLibrary" -NewLibraryName "<your library name here in PascalCase>"
    ```
    * If you aren't on Windows that's ok, powershell is available for [all platforms](https://github.com/PowerShell/PowerShell#get-powershell).
1. Update the actual library and the tests and the Forms sample app UI

## Requirements

* [Visual Studio](https://www.visualstudio.com/vs/)
* [.Net Core SDK](https://www.microsoft.com/net/download/core) (to build from command line)

## To build from command line
```
msbuild /t:restore
msbuild
```

## Future Improvements

* Update template to include a platform specific implementation
* Provide sample docs to include in a library's repo, like:
    * How to build
    * How to publish builds
    * How to setup CI
    * How to run tests