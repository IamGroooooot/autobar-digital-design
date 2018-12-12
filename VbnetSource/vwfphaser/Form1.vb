Public Class Form1
    Dim olderdata(15, 7) As Integer
    Dim oldercount(15) As Integer
    Dim tablestate(15) As Boolean
    Dim tablecost(15) As Integer
    Dim tableselmenu(15) As Integer
    Dim abtablenum As Integer
    Dim pluscnt As Integer
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abtablenum = 15
        abtable.Text = abtablenum
        openerimg.Image = Image.FromFile(Application.StartupPath + "\resource\openerimg.png")
        olderarrow.Image = Image.FromFile(Application.StartupPath + "\resource\right.png")
        sg1.Image = Image.FromFile(Application.StartupPath + "\resource\0.png")
        sg2.Image = Image.FromFile(Application.StartupPath + "\resource\0.png")
        sg3.Image = Image.FromFile(Application.StartupPath + "\resource\0.png")
        tablelist.Value = 1
        btablelist.Value = 1
        pluscnt = 0
        r1.Checked = True
    End Sub

    Public Sub updatebill()
        Dim totalcost As Integer
        totalcost = 0

        blc1.Text = olderdata(btablelist.Value, 1)
        blc2.Text = olderdata(btablelist.Value, 2)
        blc3.Text = olderdata(btablelist.Value, 3)
        blc4.Text = olderdata(btablelist.Value, 4)
        blc5.Text = olderdata(btablelist.Value, 5)
        blc6.Text = olderdata(btablelist.Value, 6)
        blc7.Text = olderdata(btablelist.Value, 7)

        blp1.Text = olderdata(btablelist.Value, 1) * 4
        blp2.Text = olderdata(btablelist.Value, 2) * 4
        blp3.Text = olderdata(btablelist.Value, 3) * 4
        blp4.Text = olderdata(btablelist.Value, 4) * 4
        blp5.Text = olderdata(btablelist.Value, 5) * 4 * 2
        blp6.Text = olderdata(btablelist.Value, 6) * 4 * 2
        blp7.Text = olderdata(btablelist.Value, 7) * 4 * 2

        For i As Integer = 1 To 7
            If i < 5 Then
                totalcost = totalcost + olderdata(btablelist.Value, i) * 4
            Else
                totalcost = totalcost + olderdata(btablelist.Value, i) * 4 * 2
            End If

        Next
        bltotal.Text = totalcost
    End Sub

    Public Sub radiochk(tablenum As Integer)
        If r1.Checked = True Then
            tableselmenu(tablenum) = 1
        End If
        If r2.Checked = True Then
            tableselmenu(tablenum) = 2
        End If
        If r3.Checked = True Then
            tableselmenu(tablenum) = 3
        End If
        If r4.Checked = True Then
            tableselmenu(tablenum) = 4
        End If
        If r5.Checked = True Then
            tableselmenu(tablenum) = 5
        End If
        If r6.Checked = True Then
            tableselmenu(tablenum) = 6
        End If
        If r7.Checked = True Then
            tableselmenu(tablenum) = 7
        End If

    End Sub
    Public Sub ringing()
        My.Computer.Audio.Play(Application.StartupPath + "\resource\bell.wav", AudioPlayMode.WaitToComplete)
    End Sub

    Public Sub sgmtcg(tablenum As Integer, menunum As Integer)
        oldercount(tablenum) = (oldercount(tablenum) + 1) * pluscnt
        sg1.Image = Image.FromFile(Application.StartupPath + "\resource\" + tablenum.ToString + ".png")
        If menunum = 1 Then
            sg2.Image = Image.FromFile(Application.StartupPath + "\resource\" + "c" + ".png")
            sg3.Image = Image.FromFile(Application.StartupPath + "\resource\" + "l" + ".png")
        ElseIf menunum = 2 Then
            sg2.Image = Image.FromFile(Application.StartupPath + "\resource\" + "n" + ".png")
            sg3.Image = Image.FromFile(Application.StartupPath + "\resource\" + "c" + ".png")
        ElseIf menunum = 3 Then
            sg2.Image = Image.FromFile(Application.StartupPath + "\resource\" + "5" + ".png")
            sg3.Image = Image.FromFile(Application.StartupPath + "\resource\" + "j" + ".png")
        ElseIf menunum = 4 Then
            sg2.Image = Image.FromFile(Application.StartupPath + "\resource\" + "5" + ".png")
            sg3.Image = Image.FromFile(Application.StartupPath + "\resource\" + "13" + ".png")
        ElseIf menunum = 5 Then
            sg2.Image = Image.FromFile(Application.StartupPath + "\resource\" + "9" + ".png")
            sg3.Image = Image.FromFile(Application.StartupPath + "\resource\" + "7e" + ".png")
        ElseIf menunum = 6 Then
            sg2.Image = Image.FromFile(Application.StartupPath + "\resource\" + "r" + ".png")
            sg3.Image = Image.FromFile(Application.StartupPath + "\resource\" + "n" + ".png")
        ElseIf menunum = 7 Then
            sg2.Image = Image.FromFile(Application.StartupPath + "\resource\" + "13" + ".png")
            sg3.Image = Image.FromFile(Application.StartupPath + "\resource\" + "11" + ".png")
        End If
        olderdata(tablenum, menunum) = (olderdata(tablenum, menunum) + 1) * pluscnt
        ringing()
    End Sub

    Public Sub cgtablestate(tablenum As Integer, state As Boolean)
        If state = True Then
            If tablenum = 1 Then
                s1.BackColor = Color.Red
            End If
            If tablenum = 2 Then
                s2.BackColor = Color.Red
            End If
            If tablenum = 3 Then
                s3.BackColor = Color.Red
            End If
            If tablenum = 4 Then
                s4.BackColor = Color.Red
            End If
            If tablenum = 5 Then
                s5.BackColor = Color.Red
            End If
            If tablenum = 6 Then
                s6.BackColor = Color.Red
            End If
            If tablenum = 7 Then
                s7.BackColor = Color.Red
            End If
            If tablenum = 8 Then
                s8.BackColor = Color.Red
            End If
            If tablenum = 9 Then
                s9.BackColor = Color.Red
            End If
            If tablenum = 10 Then
                s10.BackColor = Color.Red
            End If
            If tablenum = 11 Then
                s11.BackColor = Color.Red
            End If
            If tablenum = 12 Then
                s12.BackColor = Color.Red
            End If
            If tablenum = 13 Then
                s13.BackColor = Color.Red
            End If
            If tablenum = 14 Then
                s14.BackColor = Color.Red
            End If
            If tablenum = 15 Then
                s15.BackColor = Color.Red
            End If
            abtablenum = abtablenum - 1
            abtable.Text = abtablenum
            tablestate(tablenum) = True
        End If
        If state = False Then
            If tablenum = 1 Then
                s1.BackColor = Color.Lime
            End If
            If tablenum = 2 Then
                s2.BackColor = Color.Lime
            End If
            If tablenum = 3 Then
                s3.BackColor = Color.Lime
            End If
            If tablenum = 4 Then
                s4.BackColor = Color.Lime
            End If
            If tablenum = 5 Then
                s5.BackColor = Color.Lime
            End If
            If tablenum = 6 Then
                s6.BackColor = Color.Lime
            End If
            If tablenum = 7 Then
                s7.BackColor = Color.Lime
            End If
            If tablenum = 8 Then
                s8.BackColor = Color.Lime
            End If
            If tablenum = 9 Then
                s9.BackColor = Color.Lime
            End If
            If tablenum = 10 Then
                s10.BackColor = Color.Lime
            End If
            If tablenum = 11 Then
                s11.BackColor = Color.Lime
            End If
            If tablenum = 12 Then
                s12.BackColor = Color.Lime
            End If
            If tablenum = 13 Then
                s13.BackColor = Color.Lime
            End If
            If tablenum = 14 Then
                s14.BackColor = Color.Lime
            End If
            If tablenum = 15 Then
                s15.BackColor = Color.Lime
            End If
            abtablenum = abtablenum + 1
            abtable.Text = abtablenum
            tablestate(tablenum) = False
            oldercount(tablenum) = 0
            For i As Integer = 1 To 7
                olderdata(tablenum, i) = 0
            Next

        End If
    End Sub

    Public Sub clearbtstate()
        r1.Checked = False
        r2.Checked = False
        r3.Checked = False
        r4.Checked = False
        r5.Checked = False
        r6.Checked = False
        r7.Checked = False
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        clearbtstate()
        r1.Checked = True

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        clearbtstate()
        r2.Checked = True

    End Sub
    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        clearbtstate()
        r3.Checked = True

    End Sub
    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        clearbtstate()
        r4.Checked = True

    End Sub
    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        clearbtstate()
        r5.Checked = True

    End Sub
    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        clearbtstate()
        r6.Checked = True

    End Sub
    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        clearbtstate()
        r7.Checked = True

    End Sub

    Private Sub o_Click(sender As Object, e As EventArgs) Handles o.Click
        If pluscnt > 0 Then

            If oldercount(tablelist.Value) = 0 Then
                cgtablestate(tablelist.Value, True)
            End If
            radiochk(tablelist.Value)
            sgmtcg(tablelist.Value, tableselmenu(tablelist.Value))
            pluscnt = 0
            plcnt.Text = pluscnt
            updatebill()
        End If

    End Sub

    Private Sub c_Click(sender As Object, e As EventArgs) Handles c.Click
        pluscnt = 0
        plcnt.Text = pluscnt
        radiochk(tablelist.Value)
        If olderdata(tablelist.Value, tableselmenu(tablelist.Value)) > 0 Then
            olderdata(tablelist.Value, tableselmenu(tablelist.Value)) = olderdata(tablelist.Value, tableselmenu(tablelist.Value)) - 1
        End If
        updatebill()
    End Sub

    Private Sub rs_Click(sender As Object, e As EventArgs) Handles rs.Click
        pluscnt = 0
        plcnt.Text = pluscnt
        If tablestate(tablelist.Value) = True Then
            cgtablestate(tablelist.Value, False)
        End If

        updatebill()
    End Sub

    Private Sub btablelist_ValueChanged(sender As Object, e As EventArgs) Handles btablelist.ValueChanged
        updatebill()

    End Sub

    Private Sub p_Click(sender As Object, e As EventArgs) Handles p.Click
        pluscnt = pluscnt + 1
        plcnt.Text = pluscnt

    End Sub

    Private Sub tablelist_ValueChanged(sender As Object, e As EventArgs) Handles tablelist.ValueChanged
        pluscnt = 0
        plcnt.Text = pluscnt

    End Sub
End Class
