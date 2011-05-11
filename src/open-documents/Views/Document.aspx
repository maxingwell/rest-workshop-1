<%@ Page Language="C#" Inherits="OpenRasta.Codecs.WebForms.ResourceView<Open.Documents.Resources.Document>" %>
<%@ Import Namespace="Open.Documents" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form action="/document" method="get">
        <input type="Document" name="id" /><br />
        <br />
        <input type="submit" />
        <br />
        Author: <%=Resource.Author%><br />
        Last modified: <%=Resource.LastModifiedTimeUtc%><br />
        Link: <a href="<%=Resource.LinkToDocument + "/raw"%>">Link to Doc</a><br />
        
    </form>
    
    
</body>
</html>
