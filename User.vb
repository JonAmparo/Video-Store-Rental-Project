Public Class User
    Private _displayColumns As String
    Private _displayRows As String

    Public Property DisplayColumns() As String
        Get
            Return _displayColumns
        End Get
        Set(ByVal value As String)
            _displayColumns = value
        End Set
    End Property

    Public Property DisplayRows() As String
        Get
            Return _displayRows
        End Get
        Set(ByVal value As String)
            _displayRows = value
        End Set
    End Property
End Class
