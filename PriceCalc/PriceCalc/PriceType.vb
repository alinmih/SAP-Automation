Public Class PriceType
    Private _internalPrel As Integer
    Private _setupPrel As Integer
    Private _marfuri As Integer
    Private _marja As Integer
    Private _consumuri As Integer

    Property InternalPrel As Integer
        Get
            Return _internalPrel
        End Get
        Set
            _internalPrel = Value
        End Set
    End Property

    Property SetupPrel As Integer
        Get
            Return _setupPrel
        End Get
        Set
            _setupPrel = Value
        End Set
    End Property

    Property Marfuri As Integer
        Get
            Return _marfuri
        End Get
        Set
            _marfuri = Value
        End Set
    End Property

    Property Consumuri As Integer
        Get
            Return _consumuri
        End Get
        Set
            _consumuri = Value
        End Set
    End Property

    Property Marja As Integer
        Get
            Return _marja
        End Get
        Set
            _marja = Value
        End Set
    End Property

    'Sub ProdCost()

    '    InternalPrel = 0
    '    SetupPrel = 0
    '    Consumuri = 5
    '    Marfuri = 30
    '    Marja = 35

    'End Sub

End Class
