Module MathHelp
    Public Function Cos(x As Double) As Double
        Return Math.Cos(x)
    End Function

    Public Function Sin(x As Double) As Double
        Return Math.Sin(x)
    End Function
    Public Function ACos(x As Double) As Double
        Return Math.Acos(x)
    End Function

    Public Function ASin(x As Double) As Double
        Return Math.Asin(x)
    End Function
    Public Function Tan(x As Double) As Double
        Return Math.Tan(x)
    End Function

    Public Function Atan(x As Double) As Double
        Return Math.Atan(x)
    End Function

    Public Function Atan2(x As Double, y As Double) As Double
        Return Math.Atan2(x, y)
    End Function

    Public Function Pow(x As Double, y As Double) As Double
        Return Math.Pow(x, y)
    End Function

    Public Function Sqrt(x As Double) As Double
        Return Math.Sqrt(x)
    End Function

    Public ReadOnly Property PI() As Double
        Get
            Return Math.PI
        End Get
    End Property

    Public Function Abs(x As Double) As Double
        Return Math.Abs(x)
    End Function
End Module
