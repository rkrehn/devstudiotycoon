; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{A238D7D9-B82D-4F7C-912E-F3609E459BB4}
AppName=Dev Studio Tycoon
AppVersion=0.8.3.0
;AppVerName=Dev Studio Tycoon 0.6.05
AppPublisher=Krehn Solutions
AppPublisherURL=http://www.krehnsolutions.com/
AppSupportURL=http://www.dstycoon.com/
AppUpdatesURL=http://www.dstycoon.com/
DefaultDirName={pf}\Dev Studio Tycoon
DefaultGroupName=Dev Studio Tycoon
LicenseFile=C:\Users\Ray\Dropbox\visual basic\GameDev\WindowsApplication1\bin\Release\license.txt
OutputDir=C:\Users\Ray\Dropbox\visual basic\GameDev\WindowsApplication1\bin\Release
OutputBaseFilename=Setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Ray\Dropbox\visual basic\GameDev\WindowsApplication1\bin\Release\Dev Studio Tycoon.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ray\Dropbox\visual basic\GameDev\WindowsApplication1\bin\Debug\Data\*"; DestDir: "{app}\Data"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\Ray\Dropbox\visual basic\GameDev\WindowsApplication1\bin\Debug\Errors\*"; DestDir: "{app}\Errors"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\Ray\Dropbox\visual basic\GameDev\WindowsApplication1\bin\Release\Dev Studio Tycoon.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Ray\Dropbox\visual basic\GameDev\WindowsApplication1\bin\Release\Read Me.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Dev Studio Tycoon"; Filename: "{app}\Dev Studio Tycoon.exe"
Name: "{group}\{cm:ProgramOnTheWeb,Dev Studio Tycoon}"; Filename: "http://www.dstycoon.com/"
Name: "{group}\{cm:UninstallProgram,Dev Studio Tycoon}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\Dev Studio Tycoon"; Filename: "{app}\Dev Studio Tycoon.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\Dev Studio Tycoon.exe"; Description: "{cm:LaunchProgram,Dev Studio Tycoon}"; Flags: nowait postinstall skipifsilent

