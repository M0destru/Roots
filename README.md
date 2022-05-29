# MyRoots

Приложение для извлечения квадратного корня

## Содержание

[Руководство пользователя](#руководство-пользователя)
[Добавление нового языка](#добавление-нового-языка)

## Руководство пользователя

### Вычисление корня

#### Введите число в поле "Ввод числа"

Вид числа:
* Целое
* Вещественное ( разделитель - точка)
* Комплексное в формате "a + bi" или "a + b * i"   

#### Задайте точность в поле "Разрядов после запятой"

В результате будет показано выбранное число знаков после запятой.

Наибольшая допустимая точность - 15.

#### Выберите формат вывода в группе "Вывод корня"

Арифметический - будет выдано число с целой частью и с заданным числом разрядов после запятой

Аналитический - будет выдано символьное представление с целой частью и корневым остатком

#### Нажмите на кнопку "Извлечь"

Результат появится в поле "Результат"

### Смена языка

* Перейдите в меню "Настройки"
* Укажите путь до языкового файла
* Нажмите на кнопку "Загрузить"
* Выберите язык
* Нажмите на кнопку "Ок"

## Добавление нового языка 

Языковой файл имеет разрешение .json и структуру
```
{
    "Название языка 1": [...], 
    "Название языка 2": [...]
}
```

Язык задаётся массивом вида 

```

[
    "Настройки",
    "Справка",
    "Ввод числа",
    "Разрядность после запятой",
    "Вывод корня",
    "Введите число",
    "Извлечь",
    "Очистить",
    "Арифметический",
    "Аналитический",
    "Результат",
    "Язык",
    "Языковой файл",
    "Путь до файла",
    "Загрузить языковой файл",
    "Принять",
    "О программе: Программа для вычисления корней v1.0.0\n\nВозможности программы:\n",
    "   - Поддерживаются целые, вещественные (разделитель - точка), комплексные (в виде a + bi или a + b * i) и длинные числа\n",
    "   - Корень может быть получен в арифметическом и аналитическом (только для целых чисел) видах\n",
    "   - Можно выбрать, с какой точностью вычислить корень\n",
    "   - Программа доступна на двух языках: русский и английский\n",
    "   - Программа поддерживает подключение новых языков\n\n",
    "Инструкция:\n",
    "   *Вы можете изменить язык интерфейса во вкладке \"Настройки\"\n",
    "   1. Введите значение в поле \"Ввод числа\"\n",
    "   2. Выберите, с какой точностью Вы хотите вычислить корень, в поле \"Точность\"\n",
    "   3. Выберите вид, в котором будет выведен корень\n",
    "   4. Нажмите кнопку \"Извлечь\"\n",
    "   5. Найденный корень будет выведен в поле \"Результат\"",
    "Ошибка",
    "Не удается получить доступ к файлу",
    "Введено не число, либо такой формат числа не поддерживается",
    "Аналитический корень вещественного числа не поддерживается",
    "Аналитический корень комплексного числа не поддерживается"
  ]
```

Для добавление нового языка нужно перевести каждый элемент массива с сохранением порядка и добавить массив в языковой файл


# MyRoots

Application for square root extraction

## Content

[User Manual](#user manual)
[Adding a new language](#adding-a-new-language)

## User Manual

### Root calculation

#### Enter a number in the "Enter a number" field

Type of number:
* Whole
* Real (dot separator)
* Complex in the "a +" format bi" or "a + b * i"

#### Set the precision in the "Decimal places" field

As a result, the selected number of decimal places will be shown.

The maximum allowable accuracy is 15.

#### Select the output format in the "Root Output" group

Arithmetic - a number with an integer part and a specified number of digits after the decimal point will be output

Analytical - a symbolic representation with an integer part and a root remainder will be given

#### Click on the "Extract" button

The result will appear in the "Result" field

### Language change

* Go to the Settings menu
* Specify the path to the language file
* Click on the "Download"
button * Select the language
* Click on the "OK" button

## Adding a new language

The language file has permission .json and structure
```
{
"Name of language 1": [...],
"Name of language 2`: [...]
}
```

The language is set by an array of the form

```

[
	"Settings",
	"Help",
	"Entering a number",
	"Decimal Digit",
	"Root Output",
	"Enter a Number",
	"Extract",
	"Clear",
	"Arithmetic",
	"Analytical",
	"Result",
	"Language",
	"Language file",
	"File path",
	"Upload language file",
	"Accept",
	"About the program: A program for calculating the roots v1.0.0\n\nThe possibilities of the program:\n",
	" - Integers, real (dot separator), complex (in the form of a + are supported bi or a + b * i) and long numbers \n",
	" - The root can be obtained in arithmetic and analytical (only for integers) forms \n",
	" - You can choose with what accuracy to calculate the root \n",
	" - The program is available in two languages: Russian and English\n",
	" - The program supports the connection of new languages\n\n",
	"Instructions:\n",
	" *You can change the interface language in the \"Settings\"\n" tab,
	" 1. Enter a value in the \"Enter a number\"\n" field,
	" 2. Select the accuracy with which you want to calculate the root, in the field \"Accuracy\"\n",
	" 3. Select the type in which the root\n" will be output,
	" 4. Click \"Extract\"\n",
	" 5. The found root will be output in the field \"Result\"",
	"Error",
	"Unable to access the file",
	"Not a number has been entered, or this number format is not supported",
	"The analytical root of a real number is not supported",
	"The analytical root of a complex number is not supported"
]
```

To add a new language, you need to translate each element of the array while maintaining the order and add the array to the language file

