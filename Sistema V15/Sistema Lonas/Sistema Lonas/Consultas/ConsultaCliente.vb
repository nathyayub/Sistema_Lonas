﻿Public Class ConsultaCliente
    Dim objCLi As New ClsCliente
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objCLi.LocalizarFiltro(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "EMBARCACAO" Then
            Embarcacao.txtcliente.Text = DgdGrade.CurrentRow.Cells(0).Value
            Embarcacao.TxtNcli.Text = DgdGrade.CurrentRow.Cells(1).Value
        ElseIf quemChamou.ToUpper = "PEDIDOS" Then
            Pedidos.TxtCodCli.Text = DgdGrade.CurrentRow.Cells(0).Value
            Pedidos.TxtCli.Text = DgdGrade.CurrentRow.Cells(1).Value
        ElseIf quemChamou.ToUpper = "AGENDAMENTO" Then
            Agendamento.Txtcodcli.Text = DgdGrade.CurrentRow.Cells(1).Value
            Agendamento.txtnomcli.Text = DgdGrade.CurrentRow.Cells(2).Value
        Else
            Cliente.quemchamou = Me.Name
            Cliente.Show()
        End If

        quemChamou = ""
        Me.Close()
    End Sub


    Private Sub ConsultaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class