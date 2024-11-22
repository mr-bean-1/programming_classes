using System; 

class Reference{

    private string _book; 
    private int _chapter; 
    private int _startVerse;
    private int _endVerse; 
    // create variable to recognize the book, chapter, and the beginning and end of a verse. 


public Reference(string book, int chapter, int verse){
    this._book = book; 
    this._chapter = chapter; 
    this._startVerse = verse; 
    this._endVerse = verse; 
}

public override string ToString(){
return $"{_book} {_chapter}:{_startVerse}";


}
}
