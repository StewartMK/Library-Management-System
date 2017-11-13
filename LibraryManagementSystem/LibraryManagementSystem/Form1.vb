Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryTableDataSet.LibraryTable' table. You can move, or remove it, as needed.
        Me.LibraryTableTableAdapter.Fill(Me.LibraryTableDataSet.LibraryTable)
        If DataGridView1.Text = Nothing Then
            Try
                LibraryTableBindingSource.AddNew()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        If Student_IDTextBox.Text = Nothing Then
            Student_IDTextBox.Text = "Unknown"
        End If
        If First_NameTextBox.Text = Nothing Then
            First_NameTextBox.Text = "Unknown"
        End If
        If SurnameTextBox.Text = Nothing Then
            SurnameTextBox.Text = "Unknow"
        End If
        If GenderTextBox.Text = Nothing Then
            GenderTextBox.Text = "Unknown"
        End If
        If DOBTextBox.Text = Nothing Then
            DOBTextBox.Text = "Unknown"
        End If
        If Book_IDTextBox.Text = Nothing Then
            Book_IDTextBox.Text = "Unknown"
        End If
        If Book_Name_TextBox.Text = Nothing Then
            Book_Name_TextBox.Text = "Unknown"
        End If
        If Book_Author_TextBox.Text = Nothing Then
            Book_Author_TextBox.Text = "Unknown"
        End If
        If Year_Published_TextBox.Text = Nothing Then
            Year_Published_TextBox.Text = "Unknown"
        End If
        If Date_BorrowedTextBox.Text = Nothing Then
            Date_BorrowedTextBox.Text = "Unknown"
        End If
        If Due_DateTextBox.Text = Nothing Then
            Due_DateTextBox.Text = "Unknown"
        End If
        If Date_ReturnedTextBox.Text = Nothing Then
            Date_ReturnedTextBox.Text = "Unknown"
        End If

        Try
            Me.Validate()
            Me.LibraryTableBindingSource.EndEdit()
            MessageBox.Show("Student Details Have been added", "Infomation", MessageBoxButtons.OK)
            LibraryTableBindingSource.AddNew()
            Student_IDTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonNew_Click(sender As Object, e As EventArgs) Handles ButtonNew.Click
        Try
            LibraryTableBindingSource.AddNew()
            Student_IDTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Select Case MsgBox("Are you sure you want to Delete the current contact?", MsgBoxStyle.YesNo, "Are You Sure?")
            Case MsgBoxResult.Yes
                Try
                    LibraryTableBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case MsgBoxResult.No
                ''nothing
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            LibraryTableBindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            LibraryTableBindingSource.MoveNext()

            IIIIII        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
