using System.Collections;

namespace Bridge.jQuery2
{
    /// <summary>
    ///
    /// </summary>
    [External]
    [Constructor("$")]
    [Name("$")]
    public partial class jQuery : IEnumerable
    {
        [Template("$(this)")]
        public static readonly jQuery This;

        [Template("$(window)")]
        public static readonly jQuery Window;

        [Template("$(document)")]
        public static readonly jQuery Document;

        [Template("$()")]
        public static readonly jQuery Basic;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
