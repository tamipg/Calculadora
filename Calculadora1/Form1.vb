



' Menú que permita pasar de modo estándar a modo científica (por ejemplo: Ver --> Estándar | Científica )
' En el modo cientifico, implementaremos las siguientes funciones: x^ 2, x ^ 3, x ^ y, n!


Public Class Form1
    Dim Operando1 As Double
    Dim Operando2 As Double
    Dim Result As Double
    Dim Operacion As String
    Dim interruptor As Boolean

    ' CONFIGURACION INICIAL
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Operacion = ""
        textInput.Text = 0
        Me.Width = 270
        Me.Text = "Calculadora Estándar"
    End Sub

    ' BOTONES NUMERICOS
    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click, cmd1.Click, cmd2.Click, cmd3.Click, cmd4.Click, cmd5.Click, cmd6.Click, cmd7.Click, cmd8.Click, cmd9.Click
        If interruptor = True Then
            textInput.Text = ""
            interruptor = False
        ElseIf textInput.Text = "0" Then
            textInput.Text = ""
        End If

        Dim bt As Button = sender
        textInput.Text &= bt.Text
    End Sub

    ' BOTON SUMAR
    Private Sub sumaButton_Click(sender As Object, e As EventArgs) Handles sumaButton.Click
        If Operacion = "" Then
            Operacion = "+"
            Operando1 = Val(textInput.Text)
            interruptor = True
            '  textHistorial.Text = Operando1.ToString
        Else
            igualButton.PerformClick()
            Operacion = "+"
        End If

    End Sub

    ' BOTON RESTAR
    Private Sub restaButton_Click(sender As Object, e As EventArgs) Handles restaButton.Click
        If Operacion = "" Then
            Operacion = "-"
            Operando1 = Val(textInput.Text)
            interruptor = True
            '   textHistorial.Text = Operando1.ToString
        Else
            igualButton.PerformClick()
            Operacion = "-"
        End If
    End Sub

    ' BOTON MULTIPLICAR
    Private Sub multiplicaButton_Click(sender As Object, e As EventArgs) Handles multiplicaButton.Click
        If Operacion = "" Then
            Operacion = "*"
            Operando1 = Val(textInput.Text)
            interruptor = True
            '  textHistorial.Text = Operando1.ToString
        Else
            igualButton.PerformClick()
            Operacion = "*"
        End If
    End Sub

    ' BOTON DIVIDIR
    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click
        If Operacion = "" Then
            Operacion = "/"
            Operando1 = Val(textInput.Text)
            interruptor = True
            ' textHistorial.Text = Operando1.ToString
        Else
            igualButton.PerformClick()
            Operacion = "/"
        End If
    End Sub

    ' BOTON INVERSA
    Private Sub inversaButton_Click(sender As Object, e As EventArgs) Handles inversaButton.Click
        Operando1 = Val(textInput.Text)
        ' textHistorial.Text = "1/ " + Operando1.ToString
        Result = 1 / Operando1
        Operacion = "1/x"
        interruptor = True
        textInput.Text = Result.ToString
        Operando1 = Val(Result)
    End Sub

    ' BOTON PORCENTAJE
    Private Sub porcentajeButton_Click(sender As Object, e As EventArgs) Handles porcentajeButton.Click
        Operando2 = Val(textInput.Text)
        ' textHistorial.Text = Operando2
        interruptor = True

        If Operacion = "+" Then
            Result = Operando1 + (Operando1 / 100 * Operando2)
            textInput.Text = Result
            Operacion = ""
        ElseIf Operacion = "-" Then
            Result = Operando1 - (Operando1 / 100 * Operando2)
            textInput.Text = Result
            Operacion = ""
        ElseIf Operacion = "*" Then
            Operando2 = Operando2 / 100
            Result = Operando1 * Operando2
            textInput.Text = Operando2.ToString
            Operacion = "%"
        ElseIf Operacion = "/" Then
            Operando2 = Operando2 / 100
            Result = Operando1 / Operando2
            textInput.Text = Operando2.ToString
            Operacion = "%"
        End If


    End Sub


    ' BOTON IGUAL
    Private Sub igualButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles igualButton.Click
        Operando2 = Val(textInput.Text)
        interruptor = True
        ' SUMA
        If Operacion = "+" Then
            Result = Operando1 + Operando2
            textInput.Text = Result
            Operacion = ""
            Operando1 = Result
            interruptor = True
            '    textHistorial.Text = Operando1.ToString
            ' RESTA
        ElseIf Operacion = "-" Then
            Result = Operando1 - Operando2
            textInput.Text = Result
            Operacion = ""
            Operando1 = Result
            interruptor = True
            '   textHistorial.Text = Operando1.ToString
            ' MULTIPLICACION
        ElseIf Operacion = "*" Then
            Result = Operando1 * Operando2
            textInput.Text = Result.ToString
            Operacion = ""
            Operando1 = Result
            interruptor = True
            '  textHistorial.Text = Operando1.ToString
            ' DIVISION
        ElseIf Operacion = "/" Then
            Result = Operando1 / Operando2
            textInput.Text = Result.ToString
            Operacion = ""
            Operando1 = Result
            interruptor = True
            ' textHistorial.Text = Operando1.ToString
            ' PORCENTAJE
        ElseIf Operacion = "%" Then
            textInput.Text = Result.ToString
        End If

    End Sub


    ' BOTON PUNTO
    Private Sub dotButton_Click(sender As Object, e As EventArgs) Handles dotButton.Click
        If textInput.Text = "" Then
            textInput.Text = "0,"
            Operando1 = textInput.Text
        End If

        If textInput.Text.Contains(",") = False Then
            textInput.Text = textInput.Text & ","
            Operando1 = textInput.Text
        End If
    End Sub





    ' BOTON CAMBIO DE SIGNO
    Private Sub signoButton_Click(sender As Object, e As EventArgs) Handles signoButton.Click

        If textInput.Text.Contains("-") Then
            Dim shownum As String
            shownum = textInput.Text
            shownum = shownum.Remove(0, 1)
            textInput.Text = shownum
        Else
            If textInput.Text = 0 Then
                textInput.Text = "-"
            Else
                textInput.Text = "-" + textInput.Text
            End If
        End If
    End Sub

    ' BOTON CE
    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        textInput.Text = 0
    End Sub

    ' BOTON C
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        textInput.Text = 0
        ' textHistorial.Text = 0
        Operando1 = 0
        Operando2 = 0
        Operacion = ""
        Result = 0
        interruptor = False
    End Sub

    ' BOTON <- 
    Private Sub backSpaceButton_Click(sender As Object, e As EventArgs) Handles backSpaceButton.Click
        Dim shownum As String
        If textInput.Text <> "" Then
            shownum = textInput.Text
            shownum = shownum.Remove(shownum.Length - 1, 1)
            textInput.Text = shownum
        End If
        If textInput.Text = "" Then textInput.Text = "0"
    End Sub

    ' CALCULADORA ESTANDAR
    Private Sub std_Click(sender As Object, e As EventArgs) Handles std.Click
        Me.Width = 270
        Me.Text = "Calculadora Estándar"
    End Sub

    ' CALCULADORA CIENTIFICA
    Private Sub sci_Click(sender As Object, e As EventArgs) Handles sci.Click
        Me.Width = 338
        Me.Text = "Calculadora Científica"
    End Sub
End Class
