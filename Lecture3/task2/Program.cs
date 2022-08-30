// решение задач

// Задача1. Дан текст. В тексте нужно заменить все пробелы черточками, маленькие буквы "к" заменить большими, большие "С" заменить маленькими
string text = "Тут маленькие станут большими: ккккк. "
						+ "А тут большие станут маленькими: ССССС."
						+"А что случится с пробелами? Их не станет...";

string Replace(string text, char oldValue, char newValue) {
	string result = String.Empty;

	int length = text.Length;

	for(int i=0; i<length; i++) {
		if(text[i] == oldValue) result = result  + $"{newValue}";
		else result = result + $"{text[i]}";
	}
	return result;
}
// пока не поменяла двойные кавычки на одинарные, код не работал
string newText = Replace(text, ' ', '-');
string newText2 = Replace(newText, 'к', 'К');
string newText3 = Replace(newText2, 'С', 'с');
Console.WriteLine(newText3);

