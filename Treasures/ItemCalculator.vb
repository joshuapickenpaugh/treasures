Public Class ItemCalculator

    Private _decItemPrice As Decimal
    Private _decSubTotal As Decimal
    Private _decShippingCharge As Decimal
    Private _decTotalDue As Decimal
    Private Const SALES_TAX As Decimal = 1.02

    Public Property ItemPrice As Decimal
        Get
            Return _decItemPrice
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _decItemPrice = value
            Else
                _decItemPrice = 0
            End If
        End Set
    End Property

    Public Sub New()

        _decItemPrice = 0

    End Sub

    Public Function GetSubTotal() As Decimal

        _decSubTotal = _decSubTotal + ItemPrice

        Return _decSubTotal

    End Function

    Public Function GetSalesTax() As Decimal

        Dim TtlWithSlsTax As Double

        TtlWithSlsTax = _decSubTotal * SALES_TAX

        Return TtlWithSlsTax

    End Function

    Public Function GetShipping() As Decimal

        If _decSubTotal < 100 Then
            _decShippingCharge = 10.0
        Else
            _decShippingCharge = 0.0
        End If

        Return _decShippingCharge
    End Function

    Public Function TotalDue() As Decimal

        _decTotalDue = (_decSubTotal * SALES_TAX) + _decShippingCharge

        Return _decTotalDue
    End Function

    Public Sub Clear()

        _decItemPrice = 0.0
        _decSubTotal = 0.0
        _decShippingCharge = 0.0
        _decTotalDue = 0.0

    End Sub

End Class
