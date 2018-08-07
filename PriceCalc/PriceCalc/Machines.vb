Public Class Machines
    Overridable Function SetupHourRate(ByVal minWorked As Decimal, ByVal minRate As Decimal, ByVal qtyRate As Integer) As Decimal

        SetupHourRate = (minWorked * minRate) / qtyRate

    End Function

    Overridable Function MachineHourRate(ByVal minWorked As Decimal, ByVal minRate As Decimal, ByVal qtyRate As Integer) As Decimal

        MachineHourRate = minWorked * minRate * qtyRate

    End Function

End Class
