
class Entry
{
    public string date, promptText, entryText;

    public Entry(string_date, string_promptText, string_entryText)
    {
        date              = _date;
        promptText        = _promptText;
        entryText         = _entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {promptText}");
        Console.WriteLine(entryText);
    }
}