using Boa.Constrictor.Screenplay;

namespace QBox.Domain.ScreenPlayPattern;
public class TaskItemWithParameters<TParam> : ITask
{

    private TParam? _param { get; set; }
    private Action<TParam?>? _actionToInvoke { get; set; }

    public TaskItemWithParameters<TParam?> WithParam(TParam? param)
    {
        _param = param;
        return this;
    }

    public TaskItemWithParameters<TParam?> WithActionToInvoke(Action<TParam?> actionToInvoke)
    {
        _actionToInvoke = actionToInvoke;
        return this;
    }

    public void PerformAs(IActor actor)
    {
        _actionToInvoke!.Invoke(_param);
    }
}
