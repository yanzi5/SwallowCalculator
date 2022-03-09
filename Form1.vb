Public Class Form1
    '声明全局变量
    Dim strmiddle() As String = {"0", "0", "0"} '数组型
    Dim calmethod1 As String = "0" '文本型
    Dim calmethod2 As String = "0" '文本型
    Dim strdot As Boolean = False '逻辑型

    '按钮[0]
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If strmiddle(0) = "0" Then
            TextBox1.Text = strmiddle(0) & "."
        ElseIf strdot = False Then
            strmiddle(0) = strmiddle(0) & “0”
            TextBox1.Text = strmiddle(0) & “.”
        Else
            strmiddle(0) = strmiddle(0) & “0”
            TextBox1.Text = strmiddle(0)
        End If
    End Sub

    '按钮[.]
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        strdot = True
        strmiddle(0) = strmiddle(0) & “.”
        TextBox1.Text = strmiddle(0)
    End Sub

    '按钮[归零]
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        strmiddle(0) = 0 '将变量设置为0
        strmiddle(1) = 0
        strmiddle(2) = 0
        calmethod1 = 0
        calmethod2 = 0
        strdot = False
        TextBox1.Text = “0”
    End Sub

    '按钮[=]
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If strmiddle(2) = "0" Then
            Select Case calmethod1
                Case "+"
                    TextBox1.Text = Str(Val(strmiddle(1)) + Val(strmiddle(0)))
                Case "-"
                    TextBox1.Text = Str(Val(strmiddle(1)) - Val(strmiddle(0)))
                Case "*"
                    TextBox1.Text = Str(Val(strmiddle(1)) * Val(strmiddle(0)))
                Case "/"
                    If strmiddle(0) = "0" Then
                        TextBox1.Text = "错误！"
                    Else
                        TextBox1.Text = Str(Val(strmiddle(1)) / Val(strmiddle(0)))
                    End If
            End Select

        ElseIf calmethod2 = “*” Then
            strmiddle(0) = Str(Val(strmiddle(0)) * Val(strmiddle(2)))
            Select Case calmethod1
                Case "+"
                    TextBox1.Text = Str(Val(strmiddle(1)) + Val(strmiddle(0)))
                Case "-"
                    TextBox1.Text = Str(Val(strmiddle(1)) - Val(strmiddle(0)))
                Case "*"
                    TextBox1.Text = Str(Val(strmiddle(1)) * Val(strmiddle(0)))
                Case "/"
                    If strmiddle(0) = "0" Then
                        TextBox1.Text = "错误！"
                    Else
                        TextBox1.Text = Str(Val(strmiddle(1)) / Val(strmiddle(0)))
                    End If
            End Select

        ElseIf calmethod2 = “/” Then
            strmiddle(0) = Str(Val(strmiddle(2)) * Val(strmiddle(0)))
            Select Case calmethod1
                Case "+"
                    TextBox1.Text = Str(Val(strmiddle(1)) + Val(strmiddle(0)))
                Case "-"
                    TextBox1.Text = Str(Val(strmiddle(1)) - Val(strmiddle(0)))
                Case "*"
                    TextBox1.Text = Str(Val(strmiddle(1)) * Val(strmiddle(0)))
                Case "/"
                    If strmiddle(0) = "0" Then
                        TextBox1.Text = "错误！"
                    Else
                        TextBox1.Text = Str(Val(strmiddle(1)) / Val(strmiddle(0)))
                    End If
            End Select
        End If

    End Sub

    '按钮[1]
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If strmiddle(0) = "0" Then
            strmiddle(0) = "1"
            TextBox1.Text = strmiddle(0) & "."
        ElseIf strdot = False Then
            strmiddle(0) = strmiddle(0) & "1"
            TextBox1.Text = strmiddle(0) & "."
        Else
            strmiddle(0) = strmiddle(0) & "1"
            TextBox1.Text = strmiddle(0)
        End If
    End Sub

    '按钮[2]
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If strmiddle(0) = "0" Then
            strmiddle(0) = "2"
            TextBox1.Text = strmiddle(0) & "."
        ElseIf strdot = False Then
            strmiddle(0) = strmiddle(0) & "2"
            TextBox1.Text = strmiddle(0) & "."
        Else
            strmiddle(0) = strmiddle(0) & "2"
            TextBox1.Text = strmiddle(0)
        End If
    End Sub

    '按钮[3]
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If strmiddle(0) = "0" Then
            strmiddle(0) = "3"
            TextBox1.Text = strmiddle(0) & "."
        ElseIf strdot = False Then
            strmiddle(0) = strmiddle(0) & "3"
            TextBox1.Text = strmiddle(0) & "."
        Else
            strmiddle(0) = strmiddle(0) & "3"
            TextBox1.Text = strmiddle(0)
        End If
    End Sub

    '按钮[4]
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If strmiddle(0) = "0" Then
            strmiddle(0) = "4"
            TextBox1.Text = strmiddle(0) & "."
        ElseIf strdot = False Then
            strmiddle(0) = strmiddle(0) & "4"
            TextBox1.Text = strmiddle(0) & "."
        Else
            strmiddle(0) = strmiddle(0) & "4"
            TextBox1.Text = strmiddle(0)
        End If
    End Sub

    '按钮[5]
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If strmiddle(0) = "0" Then
            strmiddle(0) = "5"
            TextBox1.Text = strmiddle(0) & "."
        ElseIf strdot = False Then
            strmiddle(0) = strmiddle(0) & "5"
            TextBox1.Text = strmiddle(0) & "."
        Else
            strmiddle(0) = strmiddle(0) & "5"
            TextBox1.Text = strmiddle(0)
        End If
    End Sub

    '按钮[6]
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If strmiddle(0) = "0" Then
            strmiddle(0) = "6"
            TextBox1.Text = strmiddle(0) & "."
        ElseIf strdot = False Then
            strmiddle(0) = strmiddle(0) & "6"
            TextBox1.Text = strmiddle(0) & "."
        Else
            strmiddle(0) = strmiddle(0) & "6"
            TextBox1.Text = strmiddle(0)
        End If
    End Sub

    '按钮[7]
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If strmiddle(0) = "0" Then
            strmiddle(0) = "7"
            TextBox1.Text = strmiddle(0) & "."
        ElseIf strdot = False Then
            strmiddle(0) = strmiddle(0) & "7"
            TextBox1.Text = strmiddle(0) & "."
        Else
            strmiddle(0) = strmiddle(0) & "7"
            TextBox1.Text = strmiddle(0)
        End If
    End Sub

    '按钮[8]
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If strmiddle(0) = "0" Then
            strmiddle(0) = "8"
            TextBox1.Text = strmiddle(0) & "."
        ElseIf strdot = False Then
            strmiddle(0) = strmiddle(0) & "8"
            TextBox1.Text = strmiddle(0) & "."
        Else
            strmiddle(0) = strmiddle(0) & "8"
            TextBox1.Text = strmiddle(0)
        End If
    End Sub

    '按钮[9]
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If strmiddle(0) = "0" Then
            strmiddle(0) = "9"
            TextBox1.Text = strmiddle(0) & "."
        ElseIf strdot = False Then
            strmiddle(0) = strmiddle(0) & "9"
            TextBox1.Text = strmiddle(0) & "."
        Else
            strmiddle(0) = strmiddle(0) & "9"
            TextBox1.Text = strmiddle(0)
        End If
    End Sub

    '按钮[+]
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If calmethod1 = "0" Then
            calmethod1 = "+"
            strmiddle(1) = strmiddle(0)
            strmiddle(0) = "0"
        Else : Select Case calmethod1
                Case "+"
                    strmiddle(1) = Str(Val(strmiddle(0)) + Val(strmiddle(1)))
                    strmiddle(0) = "0"
                    calmethod1 = "+"
                Case "-"
                    strmiddle(1) = Str(Val(strmiddle(1)) - Val(strmiddle(0)))
                    strmiddle(0) = "0"
                    calmethod1 = "+"
                Case "*"
                    strmiddle(1) = Str(Val(strmiddle(0)) * Val(strmiddle(1)))
                    strmiddle(0) = "0"
                    calmethod1 = "+"
                Case "/"
                    strmiddle(1) = Str(Val(strmiddle(1)) / Val(strmiddle(0)))
                    strmiddle(0) = "0"
                    calmethod1 = "+"
            End Select
        End If
    End Sub

    '按钮[-]
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If calmethod1 = "0" Then
            calmethod1 = "-"
            strmiddle(1) = strmiddle(0)
            strmiddle(0) = "0"
        Else : Select Case calmethod1
                Case "+"
                    strmiddle(1) = Str(Val(strmiddle(0)) + Val(strmiddle(1)))
                    strmiddle(0) = "0"
                    calmethod1 = "-"
                Case "-"
                    strmiddle(1) = Str(Val(strmiddle(1)) - Val(strmiddle(0)))
                    strmiddle(0) = "0"
                    calmethod1 = "-"
                Case "*"
                    strmiddle(1) = Str(Val(strmiddle(0)) * Val(strmiddle(1)))
                    strmiddle(0) = "0"
                    calmethod1 = "-"
                Case "/"
                    strmiddle(1) = Str(Val(strmiddle(1)) / Val(strmiddle(0)))
                    strmiddle(0) = "0"
                    calmethod1 = "-"
            End Select
        End If
    End Sub

    '按钮[*]
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If calmethod1 = "0" Then
            calmethod1 = "*"
            strmiddle(1) = strmiddle(0)
            strmiddle(0) = "0"
        Else : Select Case calmethod1
                Case "+"
                    calmethod2 = "*"
                    strmiddle(2) = strmiddle(0)
                    strmiddle(0) = "0"
                Case "-"
                    calmethod2 = "*"
                    strmiddle(2) = strmiddle(0)
                    strmiddle(0) = "0"
                Case "*"
                    strmiddle(1) = Str(Val(strmiddle(0)) * Val(strmiddle(1)))
                    strmiddle(0) = "0"
                    calmethod1 = "*"
                Case "/"
                    strmiddle(1) = Str(Val(strmiddle(1)) / Val(strmiddle(0)))
                    strmiddle(0) = "0"
                    calmethod1 = "*"
            End Select
        End If
    End Sub

    '按钮[/]
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If calmethod1 = "0" Then
            calmethod1 = "/"
            strmiddle(1) = strmiddle(0)
            strmiddle(0) = "0"
        Else : Select Case calmethod1
                Case "+"
                    calmethod2 = "/"
                    strmiddle(2) = strmiddle(0)
                    strmiddle(0) = "0"
                Case "-"
                    calmethod2 = "/"
                    strmiddle(2) = strmiddle(0)
                    strmiddle(0) = "0"
                Case "*"
                    strmiddle(1) = Str(Val(strmiddle(0)) * Val(strmiddle(1)))
                    strmiddle(0) = "0"
                    calmethod1 = "/"
                Case "/"
                    strmiddle(1) = Str(Val(strmiddle(1)) / Val(strmiddle(0)))
                    strmiddle(0) = "0"
                    calmethod1 = "/"
            End Select
        End If
    End Sub

    '按钮[ON]
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = "0"
    End Sub

    '按钮[退出]
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Close() '结束软件
    End Sub

    '窗口创建时
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
