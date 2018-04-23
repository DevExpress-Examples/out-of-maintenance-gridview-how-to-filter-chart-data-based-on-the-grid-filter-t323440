@Html.DevExpress().Chart( _
    Sub(settings)
            settings.Name = "Chart"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "ChartPartial"}
            settings.Series.Add(New DevExpress.XtraCharts.Series("Products", DevExpress.XtraCharts.ViewType.Bar))
            settings.Series(0).ArgumentDataMember = "ProductName"
            settings.Series(0).ValueDataMembers(0) = "UnitPrice"
            settings.Width = 1000
            settings.Height = 600
    End Sub).Bind(Model).GetHtml()