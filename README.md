# Switch / Case — Console Menu

A text menu that reads a number from the console and branches on it with `switch`.

```
SwitchMenu/
├── SwitchMenu.sln
├── SwitchMenu.csproj
├── Program.cs
└── .gitignore
```

## What it demonstrates

| Concept | Where |
|---|---|
| `switch` with `case` labels and `break` | `Program.cs` |
| A `default` branch for unexpected input | `Program.cs` |
| `Convert.ToInt32` on console input | `Program.cs` |

```csharp
switch (choice)
{
    case 1:  Console.WriteLine("Your favorite pet is Dog.");   break;
    case 2:  Console.WriteLine("Your favorite pet is Cat.");   break;
    ...
    case 6:  Console.WriteLine("Your favorite pet is not in the choices."); break;
    default: Console.WriteLine("You don't have a favorite pet.");       break;
}
```

## Running it

```bash
dotnet run
```

```
What's your favorite pet?
[1] Dog
[2] Cat
[3] Rabbit
[4] Turtle
[5] Fish
[6] Not in the choices
Enter your choice: Your favorite pet is Cat.
```

Anything outside `1`–`6` falls through to `default`.

## Notes

Originally named `sssss` — renamed to `SwitchMenu`, along with the project, assembly
and root namespace.

**One bug was fixed.** The menu has always advertised `[1] Dog`, but the code read
`case 22:` instead of `case 1:`, so entering `1` fell through to `default` and printed
*"You don't have a favorite pet."* Changed to `case 1:`.

---

<div dir="rtl">

## دستور switch و case — منوی کنسولی

یک منوی متنی که یک عدد از کاربر می‌گیرد و با `switch` روی آن تصمیم می‌گیرد.

**مفاهیمی که نشان می‌دهد:**

- **دستور `switch` با حالت‌های `case` و `break`**
- **شاخه `default`** برای ورودی‌های پیش‌بینی‌نشده
- تبدیل ورودی کنسول به عدد با `Convert.ToInt32`

هر عددی بین ۱ تا ۶ حالت خودش را دارد و هر چیز دیگری به `default` می‌رود.

**اجرا:**

```bash
dotnet run
```

**نکته:** یک باگ برطرف شد. منو همیشه گزینه `[1] Dog` را نشان می‌داد ولی در کد
`case 22:` نوشته شده بود، برای همین اگر کاربر `1` می‌زد به `default` می‌رفت. به
`case 1:` تغییر کرد.

</div>
