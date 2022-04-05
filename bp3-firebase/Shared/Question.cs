namespace bp3_firebase.Shared;

public class Question
{
    private string answer;
    private string question;

    public string GetAnswer => answer;

    public string GetQuestion => question;

    public Question(string question, string answer)
    {
        this.question = question;
        this.answer = answer;
    }
    
    
}