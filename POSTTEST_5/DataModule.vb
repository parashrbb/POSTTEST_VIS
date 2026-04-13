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

End Module