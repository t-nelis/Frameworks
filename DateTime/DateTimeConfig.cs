using Bridge.Foundation;

namespace Bridge.DateTime
{
    [ObjectLiteral]
    public class DateTimeConfig
    {
        public virtual int Year { get; set; }
        public virtual int Month { get; set; }
        public virtual int Day { get; set; }
        public virtual int Hour { get; set; }
        public virtual int Minute { get; set; }
        public virtual int Second { get; set; }
        public virtual int Millisecond { get; set; }
    }
}