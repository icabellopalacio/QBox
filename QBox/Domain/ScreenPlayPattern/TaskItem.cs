using Boa.Constrictor.Screenplay;

namespace QBox.Domain.ScreenPlayPattern;
public class TaskItem : ITask
{

    private List<Action>? _actionLists { get; set; }
    private List<Task>? _actionAsyncLists { get; set; }

    public TaskItem WithActionToInvokeLists(List<Action> actionLists)
    {
        _actionLists = actionLists;
        return this;
    }
    public TaskItem WithAsyncActionToInvokeLists(List<Task> actionAsyncLists)
    {
        _actionAsyncLists = actionAsyncLists;
        return this;
    }

    public void PerformAs(IActor actor)
    {
        _actionLists?.ForEach(a => a.Invoke());
        _actionAsyncLists?.ForEach(a => a.Wait());

    }

}
