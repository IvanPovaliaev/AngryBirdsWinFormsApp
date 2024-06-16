# 🐦AngryBirdsWinForms
Копия известной игры «AngryBirds», созданной в процессе изучения технологии Windows Forms, принципов ООП, работы со звуком, асинхронностью и многопоточностью.
<div " align="center">
  
![image](https://github.com/IvanPovaliaev/AngryBirdsWinFormsApp/assets/157638990/e511ddb2-6b9a-4110-991e-2186df3744a8)

</div>

## 📝Описание работы

### 📜Привила игры
1. При зажатой ЛКМ задаётся траектория броска птицы.
2. При попадании в свинку начисляется 1 очко. После попадания свинка появляется в произвольном месте
3. При промохе по свинке птица возвращается на исходную позицию

### ⚙️Настройки
В меню настроек имеется возможность регулировки звуков и выбора языка приложения.<br />
Доступно 3 языка:
1. Русский
2. Английский
3. Немецкий

Настройки языка сохраняются после выхода приложения.

### 🕹️Геймплей
Пример работы приложения приведён ниже:
<div " align="center">

https://github.com/IvanPovaliaev/AngryBirdsWinFormsApp/assets/157638990/c42960ff-2b1a-4383-b934-81367d975304

</div>

## 🛠️Техническая часть

Проект выполнен с соблюдением принципов **ООП** и использованием **LINQ**.

Решение содержит 2 проекта:
1. Проект общей библиотеки `BallGame.Common`.
2. Проект `AngryBirdsWinForms`.

### 🏗️Архитектура
Структура каталога решения:<br />
![image](https://github.com/IvanPovaliaev/AngryBirdsWinFormsApp/assets/157638990/392468bb-d0be-4ac5-a287-18d2519ae1c2)

Проект `BallGame.Common` является общей библиотекой классов для следующих проектов:
* [BallGamesWindowsFormApp](https://github.com/IvanPovaliaev/BallGamesWindowsFormApp)
* [FruitNinjaWinFormsApp](https://github.com/IvanPovaliaev/FruitNinjaWinFormsApp)
* [AngryBirdsWinFormsApp](https://github.com/IvanPovaliaev/AngryBirdsWinFormsApp)

### 💬Работа с ресурсными файлами и мультиязычность
Для реализации мультиязычности были использована ресурсные файлы:

![image](https://github.com/IvanPovaliaev/AngryBirdsWinFormsApp/assets/157638990/663d508b-90ef-47e0-a6ba-63d5c3a4b903)

![image](https://github.com/IvanPovaliaev/AngryBirdsWinFormsApp/assets/157638990/46247450-86a3-4704-8038-2482949c9031)

![image](https://github.com/IvanPovaliaev/AngryBirdsWinFormsApp/assets/157638990/395c6dd8-61d5-497f-9240-3597a7bc8bb2)

![image](https://github.com/IvanPovaliaev/AngryBirdsWinFormsApp/assets/157638990/5caac214-ecc2-481e-a03b-b846e9f6d2b7)

Задание элементам интерфейса текстовых значений использовался менеджер ресурсов с получением необходимой строки по ключу.<br />
Например, для элементов `GameForm` использовался метод `InitializeComponentsText()`:
```csharp
private void InitializeComponentsText()
{
    var localizationResManager = SystemSettings.LocalizationResourceManager;
    scoreLabel.Text = $"{localizationResManager.GetString("Score")}: {score}";
    settingsButton.Text = localizationResManager.GetString("SettingsButton");
}
```

Получение менеджера русурсов для текущего языка осуществляется с помощь статического класса `SystemSettings`:
```csharp
public static class SystemSettings
{
    public static int SoundsVolume = 30;
    public static ResourceManager LocalizationResourceManager { get; private set; }
    public static GameLanguageCodes LanguageCode { get; private set; } = (GameLanguageCodes)Properties.Settings.Default.LastUsedLanguage;

    public static void SetLanguages(GameLanguageCodes languageCodes)
    {
        LanguageCode = languageCodes;
        switch (languageCodes)
        {
            case GameLanguageCodes.Ru:
                LocalizationResourceManager = new ResourceManager($"AngryBirdsWinForms.Languages.Russian", Assembly.GetExecutingAssembly());
                break;
            case GameLanguageCodes.En:
                LocalizationResourceManager = new ResourceManager($"AngryBirdsWinForms.Languages.English", Assembly.GetExecutingAssembly());
                break;
            case GameLanguageCodes.De:
                LocalizationResourceManager = new ResourceManager($"AngryBirdsWinForms.Languages.German", Assembly.GetExecutingAssembly());
                break;
            default:
                LocalizationResourceManager = new ResourceManager($"AngryBirdsWinForms.Languages.Russian", Assembly.GetExecutingAssembly());
                break;
        }
    }
}
```

Для выбора языка создано перечисление `GameLanguageCodes`:
```csharp
public enum GameLanguageCodes
{
    Ru,
    En,
    De
}
```




