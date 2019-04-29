Public Class Employee

    Private _user_id As Integer
    Private _employee_number As Integer
    Private _username As String
    Private _password As String
    Private _fname As String
    Private _lname As String
    Private _dob As Date
    Private _address As String
    Private _city As String
    Private _province As String
    Private _postal_code As String
    Private _home_phone As String
    Private _cell_phone As String
    Private _start_date As DateTime
    Private _sin As String
    Private _hourly_pay As Double
    Private _education As String
    Private _level As Integer
    Private _status As Integer

    Sub New(ByVal employee_number, ByVal username, ByVal password, ByVal fname, ByVal lname, ByVal Dob, ByVal Address, ByVal City, ByVal Province, ByVal Postal_code, ByVal Home_phone, ByVal Cell_phone, ByVal Start_date, ByVal Sin, ByVal Hourly_pay, ByVal Education, ByVal Level, ByVal Status)
        Me._employee_number = employee_number
        Me._username = username
        Me._password = password
        Me._fname = fname
        Me._lname = lname
        Me._dob = Dob
        Me._address = Address
        Me._city = City
        Me._province = Province
        Me._postal_code = Postal_code
        Me._home_phone = Home_phone
        Me._cell_phone = Cell_phone
        Me._start_date = Start_date
        Me._sin = Sin
        Me._hourly_pay = Hourly_pay
        Me._education = Education
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

    Public Property Dob() As Date
        Get
            Return _dob
        End Get
        Set(ByVal value As Date)
            _dob = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Public Property City() As String
        Get
            Return _city
        End Get
        Set(ByVal value As String)
            _city = value
        End Set
    End Property

    Public Property Province() As String
        Get
            Return _province
        End Get
        Set(ByVal value As String)
            _province = value
        End Set
    End Property

    Public Property Postal_code() As String
        Get
            Return _postal_code
        End Get
        Set(ByVal value As String)
            _postal_code = value
        End Set
    End Property

    Public Property Home_phone() As String
        Get
            Return _home_phone
        End Get
        Set(ByVal value As String)
            _home_phone = value
        End Set
    End Property


    Public Property Cell_phone() As String
        Get
            Return _cell_phone
        End Get
        Set(ByVal value As String)
            _cell_phone = value
        End Set
    End Property

    Public Property Start_date() As DateTime
        Get
            Return _start_date
        End Get
        Set(ByVal value As DateTime)
            _start_date = value
        End Set
    End Property

    Public Property Sin() As String
        Get
            Return _sin
        End Get
        Set(ByVal value As String)
            _sin = value
        End Set
    End Property

    Public Property Hourly_pay() As Double
        Get
            Return _hourly_pay
        End Get
        Set(ByVal value As Double)
            _hourly_pay = value
        End Set
    End Property

    Public Property Education() As String
        Get
            Return _education
        End Get
        Set(ByVal value As String)
            _education = value
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
