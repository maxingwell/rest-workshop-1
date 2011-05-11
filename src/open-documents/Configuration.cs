using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using Open.Documents.Handlers;
using Open.Documents.Resources;
using OpenRasta.Configuration;
using OpenRasta.Web;
using OpenRasta.Codecs;

namespace Open.Documents
{
    public class Configuration : IConfigurationSource
    {
        public void Configure()
        {
            ResourceSpace.Uses.ConventionsFrom(this);

            ResourceSpace.Has.Resource<Home>()
                .Anywhere
                .RenderedByAspx("~/Views/Home.aspx");

            ResourceSpace.Has.Resource<SearchResults>()
                .Uri("search-results/{search}")
                .Handler<SearchResultsHandler>().RenderedByAspx("~/Views/SearchResults.aspx");

            ResourceSpace.Has.Resource<ContactUs>()
                .Uri("/contact-us?email={email}&comment={comment}")
                .And.Uri("/contact-us/{email}/{comment}");
            
            //ResourceSpace.Has.Resource<DocumentInfo>()


            ResourceSpace.Has.Resource<Document>()
                .Uri("/document/{id}")
                .Handler<DocumentHandler>().RenderedByAspx("~/Views/Document.aspx");
        }
    }

    public class DocumentInfo
    {
    }
}