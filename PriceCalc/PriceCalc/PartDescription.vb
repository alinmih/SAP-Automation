Public Class PartDescription
    Const matConfig As String = "K_IC_FF_ST"
    Private _dwgNo As String = ""
    Private _partNo As String = ""
    Private _revNo As String = ""
    Private _matDIN As String = ""
    Private _lenght As Double = 0.0D
    Private _lenghtMax As Double = 0.0D
    Private _lenghtMin As Double = 0.0D
    Private _width As Double = 0.0D
    Private _widthMax As Double = 0.0D
    Private _widthMin As Double = 0.0D
    Private _thick As Double = 0.0D
    Private _thickMax As Double = 0.0D
    Private _thickMin As Double = 0.0D
    Private _innerDiam As Double = 0.0D
    Private _innerDiamMax As Double = 0.0D
    Private _innerDiamMin As Double = 0.0D
    Private _outerDiam As Double = 0.0D
    Private _outerDiamMax As Double = 0.0D
    Private _outerDiamMin As Double = 0.0D

    Property dwgNo As String
        Get
            Return _dwgNo
        End Get
        Set
            _dwgNo = Value
        End Set
    End Property

    Property partNo As String
        Get
            Return _partNo
        End Get
        Set
            _partNo = Value
        End Set
    End Property

    Property revNo As String
        Get
            Return _revNo
        End Get
        Set
            _revNo = Value
        End Set
    End Property

    Property matDIN As String
        Get
            Return _matDIN
        End Get
        Set
            _matDIN = Value
        End Set
    End Property

    Property lenght As Double
        Get
            Return _lenght
        End Get
        Set
            _lenght = Value
        End Set
    End Property

    Property lenghtMax As Double
        Get
            Return _lenghtMax
        End Get
        Set
            _lenghtMax = Value
        End Set
    End Property

    Property lenghtMin As Double
        Get
            Return _lenghtMin
        End Get
        Set
            _lenghtMin = Value
        End Set
    End Property

    Property width As Double
        Get
            Return _width
        End Get
        Set
            _width = Value
        End Set
    End Property

    Property widthMax As Double
        Get
            Return _widthMax
        End Get
        Set
            _widthMax = Value
        End Set
    End Property

    Property widthMin As Double
        Get
            Return _widthMin
        End Get
        Set
            _widthMin = Value
        End Set
    End Property

    Property thick As Double
        Get
            Return _thick
        End Get
        Set
            _thick = Value
        End Set
    End Property

    Property thickMax As Double
        Get
            Return _thickMax
        End Get
        Set
            _thickMax = Value
        End Set
    End Property

    Property thickMin As Double
        Get
            Return _thickMin
        End Get
        Set
            _thickMin = Value
        End Set
    End Property

    Property innerDiam As Double
        Get
            Return _innerDiam
        End Get
        Set
            _innerDiam = Value
        End Set
    End Property

    Property innerDiamMax As Double
        Get
            Return _innerDiamMax
        End Get
        Set
            _innerDiamMax = Value
        End Set
    End Property

    Property innerDiamMin As Double
        Get
            Return _innerDiamMin
        End Get
        Set
            _innerDiamMin = Value
        End Set
    End Property

    Property outerDiam As Double
        Get
            Return _outerDiam
        End Get
        Set
            _outerDiam = Value
        End Set
    End Property

    Property outerDiamMax As Double
        Get
            Return _outerDiamMax
        End Get
        Set
            _outerDiamMax = Value
        End Set
    End Property

    Property outerDiamMin As Double
        Get
            Return _outerDiamMin
        End Get
        Set
            _outerDiamMin = Value
        End Set
    End Property


End Class





