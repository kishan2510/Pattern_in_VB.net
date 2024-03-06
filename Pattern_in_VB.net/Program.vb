Imports System
Imports System.Security.Principal

Module Program
    Sub Main(args As String())
        Dim n As Integer
        Console.WriteLine("Enter the number of rows:- ")
        n = Convert.ToInt32(Console.ReadLine())
        Hollow_Square(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Number_triangle_pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Number_increasing_Pyramid_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Number_increasing_reverse_Pyramid_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Number_changing_Pyramid_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Zero_One_Triangle_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Palindrome_Triangle_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Rhombus_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Diamond_Star_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Mirror_Image_Triangle_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Hollow_Triangle_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Hollow_Reverse_Triangle_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Hollow_Hourglass_Pattern(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Hollow_Diamond_Pyramid(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")
        Pascal_Triangle(n)
        Console.Write("-------------------------------------------")
        Console.WriteLine(" ")







    End Sub

    Public Sub Hollow_Square(ByVal n As Integer)
        For i As Integer = 0 To n - 1
            Console.Write("*")
            For j As Integer = 1 To n - 2
                If i = 0 Or i = n - 1 Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next j
            Console.WriteLine("*")
        Next i
    End Sub

    Public Sub Number_triangle_pattern(ByVal n As Integer)
        For i As Integer = 1 To n
            For s As Integer = n To i Step -1
                Console.Write(" ")
            Next s
            For k As Integer = 1 To i
                Console.Write(i)
                Console.Write(" ")

            Next k
            Console.WriteLine()

        Next i

    End Sub

    Public Sub Number_increasing_Pyramid_Pattern(ByVal n As Integer)
        For i As Integer = 1 To n
            For j As Integer = 1 To i
                Console.Write(j)
                Console.Write(" ")

            Next
            Console.WriteLine()

        Next


    End Sub

    Public Sub Number_increasing_reverse_Pyramid_Pattern(ByVal n As Integer)
        For i As Integer = n To 1 Step -1

            For j As Integer = 1 To i
                Console.Write(j)
                Console.Write(" ")

            Next
            Console.WriteLine()

        Next

    End Sub

    Public Sub Number_changing_Pyramid_Pattern(ByVal n As Integer)
        Dim count As Integer = 1
        For i As Integer = 1 To n
            For j As Integer = 1 To i
                Console.Write(count)
                count += 1
                Console.Write(" ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub Zero_One_Triangle_Pattern(ByVal n As Integer)
        For i As Integer = 1 To n
            For j As Integer = 1 To i
                If (i + j) Mod 2 = 0 Then
                    Console.Write(1)
                Else
                    Console.Write(0)
                End If
                Console.Write(" ")

            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub Palindrome_Triangle_Pattern(ByVal n As Integer)
        For i As Integer = 1 To n
            For s As Integer = n To i Step -1
                Console.Write("  ")
            Next
            For j As Integer = i To 1 Step -1
                Console.Write(j & " ")
            Next
            For k As Integer = 2 To i
                Console.Write(k & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub Rhombus_Pattern(ByVal n As Integer)
        For i As Integer = 1 To n
            For s As Integer = n - 1 To i Step -1
                Console.Write(" ")
            Next
            For k As Integer = 1 To n
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub Diamond_Star_Pattern(ByVal n As Integer)
        For i As Integer = 1 To n
            For s As Integer = n - 1 To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To 2 * i - 1
                Console.Write("*")
            Next
            Console.WriteLine()

        Next
        For i As Integer = n - 1 To 1 Step -1
            For s As Integer = n - 1 To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To 2 * i - 1
                Console.Write("*")
            Next
            Console.WriteLine()

        Next
    End Sub

    Public Sub Hollow_Triangle_Pattern(ByVal n As Integer)
        For i As Integer = 1 To n
            For s As Integer = n - 1 To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To 2 * i - 2
                If i = 1 OrElse j = 1 OrElse i = n Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If


            Next
            Console.Write("*")
            Console.WriteLine()
        Next

    End Sub

    Public Sub Mirror_Image_Triangle_Pattern(ByVal n As Integer)
        For i As Integer = 1 To n
            For s As Integer = 1 To i - 1
                Console.Write(" ")
            Next
            For j As Integer = i To n
                Console.Write(j & " ")
            Next
            Console.WriteLine()
        Next

        For i As Integer = n - 1 To 1 Step -1
            For s As Integer = 1 To i - 1
                Console.Write(" ")
            Next
            For j As Integer = i To n
                Console.Write(j & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Public Sub Hollow_Reverse_Triangle_Pattern(ByVal n As Integer)
        For i As Integer = n To 1 Step -1
            For s As Integer = n - 1 To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To 2 * i - 2
                If i = 1 OrElse j = 1 OrElse i = n Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If


            Next
            Console.Write("*")
            Console.WriteLine()
        Next
    End Sub

    Public Sub Hollow_Hourglass_Pattern(ByVal n As Integer)
        For i As Integer = n To 1 Step -1
            For s As Integer = n - 1 To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To 2 * i - 2
                If i = 1 OrElse j = 1 OrElse i = n Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If


            Next
            Console.Write("*")
            Console.WriteLine()
        Next
        For i As Integer = 2 To n
            For s As Integer = n - 1 To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To 2 * i - 2
                If i = 1 OrElse j = 1 OrElse i = n Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If


            Next
            Console.Write("*")
            Console.WriteLine()
        Next
    End Sub

    Public Sub Hollow_Diamond_Pyramid(ByVal n As Integer)
        For i As Integer = 1 To n
            For s As Integer = n - 1 To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To 2 * i - 2
                If i = 1 OrElse j = 1 Then

                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If

            Next
            Console.Write("*")
            Console.WriteLine()
        Next
        For i As Integer = n - 1 To 1 Step -1
            For s As Integer = n - 1 To i Step -1
                Console.Write(" ")
            Next
            For j As Integer = 1 To 2 * i - 2
                If i = 1 OrElse j = 1 Then

                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If

            Next
            Console.Write("*")
            Console.WriteLine()
        Next
    End Sub

    Public Sub Pascal_Triangle(ByVal n As Integer)
        For i As Integer = 0 To n
            Dim c As Integer = 1
            For j As Integer = 0 To n - i - 1
                Console.Write(" ")
            Next
            For k As Integer = 0 To i
                Console.Write(c & " ")
                c = c * (i - k) / (k + 1)
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
