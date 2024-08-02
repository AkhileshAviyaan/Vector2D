Imports System

Module Program
	Sub Main(args As String())
		'Dim v1 As New Vector3D(0, 0, 0)
		'Dim v2 As New Vector3D(5, 0, 0)
		'Dim v3 As New Vector3D(2.5, 2.5 * Sqrt(3), 0)
		Dim v1 As New Vector3D(10, 0, 0)
		Dim v2 As New Vector3D(5, 0, 0)
		Dim v3 As New Vector3D(0, 0, 0)
		Dim vl1 As New VectorLine(v1, v2)
		Dim vl2 As New VectorLine(v1, v3)
		Dim CosAngle = vl1.CosOfAngleBetween(v3)
		Dim SinAngle = vl1.SinOfAngleBetween(v3)
		Dim ca = ACos(CosAngle).ToDegree
		Dim sa = ASin(SinAngle).ToDegree
		Dim Pdistance = vl1.GetPerpendicularDistance(v3)
		Dim Pinterest1 = vl1.GetPerpendicularIntersectPoint(v3)
		Dim Pinterest2 = vl1.GetPerpendicularIntersectPoint(v3)
		Dim IsInside = vl1.IsIntersectPointLiesInside(Pinterest1)
	End Sub
End Module
