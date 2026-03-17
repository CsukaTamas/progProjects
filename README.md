# progProjects

MySQL adatbáziskezelés C#-ban:
Manage NuGet Packages for Solution -> MySqlConnector -> Install<br>
Minta: fajlbolAdatbazisba.cs, adatb.cs

C# fájlbeolvasás 
```
string[] adatok = File.ReadAllLines("fajlnev.txt", Encoding.UTF8);
```

number1 és number2-ben levő szövegek átírása num1-be és num2-be int formába, ha nem szám van, hibaüzenet megjelenítése:

 ```
if (!int.TryParse(number1.Text, out num1) || !int.TryParse(number2.Text, out num2))
{
    MessageBox.Show("Kérem adjon meg két érvényes számot!", "Hiba", MessageBoxButtons.OK);
    return;
}
 ```

\ jelentései:
```
 \" – double quote
 \\ – single backslash
 \a – bell/alert
 \b – backspace
 \r – carriage return
 \n – newline
 \s – space
 \t – tab
 ```

 ```
Form2 form = new 
Form2(); form.Show();
 ```
