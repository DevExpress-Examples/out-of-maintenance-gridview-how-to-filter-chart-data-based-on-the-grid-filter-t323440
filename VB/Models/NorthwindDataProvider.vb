Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.Configuration

Public Class NorthwindDataProvider
	Public Shared Function GetProducts(ByVal filter As String) As IEnumerable
		Dim products As New List(Of Product)()

		Using connection As New OleDbConnection(WebConfigurationManager.ConnectionStrings("Northwind").ConnectionString)
            Dim commandText As String = String.Format("SELECT * FROM Products {0} {1} ORDER BY ProductID", IIf(String.IsNullOrEmpty(filter), "", "WHERE"), filter)

			Dim selectCommand As New OleDbCommand(commandText, connection)

			connection.Open()

			Dim reader As OleDbDataReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection)

			Do While reader.Read()
                products.Add(New Product() With {.ProductID = DirectCast(reader("ProductID"), Integer), .ProductName = DirectCast(reader("ProductName"), String), .UnitPrice = (If(reader("UnitPrice") Is DBNull.Value, Nothing, DirectCast(reader("UnitPrice"), Decimal?))), .UnitsOnOrder = (If(reader("UnitsOnOrder") Is DBNull.Value, Nothing, DirectCast(reader("UnitsOnOrder"), Short?)))})
			Loop

			reader.Close()
		End Using

		Return products
	End Function
End Class