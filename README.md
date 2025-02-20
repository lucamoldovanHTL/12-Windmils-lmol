
# 🎯 Lernziele: Windmühlen-Projekt in Unity

## 🏗 **Grundlagen von GameObjects und Hierarchie**
- [ ] **Whiteboxing mit Primitives**: Erstellen einer einfachen Windmühle aus grundlegenden Formen (Cubes, Cylinders).
- [ ] **Pivot-Punkt setzen**: Das Windrad als **Kind-Objekt** eines leeren GameObjects anlegen, um die Drehung korrekt zu steuern.

## 🔄 **Transformation & Bewegung in Unity**
- [ ] **Rotation mit `transform.Rotate`**: Wie sich ein Objekt um eine Achse dreht.
- [ ] **Verstehen von `Time.deltaTime`**: Warum es für flüssige Bewegungen genutzt wird.

## 🎮 **Benutzerinteraktion & Steuerung**
- [ ] **Tasteneingabe (`Input.GetKey`)**: 
  - [ ] Space-Taste gedrückt halten = Beschleunigung.
  - [ ] Space-Taste loslassen = Verlangsamung.
- [ ] **Mehrere Windmühlen unabhängig steuerbar machen**: Nur das aktuell ausgewählte Windrad soll auf `Space` reagieren.

## 🖥 **UI-Elemente & Visualisierung von Variablen**
- [ ] **Einbindung eines `Slider`-Elements**: Anzeige der aktuellen Geschwindigkeit (0–255).
- [ ] **Werteskalierung (`Mathf.Lerp`)**: Geschwindigkeit in eine Lichtintensität umwandeln.

## 🏗 **Mehrere Objekte verwalten & Interaktion zwischen Objekten**
- [ ] **Mehrere Windmühlen in einer Szene**: Jede hat eigene Steuerung, aber dasselbe Skript.
- [ ] **Unterschiedliche Zustände pro Windmühle**: Eine ist aktiv steuerbar, andere nicht.
