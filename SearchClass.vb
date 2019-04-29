Public Class SearchClass
    Private _videoID As String
    Private _title As String
    Private _genre As String
    Private _year As String
    Private _language As String
    Private _country As String
    Private _length As String
    Private _director As String
    Private _actors As String
    Private _resume As String


    Public Property ResumeVideo() As String
        Get
            Return _resume
        End Get
        Set(ByVal value As String)
            _resume = value
        End Set
    End Property

    Public Property Actors() As String
        Get
            Return _actors
        End Get
        Set(ByVal value As String)
            _actors = value
        End Set
    End Property

    Public Property Director() As String
        Get
            Return _director
        End Get
        Set(ByVal value As String)
            _director = value
        End Set
    End Property

    Public Property Length() As String
        Get
            Return _length
        End Get
        Set(ByVal value As String)
            _length = value
        End Set
    End Property

    Public Property Country() As String
        Get
            Return _country
        End Get
        Set(ByVal value As String)
            _country = value
        End Set
    End Property

    Public Property Language() As String
        Get
            Return _language
        End Get
        Set(ByVal value As String)
            _language = value
        End Set
    End Property

    Public Property Year() As String
        Get
            Return _year
        End Get
        Set(ByVal value As String)
            _year = value
        End Set
    End Property

    Public Property Genre() As String
        Get
            Return _genre
        End Get
        Set(ByVal value As String)
            _genre = value
        End Set
    End Property


    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property


    Public Property VideoID() As String
        Get
            Return _videoID
        End Get
        Set(ByVal value As String)
            _videoID = value
        End Set
    End Property

End Class
