Public Class History
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' setting this forms position uder the Main form
        Me.SetDesktopLocation(Main.Location.X, Main.Location.Y + Main.Width)
        Me.Hide()
    End Sub
End Class