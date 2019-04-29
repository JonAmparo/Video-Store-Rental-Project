Public Class Client

    Private _client_id As Integer
    Private _client_number As Integer
    Private _fname As String
    Private _lname As String
    Private _email As String
    Private _phone As String
    Private _dob As Date
    Private _address As String
    Private _city As String
    Private _province As String
    Private _postal_code As String
    Private _status As Integer

    Sub New(ByVal client_number, ByVal fname, ByVal lname, ByVal Email, ByVal Phone, ByVal Dob, ByVal Address, ByVal City, ByVal Province, ByVal Postal_code, ByVal Status)
        Me._client_number = client_number
        Me._fname = fname
        Me._lname = lname
        Me._email = Email
        Me._phone = Phone
        Me._dob = Dob
        Me._address = Address
        Me._city = City
        Me._province = Province
        Me._postal_code = Postal_code
        Me._status = Status
    End Sub

    Public Property Client_id() As Integer
        Get
            Return _client_id
        End Get
        Set(ByVal value As Integer)
            _client_id = value
        End Set
    End Property

    Public Property Client_number() As Integer
        Get
            Return _client_number
        End Get
        Set(ByVal value As Integer)
            _client_number = value
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

    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return _phone
        End Get
        Set(ByVal value As String)
            _phone = value
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

    Public Property Status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal value As Integer)
            _status = value
        End Set
    End Property

End Class
