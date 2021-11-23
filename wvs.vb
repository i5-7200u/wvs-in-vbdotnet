        Dim qwwe As Char() = "CDEFABGHIJKLMNOPQRSTUVWXYZ".ToCharArray
        For Each sa As Char In qwwe
            Dim qwde As String = sa + ":\"
            If System.IO.Directory.Exists(qwde) = True Then
                System.Console.WriteLine(qwde)
            End If
        Next
