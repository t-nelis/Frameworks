namespace Bridge.WebGL
{
    /// <summary>
    /// Provides the precision, rangeMin, and rangeMax properties returned by the getShaderPrecisionFormat method.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class WebGLShaderPrecisionFormat
    {
        /// <summary>
        /// Represents the precision in bits for a given data type.
        /// </summary>
        public virtual int Precision { get; private set; }

        /// <summary>
        /// Gets the maximum positive value in log base 2 that can be represented by a type.
        /// </summary>
        public virtual int RangeMax { get; private set; }

        /// <summary>
        /// Returns the base 2 log of the absolute value of the minimum value that can be represented.
        /// </summary>
        public virtual int RangeMin { get; private set; }
    }
}
