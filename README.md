[Прочитать эту страницу по-русски](https://github.com/vazhka-dolya/ChameleonCK/blob/main/README.ru.md) · [Посмотреть список изменений в обновлениях по-русски](https://github.com/vazhka-dolya/ChameleonCK/blob/main/Changelog.ru.md) | **Read this page in English**
# ChameleonCK

**ChameleonCK** (or simply **Chameleon**; abbreviated to **CCK**) is a tool for chroma keying in Super Mario 64, which includes a [Mario 64 Movie Maker 3](https://github.com/projectcomet64/M64MM) add-on meant to be used together with a special ROM or save state. It is also highly recommended to use [Tiny-Huge Tweaks](https://github.com/vazhka-dolya/TinyHugeTweaks) alongside this tool.

<p align="center">
  <img src="https://github.com/vazhka-dolya/ChameleonCK/blob/main/GitHubImg/CCK_showcase.gif"/>
</p>
<div align="center">
  <h6>The custom model shown can be found <a href="https://www.youtube.com/watch?v=6gp2YUWJJQ8">here</a></h6>
</div>

# Installing and using
1. Make sure you have the [latest version of M64MM3](https://github.com/projectcomet64/M64MM/releases/latest) installed.
2. Get the save state and/or the ROM version[^1] from [here](https://github.com/vazhka-dolya/ChameleonCK/tree/main/SM64) (ignore the `ROM Hack Source` folder if you're a normal user).
3. Download the [latest version of the add-on](https://github.com/vazhka-dolya/ChameleonCK/releases/latest). It will be in an archive.
4. Extract the downloaded archive's contents[^2] into the root folder[^3] of M64MM3. If it prompts you to replace files, then do it.
5. If you're using the ROM version:
   - Go to Bob-Omb Battlefield, which is replaced with the chroma key stage.
   
   If you're using the save state:
   - In Project64, go to **Options** > **Settings…** > **Options**, and make sure **Hide advanced settings** is disabled. After that, launch a normal Super Mario 64 ROM, then go to **System** > **Load…**, and select the save state. If it gives a warning about the ROM not matching the save state, then simply click “Yes.” ***You don't have to load the save state over the ROM version; you can use the save state with a normal Super Mario 64 ROM, too.***
6. That's all.

# Questions
### “If I use ChameleonCK for my work, do I have to credit you?”
Credit is highly appreciated, but completely optional!

### “Can it be used with custom player models?”
Yes! You can use [CometCHAR](https://github.com/projectcomet64/CometCHAR) to patch the ROM version with a `CMTP` file.

### “Why are the colors slightly different when enabling/disabling **Hide Stage**?”
When **Hide Stage** is disabled, what you are seeing is the stage itself, but when it's enabled, then the stage doesn't get rendered, and instead you are seeing the skybox. The stage's material uses an RGBA32 color, which has a higher bit depth; SM64's skybox uses RGBA16, which has a lower bit depth.

# Building prerequisites
<details>
  <summary>Click here to view</summary>
  
- Visual Studio 2022.
- M64MM3's repository in a folder called `M64MM` outside of where this repository is.
  - Example: if the `.sln` for BodyStates is in `C:/projects/ChameleonCK/ChameleonCK.sln`, the whole M64MM3 repository must be in `C:/projects/M64MM`.
- If you're on Windows, then, before extracting the archives, make sure to right-click the archive, open **Properties** and see if you have an **Unblock** checkbox. If you do, tick it and press **Apply**. If you don't do this and the archive(s) remain blocked, you may run into issues.
- *Depending on the circumstances*, you *may* have to do the following: go to **Menu** > **Tools** > **NuGet Package Manager** > **Package Manager Console** and enter `Install-Package HtmlRenderer.WinForms`. After that, go to **Menu** > **Project** > **Manage NuGet Packages…**, and make sure that both `HtmlRenderer.Core` and `HtmlRenderer.WinForms` are up-to-date.

</details>

# Credits
- GlitchyPSI ([his website](https://glitchypsi.xyz)) — help with this add-on.
- LiquoricePie ([Bluesky](https://bsky.app/profile/liquoricepie.bsky.social)) — icon for the add-on.

[^1]: For legal reasons, to get the ROM version, you need to have an original US ROM of Super Mario 64 that you then need to patch with the BPS file, which can be done using [this website](https://hack64.net/tools/patcher.php).
[^2]: That means *all* the contents, including the `deps` folder. If it crashes when opening the **About** window, make sure that you have `HtmlRenderer.dll` and `HtmlRenderer.WinForms.dll` in M64MM's `deps` folder.
[^3]: That's the same folder where `M64MM.exe` is located.
