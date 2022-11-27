Imports System.Data.SqlClient
Imports System.Security.Policy


Public Class FmAgenda

    Private conexao As SqlConnection = New SqlConnection("Server=DESKTOP-TSST6LS\SQLEXPRESS; Database=AgendaContatoVB; User Id=sa; Password=abc123;")
    Private comando As SqlCommand
    Private dtAp As SqlDataAdapter
    Private dtRead As SqlDataReader
    Private strSQL As String

    Private Fone As Integer

    Private Sub FmAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarGrid()

    End Sub

    Private Sub BtSalvar_Click(sender As Object, e As EventArgs) Handles BtSalvar.Click

        If (TxId.Text = "" And TxNome.Text <> "" And TxFone.Text <> "" And TxEmail.Text <> "") Then

            Try
                'conexao = New SqlConnection("Server=DESKTOP-TSST6LS\SQLEXPRESS; Database=AgendaContatoVB; User Id=sa; Password=abc123;")

                strSQL = "INSERT INTO CONTATOS (NOME, TELEFONE, EMAIL) VALUES (@NOME, @TELEFONE, @EMAIL) "
                comando = New SqlCommand(strSQL, conexao)
                comando.Parameters.AddWithValue("@NOME", TxNome.Text)
                comando.Parameters.AddWithValue("@TELEFONE", TxFone.Text)
                comando.Parameters.AddWithValue("@EMAIL", TxEmail.Text)
                conexao.Open()
                comando.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conexao.Close()
                comando.Clone()
                comando = Nothing

                MessageBox.Show("Contato cadastrado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                CarregarGrid()
                LimparCampos()

            End Try


        Else
            MessageBox.Show("Favor preencher todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub


    Private Sub CarregarGrid()
        Try
            'conexao = New SqlConnection("Server=DESKTOP-TSST6LS\SQLEXPRESS; Database=AgendaContatoVB; User Id=sa; Password=abc123;")
            Dim ds As New DataSet
            DgContatos.DataSource = Nothing

            strSQL = "SELECT * FROM CONTATOS"
            comando = New SqlCommand(strSQL, conexao)
            dtAp = New SqlDataAdapter(strSQL, conexao)
            conexao.Open()

            dtAp.Fill(ds)
            DgContatos.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
        End Try

    End Sub

    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        'Try
        '    'conexao = New SqlConnection("Server=DESKTOP-TSST6LS\SQLEXPRESS; Database=AgendaContatoVB; User Id=sa; Password=abc123;")

        '    strSQL = "SELECT * FROM CONTATOS WHERE ID = @ID"
        '    comando = New SqlCommand(strSQL, conexao)
        '    comando.Parameters.AddWithValue("@ID", TxId.Text)
        '    conexao.Open()

        '    dtRead = comando.ExecuteReader

        '    Do While dtRead.Read
        '        TxNome.Text = dtRead("nome")
        '        TxFone.Text = dtRead("telefone")
        '        TxEmail.Text = dtRead("email")
        '    Loop

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    conexao.Close()
        '    comando.Clone()
        '    comando = Nothing

        'End Try

        If (TxId.Text <> "") Then

            ConsultarPorId()

        ElseIf (TxNome.Text <> "") Then

            ConsultarPorNome()

        End If
    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click

        If (TxId.Text <> "") Then

            BtSalvar.Enabled = False
            BtEditar.Enabled = True

            Try

                strSQL = "UPDATE CONTATOS SET NOME = @NOME, TELEFONE = @TELEFONE, EMAIL = @EMAIL WHERE ID = @ID"

                comando = New SqlCommand(strSQL, conexao)
                comando.Parameters.AddWithValue("@ID", TxId.Text)
                comando.Parameters.AddWithValue("@NOME", TxNome.Text)
                comando.Parameters.AddWithValue("@TELEFONE", TxFone.Text)
                comando.Parameters.AddWithValue("@EMAIL", TxEmail.Text)
                conexao.Open()
                comando.ExecuteNonQuery()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            Finally

                conexao.Close()
                comando.Clone()
                comando = Nothing

                MessageBox.Show("Contato Alterado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                CarregarGrid()
                LimparCampos()

            End Try

        Else
            BtEditar.Enabled = False
        End If
    End Sub

    Private Sub BtDeletar_Click(sender As Object, e As EventArgs) Handles BtDeletar.Click

        If (TxId.Text <> "") Then

            BtSalvar.Enabled = False
            BtDeletar.Enabled = True

            Try

                strSQL = "DELETE CONTATOS WHERE ID = @ID"

                comando = New SqlCommand(strSQL, conexao)
                comando.Parameters.AddWithValue("@ID", TxId.Text)
                conexao.Open()
                comando.ExecuteNonQuery()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            Finally

                conexao.Close()
                comando.Clone()
                comando = Nothing

                MessageBox.Show("Contato Excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                CarregarGrid()
                LimparCampos()

            End Try

        Else

            BtDeletar.Enabled = False

        End If
    End Sub

    Private Sub ConsultarPorId()

        Try
            'conexao = New SqlConnection("Server=DESKTOP-TSST6LS\SQLEXPRESS; Database=AgendaContatoVB; User Id=sa; Password=abc123;")

            strSQL = "SELECT * FROM CONTATOS WHERE ID = @ID"
            comando = New SqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@ID", TxId.Text)
            conexao.Open()

            dtRead = comando.ExecuteReader

            Do While dtRead.Read
                TxNome.Text = dtRead("nome")
                TxFone.Text = dtRead("telefone")
                TxEmail.Text = dtRead("email")
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            conexao.Close()
            comando.Clone()
            comando = Nothing
            dtRead = Nothing

            CarregarGridConsultaPorId()

        End Try

    End Sub

    Private Sub CarregarGridConsultaPorId()
        Try
            'conexao = New SqlConnection("Server=DESKTOP-TSST6LS\SQLEXPRESS; Database=AgendaContatoVB; User Id=sa; Password=abc123;")
            Dim ds As New DataSet
            DgContatos.DataSource = Nothing

            strSQL = "SELECT * FROM CONTATOS WHERE ID = " & TxId.Text & ""
            comando = New SqlCommand(strSQL, conexao)
            dtAp = New SqlDataAdapter(strSQL, conexao)
            conexao.Open()

            dtAp.Fill(ds)
            DgContatos.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
        End Try

    End Sub


    Private Sub ConsultarPorNome()

        Try
            'conexao = New SqlConnection("Server=DESKTOP-TSST6LS\SQLEXPRESS; Database=AgendaContatoVB; User Id=sa; Password=abc123;")

            strSQL = "SELECT * FROM CONTATOS WHERE NOME LIKE '%@NOME%'"
            comando = New SqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@NOME", TxNome.Text)
            conexao.Open()

            dtRead = comando.ExecuteReader

            Do While dtRead.Read
                TxNome.Text = dtRead("nome")
                TxFone.Text = dtRead("telefone")
                TxEmail.Text = dtRead("email")
            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            conexao.Close()
            comando.Clone()
            comando = Nothing
            dtRead = Nothing

            CarregarGridConsultaPorNome()

        End Try

    End Sub

    Private Sub CarregarGridConsultaPorNome()
        Try
            'conexao = New SqlConnection("Server=DESKTOP-TSST6LS\SQLEXPRESS; Database=AgendaContatoVB; User Id=sa; Password=abc123;")
            Dim ds As New DataSet
            DgContatos.DataSource = Nothing

            strSQL = "SELECT * FROM CONTATOS WHERE NOME LIKE '%" & TxNome.Text & "%'"
            comando = New SqlCommand(strSQL, conexao)
            dtAp = New SqlDataAdapter(strSQL, conexao)
            conexao.Open()

            dtAp.Fill(ds)
            DgContatos.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
        End Try

    End Sub

    Private Sub LimparCampos()

        TxId.Text = ""
        TxNome.Text = ""
        TxFone.Text = ""
        TxEmail.Text = ""

        BtEditar.Enabled = False
        BtDeletar.Enabled = False
        BtSalvar.Enabled = True

    End Sub

    Private Sub TxId_Leave(sender As Object, e As EventArgs) Handles TxId.Leave
        If (TxId.Text <> "") Then

            BtSalvar.Enabled = False
            BtEditar.Enabled = True
            BtDeletar.Enabled = True
            ConsultarPorId()

        End If
    End Sub

    Private Sub TxFone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxFone.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If
    End Sub

    Private Sub BtLimpar_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click
        LimparCampos()
        CarregarGrid()
    End Sub

    'Private Sub DgContatos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgContatos.CellContentDoubleClick
    '    If (DgContatos.RowCount > 0) Then

    '        TxId.Text = DgContatos.CurrentRow.Cells(0).Value
    '        TxNome.Text = DgContatos.CurrentRow.Cells(1).Value
    '        TxFone.Text = DgContatos.CurrentRow.Cells(2).Value
    '        TxEmail.Text = DgContatos.CurrentRow.Cells(3).Value

    '    End If
    'End Sub

    Private Sub DgContatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgContatos.CellContentClick
        If (DgContatos.RowCount > 0) Then

            TxId.Text = DgContatos.CurrentRow.Cells(0).Value
            TxNome.Text = DgContatos.CurrentRow.Cells(1).Value
            TxFone.Text = DgContatos.CurrentRow.Cells(2).Value
            TxEmail.Text = DgContatos.CurrentRow.Cells(3).Value

            BtSalvar.Enabled = False
            BtEditar.Enabled = True
            BtDeletar.Enabled = True

        End If
    End Sub

    Private Sub TxId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxId.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then

            e.Handled = True

        End If
    End Sub





    'Private Sub TxFone_Leave(sender As Object, e As EventArgs) Handles TxFone.Leave
    '    If (TxFone.Text <> "") Then


    '        'TxFone.Text = Format$(TxFone.Text, "!(@@) @@@-@@@@")
    '        'verifica valores invalidos
    '        For i = Len(TxFone.Text) To 1 Step -1
    '            If InStr("0123456789", Mid$(TxFone.Text, i, 1)) = 0 Then
    '                TxFone.Text = Left$(TxFone.Text, i - 1) & Mid$(TxFone.Text, i + 1)
    '            End If
    '        Next
    '        ' ajusta a posicao correta
    '        If Len(Fone) <= 7 Then
    '            TxFone.Text = Format$(TxFone.Text, "!@@@-@@@@")
    '        ElseIf Len(Fone) > 7 And Len(TxFone.Text) <= 9 Then
    '            TxFone.Text = Format$(TxFone.Text, "!(@@) @@@-@@@@")
    '        ElseIf Len(Fone) > 9 Then
    '            TxFone.Text = Format$(TxFone.Text, "!(@@) @@@@-@@@@")
    '        End If

    '    End If
    'End Sub


End Class
