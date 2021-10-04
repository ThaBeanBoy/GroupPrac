' ***************************************************************** 
' Team Number: 20
' Team Member 1 Details: Chipoyera, TG (220150124) 
' Team Member 2 Details: Hlebela, JM (221026973) 
' Team Member 3 Details: NDHLOVU, AJ(221020749) 
' Team Member 4 Details: Ntuli, SD (221076674) 
' Practical: Team Project 
' Class name: (name of the class) 
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer On

<Serializable()> Public Class Genetic
    Inherits Disease

    Private _AverageAge As Double
    Private _Type As GeneticType

    Public Sub New(Name As String, PopulationSize As Integer, Treatable As Boolean, NameOfCells As String, Cause As String)
        MyBase.New(Name, PopulationSize, Treatable)
    End Sub
    'Properties
    Public Property AverageAge As Double
        Get
            Return _AverageAge
        End Get
        Set(value As Double)
            'Since a person mostly cannot have be 0 and its rare to find someone greater tha 100
            If value < 0 Then
                _AverageAge = 1
            ElseIf value > 100 Then
                _AverageAge = 98
            Else
                _AverageAge = value
            End If
        End Set
    End Property

    Public Property Type As GeneticType
        Get
            Return _Type
        End Get
        Set(value As GeneticType)
            _Type = value
        End Set
    End Property

    Functions
    Public Function solution() As String
        Dim tempsol As String
        While calcPercPopulation() < 50
            If Type.Inherited = True Then
               tempsol = "Gene Therapy"
            ElseIf Type.Inherited = False Then
                tempsol = "Gene Modification"
            End If
        End While
        While calcPercPopulation() >= 50
            If Type.Inherited = True Then
                tempsol = "Intensive Gene Therapy"
            ElseIf Type.Inherited = False Then
                tempsol = "Advanced Gene Modification(Not Available in SA)"
            End If
        End While
        return tempsol
    End Function


    Public Overrides Function display(TotalPopulationOfCountry As Integer) As String
        Dim tempText As String
        tempText = "Genetic Disease"
        tempText &= MyBase.display(TotalPopulationOfCountry)
        tempText &= "Average Age: " & CStr(AverageAge) & Environment.NewLine
        tempText &= "Type Of gene Mutation: " & Type.Name & Environment.NewLine
        tempText &= "Inherited: " & CStr(Type.Inherited) & Environment.NewLine
        tempText &= "Life Span: " & CStr(Type.FindLifeSpan()) & " years" & Environment.NewLine
        tempText &= "Solution : " & CStr(solution()) & Environment.NewLine

        Return tempText

    End Function

End Class
