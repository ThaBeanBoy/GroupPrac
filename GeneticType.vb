' ***************************************************************** 
' Team Number: 20
' Team Member 1 Details: Chipoyera, TG (220150124) 
' Team Member 2 Details: Hlebela, JM (221026973) 
' Team Member 3 Details: NDHLOVU, AJ(221020749) 
' Team Member 4 Details: Ntuli, SD (221076674) 
' Practical: Team Project 
' Class name: GeneticType 
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer On

<Serializable()> Public Class GeneticType

    Private _Name As String
    Private _Inherited As Boolean

    Public Sub New(Name As String, Inherited As Boolean)
        _Name = Name
        _Inherited = Inherited
    End Sub

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Inherited As Boolean
        Get
            Return _Inherited
        End Get
        Set(value As Boolean)
            _Inherited = value
        End Set
    End Property

    Public Function FindLifeSpan() As Double
        Dim temp As Double
        If _Inherited = True Then
            temp = 40.5
        Else
            temp = 50.7
        End If
        Return temp
    End Function

End Class