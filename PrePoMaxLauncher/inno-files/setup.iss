[Setup]
AppName=GI Launcher Suite
AppVersion=1.0
DefaultDirName={pf}\GI_Suite
OutputBaseFilename=GI_Launcher_Installer

[Files]
Source: "Launcher\bin\Release\net8.0\win-x64\publish\*"; DestDir: "{app}\Launcher"; Flags: recursesubdirs

Source: "PrePoMax\*"; DestDir: "{app}\PrePoMax"; Flags: recursesubdirs
Source: "CalculiX\*"; DestDir: "{app}\CalculiX"; Flags: recursesubdirs

[Icons]
Name: "{commondesktop}\FEA Launcher"; Filename: "{app}\Launcher\GI-Launcher.exe"
