Public Class frmAirplaneTakeOff
    Private ReadOnly Names() As String = {"A-747", "A-735", "C-150", "D-240"}
    Private ReadOnly TakeOffVelocity() As Double = {250, 264, 270, 240}
    Private ReadOnly Acceleration() As Double = {33.5, 44.2, 37.1, 51.9}
    Private planes() As Aircraft


    Private Sub frmAirplaneTakeOff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim planes(Names.Length - 1)

        For i As Integer = 0 To planes.Length - 1
            planes(i) = New Aircraft With {
                .Name = Names(i),
                .TakeOffVelocity = TakeOffVelocity(i),
                .Acceleration = Acceleration(i)}
        Next
        lstAirCraft.DataSource = planes
        lstAirCraft.DisplayMember = "Name"
    End Sub

   Private Sub lstAircraft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAircraft.SelectedIndexChanged
        Dim aircraft As AirCraft = CType(lstAircraft.SelectedItem, AirCraft)

        lblResult.Text = "The " & aircraft.Name & " aircraft has a required takeoff velocity of " & aircraft.TakeOffVelocity.ToString("n") &
                         " ft/sec and an acceleration constant of " & aircraft.Acceleration.ToString("n") & ". Therefore, it requires " &
                         aircraft.TakeOffTime.ToString("n") & " seconds to take off, with the distance being " & aircraft.TakeOffDistance.ToString("n") & " feet."
    End Sub


End Class
