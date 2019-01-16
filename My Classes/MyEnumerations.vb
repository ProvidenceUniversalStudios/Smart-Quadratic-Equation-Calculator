Imports System.IO
Imports System.Numerics

Public Class MyEnumerations
    Implements IDisposable
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

    'Function to validate Textbox input
    Public Function ValTextInput(ByRef txt2validate As String, ByVal txt2 As String, ByVal txt3 As String, Optional ByRef label As String = Nothing) As Integer
        If txt2validate = "" Then
            label = "Enter your values above"
            If txt2 = "" Or txt3 = "" Then
                ValTextInput = 0
            End If
        Else
            If IsNumeric(txt2validate) = False And txt2validate <> Nothing = True Then
                MessageBox.Show("Please enter a numeric value only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                label = "Enter your values above"
                ValTextInput = 1
            Else
                If txt2 = "" Or txt3 = "" Then
                    label = "Enter your values above"
                    ValTextInput = 0
                Else
                    ValTextInput = 2
                End If
            End If
        End If
        Return ValTextInput
    End Function
    'Sub to store answers in arraylist and listview
    Public Sub StoreMathDisplayinListView(ByVal Listview As ListView, ByVal equation As String, ByVal roots As String, ByRef StoreMath As ArrayList, ByVal factors As String)
        Try
            Dim listviewitem As New ListViewItem(equation)
            listviewitem.SubItems.Add(roots)
            listviewitem.SubItems.Add(factors)
            Listview.Items.Add(listviewitem)
            StoreMath.Add(equation & ":" & roots & ":" & factors)
        Catch ind As IndexOutOfRangeException
        End Try
    End Sub
    'Sub to produce the quadratic expression
    Public Sub ProduceEquation(ByVal numA As Double, ByVal numB As Double, ByVal numC As Double, ByRef Equation As String)

        'Initialisation of variables

        Dim aval, bval, cval As String
        aval = numA & "x" & (ChrW(&HB2)).ToString
        bval = " + " & numB & "x".ToString
        cval = " + " & numC.ToString
        Equation = aval & bval & cval & " = 0"

        ' For numA

        If numA = 1 Then
            aval = "x" & (ChrW(&HB2))
            Equation = aval & bval & cval & " = 0"
        ElseIf Math.Sign(numA) = -1 Then
            If numA = -1 Then
                aval = "– x" & (ChrW(&HB2))
                Equation = aval & bval & cval & " = 0"
            Else
                aval = "– " & numA * -1 & "x" & (ChrW(&HB2)).ToString
                Equation = aval & bval & cval & " = 0"
            End If
        End If

        'For numB

        If numB = 1 Then
            bval = " + x "
            Equation = aval & bval & cval & " = 0"
        ElseIf Math.Sign(numB) = -1 Then
            If numB = -1 Then
                bval = " – x "
                Equation = aval & bval & cval & " = 0"
            ElseIf numB = 0 Then
                Equation = aval & cval & " = 0"
            Else
                bval = " – " & numB * -1 & "x".ToString
                Equation = aval & bval & cval & " = 0"
            End If
        ElseIf numB = 0 Then
            Equation = aval & cval & " = 0"
        End If

        'For numC

        If numC = 0 Then
            Equation = aval & bval & " = 0"
        ElseIf Math.Sign(numC) = -1 Then
            If numC = 0 Then
                Equation = aval & bval & " = 0"
            Else
                cval = " – " & numC * -1.ToString
                Equation = aval & bval & cval & " = 0"
            End If
        End If

        ' For numB and numC

        If numB = 0 And numC = 0 Then
            Equation = aval & " = 0"
        End If
    End Sub
    'Sub to save list
    Public Sub SaveList(ByVal SavefileDialog As SaveFileDialog, ByVal StoredMath As ArrayList)
        If StoredMath.Count <> 0 Then
            Dim Filename As String
            SavefileDialog.ShowDialog()
            Filename = SavefileDialog.FileName
            If Filename <> Nothing Then
                Dim Filewriter As New StreamWriter(Filename)
                For Each item In StoredMath
                    Filewriter.WriteLine(item)
                Next
                Filewriter.Close()
            End If
        Else
            MsgBox("You cannot save an empty list", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Note")
        End If
    End Sub
    'Calculate Quadratic Equation
    Public Sub CalcQuadratic(ByVal numA As Double, ByVal numB As Double, ByVal numC As Double, ByRef root1 As Double, ByRef root2 As Double, Optional ByRef resultsoutput As String = Nothing, Optional ByRef remainder1 As Double = Nothing, Optional ByRef remainder2 As Double = Nothing)
        Dim a, b, c As Double
        Dim root1Str, root2Str As String
        a = numA
        b = numB
        c = numC
        root1 = (-b + Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
        root2 = (-b - Math.Sqrt(b ^ 2 - 4 * a * c)) / (2 * a)
        remainder1 = (-b + Math.Sqrt(b ^ 2 - 4 * a * c)) Mod (2 * a)
        remainder2 = (-b - Math.Sqrt(b ^ 2 - 4 * a * c)) Mod (2 * a)
        If remainder1 = 0 And remainder2 = 0 Then
            Select Case root1
                Case Is < 0
                    root1Str = " + " & Math.Abs(root1)
                Case Else
                    root1Str = " – " & root1
            End Select
            Select Case root2
                Case Is < 0
                    root2Str = " + " & Math.Abs(root2)
                Case Else
                    root2Str = " – " & root2
            End Select
            resultsoutput = "(x" & root1Str & ")" & "(x" & root2Str & ") = 0"
        End If
    End Sub
    Public Sub ShowCalculationSteps(A As Double, B As Double, C As Double)
        Dim Numerator1 As Double = -B + Math.Sqrt((B ^ 2) - (4 * A * C))
        Dim Numerator2 As Double = -B - Math.Sqrt((B ^ 2) - (4 * A * C))

    End Sub
    'Sub to load listview items
    Public Sub LoadList(ByVal OpenFileDialog As OpenFileDialog, ByRef ListView As ListView, ByRef StoreMathList As ArrayList)
        OpenFileDialog.InitialDirectory = Main.savedRecalls
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            Dim Filename As String
            Filename = OpenFileDialog.FileName
            If Filename <> Nothing Then
                Try
                    ListView.Items.Clear()
                    StoreMathList.Clear()
                    Dim AllLines As String() = File.ReadAllLines(Filename)
                    For Each line In AllLines
                        Dim ListViewItem As New ListViewItem
                        Dim equation As String = Nothing
                        Dim roots As String = Nothing
                        Dim factors As String = Nothing
                        Dim math = line.Split(":")
                        equation = math(0)
                        roots = math(1)
                        factors = math(2)
                        ListViewItem.Text = equation
                        ListViewItem.SubItems.Add(roots)
                        ListViewItem.SubItems.Add(factors)
                        ListView.Items.Add(ListViewItem)
                        StoreMathList.Add(line)
                    Next line
                Catch ex As Exception
                    MessageBox.Show("The file is invalid." & Environment.NewLine & Environment.NewLine & "Error type:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If
        End If
    End Sub
    'Sub to randomize values A, B, or C
    Public Sub Randomize(ByRef numA As Double, ByRef numB As Double, ByRef numC As Double, ByVal index01or2 As Integer, ByVal rand As Random, Optional ByRef randmodifier As Integer = Nothing)
        Dim determinant As Double
        Dim root1, root2 As Double
        Dim remainder1, remainder2 As Double

        Select Case index01or2
            Case 0
                Do
                    numA = rand.Next(-1, 2)
                    numB = rand.Next(-50, 50)
                    numC = rand.Next(-40, 50)
                    determinant = numB ^ 2 - 4 * numA * numC
                    Me.CalcQuadratic(numA, numB, numC, root1, root2, , remainder1, remainder2)
                Loop Until determinant >= 0 And remainder1 = 0 And remainder2 = 0 And numB <> 0 And numC <> 0 And numA <> 0
            Case 1
                randmodifier = rand.Next(0, 2)
                If randmodifier = 1 Then
                    Do
                        numA = rand.Next(-6, 6)
                        numB = rand.Next(-100, 100)
                        numC = rand.Next(-80, 80)
                        determinant = numB ^ 2 - 4 * numA * numC
                        Me.CalcQuadratic(numA, numB, numC, root1, root2, , remainder1, remainder2)
                    Loop Until determinant >= 0 And remainder1 = rand.Next(1, 3) Or remainder1 = 0 And remainder2 = 0 And numA <> 0 And numC <> 0
                Else
                    Do
                        numA = rand.Next(-6, 6)
                        numB = rand.Next(-100, 100)
                        numC = rand.Next(-80, 80)
                        determinant = numB ^ 2 - 4 * numA * numC
                        Me.CalcQuadratic(numA, numB, numC, root1, root2, , remainder1, remainder2)
                    Loop Until determinant >= 0 And numC <> 0 And numA <> 0
                End If
            Case 2
                randmodifier = rand.Next(0, 3)
                If randmodifier = 1 Then
                    Do
                        numA = rand.Next(-10, 13) + Format(rand.NextDouble(), "#.0")
                        numC = rand.Next(-150, 150) + Format(rand.NextDouble(), "#.0")
                        numB = rand.Next(-200, 200) + Format(rand.NextDouble(), "#.0")
                        determinant = numB ^ 2 - 4 * numA * numC
                        Me.CalcQuadratic(numA, numB, numC, root1, root2, , remainder1, remainder2)
                    Loop Until determinant >= 0 And remainder1 = 0 And remainder2 = 0 Or remainder2 = rand.Next(1, 9) And numA <> 0 And numC <> 0
                Else
                    Do
                        numA = rand.Next(-10, 13) + Format(rand.NextDouble(), "#.0")
                        numC = rand.Next(-150, 150) + Format(rand.NextDouble(), "#.0")
                        numB = rand.Next(-200, 200) + Format(rand.NextDouble(), "#.0")
                        determinant = numB ^ 2 - 4 * numA * numC
                    Loop Until determinant >= 0 And numA <> 0 And numB <> 0 And numC <> 0
                End If
            Case Else
        End Select
    End Sub
    'Sub to load sums on listbox
    Public Sub LoadTest(ByVal Openfiledialog As OpenFileDialog, ByRef ListBox As ListBox, ByRef StoreMathList As ArrayList)
        Openfiledialog.InitialDirectory = Main.savedTests
        Dim sumnumbers As Integer = 1
        If Openfiledialog.ShowDialog = DialogResult.OK Then
            Dim Filename As String
            Filename = Openfiledialog.FileName
            If Filename <> Nothing Then
                Try
                    ListBox.Items.Clear()
                    StoreMathList.Clear()
                    Dim AllLines As String() = File.ReadAllLines(Filename)
                    For Each line In AllLines
                        Dim root1 As Double
                        Dim root2 As Double
                        Dim equation As String
                        Dim math = line.Split(":")
                        root1 = math(0)
                        root2 = math(1)
                        equation = math(2)
                        ListBox.Items.Add(sumnumbers & ".   " & equation)
                        StoreMathList.Add(line)
                        sumnumbers += 1
                    Next line
                    sumnumbers = 1
                Catch ex As Exception
                    MessageBox.Show("The file is invalid." & Environment.NewLine & Environment.NewLine & "Error type:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If
        End If
    End Sub
    'Sub to save stuff in Arraylist
    Public Sub Savestuff(ByVal path As String, ByVal arraylist As ArrayList)
        Dim Filewriter As New StreamWriter(path, False)
        For Each item In arraylist
            Filewriter.WriteLine(item)
        Next
        Filewriter.Close()
    End Sub
    'Sub to load stuff from arraylist to lview
    Public Sub LoadStuffLView(ByVal path As String, ByVal arraylist As ArrayList, ByVal Listview As ListView)
        Try
            Dim AllLines As String() = File.ReadAllLines(path)
            For Each line In AllLines
                Dim ListViewItem As New ListViewItem
                Dim factors As String = Nothing
                Dim equation As String = Nothing
                Dim roots As String = Nothing
                Dim math = line.Split(":")
                equation = math(0)
                roots = math(1)
                factors = math(2)
                arraylist.Add(line)
                ListViewItem.Text = equation
                ListViewItem.SubItems.Add(roots)
                ListViewItem.SubItems.Add(factors)
                Listview.Items.Add(ListViewItem)
            Next line
        Catch ex As Exception
            MessageBox.Show("Failed to load recall list." & Environment.NewLine & Environment.NewLine & "Error type:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    'Sub to load stuff from arraylist to lbox
    Public Sub LoadStuffLbox(ByVal path As String, ByVal arraylist As ArrayList, ByVal Listbox As ListBox)
        Dim sumnumbers As Integer = 1
        Try
            Dim AllLines As String() = File.ReadAllLines(path)
            For Each line In AllLines
                Dim ListViewItem As New ListViewItem
                Dim equation As String = Nothing
                Dim roots As String = Nothing
                Dim math = line.Split(":")
                equation = math(2)
                Listbox.Items.Add(sumnumbers & ".    " & equation)
                arraylist.Add(line)
                sumnumbers += 1
            Next line
        Catch ex As Exception
            MessageBox.Show("Failed to load Practice Problems." & Environment.NewLine & Environment.NewLine & "Error type:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    'Sub to print stuff
    Public Sub PrintMath(ByVal Arraylist As ArrayList, ByRef virtualtextbox As RichTextBox)
        Dim Filename As String = InputBox("Please enter the name of the Document", "Print", "My Math")
        Try
            If Filename.Length <> 0 Then
                Dim mywriter As New StreamWriter(Main.savedTests & "\" & Filename & ".txt")
                Dim sumnumber As Integer = 1
                mywriter.WriteLine(Filename)
                mywriter.WriteLine("______________________________________________________________________________")
                mywriter.WriteLine()
                For Each item As String In Arraylist
                    Dim math = item.Split(":")
                    If CheckOptions.printAns = True Then
                        mywriter.WriteLine((sumnumber & ".    " & math(2) & "         " & "x = " & math(0) & " or " & math(1)).ToString)
                        mywriter.WriteLine()
                    Else
                        mywriter.WriteLine((sumnumber & ".   " & math(2)).ToString)
                        mywriter.WriteLine()
                    End If
                    sumnumber += 1
                Next
                mywriter.Close()
                virtualtextbox.Font = New Font("Cambria", 15)
                virtualtextbox.Text = File.ReadAllText(Main.savedTests & "\" & Filename & ".txt", System.Text.Encoding.UTF8)
                virtualtextbox.SaveFile(Main.savedTests & "\" & Filename & ".rtf", RichTextBoxStreamType.RichText)
                virtualtextbox.SaveFile(Main.savedTests & "\" & Filename & ".rtf", RichTextBoxStreamType.RichText)
                File.Delete(Main.savedTests & "\" & Filename & ".txt")
                Process.Start(Main.savedTests & "\" & Filename & ".rtf")
            End If
        Catch ex As Exception
            MsgBox("Could not save your document" & Environment.NewLine & Environment.NewLine & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub
    'Su3b to encrypt
    Public Function AuthEncrypt(ByVal data As String, ByVal rand As Random) As String
        Dim info As String = Nothing
        Dim trimmedata = data.Trim()
        Dim num As Integer = 1
        For Each character In trimmedata
            Dim charcode = Microsoft.VisualBasic.AscW(character)
            Dim sym = ChrW(rand.Next(123, 223))
            Do
                info &= Microsoft.VisualBasic.AscW(character) + num ^ 2 & ";" & sym & ";"
                num += 1
            Loop Until sym <> ChrW((AscW("\"))) Or sym <> ChrW((AscW("/"))) Or sym <> ChrW((AscW(">"))) Or sym <> ChrW((AscW("<"))) Or sym <> ChrW((AscW("?"))) Or sym <> ChrW((AscW("|"))) Or sym <> ChrW((AscW(":"))) Or sym <> ChrW((AscW("*"))) Or sym <> ChrW((AscW(";")))
        Next
        Return info
    End Function
    'Sub to decrypt
    Public Function decrypt(ByVal data As String) As String
        Dim info As String = Nothing
        Dim num As Integer = 1
        Try
            Dim charcollection = data.Split(";")
            For Each item In charcollection
                If IsNumeric(item) = True Then
                    item = CInt(item) - num ^ 2
                    info &= Microsoft.VisualBasic.ChrW(item)
                    num += 1
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred. Please contact Providence Universal for support")
            info = Nothing
        End Try
        Return info
    End Function

    Public Function slideanimation(ByRef increment As Integer, ByVal maxval As Integer, ByRef coordinateval As Integer, Optional ByVal increasecoord As Boolean = True)
        If increasecoord = True Then
            If coordinateval >= maxval Then
                Return 1
            Else
                increment += 1
                If increment = 0 Then increment += 1
                coordinateval += Math.E ^ (1 / increment)
                Return 0
            End If
        Else
            If coordinateval <= maxval Then
                Return 1
            Else
                increment -= 1
                If increment = 0 Then increment -= 1
                coordinateval -= Math.E ^ (1 / increment ^ 2)
                Return 0
            End If
        End If
    End Function
End Class
