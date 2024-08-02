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
	ReadOnly Property DirCosineX As Double
		Get
			Return (X2 - X1) / Magnitude
		End Get
	End Property
	ReadOnly Property DirCosineY As Double
		Get
			Return (Y2 - Y1) / Magnitude
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
	Public Function DotProduct(v2 As VectorLine) As Double
		Return DelX * v2.DelX + DelY * v2.DelY
	End Function
	Public Function CosOfAngleBetween(v2 As Vector3D) As Double
		Dim vl As New VectorLine(Me, v2)
		Return CosOfAngleBetween(vl)
	End Function
	Public Function SinOfAngleBetween(v2 As Vector3D) As Double
		Dim vl As New VectorLine(Me, v2)
		Return SinOfAngleBetween(vl)
	End Function
	Public Function CosOfAngleBetween(v2 As VectorLine) As Double
		Return DotProduct(v2) / (Magnitude * v2.Magnitude)
	End Function
	Public Function SinOfAngleBetween(v2 As VectorLine) As Double
		Dim CosA = CosOfAngleBetween(v2)
		Dim A = ACos(CosA)
		Return Sin(A)
	End Function
	Public Function GetPerpendicularDistance(x As Double, y As Double) As Double
		Dim vl As New VectorLine(Me, x, y)
		Dim SinA = SinOfAngleBetween(vl)
		Return vl.Magnitude * SinA
	End Function
	Public Function GetPerpendicularIntersectPoint(v As Vector3D) As Vector3D
		Dim vl As New VectorLine(Me, v.X, v.Y)
		Dim CosA = CosOfAngleBetween(vl)
		Dim projectedLength = vl.Magnitude * CosA
		Dim diffx = projectedLength * DirCosineX
		Dim diffy = projectedLength * DirCosineY
		Return New Vector3D(X1 + diffx, Y1 + diffy, v.Z)
	End Function
	Public Function GetPerpendicularDistance(v As Vector3D) As Double
		Return GetPerpendicularDistance(v.X, v.Y)
	End Function
	Public Function IsIntersectPointLiesInside(v As Vector3D) As Boolean
		Dim r1 = (X1 - v.X) / (X2 - v.X)
		Dim r2 = (Y1 - v.Y) / (Y2 - v.Y)
		If Abs(r1) > 1 Or Abs(r2) > 1 Then
			Return False
		Else
			Return True
		End If
	End Function
End Class
