Module DisableAddMovies

    'Este método está creado para deshabilitar la opción de Ingresar Películas y tandas del MenuStrip
    Public Sub IngresarPeliculasEnable(ByRef IngresarPeliculaEnable As Boolean)
        If IngresarPeliculaEnable Then
            comprarBoleto.IngresarPelículaYTandasToolStripMenuItem.Enabled = False
            ConsultarPelicula.IngresarPelículaYTandasToolStripMenuItem.Enabled = False
            RevisarAsientos.IngresarPelículaYTandasToolStripMenuItem.Enabled = False
            IngresarPeliculas.IngresarPelículaYTandasToolStripMenuItem.Enabled = False
        End If
    End Sub
End Module
