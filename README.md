# RunCustomizer
Create custom Run commands for Windows 7 or higher OS.

# Screenshot
![Main Page](https://raw.githubusercontent.com/arshit09/RunCustomizer/master/cover.jpg)

## Setup in Visual Studio Code
1) Import RunCustomizer.cs to your WindowsFormApp.
2) Change the following in "app.manifest" to get administrative privilege,
change from ```  <requestedExecutionLevel level="asInvoker" uiAccess="false" /> ``` to
 ``` <requestedExecutionLevel level="requireAdministrator" uiAccess="false" /> ```
