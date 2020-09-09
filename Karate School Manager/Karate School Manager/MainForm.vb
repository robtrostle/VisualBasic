Public Class MainForm
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub ListAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAllToolStripMenuItem.Click
        'Create an instance of allMembersForm
        Dim frmAllMembers As New AllMembersForm

        'Display the form. 
        frmAllMembers.ShowDialog()
    End Sub

    Private Sub AddNewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewMemberToolStripMenuItem.Click
        'Create an instance of Add MemberForm
        Dim frmAddMember As New AddMemberForm

        'Display the form 
        frmAddMember.ShowDialog()
    End Sub

    Private Sub FindMemeberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindMemeberToolStripMenuItem.Click
        'Create an instance of FindMemberForm
        Dim frmFindMember As New FindMemberForm

        'Display the form 
        frmFindMember.ShowDialog()
    End Sub

    Private Sub AllMembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllMembersToolStripMenuItem.Click
        'Create an instance of AllPayments Form
        Dim frmPaymentsAll As New AllPaymentsForm

        'Display the form 
        frmPaymentsAll.ShowDialog()
    End Sub
End Class
