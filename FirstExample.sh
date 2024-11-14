#!/bin/bash

# Funktion zur Ausgabe in verschiedenen Farben
print_color_text() {
  local color=$1
  local text=$2
  echo -e "\033[1m\033[$color${text}\033[0m"
}

# Funktion für die Animation der "Vorgang wird gestartet..."-Zeile
animate_start_message() {
  local interval=0.5
  local counter=0
  local max_counter=22

  while ((counter < max_counter)); do
    clear
    print_color_text "32m" "Vorgang wird gestartet"
    for ((i = 0; i <= counter; i++)); do
      echo -n "."
    done
    sleep $interval
    ((counter++))
  done

  print_color_text "32m" "Vorgang wird gestartet..."
}

# Aufruf der Animation für die "Vorgang wird gestartet..."-Zeile
animate_start_message

# zeige Vorgang: 0%
print_color_text "32m" "Vorgang: 0%"

# Fortschrittsvariablen
progress=0
target=100
interval=2

# Schleife für den Fortschritt
for ((i = 1; i <= target; i++)); do
  progress=$i
  percent=$((i * 100 / target))

  # Löschen des Bildschirms und Ausgabe des Fortschritts
  clear
  if ((percent >= 66)); then
    print_color_text "32m" "Vorgang läuft..."
    print_color_text "32m" "Vorgang: $percent%"
  elif ((percent >= 33)); then
    print_color_text "33m" "Vorgang läuft..."
    print_color_text "33m" "Vorgang: $percent%"
  else
    print_color_text "31m" "Vorgang läuft..."
    print_color_text "31m" "Vorgang: $percent%"
  fi

  sleep $interval
done

# Abschlussnachrichten
print_color_text "32m" "Hack-Vorgang erfolgreich abgeschlossen."
print_color_text "31m" "Danke für deine Daten."
sleep 10

# Fortschritt für den nächsten Durchlauf zurücksetzen
progress=0
percent=0
