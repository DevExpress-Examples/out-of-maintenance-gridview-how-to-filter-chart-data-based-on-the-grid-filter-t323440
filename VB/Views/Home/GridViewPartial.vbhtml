@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "GridView"
            settings.KeyFieldName = "ProductID"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
            settings.Columns.Add("ProductID")
            settings.Columns.Add("ProductName")
            settings.Columns.Add("UnitPrice")
            settings.Columns.Add("UnitsOnOrder")
            settings.Settings.ShowFilterRow = True
            settings.CustomJSProperties = _
                Sub(s, e)
                        Dim gridView As MVCxGridView = CType(s, MVCxGridView)
                        e.Properties("cpFilterExpression") = gridView.FilterExpression
                End Sub
            settings.ClientSideEvents.EndCallback = "function(s, e) { Chart.PerformCallback({ filterExpression: s.cpFilterExpression }); }"
    End Sub).Bind(Model).GetHtml()