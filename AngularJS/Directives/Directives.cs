using Bridge.Html5;

namespace Bridge.AngularJS
{
    public static class Directives
    {
        [Template("{el}")]
        public extern static AngularElement NG(this Element el);

        [Template("{el}")]
        public extern static AngularElement Angular(this Element el);
    }
}