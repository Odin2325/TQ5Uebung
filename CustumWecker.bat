@echo off
setlocal enabledelayedexpansion

:LOOP
cls
color 2
echo Code wird um 07:00 Uhr fortgesetzt.
for /f "tokens=1,2 delims=:" %%a in ('time /t') do (
  set "hour=%%a"
  set "minute=%%b"
)
set /a "currentHour=hour"
set /a "currentMinute=minute"

set /a "targetHour=7"
set /a "targetMinute=00"

if %currentHour% gtr %targetHour% (
  set /a "remainingHours=24 - currentHour + targetHour"
) else (
  set /a "remainingHours=targetHour - currentHour"
)

if %currentMinute% gtr %targetMinute% (
  set /a "remainingMinutes=60 - currentMinute + targetMinute"
  set /a "remainingHours=remainingHours - 1"
) else (
  set /a "remainingMinutes=targetMinute - currentMinute"
)

echo Aktuelle Uhrzeit: !currentHour!h:!currentMinute!m
echo Verbleibende Zeit bis zum Start: !remainingHours!h:!remainingMinutes!m

if %currentHour%==%targetHour% (
  if %currentMinute% geq %targetMinute% (
    nircmd.exe setsysvolume 65535
    nircmd.exe mutesysvolume 0
	cd C:\Users\akein
	taskkill /f /im WWAHost.exe
	taskkill /f /im opera.exe
    cd C:\Users\akein\Music\Music\Frei.Wild\
    
    start "" "Frei.Wild - It's a good day for a good day (Offizielles Video) (128kbit_AAC).m4a"
    timeout /t 360 /nobreak  >nul
    start "" "Frei.Wild-UnsereLieblingsliederGesamtesAlbum_1632171960767.mp3"
    
    exit
  )
)

ping -n 61 127.0.0.1 >nul
goto LOOP
