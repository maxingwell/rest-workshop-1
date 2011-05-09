using Open.Documents.Resources;

namespace Open.Documents.Handlers
{
    
    public class SearchResultsHandler
    {
        public SearchResults Post(string search)
        {
            return Get(search);
        }

        public SearchResults Get(string search)
        {
            return new SearchResults
                       {
                           Search = search
                       };
        }

    }
}