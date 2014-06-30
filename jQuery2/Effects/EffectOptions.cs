using Bridge.CLR;
using Bridge.Html5;
using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{    
    [ObjectLiteral]
    public partial class EffectOptions
    {
        /// <summary>
        /// A string or number determining how long the animation will run.
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// A string or number determining how long the animation will run.
        /// </summary>
        public string DurationString { get; set; }

        /// <summary>
        /// A string indicating which easing function to use for the transition.
        /// </summary>
        public string Easing { get; set; }

        /// <summary>
        /// A Boolean indicating whether to place the animation in the effects queue. If false, the animation will begin immediately. As of jQuery 1.7, the queue option can also accept a string, in which case the animation is added to the queue represented by that string. When a custom queue name is used the animation does not automatically start; you must call .dequeue("queuename") to start it.
        /// </summary>
        public bool Queue { get; set; }

        /// <summary>
        /// A Boolean indicating whether to place the animation in the effects queue. If false, the animation will begin immediately. As of jQuery 1.7, the queue option can also accept a string, in which case the animation is added to the queue represented by that string. When a custom queue name is used the animation does not automatically start; you must call .dequeue("queuename") to start it.
        /// </summary>
        public string QueueString { get; set; }

        /// <summary>
        /// A map of one or more of the CSS properties defined by the properties argument and their corresponding easing functions. (version added: 1.4)
        /// </summary>
        public object SpecialEasing { get; set; }

        /// <summary>
        /// A function to be called for each animated property of each animated element. This function provides an opportunity to modify the Tween object to change the value of the property before it is set.
        /// </summary>
        public Func<int, object, jQuery> Step { get; set; }

        /// TODO: Add Promise object to Func
        /// <summary>
        /// A function to be called after each step of the animation, only once per animated element regardless of the number of animated properties.
        /// </summary>
        public Func<object, int, int, jQuery> Progress { get; set; }

        /// <summary>
        /// A function to call once the animation is complete.
        /// </summary>
        public Func<jQuery> Complete { get; set; }

        /// TODO: Add Promise object to Func
        /// <summary>
        /// A function to call when the animation begins.
        /// </summary>
        public Func<object, jQuery> Start { get; set; }

        /// TODO: Add Promise object to Func
        /// <summary>
        /// A function to be called when the animation completes (its Promise object is resolved).
        /// </summary>
        public Func<object, bool, jQuery> Done { get; set; }

        /// TODO: Add Promise object to Func
        /// <summary>
        /// A function to be called when the animation fails to complete (its Promise object is rejected). 
        /// </summary>
        public Func<object, bool, jQuery> Fail { get; set; }

        /// TODO: Add Promise object to Func
        /// <summary>
        /// A function to be called when the animation completes or stops without completing (its Promise object is either resolved or rejected).
        /// </summary>
        public Func<object, bool, jQuery> Always { get; set; }
    }
}