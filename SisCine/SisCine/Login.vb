Imports System.Diagnostics.Eventing.Reader

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim t As String = "SISTEMA DE CINE  "
        Static Dim ti As String = ""
        Static Dim ind As Integer

        If ind = t.Length Then
            ind = 0
            ti = ""
        End If

        For i = ind To t.Length - 1
            ti += t.Substring(i, 1)
            ind += 1
            Exit For
        Next

        Me.Text = ti

    End Sub

    'Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
    '    If txtusuario.Text <> "DELION" And txtcontraseña.Text <> "DELION" Then
    '        If login_Acesso(txtusuario.Text, txtcontraseña.Text) Then
    '            Me.Hide()
    '            InterfazPrincipal.Show()
    '        Else
    '            MessageBox.Show("Usuario o Contraseña no valido")
    '        End If
    '    End If
    'End Sub

    'Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
    '    If MsgBox("¿Desea Salir del Sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
    '        End
    '    End If
    'End Sub
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click

        Dim usuario As String
        Dim contraseña As String
        usuario = txtusuario.Text
        contraseña = txtcontraseña.Text
        If (usuario = "Admin" Or usuario = "Cliente") And (contraseña = "12345" Or contraseña = "contraseña") Then

            InterfazPrincipal.Show()


        Else
            If MsgBox("Usuario o Contraseña incorrecta, verifique", MsgBoxStyle.Information) Then

            End If
        End If

        'If (usuario = "Cliente") And (contraseña = "123") Then
        '    InterfazPrincipal.Show()
        '    AgregarPeliculas.Visible = False
        '    AsignarCartelera.Visible = False
        '    MantenimientoPeliculas.Visible = False



        'Else
        '    If MsgBox("Usuario o Contraseña incorrecta, verifique", MsgBoxStyle.Information) Then

        '    End If
        'End If
        'txtcontraseña.Text = ""
        'txtusuario.Text = ""

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        If MsgBox("¿Desea Salir del Sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then

        End If
    End Sub

End Class