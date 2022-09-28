Public Shared Function CompareImages(ByVal I1 As Image, ByVal I2 As Image) As Boolean
    Dim BM1 As Bitmap = I1
    Dim BM2 As Bitmap = I2
    For X = 0 To BM1.Width - 1
        For y = 0 To BM2.Height - 1
            If BM1.GetPixel(X, y) <> BM2.GetPixel(X, y) Then
                Return False
            End If
        Next
    Next
    Return True
End Functionn