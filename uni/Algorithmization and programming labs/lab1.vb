Public Class lab1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text As String
        text = "1.Задать длину ребра куба. Найти объем куба и площадь его поверхности."
        Dim a, s, v As Integer
        a = Val(InputBox("длину ребра куба"))
        s = a ^ 3
        v = 6 * a ^ 2
        MsgBox(text & vbNewLine & "объем куба = " & s & vbNewLine & "площадь куба = " & v)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim text As String
        text = "2.Задать три действительных положительных числа. Найти среднее арифметическое и среднее геометрическое этих чисел."
        Dim a, b, c, s, v As Decimal
        a = Val(InputBox("enter the 1st num"))
        b = Val(InputBox("enter the 2st num"))
        c = Val(InputBox("enter the 3st num"))
        s = (a + b + c) / 3
        v = (a * b * c) ^ (1 / 3)
        MsgBox(Text & vbNewLine & "среднее арифметическое = " & s & vbNewLine & "среднее геометрическое = " & v)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim text As String
        text = "3.Число А составляет 25% от числа В, которое в свою очередь составляет 18% от числа С, а С=369. Найти А и В."
        Dim c, a, b As Decimal
        c = 369
        b = ((18 * c) / 100)
        a = ((25 * b) / 100)
        MsgBox(Text & vbNewLine & "The Value of A is: " & a & vbNewLine & "The Value of B is: " & b)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim text As String
        text = "4.Для изготовления заготовки ботинок рабочий тратит 2 мин. Сколько заготовок рабочий изготовит за 7 часов?"
        Dim a, b, s As Integer
        a = 7
        b = 7 * 60
        s = b / 2
        MsgBox(Text & vbNewLine & s)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim text As String
        text = "5.При производстве пряжи из каждого килограмма сырья получают 0,93 кг пряжи, отходы составляют 0,06 кг, потери – 0,01 кг. Сколько пряжи, отходов и потерь получим из 12 т сырья?"
        Dim production, waste, losses As Decimal
        production = 12000 * 0.93
        waste = 12000 * 0.06
        losses = 12000 * 0.01
        MsgBox(text & vbNewLine & "Из 12 т сырья " & vbNewLine & "получают: " & production & " кг пряжи " & vbNewLine &
               "отходы составляют: " & waste & " кг " & vbNewLine & "потери: " & losses & " кг")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim text As String
        text = "6.Сколько заготовок круглой формы можно получить из куска материи длиной 12 и шириной 1,4 м., если радиус заготовки =15 см? Определить площадь отходов. Центры заготовок должны располагаться на одной линии. "
        Dim long1, wide, Determine
        long1 = Fix(1.4 / 0.3)
        wide = (12 / 0.3)
        Determine = long1 * wide
        MsgBox(text & vbNewLine & " =" & Determine)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim text As String
        text = "7.Вычислите расстояние между двумя точками с координатами X1, Y1 и X2, Y2."
        Dim x1, y1, x2, y2, distance As Decimal
        x1 = Val(InputBox("enter x1 "))
        y1 = Val(InputBox("enter y1 "))
        x2 = Val(InputBox("enter x2 "))
        y2 = Val(InputBox("enter y2 "))
        distance = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2)
        MsgBox(text & vbNewLine & "the distance between two points is: " & distance)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim text As String
        text = "8.Сколько процентов от (А + В – С) приходится на А, В и С?"
        Dim a, b, c, s, v As Decimal
        a = Val(InputBox("enter A"))
        b = Val(InputBox("enter B"))
        c = Val(InputBox("enter C"))
        MsgBox(text & vbNewLine & "percentage of (A + B - C) from A = " & (((a + b - c) * 100) / a) & "%" & vbNewLine &
               "percentage of (A + B - C) from B = " & (((a + b - c) * 100) / b) & "%" & vbNewLine &
               "percentage of (A + B - C) from C = " & (((a + b - c) * 100) / c) & "%")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim text As String
        text = "9.Производительность формовочной машины – 7 тарелок в 1 мин. Сколько тарелок выпустят три машины за 6 час?"
        Dim a, b, s As Integer
        a = 6
        b = 6 * 60
        s = b / 3
        MsgBox(Text & vbNewLine & s)
    End Sub
End Class

