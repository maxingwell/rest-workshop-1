using System;
using System.Collections.Generic;
using Open.Documents.Resources;

namespace Open.Documents
{
    public static class Database
    {
        static Database()
        {
            Documents = new List<Document>
                            {
                                new Document
                                       {
                                           Author = "Author 1",
                                           LastModifiedTimeUtc = DateTime.Now.AddYears(-10),
                                           LinkToDocument = string.Format("document/{0}/raw", 1)
                                       },
                                new Document
                                       {
                                           Author = "Author 2",
                                           LastModifiedTimeUtc = DateTime.Now.AddYears(-100),
                                           LinkToDocument = string.Format("document/{0}/raw", 2)
                                       }
                            };
        }

        public static List<Document> Documents { get; private set; }

        public static Document GetDocument(int id)
        {
            return new Document
                       {
                           Author = string.Format("Author {0}", id),
                           LastModifiedTimeUtc = DateTime.Now.AddYears(-10),
                           LinkToDocument = string.Format("document/{0}", id)
                       };
        }
    }
}