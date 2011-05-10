<%@ Page Language="C#" Inherits="OpenRasta.Codecs.WebForms.ResourceView<Open.Documents.Resources.Home>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title><%= Resource.Title %></title>
    <link rel="search-template" href="/contact-us/{email}/{comment}" />
</head>
<body>
    <%= h1[Resource.Title] %>
    <hr />
    <h1>Search for a Document</h1>

    
    <form action="/search" method="post">
    <input type="search" name="term" /><br />
    <br />
    <input type="submit" />
    </form>
</body>
</html>
