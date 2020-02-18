# RunCustomizer
Create custom Run commands for Windows 7 or higher OS. <br />
Download [RunCustomizer.rar](https://github.com/arshit09/Ezzz/issues/new "RunCustomizer.rar") and run "RunCustomizer.exe" - That's it!

# Screenshot
![Main Page](https://raw.githubusercontent.com/arshit09/RunCustomizer/master/cover.jpg)

## Setup in Visual Studio Code
1) Import RunCustomizer.cs to your WindowsFormApp.
2) Change the following in "app.manifest" to get administrative privilege,<br />
change <br />
```  <requestedExecutionLevel level="asInvoker" uiAccess="false" /> ``` <br />
to<br />
 ``` <requestedExecutionLevel level="requireAdministrator" uiAccess="false" /> ```
