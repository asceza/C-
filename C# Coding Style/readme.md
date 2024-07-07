Ниже приведен принятый мной стиль кодирования и именования на C#.
Используйте его в своих собственных проектах и/или адаптируйте к своим потребностям.

## Имена классов
Использовать **PascalCasing** для имен классов и имен методов.
> Почему: в соответствии с Microsoft .NET и легкостью чтения.
```c#
public class ClientActivity
{
    public void ClearStatistics()
    {
        //...
    }
    public void CalculateStatistics()
    {
        //...
    }
}
```
---
## Имена переменных
Использовать **camelCasing** для локальных переменных и аргументов метода.
> Почему: в соответствии с Microsoft .NET и легкостью чтения.
```c#
public class UserLog
{
    public void Add(LogEvent logEvent)
    {
        int itemCount = logEvent.Items.Count;
        // ...
    }
}
```
---
## Идентификаторы
НЕиспользовать Венгерскую нотацию (когда для указания функционального назначения объекта, представленного идентификатором используется добавление префикса к имени идентификатора) или любая другая идентификацию типа в идентификаторах.
> Почему: в соответствии с Microsoft .NET. И кроме того, Visual Studio IDE позволяет очень легко определить тип переменной (через подсказки).
```c#
// Правильно
int counter;
string name;
 
// Лучше избегать
int iCounter;
string strName;
```
---
## Константы
**НЕ**использовать CapsLock для констант или переменных только для чтения.
> Почему: в соответствии с Microsoft .NET. CapsLock забирает слишком много внимания.
```c#
// Правильно
public static const string ShippingType = "DropShip";
 
// Лучше избегать
public static const string SHIPPINGTYPE = "DropShip";
```
---
## Сокращения
Избегать использования сокращений.

Исключения: сокращения, обычно используемые в качестве имен, такие как ID, URL, XML.
> Почему: в соответствии с Microsoft .NET.
```c#
// Правильно
UserGroup userGroup;
Assignment employeeAssignment;
 
// Лучше избегать
UserGroup usrGrp;
Assignment empAssignment;
 
// Исключения
CustomerId customerId;
XmlDocument xmlDocument;
FtpHelper ftpHelper;
UriPart uriPart;
```
---
## Аббревиатуры
Использовать **PascalCasing** для сокращений
> Почему: в соответствии с Microsoft .NET. CapsLock забирает слишком много внимания.
```c#
HtmlHelper htmlHelper;
FtpTransfer ftpTransfer;
UIControl uiControl;
```
---
## Без подчеркивания
**НЕ**использовать подчеркивание в идентификаторах.

Исключение: можно использавать как префикс приватных статических переменных.
> Почему: в соответствии с Microsoft .NET. Это делает код более естественным для чтения
```c#
// Correct
public DateTime clientAppointment;
public TimeSpan timeLeft;
 
// Avoid
public DateTime client_Appointment;
public TimeSpan time_Left;
 
// Exception
private DateTime _registrationDate;
```





