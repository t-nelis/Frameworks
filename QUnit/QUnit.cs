using System;
using Bridge;

namespace Bridge.QUnit
{
    [Ignore]
    [Name("QUnit")]
    public partial class QUnit
    {
        /// <summary>
        /// Configuration for QUnit.
        /// </summary>
        public static Configuration Config;

        /// <summary>
        /// Advanced and extensible data dumping for JavaScript.
        /// </summary>
        public static Dump Dump;
    }
}