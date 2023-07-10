Imports System.Data.OleDb

Public Class Form1
    Private Sub btnPublishers_Click(sender As Object, e As EventArgs) Handles btnPublishers.Click

        Dim publisher As String = txtPublisher.Text
        Dim sqlStatement As String = ""
        Dim connectionString As String = "Provider = Microsoft.Ace.OLEDB.12.0;" & "Data Source = C:\Users\Mason PC\OneDrive\Documents\Visual Basic Complete Class\COMP 9\Lab 6 Database Project\Books.mdb"
        sqlStatement = "SELECT Publisher.PubName, Book.BookName, Book.BookAuthor " &
        "FROM (Publisher " &
        "INNER JOIN Publishes ON Publisher.PubID = Publishes.PubID) " &
        "INNER JOIN Book On Book.BookID = Publishes.BookID " &
        "WHERE Publisher.PubName = '" & publisher & "'"

        Dim dtProperties As New DataTable
        Dim dbDataAdpater As OleDbDataAdapter
        dbDataAdpater = New OleDbDataAdapter(sqlStatement, connectionString)
        dbDataAdpater.Fill(dtProperties)

        DataGridView1.DataSource = dtProperties
    End Sub

    Private Sub btn1905_Click(sender As Object, e As EventArgs) Handles btn1905.Click

        Dim year As Integer = 1905
        Dim sqlStatement As String = ""
        Dim connectionString As String = "Provider = Microsoft.Ace.OLEDB.12.0;" & "Data Source = C:\Users\Mason PC\OneDrive\Documents\Visual Basic Complete Class\COMP 9\Lab 6 Database Project\Books.mdb"
        sqlStatement = "SELECT Book.BookName, Book.BookAuthor " &
        "FROM Book " &
        "WHERE Book.BookEditionYear = " & year & ";"

        Dim dtProperties As New DataTable
        Dim dbDataAdpater As OleDbDataAdapter
        dbDataAdpater = New OleDbDataAdapter(sqlStatement, connectionString)
        dbDataAdpater.Fill(dtProperties)

        DataGridView1.DataSource = dtProperties
    End Sub
End Class
