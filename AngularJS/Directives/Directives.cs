using Bridge.Html5;

namespace Bridge.AngularJS
{
    [External]
    public static class Directives
    {
        [Template("{el}")]
        public extern static AngularElement NG(this Element el);

        [Template("{el}")]
        public extern static AngularElement Angular(this Element el);

        [Template("{el}")]
        public extern static AngularHtmlElement NG(this HtmlElement el);

        [Template("{el}")]
        public extern static AngularHtmlElement Angular(this HtmlElement el);

        [Template("{el}")]
        public extern static AngularAnchorElement NG(this AnchorElement el);

        [Template("{el}")]
        public extern static AngularAnchorElement Angular(this AnchorElement el);

        [Template("{el}")]
        public extern static AngularImageElement NG(this ImageElement el);

        [Template("{el}")]
        public extern static AngularImageElement Angular(this ImageElement el);

        [Template("{el}")]
        public extern static AngularFormElement NG(this FormElement el);

        [Template("{el}")]
        public extern static AngularFormElement Angular(this FormElement el);

        // The elements related to <input/> below were extracted from:
        // http://www.w3schools.com/html/html_form_elements.asp
        // Except for label, fieldset and output elements (which don't really
        // are input elements)
        #region Input elements
        [Template("{el}")]
        public extern static AngularInputElement NG(this InputElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this InputElement el);

        [Template("{el}")]
        public extern static AngularInputElement NG(this TextAreaElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this TextAreaElement el);

        [Template("{el}")]
        public extern static AngularSelectElement NG(this SelectElement el);

        [Template("{el}")]
        public extern static AngularSelectElement Angular(this SelectElement el);

        [Template("{el}")]
        public extern static AngularInputElement NG(this OptGroupElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this OptGroupElement el);

        [Template("{el}")]
        public extern static AngularOptionElement NG(this OptionElement el);

        [Template("{el}")]
        public extern static AngularOptionElement Angular(this OptionElement el);

        [Template("{el}")]
        public extern static AngularInputElement NG(this ButtonElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this ButtonElement el);

        [Template("{el}")]
        public extern static AngularInputElement NG(this DataListElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this DataListElement el);

        [Template("{el}")]
        public extern static AngularInputElement NG(this KeygenElement el);

        [Template("{el}")]
        public extern static AngularInputElement Angular(this KeygenElement el);
        #endregion

        /// <summary>
        /// The &lt;details&gt; tag is currently experimental and not supported
        /// by all major browsers.
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        /// <remarks>
        /// The &lt;details&gt; tag is currently in draft state and not supported
        /// by all browsers, thus not available on Bridge.Html5.
        /// Details: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/details
        /// </remarks>
        [Template("{el}")]
        public extern static AngularDetailsElement NG(this UnknownElement el);

        /// <summary>
        /// The &lt;details&gt; tag is currently experimental and not supported
        /// by all major browsers.
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        /// <remarks>
        /// The &lt;details&gt; tag is currently in draft state and not supported
        /// by all browsers, thus not available on Bridge.Html5.
        /// Details: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/details
        /// </remarks>
        [Template("{el}")]
        public extern static AngularDetailsElement Angular(this UnknownElement el);
    }
}