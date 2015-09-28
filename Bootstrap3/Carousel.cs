using Bridge.jQuery2;

namespace Bridge.Bootstrap3
{
    [Ignore]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Initializes the carousel with default options and starts cycling through items.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.carousel()")]
        public static jQuery Carousel(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Initializes the carousel with an options object and starts cycling through items.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="options">The carousel options</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.carousel({1})")]
        public static jQuery Carousel(this jQuery instance, CarouselOptions options)
        {
            return null;
        }

        /// <summary>
        /// Does something with the carousel - "cycle", "next", "pause" or "prev".
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation">The operation</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.carousel({1})")]
        public static jQuery Carousel(this jQuery instance, string operation)
        {
            return null;
        }

        /// <summary>
        /// Does something with the carousel - "cycle", "next", "pause" or "prev".
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation">The operation</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.carousel({1})")]
        public static jQuery Carousel(this jQuery instance, CarouselOperation operation)
        {
            return null;
        }

        /// <summary>
        /// Cycles through the carousel items from left to right.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.carousel('cycle')")]
        public static jQuery CarouselCycle(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Cycles to the next item.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.carousel('next')")]
        public static jQuery CarouselNext(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Stops the carousel from cycling through items.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.carousel('pause')")]
        public static jQuery CarouselPause(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Cycles to the previous item.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.carousel('prev')")]
        public static jQuery CarouselPrev(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Cycles the carousel to a particular frame (0 based, similar to an array).
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="index">The index of the frame</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.carousel({0})")]
        public static jQuery Carousel(this jQuery instance, int index)
        {
            return null;
        }
    }

    /// <summary>
    /// Carousel options
    /// </summary>
    [Ignore]
    [ObjectLiteral]
    public class CarouselOptions
    {
        /// <summary>
        /// The amount of time to delay between automatically cycling an item. If false, carousel will not automatically cycle.
        /// Defaults to 5000.
        /// </summary>
        public virtual int Interval
        {
            get;
            set;
        }

        /// <summary>
        /// Pauses the cycling of the carousel on mouseenter and resumes the cycling of the carousel on mouseleave.
        /// Defaults to "hover".
        /// </summary>
        public virtual string Pause
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the carousel should cycle continuously or have hard stops.
        /// Defaults to true.
        /// </summary>
        public virtual bool Wrap
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Carousel operations
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum CarouselOperation
    {
        /// <summary>
        /// Cycles through the carousel items from left to right.
        /// </summary>
        Cycle,

        /// <summary>
        /// Cycles to the next item.
        /// </summary>
        Next,

        /// <summary>
        /// Stops the carousel from cycling through items.
        /// </summary>
        Pause,

        /// <summary>
        /// Cycles to the previous item.
        /// </summary>
        Prev
    }

    /// <summary>
    /// Carousel events.
    /// Both  events have the following additional properties:
    ///     - direction: The direction in which the carousel is sliding (either "left" or "right").
    ///     - relatedTarget: The DOM element that is being slid into place as the active item.
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum CarouselEvent
    {
        /// <summary>
        /// This event is fired when the carousel has completed its slide transition.
        /// </summary>
        [Name("slid.bs.carousel")]
        Slid,

        /// <summary>
        /// This event fires immediately when the slide instance method is invoked.
        /// </summary>
        [Name("slide.bs.carousel")]
        Slide
    }
}
