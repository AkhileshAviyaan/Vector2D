Public Class Vector2D
	Public XOrigin As Double
	Public YOrigin As Double
	Public DelX As Double
	Public DelY As Double

	Public Sub New()

	End Sub
	Public Sub New(delx As Double, dely As Double)
		Me.DelX = delx
		Me.DelY = dely
	End Sub
	Public Sub New(originx As Double, originy As Double, delx As Double, dely As Double)
		Me.XOrigin = originx
		Me.YOrigin = originy
		Me.DelX = delx
		Me.DelY = dely
	End Sub
	Public Function DotProduct(v2 As Vector2D)

	End Function
	Public Shared Operator +(v1 As Vector2D, v2 As Vector2D) As Vector2D
		Return New Vector2D(v1.DelX + v2.DelX, v1.DelY + v2.DelY)
	End Operator
	Public Shared Operator -(v1 As Vector2D, v2 As Vector2D) As Vector2D
		Return New Vector2D(v1.DelX - v2.DelX, v1.DelY - v2.DelY)
	End Operator
End Class
