'***********************************
'Practical :08
'Student Id : 221026973
'Class Name: Disease
'***********************************

Option strict On
Option infer Off
Option Explicit On

<Serializable()> Public mustInherit class Disease

	Private _Name As String
	Private _numPopulation As Integer
	Private _Budget As Double
	Private _Treatable As Boolean

	Public Sub New(Name As String, PopulationSize As Integer, Treatable As Boolean)
		_Name = Name
		_numPopulation = PopulationSize
		_Treatable = Treatable
	End Sub

	Public ReadOnly Property Name() As String
		Get
			Return _Name
		End Get
	End Property

	Public Property numPopulation() As Integer
		Get
			Return _numPopulation
		End Get
		Set(value As Integer)
			If value < 0 Then
				_numPopulation = 0
			Else
				_numPopulation = value
			End If
		End Set
	End Property

	Public Property Budget() As Double
		Get
			Return _Budget
		End Get
		Set(Value As Double)
			If Value < 0 Then
				_Budget = 0
			Else
				_Budget = Value
			End If
		End Set
	End Property

	Public Property Treatable() As Boolean
		Get
			Return _Treatable
		End Get
		Set(Value As Boolean)
			_Treatable = Value
		End Set
	End Property

	Public Overridable Function calcPercPopulation(Value As Integer) As Double
		Return (numPopulation / Value) * 100
	End Function

	Public Overridable Function FindCategorylevel(TotalPopulationOfCountry As Integer) As Integer
		Select Case (calcPercPopulation(TotalPopulationOfCountry))
			Case 0 To 49
				Return If(_Treatable, 1, 2)
			Case 50 To 70
				Return If(_Treatable, 2, 3)
			Case Else
				Return 3
		End Select
	End Function

	'Public MustOverride Function Improving() As String

	Public Overridable Function display(TotalPopulationOfCountry As Integer) As String
		Dim Ans As String
		Ans = "Name: " & _Name & Environment.NewLine
		Ans &= "Population Infected: " & CStr(_numPopulation) & Environment.NewLine
		Ans &= "Budget: " & Format(Budget, "#.##") & Environment.NewLine
		Ans &= "Treatable: " & CStr(_Treatable) & Environment.NewLine
		Ans &= "Percentage of Population Infected: " & Format(calcPercPopulation(TotalPopulationOfCountry), "#.##") & Environment.NewLine
		Ans &= "Category Level: " & CStr(FindCategorylevel(TotalPopulationOfCountry)) & Environment.NewLine
		'Ans &= "Condition Improving " & Improving() & Environment.NewLine
		Return Ans
	End Function

End Class