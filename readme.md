# Dokumentation zum Erstellen eines automatischen Testverfahrens
(Aufgabe 4 VP 2017 A2.6 Zusatz)

Diese Dokumentation soll das erstellen von Unit-Tests mithilfe von MS-Test für das .NET Framework in Visual Studio erläutern.

> **Checkout oder Download des [Ausgangsprojektes](https://github.com/derech1e/SV-UnitTests/archive/refs/heads/master.zip).**
## Übersicht

1. [Erstellen des Testprojekts](#create)
2. [Aufbau einer Testklasse](#structure)
3. [Assert Methode](#operators)
4. [Test starten](#testing)


## <a name="create"></a>Erstellen des Testprojekts

Rechtsklick auf die Klasse `Fach` und auf den Kontextmenüeintrag `Komponententests erstellen` klicken.

> Um die Methode `bastelnFID` testen zu können, muss diese den Zugriffstyp `public` besitzen.

![0_ContextMenu.png](assets/img/0_ContextMenu.png)


Als Nächstes öffnet sich ein Dialog zum Erstellen eines Testprojekts. In diesem kann man verschiedene Testframeworks und Namensgebungen festlegen.

> Alle Einstellungen können so belassen werden.

![1_CreateDialog.png](assets/img/1_CreateDialog.png)

Im Projektexplorer wurde nun ein neues Projekt innerhalb der Projektmappe erstellt. Dieses Projekt ist ausschließlich zum Testen von Klassen und Komponenten zu verwenden.

![2_NewProjectView.png](assets/img/2_NewProjectView.png)

## <a name="structure"></a>Aufbau einer Testklasse

> Eine Testklasse muss mit dem Attribut `[TestClass()]` annotiert werden. Dadurch wird diese Klasse als eine Testklasse anerkannt.

![3_NewClassView.png](assets/img/3_NewClassView.png)

> Eine Testmethode muss mit dem Attribut `[TestMethod()]` annotiert werden. Dadurch wird diese Methode als eine Testmethode anerkannt.

![4_Method_Struct.png](assets/img/4_Method_Struct.png)

Jede Testmethode wird einmal während des Tests aufgerufen und ausgeführt. Innerhalb der Methode wird die eigentliche Testung der Komponente durchgeführt. Testmethoden akzeptieren **nur** den Datentyp `void`.

## <a name="operators"></a>Assert Methode

Mithilfe der Assert Methode wird die Testlogik realisiert. `Assert` überprüft eine Bedingung auf ihre Korrektheit. Wenn die Bedingung `false` ist, wird eine `Exception `geworfen und der Test der Methode schlägt fehl.

> Es ist sehr hilfreich, die Intellisense und die Beschreibung der jeweiligen Methoden zu lesen und benutzen.

![7_Intellisense.png](assets/img/7_Intellisense.png)

#### Testfall #1

```csharp
Assert.AreEqual(ExpectedFach_MathBs.bastelnFID(), "MathBS");
```

> Dieser Test überprüft, ob der Testwert `ExpectedFach_MathBs.bastelnFID()` gleich dem gegeben `string` `MathBS` (Erwartungswert) ist.

#### Testfall #2

```csharp
Assert.AreEqual(ExpectedFach_MathBs.speichern(), "INSERT INTO Fach (FID,Bezeichnung) VALUES ('MathBS', 'Mathematik;Berufsschule');");
```

> Dieser Test überprüft, ob der Testwert `ExpectedFach_MathBs.speichern()` gleich dem gegeben SQL-Statement (Erwartungswert) `INSERT INTO Fach (FID,Bezeichnung) VALUES ('MathBS', 'Mathematik;Berufsschule');` ist.

Wenn die beide Werte gleich sind, ist der Test erfolgreich.

#### Fertige Testklasse

![6_Test_Final.png](assets/img/6_Test_Final.png)

## <a name="testing"></a>Test starten

Über die Menüleiste können nun alle Tests gestartet werden. Es öffnet sich ein Fenster mit einer Testübersicht.

![5_Start_TEST.png](assets/img/5_Start_TEST.png)
![8_Testwindow.png](assets/img/8_Testwindow.png)

# Die fertige Projektmappe ist unter dem Branch [Loesung](https://github.com/derech1e/SV-UnitTests/tree/loesung) zu finden.

Weitere Beispiele sind in der Repository [LernsituationOOP](https://github.com/derech1e/LernsituationOOP) im Testprojekt zu finden. 

Erstellt von Thomas Nürk © 2022
