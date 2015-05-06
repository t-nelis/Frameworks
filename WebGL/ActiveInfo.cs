namespace Bridge.WebGL
{
    /// <summary>
    /// Contains data returned by getActiveAttrib or getActiveUniform calls.
    /// </summary>
    [Ignore]
    [ObjectLiteral]
    public class WebGLActiveInfo
    {
        /// <summary>
        /// Represents the name of the data variable requested with a getActiveUniform or getActiveAttrib call.
        /// </summary>
        public virtual string Name { get; private set; }

        /// <summary>
        /// Represents the size of the data returned by getActiveUniform or getActiveAttrib calls.
        /// </summary>
        public virtual int Size { get; private set; }

        /// <summary>
        /// Represents the type of data returned by a getActiveUniform or getActiveAttrib call.
        /// </summary>
        public virtual string Type { get; private set; }
    }
}
