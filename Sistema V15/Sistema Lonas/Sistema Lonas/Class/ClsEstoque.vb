﻿Public Class ClsEstoque

    Dim sql As String
    Dim objbanco As New ClsBanco
    Dim objdtLocal As New DataTable

    Public Function LocalizarFiltro(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "select * from vwestoque where codigo=" & campo
        Else
            sql = "select * from vwestoque where codigo like '" & campo & "%' order by produto"
        End If
        objdtLocal = objbanco.localizar(Sql)
        Return objdtLocal
    End Function
End Class
