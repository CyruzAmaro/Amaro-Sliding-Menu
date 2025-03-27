Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        While (Panel1.Width < 140)
            Panel1.Width += 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        While (Panel1.Width > 41)
            Panel1.Width -= 1
        End While
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlDesert.Visible = False
        pnlCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pnlFoods.Visible = False
        pnlDrinks.Visible = True
        pnlDesert.Visible = False
        pnlCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDesert.Visible = True
        pnlCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDesert.Visible = False
        pnlCart.Visible = True
        pnlAbout.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDesert.Visible = False
        pnlCart.Visible = False
        pnlAbout.Visible = True
    End Sub
End Class
