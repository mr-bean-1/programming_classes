using System;


public class Entry{

// userinput, get prompt
// prompt, date, entries

    private string _prompt; 
    private string _response; 
    private DateTime _date; 

    public string Prompt {
        get {return _prompt; }
        set { _prompt = value; }
    }
    
    public string Response {
        get {return _response; }
        set { _response = value; }
    }
    public DateTime Date {
        get {return _date; }
        set { _date = value; }
    }

    public Entry(string prompt, string response){
        _prompt = prompt; 
        _response = response; 
        _date = DateTime.Now; 

    }
    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

}


