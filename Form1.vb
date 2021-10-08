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
    Private Diseases() As Disease
    Private nD As Integer
    Private FS As FileStream
    Private BF As BinaryFormatter

    Private Sub btnSetUpTheApplication_Click(sender As Object, e As EventArgs) Handles btnSetUpTheApplication.Click
        'nD += 1
        'ReDim Preserve Diseases(nD)
        'ReDim Preserve NPopulation(nD)

        'For c As Integer = 1 To nD
        '    Diseases(nD) = New Disease()
        '    Diseases(nD).numPopulation = CInt(InputBox("Please enter the population size in the Area?"))

        'Next c

    End Sub

    Private Sub btnCaptureTheData_Click(sender As Object, e As EventArgs) Handles btnCaptureTheData.Click
        nD += 1
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
                Diseases(nD) = objRespiratory
            Case 2
                'Immune 
                NameOfCells = (InputBox("Please enter the name of the cells "))
                Cause = InputBox("Please enter the cause of the disease ")
                Dim objImmune As Immune
                objImmune = New Immune(Name, nPopulation, TotalPopulation, Treatable, NameOfCells, Cause)
                'Upcasting 
                Diseases(nD) = objImmune
            Case 3
                'Genetic 
                Dim objGenetic As Genetic
                Dim AverageAge As Double = CDbl(InputBox("Please enter the average age"))
                objGenetic = New Genetic(Name, nPopulation, TotalPopulation, Treatable, AverageAge)
                objGenetic.Type.Name = CStr(InputBox("Please enter the name of the genetic type."))
                objGenetic.Type.Inherited = CBool(InputBox("is the type inherited", "TRUE OR FALSE"))

                'Upcasting 
                Diseases(nD) = objGenetic

        End Select

        'Polymorphism 
        For i As Integer = 1 To nD
            txtDisplay.Text = Diseases(i).display()
        Next i



        FS = New FileStream("Diseasefile.txt", FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter

        For i As Integer = 1 To nD
            BF.Serialize(FS, Diseases(i))
            MsgBox("Saving successful")
        Next i

        FS.Close()
    End Sub

    Private Sub btnFindASolution_Click(sender As Object, e As EventArgs) Handles btnFindASolution.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
