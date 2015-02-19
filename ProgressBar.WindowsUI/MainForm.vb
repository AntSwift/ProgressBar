Public Class MainForm
    Delegate Sub UpdateStatusDelegate(taskNumber As Integer, totalTasks As Integer, percent As Integer)

    Private Sub TaskWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles TaskWorker.DoWork
        Dim totalTasks As Integer = 10

        Dim rnd As New Random()

        For i As Integer = 1 To totalTasks
            Dim percent = CInt((i / totalTasks) * 100)

            ReportStatus(i, totalTasks, percent)

            If TaskWorker.CancellationPending Then
                e.Cancel = True
            End If
            PerformTask(rnd.Next(1, 2) * 1000) ' between 1 and 2 seconds each.

            TaskWorker.ReportProgress(percent)
        Next
    End Sub

    Private Sub TaskWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles TaskWorker.RunWorkerCompleted
        Me.StatusLabel.Text = "Completed"
        Me.StartBtn.Enabled = True
        Me.CancelBtn.Enabled = False
    End Sub

    ''' <summary>
    ''' Report the current progess of the background worker.
    ''' </summary>
    ''' <param name="taskNumber">Task which was completed</param>
    ''' <param name="totalTasks">Total tasks to be completed.</param>
    ''' <param name="percent">Percentage of the total tasks which are complete.</param>
    ''' <remarks>Marshalls the update to the UI thread if required.</remarks>
    Private Sub ReportStatus(taskNumber As Integer, totalTasks As Integer, percent As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(New UpdateStatusDelegate(AddressOf UpdateStatus), taskNumber, totalTasks, percent)
        Else
            UpdateStatus(taskNumber, totalTasks, percent)
        End If
    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click
        Me.StartBtn.Enabled = False

        TaskWorker.RunWorkerAsync()

        Me.CancelBtn.Enabled = True
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.CancelBtn.Enabled = False

        If TaskWorker.IsBusy Then
            If TaskWorker.WorkerSupportsCancellation Then
                TaskWorker.CancelAsync()
            End If
        End If

        Me.StartBtn.Enabled = True
    End Sub

    ''' <summary>
    ''' Perform a dummy task.
    ''' </summary>
    ''' <param name="time">Number of seconds for the task to take.</param>
    ''' <remarks></remarks>
    Public Sub PerformTask(time As Integer)
        Threading.Thread.Sleep(time)
    End Sub

    ''' <summary>
    ''' Update the UI controls with the current status.
    ''' </summary>
    ''' <param name="taskNumber">Task which was completed</param>
    ''' <param name="totalTasks">Total tasks to be completed.</param>
    ''' <param name="percent">Percentage of the total tasks which are complete.</param>
    ''' <remarks></remarks>
    Private Sub UpdateStatus(taskNumber As Integer, totalTasks As Integer, percent As Integer)
        Me.StatusLabel.Text = String.Format("Running task {0} of {1} ({2:P}).", taskNumber, totalTasks, percent / 100)
        Me.ProgressBar.Value = percent
    End Sub
End Class
