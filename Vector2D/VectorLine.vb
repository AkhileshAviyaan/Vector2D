Public Class VectorLine
	Public X1 As Double
	Public Y1 As Double
	Public X2 As Double
	Public Y2 As Double
	Public DelX As Double
	Public DelY As Double
	ReadOnly Property Magnitude As Double
		Get
			Return Sqrt(Pow(DelX, 2) + Pow(DelY, 2))
		End Get
	End Property

	Public Sub New()

	End Sub
	Public Sub New(v1 As Vector3D, v2 As Vector3D)
		Me.X1 = v1.X
		Me.Y1 = v1.Y
		Me.X2 = v2.X
		Me.Y2 = v2.Y
		Me.DelX = v2.X - v1.X
		Me.DelY = v2.Y - v1.Y
	End Sub
	Public Sub New(x1 As Double, y1 As Double, x2 As Double, y2 As Double)
		Me.X1 = x1
		Me.Y1 = y1
		Me.X2 = x2
		Me.Y2 = y2
		Me.DelX = x2 - x1
		Me.DelY = y2 - y1
	End Sub
	Public Function DotProduct(v2 As VectorLine)
		Return DelX * v2.DelX + DelY * v2.DelY
	End Function
	Public Function CosAngleBetween(v2 As VectorLine)
		Return DotProduct(v2) / (Magnitude * v2.Magnitude)
	End Function
	Public Function GetPerpendicularDistance(x As Double, y As Double)

	End Function
	Public Function GetPerpendicularDistance(v As Vector3D)
		GetPerpendicularDistance(v.X, v.Y)
	End Function
End Class
