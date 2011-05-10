using System;
using Open.Documents.Resources;
using OpenRasta.Web;

namespace Open.Documents.Handlers
{
    public class SearchHandler
    {
        
        public OperationResult Post(string term)
        {
            return new OperationResult.SeeOther
                       {
                           RedirectLocation = new SearchResults {Search = term}.CreateUri()
                       };
        }

        
        //public OperationResult Get(string term)
        //{
        //    if(term.ToLower().Contains("coffee") || (term.ToLower().Contains("tea")))
        //    {
        //        return ImATeapotOperationResult();
        //    }

        //    return new OperationResult.OK(new Search {Term = term});
        //}

    }
}