Imports System.Web.Mvc
Imports DevExpress.Data.Filtering

Namespace GridViewChartFilterWeb.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function GridViewPartial() As ActionResult
			Return PartialView(NorthwindDataProvider.GetProducts(Nothing))
		End Function
		Public Function ChartPartial(ByVal filterExpression As String) As ActionResult
			Dim accessFilter As String = CriteriaToWhereClauseHelper.GetAccessWhere(CriteriaOperator.Parse(filterExpression))
			Return PartialView(NorthwindDataProvider.GetProducts(accessFilter))
		End Function
	End Class
End Namespace
