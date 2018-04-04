using System;
using System.Collections.Generic;
using System.Threading;

public class OneThreadSynchronizationContext
{

    private Queue<Action> mainThreadActions = new Queue<Action>();
    private Queue<Action> mainThreadActionsRunner = new Queue<Action>();

    private void Add(Action action)
    {
        lock (mainThreadActions)
        {
            mainThreadActions.Enqueue(action);
        }
    }

    public void Execute(Action action)
    {
        Run(action);
    }

    public void Update()
    {
        lock (mainThreadActions)
        {
            if (mainThreadActions.Count > 0)
            {
                while (mainThreadActions.Count > 0)
                    mainThreadActionsRunner.Enqueue(mainThreadActions.Dequeue());
            }
        }

        if (mainThreadActionsRunner.Count > 0)
        {
            while (mainThreadActionsRunner.Count > 0)
                mainThreadActionsRunner.Dequeue()();
        }
    }

    public void Post(SendOrPostCallback callback, object state)
    {
        this.Add(() => { callback(state); });
    }

    public void Run(Action action)
    {
        Add(action);
    }
}
