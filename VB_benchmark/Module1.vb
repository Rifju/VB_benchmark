Module Module1
    Private ReadOnly times As Integer = 100000000
    Private ReadOnly Chars As String = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Sub Main()
        Console.WriteLine(times.ToString + "回ループします")

        Dim start As DateTime = DateTime.Now
        Dim starttime As String = start.ToString("mm:ss.fff")
        Console.WriteLine("start : " + starttime)

        Dim readchar As String = ""
        Dim len As Integer = 10

        For i As Integer = 0 To times - 1
            readchar = RandomChars(len)
        Next

        Dim end_dt As DateTime = DateTime.Now
        Dim endtime As String = end_dt.ToString("mm:ss.fff")
        Console.WriteLine("end : " + endtime)

        Dim margin As TimeSpan = end_dt - start
        Console.WriteLine("margin : {0}:{1}.{2}", margin.Minutes, margin.Seconds, margin.Milliseconds)


    End Sub


    Public Function RandomChars(ByVal length As Integer) As String
        Dim sb As New System.Text.StringBuilder(length)
        Dim r As New Random()

        For i As Integer = 0 To length - 1
            Dim pos As Integer = r.Next(Chars.Length)
            Dim c As Char = Chars(pos)
            sb.Append(c)
        Next

        Return sb.ToString()
    End Function

End Module
