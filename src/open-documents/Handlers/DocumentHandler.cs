using System.Collections;
using System.Collections.Generic;
using Open.Documents.Resources;

namespace Open.Documents.Handlers
{
    public class DocumentHandler
    {
        public IList<Document> Get(string title)
        {
            return new List<Document> {new Document {Title = "Doc1"}, new Document {Title = "Doc2"}};
            
        }
    }
}