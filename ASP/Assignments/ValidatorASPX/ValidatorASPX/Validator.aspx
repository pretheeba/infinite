<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="ValidatorASPX.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script type="text/javascript">
    function validateNameFamily(sender, args) {
        var name = document.getElementById('<%= txtName.ClientID %>').value;
        var familyName = document.getElementById('<%= txtFamilyName.ClientID %>').value;
        args.IsValid = name !== familyName;
    }
</script>
    <form id="form1" runat="server">
        <div>  
                <table style="width:100%;">  
                    <caption class="style3">  
                        Insert Your Details:</caption>  
                    <tr>  
                        <td class="style1">  
                        </td>  
                        <td class="style2">  
                        </td>  
                        <td>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>  
                        </td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtName" runat="server" Height="22px" MaxLength="20" Width="158px"></asp:TextBox>  
                        </td>  
                        <td>  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtName" ForeColor="#CC0000">*</asp:RequiredFieldValidator>  
                        </td>  
                        <td>  
                            &nbsp;</td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            <asp:Label ID="Label2" runat="server" Text="FamilyName:"></asp:Label>  
                        </td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtFamilyName" runat="server" Height="22px" MaxLength="10" Width="158px"></asp:TextBox>  
                        </td>  
                        <td>  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFamilyName" ForeColor="#CC0000">*</asp:RequiredFieldValidator>  
                        &nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtFamilyName" ErrorMessage="Please Enter your Family Name"></asp:RequiredFieldValidator>
                        </td>  
                        <td>  
                            &nbsp;</td>  
                        <asp:CustomValidator ID="cvNameFamily" runat="server" 
    ControlToValidate="txtFamilyName" 
    ClientValidationFunction="validateNameFamily" 
    ErrorMessage="Name and Family Name cannot be the same." 
    Display="Dynamic" ForeColor="Red"></asp:CustomValidator>
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>  
                        </td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtAddress" runat="server" Height="22px" MaxLength="15" Width="158px"></asp:TextBox>  
                        </td>  
                        <td>  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtAddress" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
&nbsp;  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAddress" ErrorMessage="Please Enter your Email ID" ForeColor="Black"></asp:RequiredFieldValidator>  
                            <asp:RegularExpressionValidator ID="revAddress" runat="server" ControlToValidate="txtAddress" 
                ValidationExpression="^.{2,}$" ErrorMessage="Address must be at least 2 letters." Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
                        </td>  
                        <td>  
                            &nbsp;<td>  
                        </td>  
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            <asp:Label ID="Label4" runat="server" Text="City"></asp:Label>  
                        </td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtCity" runat="server" Height="22px" MaxLength="10" Width="158px"></asp:TextBox>  
                        </td>  
                        <td>  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtCity" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
&nbsp;  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCity" ErrorMessage="Please Enter your City" ForeColor="Black"></asp:RequiredFieldValidator>  
                            <asp:RegularExpressionValidator ID="revCity" runat="server" ControlToValidate="txtCity" 
                ValidationExpression="^.{2,}$" ErrorMessage="City must be at least 2 letters." Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
                        </td>  
                        <td>  
                            &nbsp;</td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            <asp:Label ID="Label5" runat="server" Text="ZipCode"></asp:Label>  
                        </td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtZipCode" runat="server" Height="22px" MaxLength="15" Width="158px"></asp:TextBox>  
                        </td>  
                        <td>  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtZipCode" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
&nbsp;  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtZipCode" ErrorMessage="(XXXXX)" ForeColor="Black"></asp:RequiredFieldValidator>  
                            <asp:RegularExpressionValidator ID="revZipCode" runat="server" ControlToValidate="txtZipCode" 
                ValidationExpression="^\d{5}$" ErrorMessage="Zip Code must be 5 digits." Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
                        </td>  
                        <td>  
                            &nbsp;</td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            Phone</td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtPhone" runat="server" Height="22px" MaxLength="15" Width="158px"></asp:TextBox>  
                        </td>  
                        <td>  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtPhone" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtPhone" ErrorMessage="(XX-XXXXXX/XXX-XXXXXXX)"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" 
                ValidationExpression="^\d{2,3}-\d{7,8}$" ErrorMessage="Phone must be in format XX-XXXXXXX or XXX-XXXXXXX." Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
                        </td>  
                    </tr>  
                    <tr>  
                        <td class="style1">  
                            <asp:Label ID="Label6" runat="server" Text="E-Mail"></asp:Label>  
                        </td>  
                        <td class="style2">  
                            <asp:TextBox ID="txtEMail" runat="server" Height="22px" MaxLength="15" Width="158px"></asp:TextBox>  
                        </td>  
                        <td>  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtEMail" ForeColor="#CC0000">*</asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEMail" 
                ValidationExpression="\w+@\w+\.\w+" ErrorMessage="Invalid email format." Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
&nbsp;&nbsp;&nbsp;
                            <asp:LinkButton ID="LinkButton1" runat="server">example@example.com</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnCheck" runat="server" Text="Check" />
                        </td>
                    </tr>  
                    <tr>  
                        <td class="style1" colspan="3">  
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
                            &nbsp;</td>  
                    </tr>                      
                </table>  
            </div>  
    </form>
</body>
</html>
