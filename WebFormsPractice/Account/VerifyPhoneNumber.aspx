﻿<%@ Page Title="Verificar número de telefone" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerifyPhoneNumber.aspx.cs" Inherits="WebFormsPractice.Account.VerifyPhoneNumber" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>
        <div>
            <h4>Digite o código de verificação</h4>
            <hr />
            <asp:HiddenField runat="server" ID="PhoneNumber" />
            <asp:ValidationSummary runat="server" CssClass="text-danger" />
            <div class="row">
                <asp:Label runat="server" AssociatedControlID="Code" CssClass="col-md-2 col-form-label">Código</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="Code" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Code"
                        CssClass="text-danger" ErrorMessage="O campo Código é obrigatório." />
                </div>
            </div>
            <div class="row">
                <div class="offset-md-2 col-md-10">
                    <asp:Button runat="server" OnClick="Code_Click"
                        Text="Enviar" CssClass="btn btn-outline-dark" />
                </div>
            </div>
        </div>
    </main>
</asp:Content>
