Imports System

Module Program
	Sub Main(args As String())
		Dim v1 As New Vector3D(1, 0, 0)
		Dim v2 As New Vector3D(0, 1, 0)
		Dim v3 As New Vector3D(0, 0, 0)
		Dim vl1 As New VectorLine(v1, v2)
		Dim CosAngle = vl1.SinAngleBetween(v3)
	End Sub
End Module
