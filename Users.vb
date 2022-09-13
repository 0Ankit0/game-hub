Imports System.Data.OleDb

Public Class Users

    Dim dbconn As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet

    Dim datatable As New DataTable
    Dim cmd As New OleDbCommand

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconn.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=..\db_project321.mdb"
        showData() 'show database values in datagridview
        customColumnWidth() ' set custom column width
    End Sub

    'Set customColumnWidth
    Private Sub customColumnWidth() ' set custom column width
        'datagridName.Columns(columnNumber or columnName)
        Dim columnID As DataGridViewColumn = dgvInfo.Columns(0)
        columnID.Width = 40 'set columnwidth
        Dim columnSurname As DataGridViewColumn = dgvInfo.Columns(1)
        columnSurname.Width = 100 'set columnwidth
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Confirm dialogBox
        Dim dr As DialogResult
        dr = MessageBox.Show("Save information?", "Save", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
            'NO CONDITION GOES HERE
        Else
            'YES CONDITION GOES HERE
            'Form restriction and validation
            If Len(Trim(txtSurname.Text)) = 0 Then
                MessageBox.Show("Please enter Surname", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSurname.Focus()
            ElseIf Len(Trim(txtEmail.Text)) = 0 Then
                MessageBox.Show("Please enter Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmail.Focus()
            ElseIf Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAddress.Focus()
            ElseIf Len(Trim(txtContact_no.Text)) = 0 Then
                MessageBox.Show("Please enter Contact No", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContact_no.Focus()
            Else
                adt = New OleDbDataAdapter("insert into tbl_info (surname, email, address, contact_no) values ('" & txtSurname.Text & "', '" & txtEmail.Text & "', '" & txtAddress.Text & "', '" & txtContact_no.Text & "')", dbconn)
                adt.Fill(ds)
                ds = New DataSet
                showData() ' refresh data in datagridview
                MsgBox("Saved")
                clearText() 'clear all text
            End If
        End If
    End Sub

    Private Sub showData()
        Dim dbcommand As String
        dbcommand = "SELECT * FROM tbl_info"
        adt = New OleDbDataAdapter(dbcommand, dbconn)
        datatable = New DataTable
        adt.Fill(datatable)
        dgvInfo.DataSource = datatable
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            Dim sql = "select * from tbl_info where id like " & txtID.Text & " "
            adt = New OleDbDataAdapter(sql, dbconn)
            cmd = New OleDbCommand(sql)
            adt.Fill(ds, "tbl_info")
            'ds.tables(tableName).rows(rowNumber)(columnNumber).tostring
            txtSurname.Text = ds.Tables("tbl_info").Rows(0)(1).ToString
            txtEmail.Text = ds.Tables("tbl_info").Rows(0)(2).ToString
            txtAddress.Text = ds.Tables("tbl_info").Rows(0)(3).ToString
            txtContact_no.Text = ds.Tables("tbl_info").Rows(0)(4).ToString
            ds = New DataSet
        Catch ex As Exception
            MsgBox("No items match your search", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'Confirm dialogBox
        Dim dr As DialogResult
        dr = MessageBox.Show("Update information?", "Update", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
            'NO CONDITION GOES HERE
        Else
            'YES CONDITION GOES HERE
            'Form restriction and validation
            If Len(Trim(txtSurname.Text)) = 0 Then
                MessageBox.Show("Please enter Surname", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSurname.Focus()
            ElseIf Len(Trim(txtEmail.Text)) = 0 Then
                MessageBox.Show("Please enter Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmail.Focus()
            ElseIf Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAddress.Focus()
            ElseIf Len(Trim(txtContact_no.Text)) = 0 Then
                MessageBox.Show("Please enter Contact No", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContact_no.Focus()
            Else
                adt = New OleDbDataAdapter("update tbl_info set surname='" & txtSurname.Text & "', email='" & txtEmail.Text & "', address='" & txtAddress.Text & "', contact_no='" & txtContact_no.Text & "'where id=" & txtID.Text & "", dbconn)
                adt.Fill(ds)
                ds = New DataSet
                showData() ' refresh data in datagridview
                MsgBox("Updated")
                clearText() 'clear all text
            End If
        End If
    End Sub

    Private Sub dgvInfo_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInfo.CellClick
        Dim i As Integer
        i = dgvInfo.CurrentRow.Index
        'txtName = datagridName.Item(columnName or columnNumber, rowNumber).value.tostring
        txtID.Text = dgvInfo.Item(0, i).Value.ToString
        txtSurname.Text = dgvInfo.Item(1, i).Value.ToString
        txtEmail.Text = dgvInfo.Item(2, i).Value.ToString
        txtAddress.Text = dgvInfo.Item(3, i).Value.ToString
        txtContact_no.Text = dgvInfo.Item(4, i).Value.ToString
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If cboFilter.SelectedItem = "ID" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("id = " & txtSearch.Text & "")
                dgvInfo.DataSource = dataView

            ElseIf cboFilter.SelectedItem = "Surname" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("surname like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView

            ElseIf cboFilter.SelectedItem = "Email" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("email like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView

            ElseIf cboFilter.SelectedItem = "Address" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("address like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView
            ElseIf cboFilter.SelectedItem = "Contact No" Then
                Dim dataView As New DataView(datatable)
                dataView.RowFilter = String.Format("contact_no like '%" & txtSearch.Text & "%'")
                dgvInfo.DataSource = dataView
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'Confirm dialogBox
        Dim dr As DialogResult
        dr = MessageBox.Show("Delete information?", "Delete", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
            'NO CONDITION GOES HERE
        Else
            'YES CONDITION GOES HERE
            'Form restriction and validation
            If Len(Trim(txtSurname.Text)) = 0 Then
                MessageBox.Show("Please enter Surname", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSurname.Focus()
            ElseIf Len(Trim(txtEmail.Text)) = 0 Then
                MessageBox.Show("Please enter Email", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmail.Focus()
            ElseIf Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAddress.Focus()
            ElseIf Len(Trim(txtContact_no.Text)) = 0 Then
                MessageBox.Show("Please enter Contact No", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContact_no.Focus()
            Else
                adt = New OleDbDataAdapter("delete surname='" & txtSurname.Text & "', email='" & txtEmail.Text & "', address='" & txtAddress.Text & "', contact_no='" & txtContact_no.Text & "' from tbl_info where  id=" & txtID.Text & "", dbconn)
                adt.Fill(ds)
                ds = New DataSet
                showData() ' refresh data in datagridview
                MsgBox("Deleted")
                clearText() 'clear all text
            End If
        End If
    End Sub

    Sub clearText() 'clear all text
        txtID.Text = ""
        txtSurname.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtContact_no.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Confirm dialogBox
        Dim dr As DialogResult
        dr = MessageBox.Show("Clear text?", "Clear", MessageBoxButtons.YesNo)
        If dr = DialogResult.No Then
            'NO CONDITION GOES HERE
        Else
            'YES CONDITION GOES HERE
            clearText() 'clear all text
        End If
    End Sub

    Private Sub txtContact_no_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact_no.KeyPress
        'Input number only
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        'Input number only
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Users_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub


    'copyright © 2017 ITGeekSolutions
End Class
