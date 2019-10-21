Imports System.ComponentModel

Public Class IngresarPeliculas

    'Declaración de las variables que almacenarán las rutas de las imágenes
    Dim ruta1 As String = ""
    Dim ruta2 As String = ""
    Dim ruta3 As String = ""
    Dim ruta4 As String = ""

    'Variable que impedirá que se cambie de ventana hasta haber completado todo
    Dim cambioVentana As Integer = 0

    'Variables que almacenaran los horarios ingresados
    Dim horario1(), horario2(), horario3(), horario4() As String

    'Controles de las opciones del MenuStrip
    Private Sub BienvenidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BienvenidaToolStripMenuItem.Click
        bienvenida.Show()
        Me.Hide()
    End Sub
    'Evento click para decir que ya te encuentras en la ventana
    Private Sub IngresarPelículaYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPelículaYTandasToolStripMenuItem.Click
        MsgBox("Ya estás en esta ventana")
    End Sub

    'Evento para cambiar de ventana a totales
    Private Sub VerTotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTotalesToolStripMenuItem.Click
        'Aquí se controla que no se puede cambiar de ventana hasta que se haya completado todo
        If cambioVentana = 1 Then
            Totales.Show()
            Me.Hide()
        Else
            MsgBox("No puedes salir de esta ventana hasta rellenear todos los campos")
        End If
    End Sub
    'Consulta de peliculas
    Private Sub ConsultarPelículasYTandasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPelículasYTandasToolStripMenuItem.Click
        'Aquí se controla que no se puede cambiar de ventana hasta que se haya completado todo
        If cambioVentana = 1 Then
            ConsultarPelicula.Show()
            Me.Hide()
        Else
            MsgBox("No puedes salir de esta ventana hasta rellenear todos los campos")
        End If
    End Sub
    'Evento click para ver pantalla de asientos
    Private Sub VerAsientosDisponiblesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerAsientosDisponiblesToolStripMenuItem.Click
        'Aquí se controla que no se puede cambiar de ventana hasta que se haya completado todo
        If cambioVentana = 1 Then
            RevisarAsientos.Show()
            Me.Hide()
        Else
            MsgBox("No puedes salir de esta ventana hasta rellenear todos los campos")
        End If
    End Sub

    'Al presionar el botón Cargar Película de cada Sala se abrirá una ventana para seleccionar la imagen que se mostrará. A su vez, esta se asigna.
    Private Sub BtnCargarImagenPelicula1_Click(sender As Object, e As EventArgs) Handles btnCargarImagenPelicula1.Click
        'Si el diálogo aparece bien, se asigna la imagen al PictureBox
        If pfdCargaImagen.ShowDialog = DialogResult.OK Then
            pbImagenAñadidaPelicula1.ImageLocation = pfdCargaImagen.FileName.ToString
            ruta1 = pbImagenAñadidaPelicula1.ImageLocation
        Else
            'Sino no se le asigna nada
            ruta1 = ""
        End If
    End Sub
    'Evento click para cargar imagen
    Private Sub BtnCargarImagenPelicula2_Click(sender As Object, e As EventArgs) Handles btnCargarImagenPelicula2.Click
        If pfdCargaImagen.ShowDialog = DialogResult.OK Then
            pbImagenAñadidaPelicula2.ImageLocation = pfdCargaImagen.FileName.ToString
            ruta2 = pbImagenAñadidaPelicula2.ImageLocation
        Else
            ruta2 = ""
        End If
    End Sub
    'Evento click para cargar imagen
    Private Sub BtnCargarImagenPelicula3_Click(sender As Object, e As EventArgs) Handles btnCargarImagenPelicula3.Click
        If pfdCargaImagen.ShowDialog = DialogResult.OK Then
            pbImagenAñadidaPelicula3.ImageLocation = pfdCargaImagen.FileName.ToString
            ruta3 = pbImagenAñadidaPelicula3.ImageLocation
        Else
            ruta3 = ""
        End If
    End Sub
    'Evento click para cargar imagen
    Private Sub BtnCargarImagenPelicula4_Click(sender As Object, e As EventArgs) Handles btnCargarImagenPelicula4.Click
        If pfdCargaImagen.ShowDialog = DialogResult.OK Then
            pbImagenAñadidaPelicula4.ImageLocation = pfdCargaImagen.FileName.ToString
            ruta4 = pbImagenAñadidaPelicula4.ImageLocation
        Else
            ruta4 = ""
        End If
    End Sub

    'Este botón agregará el horario seleccionado en el combobox al listbox.
    Private Sub BtnAgregarHorario1_Click(sender As Object, e As EventArgs) Handles btnAgregarHorario1.Click
        'Si no se ha seleccionado nada en el comboBox saltará un mensaje. 
        If (cmbAgregarHorario1.SelectedItem = "") Then
            MsgBox("Seleccione un horario para la película", MsgBoxStyle.Critical)
            'En caso contrario, se almacena lo seleccionado en el combobox en el listbox
        Else
            lbHorariosAgregados1.Items.Add(cmbAgregarHorario1.SelectedItem)
        End If

        'Este método evita que haya valores repetidos en el listbox
        Dim items(lbHorariosAgregados1.Items.Count - 1) As Object
        lbHorariosAgregados1.Items.CopyTo(items, 0)
        lbHorariosAgregados1.Items.Clear()
        lbHorariosAgregados1.Items.AddRange(items.AsEnumerable().Distinct().ToArray())

        'Esta sección de aquí manda la información del listbox al método que lo almacena para devolverlo en otras pantallas
        Dim Size, i As Integer
        Size = Me.lbHorariosAgregados1.Items.Count - 1
        ReDim horario1(0 To Size)

        For i = 0 To Size
            horario1(i) = Me.lbHorariosAgregados1.Items(i).ToString
        Next i

    End Sub
    'Evento click para agregar horario
    Private Sub BtnAgregarHorario2_Click(sender As Object, e As EventArgs) Handles btnAgregarHorario2.Click
        'Si no se ha seleccionado un horario se saltara un error
        If (cmbAgregarHorario2.SelectedItem = "") Then
            MsgBox("Seleccione un horario para la película", MsgBoxStyle.Critical)
        Else
            lbHorariosAgregados2.Items.Add(cmbAgregarHorario2.SelectedItem)
        End If

        'Este método evita que haya valores repetidos en el listbox
        Dim items(lbHorariosAgregados2.Items.Count - 1) As Object
        lbHorariosAgregados2.Items.CopyTo(items, 0)
        lbHorariosAgregados2.Items.Clear()
        lbHorariosAgregados2.Items.AddRange(items.AsEnumerable().Distinct().ToArray())

        'Esta sección de aquí manda la información del listbox al método que lo almacena para devolverlo en otras pantallas
        Dim Size, i As Integer
        Size = Me.lbHorariosAgregados2.Items.Count - 1
        ReDim horario2(0 To Size)

        For i = 0 To Size
            horario2(i) = Me.lbHorariosAgregados2.Items(i).ToString
        Next i
    End Sub
    'Evento click para agregar horario
    Private Sub BtnAgregarHorario3_Click(sender As Object, e As EventArgs) Handles btnAgregarHorario3.Click
        'Si no se ha seleccionado nada en el comboBox saltará un mensaje. 
        If (cmbAgregarHorario3.SelectedItem = "") Then
            MsgBox("Seleccione un horario para la película", MsgBoxStyle.Critical)
        Else
            lbHorariosAgregados3.Items.Add(cmbAgregarHorario3.SelectedItem)
        End If
        'Este método evita que haya valores repetidos en el listbox
        Dim items(lbHorariosAgregados3.Items.Count - 1) As Object
        lbHorariosAgregados3.Items.CopyTo(items, 0)
        lbHorariosAgregados3.Items.Clear()
        lbHorariosAgregados3.Items.AddRange(items.AsEnumerable().Distinct().ToArray())

        'Esta sección de aquí manda la información del listbox al método que lo almacena para devolverlo en otras pantallas
        Dim Size, i As Integer
        Size = Me.lbHorariosAgregados3.Items.Count - 1
        ReDim horario3(0 To Size)

        For i = 0 To Size
            horario3(i) = Me.lbHorariosAgregados3.Items(i).ToString
        Next i
    End Sub
    'Evento click para agregar horario
    Private Sub BtnAgregarHorario4_Click(sender As Object, e As EventArgs) Handles btnAgregarHorario4.Click
        'Si no se ha seleccionado nada en el comboBox saltará un mensaje. 
        If (cmbAgregarHorario4.SelectedItem = "") Then
            MsgBox("Seleccione un horario para la película", MsgBoxStyle.Critical)
        Else
            lbHorariosAgregados4.Items.Add(cmbAgregarHorario4.SelectedItem)
        End If
        'Este método evita que haya valores repetidos en el listbox
        Dim items(lbHorariosAgregados4.Items.Count - 1) As Object
        lbHorariosAgregados4.Items.CopyTo(items, 0)
        lbHorariosAgregados4.Items.Clear()
        lbHorariosAgregados4.Items.AddRange(items.AsEnumerable().Distinct().ToArray())
        'Esta sección de aquí manda la información del listbox al método que lo almacena para devolverlo en otras pantallas
        Dim Size, i As Integer
        Size = Me.lbHorariosAgregados4.Items.Count - 1
        ReDim horario4(0 To Size)

        For i = 0 To Size
            horario4(i) = Me.lbHorariosAgregados4.Items(i).ToString
        Next i

    End Sub
    'Evento para cargar todos los datos
    Private Sub BtnFinalizarIngresoPeliculas_Click(sender As Object, e As EventArgs) Handles btnFinalizarIngresoPeliculas.Click
        Movies.Sala1(txtAñadirNombrePelicula1.Text, dtpAñadirFechaPelicula1.Value, ruta1, horario1)
        Movies.Sala2(txtAñadirNombrePelicula2.Text, dtpAñadirFechaPelicula2.Value, ruta2, horario2)
        Movies.Sala3(txtAñadirNombrePelicula3.Text, dtpAñadirFechaPelicula3.Value, ruta3, horario3)
        Movies.Sala4(txtAñadirNombrePelicula4.Text, dtpAñadirFechaPelicula4.Value, ruta4, horario4)
        'Si que controla que todos los datos esten llenos
        If lbHorariosAgregados1.Items.Count = 0 Or txtAñadirNombrePelicula1.Text = "" Or ruta1 = "" Then
            MsgBox("Rellene los datos de la sala 1", MsgBoxStyle.Critical)
        ElseIf lbHorariosAgregados2.Items.Count = 0 Or txtAñadirNombrePelicula2.Text = "" Or ruta2 = "" Then
            MsgBox("Rellene los datos de la sala 2", MsgBoxStyle.Critical)
        ElseIf lbHorariosAgregados3.Items.Count = 0 Or txtAñadirNombrePelicula3.Text = "" Or ruta3 = "" Then
            MsgBox("Rellene los datos de la sala 3", MsgBoxStyle.Critical)
        ElseIf lbHorariosAgregados4.Items.Count = 0 Or txtAñadirNombrePelicula4.Text = "" Or ruta4 = "" Then
            MsgBox("Rellene los datos de la sala 4", MsgBoxStyle.Critical)
        Else
            cambioVentana = 1
            ConsultarPelicula.Show()
            DisableAddMovies.IngresarPeliculasEnable(True)
            Me.Hide()
        End If

    End Sub
    'validadcion de que se llene el nombre de la pelicula 
    Private Sub txtAñadirNombrePelicula1_Validating(sender As Object, e As CancelEventArgs) Handles txtAñadirNombrePelicula1.Validating
        If txtAñadirNombrePelicula1.Text = "" Then
            MsgBox("Rellene el campo nombre de la película 1", MsgBoxStyle.Critical)
            e.Cancel = True
        ElseIf IsNumeric(txtAñadirNombrePelicula1.Text) Then
            MsgBox("Introduzca un nombre para la película 1", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtAñadirNombrePelicula2_Validating(sender As Object, e As CancelEventArgs) Handles txtAñadirNombrePelicula2.Validating
        If txtAñadirNombrePelicula2.Text = "" Then
            MsgBox("Rellene el campo nombre de la película 2", MsgBoxStyle.Critical)
            e.Cancel = True
        ElseIf IsNumeric(txtAñadirNombrePelicula2.Text) Then
            MsgBox("Introduzca un nombre para la película 2", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtAñadirNombrePelicula3_Validating(sender As Object, e As CancelEventArgs) Handles txtAñadirNombrePelicula3.Validating
        If txtAñadirNombrePelicula3.Text = "" Then
            MsgBox("Rellene el campo nombre de la película 3", MsgBoxStyle.Critical)
            e.Cancel = True
        ElseIf IsNumeric(txtAñadirNombrePelicula3.Text) Then
            MsgBox("Introduzca un nombre para la película 3", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtAñadirNombrePelicula4_Validating(sender As Object, e As CancelEventArgs) Handles txtAñadirNombrePelicula4.Validating
        If txtAñadirNombrePelicula4.Text = "" Then
            MsgBox("Rellene el campo nombre de la película 4", MsgBoxStyle.Critical)
            e.Cancel = True
        ElseIf IsNumeric(txtAñadirNombrePelicula4.Text) Then
            MsgBox("Introduzca un nombre para la película 4", MsgBoxStyle.Critical)
            e.Cancel = True
        End If
    End Sub

End Class