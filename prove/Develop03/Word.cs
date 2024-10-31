using System; 

class Word{
    private string _text; 
    private bool _isHide; 

    public Word(string text){
        this._text = text; 
        _isHide = false; 
    }

    public void Hide(){
        _isHide = true; 
    }
    public string GetText(){
        return _text; 
    }
    public bool IsHide(){
        return _isHide; 
    }

}
