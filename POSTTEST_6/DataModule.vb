Imports MySqlConnector

Module DataModule
    Public Function GetAllMember() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT idMember AS 'ID Member', nama AS 'Nama', " &
                "paket AS 'Paket', noHP AS 'No. HP', " &
                "DATE_FORMAT(tanggalDaftar, '%d/%m/%Y') AS 'Tgl. Daftar', " &
                "status AS 'Status' FROM tbmember ORDER BY idMember ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchMember(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT idMember AS 'ID Member', nama AS 'Nama', " &
                "paket AS 'Paket', noHP AS 'No. HP', " &
                "DATE_FORMAT(tanggalDaftar, '%d/%m/%Y') AS 'Tgl. Daftar', " &
                "status AS 'Status' FROM tbmember " &
                "WHERE idMember LIKE @kw OR nama LIKE @kw OR paket LIKE @kw OR status LIKE @kw " &
                "ORDER BY idMember ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function IDSudahAda(id As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM tbmember WHERE idMember = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanMember(id As String, nama As String, paket As String, noHP As String, tgl As String, status As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbmember (idMember, nama, paket, noHP, tanggalDaftar, status) " &
                "VALUES (@id, @nama, @paket, @noHP, @tgl, @status)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@paket", paket)
                    cmd.Parameters.AddWithValue("@noHP", noHP)
                    cmd.Parameters.AddWithValue("@tgl", tgl)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahMember(id As String, nama As String, paket As String, noHP As String, tgl As String, status As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbmember SET nama=@nama, paket=@paket, noHP=@noHP, " &
                "tanggalDaftar=@tgl, status=@status WHERE idMember=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@paket", paket)
                    cmd.Parameters.AddWithValue("@noHP", noHP)
                    cmd.Parameters.AddWithValue("@tgl", tgl)
                    cmd.Parameters.AddWithValue("@status", status)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusMember(id As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "DELETE FROM tbmember WHERE idMember = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllInstruktur() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT i.idInstruktur AS 'ID Instruktur', " &
                "m.nama AS 'Nama Member', " &
                "i.namaInstruktur AS 'Nama Instruktur', " &
                "i.spesialisasi AS 'Spesialisasi', " &
                "i.noHPInstruktur AS 'No. HP', " &
                "i.jadwal AS 'Jadwal', " &
                "i.catatan AS 'Catatan' " &
                "FROM tbinstruktur i " &
                "INNER JOIN tbmember m ON i.idMember = m.idMember " &
                "ORDER BY i.idInstruktur ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data instruktur: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchInstruktur(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT i.idInstruktur AS 'ID Instruktur', " &
                "m.nama AS 'Nama Member', " &
                "i.namaInstruktur AS 'Nama Instruktur', " &
                "i.spesialisasi AS 'Spesialisasi', " &
                "i.noHPInstruktur AS 'No. HP', " &
                "i.jadwal AS 'Jadwal', " &
                "i.catatan AS 'Catatan' " &
                "FROM tbinstruktur i " &
                "INNER JOIN tbmember m ON i.idMember = m.idMember " &
                "WHERE i.namaInstruktur LIKE @kw OR i.spesialisasi LIKE @kw " &
                "OR m.nama LIKE @kw OR i.jadwal LIKE @kw " &
                "ORDER BY i.idInstruktur ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data instruktur: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function IDInstrukturSudahAda(id As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM tbinstruktur WHERE idInstruktur = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function GetInstrukturByID(id As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT * FROM tbinstruktur WHERE idInstruktur = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanInstruktur(idInstruktur As String, idMember As String,
                                     namaInstruktur As String, spesialisasi As String,
                                     noHP As String, jadwal As String,
                                     catatan As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbinstruktur (idInstruktur, idMember, namaInstruktur, " &
                "spesialisasi, noHPInstruktur, jadwal, catatan) " &
                "VALUES (@idI, @idM, @nama, @spesial, @noHP, @jadwal, @catatan)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idI", idInstruktur)
                    cmd.Parameters.AddWithValue("@idM", idMember)
                    cmd.Parameters.AddWithValue("@nama", namaInstruktur)
                    cmd.Parameters.AddWithValue("@spesial", spesialisasi)
                    cmd.Parameters.AddWithValue("@noHP", noHP)
                    cmd.Parameters.AddWithValue("@jadwal", jadwal)
                    cmd.Parameters.AddWithValue("@catatan", catatan)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data instruktur: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahInstruktur(idInstruktur As String, idMember As String,
                                   namaInstruktur As String, spesialisasi As String,
                                   noHP As String, jadwal As String,
                                   catatan As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbinstruktur SET idMember=@idM, namaInstruktur=@nama, " &
                "spesialisasi=@spesial, noHPInstruktur=@noHP, " &
                "jadwal=@jadwal, catatan=@catatan " &
                "WHERE idInstruktur=@idI"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idI", idInstruktur)
                    cmd.Parameters.AddWithValue("@idM", idMember)
                    cmd.Parameters.AddWithValue("@nama", namaInstruktur)
                    cmd.Parameters.AddWithValue("@spesial", spesialisasi)
                    cmd.Parameters.AddWithValue("@noHP", noHP)
                    cmd.Parameters.AddWithValue("@jadwal", jadwal)
                    cmd.Parameters.AddWithValue("@catatan", catatan)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data instruktur: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusInstruktur(id As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "DELETE FROM tbinstruktur WHERE idInstruktur = @id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data instruktur: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllMemberCombo() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT idMember, CONCAT(idMember, ' - ', nama) AS labelMember " &
                "FROM tbmember ORDER BY idMember ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

End Module