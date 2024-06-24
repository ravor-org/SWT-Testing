# SWT-Testing

## Versionkontrollaufgabe

![image](https://github.com/ravor-org/SWT-Testing/assets/10080228/4e44eff9-6acc-42ca-8c4a-c5875af3f77d)

![image](https://github.com/ravor-org/SWT-Testing/assets/10080228/5a30607e-c246-4a99-b2ce-360aefa21af0)

Den Rest sollte man hoffentlich in der Historie sehen!

## Testingaufgabe

### Testen Sie Ihr eigenes Projekt / Ihren eigenen Code mit JUnit (so wie wir das mit dem Taschenrechner gemacht haben)
Tests erfolgten per NUnit und Moq in diesem Repo.
![image](https://github.com/ravor-org/SWT-Testing/assets/10080228/35edfeb1-4f3f-44b3-9f60-b06100ad2c8b)


### Testen Sie dabei ebenfalls auf eine Exception!
```csharp
[Test]
public void RemainingTest2By0()
{
    Assert.That(() => _testCalculator.RemainingDiv(4, 0), Throws.TypeOf<DivideByZeroException>());
}
```

### Entwickeln oder finalisieren Sie im TDD-Modus die Testklassen mit Testfunktionen für Zeichen to € . Falls Ihnen ein besseres / anderes Beispiel einfällt, um erst eine Klasse mit Methoden zu testen und dann dies zu implementieren, verwenden Sie dieses!
Siehe Commit [e95d2636df95df4ae658c74605f6f3dea045aa63](https://github.com/ravor-org/SWT-Testing/commit/e95d2636df95df4ae658c74605f6f3dea045aa63) und [34b3773c39b7781a59f6ad0a45b393c0931b6b75](https://github.com/ravor-org/SWT-Testing/commit/34b3773c39b7781a59f6ad0a45b393c0931b6b75)
Ersterer gab den Test for und zweiteres war dann die Implementierung für den Test

### Schreiben Sie einen eigenen Anwendungsfall, bei dem Sie eine unangenehme Methode „herausmocken“! Wie in der Präsenz (Code).
Siehe Commit [504abe617fc57326cef5c9a430d5954bd6826754](https://github.com/ravor-org/SWT-Testing/commit/504abe617fc57326cef5c9a430d5954bd6826754)
Moq und NUnit unterstützen leider kein "Mocking" von nicht-virtuellen / nicht-abstrakten Klassen. Über ein Interface, welches aus der Klasse generiert wurde, kann das Problem aber umgangen werden. Interfaces sind virtuelle Implementierungen und damit durch Moq unterstützt.

### Lassen sie Test Coverage auf ihren Code los.

![image](https://github.com/ravor-org/SWT-Testing/assets/10080228/83a36ffe-5598-47ba-b748-15bf8176d5ba)

Hier habe ich extra mit Commit [2661d77b0fbc9a852298b28222510c4c2477b53e](https://github.com/ravor-org/SWT-Testing/commit/2661d77b0fbc9a852298b28222510c4c2477b53e) eine Methode und den dazugehörigen Test so geschrieben, dass der Test einen "krummen" Wert herausgibt und die Coverage nicht auf 100% steht. Das war Absicht. :)
