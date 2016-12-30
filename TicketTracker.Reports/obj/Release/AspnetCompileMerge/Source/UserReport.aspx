<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserReport.aspx.cs" Inherits="TicketTracker.Reports.UserReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="frmMain" runat="server">
    <div>
        <p>
            <asp:Label ID="lblFirstName" runat="server"></asp:Label>,
        </p>
        <p>
            We have created a new ticket for the following request: <asp:Label ID="lblTicketSubject" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <p>
            The ticket has been given the following priority level: <asp:Label ID="lblPriorityLevel" runat="server" Font-Bold="True"></asp:Label>
            <br />
            The ticket has been given the following target date: <asp:Label ID="lblTargetDate" runat="server" Font-Bold="True"></asp:Label>
        </p>
        <p>
            Please let us know if there is anything else we can do for you!
        </p>
        <p>
            Regards,
            <br />
            <br />
            IT Department
            <br />
            Pension Consultants, Inc.
        </p>
    </div>
    </form>
</body>
</html>
