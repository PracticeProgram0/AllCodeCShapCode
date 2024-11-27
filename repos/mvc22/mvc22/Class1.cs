using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc22
{
    public class Class1
    {
        public static IHtmlString Button(string value)
        {
            TagBuilder tag = new TagBuilder("InPUT");
            tag.Attributes.Add("type","SUBMIT");
            tag.Attributes.Add("value", value);
            return new HtmlString(tag.ToString());
        }
    }
}