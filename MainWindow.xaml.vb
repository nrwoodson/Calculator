Class MainWindow
    Dim h As Double
    Dim num1, num2, sign As String
    Dim refresher, newNum As Boolean
    Public Sub reset_all()
        ui_Display.Text = ""
        sign = ""
        num1 = ""
        num2 = ""
        refresher = True
        newNum = False

    End Sub

    Private Sub key_Clear_Click() Handles key_ClearAll.Click

        reset_all()

    End Sub

    Private Sub key_Decimal_Click(sender As Object, e As RoutedEventArgs) Handles key_decimal.Click

        If sign <> "" And newNum = False Then
            ui_Display.Text = "0."
            newNum = True
        Else
        End If

        If ui_Display.Text = "" Then
            ui_Display.Text = "0."
            refresher = True
        Else
            ui_Display.Text = ui_Display.Text & "."
            refresher = True
        End If

    End Sub


    Private Sub key_0_Click(sender As Object, e As RoutedEventArgs) Handles key_0.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 0
    End Sub
    Private Sub key_1_Click(sender As Object, e As RoutedEventArgs) Handles key_1.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 1
    End Sub
    Private Sub key_2_Click(sender As Object, e As RoutedEventArgs) Handles key_2.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 2
    End Sub
    Private Sub key_3_Click(sender As Object, e As RoutedEventArgs) Handles key_3.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 3
    End Sub
    Private Sub key_4_Click(sender As Object, e As RoutedEventArgs) Handles key_4.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 4
    End Sub
    Private Sub key_5_Click(sender As Object, e As RoutedEventArgs) Handles key_5.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 5
    End Sub
    Private Sub key_6_Click(sender As Object, e As RoutedEventArgs) Handles key_6.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 6
    End Sub
    Private Sub key_7_Click(sender As Object, e As RoutedEventArgs) Handles key_7.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 7
    End Sub
    Private Sub key_8_Click(sender As Object, e As RoutedEventArgs) Handles key_8.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 8
    End Sub
    Private Sub key_9_Click(sender As Object, e As RoutedEventArgs) Handles key_9.Click
        If sign <> "" And newNum = False Then
            ui_Display.Text = ""
            newNum = True
        Else
        End If

        ui_Display.Text = ui_Display.Text & 9
    End Sub
    Private Sub opp_div_Click() Handles opp_div.Click

        If num1 > "" And refresher = True Then
            sign = "div"
            Evaluate()
        Else
        End If

        If ui_Display.Text <> "" Then
            num1 = Val(ui_Display.Text)
            sign = "div"
            newNum = False
            refresher = True
        Else
        End If

    End Sub
    Private Sub opp_mul_Click() Handles opp_mul.Click

        If num1 > "" And refresher = True Then
            sign = "mul"
            Evaluate()
        Else
        End If

        If ui_Display.Text <> "" Then
            num1 = Val(ui_Display.Text)
            sign = "mul"
            newNum = False
            refresher = True
        Else
        End If

    End Sub
    Private Sub opp_add_Click() Handles opp_add.Click

        If num1 > "" And refresher = True Then
            sign = "add"
            Evaluate()
        Else
        End If

        If ui_Display.Text <> "" Then
            num1 = Val(ui_Display.Text)
            sign = "add"
            newNum = False
            refresher = True
        Else
        End If

    End Sub
    Private Sub opp_sub_Click() Handles opp_sub.Click

        If num1 > "" And refresher = True Then
            sign = "sub"
            Evaluate()
        Else
        End If

        If ui_Display.Text <> "" Then
            num1 = Val(ui_Display.Text)
            sign = "sub"
            newNum = False
            refresher = True
        Else
        End If

    End Sub
    Private Sub opp_pow_Click() Handles opp_pow.Click

        If num1 > "" And refresher = True Then
            sign = "pow"
            Evaluate()
        Else
        End If

        If ui_Display.Text <> "" Then
            num1 = Val(ui_Display.Text)
            sign = "pow"
            newNum = False
            refresher = True
        Else
        End If

    End Sub
    Private Sub opp_per_Click() Handles opp_per.Click

        If num1 > "" And refresher = True Then
            sign = "per"
            Evaluate()
        Else
        End If

        If ui_Display.Text <> "" Then
            num1 = Val(ui_Display.Text)
            sign = "per"
            newNum = False
            refresher = True
            Evaluate()
        Else
        End If

    End Sub
    Private Sub opp_minus_Click() Handles opp_minus.Click

        If num1 > "" And refresher = True Then
            sign = "minus"
            Evaluate()
        Else
        End If

        If ui_Display.Text <> "" Then
            num1 = Val(ui_Display.Text)
            sign = "minus"
            newNum = False
            refresher = True
            Evaluate()
        Else
        End If

    End Sub
    Private Sub opp_equal_Click() Handles opp_equal.Click


        Evaluate()

    End Sub

    Public Sub Evaluate()
        If num1 <> "" Then


            num2 = Val(ui_Display.Text)



            Select Case sign
                Case "add"
                    ui_Display.Text = Val(num1) + Val(num2)
                Case "sub"
                    ui_Display.Text = Val(num1) - Val(num2)
                Case "mul"
                    ui_Display.Text = Val(num1) * Val(num2)
                Case "div"
                    ui_Display.Text = Val(num1) / Val(num2)
                Case "pow"
                    ui_Display.Text = Val(num1) ^ Val(num2)
                Case "per"
                    ui_Display.Text = Val(num1) / 100
                Case "minus"
                    ui_Display.Text = Val(num1) * -1
            End Select


            refresher = False
            newNum = True

        Else
        End If

    End Sub


End Class
