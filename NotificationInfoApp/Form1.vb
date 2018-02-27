Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotificationIcon.Visible = True
        NotificationIcon.BalloonTipTitle = "Notifier"

        ' setting a default value of info for our combo box/dropdown menu
        BoxType.SelectedIndex = 0

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Using a sub for cleaner code and better reusability
        DisplayNotification()
    End Sub

    Private Sub DisplayNotification()
        ' It doesn't allow empty strings to be used as title/text for the notification
        ' so I provide default values programatically, just to be safe
        If BoxTitle.Text = "" Then
            BoxTitle.Text = "Default Title"
        End If
        If TextInfo.Text = "" Then
            TextInfo.Text = "Default Info Text"
        End If

        ' We change the style of the ToolTip depending on What the user choose from the dropdown menu for type
        If BoxType.SelectedIndex = 0 Then   ' 0 refers to the first item in the dropdown list; basically it's an array, and we access its indexes
            ' (time in ms, Title, Text, Type)
            NotificationIcon.ShowBalloonTip(2000, BoxTitle.Text, TextInfo.Text, ToolTipIcon.Info)
        ElseIf BoxType.SelectedIndex = 1 Then
            NotificationIcon.ShowBalloonTip(2000, BoxTitle.Text, TextInfo.Text, ToolTipIcon.Warning)
        Else
            NotificationIcon.ShowBalloonTip(2000, BoxTitle.Text, TextInfo.Text, ToolTipIcon.Error)
        End If

        ' Updating the history form
        History.TextBoxHistory.Text &= DateTime.Now().ToString("HH:mm") & Environment.NewLine & "Type: " & BoxType.SelectedItem & " Notification" &
            Environment.NewLine & "Title: " & BoxTitle.Text &
            Environment.NewLine & "Message: " & TextInfo.Text &
            Environment.NewLine & Environment.NewLine

    End Sub

    Private Sub NotificationIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotificationIcon.MouseDoubleClick
        ' Here You can add code to show the form or do whaterver you like when the icon in the system tray is double clicked
        Me.WindowState = WindowState.Normal
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clearing all inputs
        BoxTitle.Text = ""
        TextInfo.Text = ""
        BoxType.SelectedIndex = 0
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        ' if history form is already visible we hide it
        If History.Visible Then
            History.Hide()
        Else
            History.Show()
        End If
    End Sub
End Class
