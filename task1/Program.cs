// В текстовом файле, содержащем текст программы на языке Си, проверить соответствие открывающихся и закрывающихся фигурных скобок { и }.
// Результат проверки вывести на экран и записать в виде фразы в текстовый файл. 
// Результат работы программы (вывод) поместить в отдельный текстовый файл (например, "out . txt " ), продублировав на экране.

string text = "if (a > b) { result = a ";
File.WriteAllText(@"C:\\Users\РомаЛиля\Desktop\C#Tasks\test.txt", text);
Console.ReadKey();

string IsCorrect(string Text) {
    string[] s = new string[]{Text};
    string result = "";

    int FirstCount = 0;
    int SecondCount = 0;
        for (int i = 0; i < Text.Length; i++)
        {
            if (s[0][i] == '}')
            {
                FirstCount++;
            } 
            else if (s[0][i] == '{')
            {
                SecondCount++;
            }
        }

        if (FirstCount == SecondCount) {
            return result = "Баланс скобок не нарушен!";
        } 
        else {
            return result = "Баланс скобок нарушен!";
        }
}

string Result = IsCorrect(text);
File.WriteAllText(@"C:\\Users\РомаЛиля\Desktop\C#Tasks\out.txt", Result);
Console.WriteLine(Result);