Imports System.Web.Mvc

Public Class HomeController
    Inherits Controller

    ' GET: /Home
    Function Index() As ActionResult
        Return View()
    End Function
End Class