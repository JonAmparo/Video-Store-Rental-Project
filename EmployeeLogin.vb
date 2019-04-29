Public Class EmployeeLogin

    Private _user_id As Integer
    Private _employee_number As Integer
    Private _username As String
    Private _password As String
    Private _fname As String
    Private _lname As String
    Private _level As Integer
    Private _status As Integer

    Sub New(ByVal user_id, ByVal employee_number, ByVal username, ByVal password, ByVal fname, ByVal lname, ByVal Level, ByVal Status)
        Me._user_id = user_id
        Me._employee_number = employee_number
        Me._username = username
        Me._password = password
        Me._fname = fname
        Me._lname = lname
        Me._level = Level
        Me._status = Status
    End Sub

    Public Property User_id() As Integer
        Get
            Return _user_id
        End Get
        Set(ByVal value As Integer)
            _user_id = value
        End Set
    End Property

    Public Property Employee_number() As Integer
        Get
            Return _employee_number
        End Get
        Set(ByVal value As Integer)
            _employee_number = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Public Property Fname() As String
        Get
            Return _fname
        End Get
        Set(ByVal value As String)
            _fname = value
        End Set
    End Property

    Public Property Lname() As String
        Get
            Return _lname
        End Get
        Set(ByVal value As String)
            _lname = value
        End Set
    End Property

    Public Property Level() As Integer
        Get
            Return _level
        End Get
        Set(ByVal value As Integer)
            _level = value
        End Set
    End Property

    Public Property Status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal value As Integer)
            _status = value
        End Set
    End Property

End Class
