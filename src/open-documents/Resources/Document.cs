using System;

namespace Open.Documents.Resources
{
    public class Document
    {
        public string Author { get; set; }
        public DateTime LastModifiedTimeUtc { get; set; }
        public string LinkToDocument { get; set; }
    }
}