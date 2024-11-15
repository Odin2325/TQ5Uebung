# Use Case
## Bibliotheksverwaltungssystem für eine Universitätsbibliothek

* *Use Case Name:* Buch ausleihen
* *Akteure:* Benutzer mit Mitgliedsstatus
* *Ziel:* Benutzer reserviert Buch (Vormerken)
* *Vorbedingungen:*
    * Benutzer ist Mitglied
    * Benutzer ist eingeloggt
* *Nachbedingungen:*
    * Das vorgemerkte Buch ist im System vermerkt und kann von anderen für eine festgelegte Dauer nicht mehr ausgeliehen werden
* Hauptablauf:
    1. Der Benutzer navigiert zum Katalog
    1. Der Benutzer sucht ein Buch über die Suchemaske (Titel, Author, ISBN, etc.)
    1. Dem Benutzer werden Treffer zur Suche angezeigt
    1. Der Benutzer geht zur Detailansicht eines Treffers
    1. Der Benutzer wählt Vormerken aus 
    1. Der Benutzer erhält Bestätigung über erfolgreiches Vormerken
* Alternativabläufe:
    *A1:* Es sind keine ausleihbaren Exemplare vorhanden, dann kann Vormerken nicht durchgeführt werden
* Ausnahmen:
    *E1:* Der Benutzer hat unbeglichene Mahngebühren