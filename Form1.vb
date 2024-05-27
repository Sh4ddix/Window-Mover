Imports System.Runtime.InteropServices
Public Class Form1
    ' Importieren der benötigten Funktionen aus der User32.dll
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function MoveWindow(hWnd As IntPtr, X As Integer, Y As Integer, nWidth As Integer, nHeight As Integer, bRepaint As Boolean) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowRect(hWnd As IntPtr, ByRef lpRect As RECT) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialisieren Sie das Label
        LoadTextBoxValues("textbox_values.txt")
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim windowName As String = TextBox3.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If String.IsNullOrEmpty(TextBox11.Text) OrElse String.IsNullOrEmpty(TextBox26.Text) Then
            MessageBox.Show("Bitte füllen Sie beide Textboxen aus.")
        Else
            If hWnd <> IntPtr.Zero Then
                Dim rect As RECT
                If GetWindowRect(hWnd, rect) Then
                    Dim width As Integer = rect.Right - rect.Left
                    Dim height As Integer = rect.Bottom - rect.Top

                    ' Verschiebe das Fenster zu den Koordinaten aus den Textboxen und behalte die aktuelle Größe bei
                    MoveWindow(hWnd, Convert.ToInt32(TextBox11.Text), Convert.ToInt32(TextBox26.Text), width, height, True)
                Else
                    MessageBox.Show("Fenstergröße konnte nicht ermittelt werden.")
                End If
            Else
                MessageBox.Show("Fenster nicht gefunden.")
            End If
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox1.Text = "aktiviert"
        Else
            CheckBox1.Text = "deaktiviert"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox2.Text = "aktiviert"
        Else
            CheckBox2.Text = "deaktiviert"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            CheckBox3.Text = "aktiviert"
        Else
            CheckBox3.Text = "deaktiviert"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            CheckBox4.Text = "aktiviert"
        Else
            CheckBox4.Text = "deaktiviert"
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            CheckBox5.Text = "aktiviert"
        Else
            CheckBox5.Text = "deaktiviert"
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            CheckBox6.Text = "aktiviert"
        Else
            CheckBox6.Text = "deaktiviert"
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked Then
            CheckBox7.Text = "aktiviert"
        Else
            CheckBox7.Text = "deaktiviert"
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then
            CheckBox8.Text = "aktiviert"
        Else
            CheckBox8.Text = "deaktiviert"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim windowName As String = TextBox3.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If hWnd <> IntPtr.Zero Then
            Dim rect As RECT
            If GetWindowRect(hWnd, rect) Then
                Dim x As Integer = rect.Left
                Dim y As Integer = rect.Top

                ' Zeige die aktuelle Fensterposition an
                TextBox11.Text = x.ToString()
                TextBox26.Text = y.ToString()
            Else
                MessageBox.Show("Fensterposition konnte nicht ermittelt werden.")
            End If
        Else
            MessageBox.Show("Fenster nicht gefunden.")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim windowName As String = TextBox4.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If hWnd <> IntPtr.Zero Then
            Dim rect As RECT
            If GetWindowRect(hWnd, rect) Then
                Dim x As Integer = rect.Left
                Dim y As Integer = rect.Top

                ' Zeige die aktuelle Fensterposition an
                TextBox12.Text = x.ToString()
                TextBox25.Text = y.ToString()
            Else
                MessageBox.Show("Fensterposition konnte nicht ermittelt werden.")
            End If
        Else
            MessageBox.Show("Fenster nicht gefunden.")
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim windowName As String = TextBox6.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If hWnd <> IntPtr.Zero Then
            Dim rect As RECT
            If GetWindowRect(hWnd, rect) Then
                Dim x As Integer = rect.Left
                Dim y As Integer = rect.Top

                ' Zeige die aktuelle Fensterposition an
                TextBox14.Text = x.ToString()
                TextBox24.Text = y.ToString()
            Else
                MessageBox.Show("Fensterposition konnte nicht ermittelt werden.")
            End If
        Else
            MessageBox.Show("Fenster nicht gefunden.")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim windowName As String = TextBox5.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If hWnd <> IntPtr.Zero Then
            Dim rect As RECT
            If GetWindowRect(hWnd, rect) Then
                Dim x As Integer = rect.Left
                Dim y As Integer = rect.Top

                ' Zeige die aktuelle Fensterposition an
                TextBox13.Text = x.ToString()
                TextBox23.Text = y.ToString()
            Else
                MessageBox.Show("Fensterposition konnte nicht ermittelt werden.")
            End If
        Else
            MessageBox.Show("Fenster nicht gefunden.")
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim windowName As String = TextBox10.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If hWnd <> IntPtr.Zero Then
            Dim rect As RECT
            If GetWindowRect(hWnd, rect) Then
                Dim x As Integer = rect.Left
                Dim y As Integer = rect.Top

                ' Zeige die aktuelle Fensterposition an
                TextBox18.Text = x.ToString()
                TextBox22.Text = y.ToString()
            Else
                MessageBox.Show("Fensterposition konnte nicht ermittelt werden.")
            End If
        Else
            MessageBox.Show("Fenster nicht gefunden.")
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim windowName As String = TextBox9.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If hWnd <> IntPtr.Zero Then
            Dim rect As RECT
            If GetWindowRect(hWnd, rect) Then
                Dim x As Integer = rect.Left
                Dim y As Integer = rect.Top

                ' Zeige die aktuelle Fensterposition an
                TextBox17.Text = x.ToString()
                TextBox21.Text = y.ToString()
            Else
                MessageBox.Show("Fensterposition konnte nicht ermittelt werden.")
            End If
        Else
            MessageBox.Show("Fenster nicht gefunden.")
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim windowName As String = TextBox8.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If hWnd <> IntPtr.Zero Then
            Dim rect As RECT
            If GetWindowRect(hWnd, rect) Then
                Dim x As Integer = rect.Left
                Dim y As Integer = rect.Top

                ' Zeige die aktuelle Fensterposition an
                TextBox16.Text = x.ToString()
                TextBox20.Text = y.ToString()
            Else
                MessageBox.Show("Fensterposition konnte nicht ermittelt werden.")
            End If
        Else
            MessageBox.Show("Fenster nicht gefunden.")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim windowName As String = TextBox7.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If hWnd <> IntPtr.Zero Then
            Dim rect As RECT
            If GetWindowRect(hWnd, rect) Then
                Dim x As Integer = rect.Left
                Dim y As Integer = rect.Top

                ' Zeige die aktuelle Fensterposition an
                TextBox15.Text = x.ToString()
                TextBox19.Text = y.ToString()
            Else
                MessageBox.Show("Fensterposition konnte nicht ermittelt werden.")
            End If
        Else
            MessageBox.Show("Fenster nicht gefunden.")
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        SaveTextBoxValues("textbox_values.txt")
    End Sub
    Private Sub LoadTextBoxValues(filePath As String)
        If Not System.IO.File.Exists(filePath) Then
            MessageBox.Show("Es wurde keine Datei mit Einstellungen gefunden!")
            Return
        End If

        Using reader As New System.IO.StreamReader(filePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim parts As String() = line.Split("="c)
                If parts.Length = 2 Then
                    Dim ctrlName As String = parts(0)
                    Dim ctrlValue As String = parts(1)
                    Dim ctrl As Control = Me.Controls.Find(ctrlName, True).FirstOrDefault()
                    If TypeOf ctrl Is TextBox Then
                        CType(ctrl, TextBox).Text = ctrlValue
                    End If
                End If
            End While
        End Using
    End Sub
    Private Sub SaveTextBoxValues(filePath As String)
        Using writer As New System.IO.StreamWriter(filePath)
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    writer.WriteLine(ctrl.Name & "=" & ctrl.Text)
                End If
            Next
        End Using
        MessageBox.Show("Werte gespeichert.")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim windowName As String = TextBox4.text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If String.IsNullOrEmpty(TextBox12.Text) OrElse String.IsNullOrEmpty(TextBox25.Text) Then
            MessageBox.Show("Bitte füllen Sie beide Textboxen aus.")
        Else
            If hWnd <> IntPtr.Zero Then
                Dim rect As RECT
                If GetWindowRect(hWnd, rect) Then
                    Dim width As Integer = rect.Right - rect.Left
                    Dim height As Integer = rect.Bottom - rect.Top

                    ' Verschiebe das Fenster zu den Koordinaten aus den Textboxen und behalte die aktuelle Größe bei
                    MoveWindow(hWnd, Convert.ToInt32(TextBox12.Text), Convert.ToInt32(TextBox25.Text), width, height, True)

                Else
                    MessageBox.Show("Fenstergröße konnte nicht ermittelt werden.")
                End If
            Else
                MessageBox.Show("Fenster nicht gefunden.")
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim windowName As String = TextBox6.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If String.IsNullOrEmpty(TextBox14.Text) OrElse String.IsNullOrEmpty(TextBox24.Text) Then
            MessageBox.Show("Bitte füllen Sie beide Textboxen aus.")
        Else
            If hWnd <> IntPtr.Zero Then
                Dim rect As RECT
                If GetWindowRect(hWnd, rect) Then
                    Dim width As Integer = rect.Right - rect.Left
                    Dim height As Integer = rect.Bottom - rect.Top

                    ' Verschiebe das Fenster zu den Koordinaten aus den Textboxen und behalte die aktuelle Größe bei
                    MoveWindow(hWnd, Convert.ToInt32(TextBox14.Text), Convert.ToInt32(TextBox24.Text), width, height, True)

                Else
                    MessageBox.Show("Fenstergröße konnte nicht ermittelt werden.")
                End If
            Else
                MessageBox.Show("Fenster nicht gefunden.")
            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim windowName As String = TextBox5.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If String.IsNullOrEmpty(TextBox13.Text) OrElse String.IsNullOrEmpty(TextBox23.Text) Then
            MessageBox.Show("Bitte füllen Sie beide Textboxen aus.")
        Else
            If hWnd <> IntPtr.Zero Then
                Dim rect As RECT
                If GetWindowRect(hWnd, rect) Then
                    Dim width As Integer = rect.Right - rect.Left
                    Dim height As Integer = rect.Bottom - rect.Top

                    ' Verschiebe das Fenster zu den Koordinaten aus den Textboxen und behalte die aktuelle Größe bei
                    MoveWindow(hWnd, Convert.ToInt32(TextBox13.Text), Convert.ToInt32(TextBox23.Text), width, height, True)

                Else
                    MessageBox.Show("Fenstergröße konnte nicht ermittelt werden.")
                End If
            Else
                MessageBox.Show("Fenster nicht gefunden.")
            End If
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim windowName As String = TextBox10.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If String.IsNullOrEmpty(TextBox18.Text) OrElse String.IsNullOrEmpty(TextBox22.Text) Then
            MessageBox.Show("Bitte füllen Sie beide Textboxen aus.")
        Else
            If hWnd <> IntPtr.Zero Then
                Dim rect As RECT
                If GetWindowRect(hWnd, rect) Then
                    Dim width As Integer = rect.Right - rect.Left
                    Dim height As Integer = rect.Bottom - rect.Top

                    ' Verschiebe das Fenster zu den Koordinaten aus den Textboxen und behalte die aktuelle Größe bei
                    MoveWindow(hWnd, Convert.ToInt32(TextBox18.Text), Convert.ToInt32(TextBox22.Text), width, height, True)
                Else
                    MessageBox.Show("Fenstergröße konnte nicht ermittelt werden.")
                End If
            Else
                MessageBox.Show("Fenster nicht gefunden.")
            End If
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim windowName As String = TextBox9.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If String.IsNullOrEmpty(TextBox17.Text) OrElse String.IsNullOrEmpty(TextBox21.Text) Then
            MessageBox.Show("Bitte füllen Sie beide Textboxen aus.")
        Else
            If hWnd <> IntPtr.Zero Then
                Dim rect As RECT
                If GetWindowRect(hWnd, rect) Then
                    Dim width As Integer = rect.Right - rect.Left
                    Dim height As Integer = rect.Bottom - rect.Top

                    ' Verschiebe das Fenster zu den Koordinaten aus den Textboxen und behalte die aktuelle Größe bei
                    MoveWindow(hWnd, Convert.ToInt32(TextBox17.Text), Convert.ToInt32(TextBox21.Text), width, height, True)
                Else
                    MessageBox.Show("Fenstergröße konnte nicht ermittelt werden.")
                End If
            Else
                MessageBox.Show("Fenster nicht gefunden.")
            End If
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim windowName As String = TextBox8.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If String.IsNullOrEmpty(TextBox16.Text) OrElse String.IsNullOrEmpty(TextBox22.Text) Then
            MessageBox.Show("Bitte füllen Sie beide Textboxen aus.")
        Else
            If hWnd <> IntPtr.Zero Then
                Dim rect As RECT
                If GetWindowRect(hWnd, rect) Then
                    Dim width As Integer = rect.Right - rect.Left
                    Dim height As Integer = rect.Bottom - rect.Top

                    ' Verschiebe das Fenster zu den Koordinaten aus den Textboxen und behalte die aktuelle Größe bei
                    MoveWindow(hWnd, Convert.ToInt32(TextBox16.Text), Convert.ToInt32(TextBox22.Text), width, height, True)
                Else
                    MessageBox.Show("Fenstergröße konnte nicht ermittelt werden.")
                End If
            Else
                MessageBox.Show("Fenster nicht gefunden.")
            End If
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim windowName As String = TextBox7.Text ' Ersetze durch den tatsächlichen Fenstertitel
        Dim hWnd As IntPtr = FindWindow(Nothing, windowName)

        If String.IsNullOrEmpty(TextBox15.Text) OrElse String.IsNullOrEmpty(TextBox19.Text) Then
            MessageBox.Show("Bitte füllen Sie beide Textboxen aus.")
        Else
            If hWnd <> IntPtr.Zero Then
                Dim rect As RECT
                If GetWindowRect(hWnd, rect) Then
                    Dim width As Integer = rect.Right - rect.Left
                    Dim height As Integer = rect.Bottom - rect.Top

                    ' Verschiebe das Fenster zu den Koordinaten aus den Textboxen und behalte die aktuelle Größe bei
                    MoveWindow(hWnd, Convert.ToInt32(TextBox15.Text), Convert.ToInt32(TextBox19.Text), width, height, True)
                Else
                    MessageBox.Show("Fenstergröße konnte nicht ermittelt werden.")
                End If
            Else
                MessageBox.Show("Fenster nicht gefunden.")
            End If
        End If

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If CheckBox1.Checked Then
            Button3.PerformClick()
        End If
        If CheckBox2.Checked Then
            Button4.PerformClick()
        End If
        If CheckBox3.Checked Then
            Button6.PerformClick()
        End If
        If CheckBox4.Checked Then
            Button5.PerformClick()
        End If
        If CheckBox5.Checked Then
            Button10.PerformClick()
        End If
        If CheckBox6.Checked Then
            Button9.PerformClick()
        End If
        If CheckBox7.Checked Then
            Button8.PerformClick()
        End If
        If CheckBox8.Checked Then
            Button7.PerformClick()
        End If
    End Sub
End Class
