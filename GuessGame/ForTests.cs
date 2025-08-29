using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class ForTests
    {
        public static class QuizSeeder
        {
            public static void Seed()
            {
                /*так как то быстрее*/
                QuizManager.AllQuizzes.Clear();
                var quiz1 = new Quiz("Основы C#", "Базовые вопросы по языку C#", "Программирование", new List<Question>
            {
                new Question("Какой тип данных хранит целое число?", new List<string>{"int", "string", "bool", "float"}, 0),
                new Question("Какое ключевое слово используется для объявления класса?", new List<string>{"class", "struct", "namespace", "using"}, 0),
                new Question("Какие из типов являются ссылочными?", new List<string>{"string", "int", "class", "struct"}, new List<int>{0,2}),
                new Question("Какое значение по умолчанию у bool?", new List<string>{"true", "false", "null", "0"}, 1),
                new Question("Что из этого — тип с плавающей точкой?", new List<string>{"decimal", "float", "double", "int"}, new List<int>{1,2}),
                new Question("Какое ключевое слово используется для наследования?", new List<string>{"base", "extends", ":", "inherits"}, 2),
                new Question("Какое из ключевых слов определяет метод, который не возвращает значение?", new List<string>{"void", "return", "null", "break"}, 0),
                new Question("Сколько байт занимает тип int в C#?", new List<string>{"2", "4", "8", "16"}, 1),
                new Question("Что возвращает метод Main по умолчанию?", new List<string>{"int", "void", "bool", "string"}, new List<int>{0,1}),
                new Question("Как обозначается строковый литерал?", new List<string>{"''", "\"\"", "##", "``"}, 1),
                new Question("Какое ключевое слово используется для создания объекта?", new List<string>{"create", "init", "new", "this"}, 2),
                new Question("Можно ли присвоить null переменной типа string?", new List<string>{"Да", "Нет", "Только в unsafe коде", "Только при использовании struct"}, 0),
                new Question("Какие из перечисленных являются ключевыми словами?", new List<string>{"static", "using", "class", "integer"}, new List<int>{0,1,2}),
                new Question("Какое из перечисленных — значение типа bool?", new List<string>{"yes", "true", "1", "false"}, new List<int>{1,3}),
                new Question("Какой тип данных используется для символа?", new List<string>{"string", "char", "text", "symbol"}, 1),
                new Question("Какое ключевое слово используется для пространства имён?", new List<string>{"namespace", "package", "space", "ns"}, 0),
                new Question("Какие модификаторы доступа существуют?", new List<string>{"public", "protected", "private", "internal"}, new List<int>{0,1,2,3}),
                new Question("Что такое константа?", new List<string>{"Поле, значение которого нельзя изменить", "Поле, доступное только внутри метода", "Класс без методов", "Объект, созданный через new"}, 0),
                new Question("Что из этого является циклом?", new List<string>{"if", "while", "for", "switch"}, new List<int>{1,2}),
                new Question("Можно ли в C# перегружать операторы?", new List<string>{"Да", "Нет", "Только в unsafe коде", "Только в static классе"}, 0),
            });
                QuizManager.AddQuiz(quiz1);
                var quiz2 = new Quiz("ООП в C#", "Вопросы по объектно-ориентированному программированию", "Программирование", new List<Question>
            {
                new Question("Основные принципы ООП?", new List<string>{"Инкапсуляция", "Полиморфизм", "Абстракция", "Сериализация"}, new List<int>{0,1,2}),
                new Question("Что такое конструктор?", new List<string>{"Метод для инициализации объекта", "Метод для удаления объекта", "Оператор присваивания", "Тип данных"}, 0),
                new Question("Может ли интерфейс содержать поля?", new List<string>{"Да", "Нет", "Только статические", "Только константы"}, 1),
                new Question("Каким словом запрещается наследование класса?", new List<string>{"abstract", "sealed", "override", "final"}, 1),
                new Question("Какое ключевое слово используется для реализации интерфейса?", new List<string>{"base", ":", "implements", "interface"}, 1),
                new Question("Что из этого полиморфизм?", new List<string>{"Переопределение методов", "Перегрузка методов", "Сокрытие методов", "Клонирование объектов"}, new List<int>{0,1}),
                new Question("Что делает ключевое слово override?", new List<string>{"Определяет новый метод", "Переопределяет метод базового класса", "Удаляет метод", "Запрещает наследование"}, 1),
                new Question("Можно ли наследоваться от нескольких классов?", new List<string>{"Да", "Нет", "Только в struct", "Только от sealed класса"}, 1),
                new Question("Что может содержать абстрактный класс?", new List<string>{"Абстрактные методы", "Реализованные методы", "Поля", "Константы"}, new List<int>{0,1,2,3}),
                new Question("Что означает ключевое слово virtual?", new List<string>{"Метод можно переопределить", "Метод является конструктором", "Метод доступен только в наследниках", "Метод private"}, 0),
                new Question("Какие из перечисленных типов могут быть абстрактными?", new List<string>{"class", "struct", "interface", "enum"}, 0),
                new Question("Какой модификатор запрещает переопределение метода?", new List<string>{"sealed", "const", "static", "readonly"}, 0),
                new Question("Можно ли создать объект интерфейса?", new List<string>{"Да", "Нет", "Только в generic-классах", "Только в static-классах"}, 1),
                new Question("Какое ключевое слово используется для доступа к родительскому классу?", new List<string>{"super", "base", "this", "parent"}, 1),
                new Question("Что может содержать интерфейс?", new List<string>{"Сигнатуры методов", "Поля", "Конструкторы", "Реализации методов"}, 0),
                new Question("Что означает инкапсуляция?", new List<string>{"Сокрытие деталей реализации", "Возможность наследования", "Создание объекта", "Разделение памяти"}, 0),
                new Question("Какое ключевое слово запрещает наследование от класса?", new List<string>{"sealed", "abstract", "virtual", "final"}, 0),
                new Question("Что такое абстракция?", new List<string>{"Выделение главных характеристик объекта", "Сокрытие данных", "Оптимизация памяти", "Использование struct"}, 0),
                new Question("Можно ли перегружать конструкторы?", new List<string>{"Да", "Нет", "Только в интерфейсах", "Только в sealed-классах"}, 0),
                new Question("Какие члены класса нельзя наследовать?", new List<string>{"private", "protected", "public", "internal"}, 0),
            });
                QuizManager.AddQuiz(quiz2);

                var quiz4 = new Quiz("WinForms", "Разработка интерфейсов на WinForms", "Программирование", new List<Question>
            {
                new Question("Что такое Form?", new List<string>{"Окно приложения", "Класс для БД", "Событие", "Контейнер для CSS"}, 0),
                new Question("Какой элемент используется для ввода текста?", new List<string>{"Label", "Button", "TextBox", "CheckBox"}, 2),
                new Question("Какие элементы являются контейнерами?", new List<string>{"Panel", "GroupBox", "FlowLayoutPanel", "Button"}, new List<int>{0,1,2}),
                new Question("Какое событие срабатывает при клике на кнопку?", new List<string>{"Click", "Load", "TextChanged", "Resize"}, 0),
                new Question("Как задать шрифт у Label?", new List<string>{"label.Text", "label.Font", "label.Style", "label.Size"}, 1),
                new Question("Что такое Dock?", new List<string>{"Прикрепление элемента к краю контейнера", "Выравнивание текста", "Тип Border", "Метод Resize"}, 0),
                new Question("Какие из элементов отображают список?", new List<string>{"ListBox", "ComboBox", "CheckedListBox", "ProgressBar"}, new List<int>{0,1,2}),
                new Question("Как отцентрировать форму?", new List<string>{"StartPosition", "Dock", "Anchor", "Align"}, 0),
                new Question("Какое свойство задаёт текст кнопки?", new List<string>{"button.Text", "button.Label", "button.Caption", "button.Value"}, 0),
                new Question("Какие события есть у TextBox?", new List<string>{"TextChanged", "KeyDown", "KeyPress", "Click"}, new List<int>{0,1,2,3}),
                new Question("Можно ли вложить TableLayoutPanel внутрь GroupBox?", new List<string>{"Да", "Нет", "Только через Dock", "Только через Anchor"}, 0),
                new Question("Что делает свойство Enabled?", new List<string>{"Отключает элемент", "Скрывает элемент", "Изменяет цвет", "Удаляет элемент"}, 0),
                new Question("Какие элементы относятся к меню?", new List<string>{"MenuStrip", "ContextMenuStrip", "ToolStripMenuItem", "Panel"}, new List<int>{0,1,2}),
                new Question("Как изменить заголовок формы?", new List<string>{"this.Name", "this.Text", "this.Caption", "this.Title"}, 1),
                new Question("Что такое Anchor?", new List<string>{"Закрепление элемента относительно границ контейнера", "Выравнивание текста", "Docking", "Позиционирование формы"}, 0),
                new Question("Какие элементы являются кнопками?", new List<string>{"Button", "RadioButton", "CheckBox", "PictureBox"}, new List<int>{0,1,2}),
                new Question("Что делает свойство Visible?", new List<string>{"Показывает/скрывает элемент", "Удаляет элемент", "Блокирует элемент", "Изменяет цвет"}, 0),
                new Question("Что из этого контейнеры?", new List<string>{"TabControl", "Panel", "FlowLayoutPanel", "Timer"}, new List<int>{0,1,2}),
                new Question("Какое событие срабатывает при загрузке формы?", new List<string>{"Load", "Shown", "Initialize", "Start"}, 0),
                new Question("Можно ли менять размеры формы во время выполнения?", new List<string>{"Да", "Нет", "Только через Dock", "Только через Anchor"}, 0),
            });
                QuizManager.AddQuiz(quiz4);

                // 1. C# Basics
                var csharpQuiz = new Quiz("C# Basics", "Основы языка программирования C#", "Программирование", new List<Question>());
                csharpQuiz.AddQuestion(new Question("Ключевое слово для объявления класса?", new List<string> { "class", "struct", "new", "namespace" }, 0));
                csharpQuiz.AddQuestion(new Question("Какое значение по умолчанию у int?", new List<string> { "0", "null", "1", "Не определено" }, 0));
                csharpQuiz.AddQuestion(new Question("Какая сборка содержит базовые классы C#?", new List<string> { "System.dll", "Core.dll", "Base.dll", "Object.dll" }, 0));
                csharpQuiz.AddQuestion(new Question("Что означает ключевое слово 'static'?", new List<string> { "Метод принадлежит классу", "Метод создаёт объект", "Метод виртуальный", "Метод защищён" }, 0));
                csharpQuiz.AddQuestion(new Question("Какое ключевое слово используется для наследования?", new List<string> { "inherits", "extends", ":", "base" }, 2));
                csharpQuiz.AddQuestion(new Question("Как обозначается пространство имён?", new List<string> { "package", "namespace", "using", "import" }, 1));
                csharpQuiz.AddQuestion(new Question("Какое ключевое слово используется для создания объекта?", new List<string> { "create", "new", "make", "init" }, 1));
                csharpQuiz.AddQuestion(new Question("Что такое 'int?'", new List<string> { "Обычный int", "Nullable int", "Массив int", "Константа int" }, 1));
                csharpQuiz.AddQuestion(new Question("Какое ключевое слово для обработки исключений?", new List<string> { "catch", "try", "throw", "finally" }, new List<int> { 0, 1, 2, 3 }));
                csharpQuiz.AddQuestion(new Question("Какой тип данных для текста?", new List<string> { "string", "char", "text", "varchar" }, 0));
                csharpQuiz.AddQuestion(new Question("Какой модификатор доступа по умолчанию у класса?", new List<string> { "public", "private", "internal", "protected" }, 2));
                csharpQuiz.AddQuestion(new Question("Какое ключевое слово для интерфейса?", new List<string> { "interface", "contract", "abstract", "IType" }, 0));
                csharpQuiz.AddQuestion(new Question("Можно ли перегрузить оператор в C#?", new List<string> { "Да", "Нет", "Только арифметический", "Только логический" }, 0));
                csharpQuiz.AddQuestion(new Question("Что возвращает метод без return?", new List<string> { "void", "null", "0", "Exception" }, 0));
                csharpQuiz.AddQuestion(new Question("Что означает async?", new List<string> { "Асинхронный метод", "Параллельный метод", "Абстрактный метод", "Приватный метод" }, 0));
                csharpQuiz.AddQuestion(new Question("Что такое LINQ?", new List<string> { "СУБД", "Язык запросов к коллекциям", "Фреймворк", "Библиотека графики" }, 1));
                csharpQuiz.AddQuestion(new Question("Что такое delegate?", new List<string> { "Тип для хранения методов", "Тип данных int", "Ссылка на объект", "Модуль" }, 0));
                csharpQuiz.AddQuestion(new Question("Можно ли наследовать от нескольких классов?", new List<string> { "Да", "Нет", "Только через интерфейсы", "Да, но с ключевым словом multi" }, 2));
                csharpQuiz.AddQuestion(new Question("Какое ключевое слово для константы?", new List<string> { "const", "final", "static", "define" }, 0));
                csharpQuiz.AddQuestion(new Question("Что такое garbage collector?", new List<string> { "Механизм очистки памяти", "Сборщик данных", "Очередь", "Интерфейс" }, 0));
                QuizManager.AddQuiz(csharpQuiz);

                // 2. История
                var historyQuiz = new Quiz("История", "Основные события мировой истории", "История", new List<Question>());
                historyQuiz.AddQuestion(new Question("Когда началась Вторая мировая война?", new List<string> { "1914", "1939", "1945", "1941" }, 1));
                historyQuiz.AddQuestion(new Question("Кто был первым президентом США?", new List<string> { "Джордж Вашингтон", "Авраам Линкольн", "Франклин Рузвельт", "Томас Джефферсон" }, 0));
                historyQuiz.AddQuestion(new Question("В каком году распался СССР?", new List<string> { "1989", "1991", "1993", "1990" }, 1));
                historyQuiz.AddQuestion(new Question("Год Крещения Руси?", new List<string> { "988", "862", "1240", "1147" }, 0));
                historyQuiz.AddQuestion(new Question("Кто открыл Америку?", new List<string> { "Магеллан", "Колумб", "Кук", "Васко да Гама" }, 1));
                historyQuiz.AddQuestion(new Question("Когда произошла Французская революция?", new List<string> { "1789", "1812", "1848", "1917" }, 0));
                historyQuiz.AddQuestion(new Question("Кто написал 'Илиаду'?", new List<string> { "Гомер", "Платон", "Аристотель", "Софокл" }, 0));
                historyQuiz.AddQuestion(new Question("Год открытия Америки?", new List<string> { "1492", "1500", "1453", "1521" }, 0));
                historyQuiz.AddQuestion(new Question("В каком году началась Первая мировая война?", new List<string> { "1914", "1939", "1905", "1920" }, 0));
                historyQuiz.AddQuestion(new Question("Кто был первым императором Рима?", new List<string> { "Юлий Цезарь", "Август", "Нерон", "Клавдий" }, 1));
                historyQuiz.AddQuestion(new Question("Кто написал 'Война и мир'?", new List<string> { "Толстой", "Пушкин", "Достоевский", "Чехов" }, 0));
                historyQuiz.AddQuestion(new Question("Когда упала Западная Римская империя?", new List<string> { "476", "410", "800", "622" }, 0));
                historyQuiz.AddQuestion(new Question("В каком году человек впервые полетел в космос?", new List<string> { "1961", "1969", "1957", "1971" }, 0));
                historyQuiz.AddQuestion(new Question("Какое событие произошло в 1812 году в России?", new List<string> { "Отечественная война", "Революция", "Крещение Руси", "Распад СССР" }, 0));
                historyQuiz.AddQuestion(new Question("Кто был первым канцлером Германии?", new List<string> { "Бисмарк", "Гитлер", "Коль", "Шредер" }, 0));
                historyQuiz.AddQuestion(new Question("Когда был подписан Магна Карта?", new List<string> { "1215", "1492", "1066", "1648" }, 0));
                historyQuiz.AddQuestion(new Question("Кто был первым царём всея Руси?", new List<string> { "Иван III", "Иван IV Грозный", "Пётр I", "Алексей Михайлович" }, 1));
                historyQuiz.AddQuestion(new Question("В каком году Наполеон пошёл в поход на Россию?", new List<string> { "1812", "1805", "1799", "1825" }, 0));
                historyQuiz.AddQuestion(new Question("Кто написал 'Божественную комедию'?", new List<string> { "Данте", "Шекспир", "Мольер", "Гете" }, 0));
                historyQuiz.AddQuestion(new Question("Когда была основана Киевская Русь?", new List<string> { "862", "988", "1240", "1147" }, 0));
                QuizManager.AddQuiz(historyQuiz);

                // 3. География
                var geographyQuiz = new Quiz("География", "Страны и столицы", "География", new List<Question>());
                geographyQuiz.AddQuestion(new Question("Столица Франции?", new List<string> { "Париж", "Берлин", "Мадрид", "Рим" }, 0));
                geographyQuiz.AddQuestion(new Question("Самая длинная река мира?", new List<string> { "Нил", "Амазонка", "Янцзы", "Волга" }, 1));
                geographyQuiz.AddQuestion(new Question("Высочайшая гора в мире?", new List<string> { "Эверест", "Килиманджаро", "Эльбрус", "Монблан" }, 0));
                geographyQuiz.AddQuestion(new Question("Самая большая страна по площади?", new List<string> { "Канада", "Россия", "США", "Китай" }, 1));
                geographyQuiz.AddQuestion(new Question("Столица Австралии?", new List<string> { "Сидней", "Канберра", "Мельбурн", "Брисбен" }, 1));
                geographyQuiz.AddQuestion(new Question("Сколько океанов на Земле?", new List<string> { "3", "4", "5", "6" }, 2));
                geographyQuiz.AddQuestion(new Question("Столица Японии?", new List<string> { "Токио", "Осака", "Киото", "Хиросима" }, 0));
                geographyQuiz.AddQuestion(new Question("Самая большая пустыня мира?", new List<string> { "Сахара", "Гоби", "Антарктическая", "Калахари" }, 2));
                geographyQuiz.AddQuestion(new Question("Столица Бразилии?", new List<string> { "Рио-де-Жанейро", "Сан-Паулу", "Бразилиа", "Сальвадор" }, 2));
                geographyQuiz.AddQuestion(new Question("Какая страна называется 'страна восходящего солнца'?", new List<string> { "Китай", "Япония", "Корея", "Таиланд" }, 1));
                geographyQuiz.AddQuestion(new Question("Самое глубокое озеро?", new List<string> { "Байкал", "Танганьика", "Виктория", "Каспийское" }, 0));
                geographyQuiz.AddQuestion(new Question("Столица Канады?", new List<string> { "Оттава", "Торонто", "Монреаль", "Ванкувер" }, 0));
                geographyQuiz.AddQuestion(new Question("Столица Италии?", new List<string> { "Милан", "Рим", "Неаполь", "Флоренция" }, 1));
                geographyQuiz.AddQuestion(new Question("Какая страна самая густонаселённая?", new List<string> { "Индия", "Китай", "США", "Индонезия" }, 1));
                geographyQuiz.AddQuestion(new Question("Столица Египта?", new List<string> { "Каир", "Александрия", "Луксор", "Гиза" }, 0));
                geographyQuiz.AddQuestion(new Question("Какое море самое солёное?", new List<string> { "Красное", "Средиземное", "Мёртвое", "Чёрное" }, 2));
                geographyQuiz.AddQuestion(new Question("Столица Турции?", new List<string> { "Стамбул", "Анкара", "Измир", "Бурса" }, 1));
                geographyQuiz.AddQuestion(new Question("Столица Германии?", new List<string> { "Берлин", "Мюнхен", "Гамбург", "Франкфурт" }, 0));
                geographyQuiz.AddQuestion(new Question("Самая высокая вершина Европы?", new List<string> { "Монблан", "Эльбрус", "Маттерхорн", "Гросглокнер" }, 1));
                geographyQuiz.AddQuestion(new Question("Столица Украины?", new List<string> { "Львов", "Киев", "Харьков", "Одесса" }, 1));
                QuizManager.AddQuiz(geographyQuiz);

                // 4. Биология
                var biologyQuiz = new Quiz("Биология", "Живые организмы", "Биология", new List<Question>());
                biologyQuiz.AddQuestion(new Question("Какой газ нужен человеку для дыхания?", new List<string> { "Кислород", "Углекислый газ", "Азот", "Водород" }, 0));
                biologyQuiz.AddQuestion(new Question("Из чего состоят клетки?", new List<string> { "Цитоплазма, ядро, мембрана", "Белки и жиры", "Кости и мышцы", "Только мембрана" }, 0));
                biologyQuiz.AddQuestion(new Question("Какой орган отвечает за кровообращение?", new List<string> { "Лёгкие", "Печень", "Сердце", "Почки" }, 2));
                biologyQuiz.AddQuestion(new Question("Сколько хромосом у человека?", new List<string> { "23", "46", "44", "48" }, 1));
                biologyQuiz.AddQuestion(new Question("Какой витамин вырабатывается на солнце?", new List<string> { "A", "B", "C", "D" }, 3));
                biologyQuiz.AddQuestion(new Question("К какой группе относятся грибы?", new List<string> { "Растения", "Животные", "Отдельное царство", "Бактерии" }, 2));
                biologyQuiz.AddQuestion(new Question("Самая крупная клетка в организме человека?", new List<string> { "Яйцеклетка", "Нейрон", "Эритроцит", "Лейкоцит" }, 0));
                biologyQuiz.AddQuestion(new Question("Где находится ДНК?", new List<string> { "В цитоплазме", "В ядре", "В мембране", "В рибосоме" }, 1));
                biologyQuiz.AddQuestion(new Question("Кто автор теории эволюции?", new List<string> { "Дарвин", "Ньютон", "Мендель", "Пастер" }, 0));
                biologyQuiz.AddQuestion(new Question("Какое животное млекопитающее?", new List<string> { "Крокодил", "Дельфин", "Черепаха", "Акула" }, 1));
                biologyQuiz.AddQuestion(new Question("Что является единицей наследственности?", new List<string> { "Ген", "Клетка", "Хромосома", "Белок" }, 0));
                biologyQuiz.AddQuestion(new Question("Какой орган у человека фильтрует кровь?", new List<string> { "Печень", "Сердце", "Почки", "Желудок" }, 2));
                biologyQuiz.AddQuestion(new Question("Сколько костей у взрослого человека?", new List<string> { "206", "210", "200", "180" }, 0));
                biologyQuiz.AddQuestion(new Question("Какое животное самое большое?", new List<string> { "Слон", "Синий кит", "Акула", "Динозавр" }, 1));
                biologyQuiz.AddQuestion(new Question("Что изучает ботаника?", new List<string> { "Животных", "Растения", "Бактерий", "Грибы" }, 1));
                biologyQuiz.AddQuestion(new Question("Какие клетки переносят кислород?", new List<string> { "Лейкоциты", "Эритроциты", "Тромбоциты", "Нейроны" }, 1));
                biologyQuiz.AddQuestion(new Question("Какое животное откладывает яйца?", new List<string> { "Курица", "Собака", "Кошка", "Лошадь" }, 0));
                biologyQuiz.AddQuestion(new Question("Какой орган у растений выделяет кислород?", new List<string> { "Корни", "Листья", "Стебель", "Цветы" }, 1));
                biologyQuiz.AddQuestion(new Question("Какая наука изучает насекомых?", new List<string> { "Зоология", "Энтомология", "Микология", "Орнитология" }, 1));
                biologyQuiz.AddQuestion(new Question("Какое животное питается эвкалиптом?", new List<string> { "Коала", "Панда", "Слон", "Жираф" }, 0));
                QuizManager.AddQuiz(biologyQuiz);

                // 5. Математика
                var mathQuiz = new Quiz("Математика", "Основные математические задачи", "Математика", new List<Question>());
                mathQuiz.AddQuestion(new Question("Сколько будет 7 * 8?", new List<string> { "54", "56", "58", "64" }, 1));
                mathQuiz.AddQuestion(new Question("Чему равна сумма углов треугольника?", new List<string> { "90°", "180°", "270°", "360°" }, 1));
                mathQuiz.AddQuestion(new Question("Корень из 81?", new List<string> { "9", "8", "7", "6" }, 0));
                mathQuiz.AddQuestion(new Question("Сколько будет 15 / 3?", new List<string> { "3", "4", "5", "6" }, 2));
                mathQuiz.AddQuestion(new Question("Площадь квадрата со стороной 4?", new List<string> { "8", "12", "16", "20" }, 2));
                mathQuiz.AddQuestion(new Question("Что больше: π или 3.14?", new List<string> { "π", "3.14", "Они равны", "Неизвестно" }, 0));
                mathQuiz.AddQuestion(new Question("2 в 5 степени?", new List<string> { "16", "32", "64", "128" }, 1));
                mathQuiz.AddQuestion(new Question("Сколько будет 100 - 37?", new List<string> { "63", "64", "65", "66" }, 0));
                mathQuiz.AddQuestion(new Question("Какое число делится на все?", new List<string> { "0", "1", "2", "10" }, 1));
                mathQuiz.AddQuestion(new Question("Формула площади круга?", new List<string> { "πr", "πr²", "2πr", "r²" }, 1));
                mathQuiz.AddQuestion(new Question("Чему равно 5!", new List<string> { "25", "60", "120", "720" }, 2));
                mathQuiz.AddQuestion(new Question("Среднее арифметическое чисел 2 и 8?", new List<string> { "4", "5", "6", "7" }, 1));
                mathQuiz.AddQuestion(new Question("Квадратный корень из 144?", new List<string> { "10", "11", "12", "13" }, 2));
                mathQuiz.AddQuestion(new Question("Какая фигура имеет 4 равные стороны?", new List<string> { "Прямоугольник", "Ромб", "Квадрат", "Трапеция" }, 2));
                mathQuiz.AddQuestion(new Question("Сколько градусов в окружности?", new List<string> { "90", "180", "270", "360" }, 3));
                mathQuiz.AddQuestion(new Question("Если a=2, b=3, чему равно a+b?", new List<string> { "4", "5", "6", "7" }, 2));
                mathQuiz.AddQuestion(new Question("Чему равно 10²?", new List<string> { "10", "20", "100", "1000" }, 2));
                mathQuiz.AddQuestion(new Question("Сколько граней у куба?", new List<string> { "4", "6", "8", "12" }, 1));
                mathQuiz.AddQuestion(new Question("Чему равно 2/4?", new List<string> { "0.25", "0.5", "0.75", "1" }, 1));
                mathQuiz.AddQuestion(new Question("Сколько будет 2³?", new List<string> { "4", "6", "8", "10" }, 2));
                QuizManager.AddQuiz(mathQuiz);
            }
        }
            }
}
