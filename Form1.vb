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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Home screen for da app
        Dim Home As String = "Home:" & Environment.NewLine
        Home += "-------------------" & Environment.NewLine & Environment.NewLine
        Home += "1. Press the 'Set Up' button to retrive saved data" & Environment.NewLine & Environment.NewLine
        Home += "2. Press the 'Capture Data' button to save new disease" & Environment.NewLine & Environment.NewLine

        txtDisplay.Text = Home

        'Baking the file variable
        FS = New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read)
        BF = New BinaryFormatter()

        While FS.Position < FS.Length
            'Translating from the trecherous 'BITS' to useable ting
            nD += 1
            Dim TempDisease As Disease
            TempDisease = DirectCast(BF.Deserialize(FS), Disease)

            'Adding the understandable tings to the disease array
            ReDim Preserve Diseases(nD)
            Diseases(nD) = TempDisease
        End While

        FS.Close()
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
            MsgBox("No disease were made")
        End If
    End Sub

    Private Sub btnCaptureTheData_Click(sender As Object, e As EventArgs) Handles btnCaptureTheData.Click
        ReDim Preserve Diseases(nD)
        'ReDim Preserve NPopulation(nD)

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
                               " 1.Respiratory" & Environment.NewLine &
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
                objRespiratory = New Respiratory(Name, nPopulation, TotalPopulation, Treatable, PartAffected, AveCoughes)
                'Upcasting 
                txtDisplay.Text = objRespiratory.display()
                nD += 1
                Diseases(nD) = objRespiratory
            Case 2
                'Immune 
                NameOfCells = (InputBox("Please enter the name of the cells "))
                Cause = InputBox("Please enter the cause of the disease ")
                Dim objImmune As Immune
                objImmune = New Immune(Name, nPopulation, TotalPopulation, Treatable, NameOfCells, Cause)
                'Upcasting 
                txtDisplay.Text = objImmune.display()
                nD += 1
                Diseases(nD) = objImmune
            Case 3
                'Genetic 
                Dim objGenetic As Genetic
                Dim AverageAge As Double = CDbl(InputBox("Please enter the average age"))
                objGenetic = New Genetic(Name, nPopulation, TotalPopulation, Treatable, AverageAge)

                Dim GeneticTypeName As String = CStr(InputBox("Please enter the name of the genetic type."))
                Dim GeneticTypeInherited As Boolean = CBool(InputBox("is the type inherited", "TRUE OR FALSE"))
                'objGenetic.Type.Name = CStr(InputBox("Please enter the name of the genetic type."))
                'objGenetic.Type.Inherited = CBool(InputBox("is the type inherited", "TRUE OR FALSE"))
                objGenetic.Type = New GeneticType(GeneticTypeName, GeneticTypeInherited)

                'Upcasting 
                txtDisplay.Text = objGenetic.display()
                nD += 1
                Diseases(nD) = objGenetic
        End Select

        'Polymorphism 
        For i As Integer = 1 To nD
            txtDisplay.Text = Diseases(i).display()
        Next i



        FS = New FileStream(FileName, FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter

        For i As Integer = 1 To nD
            BF.Serialize(FS, Diseases(i))
            MsgBox("Saving successful")
        Next i

        FS.Close()
    End Sub

    Private Sub btnFindASolution_Click(sender As Object, e As EventArgs) Handles btnFindASolution.Click

    End Sub

End Class
