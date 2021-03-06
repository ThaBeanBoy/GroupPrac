' ***************************************************************** 
' Team Number: 20
' Team Member 1 Details: Chipoyera, TG (220150124) 
' Team Member 2 Details: Hlebela, JM (221026973) 
' Team Member 3 Details: NDHLOVU, AJ(221020749) 
' Team Member 4 Details: Ntuli, SD (221076674) 
' Practical: Team Project 
' Class name: Immune 
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer On

<Serializable()> Public Class Immune
    'Inherting from Disease class
    Inherits Disease

    'Attributes
    Private _NameOfCells As String
    Private _Cause As String

    '<<Constructor>>
    Public Sub New(Name As String, PopulationInfected As Integer, TotalPopulation As Integer, Treatable As Boolean, Budget As Double, NameOfCells As String, Cause As String)
        MyBase.New(Name, PopulationInfected, TotalPopulation, Treatable, Budget)
        _NameOfCells = NameOfCells
        _Cause = Cause
    End Sub

    '<<Property Methods>>
    Public Property NameOfCells As String
        Get
            Return _NameOfCells
        End Get
        Set(value As String)
            _NameOfCells = value
        End Set
    End Property

    Public Property Cause As String
        Get
            Return _Cause
        End Get
        Set(value As String)
            _Cause = value
        End Set
    End Property

    '<<Methods>>
    'Public Overrides Function Improving() As String
    '   Throw New NotImplementedException()
    'End Function

    Public Overrides Function display() As String
        Dim DType As String = "Immune Disease" & Environment.NewLine
        Dim OGInfo As String = MyBase.display()
        Dim NameOfCells As String = "Name of cells: " & _NameOfCells & Environment.NewLine
        Dim Cause As String = "Cause: " & _Cause & Environment.NewLine

        Return DType + OGInfo + NameOfCells + Cause & Environment.NewLine
    End Function
End Class
