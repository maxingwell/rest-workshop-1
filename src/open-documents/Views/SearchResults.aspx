<%@ Page Language="C#" Inherits="OpenRasta.Codecs.WebForms.ResourceView<Open.Documents.Resources.SearchResults>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Search Results</h1>

    <div>
        <input type="text" name="search" style="width:450px;" 
            value="You searched for: <%= Resource.Search %>" /><br />

        
    </div>
</body>
</html>
