using System;
using System.Dynamic;
using System.Globalization;

public class Entry{

// userinput, get prompt
// prompt, date, entries
    public string Prompt {get; set;}
    
    public string Response {get; set; }
    public DateTime Date {get; set;}

    public Entry(string prompt, string response){
        Prompt = prompt; 
        Response = response; 
        Date = DateTime.Now; 

    }
    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

}


