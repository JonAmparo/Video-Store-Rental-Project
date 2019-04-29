Public Class Video
    Private _video_id As Integer
    Private _photo As String
    Private _title As String
    Private _year As String
    Private _country As String
    Private _language As String
    Private _length As Integer
    Private _resume As String
    Private _genre As String
    Private _actors As String
    Private _director As String
    Private _status As Integer

    Sub New(ByVal Photo, ByVal Title, ByVal Year, ByVal Country, ByVal Language, ByVal Length, ByVal ResumeVideo, ByVal Genre, ByVal Actors, ByVal Director, ByVal Status)
        Me._photo = Photo
        Me._title = Title
        Me._year = Year
        Me._country = Country
        Me._language = Language
        Me._length = Length
        Me._resume = ResumeVideo
        Me._genre = Genre
        Me._actors = Actors
        Me._director = Director
        Me._status = Status
    End Sub

    Public Property Video_id() As Integer
        Get
            Return _video_id
        End Get
        Set(ByVal value As Integer)
            _video_id = value
        End Set
    End Property

    Public Property Photo() As String
        Get
            Return _photo
        End Get
        Set(ByVal value As String)
            _photo = value
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

    Public Property Year() As String
        Get
            Return _year
        End Get
        Set(ByVal value As String)
            _year = value
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

    Public Property Length() As Integer
        Get
            Return _length
        End Get
        Set(ByVal value As Integer)
            _length = value
        End Set
    End Property

    Public Property ResumeVideo() As String
        Get
            Return _resume
        End Get
        Set(ByVal value As String)
            _resume = value
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

    Public Property Status() As Integer
        Get
            Return _status
        End Get
        Set(ByVal value As Integer)
            _status = value
        End Set
    End Property

End Class
