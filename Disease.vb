' Surname , Initials : Hlebela ,JM
'Practical :08
'Student Id : 221026973
'Class Name: Disease


Option strict On
Option infer off
Option Explicit on
<Serializable()> Public mustInherit class Disease

	Private _Name As String
	Private _numPopulation As Integer
	Private _Budget As Double
	Private _Treatable As Boolean

	Public Sub New(Name As String, PopulationSize As Integer)
		_Name = Name
		_numPopulation = PopulationSize
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

	Public Property Budget As Double
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

	Public Property Treatable As Boolean
		Get
			Return _Treatable
		End Get
		Set(Value As Boolean)
			_Treatable = Value
		End Set
	End Property

	Public MustOverride Function calcPercPopulation() As Double

	Public MustOverride Function FindCategorylevel() As Integer

	Public MustOverride Function Improving() As String

	Public Overridable Function display() As String
		Dim Ans As String
		Ans = "Name: " & _Name & Environment.NewLine
		Ans &= "Population Infected: " & CStr(_numPopulation) & Environment.NewLine
		Ans &= "Budget: " & Format(Budget, "#.##") & Environment.NewLine
		Ans &= "Treatable: " & CStr(_Treatable) & Environment.NewLine
		Ans &= "Percentage of Population Infected: " & Format(calcPercPopulation(), "#.##") & Environment.NewLine
		Ans &= "Category Level: " & CStr(FindCategorylevel()) & Environment.NewLine
		Ans &= "Condition Improving " & Improving() & Environment.NewLine
		Return Ans
	End Function

End Class