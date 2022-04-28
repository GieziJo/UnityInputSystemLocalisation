# Input System Localisation for Unity
## Description

Localised keys for Unity's new [Input System](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/api/UnityEngine.InputSystem.html).
When calling [`InputControlPath.ToHumanReadableString`](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/api/UnityEngine.InputSystem.InputControlPath.html#UnityEngine_InputSystem_InputControlPath_ToHumanReadableString_System_String_UnityEngine_InputSystem_InputControlPath_HumanReadableStringOptions_UnityEngine_InputSystem_InputControl_), the returned string will always be in english (e.g. the 'Space' key), but we would like an accurate translation for any language.

This is an attempt at providing a framework to translate these keys to any language.

The source file with the input strings and translation is located in [`Resources/InputKeysDictionary.csv`](Resources/InputKeysDictionary.csv).

## Usage
Assuming `InputControlPath.ToHumanReadableString` returns the first entry in the examples.
Example usage:
```csharp
Debug.Log(Giezi.Tools.InputSystemLocalisation.GetTranslation("Space", "Fr"));
Debug.Log(Giezi.Tools.InputSystemLocalisation.GetTranslation("Space", "De"));
Debug.Log(Giezi.Tools.InputSystemLocalisation.GetTranslation("Any Key", "Fr"));
Debug.Log(Giezi.Tools.InputSystemLocalisation.GetTranslation("Any Key", "De"));
Debug.Log(Giezi.Tools.InputSystemLocalisation.GetTranslation("Numpad *", "Fr"));
Debug.Log(Giezi.Tools.InputSystemLocalisation.GetTranslation("Numpad *", "De"));
```
Which outputs:
```bash
Espace
Leehrtaste
N'importe quelle touche
Irgend eine Taste
Pavé Numérique *
Nummernblock *
```

The class returns the input string if the value is not found.

## Installation
Add the line
```json
"ch.giezi.tools.inputsystemlocalisation": "https://github.com/GieziJo/UnityInputSystemLocalisation.git#main"
```
to the file `Packages/manifest.json` under `dependencies`, or in the `Package Manager` add the link 
```html
https://github.com/GieziJo/UnityInputSystemLocalisation.git#main
```
under `+ -> "Add package from git URL...`.

## Contribute
Feel free to modify the code or add entries to the dictionary, either additional languages or keys I've missed.
Then open a pull request and they will be merged.
