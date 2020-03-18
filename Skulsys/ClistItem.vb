Public Class CListItem

    Private m_sItemData As String
    Private m_sItemDisplay As String

    Public Sub New(ByVal sValue As String, ByVal sData As String)
        m_sItemData = sData
        m_sItemDisplay = sValue
    End Sub

    Public Overrides Function ToString() As String
        Return m_sItemDisplay
    End Function

    Public Property ItemData() As String
        Get
            Return m_sItemData
        End Get
        Set(ByVal Value As String)
            m_sItemData = Value
        End Set
    End Property

    Public Property ItemDisplay() As String
        Get
            Return m_sItemDisplay
        End Get
        Set(ByVal Value As String)
            m_sItemDisplay = Value
        End Set
    End Property

End Class