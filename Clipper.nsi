; # [ zrfisaac ]

; # [ about ]
; # - author : Isaac Santana
; # . - email : zrfisaac@gmail.com
; # . - site : zrfisaac.github.io

; # [ nsis ]

; # - Library
!include "LogicLib.nsh"
!include "MUI2.nsh"
!include "x64.nsh"

; # - Variable
!define APP_GUID "{F19EF532-E6D4-4085-8E9A-57120A4B0EF1}"

; # - Main
Name "Clipper 0.0.0.2"
OutFile "Clipper 0.0.0.2.exe"
Unicode True
InstallDir "$PROGRAMFILES\Clipper"
InstallDirRegKey HKLM "SOFTWARE\Clipper" ""
RequestExecutionLevel Admin

; # - Picture
!define MUI_ICON "Clipper.ico" 
!define MUI_UNICON "Clipper.ico" 
!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_RIGHT
;!define MUI_HEADERIMAGE_BITMAP "Pictures\InstallerHeader.bmp"
;!define MUI_WELCOMEFINISHPAGE_BITMAP "Pictures\InstallerBanner.bmp"
;!define MUI_HEADERIMAGE_UNBITMAP  "Pictures\UninstallerHeader.bmp"
;!define MUI_UNWELCOMEFINISHPAGE_BITMAP "Pictures\UninstallerBanner.bmp"

; # - Shortcut
!define MUI_FINISHPAGE_RUN
!define MUI_FINISHPAGE_RUN_TEXT "$(MUI_Shortcut)"
!define MUI_FINISHPAGE_RUN_FUNCTION "fnShortcut"
Function "fnShortcut"
	CreateShortCut "$DESKTOP\Clipper.lnk" "$INSTDIR\Clipper.exe"
FunctionEnd

; # - Interface
!define MUI_ABORTWARNING

; # - Page - Installer
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

; # - Page - Uninstaller
!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_UNPAGE_FINISH

; # - Language
!insertmacro MUI_LANGUAGE "PortugueseBR"
Function .onInit
  !insertmacro MUI_LANGDLL_DISPLAY
FunctionEnd

; # - Version
VIProductVersion "0.0.0.2"
VIAddVersionKey "ProductName" "Clipper"
VIAddVersionKey "Comments" ""
VIAddVersionKey "CompanyName" "Isaac Santana / zrfisaac@gmail.com"
VIAddVersionKey "LegalTrademarks" "Isaac Santana / zrfisaac@gmail.com"
VIAddVersionKey "LegalCopyright" "Isaac Santana / zrfisaac@gmail.com"
VIAddVersionKey "FileDescription" "Clipper"
VIAddVersionKey "FileVersion" "0.0.0.2"
VIAddVersionKey "ProductVersion" "0.0.0.2"

; # - Translation
LangString MUI_Shortcut ${LANG_PORTUGUESEBR} "Criar atalho na área de trabalho"

; # - Installer - Clipper
Section Clipper
	; # : - Required
	SectionIn RO

	; # : - Files
	SetOutPath "$INSTDIR"
	File "Clipper.ico"
	File "bin\Release\Clipper.exe"

	; # : - Uninstaller
	WriteUninstaller "$INSTDIR\Uninstall.exe"

	; # : - Shortcuts
	CreateDirectory "$SMPROGRAMS\"
	CreateShortCut "$SMPROGRAMS\Clipper.lnk" "$INSTDIR\Clipper.exe" "" "$INSTDIR\Clipper.ico"

	; # : - Control Panel
	WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "DisplayName" "Clipper 0.0.0.2"
	WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "UninstallString" "$\"$INSTDIR\Uninstall.exe$\""
	WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "QuietUninstallString" "$\"$INSTDIR\Uninstall.exe$\" /S"
	WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "InstallLocation" "$\"$INSTDIR$\""
	WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "DisplayIcon" "$\"$INSTDIR\Clipper.ico$\""
	WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "Publisher" "Isaac Santana / zrfisaac@gmail.com"
	WriteRegStr HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "DisplayVersion" "0.0.0.2"
	WriteRegDWORD HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "VersionMajor" 0
	WriteRegDWORD HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "VersionMinor" 0
	WriteRegDWORD HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "NoModify" 0
	WriteRegDWORD HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "NoRepair" 2
	WriteRegDWORD HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}" "EstimatedSize" 488 ;KB
SectionEnd

; # - Uninstaller - Clipper
Section Un.Clipper
	; # : - Required
	SectionIn RO

	; # : - Files
	Delete "$INSTDIR\*.*"
	RMDir /r "$INSTDIR"

	; # : - Shortcuts
	Delete "$INSTDIR\Clipper.lnk"
	RMDir /r "$SMPROGRAMS\Clipper"

	; # : - Registry
	DeleteRegKey HKLM "SOFTWARE\Clipper"
	DeleteRegKey HKLM "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\${APP_GUID}"
SectionEnd
