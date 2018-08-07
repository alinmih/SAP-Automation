Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim small As SmallSaw = New SmallSaw
        Dim big As BigSaw = New BigSaw
        Dim minutes As Double = 10
        Dim qty As Integer = 10

        'Circular.Text = small.SetupHourRate(minutes, small.MinRate, qty)

        'Mayer.Text = big.SetupHourRate(minutes, big.MinRate, qty)


        Dim part As New PartDescription
        part.lenght = 6
        part.width = 123.4

        'lenght.Text = part.lenght
        'Width.Text = part.width

        Dim priceType As New PriceType


        'For index = 1 To 3000
        '    ComboBox1.Items.Add("ISOVAL TM           0070 10400 10400: " + index.ToString())
        'Next

        'ComboBox1.Items.AddRange(item)


    End Sub





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ware As WareHouse = New WareHouse

        For Each item In ware.warehouse
            'Dim st As String
            'st = item.matCode & "-" & item.matDescription
            If item.matDensity = "1,9" Then
                'ComboBox1.Items.Add(item.matLenght)
            End If
        Next

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dwgLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class
