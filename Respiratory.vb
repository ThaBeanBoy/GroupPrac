'***********************************
'Surname, Initial: Chipoyera TG
'Practical :08
'Student Id : 220150124
'Class Name: Immune
'***********************************

Option Strict On
Option Explicit On
Option Infer On

Public Class Respiratory
    'Inheriting from Disease
    Inherits Disease

    'Attributes
    Private _PartAffected As String
    Private _AveNumOfCoughs As Double

    '<<Constructor>>
    Public Sub New(Name As String, PopulationSize As Integer, Treatable As Boolean, PartAffected As String, AveNumOfCoughs As Double)
        MyBase.New(Name, PopulationSize, Treatable)
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
    Public Overrides Function display(TotalPopulationOfCountry As Integer) As String
        Dim OgInfo As String = MyBase.display(TotalPopulationOfCountry)
        Dim PA As String = "Part Affected: " & _PartAffected & Environment.NewLine
        Dim AVNC As String = "Average number of coughs: " & Format(_AveNumOfCoughs, ".##") & Environment.NewLine

        Return OgInfo + PA + AVNC
    End Function
End Class
