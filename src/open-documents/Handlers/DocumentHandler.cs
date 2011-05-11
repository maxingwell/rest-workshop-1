using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using Open.Documents.Resources;
using OpenRasta.Web;

namespace Open.Documents.Handlers
{
    public class DocumentHandler
    {
        //public Document Get()
        //{
        //    return new Document();
        //}

        public Document Get()
        {
            return new Document();
        }

        public Document Get(int id)
        {
            var doc = Database.GetDocument(id);
            return doc;
        }

        public Document Post(int id)
        {
            return Get(id);
        }
    }
}