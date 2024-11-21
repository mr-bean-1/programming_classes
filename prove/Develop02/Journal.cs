using System;
using System.Collections.Generic;
using System.IO;

public class Journal {
    private List<Entry> entries = new List<Entry>();  

    public void AddEntry(string prompt, string response) {
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
    }
// method displayentries 
// will go through each part in the list and print it 
    public void DisplayEntries() {

        foreach (Entry entry in entries) {

            Console.WriteLine(entry);
        }
    }

// load from file method 
// it will load the date, prompt, and response 
    public void LoadFromFile(string journal_entries) {
        entries.Clear();
        try {
            if (!File.Exists(journal_entries)) {
                Console.WriteLine("File not found.");
            }

            using (StreamReader reader = new StreamReader(journal_entries)) {
                string line; 

                string currentPrompt = null; 

                string currentResponse = null; 
                DateTime currentDate = DateTime.Now; 

                while ((line = reader.ReadLine()) != null) {

                    if (line.StartsWith("Date: ")) {
                        currentDate = DateTime.Parse(line.Substring("Date: ".Length));
                    } else if (line.StartsWith("Prompt: ")) {
                        currentPrompt = line.Substring("Prompt: ".Length);
                    } 
                    else if (line.StartsWith("Response: ")) 
                    {
                        currentResponse = line.Substring("Response: ".Length);
                        entries.Add(new Entry(currentPrompt, currentResponse) { Date = currentDate });
                    }
                }
            }
        } catch (Exception ex)
         {
            Console.WriteLine($"Couldn't load file: {ex.Message}");
        }
    }

    // savetofile method
// will write the journal entries, date, and the given prompt 
    public void SaveToFile(string journal_entries) {

        using StreamWriter writer = new StreamWriter(journal_entries);
        foreach (Entry entry in entries)
        {
            writer.WriteLine($"Date: {entry.Date}");

            writer.WriteLine($"Prompt: {entry.Prompt}");

            writer.WriteLine($"Response: {entry.Response}");
         
        }
    }
}
