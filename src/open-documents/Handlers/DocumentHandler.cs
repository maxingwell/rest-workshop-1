using Open.Documents.Resources;

namespace Open.Documents.Handlers
{
    public class DocumentHandler
    {
        public Document Get(string title)
        {
            return new Document
                       {
                           Title = title
                       };
        }
    }
}