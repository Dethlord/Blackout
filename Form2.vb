Imports System
Imports System.IO
Imports System.Reflection
Imports System.Media
Imports Microsoft.DirectX.DirectSound
Public Class Form2
    Dim ListWiners As String
    Private SStart As Stream = My.Resources.Звук_старта
    Private SoundStart As SoundPlayer = New SoundPlayer(SStart)

    'Обьявления

    Private Zan1 As Stream = My.Resources._1_место1
    Private SoundZan1 As SoundPlayer = New SoundPlayer(Zan1)

    Private Zan2 As Stream = My.Resources._2_место1
    Private SoundZan2 As SoundPlayer = New SoundPlayer(Zan2)

    Private Zan3 As Stream = My.Resources._3_место1
    Private SoundZan3 As SoundPlayer = New SoundPlayer(Zan4)

    Private Zan4 As Stream = My.Resources._4_место1
    Private SoundZan4 As SoundPlayer = New SoundPlayer(Zan4)

    Private Zan5 As Stream = My.Resources._5_место1
    Private SoundZan5 As SoundPlayer = New SoundPlayer(Zan6)

    Private Zan6 As Stream = My.Resources._6_место1
    Private SoundZan6 As SoundPlayer = New SoundPlayer(Zan6)

   
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MAIN()
    End Sub

    Sub MAIN()
        Me.Text = "Результаты"

        PicTablo.Image = My.Resources.Кнопка_турнирная_таблицаТ
        PicNewGame.Image = My.Resources.Кнопка_новая_игра_малаяС
        Record.Image = My.Resources.Рекорд
        CubokPic.Image = My.Resources.Пьедестал
        PicPlaverName1.Visible = False
        PicWiner1.Visible = False
        PicWiner2.Visible = False
        PicWiner3.Visible = False
        PicWiner4.Visible = False
       
        PicRecord.Visible = False
        PicPlaverName1.Visible = False
        PicPlaverName2.Visible = False
        PicPlaverName3.Visible = False
        PicPlaverName4.Visible = False
       
        PicPlaverName7.Visible = False
        Record.Visible = False

        PicTablo.Visible = False
        PicNewGame.Visible = False
        Timer1.Interval = 10
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.CubokPic.Image = My.Resources.Золотой_кубок
        CubokPic.Visible = True
        If Sound Then
            SoundStart.Play()
        End If
        HuIsWin()
        SayWin()
        ShowNameWiner1()
        Timer2.Interval = 400
        Timer2.Start()
    End Sub
    Public Sub SayWin()
        'Обьявление победителей
        If Sound Then
            If Mid(ListWiners, 1, 1) = "1" Then SoundZan1.PlaySync()
            If Mid(ListWiners, 2, 1) = "1" Then SoundZan2.PlaySync()
            If Mid(ListWiners, 3, 1) = "1" Then SoundZan3.PlaySync()
            If Mid(ListWiners, 4, 1) = "1" Then SoundZan4.PlaySync()
        Else
            If Mid(ListWiners, 1, 1) = "1" Then MsgBox("Вы заняли 1 место!", MsgBoxStyle.OkOnly, "Поздравляем")
            If Mid(ListWiners, 2, 1) = "1" Then MsgBox("Вы заняли 2 место!", MsgBoxStyle.OkOnly, "Поздравляем")
            If Mid(ListWiners, 3, 1) = "1" Then MsgBox("Вы заняли 3 место!", MsgBoxStyle.OkOnly, "Поздравляем")
            If Mid(ListWiners, 4, 1) = "1" Then MsgBox("Вы заняли 4 место", MsgBoxStyle.OkOnly)
         
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ShowMesto1()
        Timer2.Stop()
        Timer3.Interval = 400
        Timer3.Start()
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.CubokPic.Image = My.Resources.Серебрянный_кубок
        CubokPic.Visible = True
        If Sound Then
            SoundStart.Play()
        End If
        ShowNameWiner2()
        Timer3.Stop()
        Timer4.Interval = 400
        Timer4.Start()
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        ShowMesto2()
        Timer4.Stop()
        Timer5.Interval = 400
        Timer5.Start()
    End Sub
    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Me.CubokPic.Image = My.Resources.Медный_кубок
        CubokPic.Visible = True
        If Sound Then
            SoundStart.Play()
        End If
        ShowNameWiner3()
        Timer5.Stop()
        Timer6.Interval = 400
        Timer6.Start()
    End Sub
    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        ShowMesto3()
        Timer6.Stop()
        Timer7.Interval = 400
        Timer7.Start()
    End Sub
    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        Me.Cubok4.Image = My.Resources._4_место
        Cubok4.Visible = True
        If Sound Then
            SoundStart.Play()
        End If
        ShowNameWiner4()
        Timer7.Stop()
        Timer8.Interval = 400
        Timer8.Start()
    End Sub
    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        ShowMesto4()
        Timer8.Stop()
        Timer9.Interval = 400
        Timer9.Start()
    End Sub
    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        Timer9.Stop()
        Timer13.Interval = 400
        Timer13.Start()
    End Sub
    Private Sub Timer13_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer13.Tick

        HuIsRecord()
        If Sound Then
            SoundStart.Play()
        End If
        Record.Visible = True
        Timer13.Stop()
        Timer14.Interval = 400
        Timer14.Start()
    End Sub
    Private Sub Timer14_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer14.Tick
        ShowNameWinerRecord()

        PicTablo.Visible = True
        PicNewGame.Visible = True
        Timer14.Stop()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dialog1.Show()
    End Sub
    Public Sub HuIsWin()
        Dim VremPlaverScore(5) As Integer
        VremPlaverScore(0) = PlaverScore(1)
        VremPlaverScore(1) = PlaverScore(2)
        VremPlaverScore(2) = PlaverScore(3)
        VremPlaverScore(3) = PlaverScore(4)


        Array.Sort(PlaverScore, 1, 4)
        Array.Reverse(PlaverScore, 1, 4)
        For RRR As Integer = 1 To 4
            ListWiners = ListWiners & (Array.IndexOf(VremPlaverScore, PlaverScore(RRR)) + 1)
        Next


        PlaverScore(1) = VremPlaverScore(0)
        PlaverScore(2) = VremPlaverScore(1)
        PlaverScore(3) = VremPlaverScore(2)
        PlaverScore(4) = VremPlaverScore(3)
   
    End Sub

    Public Sub ShowNameWiner1()
        Select Case Mid(ListWiners, 1, 1)
            Case 1
                PicWiner1.Image = My.Resources.Игрок
                PicWiner1.Visible = True
                PicPlaverName1.Text = PlaverName
                PicPlaverName1.Visible = True
            Case 2
                PicWiner1.Image = My.Resources.Спок
                PicWiner1.Visible = True
            Case 3
                PicWiner1.Image = My.Resources.Мария
                PicWiner1.Visible = True
            Case 4
                PicWiner1.Image = My.Resources.Алекс
                PicWiner1.Visible = True
            Case 5
                PicWiner1.Image = My.Resources.Ирина
                PicWiner1.Visible = True
            Case 6
                PicWiner1.Image = My.Resources.Джон
                PicWiner1.Visible = True
        End Select
    End Sub
    Public Sub ShowNameWiner2()
        Select Case Mid(ListWiners, 2, 1)
            Case 1
                PicWiner2.Image = My.Resources.Игрок
                PicWiner2.Visible = True
                PicPlaverName2.Text = PlaverName
                PicPlaverName2.Visible = True
            Case 2
                PicWiner2.Image = My.Resources.Спок
                PicWiner2.Visible = True
            Case 3
                PicWiner2.Image = My.Resources.Мария
                PicWiner2.Visible = True
            Case 4
                PicWiner2.Image = My.Resources.Алекс
                PicWiner2.Visible = True
            Case 5
                PicWiner2.Image = My.Resources.Ирина
                PicWiner2.Visible = True
            Case 6
                PicWiner2.Image = My.Resources.Джон
                PicWiner2.Visible = True
        End Select
    End Sub
    Public Sub ShowNameWiner3()
        Select Case Mid(ListWiners, 3, 1)
            Case 1
                PicWiner3.Image = My.Resources.Игрок
                PicWiner3.Visible = True
                PicPlaverName3.Text = PlaverName
                PicPlaverName3.Visible = True
            Case 2
                PicWiner3.Image = My.Resources.Спок
                PicWiner3.Visible = True
            Case 3
                PicWiner3.Image = My.Resources.Мария
                PicWiner3.Visible = True
            Case 4
                PicWiner3.Image = My.Resources.Алекс
                PicWiner3.Visible = True
            Case 5
                PicWiner3.Image = My.Resources.Ирина
                PicWiner3.Visible = True
            Case 6
                PicWiner3.Image = My.Resources.Джон
                PicWiner3.Visible = True
        End Select
    End Sub
    Public Sub ShowNameWiner4()
        Select Case Mid(ListWiners, 4, 1)
            Case 1
                PicWiner4.Image = My.Resources.Игрок
                PicWiner4.Visible = True
                PicPlaverName4.Text = PlaverName
                PicPlaverName4.Visible = True
            Case 2
                PicWiner4.Image = My.Resources.Спок
                PicWiner4.Visible = True
            Case 3
                PicWiner4.Image = My.Resources.Мария
                PicWiner4.Visible = True
            Case 4
                PicWiner4.Image = My.Resources.Алекс
                PicWiner4.Visible = True
            Case 5
                PicWiner4.Image = My.Resources.Ирина
                PicWiner4.Visible = True
            Case 6
                PicWiner4.Image = My.Resources.Джон
                PicWiner4.Visible = True
        End Select
    End Sub
    
    Public Sub ShowNameWinerRecord()
        Select Case PlaverNameRecord
            Case 1
                Dim Path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                Dim line As String
                Using sr As StreamReader = New StreamReader(Path & "\" & "RecordNamePlaver.txt", True)
                    line = sr.ReadLine
                    sr.Close()
                End Using
                PlaverName = line

                PicRecord.Image = My.Resources.Игрок
                PicRecord.Visible = True
                PicPlaverName7.Text = PlaverName
                PicPlaverName7.Visible = True

            Case 2
                PicRecord.Image = My.Resources.Спок
                PicRecord.Visible = True
            Case 3
                PicRecord.Image = My.Resources.Мария
                PicRecord.Visible = True
            Case 4
                PicRecord.Image = My.Resources.Алекс
                PicRecord.Visible = True
            Case 5
                PicRecord.Image = My.Resources.Ирина
                PicRecord.Visible = True
            Case 6
                PicRecord.Image = My.Resources.Джон
                PicRecord.Visible = True
        End Select
    End Sub

    Public Sub HuIsRecord()
        'Проверка есть ли файл рекордов
        Dim Path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Dim PlaverScoreRecord As String
        Dim line As String
        If File.Exists(Path & "\" & "Record.txt") Then
            'Фаил имеется
            Using sr As StreamReader = New StreamReader(Path & "\" & "Record.txt", True)
                line = sr.ReadLine
                sr.Close()
            End Using
            'Сравнить со старым рекордом
            If Val(PlaverScore(Mid(ListWiners, 1, 1))) <= Val(Mid(line, 1, Len(line) - 1)) Then
                PlaverNameRecord = Val(Mid(line, Len(line), 1))
                PlaverScoreRecord = Mid(line, 1, Len(line) - 1)
                ShowRecord(PlaverScoreRecord)
            Else
                PlaverNameRecord = Val(Mid(ListWiners, 1, 1))
                PlaverScoreRecord = PlaverScore(PlaverNameRecord)
                ShowRecord(PlaverScoreRecord)
                'Перезаписать файл с новым результатом

                If PlaverNameRecord = 1 Then
                    Using sw As StreamWriter = New StreamWriter(Path & "\" & "RecordNamePlaver.txt", False)
                        sw.Write(PlaverName)
                        sw.Close()
                    End Using
                End If
                Using sw As StreamWriter = New StreamWriter(Path & "\" & "Record.txt", False)
                    sw.Write(PlaverScoreRecord & PlaverNameRecord)
                    sw.Close()
                End Using

            End If
        Else
            'Фаил отсутствует
            'Запишем игрока занявшего 1 место и его очки
            PlaverNameRecord = Mid(ListWiners, 1, 1)
            PlaverScoreRecord = PlaverScore(PlaverNameRecord)
            ShowRecord(PlaverScoreRecord)
            If PlaverNameRecord = 1 Then
                Using sw As StreamWriter = New StreamWriter(Path & "\" & "RecordNamePlaver.txt", False)
                    sw.Write(PlaverName)
                    sw.Close()
                End Using
            End If
            Using sw As StreamWriter = New StreamWriter(Path & "\" & "Record.txt", True)
                sw.Write(PlaverScoreRecord & PlaverNameRecord)
                sw.Close()
            End Using
        End If
    End Sub
    Private Sub ShowMesto1()
        Dim Plaver As String
        Plaver = Mid(ListWiners, 1, 1)
        If Math.Sign(PlaverScore(Plaver)) = -1 Then
            Opic0.Image = My.Resources.Минус_п
        Else
            Opic0.Image = My.Resources.Плюс_п
        End If

        Select Case Len(Str(Math.Abs(PlaverScore(Plaver)))) - 1
            Case 1
                Select Case PlaverScore(Plaver)
                    Case 0
                        Opic1.Image = My.Resources.Ноль_п
                    Case 1
                        Opic1.Image = My.Resources._11п
                    Case 2
                        Opic1.Image = My.Resources._12п
                    Case 3
                        Opic1.Image = My.Resources._13п
                    Case 4
                        Opic1.Image = My.Resources._14п
                    Case 5
                        Opic1.Image = My.Resources._15п
                    Case 6
                        Opic1.Image = My.Resources._16п
                    Case 7
                        Opic1.Image = My.Resources._17п
                    Case 8
                        Opic1.Image = My.Resources._18п
                    Case 9
                        Opic1.Image = My.Resources._19п
                End Select
                Opic2.Image = My.Resources._2_откп
                Opic3.Image = My.Resources._3_откп
                Opic4.Image = My.Resources._4_откп
            Case 2
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        Opic1.Image = My.Resources._11п
                    Case 2
                        Opic1.Image = My.Resources._12п
                    Case 3
                        Opic1.Image = My.Resources._13п
                    Case 4
                        Opic1.Image = My.Resources._14п
                    Case 5
                        Opic1.Image = My.Resources._15п
                    Case 6
                        Opic1.Image = My.Resources._16п
                    Case 7
                        Opic1.Image = My.Resources._17п
                    Case 8
                        Opic1.Image = My.Resources._18п
                    Case 9
                        Opic1.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        Opic2.Image = My.Resources._20п
                    Case 1
                        Opic2.Image = My.Resources._21п
                    Case 2
                        Opic2.Image = My.Resources._22п
                    Case 3
                        Opic2.Image = My.Resources._23п
                    Case 4
                        Opic2.Image = My.Resources._24п
                    Case 5
                        Opic2.Image = My.Resources._25п
                    Case 6
                        Opic2.Image = My.Resources._26п
                    Case 7
                        Opic2.Image = My.Resources._27п
                    Case 8
                        Opic2.Image = My.Resources._28п
                    Case 9
                        Opic2.Image = My.Resources._29п
                End Select
                Opic3.Image = My.Resources._3_откп
                Opic4.Image = My.Resources._4_откп
            Case 3
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        Opic1.Image = My.Resources._11п
                    Case 2
                        Opic1.Image = My.Resources._12п
                    Case 3
                        Opic1.Image = My.Resources._13п
                    Case 4
                        Opic1.Image = My.Resources._14п
                    Case 5
                        Opic1.Image = My.Resources._15п
                    Case 6
                        Opic1.Image = My.Resources._16п
                    Case 7
                        Opic1.Image = My.Resources._17п
                    Case 8
                        Opic1.Image = My.Resources._18п
                    Case 9
                        Opic1.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        Opic2.Image = My.Resources._20п
                    Case 1
                        Opic2.Image = My.Resources._21п
                    Case 2
                        Opic2.Image = My.Resources._22п
                    Case 3
                        Opic2.Image = My.Resources._23п
                    Case 4
                        Opic2.Image = My.Resources._24п
                    Case 5
                        Opic2.Image = My.Resources._25п
                    Case 6
                        Opic2.Image = My.Resources._26п
                    Case 7
                        Opic2.Image = My.Resources._27п
                    Case 8
                        Opic2.Image = My.Resources._28п
                    Case 9
                        Opic2.Image = My.Resources._29п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 3, 1)
                    Case 0
                        Opic3.Image = My.Resources._30п
                    Case 1
                        Opic3.Image = My.Resources._31п
                    Case 2
                        Opic3.Image = My.Resources._32п
                    Case 3
                        Opic3.Image = My.Resources._33п
                    Case 4
                        Opic3.Image = My.Resources._34п
                    Case 5
                        Opic3.Image = My.Resources._35п
                    Case 6
                        Opic3.Image = My.Resources._36п
                    Case 7
                        Opic3.Image = My.Resources._37п
                    Case 8
                        Opic3.Image = My.Resources._38п
                    Case 9
                        Opic3.Image = My.Resources._39п
                End Select
                Opic4.Image = My.Resources._4_откп
            Case 4
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        Opic1.Image = My.Resources._11п
                    Case 2
                        Opic1.Image = My.Resources._12п
                    Case 3
                        Opic1.Image = My.Resources._13п
                    Case 4
                        Opic1.Image = My.Resources._14п
                    Case 5
                        Opic1.Image = My.Resources._15п
                    Case 6
                        Opic1.Image = My.Resources._16п
                    Case 7
                        Opic1.Image = My.Resources._17п
                    Case 8
                        Opic1.Image = My.Resources._18п
                    Case 9
                        Opic1.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        Opic2.Image = My.Resources._20п
                    Case 1
                        Opic2.Image = My.Resources._21п
                    Case 2
                        Opic2.Image = My.Resources._22п
                    Case 3
                        Opic2.Image = My.Resources._23п
                    Case 4
                        Opic2.Image = My.Resources._24п
                    Case 5
                        Opic2.Image = My.Resources._25п
                    Case 6
                        Opic2.Image = My.Resources._26п
                    Case 7
                        Opic2.Image = My.Resources._27п
                    Case 8
                        Opic2.Image = My.Resources._28п
                    Case 9
                        Opic2.Image = My.Resources._29п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 3, 1)
                    Case 0
                        Opic3.Image = My.Resources._30п
                    Case 1
                        Opic3.Image = My.Resources._31п
                    Case 2
                        Opic3.Image = My.Resources._32п
                    Case 3
                        Opic3.Image = My.Resources._33п
                    Case 4
                        Opic3.Image = My.Resources._34п
                    Case 5
                        Opic3.Image = My.Resources._35п
                    Case 6
                        Opic3.Image = My.Resources._36п
                    Case 7
                        Opic3.Image = My.Resources._37п
                    Case 8
                        Opic3.Image = My.Resources._38п
                    Case 9
                        Opic3.Image = My.Resources._39п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 4, 1)
                    Case 0
                        Opic4.Image = My.Resources._40п
                    Case 1
                        Opic4.Image = My.Resources._41п
                    Case 2
                        Opic4.Image = My.Resources._42п
                    Case 3
                        Opic4.Image = My.Resources._43п
                    Case 4
                        Opic4.Image = My.Resources._44п
                    Case 5
                        Opic4.Image = My.Resources._45п
                    Case 6
                        Opic4.Image = My.Resources._46п
                    Case 7
                        Opic4.Image = My.Resources._47п
                    Case 8
                        Opic4.Image = My.Resources._48п
                    Case 9
                        Opic4.Image = My.Resources._49п
                End Select
        End Select

    End Sub
    Private Sub ShowMesto2()
        Dim Plaver As String
        Plaver = Mid(ListWiners, 2, 1)
        If Math.Sign(PlaverScore(Plaver)) = -1 Then
            Opic02.Image = My.Resources.Минус_п
        Else
            Opic02.Image = My.Resources.Плюс_п
        End If

        Select Case Len(Str(Math.Abs(PlaverScore(Plaver)))) - 1
            Case 1
                Select Case PlaverScore(Plaver)
                    Case 0
                        Opic12.Image = My.Resources.Ноль_п
                    Case 1
                        Opic12.Image = My.Resources._11п
                    Case 2
                        Opic12.Image = My.Resources._12п
                    Case 3
                        Opic12.Image = My.Resources._13п
                    Case 4
                        Opic12.Image = My.Resources._14п
                    Case 5
                        Opic12.Image = My.Resources._15п
                    Case 6
                        Opic12.Image = My.Resources._16п
                    Case 7
                        Opic12.Image = My.Resources._17п
                    Case 8
                        Opic12.Image = My.Resources._18п
                    Case 9
                        Opic12.Image = My.Resources._19п
                End Select
                Opic22.Image = My.Resources._2_откп
                Opic32.Image = My.Resources._3_откп
                Opic42.Image = My.Resources._4_откп
            Case 2
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        Opic12.Image = My.Resources._11п
                    Case 2
                        Opic12.Image = My.Resources._12п
                    Case 3
                        Opic12.Image = My.Resources._13п
                    Case 4
                        Opic12.Image = My.Resources._14п
                    Case 5
                        Opic12.Image = My.Resources._15п
                    Case 6
                        Opic12.Image = My.Resources._16п
                    Case 7
                        Opic12.Image = My.Resources._17п
                    Case 8
                        Opic12.Image = My.Resources._18п
                    Case 9
                        Opic12.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        Opic22.Image = My.Resources._20п
                    Case 1
                        Opic22.Image = My.Resources._21п
                    Case 2
                        Opic22.Image = My.Resources._22п
                    Case 3
                        Opic22.Image = My.Resources._23п
                    Case 4
                        Opic22.Image = My.Resources._24п
                    Case 5
                        Opic22.Image = My.Resources._25п
                    Case 6
                        Opic22.Image = My.Resources._26п
                    Case 7
                        Opic22.Image = My.Resources._27п
                    Case 8
                        Opic22.Image = My.Resources._28п
                    Case 9
                        Opic22.Image = My.Resources._29п
                End Select
                Opic32.Image = My.Resources._3_откп
                Opic42.Image = My.Resources._4_откп
            Case 3
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        Opic12.Image = My.Resources._11п
                    Case 2
                        Opic12.Image = My.Resources._12п
                    Case 3
                        Opic12.Image = My.Resources._13п
                    Case 4
                        Opic12.Image = My.Resources._14п
                    Case 5
                        Opic12.Image = My.Resources._15п
                    Case 6
                        Opic12.Image = My.Resources._16п
                    Case 7
                        Opic12.Image = My.Resources._17п
                    Case 8
                        Opic12.Image = My.Resources._18п
                    Case 9
                        Opic12.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        Opic22.Image = My.Resources._20п
                    Case 1
                        Opic22.Image = My.Resources._21п
                    Case 2
                        Opic22.Image = My.Resources._22п
                    Case 3
                        Opic22.Image = My.Resources._23п
                    Case 4
                        Opic22.Image = My.Resources._24п
                    Case 5
                        Opic22.Image = My.Resources._25п
                    Case 6
                        Opic22.Image = My.Resources._26п
                    Case 7
                        Opic22.Image = My.Resources._27п
                    Case 8
                        Opic22.Image = My.Resources._28п
                    Case 9
                        Opic22.Image = My.Resources._29п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 3, 1)
                    Case 0
                        Opic32.Image = My.Resources._30п
                    Case 1
                        Opic32.Image = My.Resources._31п
                    Case 2
                        Opic32.Image = My.Resources._32п
                    Case 3
                        Opic32.Image = My.Resources._33п
                    Case 4
                        Opic32.Image = My.Resources._34п
                    Case 5
                        Opic32.Image = My.Resources._35п
                    Case 6
                        Opic32.Image = My.Resources._36п
                    Case 7
                        Opic32.Image = My.Resources._37п
                    Case 8
                        Opic32.Image = My.Resources._38п
                    Case 9
                        Opic32.Image = My.Resources._39п
                End Select
                Opic42.Image = My.Resources._4_откп
            Case 4
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        Opic12.Image = My.Resources._11п
                    Case 2
                        Opic12.Image = My.Resources._12п
                    Case 3
                        Opic12.Image = My.Resources._13п
                    Case 4
                        Opic12.Image = My.Resources._14п
                    Case 5
                        Opic12.Image = My.Resources._15п
                    Case 6
                        Opic12.Image = My.Resources._16п
                    Case 7
                        Opic12.Image = My.Resources._17п
                    Case 8
                        Opic12.Image = My.Resources._18п
                    Case 9
                        Opic12.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        Opic22.Image = My.Resources._20п
                    Case 1
                        Opic22.Image = My.Resources._21п
                    Case 2
                        Opic22.Image = My.Resources._22п
                    Case 3
                        Opic22.Image = My.Resources._23п
                    Case 4
                        Opic22.Image = My.Resources._24п
                    Case 5
                        Opic22.Image = My.Resources._25п
                    Case 6
                        Opic22.Image = My.Resources._26п
                    Case 7
                        Opic22.Image = My.Resources._27п
                    Case 8
                        Opic22.Image = My.Resources._28п
                    Case 9
                        Opic22.Image = My.Resources._29п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 3, 1)
                    Case 0
                        Opic32.Image = My.Resources._30п
                    Case 1
                        Opic32.Image = My.Resources._31п
                    Case 2
                        Opic32.Image = My.Resources._32п
                    Case 3
                        Opic32.Image = My.Resources._33п
                    Case 4
                        Opic32.Image = My.Resources._34п
                    Case 5
                        Opic32.Image = My.Resources._35п
                    Case 6
                        Opic32.Image = My.Resources._36п
                    Case 7
                        Opic32.Image = My.Resources._37п
                    Case 8
                        Opic32.Image = My.Resources._38п
                    Case 9
                        Opic32.Image = My.Resources._39п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 4, 1)
                    Case 0
                        Opic42.Image = My.Resources._40п
                    Case 1
                        Opic42.Image = My.Resources._41п
                    Case 2
                        Opic42.Image = My.Resources._42п
                    Case 3
                        Opic42.Image = My.Resources._43п
                    Case 4
                        Opic42.Image = My.Resources._44п
                    Case 5
                        Opic42.Image = My.Resources._45п
                    Case 6
                        Opic42.Image = My.Resources._46п
                    Case 7
                        Opic42.Image = My.Resources._47п
                    Case 8
                        Opic42.Image = My.Resources._48п
                    Case 9
                        Opic42.Image = My.Resources._49п
                End Select
        End Select
        Opic02.Visible = True
        Opic12.Visible = True
        Opic22.Visible = True
        Opic32.Visible = True
        Opic42.Visible = True
    End Sub
    Private Sub ShowMesto3()
        Dim Plaver As String
        Plaver = Mid(ListWiners, 3, 1)
        If Math.Sign(PlaverScore(Plaver)) = -1 Then
            Opic03.Image = My.Resources.Минус_п
        Else
            Opic03.Image = My.Resources.Плюс_п
        End If

        Select Case Len(Str(Math.Abs(PlaverScore(Plaver)))) - 1
            Case 1
                Select Case PlaverScore(Plaver)
                    Case 0
                        Opic13.Image = My.Resources.Ноль_п
                    Case 1
                        Opic13.Image = My.Resources._11п
                    Case 2
                        Opic13.Image = My.Resources._12п
                    Case 3
                        Opic13.Image = My.Resources._13п
                    Case 4
                        Opic13.Image = My.Resources._14п
                    Case 5
                        Opic13.Image = My.Resources._15п
                    Case 6
                        Opic13.Image = My.Resources._16п
                    Case 7
                        Opic13.Image = My.Resources._17п
                    Case 8
                        Opic13.Image = My.Resources._18п
                    Case 9
                        Opic13.Image = My.Resources._19п
                End Select
                Opic23.Image = My.Resources._2_откп
                Opic33.Image = My.Resources._3_откп
                Opic43.Image = My.Resources._4_откп
            Case 2
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        Opic13.Image = My.Resources._11п
                    Case 2
                        Opic13.Image = My.Resources._12п
                    Case 3
                        Opic13.Image = My.Resources._13п
                    Case 4
                        Opic13.Image = My.Resources._14п
                    Case 5
                        Opic13.Image = My.Resources._15п
                    Case 6
                        Opic13.Image = My.Resources._16п
                    Case 7
                        Opic13.Image = My.Resources._17п
                    Case 8
                        Opic13.Image = My.Resources._18п
                    Case 9
                        Opic13.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        Opic23.Image = My.Resources._20п
                    Case 1
                        Opic23.Image = My.Resources._21п
                    Case 2
                        Opic23.Image = My.Resources._22п
                    Case 3
                        Opic23.Image = My.Resources._23п
                    Case 4
                        Opic23.Image = My.Resources._24п
                    Case 5
                        Opic23.Image = My.Resources._25п
                    Case 6
                        Opic23.Image = My.Resources._26п
                    Case 7
                        Opic23.Image = My.Resources._27п
                    Case 8
                        Opic23.Image = My.Resources._28п
                    Case 9
                        Opic23.Image = My.Resources._29п
                End Select
                Opic33.Image = My.Resources._3_откп
                Opic43.Image = My.Resources._4_откп
            Case 3
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        Opic13.Image = My.Resources._11п
                    Case 2
                        Opic13.Image = My.Resources._12п
                    Case 3
                        Opic13.Image = My.Resources._13п
                    Case 4
                        Opic13.Image = My.Resources._14п
                    Case 5
                        Opic13.Image = My.Resources._15п
                    Case 6
                        Opic13.Image = My.Resources._16п
                    Case 7
                        Opic13.Image = My.Resources._17п
                    Case 8
                        Opic13.Image = My.Resources._18п
                    Case 9
                        Opic13.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        Opic23.Image = My.Resources._20п
                    Case 1
                        Opic23.Image = My.Resources._21п
                    Case 2
                        Opic23.Image = My.Resources._22п
                    Case 3
                        Opic23.Image = My.Resources._23п
                    Case 4
                        Opic23.Image = My.Resources._24п
                    Case 5
                        Opic23.Image = My.Resources._25п
                    Case 6
                        Opic23.Image = My.Resources._26п
                    Case 7
                        Opic23.Image = My.Resources._27п
                    Case 8
                        Opic23.Image = My.Resources._28п
                    Case 9
                        Opic23.Image = My.Resources._29п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 3, 1)
                    Case 0
                        Opic33.Image = My.Resources._30п
                    Case 1
                        Opic33.Image = My.Resources._31п
                    Case 2
                        Opic33.Image = My.Resources._32п
                    Case 3
                        Opic33.Image = My.Resources._33п
                    Case 4
                        Opic33.Image = My.Resources._34п
                    Case 5
                        Opic33.Image = My.Resources._35п
                    Case 6
                        Opic33.Image = My.Resources._36п
                    Case 7
                        Opic33.Image = My.Resources._37п
                    Case 8
                        Opic33.Image = My.Resources._38п
                    Case 9
                        Opic33.Image = My.Resources._39п
                End Select
                Opic43.Image = My.Resources._4_откп
            Case 4
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        Opic13.Image = My.Resources._11п
                    Case 2
                        Opic13.Image = My.Resources._12п
                    Case 3
                        Opic13.Image = My.Resources._13п
                    Case 4
                        Opic13.Image = My.Resources._14п
                    Case 5
                        Opic13.Image = My.Resources._15п
                    Case 6
                        Opic13.Image = My.Resources._16п
                    Case 7
                        Opic13.Image = My.Resources._17п
                    Case 8
                        Opic13.Image = My.Resources._18п
                    Case 9
                        Opic13.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        Opic23.Image = My.Resources._20п
                    Case 1
                        Opic23.Image = My.Resources._21п
                    Case 2
                        Opic23.Image = My.Resources._22п
                    Case 3
                        Opic23.Image = My.Resources._23п
                    Case 4
                        Opic23.Image = My.Resources._24п
                    Case 5
                        Opic23.Image = My.Resources._25п
                    Case 6
                        Opic23.Image = My.Resources._26п
                    Case 7
                        Opic23.Image = My.Resources._27п
                    Case 8
                        Opic23.Image = My.Resources._28п
                    Case 9
                        Opic23.Image = My.Resources._29п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 3, 1)
                    Case 0
                        Opic33.Image = My.Resources._30п
                    Case 1
                        Opic33.Image = My.Resources._31п
                    Case 2
                        Opic33.Image = My.Resources._32п
                    Case 3
                        Opic33.Image = My.Resources._33п
                    Case 4
                        Opic33.Image = My.Resources._34п
                    Case 5
                        Opic33.Image = My.Resources._35п
                    Case 6
                        Opic33.Image = My.Resources._36п
                    Case 7
                        Opic33.Image = My.Resources._37п
                    Case 8
                        Opic33.Image = My.Resources._38п
                    Case 9
                        Opic33.Image = My.Resources._39п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 4, 1)
                    Case 0
                        Opic43.Image = My.Resources._40п
                    Case 1
                        Opic43.Image = My.Resources._41п
                    Case 2
                        Opic43.Image = My.Resources._42п
                    Case 3
                        Opic43.Image = My.Resources._43п
                    Case 4
                        Opic43.Image = My.Resources._44п
                    Case 5
                        Opic43.Image = My.Resources._45п
                    Case 6
                        Opic43.Image = My.Resources._46п
                    Case 7
                        Opic43.Image = My.Resources._47п
                    Case 8
                        Opic43.Image = My.Resources._48п
                    Case 9
                        Opic43.Image = My.Resources._49п
                End Select
        End Select

    End Sub
    Private Sub ShowMesto4()
        Dim Plaver As String
        Plaver = Mid(ListWiners, 4, 1)
        If Math.Sign(PlaverScore(Plaver)) = -1 Then
            OPic04.Image = My.Resources.Минус_п
        Else
            OPic04.Image = My.Resources.Плюс_п
        End If

        Select Case Len(Str(Math.Abs(PlaverScore(Plaver)))) - 1
            Case 1
                Select Case PlaverScore(Plaver)
                    Case 0
                        OPic14.Image = My.Resources.Ноль_п
                    Case 1
                        OPic14.Image = My.Resources._11п
                    Case 2
                        OPic14.Image = My.Resources._12п
                    Case 3
                        OPic14.Image = My.Resources._13п
                    Case 4
                        OPic14.Image = My.Resources._14п
                    Case 5
                        OPic14.Image = My.Resources._15п
                    Case 6
                        OPic14.Image = My.Resources._16п
                    Case 7
                        OPic14.Image = My.Resources._17п
                    Case 8
                        OPic14.Image = My.Resources._18п
                    Case 9
                        OPic14.Image = My.Resources._19п
                End Select
                OPic24.Image = My.Resources._2_откп
                OPic34.Image = My.Resources._3_откп
                OPic44.Image = My.Resources._4_откп
            Case 2
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        OPic14.Image = My.Resources._11п
                    Case 2
                        OPic14.Image = My.Resources._12п
                    Case 3
                        OPic14.Image = My.Resources._13п
                    Case 4
                        OPic14.Image = My.Resources._14п
                    Case 5
                        OPic14.Image = My.Resources._15п
                    Case 6
                        OPic14.Image = My.Resources._16п
                    Case 7
                        OPic14.Image = My.Resources._17п
                    Case 8
                        OPic14.Image = My.Resources._18п
                    Case 9
                        OPic14.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        OPic24.Image = My.Resources._20п
                    Case 1
                        OPic24.Image = My.Resources._21п
                    Case 2
                        OPic24.Image = My.Resources._22п
                    Case 3
                        OPic24.Image = My.Resources._23п
                    Case 4
                        OPic24.Image = My.Resources._24п
                    Case 5
                        OPic24.Image = My.Resources._25п
                    Case 6
                        OPic24.Image = My.Resources._26п
                    Case 7
                        OPic24.Image = My.Resources._27п
                    Case 8
                        OPic24.Image = My.Resources._28п
                    Case 9
                        OPic24.Image = My.Resources._29п
                End Select
                OPic34.Image = My.Resources._3_откп
                OPic44.Image = My.Resources._4_откп
            Case 3
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        OPic14.Image = My.Resources._11п
                    Case 2
                        OPic14.Image = My.Resources._12п
                    Case 3
                        OPic14.Image = My.Resources._13п
                    Case 4
                        OPic14.Image = My.Resources._14п
                    Case 5
                        OPic14.Image = My.Resources._15п
                    Case 6
                        OPic14.Image = My.Resources._16п
                    Case 7
                        OPic14.Image = My.Resources._17п
                    Case 8
                        OPic14.Image = My.Resources._18п
                    Case 9
                        OPic14.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        OPic24.Image = My.Resources._20п
                    Case 1
                        OPic24.Image = My.Resources._21п
                    Case 2
                        OPic24.Image = My.Resources._22п
                    Case 3
                        OPic24.Image = My.Resources._23п
                    Case 4
                        OPic24.Image = My.Resources._24п
                    Case 5
                        OPic24.Image = My.Resources._25п
                    Case 6
                        OPic24.Image = My.Resources._26п
                    Case 7
                        OPic24.Image = My.Resources._27п
                    Case 8
                        OPic24.Image = My.Resources._28п
                    Case 9
                        OPic24.Image = My.Resources._29п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 3, 1)
                    Case 0
                        OPic34.Image = My.Resources._30п
                    Case 1
                        OPic34.Image = My.Resources._31п
                    Case 2
                        OPic34.Image = My.Resources._32п
                    Case 3
                        OPic34.Image = My.Resources._33п
                    Case 4
                        OPic34.Image = My.Resources._34п
                    Case 5
                        OPic34.Image = My.Resources._35п
                    Case 6
                        OPic34.Image = My.Resources._36п
                    Case 7
                        OPic34.Image = My.Resources._37п
                    Case 8
                        OPic34.Image = My.Resources._38п
                    Case 9
                        OPic34.Image = My.Resources._39п
                End Select
                OPic44.Image = My.Resources._4_откп
            Case 4
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 1, 1)
                    Case 1
                        OPic14.Image = My.Resources._11п
                    Case 2
                        OPic14.Image = My.Resources._12п
                    Case 3
                        OPic14.Image = My.Resources._13п
                    Case 4
                        OPic14.Image = My.Resources._14п
                    Case 5
                        OPic14.Image = My.Resources._15п
                    Case 6
                        OPic14.Image = My.Resources._16п
                    Case 7
                        OPic14.Image = My.Resources._17п
                    Case 8
                        OPic14.Image = My.Resources._18п
                    Case 9
                        OPic14.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 2, 1)
                    Case 0
                        OPic24.Image = My.Resources._20п
                    Case 1
                        OPic24.Image = My.Resources._21п
                    Case 2
                        OPic24.Image = My.Resources._22п
                    Case 3
                        OPic24.Image = My.Resources._23п
                    Case 4
                        OPic24.Image = My.Resources._24п
                    Case 5
                        OPic24.Image = My.Resources._25п
                    Case 6
                        OPic24.Image = My.Resources._26п
                    Case 7
                        OPic24.Image = My.Resources._27п
                    Case 8
                        OPic24.Image = My.Resources._28п
                    Case 9
                        OPic24.Image = My.Resources._29п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 3, 1)
                    Case 0
                        OPic34.Image = My.Resources._30п
                    Case 1
                        OPic34.Image = My.Resources._31п
                    Case 2
                        OPic34.Image = My.Resources._32п
                    Case 3
                        OPic34.Image = My.Resources._33п
                    Case 4
                        OPic34.Image = My.Resources._34п
                    Case 5
                        OPic34.Image = My.Resources._35п
                    Case 6
                        OPic34.Image = My.Resources._36п
                    Case 7
                        OPic34.Image = My.Resources._37п
                    Case 8
                        OPic34.Image = My.Resources._38п
                    Case 9
                        OPic34.Image = My.Resources._39п
                End Select
                Select Case Mid(Math.Abs(PlaverScore(Plaver)), 4, 1)
                    Case 0
                        OPic44.Image = My.Resources._40п
                    Case 1
                        OPic44.Image = My.Resources._41п
                    Case 2
                        OPic44.Image = My.Resources._42п
                    Case 3
                        OPic44.Image = My.Resources._43п
                    Case 4
                        OPic44.Image = My.Resources._44п
                    Case 5
                        OPic44.Image = My.Resources._45п
                    Case 6
                        OPic44.Image = My.Resources._46п
                    Case 7
                        OPic44.Image = My.Resources._47п
                    Case 8
                        OPic44.Image = My.Resources._48п
                    Case 9
                        OPic44.Image = My.Resources._49п
                End Select
        End Select

    End Sub
    
    
    Public Sub ShowRecord(ByVal PScoreRecord As String)
        If Math.Sign(Val(PScoreRecord)) = -1 Then
            OPic07.Image = My.Resources.Минус_п
        Else
            OPic07.Image = My.Resources.Плюс_п
        End If

        Select Case Len(Str(Math.Abs(Val(PScoreRecord)))) - 1
            Case 1
                Select Case PScoreRecord
                    Case 0
                        OPic17.Image = My.Resources.Ноль_п
                    Case 1
                        OPic17.Image = My.Resources._11п
                    Case 2
                        OPic17.Image = My.Resources._12п
                    Case 3
                        OPic17.Image = My.Resources._13п
                    Case 4
                        OPic17.Image = My.Resources._14п
                    Case 5
                        OPic17.Image = My.Resources._15п
                    Case 6
                        OPic17.Image = My.Resources._16п
                    Case 7
                        OPic17.Image = My.Resources._17п
                    Case 8
                        OPic17.Image = My.Resources._18п
                    Case 9
                        OPic17.Image = My.Resources._19п
                End Select
                OPic27.Image = My.Resources._2_откп
                OPic37.Image = My.Resources._3_откп
                OPic47.Image = My.Resources._4_откп
            Case 2
                Select Case Mid(Math.Abs(Val(PScoreRecord)), 1, 1)
                    Case 1
                        OPic17.Image = My.Resources._11п
                    Case 2
                        OPic17.Image = My.Resources._12п
                    Case 3
                        OPic17.Image = My.Resources._13п
                    Case 4
                        OPic17.Image = My.Resources._14п
                    Case 5
                        OPic17.Image = My.Resources._15п
                    Case 6
                        OPic17.Image = My.Resources._16п
                    Case 7
                        OPic17.Image = My.Resources._17п
                    Case 8
                        OPic17.Image = My.Resources._18п
                    Case 9
                        OPic17.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(Val(PScoreRecord)), 2, 1)
                    Case 0
                        OPic27.Image = My.Resources._20п
                    Case 1
                        OPic27.Image = My.Resources._21п
                    Case 2
                        OPic27.Image = My.Resources._22п
                    Case 3
                        OPic27.Image = My.Resources._23п
                    Case 4
                        OPic27.Image = My.Resources._24п
                    Case 5
                        OPic27.Image = My.Resources._25п
                    Case 6
                        OPic27.Image = My.Resources._26п
                    Case 7
                        OPic27.Image = My.Resources._27п
                    Case 8
                        OPic27.Image = My.Resources._28п
                    Case 9
                        OPic27.Image = My.Resources._29п
                End Select
                OPic37.Image = My.Resources._3_откп
                OPic47.Image = My.Resources._4_откп
            Case 3
                Select Case Mid(Math.Abs(Val(PScoreRecord)), 1, 1)
                    Case 1
                        OPic17.Image = My.Resources._11п
                    Case 2
                        OPic17.Image = My.Resources._12п
                    Case 3
                        OPic17.Image = My.Resources._13п
                    Case 4
                        OPic17.Image = My.Resources._14п
                    Case 5
                        OPic17.Image = My.Resources._15п
                    Case 6
                        OPic17.Image = My.Resources._16п
                    Case 7
                        OPic17.Image = My.Resources._17п
                    Case 8
                        OPic17.Image = My.Resources._18п
                    Case 9
                        OPic17.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(Val(PScoreRecord)), 2, 1)
                    Case 0
                        OPic27.Image = My.Resources._20п
                    Case 1
                        OPic27.Image = My.Resources._21п
                    Case 2
                        OPic27.Image = My.Resources._22п
                    Case 3
                        OPic27.Image = My.Resources._23п
                    Case 4
                        OPic27.Image = My.Resources._24п
                    Case 5
                        OPic27.Image = My.Resources._25п
                    Case 6
                        OPic27.Image = My.Resources._26п
                    Case 7
                        OPic27.Image = My.Resources._27п
                    Case 8
                        OPic27.Image = My.Resources._28п
                    Case 9
                        OPic27.Image = My.Resources._29п
                End Select
                Select Case Mid(Math.Abs(Val(PScoreRecord)), 3, 1)
                    Case 0
                        OPic37.Image = My.Resources._30п
                    Case 1
                        OPic37.Image = My.Resources._31п
                    Case 2
                        OPic37.Image = My.Resources._32п
                    Case 3
                        OPic37.Image = My.Resources._33п
                    Case 4
                        OPic37.Image = My.Resources._34п
                    Case 5
                        OPic37.Image = My.Resources._35п
                    Case 6
                        OPic37.Image = My.Resources._36п
                    Case 7
                        OPic37.Image = My.Resources._37п
                    Case 8
                        OPic37.Image = My.Resources._38п
                    Case 9
                        OPic37.Image = My.Resources._39п
                End Select
                OPic47.Image = My.Resources._4_откп
            Case 4
                Select Case Mid(Math.Abs(Val(PScoreRecord)), 1, 1)
                    Case 1
                        OPic17.Image = My.Resources._11п
                    Case 2
                        OPic17.Image = My.Resources._12п
                    Case 3
                        OPic17.Image = My.Resources._13п
                    Case 4
                        OPic17.Image = My.Resources._14п
                    Case 5
                        OPic17.Image = My.Resources._15п
                    Case 6
                        OPic17.Image = My.Resources._16п
                    Case 7
                        OPic17.Image = My.Resources._17п
                    Case 8
                        OPic17.Image = My.Resources._18п
                    Case 9
                        OPic17.Image = My.Resources._19п
                End Select
                Select Case Mid(Math.Abs(Val(PScoreRecord)), 2, 1)
                    Case 0
                        OPic27.Image = My.Resources._20п
                    Case 1
                        OPic27.Image = My.Resources._21п
                    Case 2
                        OPic27.Image = My.Resources._22п
                    Case 3
                        OPic27.Image = My.Resources._23п
                    Case 4
                        OPic27.Image = My.Resources._24п
                    Case 5
                        OPic27.Image = My.Resources._25п
                    Case 6
                        OPic27.Image = My.Resources._26п
                    Case 7
                        OPic27.Image = My.Resources._27п
                    Case 8
                        OPic27.Image = My.Resources._28п
                    Case 9
                        OPic27.Image = My.Resources._29п
                End Select
                Select Case Mid(Math.Abs(Val(PScoreRecord)), 3, 1)
                    Case 0
                        OPic37.Image = My.Resources._30п
                    Case 1
                        OPic37.Image = My.Resources._31п
                    Case 2
                        OPic37.Image = My.Resources._32п
                    Case 3
                        OPic37.Image = My.Resources._33п
                    Case 4
                        OPic37.Image = My.Resources._34п
                    Case 5
                        OPic37.Image = My.Resources._35п
                    Case 6
                        OPic37.Image = My.Resources._36п
                    Case 7
                        OPic37.Image = My.Resources._37п
                    Case 8
                        OPic37.Image = My.Resources._38п
                    Case 9
                        OPic37.Image = My.Resources._39п
                End Select
                Select Case Mid(Math.Abs(Val(PScoreRecord)), 4, 1)
                    Case 0
                        OPic47.Image = My.Resources._40п
                    Case 1
                        OPic47.Image = My.Resources._41п
                    Case 2
                        OPic47.Image = My.Resources._42п
                    Case 3
                        OPic47.Image = My.Resources._43п
                    Case 4
                        OPic47.Image = My.Resources._44п
                    Case 5
                        OPic47.Image = My.Resources._45п
                    Case 6
                        OPic47.Image = My.Resources._46п
                    Case 7
                        OPic47.Image = My.Resources._47п
                    Case 8
                        OPic47.Image = My.Resources._48п
                    Case 9
                        OPic47.Image = My.Resources._49п
                End Select
        End Select

    End Sub
    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        PicTablo.Image = My.Resources.Кнопка_турнирная_таблицаТ
        PicNewGame.Image = My.Resources.Кнопка_новая_игра_малаяТ
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicTablo.Click
        Dialog1.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicNewGame.Click
        Me.Hide()
        Me.Close()
        Form1.Show()
        'Скрыть элементы управления и отображения
        Form1.Opic0.Visible = False
        Form1.Opic1.Visible = False
        Form1.Opic2.Visible = False
        Form1.Opic3.Visible = False
        Form1.Opic4.Visible = False
        Form1.TurPic.Visible = False
        Form1.StartPic.Visible = False
        Form1.StavkaPic.Visible = False
        Form1.BonusPic.Visible = False
        Form1.BringToFront()
        Form1.NewGame()
    End Sub


    Private Sub PicNewGame_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicNewGame.MouseMove
        PicNewGame.Image = My.Resources.Кнопка_новая_игра_малаяС
    End Sub

    Private Sub PicTablo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicTablo.MouseMove
        PicTablo.Image = My.Resources.Кнопка_турнирная_таблицаС
    End Sub



    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick

    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick

    End Sub

    Private Sub CubokPic_Click(sender As Object, e As EventArgs) Handles CubokPic.Click

    End Sub
End Class