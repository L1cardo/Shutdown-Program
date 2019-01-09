Imports System.ComponentModel

Public Class Form1
    Dim a As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "王宇是傻狗" Then
            MsgBox（"傻狗，叫你输你就输！不然你电脑马上关机！你还有" & a - 1 & "次机会"， 48, "警告")
            TextBox1.Clear()
            TextBox1.Focus()
            a -= 1
            If a = 0 Then
                MsgBox("傻狗你完了，等着电脑关机吧")
                Shell（"shutdown -s -t 0"）                                                                                               '关机指令
            End If
        Else
            MsgBox("好吧好吧，你承认自己是傻狗了，那电脑就关机吧")
            Shell（"shutdown -s -t 0"）                                                                                                   '关机指令
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline                        'LinkLabel去除下划线
        a = 4
        MsgBox("欢迎傻狗使用本程序！", 0， "欢迎")
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle                                               '窗体大小无法改变
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MsgBox("傻狗，不要想着关闭程序，你关不掉的，照着爸爸说的的去做！", 0 + 48， “警告”)
        e.Cancel = True                                                                                                                          '取消窗体关闭
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://weibo.com/1935602951")                                             '启动网站
    End Sub
End Class
