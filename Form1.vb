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
Option Infer Off
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class Form1
    'Variables for form
    Private nD As Integer = 0
    Private Diseases(nD) As Disease

    'Variables for file tings
    Private FS As FileStream
    Private BF As BinaryFormatter
    Private Const FileName As String = "Diseasefile.txt"

    'Baking the file variables
    Private Sub GetDiseases()
        FS = New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read)
        BF = New BinaryFormatter()

        While FS.Position < FS.Length
            'Translating from the trecherous 'BITS' to useable ting
            Dim TempDisease As Disease
            TempDisease = DirectCast(BF.Deserialize(FS), Disease)

            'Adding the understandable tings to the disease array
            nD += 1
            ReDim Preserve Diseases(nD)
            Diseases(nD) = TempDisease
        End While

        FS.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDiseases()

        'Home screen for da app
        Dim Home As String = "Home:" & Environment.NewLine
        Home += "-------------------" & Environment.NewLine & Environment.NewLine
        Home += "1. Press the 'Set Up' button to retrive saved data" & Environment.NewLine & Environment.NewLine
        Home += "2. Press the 'Capture Data' button to save new disease" & Environment.NewLine & Environment.NewLine
        Home += "3. Press the ''Correlation' button to see if there is a correlation" & Environment.NewLine

        txtDisplay.Text = Home

    End Sub

    Private Sub btnSetUpTheApplication_Click(sender As Object, e As EventArgs) Handles btnSetUpTheApplication.Click
        If Not (nD = 0) Then
            'Clearing the display screen
            txtDisplay.Text = ""

            'Downcasting the diseases
            Dim AllDiseaseInfo As String = ""
            For DiseaseIndx As Integer = 1 To nD
                If Not (TryCast(Diseases(DiseaseIndx), Genetic) Is Nothing) Then
                    'Is a genetic disease
                    Dim Genetic As Genetic = DirectCast(Diseases(DiseaseIndx), Genetic)
                    AllDiseaseInfo += Genetic.display()
                ElseIf Not (TryCast(Diseases(DiseaseIndx), Respiratory) Is Nothing) Then
                    'Is a resparitory disease
                    Dim Respiratory As Respiratory = DirectCast(Diseases(DiseaseIndx), Respiratory)
                    AllDiseaseInfo += Respiratory.display()
                Else
                    'Is a Immune disease
                    Dim Immune As Immune = DirectCast(Diseases(DiseaseIndx), Immune)
                    AllDiseaseInfo += Immune.display()
                End If
            Next

            'Displaying the diseases
            txtDisplay.Text = AllDiseaseInfo
        Else
            MsgBox("No disease were made or in file")
        End If
    End Sub

    Private Sub btnCaptureTheData_Click(sender As Object, e As EventArgs) Handles btnCaptureTheData.Click
        Dim Name As String
        Dim nPopulation As Integer 'My own thin 
        Dim Budget As Double
        Dim Treatable As Boolean
        Dim choice As Integer
        Dim PartAffected As String
        Dim AveCoughes As Double
        Dim TotalPopulation As Integer
        Dim NameOfCells As String
        Dim Cause As String

        choice = CInt(InputBox("Please select the type of disease" & Environment.NewLine &
                               "1.Respiratory" & Environment.NewLine &
                               "2.Immune" & Environment.NewLine &
                               "3.Genetic"))

        Name = InputBox("Please enter the name of the disease ?")
        Budget = CInt(InputBox("Please enter the budget available for the disease?"))
        nPopulation = CInt(InputBox("Please enter the amount of people affected by the disease")) 'My own thing 
        Treatable = CBool(InputBox("Is the disease treatable", "TRUE OR FALSE"))
        TotalPopulation = CInt(InputBox("Please enter the total population."))




        Select Case choice
            Case 1
                'Resperitory 
                PartAffected = InputBox("Please enter the part affrected by the disease?")
                AveCoughes = CDbl(InputBox("Please enter the average coughes  "))

                Dim objRespiratory As Respiratory
                objRespiratory = New Respiratory(Name, nPopulation, TotalPopulation, Treatable, Budget, PartAffected, AveCoughes)

                txtDisplay.Text = "Newest Disease:" & Environment.NewLine & Environment.NewLine & objRespiratory.display()

                'Upcasting 
                nD += 1
                ReDim Preserve Diseases(nD)
                Diseases(nD) = objRespiratory
            Case 2
                'Immune 
                NameOfCells = (InputBox("Please enter the name of the cells "))
                Cause = InputBox("Please enter the cause of the disease ")
                Dim objImmune As Immune
                objImmune = New Immune(Name, nPopulation, TotalPopulation, Treatable, Budget, NameOfCells, Cause)

                txtDisplay.Text = "Newest Disease:" & Environment.NewLine & Environment.NewLine & objImmune.display()

                'Upcasting 
                nD += 1
                ReDim Preserve Diseases(nD)
                Diseases(nD) = objImmune
            Case 3
                'Genetic 
                Dim objGenetic As Genetic
                Dim objGeneticType As GeneticType

                Dim GeneticTypeName As String = CStr(InputBox("Please enter the name of the genetic type."))
                Dim GeneticTypeInherited As Boolean = CBool(InputBox("is the type inherited", "TRUE OR FALSE"))
                objGeneticType = New GeneticType(GeneticTypeName, GeneticTypeInherited)

                Dim AverageAge As Double = CDbl(InputBox("Please enter the average age"))
                objGenetic = New Genetic(Name, nPopulation, TotalPopulation, Treatable, Budget, AverageAge, objGeneticType)

                txtDisplay.Text = "Newest Disease:" & Environment.NewLine & Environment.NewLine & objGenetic.display()

                'Upcasting
                nD += 1
                ReDim Preserve Diseases(nD)
                Diseases(nD) = objGenetic
        End Select

        FS = New FileStream(FileName, FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter()

        For i As Integer = 1 To nD
            BF.Serialize(FS, Diseases(i))
        Next i

        FS.Close()
    End Sub

    Private Sub btnFindASolution_Click(sender As Object, e As EventArgs) Handles btnFindASolution.Click
        'To Find The solution Would be based on the classes of diseases That ranked top 3
        If nD >= 3 Then
            Dim HighestInfectedPercs(3) As Disease
            Dim DiseaseQualifier() As Disease = Diseases

            Dim Highest As Integer = HighestInfPerc(DiseaseQualifier)
            HighestInfectedPercs(1) = DiseaseQualifier(Highest)
            MsgBox(HighestInfectedPercs(1).Name & " at " & HighestInfectedPercs(1).calcPercPopulation())
            FilterOut(DiseaseQualifier, Highest)

            Highest = HighestInfPerc(DiseaseQualifier)
            HighestInfectedPercs(2) = DiseaseQualifier(Highest)
            MsgBox(HighestInfectedPercs(2).Name & " at " & HighestInfectedPercs(2).calcPercPopulation())
            FilterOut(DiseaseQualifier, Highest)

            Highest = HighestInfPerc(DiseaseQualifier)
            HighestInfectedPercs(3) = DiseaseQualifier(Highest)

            'If all the disease are of the same disease type, msgbox the name of the disease type
            'MsgBox("Highest in order")
            'MsgBox(HighestInfectedPercs(1).Name & " at " & HighestInfectedPercs(1).calcPercPopulation())
            'MsgBox(HighestInfectedPercs(2).Name & " at " & HighestInfectedPercs(2).calcPercPopulation())
            'MsgBox(HighestInfectedPercs(3).Name & " at " & HighestInfectedPercs(3).calcPercPopulation())

            If Not (TryCast(HighestInfectedPercs(1), Immune) Is Nothing) And Not (TryCast(HighestInfectedPercs(2), Immune) Is Nothing) And Not (TryCast(HighestInfectedPercs(3), Immune) Is Nothing) Then
                MsgBox("The top 3 diseases are all Immune diseases")
            ElseIf Not (TryCast(HighestInfectedPercs(1), Genetic) Is Nothing) And Not (TryCast(HighestInfectedPercs(2), Genetic) Is Nothing) And Not (TryCast(HighestInfectedPercs(3), Genetic) Is Nothing) Then
                MsgBox("The top 3 diseases are all Genetic diseases")
            ElseIf Not (TryCast(HighestInfectedPercs(1), Respiratory) Is Nothing) And Not (TryCast(HighestInfectedPercs(2), Respiratory) Is Nothing) And Not (TryCast(HighestInfectedPercs(3), Respiratory) Is Nothing) Then
                MsgBox("The top 3 diseases are all Respiratory diseases")
            Else
                MsgBox("No correlation found")
            End If
        Else
            MsgBox("You must have 3 or more diseases to find a correlation")
        End If
    End Sub

    Private Sub FilterOut(ByRef Arry() As Disease, IndexToFilter1 As Integer)
        Dim FilteredArray() As Disease

        Dim FilteredAnElement As Boolean = False

        For i As Integer = 1 To Arry.Length - 1
            If Not (i = IndexToFilter1) Then
                Dim IndxInFilterdArr As Integer = If(FilteredAnElement, i - 1, i)
                ReDim Preserve FilteredArray(IndxInFilterdArr)
                FilteredArray(IndxInFilterdArr) = Diseases(i)
            Else
                FilteredAnElement = True
            End If
        Next i

        Arry = FilteredArray
    End Sub

    Private Function HighestInfPerc(Arr() As Disease) As Integer
        Dim HighestIndx As Integer = 1

        For i As Integer = 1 To Arr.Length - 1
            If Diseases(HighestIndx).calcPercPopulation() < Diseases(i).calcPercPopulation() Then
                HighestIndx = i
            End If
        Next i

        Return HighestIndx
    End Function

End Class
