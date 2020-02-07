Public Class Form1
    Dim A, B, C, D, E As Boolean

    Private time As Byte

    Private Sub Form1_Load(sender As Object, ev As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, ev As EventArgs) Handles Timer1.Tick

        A = time >= 8
        If A Then
            time -= 8
        End If

        B = time >= 4
        If B Then
            time -= 4
        End If

        C = time >= 2
        If B Then
            time -= 2
        End If

        D = time >= 1
        If B Then
            time -= 1
        End If

        If (C And (Not B Or D)) Or (B And Not C) Then
            pb1.Image = My.Resources.red_circle
        Else
            pb1.Image = My.Resources.grey_circle
        End If



        time = +1
    End Sub
End Class
