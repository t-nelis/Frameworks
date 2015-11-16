namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Global settings of animations.
        /// </summary>
        public static readonly Fx Fx;
    }

    [External]
    [ObjectLiteral]
    public class Fx
    {
        /// <summary>
        /// The rate (in milliseconds) at which animations fire. Defaults to 13.
        /// </summary>
        public virtual int Interval
        {
            get;
            set;
        }

        /// <summary>
        /// Globally disable all animations. Defaults to false;
        /// </summary>
        public virtual bool Off
        {
            get;
            set;
        }
    }
}
