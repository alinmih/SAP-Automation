Public Class RawMaterial

    Public Property matCode As Integer
    Public Property matDescription As String
    Public Property matUnit As String
    Public Property matPrice As String

    Public Property matLenght As String
    'Public Property matLenghtUnit As String

    Public Property matWidth As String
    'Public Property matWidthUnit As String

    Public Property matThickness As String
    'Public Property matThicknessUnit As String

    Public Property matShortDescription As String
    Public Property matDensity As String


    Public Property matDin As String


    'Public Property matQty As String


    Sub New(ByVal code As Integer, ByVal desc As String, ByVal unit As String, ByVal price As Double, ByVal lenght As Integer,
            ByVal width As Integer, ByVal thick As Double, ByVal shortDes As String, ByVal dens As Double)
        Me.matCode = code
        Me.matDescription = desc
        Me.matUnit = unit
        Me.matPrice = price
        Me.matLenght = lenght
        Me.matWidth = width
        Me.matThickness = thick
        Me.matShortDescription = shortDes
        Me.matDensity = dens
    End Sub



End Class
