Public Class Arith

    Public Function addition(ParamArray values() As Double) As Double
        Try
            Dim result As Double = 0
            For Each vl As Double In values
                result += vl
            Next
            Return result
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function substraction(ParamArray values() As Double) As Double
        Try
            Dim result As Double = 0
            For Each vl As Double In values
                result -= vl
            Next
            Return result
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function multiplication(ParamArray values() As Double) As Double
        Try
            Dim result As Double = 0
            For Each vl As Double In values
                result *= vl
            Next
            Return result
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function division(ParamArray values() As Double) As Double
        Try
            Dim result As Double = 0
            For Each vl As Double In values
                result /= vl
            Next
            Return result
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
