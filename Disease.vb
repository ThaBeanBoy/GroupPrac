' ***************************************************************** 
' Team Number: 20
' Team Member 1 Details: Chipoyera, TG (220150124) 
' Team Member 2 Details: Hlebela, JM (221026973) 
' Team Member 3 Details: NDHLOVU, AJ(221020749) 
' Team Member 4 Details: Ntuli, SD (221076674) 
' Practical: Team Project 
' Class name: (name of the class) 
' *****************************************************************

Option strict On
Option infer Off
Option Explicit On

<Serializable()> Public mustInherit class Disease
	Protected Shared _TotalPopulation As Integer

	Private _Name As String
	Private _numPopulation As Integer
	Private _Budget As Double
	Private _Treatable As Boolean

	Public Sub New(Name As String, PopulationSize As Integer, TotalPopulation As Integer, Treatable As Boolean)
		_TotalPopulation = TotalPopulation
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

	Public Function Improving() As String
		'The Hingher the category the more effort and money needed to 
		'Deal with this disease     
		Dim improve As String

		While calcPercPopulation() < 50

			If Treatable = True Then
				improve = "Catergory One(2) Improvement"
			ElseIf Treatable = False Then
				improve = "Category Two(2) Improvement"
			End If

		End While

		While calcPercPopulation() > 50

			If Treatable = True Then
				improve = "Catergory One(3) Improvement"
			ElseIf Treatable = False Then
				improve = "Category Two(4) Improvement"
			End If

		End While
	End Function

	Public Overridable Function calcPercPopulation() As Double
		Return (numPopulation / _TotalPopulation) * 100
	End Function

	Public Overridable Function FindCategorylevel() As Integer
		Select Case (calcPercPopulation())
			Case 0 To 49
				Return If(_Treatable, 1, 2)
			Case 50 To 70
				Return If(_Treatable, 2, 3)
			Case Else
				Return 3
		End Select
	End Function

	'Public MustOverride Function Improving() As String

	Public Overridable Function display() As String
		Dim Ans As String
		Ans = "Name: " & _Name & Environment.NewLine
		Ans &= "Population Infected: " & CStr(_numPopulation) & Environment.NewLine
		Ans &= "Budget: " & Format(Budget, "#.##") & Environment.NewLine
		Ans &= "Treatable: " & CStr(_Treatable) & Environment.NewLine
		Ans &= "Percentage of Population Infected: " & Format(calcPercPopulation(), "#.##") & Environment.NewLine
		Ans &= "Category Level: " & CStr(FindCategorylevel()) & Environment.NewLine
		'Ans &= "Condition Improving " & Improving() & Environment.NewLine
		Return Ans
	End Function

End Class