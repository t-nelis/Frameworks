using Bridge;
using Bridge.Html5;
using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{    
    public partial class jQuery
    {
        /// <summary>
        /// Global settings of animations.
        /// </summary>
        public static readonly Fx Fx;
    }

    [Ignore]
    [ObjectLiteral]
    public class Fx
    {
        /// <summary>
        /// The rate (in milliseconds) at which animations fire. Defaults to 13.
        /// </summary>
        public virtual int Interval { get; set; }

        /// <summary>
        /// Globally disable all animations. Defaults to false;
        /// </summary>
        public virtual bool Off { get; set; }
    }
}