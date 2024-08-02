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
	Public Sub New(x1 As Double, y1 As Double, x2 As Double, y2 As Double)
		Me.X1 = x1
		Me.Y1 = y1
		Me.X2 = x2
		Me.Y2 = y2
		Me.DelX = x2 - x1
		Me.DelY = y2 - y1
	End Sub
	Public Sub New(v1 As Vector3D, v2 As Vector3D)
		Me.New(v1.X, v1.Y, v2.X, v2.Y)
	End Sub
	Public Sub New(vl As VectorLine, x2 As Double, y2 As Double)
		Me.New(vl.X1, vl.Y1, x2, y2)
	End Sub
	Public Sub New(vl As VectorLine, v As Vector3D)
		Me.New(vl, v.X, v.Y)
	End Sub
	Public Function DotProduct(v2 As VectorLine)
		Return DelX * v2.DelX + DelY * v2.DelY
	End Function
	Public Function CosAngleBetween(v2 As Vector3D)
		Dim vl As New VectorLine(Me, v2)
		Return CosAngleBetween(vl)
	End Function
	Public Function SinAngleBetween(v2 As Vector3D)
		Dim vl As New VectorLine(Me, v2)
		Return SinAngleBetween(vl)
	End Function
	Public Function CosAngleBetween(v2 As VectorLine)
		Return DotProduct(v2) / (Magnitude * v2.Magnitude)
	End Function
	Public Function SinAngleBetween(v2 As VectorLine)
		Dim CosA = CosAngleBetween(v2)
		Dim A = ACos(CosA)
		Return Sin(A)
	End Function
	Public Function GetPerpendicularDistance(x As Double, y As Double)
		Dim vl As New VectorLine(Me, x, y)
		Dim SinA = SinAngleBetween(vl)
		Return vl.Magnitude * SinA
	End Function
	Public Function GetPerpendicularIntersectPoint(v As Vector3D)
		Dim vl As New VectorLine(Me, v.X, v.Y)
		Dim SinA = SinAngleBetween(vl)
		Dim DisX = vl.DelX * SinA
		Dim DisY = vl.DelY * SinA
		Return New Vector3D(X1 + DisX, Y1 + DisY, v.Z)
	End Function
	Public Function GetPerpendicularDistance(v As Vector3D)
		GetPerpendicularDistance(v.X, v.Y)
	End Function
End Class
