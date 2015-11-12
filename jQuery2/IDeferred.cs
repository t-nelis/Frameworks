using System;

namespace Bridge.jQuery2
{
    [Ignore]
    public interface IDeferred
    {
        Deferred Always(params Action[] alwaysCallbacks);

        Deferred Done(params Action[] doneCallbacks);

        Deferred Fail(params Action[] failCallbacks);

        Deferred Notify(params object[] arguments);

        Deferred NotifyWith(object context, params object[] arguments);

        Deferred Progress(params Action[] progressCallbacks);

        Deferred Reject(params object[] arguments);

        Deferred RejectWith(object context, params object[] arguments);

        Deferred Resolve(params object[] arguments);

        Deferred ResolveWith(object context, params object[] arguments);

        string State();

        Promise Then(Action doneFilter, Action failFilter = null, Action progressFilter = null);
    }
}
