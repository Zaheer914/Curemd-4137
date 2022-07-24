<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="WebApplication2.Students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>DropDown</title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
        <style>
            .container{
                width:20%;
                margin-top:100px;
            }
            #DropDownList1{
                background-color:aqua;
                color:purple;
            }
        </style>
        <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
        <script type="text/javascript">
            // Hiding table of Html
        $(document).ready(function () {
            $('.table').hide();
        });
            //function calling on submitting data
        function studentInformation() {
            var Id = document.getElementById("DropDownList1").value;
            $.ajax({
                url: 'Students.aspx/InformationofStudent',
                type: 'post',
                data: JSON.stringify({ "Id": Id }),
                contentType: 'application/json',
                async:false,
                success: function (data) {
                    // doing list empty on submit
                    $('#studentId').empty();
                    $('#studentFname').empty();
                    $('#studentLname').empty();
                    $('#studentCity').empty();

                    if (data.d != "") {
                        // Appending and animating data into a table
                        $('.table').hide().show('slow');
                        $('#studentId').append(data.d[0]);
                        $('#studentFname').append(data.d[1]);
                        $('#studentLname').append(data.d[2]);
                        $('#studentCity').append(data.d[3]);
                    }
                    
                }
            });


        }
    </script>
    </head>
    <%--front side of the page--%>
    <body>
        <form id="form1" runat="server">
            <div class="container">
            <asp:DropDownList ID="DropDownList1" runat="server" Width="280px" class="form-select" aria-label="Default select example" >  
            </asp:DropDownList> 
             <asp:Button runat="server" Text="Submit" OnClientClick="studentInformation();return false;" style="margin-top: 10px;padding-right: 11px;
"/>
            </div>
            <div class="container">
                <table class="table table-light">
                    <thead>
                        <tr>
                            <th scope="col">Id</th>
                            <th scope="col">FirstName</th>
                            <th scope="col">LastName</th>
                            <th scope="col">City</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr id="studentData">
                           <td Id="studentId"></td>
                           <td Id="studentFname"></td>
                           <td Id="studentLname"></td>
                           <td Id="studentCity"></td>
                        </tr>
                    </tbody>
                </table>

            </div>
        </form>  
    </body>
</html>
