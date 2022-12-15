using Boa.Constrictor.Screenplay;

namespace QBox.Domain.ScreenPlayPattern;
public class QuestionItem<TAnswer> : IQuestion<TAnswer>
{

    private const int DEFAULT_WAIT_TO_API_TIMEOUT_IN_SECONDS = 300;

    private Func<TAnswer>? _actionToInvoke { get; set; }

    public QuestionItem<TAnswer> WithActionToInvoke(Func<TAnswer> actionToInvoke)
    {
        _actionToInvoke = actionToInvoke;
        return this;
    }

    public TAnswer RequestAs(IActor actor)
    {
        return ExecuteFunctionAndWaitToResult(_actionToInvoke);
    }
    public TAnswer ExecuteFunctionAndWaitToResult(Func<TAnswer>? functionToInvoke)
    {
        var timeOutDateTime = DateTime.Now.AddSeconds(DEFAULT_WAIT_TO_API_TIMEOUT_IN_SECONDS);
        var result = default(TAnswer);
        while (result is null && DateTime.Now <= timeOutDateTime)
        {
            result = functionToInvoke!.Invoke();
        }
        return result;
    }

}
