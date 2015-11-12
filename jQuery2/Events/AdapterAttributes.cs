using Bridge;

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
    public abstract class AdapterAttribute : Bridge.AdapterAttribute
    {
        public const string Format = "$({1}).on('{0}', this.{2});";
        public const string FormatScope = "$({1}).on('{0}', $.proxy(this.{2}, this));";
    }

    [Ignore]
    public class jQueryEventAttribute : AdapterAttribute
    {
        public const bool IsCommonEvent = true;

        public jQueryEventAttribute(string eventName, string selector, JqueryEventTarget target = JqueryEventTarget.Value)
        {
        }
    }

    [Ignore]
    public class ClickAttribute : AdapterAttribute
    {
        public const string Event = "click";

        public ClickAttribute(string selector, JqueryEventTarget target = JqueryEventTarget.Value)
        {
        }
    }
}