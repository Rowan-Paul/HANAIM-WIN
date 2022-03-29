using Microsoft.JSInterop;

namespace bp3_quiz.Pages;

public class MessageUpdateInvokeHelper
{
    private Action action;

    public MessageUpdateInvokeHelper(Action action)
    {
        this.action = action;
    }

    [JSInvokable("bp3-quiz")]
    public void UpdateMessageCaller()
    {
        action.Invoke();
    }
}