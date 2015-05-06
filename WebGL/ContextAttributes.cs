namespace Bridge.WebGL
{
    /// <summary>
    /// A dictionary object of attributes used to initialize the context for the first time.
    /// </summary>
    [Ignore]
    [ObjectLiteral]
    public class WebGLContextAttributes
    {
        /// <summary>
        /// Gets or sets whether the drawing buffer has an alpha channel for alpha compositing and operations.
        /// </summary>
        public bool Alpha { get; set; }

        /// <summary>
        /// Get or set the antialias state on a WebGL rendering context.
        /// </summary>
        public bool Antialias { get; set; }

        /// <summary>
        /// Gets or sets whether the drawing buffer has a depth buffer. Returns false if no depth buffer exists.
        /// </summary>
        public bool Depth { get; set; }

        /// <summary>
        /// A flag that sets whether WebGL creates a context with getContext if system performance is low.
        /// </summary>
        public bool FailIfMajorPerformanceCaveat { get; set; }

        /// <summary>
        /// Gets or sets whether the colors in the drawing buffer are premultiplied alpha values. This property is ignored if the alpha property is false.
        /// </summary>
        public bool PremultipliedAlpha { get; set; }

        /// <summary>
        /// Sets or gets whether the drawing buffer's is cleared once content is presented.
        /// </summary>
        public bool PreserveDrawingBuffer { get; set; }
    }
}
