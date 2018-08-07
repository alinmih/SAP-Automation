Public Class CenterlessGrinding
    Inherits Machines
    Property MinRate As Decimal = 1.8D
    Property CostCenter As String = "B-266"
    Property Name As String = "Rectificare fara centre"
    Public Overrides Function SetupHourRate(minWorked As Decimal, minRate As Decimal, qtyRate As Integer) As Decimal
        SetupHourRate = MyBase.SetupHourRate(minWorked, minRate, qtyRate)
    End Function

    Public Overrides Function MachineHourRate(minWorked As Decimal, minRate As Decimal, qtyRate As Integer) As Decimal
        MachineHourRate = MyBase.MachineHourRate(minWorked, minRate, qtyRate)
    End Function
End Class
