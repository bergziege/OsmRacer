# OsmRacer
Mein erstes Unity Projekt. Eine Kleine Anwendung für den Smart Trainer um auf einem mit Höhendaten angereicherten OSM Streckennetz fahren zu können.

## Was bisher funktioniert

* Abrufen von Höhendaten aus dem LiDAR Geländemodell mittels gdallocationinfo.
    * Setzt vorraus, das "gdallocationinfo" über die Kommandozeile erreichbar ist.

## Nächste Ziele

* entschlacken einer OSM Datei
    * Alles außer Straßen und deren Nodes entfernen (z.B. Gebäude, Gewässer, Wanderwege, ...).
* anreichern aller Nodes in der OSM Datei um das "ele" Tag mit Höhenwert aus dem Geländemodell

Bis hier soll es auf jeden Fall noch ein OSM Format bleiben, um die Datei mit gängigen OSM Editoren öffnen zu können

* Wahrscheinlich überführen der OSM Daten in eine lokale DB
* Daten aus der DB abrufen und in Unity darstellen.
    * Schwerpunkt hierbei: nur die Daten in einem bestimmten Umkreis abrufen (wenn das denn geht ;-)
