' ***************************************************************** 
' Team Number: 20
' Team Member 1 Details: Chipoyera, TG (220150124) 
' Team Member 2 Details: Hlebela, JM (221026973) 
' Team Member 3 Details: NDHLOVU, AJ(221020749) 
' Team Member 4 Details: Ntuli, SD (221076674) 
' Practical: Team Project 
' Class name: Respiratory 
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer On

<Serializable()> Public Class Respiratory
    'Inheriting from Disease
    Inherits Disease

    'Attributes
    Private _PartAffected As String
    Private _AveNumOfCoughs As Double

    '<<Constructor>>
    Public Sub New(Name As String, PopulationInfected As Integer, TotalPopulation As Integer, Treatable As Boolean, Budget As Double, PartAffected As String, AveNumOfCoughs As Double)
        MyBase.New(Name, PopulationInfected, TotalPopulation, Treatable, Budget)
        _PartAffected = PartAffected
        _AveNumOfCoughs = AveNumOfCoughs
    End Sub

    '<<Property Methods>>
    Public Property PartAffected() As String
        Get
            Return _PartAffected
        End Get
        Set(value As String)
            _PartAffected = value
        End Set
    End Property

    Public Property AverageNumberOfCoughs() As Double
        Get
            Return _AveNumOfCoughs
        End Get
        Set(value As Double)
            _AveNumOfCoughs = value
        End Set
    End Property

    '<<Methods>>
    'Public Overrides Function Improving() As String
    '   Throw New NotImplementedException()
    'End Function

    Public Overrides Function display() As String
        Dim DType As String = "Respiratory Disease" & Environment.NewLine
        Dim OgInfo As String = MyBase.display()
        Dim PA As String = "Part Affected: " & _PartAffected & Environment.NewLine
        Dim AVNC As String = "Average number of coughs: " & Format(_AveNumOfCoughs, ".##") & Environment.NewLine

        Return DType + OgInfo + PA + AVNC & Environment.NewLine
    End Function
End Class
