namespace Bridge.QUnit
{
    [External]
    [ObjectLiteral]
    public class ModuleStartCallbackArgs
    {
        /// <summary>
        /// Name of the next module to run
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}
