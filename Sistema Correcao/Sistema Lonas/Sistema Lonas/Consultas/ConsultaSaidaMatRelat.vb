﻿Public Class ConsultaSaidaMatRelat
    Dim objentsai As New ClsSaidaDeMaterial

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        DgdGrade.DataSource = objentsai.Localizar_porData(DtpIni.Text, DtpFin.Text)
    End Sub


    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Dim rpt As New CrpSaidaMat
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Saída de Materiais"
        rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub ConsultaSaidaMatRelat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class