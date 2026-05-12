# 🎮 2048 — Классическая головоломка на чистой логике

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)]()
[![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)]()
[![WinForms](https://img.shields.io/badge/WinForms-5C2D91?style=for-the-badge&logo=.net&logoColor=white)]()
[![JSON](https://img.shields.io/badge/json-5E5C5C?style=for-the-badge&logo=json&logoColor=white)]()
[![Newtonsoft.Json](https://img.shields.io/badge/Newtonsoft.Json-000000?style=for-the-badge&logo=json&logoColor=white)]()

> Реализация игры 2048 на Windows Forms. Без анимаций и таймеров — всё построено на прямом управлении Label-элементами, тройных вложенных циклах и линейном поиске. Поддерживается выбор размера поля от 4×4 до 8×8.

---

## ✨ Особенности

- 🎯 Полная механика игры 2048: движение, слияние плиток, подсчёт очков
- 🧩 Игровое поле собрано из WinForms-элементов `Label`
- 📐 **Настраиваемый размер поля** — можно играть на сетке от 4×4 до 8×8
- 💾 Сохранение результатов всех игроков в `result.json` с поиском лучшего счёта по имени
- 🏁 Игра продолжается и по достижении 2048, поражение засчитывается если нет доступных ходов
- 📋 Используется **Newtonsoft.Json** для сериализации и собственный `FileManager` для работы с файлами

---

## 🧱 Как устроена логика

Игровое поле — это не просто двумерный массив чисел, а **сетка из Label-элементов**. Её размер задаётся переменной `mapSize` и может быть от 4 до 8. Все алгоритмы (движение, слияние, спавн) написаны через циклы, привязанные к `mapSize`, поэтому работают корректно при любом размере поля.

При нажатии на стрелки происходит следующее:

1. **Движение плитки с помощью тройного цикла**.
2. **Сравнение текста** — у двух Label-элементов считывается свойство `Text`. Если значения равны — происходит слияние с удвоением.
3. **Визуальное обновление** — победившая плитка перекрашивается, проигравшая очищается и становится серой.
4. **Генерация новой плитки** — после каждого хода в случайную свободную клетку добавляется 2 (с шансом 75%) или 4 (с шансом 25%).

### Движение вправо (реальный код)

```csharp
private void PressRight()
{
    for (var i = 0; i < mapSize; i++)
    {
        for (var j = mapSize - 1; j >= 0; j--)
        {
            if (labelsMap[i, j].Text != string.Empty)
            {
                for (var k = j - 1; k >= 0; k--)
                {
                    if (labelsMap[i, k].Text != string.Empty)
                    {
                        if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                        {
                            var number = int.Parse(labelsMap[i, j].Text);
                            score += number * 2;

                            labelsMap[i, j].Text = (number * 2).ToString();
                            SetColor(labelsMap[i, j]);

                            labelsMap[i, k].Text = string.Empty;
                            labelsMap[i, k].BackColor = Color.Silver;
                        }
                        break;
                    }
                }
            }
        }
    }
    GenerateNumber();
    ShowScore();
}
```

Поиск пустой клетки для спавна

```csharp
private List<(int, int)> LinearSearch()
{
    var emptyLabels = new List<(int Row, int Column)>();

    for (var i = 0; i < mapSize; i++)
    {
        for (var j = 0; j < mapSize; j++)
        {
            if (labelsMap[i, j].Text == string.Empty)
            {
                emptyLabels.Add((i, j));
            }
        }
    }

    return emptyLabels;
}
```

---

💾


Сохранение результатов

Все результаты хранятся в файле result.json. После каждого завершения игры запись добавляется в общую таблицу рекордов.

```csharp
// Получение лучшего результата игрока по имени
public static int GetBestResult(string name)
{
    var usersResult = GetAll();
    var results = new List<string[]>();

    // Фильтруем — собираем все партии этого игрока
    foreach (var result in usersResult)
    {
        if (result[0] == name)
        {
            results.Add(result);
        }
    }

    // Ищем максимальный счёт линейным перебором
    var bestResult = 0;
    foreach (var result in results)
    {
        if (int.Parse(result[1]) > bestResult)
        {
            bestResult = int.Parse(result[1]);
        }
    }

    return bestResult;
}
```

```csharp
// Сохранение всего списка результатов в JSON
public static void Save(List<string[]> results)
{
    var data = JsonConvert.SerializeObject(results, Formatting.Indented);
    FileManager.Save(Path, data);
}
```

---

🎮 Как играть

1. При запуске выберите размер поля (от 4×4 до 8×8).
2. Управляйте плитками стрелками на клавиатуре (← ↑ → ↓ или клавишами wasd).
3. Одинаковые плитки при столкновении сливаются, удваивая номинал.
4. Цель — добраться до плитки с числом 2048 или выше.
5. Игра заканчивается в случае выхода или поражением (не осталось ходов).

---

🖼️ Как это выглядит

<img width="800" height="448" alt="image" src="https://github.com/user-attachments/assets/3ef6402e-c1f0-43fd-a112-dd628eb66531" />

<img width="328" height="298" alt="image" src="https://github.com/user-attachments/assets/ea94ecda-4c85-4b3e-abd4-37a8d18b6476" />

<img width="528" height="336" alt="image" src="https://github.com/user-attachments/assets/86a58fc0-4cd9-4dae-b881-c69c86c29ce2" />

<img width="591" height="585" alt="image" src="https://github.com/user-attachments/assets/deb99e47-2f6e-4da2-9dcc-08af40577470" />

<img width="599" height="598" alt="image" src="https://github.com/user-attachments/assets/e7575967-7815-47d0-b8d4-6296b016d32a" />


---

🛠️ Чему я научился

· Управление WinForms-элементами из кода — игровое поле собрано из Label-компонентов, которыми программа управляет напрямую: читает Text, меняет BackColor, очищает содержимое.
· Динамический интерфейс — размер сетки меняется в зависимости от выбора пользователя (от 4×4 до 8×8), элементы создаются и размещаются программно.
· Тройные вложенные циклы — алгоритм сдвига и слияния плиток реализован через обход поля с тремя индексами (i, j, k) для поиска соседних элементов в нужном направлении.
· Линейный поиск — поиск пустых клеток для спавна и максимального счёта игрока выполняется полным перебором.
· Принципы ООП.
· Работа со строками и числами — все значения на плитках хранятся как string в Label, преобразуются через int.Parse для вычислений и обратно через ToString() для отображения.

```
