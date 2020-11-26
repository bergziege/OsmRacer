# OsmRacer
Mein erstes Unity Projekt. Eine Kleine Anwendung für den Smart Trainer um auf einem mit Höhendaten angereicherten OSM Streckennetz fahren zu können.

## Was bisher funktioniert

* Abrufen von Höhendaten aus dem LiDAR Geländemodell mittels gdallocationinfo.
    * Setzt vorraus, das "gdallocationinfo" über die Kommandozeile erreichbar ist.

## Nächste Ziele

* entschlacken einer OSM Datei
    * Alles außer Straßen und deren Nodes entfernen (z.B. Gebäude, Gewässer, Wanderwege, ...).
    * Basis für die erste Version wird Sachsen. Da kann ich gute die Realität mit der Theorie vergleichen und es gibt 20m LiDAR Daten.
    * Als Tools fürs Filtern soll "osmfilter" zum Einsatz kommen. Die entsprechenden Parameter werden hier veröffentlicht.
* anreichern aller Nodes in der OSM Datei um das "ele" Tag mit Höhenwert aus dem Geländemodell
    * Dies wird druch ein kleines Kommandozeilentool geschehen

Bis hier soll es auf jeden Fall noch ein OSM Format bleiben, um die Datei mit gängigen OSM Editoren öffnen zu können

* Wahrscheinlich überführen der OSM Daten in eine lokale DB. 
    * Schwerpunkt hier: in-file DB. Als Nutzer der fertigen Anwendung möchte ich mir nicht erst eine DB Software auf dem Rechner installieren müsssen.
    * Alternativ ein eigenes, binäres Format. Bei diesem Punkt bin ich mir absolut noch unklar was es werden wird.
* Daten aus der DB abrufen und in Unity darstellen.
    * Schwerpunkt hierbei: nur die Daten in einem bestimmten Umkreis abrufen (wenn das denn geht ;-)
    * Zusätzliche Stützpunkte in die Straßen einfügen um Höhenänderungen bei z.B. langen, graden Strecken anzeigen zu können.

* Auslesen Smart Trainer über Ant+ FE-C und Darstellung auf Strecke
* Grundlegende Navigation beim Fahren
* Ansteuern des Trainers mit Steigungsdaten
    * evtl. schon Grundlegende Glättung/Interpolation der Daten

* In-game Editor für Höhendaten
