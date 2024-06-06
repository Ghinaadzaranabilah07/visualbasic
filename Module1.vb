Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public X As Integer
    Public S As String = ""
    Public T As String = ""
    Public OLECMD As OleDbCommand
    Public OLERDR As OleDbDataReader
    Public CNN As OleDbConnection
    Public koneksi As String = "Provider=microsoft.ACE.OLEDB.12.0;Data Source=" & _
    Application.StartupPath & "\ADOGaji.accdb;"
End Module
