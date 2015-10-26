Option Explicit On
Friend Class Form1
    Inherits System.Windows.Forms.Form
    Dim i As Short
    Dim textheight As Integer, textwidth As Integer
    Dim grBrush As System.Drawing.Brush
    Dim tcounter As Integer = 1
    Dim Starttime As Integer
    Dim t1 As Integer
    Dim t2 As Integer
    Dim passes As Integer
    Dim noofqsubmitted As Integer
    Dim b1(0) As Button

    'select * from score
    '--insert into score values('pr1',11,12)
    Dim prevhelp As String

    Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Kunal\BRAINWAVES\11-03-07\p1.mdb;Persist Security Info=False" '"Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=proceed;Data Source=it25"
    Dim str As String = "SELECT * FROM Table1"
    Dim con1 As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Kunal\BRAINWAVES\11-03-07\dblocal.mdb;Persist Security Info=False" '"Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=proceed;Data Source=it25"
    Dim str1 As String = "SELECT * FROM sol"

    Dim dt As New DataTable()
    Dim currentlistindex As Integer
    Dim optionselected As Integer
    Dim sec As Integer



    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Randomize()
        prevhelp = Label_Help.Text
        textwidth = 15
        textheight = 17
        Timer1(0).Enabled = True
        Me.BackColor = Color.Black

        If GetSetting("proceed", "setting", "notproperlyclosed", 0) = 1 Then

        End If
    End Sub
    Private Sub Tickit(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Dim g As Graphics = CreateGraphics()
        Dim Index As Short = Timer1.GetIndex(eventSender)
        Dim Textsize As New System.Drawing.SizeF
        If Timer1.Count * textwidth * 1.5 < Me.Width Then
            Timer1.Load(Timer1.Count)
            Timer1(Timer1.Count - 1).Tag = 0
            Timer1(Timer1.Count - 1).Interval = (Rnd() * 4999) + 1
            Timer1(Timer1.Count - 1).Enabled = False
        End If

        Timer1((Timer1.Count - 1) * Rnd()).Enabled = True
        Dim forecolor1 As New System.Drawing.Color
        Dim forecolor2 As New System.Drawing.Color
        Dim t1 As Integer
        t1 = Rnd() * 150
        t2 = t2 + 1
        If t2 > 5000 And t2 < 10000 Then
            forecolor1 = Color.FromArgb(0, t1, 0)
            forecolor2 = Color.FromArgb(0, t1 + 100, 0)
        ElseIf t2 > 10000 Then
            t2 = 0
        Else
            forecolor1 = Color.FromArgb(0, 0, t1)
            forecolor2 = Color.FromArgb(0, 0, t1 + 100)
        End If
        Timer1(Index).Tag = CDbl(Timer1(Index).Tag) + textheight

        Timer1(Index).Interval = (Rnd() * 100) + 1



        Dim font As New Font("Arial", textwidth, FontStyle.Bold, GraphicsUnit.Point)

        Dim ptfGradientStart As New PointF(10, 5)
        Dim ptfGradientEnd As New PointF(10, 10)
        grBrush = New Drawing2D.LinearGradientBrush(ptfGradientStart, ptfGradientEnd, forecolor1, forecolor2)


        If CInt(Rnd() * 2) = 2 Then
            g.DrawString("c", font, grBrush, Index * textwidth * 1.5, Timer1(Index).Tag)
        ElseIf CInt(Rnd()) = 1 Then
            g.DrawString("+", font, grBrush, Index * textwidth * 1.5, Timer1(Index).Tag)
        Else
            g.DrawString("C", font, grBrush, Index * textwidth * 1.5, Timer1(Index).Tag)
        End If


        If Timer1(Index).Tag > 3 * textheight Then
            g.FillRectangle(Brushes.Black, CInt(Index * textwidth * 1.5), CInt(Timer1(Index).Tag - 18 * textheight), textwidth + 5, textheight)
            If CInt(Timer1(Index).Tag - 18 * textheight) > Height Then Timer1(Index).Tag = 0
        End If

        g.Dispose()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub



    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        'sec += 1
        'Dim sec1 As Integer
        sec = (System.Environment.TickCount() - Starttime) / 100
        '        Label1.Text = (sec / 1800)
        Dim m As String, s As String

        m = Format(Fix((1800 - sec) / 60) Mod 60, "##00")
        s = Format(Fix((1800 - sec)) Mod 60 Mod 60, "##00")
        '        If Len(s) = 1 Then s = "0" & s
        Label1.Text = m & ":" & s

        If sec > 1800 Then
            Timer3.Stop()
            checkresult()
            MsgBox("Time Over !!!")
        End If

        If (sec / 60) > noofqsubmitted + 1 Then
            If Not prevhelp = Label_Help.Text Then
                prevhelp = Label_Help.Text
                Label_Help.Text = "Hurry Up !!!" & vbNewLine & "You are running out of time."
            End If
        Else
            If Not prevhelp = Label_Help.Text Then
                Label_Help.Text = prevhelp
            End If
        End If
    End Sub


    Private Sub drawbuttons()

        b1(0) = New Button
        b1(0).Left = Button_qst.Left
        b1(0).Top = Button_qst.Top
        b1(0).Width = Button_qst.Width
        b1(0).Height = Button_qst.Height
        b1(0).BackColor = Button_qst.BackColor
        b1(0).ForeColor = Button_qst.ForeColor
        b1(0).Text = 1
        b1(0).Visible = True
        b1(0).Name = 0

        Me.Controls.Add(b1(0))
        AddHandler b1(0).Click, AddressOf Button_qst_Click

        Dim i As Integer
        For i = 1 To 29
            ReDim Preserve b1(i)
            b1(i) = New Button
            b1(i).Left = b1(i - 1).Left
            b1(i).Top = b1(i - 1).Top + b1(0).Height

            If i = 15 Then
                b1(i).Left = Me.Width - (b1(0).Left + b1(0).Width)
                b1(i).Top = b1(0).Top
            End If


            b1(i).BackColor = Button_qst.BackColor
            b1(i).ForeColor = Button_qst.ForeColor
            b1(i).Width = b1(i - 1).Width
            b1(i).Height = b1(i - 1).Height
            b1(i).Name = i
            b1(i).Text = i + 1

            Me.Controls.Add(b1(i))
            AddHandler b1(i).Click, AddressOf Button_qst_Click
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        drawbuttons()
        lblload()

        populatelistbox()
        Dim i As Integer
        nextqst(0)
        Button_Submit.Enabled = False
        For i = 0 To 29
            ListBox_EnteredOptions.Items.Add(-1)
        Next

        Timer3.Start()


        Starttime = System.Environment.TickCount

    End Sub

    Private Sub lblload()
        dt.Clear()
        Dim dataAdapter As New OleDb.OleDbDataAdapter(str, con)
        dataAdapter.Fill(dt)
        dataAdapter.Dispose()
        'Display the table in the data grid.

        dgv.DataSource = dt
    End Sub

    Private Sub populatelistbox()
        Dim i As Integer
        Randomize()
        For i = 0 To 29
            ListBox_RND.Items.Add(i)
        Next

        Dim j As Integer, k As Integer
        For i = 0 To 29
            j = ListBox_RND.Items.Item(i)
            k = Rnd() * 29
            ListBox_RND.Items.Item(i) = ListBox_RND.Items.Item(k)
            ListBox_RND.Items.Item(k) = j
        Next
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        optionselected = 1
        Button_Submit.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        optionselected = 2
        Button_Submit.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        optionselected = 3
        Button_Submit.Enabled = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        optionselected = 4
        Button_Submit.Enabled = True
    End Sub

    Private Sub Button_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Submit.Click


        ListBox_EnteredOptions.Items.Item(ListBox_RND.Items.Item(currentlistindex)) = optionselected

        Dim trs As New ADODB.Recordset
        trs.Open(str1, con1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        trs.AddNew()
        trs(0).Value = ListBox_RND.Items.Item(currentlistindex)
        trs(1).Value = optionselected
        trs(2).Value = dgv.Rows(ListBox_RND.Items.Item(currentlistindex)).Cells(6).Value
        trs.Update()
        trs.Close()

        b1(currentlistindex).BackColor = Color.Green
        b1(currentlistindex).Enabled = False

        noofqsubmitted += 1
        currentlistindex = currentlistindex + 1
        Dim i As Integer
d1:
        For i = currentlistindex To 29
            If Not b1(i).BackColor = Color.Green Then
                Exit For
            End If
        Next
        Dim checkfromstart As Boolean

        If i > 29 Then
            If checkfromstart = True Then
                MsgBox("End")
                Exit Sub
            Else
                checkfromstart = True
                currentlistindex = 0
                GoTo d1
            End If
        End If
        currentlistindex = i
        nextqst(currentlistindex)
    End Sub

    Private Sub Button_Pass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Pass.Click
        passes = checknoofpasses()
        If passes > 4 Then
            MsgBox("More than 5 passes r not allowed")
            Exit Sub
        End If
        Dim tindex As Integer
        tindex = currentlistindex
        currentlistindex = currentlistindex + 1

        Dim checkfromstart As Boolean
        Dim i As Integer
d1:
        For i = currentlistindex To 29

            If Not b1(i).BackColor = Color.Green Then
                Exit For
            End If
        Next

        If i > 28 Then
            If checkfromstart = True Then
                MsgBox("End")
                Exit Sub
            Else
                checkfromstart = True
                currentlistindex = 0
                GoTo d1
            End If
        End If

        b1(tindex).BackColor = Color.Orange
        nextqst(i)

    End Sub

    Sub nextqst(ByVal i As Integer)
        currentlistindex = i
        b1(currentlistindex).BackColor = Color.Red
        i = ListBox_RND.Items.Item(i)
        TextBox_qst.Text = dgv.Rows(i).Cells(1).Value
        RadioButton1.Text = dgv.Rows(i).Cells(2).Value
        RadioButton2.Text = dgv.Rows(i).Cells(3).Value
        RadioButton3.Text = dgv.Rows(i).Cells(4).Value
        RadioButton4.Text = dgv.Rows(i).Cells(5).Value
        RadioButton5.Select()
        Button_Submit.Enabled = False
        MsgBox(dgv.Rows(i).Cells(6).Value)
    End Sub
    Sub redtoorange()
        Dim i As Integer
        For i = 0 To UBound(b1)
            If b1(i).BackColor = Color.Red Then
                b1(i).BackColor = Color.Orange
            End If
        Next
    End Sub

    Function checknoofpasses() As Integer
        Dim i As Integer
        Dim temp As Integer
        For i = 0 To UBound(b1)
            If b1(i).BackColor = Color.Orange Then
                temp += 1
            End If
        Next
        checknoofpasses = temp
    End Function
    Private Sub Button_qst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not b1(DirectCast(sender, Button).Name).BackColor = Color.Orange Then Exit Sub
        currentlistindex = DirectCast(sender, Button).Name
        redtoorange()
        nextqst(currentlistindex)
    End Sub

    Sub checkresult()
        Dim trs As New ADODB.Recordset
        trs.Open(str1, con1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Dim i As Integer, score As Integer
        trs.MoveFirst()
        On Error GoTo e1
        For i = 0 To 29
            If trs(1).Value = trs(2).Value Then
                score += 1
            End If
            trs.MoveNext()
        Next
        MsgBox("")
e1:
        MsgBox(score)
        trs.Close()
    End Sub

    Private Sub Button_GiveUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_GiveUp.Click
        checkresult()
    End Sub
End Class