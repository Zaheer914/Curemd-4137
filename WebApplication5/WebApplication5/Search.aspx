<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WebApplication5.Search" %>

    <!DOCTYPE html>  
  
    <html>  
        <head runat="server">  
            <title>Intellisense</title>  
            <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"> 
            <%--Styling of the Front Page using internal css--%>
            <style>
                *{
                    font-size:30px;
                }
                #txtCountry{
                    text-align:left;
                    left:25%;
                    max-width:50%;
                    color:green;
                }
                h2{
                    text-align:center;
                    color:crimson;
                } 
                label{
                    display:block;
                    text-align:center;
                    font-size:xx-large;
                    color:darkseagreen;
                }
                .ui-menu-item-wrapper{
                    color:green;
                }
        
        
            </style>
            
            <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">  
            <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>  
            <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>  
            <script type="text/javascript">  
                $(document).ready(function () { 
                    /*using auto complete function of jquery*/
                    $("#txtCountry").autocomplete({ 
                
                        source: function (request, responce) {  
                            $.ajax({  
                                url: "Search.aspx/GetCarNames",  
                                method: "post",  
                                contentType: "application/json;charset=utf-8",
                                /*term is getting value in the textbox and sending into the function on server side*/
                                data: JSON.stringify({ term: request.term }),  
                                dataType: 'json',  
                                success: function (data) { 
                                    /*Getting data by the response from the server side*/ 
                                    responce(data.d);  
                                },  
                                error: function (err) {  
                                    alert(err);  
                                }  
                            });  
                        }  
                    });  
                });  
            </script>  
        </head>  
        <%--Content on the Front Page--%> 
        <body>  
            <form id="form1" runat="server">  
                <div class="container">  
                    <h2>Autocomplete Texbox</h2>  
                    <label>Car Names</label>  
                    <asp:TextBox ID="txtCountry" CssClass="form-control col-md-3" runat="server"></asp:TextBox>  
                </div>  
            </form>  
        </body>  
    </html>  
