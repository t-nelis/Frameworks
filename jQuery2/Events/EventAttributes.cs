using Bridge.CLR;

namespace Bridge.jQuery2
{
    [Ignore]
    public enum JqueryEventTarget
    {
        [Template("{0}")]
        Raw=0,

        [Template("'{0}'")]
        Value
    }

    [Ignore]
    public abstract class EventAttribute : Bridge.CLR.EventAttribute
    {
        public const string Format = "$({1}).on('{0}', this.{2});";
    }

    [Ignore]
    public class JQueryEventAttribute : EventAttribute
    {
        public const bool IsCommonEvent = true;

        public JQueryEventAttribute(string eventName, string selector, JqueryEventTarget target = JqueryEventTarget.Value)
        {
        }
    }  

    [Ignore]
    public class ReadyAttribute : EventAttribute
    {
        public const string Format = "$(this.{2});";
        public const string Event = "ready";

        public ReadyAttribute()
        {            
        }
    }

    [Ignore]
    public class ClickAttribute : EventAttribute
    {
        public const string Event = "click";

        public ClickAttribute(string selector, JqueryEventTarget target = JqueryEventTarget.Value)
        {
        }
    } 
}