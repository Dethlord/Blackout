Imports System.Windows.Forms

Public Class Dialog1
    Dim bilo As Boolean
    Dim plaverscore1, plaverscore2, plaverscore3, plaverscore4 As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Установка картинок имен
        Pic1.Image = My.Resources.Игрок
        Pic2.Image = My.Resources.Спок
        Pic3.Image = My.Resources.Мария
        Pic4.Image = My.Resources.Алекс
      

        PicPlaverName.Text = PlaverName


        TextBox1.Text = PlaversScores(1, 1)
        TextBox2.Text = PlaversScores(2, 1)
        TextBox3.Text = PlaversScores(3, 1)
        TextBox4.Text = PlaversScores(4, 1)
       

        TextBox7.Text = PlaversScores(1, 2)
        TextBox8.Text = PlaversScores(2, 2)
        TextBox9.Text = PlaversScores(3, 2)
        TextBox10.Text = PlaversScores(4, 2)
       

        TextBox13.Text = PlaversScores(1, 3)
        TextBox14.Text = PlaversScores(2, 3)
        TextBox15.Text = PlaversScores(3, 3)
        TextBox16.Text = PlaversScores(4, 3)
        

        TextBox19.Text = PlaversScores(1, 4)
        TextBox20.Text = PlaversScores(2, 4)
        TextBox21.Text = PlaversScores(3, 4)
        TextBox22.Text = PlaversScores(4, 4)
       

        TextBox25.Text = PlaversScores(1, 5)
        TextBox26.Text = PlaversScores(2, 5)
        TextBox27.Text = PlaversScores(3, 5)
        TextBox28.Text = PlaversScores(4, 5)
        

        TextBox31.Text = PlaversScores(1, 6)
        TextBox32.Text = PlaversScores(2, 6)
        TextBox33.Text = PlaversScores(3, 6)
        TextBox34.Text = PlaversScores(4, 6)
       

        TextBox37.Text = PlaversScores(1, 7)
        TextBox38.Text = PlaversScores(2, 7)
        TextBox39.Text = PlaversScores(3, 7)
        TextBox40.Text = PlaversScores(4, 7)
       

        TextBox43.Text = PlaversScores(1, 8)
        TextBox44.Text = PlaversScores(2, 8)
        TextBox45.Text = PlaversScores(3, 8)
        TextBox46.Text = PlaversScores(4, 8)
       

        TextBox49.Text = PlaversScores(1, 9)
        TextBox50.Text = PlaversScores(2, 9)
        TextBox51.Text = PlaversScores(3, 9)
        TextBox52.Text = PlaversScores(4, 9)
        

        TextBox55.Text = PlaversScores(1, 10)
        TextBox56.Text = PlaversScores(2, 10)
        TextBox57.Text = PlaversScores(3, 10)
        TextBox58.Text = PlaversScores(4, 10)
       

        TextBox61.Text = PlaversScores(1, 11)
        TextBox62.Text = PlaversScores(2, 11)
        TextBox63.Text = PlaversScores(3, 11)
        TextBox64.Text = PlaversScores(4, 11)
       


        TextBox67.Text = PlaversScores(1, 12)
        TextBox68.Text = PlaversScores(2, 12)
        TextBox69.Text = PlaversScores(3, 12)
        TextBox70.Text = PlaversScores(4, 12)
       

        TextBox73.Text = PlaversScores(1, 13)
        TextBox74.Text = PlaversScores(2, 13)
        TextBox75.Text = PlaversScores(3, 13)
        TextBox76.Text = PlaversScores(4, 13)
       

        TextBox79.Text = PlaversScores(1, 14)
        TextBox80.Text = PlaversScores(2, 14)
        TextBox81.Text = PlaversScores(3, 14)
        TextBox82.Text = PlaversScores(4, 14)
       
        TextBox85.Text = PlaversScores(1, 15)
        TextBox86.Text = PlaversScores(2, 15)
        TextBox87.Text = PlaversScores(3, 15)
        TextBox88.Text = PlaversScores(4, 15)
     

        TextBox91.Text = PlaversScores(1, 16)
        TextBox92.Text = PlaversScores(2, 16)
        TextBox93.Text = PlaversScores(3, 16)
        TextBox94.Text = PlaversScores(4, 16)
       

        TextBox97.Text = PlaversScores(1, 17)
        TextBox98.Text = PlaversScores(2, 17)
        TextBox99.Text = PlaversScores(3, 17)
        TextBox100.Text = PlaversScores(4, 17)
       

        TextBox103.Text = PlaversScores(1, 18)
        TextBox104.Text = PlaversScores(2, 18)
        TextBox105.Text = PlaversScores(3, 18)
        TextBox106.Text = PlaversScores(4, 18)
     

        TextBox109.Text = PlaversScores(1, 19)
        TextBox110.Text = PlaversScores(2, 19)
        TextBox111.Text = PlaversScores(3, 19)
        TextBox112.Text = PlaversScores(4, 19)
       

        TextBox115.Text = PlaversScores(1, 20)
        TextBox116.Text = PlaversScores(2, 20)
        TextBox117.Text = PlaversScores(3, 20)
        TextBox118.Text = PlaversScores(4, 20)
      

        TextBox121.Text = PlaversScores(1, 21)
        TextBox122.Text = PlaversScores(2, 21)
        TextBox123.Text = PlaversScores(3, 21)
        TextBox124.Text = PlaversScores(4, 21)
     

        TextBox127.Text = PlaversScores(1, 22)
        TextBox128.Text = PlaversScores(2, 22)
        TextBox129.Text = PlaversScores(3, 22)
        TextBox130.Text = PlaversScores(4, 22)
       

        TextBox133.Text = PlaversScores(1, 23)
        TextBox134.Text = PlaversScores(2, 23)
        TextBox135.Text = PlaversScores(3, 23)
        TextBox136.Text = PlaversScores(4, 23)
      

        TextBox139.Text = PlaversScores(1, 24)
        TextBox140.Text = PlaversScores(2, 24)
        TextBox141.Text = PlaversScores(3, 24)
        TextBox142.Text = PlaversScores(4, 24)
     

        TextBox145.Text = PlaversScores(1, 25)
        TextBox146.Text = PlaversScores(2, 25)
        TextBox147.Text = PlaversScores(3, 25)
        TextBox148.Text = PlaversScores(4, 25)
      

        TextBox151.Text = PlaversScores(1, 26)
        TextBox152.Text = PlaversScores(2, 26)
        TextBox153.Text = PlaversScores(3, 26)
        TextBox154.Text = PlaversScores(4, 26)
       

        TextBox157.Text = PlaversScores(1, 27)
        TextBox158.Text = PlaversScores(2, 27)
        TextBox159.Text = PlaversScores(3, 27)
        TextBox160.Text = PlaversScores(4, 27)
     

        TextBox163.Text = PlaversScores(1, 28)
        TextBox164.Text = PlaversScores(2, 28)
        TextBox165.Text = PlaversScores(3, 28)
        TextBox166.Text = PlaversScores(4, 28)


        For Round As Integer = 1 To 28
            plaverscore1 = plaverscore1 + PlaversScores(1, Round)
            plaverscore2 = plaverscore2 + PlaversScores(2, Round)
            plaverscore3 = plaverscore3 + PlaversScores(3, Round)
            plaverscore4 = plaverscore4 + PlaversScores(4, Round)
        Next
        Player1.Text = plaverscore1
        Player2.Text = plaverscore2
        Player3.Text = plaverscore3
        Player4.Text = plaverscore4

    End Sub


  
    Private Sub TextBox62_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox62.TextChanged

    End Sub
End Class
