# OsmRacer
Mein erstes Unity Projekt. Eine Kleine Anwendung für den Smart Trainer um auf einem mit Höhendaten angereicherten OSM Streckennetz fahren zu können.

## Was bisher funktioniert

* Abrufen von Höhendaten aus dem LiDAR Geländemodell mittels gdallocationinfo.
    * Setzt vorraus, das "gdallocationinfo" über die Kommandozeile erreichbar ist.
* entschlacken einer OSM Datei
    * Alles außer Straßen und deren Nodes entfernen (z.B. Gebäude, Gewässer, Wanderwege, ...).
    * Basis für die erste Version wird Sachsen. Da kann ich gute die Realität mit der Theorie vergleichen und es gibt 20m LiDAR Daten.
    * Als Tools fürs Filtern soll "osmfilter" zum Einsatz kommen. Die entsprechenden Parameter werden hier veröffentlicht.
    
Leider sind die OSM Daten nicht unbedingt einheitlich, so das es mit den aktuellen osmfilter Parametern zu fehlenden Straßen/Wegen kommen kann. Dies sind vor Allem Radwege wie z.B. Teile des Elberadwegs, die manchmal als "Cyclepath" und manchmal als "Path" mit einzelner Rad/Fußgänger Zuweisung versehen sind. Aber auch Straßen wie z.B. die Wiener Str. in Dresden wird in großen Teilen als "unclassified" und nicht wie auf einem anderen Stück als "tertiary" betitelt.
Für einen ersten Versuch soll es jedoch reichen. Ein neues Streckennetz einzulesen muss sowieso ein Kernfeature der Anwendung werden um die Datenbasis gut pflegen zu können.

## Nächste Ziele

* Aufbereiten der OSM Daten und überführen in eine SQLite/spatialite DB
    * Alle "Way" Elemente durchlaufen und zusätzlich zu den OSM "Node"s mindestens alle 20m einen weiteren Stützpunkt hinzufügen
    * Alle Nodes mit einer Höhe versehen
    * Wege und Knotenpunkte in der DB ablegen
        * Um die Daten später besser verarbeiten zu können, werden die "Wege" in einzelne Segmente zwischen jeweils 2 Stützpunkte zerlegt.

* Bis hierher sind alles noch vorbereitende Schritte. Nachfolgendes findet dann im "Spiel" statt.

* Daten aus der DB abrufen und in Unity darstellen.
    * Alle Knoten in einem bestimmten Umkreis abrufen
    * Alle Segmente, die die Knoten als Start- oder Endpunkt haben abrufen und die Knoten somit verbinden

* Auslesen Smart Trainer über Ant+ FE-C und Darstellung auf Strecke
* Grundlegende Navigation beim Fahren
* Ansteuern des Trainers mit Steigungsdaten
    * evtl. schon Grundlegende Glättung der ausgesteuerten Steigungsdaten
        * Die an den Trainer gesendeten Steigungsdaten müssen somit nicht mehr 100% mit der visuellen Repräsentation des Weges übereinstimmen, was bei 20m Segmenten aber vertretbar sein sollte.

* In-game Editor für Höhendaten
    * Werden als Korrekturwerte zu Node IDs abgelegt bzw. als Offset zwischen 2 Node IDs, wenn es sich um Korrekturwerte für errechnete Stützpukte handelt
        * NodeID: 356m <- Korrekturwert für einen OSM Node
        * NodeID->NodeID + 2: 340m <- Korrekturwert für den 2. Stützpunkt zwischen 2 OSM Nodes
     * Korrekturwerte bleiben gültig, bis z.B. der Abstand der errechneten, zusätzlichen Stützpunkte geändert wird.
     * Korrekturwerte werden in einer separaten DB vorgehalten um diese nicht zu löschen, wenn das eigentliche Wegenetz aktualisiert wird.
