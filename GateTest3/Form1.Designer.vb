<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebBrowserTest = New System.Windows.Forms.WebBrowser()
        Me.btnTestRefresh = New System.Windows.Forms.Button()
        Me.btnTestRemote = New System.Windows.Forms.Button()
        Me.WebBrowserG04 = New System.Windows.Forms.WebBrowser()
        Me.btnG04Remote = New System.Windows.Forms.Button()
        Me.btnG04Refresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gate Test"
        '
        'WebBrowserTest
        '
        Me.WebBrowserTest.Location = New System.Drawing.Point(35, 99)
        Me.WebBrowserTest.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserTest.Name = "WebBrowserTest"
        Me.WebBrowserTest.ScrollBarsEnabled = False
        Me.WebBrowserTest.Size = New System.Drawing.Size(428, 347)
        Me.WebBrowserTest.TabIndex = 1
        Me.WebBrowserTest.Url = New System.Uri("http://192.168.225.133/#remote", System.UriKind.Absolute)
        '
        'btnTestRefresh
        '
        Me.btnTestRefresh.Location = New System.Drawing.Point(95, 466)
        Me.btnTestRefresh.Name = "btnTestRefresh"
        Me.btnTestRefresh.Size = New System.Drawing.Size(59, 56)
        Me.btnTestRefresh.TabIndex = 2
        Me.btnTestRefresh.Text = "Refresh"
        Me.btnTestRefresh.UseVisualStyleBackColor = True
        '
        'btnTestRemote
        '
        Me.btnTestRemote.Location = New System.Drawing.Point(35, 466)
        Me.btnTestRemote.Name = "btnTestRemote"
        Me.btnTestRemote.Size = New System.Drawing.Size(54, 56)
        Me.btnTestRemote.TabIndex = 3
        Me.btnTestRemote.Text = "Remote"
        Me.btnTestRemote.UseVisualStyleBackColor = True
        '
        'WebBrowserG04
        '
        Me.WebBrowserG04.Location = New System.Drawing.Point(513, 99)
        Me.WebBrowserG04.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserG04.Name = "WebBrowserG04"
        Me.WebBrowserG04.ScrollBarsEnabled = False
        Me.WebBrowserG04.Size = New System.Drawing.Size(428, 347)
        Me.WebBrowserG04.TabIndex = 4
        Me.WebBrowserG04.Url = New System.Uri("http://192.168.224.42/#remote", System.UriKind.Absolute)
        '
        'btnG04Remote
        '
        Me.btnG04Remote.Location = New System.Drawing.Point(513, 466)
        Me.btnG04Remote.Name = "btnG04Remote"
        Me.btnG04Remote.Size = New System.Drawing.Size(54, 56)
        Me.btnG04Remote.TabIndex = 5
        Me.btnG04Remote.Text = "Remote"
        Me.btnG04Remote.UseVisualStyleBackColor = True
        '
        'btnG04Refresh
        '
        Me.btnG04Refresh.Location = New System.Drawing.Point(573, 466)
        Me.btnG04Refresh.Name = "btnG04Refresh"
        Me.btnG04Refresh.Size = New System.Drawing.Size(59, 56)
        Me.btnG04Refresh.TabIndex = 6
        Me.btnG04Refresh.Text = "Refresh"
        Me.btnG04Refresh.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(676, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Gate 04"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.GateTest3.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(358, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(969, 538)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnG04Refresh)
        Me.Controls.Add(Me.btnG04Remote)
        Me.Controls.Add(Me.WebBrowserG04)
        Me.Controls.Add(Me.btnTestRemote)
        Me.Controls.Add(Me.btnTestRefresh)
        Me.Controls.Add(Me.WebBrowserTest)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Gate App v0.1.20220818"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents WebBrowserTest As WebBrowser
    Friend WithEvents btnTestRefresh As Button
    Friend WithEvents btnTestRemote As Button
    Friend WithEvents WebBrowserG04 As WebBrowser
    Friend WithEvents btnG04Remote As Button
    Friend WithEvents btnG04Refresh As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
