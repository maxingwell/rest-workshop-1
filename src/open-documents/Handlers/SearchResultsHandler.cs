using Open.Documents.Resources;

namespace Open.Documents.Handlers
{
    
    public class SearchResultsHandler
    {
        public SearchResults Get(string search)
        {
            search = string.Format("You searched for: {0}", search);
            
            if (search.ToLower().Contains("coffee"))
            {
                search = "Im a teapot";
            }

            return new SearchResults
                       {
                           Search = search
                       };
        }

        public SearchResults Post(string search)
        {
            return Get(search);
        }
        
    }
}