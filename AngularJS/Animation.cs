using System;

namespace Bridge.AngularJS
{
    // TODO: Overload / extension with jQuery on separate project which requires
    //       jQuery to be included.
    [Ignore]
    [ObjectLiteral]
    public class Animation
    {
        // Function which returns a function to cancel animation
        public Func<jqLite, Action, Action<jqLite>> EventName;

        public Func<jqLite, string, Action, Action<bool>> AddClass;

        public Func<jqLite, string, Action, Action<bool>> RemoveClass;
    }
}

