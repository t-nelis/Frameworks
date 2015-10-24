using Bridge.Html5;
using System;

namespace Bridge.AngularJS
{
    [Ignore]
    [ObjectLiteral]
    public class Animation
    {
        // Function which returns a function to cancel animation
        public Func<Element, Action, Action<Element>> EventName;

        public Func<Element, string, Action, Action<bool>> AddClass;

        public Func<Element, string, Action, Action<bool>> RemoveClass;
    }
}

