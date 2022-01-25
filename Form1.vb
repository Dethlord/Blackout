'




'
Imports System
Imports System.IO
Imports System.Reflection
Imports System.Media
Imports Microsoft.DirectX.DirectSound
Imports Microsoft.Win32

Public Class Form1
    'Инициализация звуков
    Private SCards As Stream = My.Resources.Звук_карт
    Private SoundCards As SoundPlayer = New SoundPlayer(SCards)

    Private SStart As Stream = My.Resources.Звук_старта
    Private SoundStart As SoundPlayer = New SoundPlayer(SStart)

    Private SStavka As Stream = My.Resources.Звук_ставки
    Private SoundStavka As SoundPlayer = New SoundPlayer(SStavka)

    Private SNStart As Stream = My.Resources.Старт
    Private SoundNStart As SoundPlayer = New SoundPlayer(SNStart)

    Private SKresti As Stream = My.Resources.крести
    Private SoundKresti As SoundPlayer = New SoundPlayer(SKresti)

    Private SPiki As Stream = My.Resources.пики
    Private SoundPiki As SoundPlayer = New SoundPlayer(SPiki)

    Private SChirva As Stream = My.Resources.червы
    Private SoundChirva As SoundPlayer = New SoundPlayer(SChirva)

    Private SBuba As Stream = My.Resources.бубны
    Private SoundBuba As SoundPlayer = New SoundPlayer(SBuba)

    Private SNeSpeshi As Stream = My.Resources.Не_спеши
    Private SoundNeSpeshi As SoundPlayer = New SoundPlayer(SNeSpeshi)

    Private SNeMain As Stream = My.Resources.Не_старшая
    Private SoundNeMain As SoundPlayer = New SoundPlayer(SNeMain)

    Private SSamMainCards As Stream = My.Resources.По_самым_ст_картам
    Private SoundSamMainCards As SoundPlayer = New SoundPlayer(SSamMainCards)

    Private SSamMainCardsAnd As Stream = My.Resources.По_старшим_коз_и_кар
    Private SoundSamMainCardsAnd As SoundPlayer = New SoundPlayer(SSamMainCardsAnd)
    'Шлема
    Private SShlem1 As Stream = My.Resources.начальный_шлем
    Private SoundShlem1 As SoundPlayer = New SoundPlayer(SShlem1)

    Private SShlem2 As Stream = My.Resources.двойной_шлем
    Private SoundShlem2 As SoundPlayer = New SoundPlayer(SShlem2)

    Private SShlem3 As Stream = My.Resources.тройной_шлем
    Private SoundShlem3 As SoundPlayer = New SoundPlayer(SShlem3)

    Private SShlem4 As Stream = My.Resources.шлем_каре
    Private SoundShlem4 As SoundPlayer = New SoundPlayer(SShlem4)

    Private SShlem5 As Stream = My.Resources.шлем_с_пяти
    Private SoundShlem5 As SoundPlayer = New SoundPlayer(SShlem5)

    Private SShlem6 As Stream = My.Resources.супер_шлем
    Private SoundShlem6 As SoundPlayer = New SoundPlayer(SShlem6)
    'Предупреждения
    Private PokHave As Stream = My.Resources.У_вас_покер
    Private SoundPokHave As SoundPlayer = New SoundPlayer(PokHave)

    Private BezKoz As Stream = My.Resources.Внимание_бескоз_режим
    Private SoundBezKoz As SoundPlayer = New SoundPlayer(BezKoz)


    Private MySoundCard As Device



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Проверка версии NET FRAMEWORK 
        If System.Environment.Version.Major < 2 Then
            MsgBox("NetFramework отсутствует, либо устарел")
        End If
        'Инициализация звуковой карты
        MySoundCard = New Device
        MySoundCard.SetCooperativeLevel(Me.Handle, CooperativeLevel.Priority)

        NewGamePic.Image = My.Resources.Кнопка_новая_играТ
        Randomize()
        Inizialization()
        MainMasiv()
        ShowDeck()
    End Sub

    Public Sub Inizialization()
        Me.Text = "Русский блэкаут 2021"
        'Обьявление массивов элементов управления
        cb(1) = Me.PictureBox1 : cb(2) = Me.PictureBox2 : cb(3) = Me.PictureBox3 : cb(4) = Me.PictureBox4
        cb(5) = Me.PictureBox5 : cb(6) = Me.PictureBox6 : cb(7) = Me.PictureBox7 : cb(8) = Me.PictureBox8
        cb(9) = Me.PictureBox9 : cb(10) = Me.PictureBox10 : cb(11) = Me.PictureBox11 : cb(12) = Me.PictureBox12
        cb(13) = Me.PictureBox13 : cb(14) = Me.PictureBox14 : cb(15) = Me.PictureBox15 : cb(16) = Me.PictureBox16
        cb(17) = Me.PictureBox17 : cb(18) = Me.PictureBox18 : cb(19) = Me.PictureBox19 : cb(20) = Me.PictureBox20
        cb(21) = Me.PictureBox21 : cb(22) = Me.PictureBox22 : cb(23) = Me.PictureBox23 : cb(24) = Me.PictureBox24
        cb(25) = Me.PictureBox25 : cb(26) = Me.PictureBox26 : cb(27) = Me.PictureBox27 : cb(28) = Me.PictureBox28
        cb(29) = Me.PictureBox29 : cb(30) = Me.PictureBox30 : cb(31) = Me.PictureBox31 : cb(32) = Me.PictureBox32
        cb(33) = Me.PictureBox33 : cb(34) = Me.PictureBox34 : cb(35) = Me.PictureBox35 : cb(36) = Me.PictureBox36
        Igrok(1) = Me.Picture1 : Igrok(2) = Me.Picture2 : Igrok(3) = Me.Picture3 : Igrok(4) = Me.Picture4
        Igrok(5) = Me.Picture5 : Igrok(6) = Me.Picture6
        prot1(1) = Me.PictureBox42 : prot1(2) = Me.PictureBox41 : prot1(3) = Me.PictureBox40 : prot1(4) = Me.PictureBox39
        prot1(5) = Me.PictureBox38 : prot1(6) = Me.PictureBox37
        prot2(1) = Me.PictureBox48 : prot2(2) = Me.PictureBox47 : prot2(3) = Me.PictureBox46 : prot2(4) = Me.PictureBox45
        prot2(5) = Me.PictureBox44 : prot2(6) = Me.PictureBox43
        prot3(1) = Me.PictureBox55 : prot3(2) = Me.PictureBox54 : prot3(3) = Me.PictureBox52 : prot3(4) = Me.PictureBox51
        prot3(5) = Me.PictureBox50 : prot3(6) = Me.PictureBox49

        CardsTable(1) = Me.PictureBox68 : CardsTable(2) = Me.PictureBox69 : CardsTable(3) = Me.PictureBox70
        CardsTable(4) = Me.PictureBox71 : CardsTable(5) = Me.PictureBox72 : CardsTable(6) = Me.PictureBox73

        StolKardsVis() 'Скрываем картинки карт на столе
        PicActivCard.Visible = False 'Скрыть активную карту
        'и противников
        For fgh2 As Integer = 1 To 6
            Igrok(fgh2).Visible = False
            prot1(fgh2).Visible = False
            prot2(fgh2).Visible = False
            prot3(fgh2).Visible = False
        Next
        BonusPic.Visible = False
        Kozirpict.Visible = False
        'Установка имени игрока 
        PlaverNameFromFile()
        PicPlaverName.Text = PlaverName
        'Скрываем все картинки взятия взяток
        Vzat1.Visible = False
        Vzat2.Visible = False
        Vzat3.Visible = False
        Vzat4.Visible = False

        'Убрать в начале меню игры
        MenuStrip1.Visible = False
        'Скрыть кнопку старта и ставок
        StavkaPic.Visible = False
        StavkaPic2.Visible = False
        StavkaPic3.Visible = False
        StavkaPic4.Visible = False
        StartPic.Visible = False
        'Звук включен по умолчанию
        Sound = True
        'Задний фон по умолчанию зеленый
        Me.BackColor = Color.Green
        'Скрыть картинку права руки(хода) и имени 1 игрока
        PicPlaverName.Visible = False
        PicPravo1.Visible = False
        PicPravo2.Visible = False
        PicPravo3.Visible = False
        PicPravo4.Visible = False

        'Установка картинок имен
        PicPravo1.Image = My.Resources.Игрок
        PicPravo2.Image = My.Resources.Спок
        PicPravo3.Image = My.Resources.Мария
        PicPravo4.Image = My.Resources.Алекс

        'Скрыть название тура
        TurPic.Visible = False
        'Скрыть очки
        Opic0.Visible = False
        Opic1.Visible = False
        Opic2.Visible = False
        Opic3.Visible = False
        Opic4.Visible = False



    End Sub

    Private Sub НоваяИграToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles НоваяИграToolStripMenuItem.Click
        NewGamePic.Visible = False
        NewGame()
    End Sub

    Private Sub Picture1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture1.Click, Picture2.Click, Picture3.Click, Picture4.Click, Picture5.Click, Picture6.Click
        'Не давать играть пока не закрепленна ставка
        If isPlaverBid = False Then
            If Sound Then
                SoundNStart.Play()
            End If
            Exit Sub
        End If
        'Блок для предотврашения бага(фикса)Возникает ситуация когда человек берет взятку и все карты уже лежат на столе -он может скинуть лишнию карту(причем она просто исчезает в никуда(так как все места под карты заняты))
        If CardsTable(RndTableLocation(1)).Visible = True And CardsTable(RndTableLocation(2)).Visible = True And
         CardsTable(RndTableLocation(3)).Visible = True And CardsTable(RndTableLocation(4)).Visible = True Then
            Exit Sub
        End If
        If RightToMove = 1 Then
            If StavkaSelector.Enabled = False Then 'Ход разрешен только после выставления всех ставок
                If isPlaverBid = True Then
                    If RightToMove = 1 Then
                        Select Case DirectCast(sender, PictureBox).Name
                            Case Picture1.Name
                                CurentSelectCard = 1
                                ValidationForMen()
                                If isDiscard = True Then
                                    SpentCards(1, 1) = 1
                                    For yui As Integer = 1 To 4
                                        If CardsTable(RndTableLocation(yui)).Visible = False Then
                                            CardsTable(RndTableLocation(yui)).Visible = True
                                            CardsTable(RndTableLocation(yui)).Image = Igrok(1).Image
                                            CardsTable(RndTableLocation(yui)).BringToFront()
                                            Exit For
                                        End If
                                    Next yui
                                    Picture1.Visible = False
                                End If
                            Case Picture2.Name
                                CurentSelectCard = 2
                                ValidationForMen()
                                If isDiscard = True Then
                                    SpentCards(1, 2) = 1
                                    For yui As Integer = 1 To 4
                                        If CardsTable(RndTableLocation(yui)).Visible = False Then
                                            CardsTable(RndTableLocation(yui)).Visible = True
                                            CardsTable(RndTableLocation(yui)).Image = Igrok(2).Image
                                            CardsTable(RndTableLocation(yui)).BringToFront()
                                            Exit For
                                        End If
                                    Next yui
                                    Picture2.Visible = False
                                End If
                            Case Picture3.Name
                                CurentSelectCard = 3
                                ValidationForMen()
                                If isDiscard = True Then
                                    SpentCards(1, 3) = 1
                                    For yui As Integer = 1 To 4
                                        If CardsTable(RndTableLocation(yui)).Visible = False Then
                                            CardsTable(RndTableLocation(yui)).Visible = True
                                            CardsTable(RndTableLocation(yui)).Image = Igrok(3).Image
                                            CardsTable(RndTableLocation(yui)).BringToFront()
                                            Exit For
                                        End If
                                    Next yui
                                    Picture3.Visible = False
                                End If
                            Case Picture4.Name
                                CurentSelectCard = 4
                                ValidationForMen()
                                If isDiscard = True Then
                                    SpentCards(1, 4) = 1
                                    For yui As Integer = 1 To 4
                                        If CardsTable(RndTableLocation(yui)).Visible = False Then
                                            CardsTable(RndTableLocation(yui)).Visible = True
                                            CardsTable(RndTableLocation(yui)).Image = Igrok(4).Image
                                            CardsTable(RndTableLocation(yui)).BringToFront()
                                            Exit For
                                        End If
                                    Next yui
                                    Picture4.Visible = False
                                End If
                            Case Picture5.Name
                                CurentSelectCard = 5
                                ValidationForMen()
                                If isDiscard = True Then
                                    SpentCards(1, 5) = 1
                                    For player As Integer = 1 To 4
                                        If CardsTable(RndTableLocation(player)).Visible = False Then
                                            CardsTable(RndTableLocation(player)).Visible = True
                                            CardsTable(RndTableLocation(player)).Image = Igrok(5).Image
                                            CardsTable(RndTableLocation(player)).BringToFront()
                                            Exit For
                                        End If
                                    Next player
                                    Picture5.Visible = False
                                End If
                            Case Picture6.Name
                                CurentSelectCard = 6
                                ValidationForMen()
                                If isDiscard = True Then
                                    SpentCards(1, 6) = 1
                                    For player As Integer = 1 To 4
                                        If CardsTable(RndTableLocation(player)).Visible = False Then
                                            CardsTable(RndTableLocation(player)).Visible = True
                                            CardsTable(RndTableLocation(player)).Image = Igrok(6).Image
                                            CardsTable(RndTableLocation(player)).BringToFront()
                                            Exit For
                                        End If
                                    Next player
                                    Picture6.Visible = False
                                End If
                        End Select
                    End If

                    If isDiscard Then
                        If Sound Then
                            SoundCards.Play()
                        End If
                    End If

                    StartPic.Enabled = False 'Запретить ставить ставку игроку
                    If isDiscard = True Then
                        CheckFull = CheckFull + 1
                        'Если 1 элемент массива CardsPlaversStolPow пуст значит ком не ходил с активной карты соответственно
                        'обьявляем активную карту 1 игрока и добавляем к ней +50
                        If CardsPlaversTablePow(1) = 0 Then
                            CardsPlaversPow(RightToMove, CurentSelectCard) += 50
                            ActiveCard = CardsPlavers(RightToMove, CurentSelectCard)
                        End If
                        IsActiveCard = True
                        If CheckFull = 5 Then CheckFull = 1
                        CardsPlaversTablePow(CheckFull) = CardsPlaversPow(RightToMove, CurentSelectCard)
                        RightToMove = RightToMove + 1
                        ShowActivCard() 'Показать активную карту
                        PutCardselector.Interval = SpeedRasclad
                        PutCardselector.Start()
                    End If
                End If
            Else
                If Sound Then
                    SoundNeSpeshi.PlaySync()
                Else
                    MsgBox("Будь вежлив,пусть все cделают ставки", MsgBoxStyle.Information)
                End If

            End If
        End If
    End Sub
    Public Function ValidationForMen() As Boolean
        'Функция аназиза разрешенности,Возратит истину при разрешенности выбранного хода
        'Игнорировать данный блок в первом туре
        Dim gak As Integer
        Dim proxod As Boolean
        Dim bilo As Integer
        Dim Naibol, Naibol1, Naibol2, Naibol3, Naibol4, Naibol5, Naibol6 As Integer
        'Если заходим первыми то не ограничивать ни в чем
        If IsActiveCard = False Then
            isDiscard = True
            Exit Function
        End If
        'Если у нас валет буби(джокер) то разрешить в любой ситуации
        If CardsPlavers(RightToMove, CurentSelectCard) = 24 Then
            isDiscard = True
            Exit Function
        End If

        'Если карта которую надо побить валет то запретить ходить игроку кроме его высшей(высших) карт
        If ActiveCard = 24 Then
            For gg As Integer = 1 To NumberOfCards
                If Not (SpentCards(RightToMove, gg) = 1) Then 'Если карта отработана то её не анализировать
                    bilo = bilo + 1
                    AnalizCards(bilo) = gg 'Занесем анализируемые карты(для удобства)
                End If
            Next gg

            Select Case bilo
                Case 1 'Когда осталась 1 карта
                    isDiscard = True
                    Exit Function
                Case 2 ''Когда остались 2 карты
                    'Реакция на одинаковые по ценности
                    If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                        isDiscard = True
                        Exit Function
                    End If
                    'Узнаем наибольшию карту
                    If CardsPlaversPow(RightToMove, AnalizCards(1)) > CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                        Naibol = AnalizCards(1)
                    Else
                        Naibol = AnalizCards(2)
                    End If
                Case 3 'Когда остались 3 карты
                    'Реакция на одинаковые по ценности
                    If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                        isDiscard = True
                        Exit Function
                    End If
                    'Узнаем наибольшию карту
                    If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                   CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                        Naibol1 = AnalizCards(1)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                        Naibol2 = AnalizCards(2)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                        Naibol3 = AnalizCards(3)
                    End If
                Case 4 'Когда остались 4 карты
                    'Реакция на одинаковые по ценности
                    If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(3)) And
                       CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                        isDiscard = True
                        Exit Function
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                     CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                     CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                        Naibol1 = AnalizCards(1)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                       CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                        Naibol2 = AnalizCards(2)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                        Naibol3 = AnalizCards(3)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                        Naibol4 = AnalizCards(4)
                    End If
                Case 5 'Когда осталось 5 карт
                    If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                       CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                       CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                        Naibol1 = AnalizCards(1)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                       CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                       CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                        Naibol2 = AnalizCards(2)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                       CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                        Naibol3 = AnalizCards(3)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                       CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                        Naibol4 = AnalizCards(4)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                       CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                        Naibol5 = AnalizCards(5)
                    End If
                Case 6 'Когда 6 карт
                    If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                        Naibol1 = AnalizCards(1)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                       CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                       CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                       CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                        Naibol2 = AnalizCards(2)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                       CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                       CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                        Naibol3 = AnalizCards(3)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                       CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                       CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                        Naibol4 = AnalizCards(4)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                       CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                       CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                        Naibol5 = AnalizCards(5)
                    End If
                    If CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                       CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                       CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                       CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                        Naibol6 = AnalizCards(6)
                    End If
            End Select
            If CurentSelectCard = Naibol Or CurentSelectCard = Naibol1 Or CurentSelectCard = Naibol2 Or CurentSelectCard = Naibol3 _
            Or CurentSelectCard = Naibol4 Or CurentSelectCard = Naibol5 Or CurentSelectCard = Naibol6 Then
                isDiscard = True
                Exit Function
            Else
                If Sound Then
                    SoundNeMain.Play()
                Else
                    MsgBox("Это не старшая карта", MsgBoxStyle.Information)
                End If
            End If
        Else 'Анализ разрешенности при других ситуациях

            Select Case NumberOfCards
                Case 1
                    isDiscard = True
                    Exit Function
                Case 2, 3, 4, 5, 6
                    'Если выбранная карта находится в том же ряду что и активная то разршить ход и обавить +50 к ценности
                    gak = GetActiveCardColumn()
                    For aa As Integer = 1 To 9
                        If CardsPlavers(RightToMove, CurentSelectCard) = StartArray(aa, gak) Then
                            CardsPlaversPow(RightToMove, CurentSelectCard) += 50
                            isDiscard = True
                            Exit Function
                        End If
                    Next aa
            End Select

            'Если имеется карта совпадающая с рядом активной то не дать ходить кроме её(их)
            gak = GetActiveCardColumn()
            For gg As Integer = 1 To NumberOfCards
                If Not (SpentCards(RightToMove, gg) = 1) Then 'Не просматривать отработанные карты
                    For aa As Integer = 1 To 9
                        If Not (CardsPlavers(RightToMove, gg)) = 24 Then 'обход при вальте буби(чтоб при активной буби не вытягивала вальта с вас)
                            If CardsPlavers(RightToMove, gg) = StartArray(aa, gak) Then
                                proxod = True 'Подтверждение события совпадения
                                Exit For
                            End If
                        End If
                    Next aa
                End If
            Next gg
            If proxod = True Then
                'Если выбранная карта находится в том же ряду что и активная то разршить ход и обавить +50 к ценности
                For aa As Integer = 1 To 9
                    If CardsPlavers(RightToMove, CurentSelectCard) = StartArray(aa, gak) Then
                        CardsPlaversPow(RightToMove, CurentSelectCard) += 50
                        isDiscard = True
                        Exit Function
                    End If
                Next aa
            Else
                isDiscard = True
                Exit Function
            End If
        End If
        'Относительно активной карты оповешаем о некоректности выбора
        Select Case gak
            Case 1
                If Sound Then
                    SoundPiki.Play()
                Else
                    MsgBox("Сбросте пики")
                End If
            Case 2
                If Sound Then
                    SoundKresti.Play()
                Else
                    MsgBox("Сбросте крести")
                End If
            Case 3
                If Sound Then
                    SoundChirva.Play()
                Else
                    MsgBox("Сбросте чирвы")
                End If
            Case 4
                If Sound Then
                    SoundBuba.Play()
                Else
                    MsgBox("Сбросте бубны")
                End If
        End Select
        isDiscard = False
    End Function

    Private Sub Picture1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Picture1.MouseMove, Picture2.MouseMove, Picture3.MouseMove, Picture4.MouseMove, Picture5.MouseMove, Picture6.MouseMove
        If StartPic.Enabled = True Then
            StartPic.Image = My.Resources.V1
        End If
        Select Case DirectCast(sender, PictureBox).Name
            Case Picture1.Name
                If MoveCards1 = False Then
                    Picture1.Top = Picture1.Top - 15
                    MoveCards1 = True
                    If MoveCards2 = True Then Picture2.Top = Picture2.Top + 15 : MoveCards2 = False
                    If MoveCards3 = True Then Picture3.Top = Picture3.Top + 15 : MoveCards3 = False
                    If MoveCards4 = True Then Picture4.Top = Picture4.Top + 15 : MoveCards4 = False
                    If MoveCards5 = True Then Picture5.Top = Picture5.Top + 15 : MoveCards5 = False
                    If MoveCards6 = True Then Picture6.Top = Picture6.Top + 15 : MoveCards6 = False
                End If
            Case Picture2.Name
                If MoveCards2 = False Then
                    Picture2.Top = Picture2.Top - 15
                    MoveCards2 = True
                    If MoveCards1 = True Then Picture1.Top = Picture1.Top + 15 : MoveCards1 = False
                    If MoveCards3 = True Then Picture3.Top = Picture3.Top + 15 : MoveCards3 = False
                    If MoveCards4 = True Then Picture4.Top = Picture4.Top + 15 : MoveCards4 = False
                    If MoveCards5 = True Then Picture5.Top = Picture5.Top + 15 : MoveCards5 = False
                    If MoveCards6 = True Then Picture6.Top = Picture6.Top + 15 : MoveCards6 = False
                End If
            Case Picture3.Name
                If MoveCards3 = False Then
                    Picture3.Top = Picture3.Top - 15
                    MoveCards3 = True
                    If MoveCards1 = True Then Picture1.Top = Picture1.Top + 15 : MoveCards1 = False
                    If MoveCards2 = True Then Picture2.Top = Picture2.Top + 15 : MoveCards2 = False
                    If MoveCards4 = True Then Picture4.Top = Picture4.Top + 15 : MoveCards4 = False
                    If MoveCards5 = True Then Picture5.Top = Picture5.Top + 15 : MoveCards5 = False
                    If MoveCards6 = True Then Picture6.Top = Picture6.Top + 15 : MoveCards6 = False
                End If
            Case Picture4.Name
                If MoveCards4 = False Then
                    Picture4.Top = Picture4.Top - 15
                    MoveCards4 = True
                    If MoveCards1 = True Then Picture1.Top = Picture1.Top + 15 : MoveCards1 = False
                    If MoveCards2 = True Then Picture2.Top = Picture2.Top + 15 : MoveCards2 = False
                    If MoveCards3 = True Then Picture3.Top = Picture3.Top + 15 : MoveCards3 = False
                    If MoveCards5 = True Then Picture5.Top = Picture5.Top + 15 : MoveCards5 = False
                    If MoveCards6 = True Then Picture6.Top = Picture6.Top + 15 : MoveCards6 = False
                End If
            Case Picture5.Name
                If MoveCards5 = False Then
                    Picture5.Top = Picture5.Top - 15
                    MoveCards5 = True
                    If MoveCards1 = True Then Picture1.Top = Picture1.Top + 15 : MoveCards1 = False
                    If MoveCards2 = True Then Picture2.Top = Picture2.Top + 15 : MoveCards2 = False
                    If MoveCards3 = True Then Picture3.Top = Picture3.Top + 15 : MoveCards3 = False
                    If MoveCards4 = True Then Picture4.Top = Picture4.Top + 15 : MoveCards4 = False
                    If MoveCards6 = True Then Picture6.Top = Picture6.Top + 15 : MoveCards6 = False
                End If
            Case Picture6.Name
                If MoveCards6 = False Then
                    Picture6.Top = Picture6.Top - 15
                    MoveCards6 = True
                    If MoveCards1 = True Then Picture1.Top = Picture1.Top + 15 : MoveCards1 = False
                    If MoveCards2 = True Then Picture2.Top = Picture2.Top + 15 : MoveCards2 = False
                    If MoveCards3 = True Then Picture3.Top = Picture3.Top + 15 : MoveCards3 = False
                    If MoveCards4 = True Then Picture4.Top = Picture4.Top + 15 : MoveCards4 = False
                    If MoveCards5 = True Then Picture5.Top = Picture5.Top + 15 : MoveCards5 = False
                End If
        End Select
        'Скрыть меню игры когда курсор на картах
        MenuStrip1.Visible = False

    End Sub
    Sub Main()
        Clearing() ' Очистка всех сущностей
        InitDeckArray() 'Инициализация массива карт
        ShowDeck() 'Показ колоды
        SetRandomPlaceArray() 'Иничиализация массива случайных позиций карт на столе
        'BonusPic.Visible = False перенес в процедуру Clearing
        RoundSelector() 'переключатель раундов
        InformAboutPoker() 'Оповещение наличия покера
        PlaversMoveShow() 'Показать право хода картинкой имени игроков
        Normalization() 'Нормализация ценности карт(так как некоторые карты могут иметь одинаковую ценность                      TODO поменял местами  Filter() и TrumpCheck()
        TrumpCheck() 'Проверка принадлежности карт к козырным и добавление к ним ценности

        BrainCalcStavka() 'Искуственный интелект выбора ставки
        Detector.Interval = 1
        Detector.Start() 'Запуск таймер детектирования полного набора карт на столе(все 4)
    End Sub
    Sub Clearing()
        Array.Clear(SpentCards, 0, 35) 'Чистим массив отработанных карт
        StolKardsVis() 'Скрываем картинки карт на столе
        'и противников
        For fgh2 As Integer = 1 To 6
            Igrok(fgh2).Visible = False
            prot1(fgh2).Visible = False
            prot2(fgh2).Visible = False
            prot3(fgh2).Visible = False

        Next
        'Скрываем картинку козыря
        Kozirpict.Visible = False
        'Скрываем картинку бонуса
        BonusPic.Visible = False
        'Скрываем все картинки взятия взяток
        Vzat1.Visible = False
        Vzat2.Visible = False
        Vzat3.Visible = False
        Vzat4.Visible = False


        StavkaPic2.Visible = False
        StavkaPic3.Visible = False
        StavkaPic4.Visible = False

        StartPic.Enabled = True
        StavkaPic.Enabled = True
        Array.Clear(RndDeck, 1, 36)
        Array.Clear(CardsPlavers, 1, 34)
        Array.Clear(CardsPlaversPow, 1, 34)
        Array.Clear(CardsPlaversTablePow, 1, 4)
        PutCardselector.Stop()
        Array.Clear(BidPlavers, 1, 4)
        isPlaverBid = False
        Bid = 0
        StavkaPic.Image = My.Resources.ПасБ
        IsActiveCard = False
        'Скрыть картинку права руки(хода)
        PicPlaverName.Visible = False
        PicPravo1.Visible = False
        PicPravo2.Visible = False
        PicPravo3.Visible = False
        PicPravo4.Visible = False

        'Выход козыря из игры нас интересует непосредственно в бескозырке
        If Round >= 6 And Round <= 11 Then
            isTrampOver = False
        Else
            isTrampOver = True
        End If
        CheckFull = 0
    End Sub


    Sub RoundSelector()
        Select Case Round
            Case 1
                TurPic.Visible = True : TurPic.Image = My.Resources.Соло
                FirstRightMove = 1 : RightToMove = 1 : RightOfBid = 1
                NumberOfCards = 1 : AllCardsCount = 4
            Case 2
                TurPic.Visible = True : TurPic.Image = My.Resources.дуэт
                FirstRightMove = 2 : RightToMove = 2 : RightOfBid = 2
                NumberOfCards = 2 : AllCardsCount = 8
            Case 3
                TurPic.Visible = True : TurPic.Image = My.Resources.трио
                FirstRightMove = 3 : RightToMove = 3 : RightOfBid = 3
                NumberOfCards = 3 : AllCardsCount = 12
            Case 4
                TurPic.Visible = True : TurPic.Image = My.Resources.Квадрат
                FirstRightMove = 4 : RightToMove = 4 : RightOfBid = 4
                NumberOfCards = 4 : AllCardsCount = 16
            Case 5
                TurPic.Visible = True : TurPic.Image = My.Resources.Пентет
                FirstRightMove = 1 : RightToMove = 1 : RightOfBid = 1
                NumberOfCards = 5 : AllCardsCount = 20
            Case 6
                TurPic.Visible = True : TurPic.Image = My.Resources.Бескозырка
                FirstRightMove = 2 : RightToMove = 2 : RightOfBid = 2
                NumberOfCards = 6 : AllCardsCount = 24
            Case 7
                TurPic.Visible = True : TurPic.Image = My.Resources.Бескозырка
                FirstRightMove = 3 : RightToMove = 3 : RightOfBid = 3
                NumberOfCards = 6 : AllCardsCount = 24
            Case 8
                TurPic.Visible = True : TurPic.Image = My.Resources.Бескозырка
                FirstRightMove = 4 : RightToMove = 4 : RightOfBid = 4
                NumberOfCards = 6 : AllCardsCount = 24
            Case 9
                TurPic.Visible = True : TurPic.Image = My.Resources.Бескозырка
                FirstRightMove = 1 : RightToMove = 1 : RightOfBid = 1
                NumberOfCards = 6 : AllCardsCount = 24
            Case 10
                TurPic.Visible = True : TurPic.Image = My.Resources.Бескозырка
                FirstRightMove = 2 : RightToMove = 2 : RightOfBid = 2
                NumberOfCards = 6 : AllCardsCount = 24
            Case 11
                TurPic.Visible = True : TurPic.Image = My.Resources.Бескозырка
                FirstRightMove = 3 : RightToMove = 3 : RightOfBid = 3
                NumberOfCards = 6 : AllCardsCount = 24
            Case 12
                'Подготовить после бескозырки
                StavkaPic.Visible = True : StavkaPic2.Visible = False : StavkaPic3.Visible = False
                StavkaPic4.Visible = False

                TurPic.Visible = True : TurPic.Image = My.Resources.Пентет
                FirstRightMove = 4 : RightToMove = 4 : RightOfBid = 4
                NumberOfCards = 5 : AllCardsCount = 20
            Case 13
                TurPic.Visible = True : TurPic.Image = My.Resources.Квадрат
                FirstRightMove = 1 : RightToMove = 1 : RightOfBid = 1
                NumberOfCards = 4 : AllCardsCount = 16
            Case 14
                TurPic.Visible = True : TurPic.Image = My.Resources.трио
                FirstRightMove = 2 : RightToMove = 2 : RightOfBid = 2
                NumberOfCards = 3 : AllCardsCount = 12
            Case 15
                TurPic.Visible = True : TurPic.Image = My.Resources.дуэт
                FirstRightMove = 3 : RightToMove = 3 : RightOfBid = 3
                NumberOfCards = 2 : AllCardsCount = 8
            Case 16
                TurPic.Visible = True : TurPic.Image = My.Resources.Соло
                FirstRightMove = 4 : RightToMove = 4 : RightOfBid = 4
                NumberOfCards = 1 : AllCardsCount = 4
            Case 17 'Лбы
                TurPic.Visible = True : TurPic.Image = My.Resources.Лбы
                FirstRightMove = 1 : RightToMove = 1 : RightOfBid = 1
                NumberOfCards = 1 : AllCardsCount = 4
            Case 18 'Лбы
                TurPic.Visible = True : TurPic.Image = My.Resources.Лбы
                FirstRightMove = 2 : RightToMove = 2 : RightOfBid = 2
                NumberOfCards = 1 : AllCardsCount = 4
            Case 19 'Лбы
                TurPic.Visible = True : TurPic.Image = My.Resources.Лбы
                FirstRightMove = 3 : RightToMove = 3 : RightOfBid = 3
                NumberOfCards = 1 : AllCardsCount = 4
            Case 20 'Обязаловка
                TurPic.Visible = True : TurPic.Image = My.Resources.Обязаловка
                FirstRightMove = 4 : RightToMove = 4 : RightOfBid = 4
                NumberOfCards = 5 : AllCardsCount = 20
                BidPlavers(1) = 1
                Bid = 1 'Проставить ставку принудительно
                StavkaPic.Image = My.Resources._1Б
            Case 21 'Обязаловка
                TurPic.Visible = True : TurPic.Image = My.Resources.Обязаловка
                FirstRightMove = 1 : RightToMove = 1 : RightOfBid = 1
                NumberOfCards = 5 : AllCardsCount = 20
                BidPlavers(1) = 1
                Bid = 1 'Проставить ставку принудительно
                StavkaPic.Image = My.Resources._1Б
            Case 22 'Обязаловка
                TurPic.Visible = True : TurPic.Image = My.Resources.Обязаловка
                FirstRightMove = 2 : RightToMove = 2 : RightOfBid = 2
                NumberOfCards = 5 : AllCardsCount = 20
                BidPlavers(1) = 1
                Bid = 1 'Проставить ставку принудительно
                StavkaPic.Image = My.Resources._1Б
            Case 23 'Темная
                StavkaPic.Enabled = True 'Разблокировать после обязаловки
                TurPic.Visible = True : TurPic.Image = My.Resources.Темная
                FirstRightMove = 3 : RightToMove = 3 : RightOfBid = 3
                NumberOfCards = 5 : AllCardsCount = 20
            Case 24 'Темная
                TurPic.Visible = True : TurPic.Image = My.Resources.Темная
                FirstRightMove = 4 : RightToMove = 4 : RightOfBid = 4
                NumberOfCards = 5 : AllCardsCount = 20
            Case 25 'Темная
                TurPic.Visible = True : TurPic.Image = My.Resources.Темная
                FirstRightMove = 1 : RightToMove = 1 : RightOfBid = 1
                NumberOfCards = 5 : AllCardsCount = 20
            Case 26 'Золотая
                TurPic.Visible = True : TurPic.Image = My.Resources.Золотая
                FirstRightMove = 2 : RightToMove = 2 : RightOfBid = 2
                NumberOfCards = 5 : AllCardsCount = 20
            Case 27 'Золотая
                TurPic.Visible = True : TurPic.Image = My.Resources.Золотая
                FirstRightMove = 3 : RightToMove = 3 : RightOfBid = 3
                NumberOfCards = 5 : AllCardsCount = 20
            Case 28 'Золотая
                TurPic.Visible = True : TurPic.Image = My.Resources.Золотая
                FirstRightMove = 4 : RightToMove = 4 : RightOfBid = 4
                NumberOfCards = 5 : AllCardsCount = 20
            Case 29
                Me.Hide()

                Form2.Show()
                Exit Sub
        End Select

        CardsInit()

        Kozirpict.Image = GetItem(Trump)
        Kozirpict.Visible = True


        'Убрать с колоды розданные карты
        For Card As Integer = 1 To AllCardsCount
            cb(37 - Card).Visible = False
        Next Card


        'Показ или сокрытие карт игрока и рубашек карт противника
        For Card As Integer = 1 To NumberOfCards
            If (Round >= 17 And Round <= 19) Then 'Лбы
                Igrok(Card).Image = My.Resources.Рубашка_Биг
                Igrok(Card).Visible = True
                prot1(Card).Image = GetItem(RndDeck(35))
                prot1(Card).Visible = True
                prot2(Card).Image = GetItem(RndDeck(34))
                prot2(Card).Visible = True
                prot3(Card).Image = GetItem(RndDeck(33))
                prot3(Card).Visible = True
            ElseIf (Round >= 23 And Round <= 25) Then 'Темная
                Igrok(Card).Image = My.Resources.Рубашка_Биг
                Igrok(Card).Visible = True
                prot1(Card).Image = My.Resources.Рубашка_Биг
                prot1(Card).Visible = True
                prot2(Card).Image = My.Resources.Рубашка_Биг
                prot2(Card).Visible = True
                prot3(Card).Image = My.Resources.Рубашка_Биг
                prot3(Card).Visible = True
            Else 'В других раундах
                Igrok(Card).Image = GetItem(CardsPlavers(1, Card))
                Igrok(Card).Visible = True
                prot1(Card).Image = My.Resources.Рубашка_Биг
                prot1(Card).Visible = True
                prot2(Card).Image = My.Resources.Рубашка_Биг
                prot2(Card).Visible = True
                prot3(Card).Image = My.Resources.Рубашка_Биг
                prot3(Card).Visible = True
            End If
        Next Card

        If ShowDebag = True Then

            For Card As Integer = 1 To NumberOfCards
                'Показ карт(полное у всех)
                prot1(Card).Image = GetItem(CardsPlavers(2, Card))
                prot1(Card).Visible = True
                prot2(Card).Image = GetItem(CardsPlavers(3, Card))
                prot2(Card).Visible = True
                prot3(Card).Image = GetItem(CardsPlavers(4, Card))
                prot3(Card).Visible = True
            Next Card

        End If

    End Sub

    Sub InformAboutPoker()
        'Проверка когда покер в козырях
        If Trump = 24 Then
            If Sound Then
                SoundBezKoz.PlaySync()
            Else
                MsgBox("Бескозырный режим")
            End If
        End If
        'Оповестить игрока о наличии покера у него на руках(кроме темной и в лбах)
        If Not (Round = 17 Or Round = 18 Or Round = 19 Or Round = 23 Or Round = 24 Or Round = 25) Then
            For ii = 1 To NumberOfCards
                If CardsPlavers(1, ii) = 24 Then
                    If Sound Then
                        SoundPokHave.PlaySync()
                    Else
                        MsgBox("У вас покер!")
                    End If
                End If
            Next ii
        End If

    End Sub



    Sub TrumpCheck()
        'Проверка игроков на козырную карту если есть то +100 к карте
        If Not (Trump = 24) And Not (NumberOfCards = 6) Then 'Обход при козырном покере(бескозырка) и в бескозырке
            For aa = 1 To 9
                For Card = 1 To NumberOfCards
                    For plaver = 1 To 4
                        If Not CardsPlavers(plaver, Card) = 24 Then 'Не прибавлять +100 к вальту если масть будет бубны
                            If StartArray(aa, GetTrumpColumn) = CardsPlavers(plaver, Card) Then
                                CardsPlaversPow(plaver, Card) = CardsPlaversPow(plaver, Card) + 100
                            End If
                        End If
                    Next plaver
                Next Card
            Next aa
        End If
    End Sub

    Sub Normalization()
        'Фильтр нормализации значений карт
        Dim Znach As Integer
        For Card As Integer = 1 To NumberOfCards
            For Player = 1 To 4
                Znach = CardsPlaversPow(Player, Card)
                If Znach <= 4 Then CardsPlaversPow(Player, Card) = 6
                If Znach >= 5 And Znach <= 8 Then CardsPlaversPow(Player, Card) = 7
                If Znach >= 9 And Znach <= 12 Then CardsPlaversPow(Player, Card) = 8
                If Znach >= 13 And Znach <= 16 Then CardsPlaversPow(Player, Card) = 9
                If Znach >= 17 And Znach <= 20 Then CardsPlaversPow(Player, Card) = 10
                If Znach >= 21 And Znach <= 23 Then CardsPlaversPow(Player, Card) = 11
                If Znach >= 25 And Znach <= 28 Then CardsPlaversPow(Player, Card) = 12
                If Znach >= 29 And Znach <= 32 Then CardsPlaversPow(Player, Card) = 13
                If Znach >= 33 And Znach <= 36 Then CardsPlaversPow(Player, Card) = 14

                If Znach = 24 Then CardsPlaversPow(Player, Card) = 200 'Это значение козырного вальта бубен и его же с правом хода
            Next Player
        Next Card

    End Sub
    Sub CalcWiner() 'Расчет очков всех игроков
        'Скрыть картинку права руки(хода) и имена
        PicPlaverName.Visible = False
        PicPravo1.Visible = False : PicPravo2.Visible = False
        PicPravo3.Visible = False : PicPravo4.Visible = False

        CalcZdvig()
        'Расчет взяток  1 игрока
        If CardsPlaversTablePow(1) > CardsPlaversTablePow(2) And CardsPlaversTablePow(1) > CardsPlaversTablePow(3) And
            CardsPlaversTablePow(1) > CardsPlaversTablePow(4) Then
            PlaversScores(1, Round) = PlaversScores(1, Round) + 1
            PlaversVzatShow()
        End If
        MSEAinfo = MSEAinfo & Bid & PlaversScores(1, Round)
        'Расчет взяток  2 игрока
        If CardsPlaversTablePow(2) > CardsPlaversTablePow(1) And CardsPlaversTablePow(2) > CardsPlaversTablePow(3) And
        CardsPlaversTablePow(2) > CardsPlaversTablePow(4) Then
            PlaversScores(2, Round) = PlaversScores(2, Round) + 1
            PlaversVzatShow()
        End If
        'Расчет взяток 3 игрока
        If CardsPlaversTablePow(3) > CardsPlaversTablePow(1) And CardsPlaversTablePow(3) > CardsPlaversTablePow(2) And
        CardsPlaversTablePow(3) > CardsPlaversTablePow(4) Then
            PlaversScores(3, Round) = PlaversScores(3, Round) + 1
            PlaversVzatShow()
        End If
        'Расчет взяток  4 игрока
        If CardsPlaversTablePow(4) > CardsPlaversTablePow(1) And CardsPlaversTablePow(4) > CardsPlaversTablePow(2) And
        CardsPlaversTablePow(4) > CardsPlaversTablePow(3) Then
            PlaversScores(4, Round) = PlaversScores(4, Round) + 1
            PlaversVzatShow()
        End If

        'Расчет очков в бескозырке(сколько взяли-стоко и дали) и выход из подпрограммы
        If Round >= 6 And Round <= 11 Then
            For pls As Integer = 1 To 4
                If PlaversScores(pls, Round) = 0 Then
                    PlaversScores(pls, Round) = 0
                End If
                If PlaversScores(pls, Round) > 0 Then
                    PlaversScores(pls, Round) = PlaversScores(pls, Round) * 10
                    'Проверка на шлем 6 карт(максимальное набранное число взяток из возможных)
                    If PlaversScores(pls, Round) = 60 Then
                        PlaversScores(pls, Round) = PlaversScores(pls, Round) + 60
                        'Показать шлем у 1 игрока
                        If pls = 1 Then
                            BonusPic.Visible = True : BonusPic.Image = My.Resources._6_шлем
                            If Sound Then
                                My.Computer.Audio.Play(My.Resources.супер_шлем, AudioPlayMode.WaitToComplete)
                            Else
                                MsgBox("Супер шлем!", MsgBoxStyle.OkOnly, "Поздравляем")
                            End If
                        End If
                    End If
                End If
            Next pls
            Exit Sub
        End If
        'Расчет очков
        For pls As Integer = 1 To 4
            If PlaversScores(pls, Round) > BidPlavers(pls) Then PlaversScores(pls, Round) = PlaversScores(pls, Round)
            If PlaversScores(pls, Round) = BidPlavers(pls) Then
                If PlaversScores(pls, Round) = 0 And BidPlavers(pls) = 0 Then PlaversScores(pls, Round) = 5
                If BidPlavers(pls) > 0 Then
                    PlaversScores(pls, Round) = BidPlavers(pls) * 10
                    'Проверка на шлем(максимальное набранное число взяток из возможных)
                    If BidPlavers(pls) = NumberOfCards Then
                        Select Case NumberOfCards
                            'Case 1 Заблокировал 1 шлем из за неэффективности
                            '    PlaversVzatKoll(pls, Tur) = PlaversVzatKoll(pls, Tur) + 10
                            '    If pls = 1 Then
                            '        BonusPic.Visible = True : BonusPic.Image = My.Resources._1_шлем
                            '        If Sound Then
                            '            SoundShlem1.PlaySync()
                            '        Else
                            '            MsgBox("Начальный шлем!", MsgBoxStyle.OkOnly, "Поздравляем")
                            '        End If
                            '    End If
                            Case 2
                                PlaversScores(pls, Round) = PlaversScores(pls, Round) + 20
                                If pls = 1 Then
                                    BonusPic.Visible = True : BonusPic.Image = My.Resources._2_шлем

                                    If Sound Then
                                        SoundShlem2.PlaySync()
                                    Else
                                        MsgBox("Двойной шлем!", MsgBoxStyle.OkOnly, "Поздравляем")
                                    End If
                                End If
                            Case 3
                                PlaversScores(pls, Round) = PlaversScores(pls, Round) + 30
                                If pls = 1 Then
                                    BonusPic.Visible = True : BonusPic.Image = My.Resources._3_шлем
                                    If Sound Then
                                        SoundShlem3.PlaySync()
                                    Else
                                        MsgBox("Тройной шлем!", MsgBoxStyle.OkOnly, "Поздравляем")
                                    End If
                                End If
                            Case 4
                                PlaversScores(pls, Round) = PlaversScores(pls, Round) + 40
                                If pls = 1 Then
                                    BonusPic.Visible = True : BonusPic.Image = My.Resources._4_шлем
                                    If Sound Then
                                        SoundShlem4.PlaySync()
                                    Else
                                        MsgBox("Шлем каре!", MsgBoxStyle.OkOnly, "Поздравляем")
                                    End If
                                End If
                            Case 5
                                PlaversScores(pls, Round) = PlaversScores(pls, Round) + 50
                                If pls = 1 Then
                                    BonusPic.Visible = True : BonusPic.Image = My.Resources._5_шлем
                                    If Sound Then
                                        SoundShlem5.PlaySync()
                                    Else
                                        MsgBox("Шлем на пяти!", MsgBoxStyle.OkOnly, "Поздравляем")
                                    End If
                                End If
                            Case 6
                                PlaversScores(pls, Round) = PlaversScores(pls, Round) + 60
                                If pls = 1 Then
                                    BonusPic.Visible = True : BonusPic.Image = My.Resources._6_шлем
                                    If Sound Then
                                        SoundShlem6.PlaySync()
                                    Else
                                        MsgBox("Супер шлем!", MsgBoxStyle.OkOnly, "Поздравляем")
                                    End If
                                End If
                        End Select
                    End If
                End If
            End If

            If PlaversScores(pls, Round) = 0 And BidPlavers(pls) = 1 Then PlaversScores(pls, Round) = -10
            If PlaversScores(pls, Round) < BidPlavers(pls) Then PlaversScores(pls, Round) = BidPlavers(pls) * -10
        Next pls
        'Расчет очков в темной(x2)
        If Round = 23 Or Round = 24 Or Round = 25 Then
            For pls As Integer = 1 To 4
                PlaversScores(pls, Round) = PlaversScores(pls, Round) * 2
            Next pls
        End If
        'Расчет очков в золотой(x3)
        If Round = 26 Or Round = 27 Or Round = 28 Then
            For pls As Integer = 1 To 4
                PlaversScores(pls, Round) = PlaversScores(pls, Round) * 3
            Next pls
        End If
    End Sub
    Sub CardsInit()
        'Присвоение значений карт и начальной ценности 
        Dim decrement As Integer
        For player As Integer = 1 To 4
            For playercard As Integer = 1 To NumberOfCards
                decrement = decrement + 1
                CardsPlavers(player, playercard) = RndDeck(37 - decrement)
                CardsPlaversPow(player, playercard) = CardsPlavers(player, playercard)
            Next playercard
        Next player
        If Not (Trump = 24 Or (Round >= 6 And Round <= 11)) Then 'пропуск в бескозырке
            'Присвоение козыря 
            Trump = RndDeck(36 - AllCardsCount)
        End If
    End Sub
    Sub StolKardsVis()
        For fgh2 As Integer = 1 To 6
            CardsTable(fgh2).Visible = False
        Next
    End Sub

    Sub BrainCalcMove()
        'Искуственный интелект на выбор ходов
        Dim proxodd As Boolean = False
        Dim proxodd2 As Boolean = False
        Dim proxodd3 As Boolean = False
        Dim proxodd4 As Boolean = False
        Dim Gak As Integer
        Dim Bilo As Integer = 0
        Dim BiloKoz As Integer = 0
        Dim BiloMast As Integer = 0
        Dim Largest, Min As Integer
        'Детектор выхода из игры вальта козырного в бескозырке
        If Not (isTrampOver = True) Then
            If Round >= 6 And Round <= 11 Then
                For pl As Integer = 1 To 4
                    If CardsPlaversTablePow(pl) >= 200 Then
                        isTrampOver = True
                    End If
                Next pl
            End If

            'Проверка есть ли козырный валет у игрока с правом хода если да то скинуть
            If Round >= 6 And Round <= 11 Then
                For tt As Integer = 1 To NumberOfCards
                    If Not (SpentCards(RightToMove, tt) = 1) Then 'Если карта отработана то её не анализировать
                        If CardsPlavers(RightToMove, tt) = 24 Then
                            SelectedCard = tt
                            isTrampOver = True
                            CardsPlaversPow(RightToMove, SelectedCard) += 50
                            If Not (IsActiveCard = True) Then
                                ActiveCard = CardsPlavers(RightToMove, SelectedCard)
                            End If
                            CheckFull = CheckFull + 1
                            CardsPlaversTablePow(CheckFull) = CardsPlaversPow(RightToMove, SelectedCard)
                            SpentCards(RightToMove, SelectedCard) = 1
                            IsActiveCard = True
                            'Проигрыш звука при вальте бубей
                            If ActiveCard = 24 Then
                                If Sound Then
                                    SoundSamMainCards.PlaySync()
                                End If
                            End If
                            Exit Sub
                        End If
                    End If
                Next
            End If
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''
        'Комп заходит с карты
        If IsActiveCard = False Then
            CheckFull = 1
            For gg As Integer = 1 To NumberOfCards
                If Not (SpentCards(RightToMove, gg) = 1) Then 'Если карта отработана то её не анализировать
                    Bilo = Bilo + 1
                    AnalizCards(Bilo) = gg 'Занесем анализируемые карты(для удобства)
                End If
            Next gg
            'Выбрать наибольшую по ценности карту если козырный валет вышел
            If isTrampOver = True Then
                Select Case Bilo
                    Case 1 'Когда 1 карта
                        SelectedCard = AnalizCards(Bilo)
                    Case 2 'Когда 2 карты
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) > CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                            SelectedCard = AnalizCards(1)
                        Else
                            SelectedCard = AnalizCards(2)
                        End If
                        'Реакция на одинаковые по ценности
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                            SelectedCard = AnalizCards(Int((2 * Rnd()) + 1))
                        End If
                    Case 3 'Когда 3 карты
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            SelectedCard = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            SelectedCard = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                            SelectedCard = AnalizCards(3)
                        End If
                        'Реакция на одинаковые по ценности
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            SelectedCard = AnalizCards(Int((3 * Rnd()) + 1))
                        End If
                    Case 4 'Когда 4 карты
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            SelectedCard = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            SelectedCard = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            SelectedCard = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            SelectedCard = AnalizCards(4)
                        End If
                        'Реакция на одинаковые по ценности
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            SelectedCard = AnalizCards(Int((4 * Rnd()) + 1))
                        End If
                    Case 5 'Когда 5 карт
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            SelectedCard = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            SelectedCard = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            SelectedCard = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            SelectedCard = AnalizCards(4)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            SelectedCard = AnalizCards(5)
                        End If
                    Case 6 'Когда 6 карт
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            SelectedCard = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            SelectedCard = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            SelectedCard = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            SelectedCard = AnalizCards(4)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            SelectedCard = AnalizCards(5)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            SelectedCard = AnalizCards(6)
                        End If
                End Select
                'Выбрать наименьшую по ценности карту если козырный валет еще есть у кого-то
            Else
                Select Case Bilo
                    Case 1 'Когда 1 карта
                        SelectedCard = AnalizCards(Bilo)
                    Case 2
                        'Выбрать наименьшую по ценности карту
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                            SelectedCard = AnalizCards(2)
                        Else
                            SelectedCard = AnalizCards(1)
                        End If
                    Case 3
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                            CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            SelectedCard = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                            CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            SelectedCard = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                            SelectedCard = AnalizCards(3)
                        End If
                    Case 4
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            SelectedCard = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            SelectedCard = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            SelectedCard = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            SelectedCard = AnalizCards(4)
                        End If
                    Case 5
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            SelectedCard = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            SelectedCard = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            SelectedCard = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            SelectedCard = AnalizCards(4)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            SelectedCard = AnalizCards(5)
                        End If
                    Case 6
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                        CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                        CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                        CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                        CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            SelectedCard = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            SelectedCard = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            SelectedCard = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            SelectedCard = AnalizCards(4)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            SelectedCard = AnalizCards(5)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            SelectedCard = AnalizCards(6)
                        End If
                End Select
            End If
            CardsPlaversPow(RightToMove, SelectedCard) += 50
            ActiveCard = CardsPlavers(RightToMove, SelectedCard)
            CardsPlaversTablePow(CheckFull) = CardsPlaversPow(RightToMove, SelectedCard)
            SpentCards(RightToMove, SelectedCard) = 1
            IsActiveCard = True
            If RightToMove = 5 Then
                RightToMove = 1
                PutCardselector.Stop()
            End If
            'Проигрыш звука при вальте бубей
            If ActiveCard = 24 Then
                If Sound Then
                    SoundSamMainCardsAnd.PlaySync()
                End If
            End If
        Else 'Ответная реакция
            CheckFull = CheckFull + 1 'следующая позиция массива CardsPlaversStolPow
            If CheckFull = 5 Then
                CheckFull = 1
            End If
            'Блок текуших карт
            For gg As Integer = 1 To NumberOfCards
                If Not (SpentCards(RightToMove, gg) = 1) Then 'Если карта отработана то её не анализировать
                    Bilo = Bilo + 1
                    AnalizCards(Bilo) = gg 'Занесем анализируемые карты(для удобства)
                End If
            Next gg
            'Походить если осталась последняя
            If Bilo = 1 Then
                SelectedCard = AnalizCards(Bilo)
                'Эта карта совпадает с рядом активной?если да то +50 к карте
                Gak = GetActiveCardColumn()
                For aa As Integer = 1 To 9
                    If CardsPlavers(RightToMove, SelectedCard) = StartArray(aa, Gak) Then
                        CardsPlaversPow(RightToMove, SelectedCard) += 50
                        Exit For
                    End If
                Next aa
                CardsPlaversTablePow(CheckFull) = CardsPlaversPow(RightToMove, SelectedCard)
                SpentCards(RightToMove, SelectedCard) = 1
                Exit Sub
            End If
            'В любом случае скинуть вальта бубей если таковой имеется
            For tt As Integer = 1 To NumberOfCards
                If Not (SpentCards(RightToMove, tt) = 1) Then 'Если карта отработана то её не анализировать
                    If CardsPlavers(RightToMove, tt) = 24 Then
                        SelectedCard = tt
                        CardsPlaversTablePow(CheckFull) = CardsPlaversPow(RightToMove, SelectedCard)
                        SpentCards(RightToMove, SelectedCard) = 1
                        Exit Sub
                    End If
                End If
            Next

            'Реакция если на столе бубновый валет
            If ActiveCard = 24 Then
                Select Case Bilo
                    Case 2 'Когда 2 карты
                        'Узнаем наибольшию карту
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) > CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                            Largest = AnalizCards(1)
                        Else
                            Largest = AnalizCards(2)
                        End If
                        SelectedCard = Largest
                        'Реакция на одинаковые по ценности
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                            SelectedCard = AnalizCards(Int((2 * Rnd()) + 1))
                        End If
                    Case 3 'Когда 3 карты
                        'Узнаем наибольшию карту
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                       CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            Largest = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            Largest = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                            Largest = AnalizCards(3)
                        End If
                        'Реакция на одинаковые по ценности
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            Largest = AnalizCards(Int((3 * Rnd()) + 1))
                        End If
                        SelectedCard = Largest
                    Case 4 'Когда 4 карты
                        'Узнаем наибольшию карту
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                    CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                    CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            Largest = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            Largest = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            Largest = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            Largest = AnalizCards(4)
                        End If
                        'Реакция на одинаковые по ценности
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            Largest = AnalizCards(Int((4 * Rnd()) + 1))
                        End If
                        SelectedCard = Largest
                    Case 5
                        'Узнаем наибольшию карту
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                  CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                  CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                  CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            Largest = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            Largest = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            Largest = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            Largest = AnalizCards(4)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            Largest = AnalizCards(5)
                        End If
                        SelectedCard = Largest
                    Case 6
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            Largest = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            Largest = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            Largest = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            Largest = AnalizCards(4)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            Largest = AnalizCards(5)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            Largest = AnalizCards(6)
                        End If
                        SelectedCard = Largest
                End Select
                CardsPlaversTablePow(CheckFull) = CardsPlaversPow(RightToMove, SelectedCard)
                SpentCards(RightToMove, SelectedCard) = 1
                Exit Sub
            Else 'Реакция при других обстоятельствах
                '' 'Здесь проверка на совпададения карт или карты с мастью активной карты(произвести оптимальный выбор)
                'Если имеется карта совпадающая с рядом активной то не дать ходить кроме её(их)
                Gak = GetActiveCardColumn()
                For gg As Integer = 1 To NumberOfCards
                    If Not (SpentCards(RightToMove, gg) = 1) Then 'Если карта отработана то её не анализировать
                        For aa As Integer = 1 To 9
                            If CardsPlavers(RightToMove, gg) = StartArray(aa, Gak) Then
                                proxodd = True 'Подтверждение события совпадения
                                BiloMast = BiloMast + 1
                                AnalizCards(BiloMast) = gg 'Занесем анализируемые карты(для удобства)
                            End If
                        Next aa
                    End If
                Next gg
                If proxodd = True Then
                    'Если выбранная карта находится в том же ряду что и активная то разршить ход и добавить +50 к ценности
                    Select Case BiloMast
                        Case 1
                            SelectedCard = AnalizCards(BiloMast)
                        Case 2
                            'Если 2 карты совпадают с мастью активной то вычислим наибольшию
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) > CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                Largest = AnalizCards(1)
                            Else
                                Largest = AnalizCards(2)
                            End If
                            For jk As Integer = 1 To CheckFull
                                If CardsPlaversTablePow(jk) > CardsPlaversPow(RightToMove, Largest) + 50 Or isTrampOver = False And Not CheckFull = 4 Then 'Если ходит последний игрок и берет всю взятку то он игнорит то что валет еще не вышел
                                    proxodd2 = True ''Если есть хоть одна карта на столе которая бьет наибольшию карту игрока?
                                    Exit For
                                End If
                            Next
                            If proxodd2 = True Then
                                'Выбрать наименьшую по ценности карту
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) > CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                    SelectedCard = AnalizCards(2)
                                Else
                                    SelectedCard = AnalizCards(1)
                                End If
                            Else
                                'Выбрать наибольшую по ценности карту
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) > CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                    SelectedCard = AnalizCards(1)
                                Else
                                    SelectedCard = AnalizCards(2)
                                End If
                            End If
                        Case 3
                            'Если 3 карты совпадают то вычислим наибольшию
                            'Узнаем наибольшию карту
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                Largest = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                Largest = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                Largest = AnalizCards(3)
                            End If
                            'Реакция на одинаковые по ценности
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                Largest = AnalizCards(Int((3 * Rnd()) + 1))
                            End If
                            For jk As Integer = 1 To CheckFull
                                If CardsPlaversTablePow(jk) > CardsPlaversPow(RightToMove, Largest) + 50 Or isTrampOver = False And Not CheckFull = 4 Then 'Если ходит последний игрок и берет всю взятку то он игнорит то что валет еще не вышелThen
                                    proxodd2 = True ''Если есть хоть одна карта на столе которая бьет наибольшию карту игрока?
                                    Exit For
                                End If
                            Next
                            If proxodd2 = True Then
                                'Выбрать наименьшую по ценности карту
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                 CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                    Min = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                    Min = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                    Min = AnalizCards(3)
                                End If
                                'Реакция на одинаковые по ценности
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                    Min = AnalizCards(Int((3 * Rnd()) + 1))
                                End If
                                SelectedCard = Min
                            Else
                                'Наибольшую в др случае
                                SelectedCard = Largest
                            End If
                        Case 4
                            'Если 4 карты совпадают то вычислим наибольшию
                            'Узнаем наибольшию карту
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                Largest = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                Largest = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                Largest = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                Largest = AnalizCards(4)
                            End If
                            'Реакция на одинаковые по ценности
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                Largest = AnalizCards(Int((4 * Rnd()) + 1))
                            End If
                            For jk As Integer = 1 To CheckFull
                                If CardsPlaversTablePow(jk) > CardsPlaversPow(RightToMove, Largest) + 50 Or isTrampOver = False And Not CheckFull = 4 Then 'Если ходит последний игрок и берет всю взятку то он игнорит то что валет еще не вышел 
                                    proxodd2 = True ''Если есть хоть одна карта на столе которая бьет наибольшию карту игрока?
                                    Exit For
                                End If
                            Next
                            If proxodd2 = True Then
                                'Выбрать наименьшую по ценности карту
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                            CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                            CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    Min = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    Min = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    Min = AnalizCards(3)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                    Min = AnalizCards(4)
                                End If
                                'Реакция на одинаковые по ценности
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) = CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    Min = AnalizCards(Int((4 * Rnd()) + 1))
                                End If
                                SelectedCard = Min
                            Else
                                SelectedCard = Largest
                            End If
                        Case 5
                            'Если 5 карты совпадают то вычислим наибольшию
                            'Узнаем наибольшию карту
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                Largest = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                Largest = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                Largest = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                Largest = AnalizCards(4)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                Largest = AnalizCards(5)
                            End If
                            For jk As Integer = 1 To CheckFull
                                If CardsPlaversTablePow(jk) > CardsPlaversPow(RightToMove, Largest) + 50 Or isTrampOver = False And Not CheckFull = 4 Then 'Если ходит последний игрок и берет всю взятку то он игнорит то что валет еще не вышел
                                    proxodd2 = True ''Если есть хоть одна карта на столе которая бьет наибольшию карту игрока?
                                    Exit For
                                End If
                            Next
                            If proxodd2 = True Then
                                'Выбрать наименьшую по ценности карту
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                          CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                          CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                          CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    Min = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    Min = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    Min = AnalizCards(3)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    Min = AnalizCards(4)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    Min = AnalizCards(5)
                                End If
                                SelectedCard = Min
                            Else
                                'Наибольшую в др случае
                                SelectedCard = Largest
                            End If
                        Case 6
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                Largest = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                Largest = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                Largest = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                Largest = AnalizCards(4)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                Largest = AnalizCards(5)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                Largest = AnalizCards(6)
                            End If
                            For jk As Integer = 1 To CheckFull
                                If CardsPlaversTablePow(jk) > CardsPlaversPow(RightToMove, Largest) + 50 Or isTrampOver = False And Not CheckFull = 4 Then 'Если ходит последний игрок и берет всю взятку то он игнорит то что валет еще не вышел
                                    proxodd2 = True ''Если есть хоть одна карта на столе которая бьет наибольшию карту игрока?
                                    Exit For
                                End If
                            Next
                            If proxodd2 = True Then
                                'Выбрать наименьшую по ценности карту
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    Min = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    Min = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    Min = AnalizCards(3)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    Min = AnalizCards(4)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    Min = AnalizCards(5)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    Min = AnalizCards(6)
                                End If
                                SelectedCard = Min
                            Else
                                'Наибольшую в др случае
                                SelectedCard = Largest
                            End If
                    End Select
                    CardsPlaversPow(RightToMove, SelectedCard) += 50
                    CardsPlaversTablePow(CheckFull) = CardsPlaversPow(RightToMove, SelectedCard)
                    SpentCards(RightToMove, SelectedCard) = 1
                    Exit Sub
                End If
                ''''Выбор хода если есть козыря на руках!!!!тут
                For gg As Integer = 1 To NumberOfCards
                    If Not (SpentCards(RightToMove, gg) = 1) Then 'Если карта отработана то её не анализировать
                        If CardsPlaversPow(RightToMove, gg) > 100 Then
                            proxodd4 = True 'Подтверждение события совпадения
                            BiloKoz = BiloKoz + 1
                            AnalizCardsKoz(BiloKoz) = gg 'Занесем анализируемые карты(для удобства)
                        End If
                    End If
                Next gg
                ' '' ''Занесем оставшиеся номера карт(для удобства)
                ' '' ''Блок текуших карт
                '' ''For gg As Integer = 1 To kollcards
                '' ''    If Not (Otrabotka(PravoXoda, gg) = 1) Then 'Если карта отработана то её не анализировать
                '' ''        Bilo = Bilo + 1
                '' ''        AnalizCards(Bilo) = gg 'Занесем анализируемые карты(для удобства)
                '' ''    End If
                '' ''Next gg

                'Узнаем козырей
                If proxodd4 = True Then
                    Select Case BiloKoz
                        Case 1 'Выбор хода когда на руках 1 козырь
                            'Узнаем козыря
                            Largest = AnalizCardsKoz(1)
                        Case 2 'Выбор хода когда на руках 2 козыря
                            'Узнаем старшего козыря
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) > CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                Largest = AnalizCards(1)
                            Else
                                Largest = AnalizCards(2)
                            End If
                        Case 3
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                Largest = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                Largest = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                Largest = AnalizCards(3)
                            End If
                        Case 4
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                Largest = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                Largest = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                Largest = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                Largest = AnalizCards(4)
                            End If
                        Case 5
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                Largest = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                Largest = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                Largest = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                Largest = AnalizCards(4)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                Largest = AnalizCards(5)
                            End If
                        Case 6
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                Largest = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                Largest = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                Largest = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                Largest = AnalizCards(4)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                Largest = AnalizCards(5)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                Largest = AnalizCards(6)
                            End If
                    End Select

                    For jk As Integer = 1 To CheckFull
                        If CardsPlaversTablePow(jk) > CardsPlaversPow(RightToMove, Largest) Then
                            proxodd3 = True ''Если есть хоть одна карта на столе которая бьет козыря игрока?
                            Exit For
                        End If
                    Next

                    If proxodd3 = True Then
                        'Выбрать наименьшую по ценности карту(учитывая сколько карт всего осталось)
                        Select Case Bilo
                            Case 2
                                'Выбрать наименьшую по ценности карту
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                    SelectedCard = AnalizCards(2)
                                Else
                                    SelectedCard = AnalizCards(1)
                                End If
                            Case 3
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                    CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                    SelectedCard = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                    CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                    SelectedCard = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                    SelectedCard = AnalizCards(3)
                                End If
                            Case 4
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    SelectedCard = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    SelectedCard = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    SelectedCard = AnalizCards(3)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                    SelectedCard = AnalizCards(4)
                                End If
                            Case 5
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    SelectedCard = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    SelectedCard = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    SelectedCard = AnalizCards(3)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    SelectedCard = AnalizCards(4)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    SelectedCard = AnalizCards(5)
                                End If
                            Case 6
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    SelectedCard = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    SelectedCard = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    SelectedCard = AnalizCards(3)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    SelectedCard = AnalizCards(4)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    SelectedCard = AnalizCards(5)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    SelectedCard = AnalizCards(6)
                                End If
                        End Select
                    Else
                        'Выбрать наибольшую по ценности карту! Можно потом попробывать просто вставить Naibol(оптимизация)
                        Select Case Bilo
                            Case 2
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                    SelectedCard = AnalizCards(1)
                                Else
                                    SelectedCard = AnalizCards(2)
                                End If
                            Case 3
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                    SelectedCard = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                    SelectedCard = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                    SelectedCard = AnalizCards(3)
                                End If
                            Case 4
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                          CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                          CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    SelectedCard = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    SelectedCard = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    SelectedCard = AnalizCards(3)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                    SelectedCard = AnalizCards(4)
                                End If
                            Case 5
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    SelectedCard = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    SelectedCard = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    SelectedCard = AnalizCards(3)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    SelectedCard = AnalizCards(4)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                    SelectedCard = AnalizCards(5)
                                End If
                            Case 6
                                If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    SelectedCard = AnalizCards(1)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    SelectedCard = AnalizCards(2)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    SelectedCard = AnalizCards(3)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    SelectedCard = AnalizCards(4)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                    SelectedCard = AnalizCards(5)
                                End If
                                If CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                                   CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                    SelectedCard = AnalizCards(6)
                                End If
                        End Select
                    End If
                    CardsPlaversTablePow(CheckFull) = CardsPlaversPow(RightToMove, SelectedCard)
                    SpentCards(RightToMove, SelectedCard) = 1
                    Exit Sub
                End If

                'Реакция на ситуации отличные от вышеперечисленных
                'Узнаем старшию карту(относительно сколько карт осталось)

                Select Case Bilo
                    Case 2
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) > CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                            Largest = AnalizCards(1)
                        Else
                            Largest = AnalizCards(2)
                        End If
                    Case 3
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            Largest = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            Largest = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                            Largest = AnalizCards(3)
                        End If
                    Case 4
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                  CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                  CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            Largest = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            Largest = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            Largest = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                            Largest = AnalizCards(4)
                        End If
                    Case 5
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            Largest = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            Largest = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            Largest = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            Largest = AnalizCards(4)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                            Largest = AnalizCards(5)
                        End If
                    Case 6
                        If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            Largest = AnalizCards(1)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            Largest = AnalizCards(2)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            Largest = AnalizCards(3)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                           CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            Largest = AnalizCards(4)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                            Largest = AnalizCards(5)
                        End If
                        If CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                           CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                            Largest = AnalizCards(6)
                        End If
                End Select

                For jk As Integer = 1 To CheckFull
                    If CardsPlaversTablePow(jk) > CardsPlaversPow(RightToMove, Largest) Then
                        proxodd3 = True ''Если есть хоть одна карта на столе которая бьет наибольшию карту игрока?
                        Exit For
                    End If
                Next
                If proxodd3 = True Then
                    'Выбрать наименьшую по ценности карту(учитывая сколько карт всего осталось)
                    Select Case Bilo
                        Case 2
                            'Выбрать наименьшую по ценности карту
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                SelectedCard = AnalizCards(2)
                            Else
                                SelectedCard = AnalizCards(1)
                            End If
                        Case 3
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                                CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                SelectedCard = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                                CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                SelectedCard = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                SelectedCard = AnalizCards(3)
                            End If
                        Case 4
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                SelectedCard = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                SelectedCard = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                SelectedCard = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                SelectedCard = AnalizCards(4)
                            End If
                        Case 5
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                SelectedCard = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                SelectedCard = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                SelectedCard = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                SelectedCard = AnalizCards(4)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                SelectedCard = AnalizCards(5)
                            End If
                        Case 6
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                            CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                            CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                            CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                            CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                SelectedCard = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                SelectedCard = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                SelectedCard = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                SelectedCard = AnalizCards(4)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) <= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                SelectedCard = AnalizCards(5)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) <= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                SelectedCard = AnalizCards(6)
                            End If
                    End Select
                Else
                    'Выбрать наибольшую по ценности карту! Можно потом попробывать просто вставить Naibol(оптимизация)
                    Select Case Bilo
                        Case 2
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                SelectedCard = AnalizCards(1)
                            Else
                                SelectedCard = AnalizCards(2)
                            End If
                        Case 3
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                SelectedCard = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                SelectedCard = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) Then
                                SelectedCard = AnalizCards(3)
                            End If
                        Case 4
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                      CardsPlaversPow(RightToMove, AnalizCards(1)) <= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                SelectedCard = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                SelectedCard = AnalizCards(2)
                            End If

                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                SelectedCard = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) Then
                                SelectedCard = AnalizCards(4)
                            End If
                        Case 5
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                SelectedCard = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                SelectedCard = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                SelectedCard = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                SelectedCard = AnalizCards(4)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) Then
                                SelectedCard = AnalizCards(5)
                            End If
                        Case 6
                            If CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(1)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                SelectedCard = AnalizCards(1)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(2)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                SelectedCard = AnalizCards(2)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(3)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                SelectedCard = AnalizCards(3)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) And
                               CardsPlaversPow(RightToMove, AnalizCards(4)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                SelectedCard = AnalizCards(4)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(5)) >= CardsPlaversPow(RightToMove, AnalizCards(6)) Then
                                SelectedCard = AnalizCards(5)
                            End If
                            If CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(1)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(2)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(3)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(4)) And
                               CardsPlaversPow(RightToMove, AnalizCards(6)) >= CardsPlaversPow(RightToMove, AnalizCards(5)) Then
                                SelectedCard = AnalizCards(6)
                            End If
                    End Select
                End If
                CardsPlaversTablePow(CheckFull) = CardsPlaversPow(RightToMove, SelectedCard)
                SpentCards(RightToMove, SelectedCard) = 1
            End If
        End If
    End Sub
    Sub BrainCalcStavka()
        'Искуственный интелект на выбор ставки
        Dim powerCard As Integer
        'Не производить выбор ставки в бескозырке так как в ней сколько набереш взяток -столько и будет очков
        If Round >= 6 And Round <= 11 And isPlaverBid = True Then
            PutCardselector.Interval = SpeedRasclad
            PutCardselector.Start()
            Exit Sub
        End If
        If (Round > 5 And Round < 12) Then 'В туре бескозырка без задержек пройти по StavkaSelector
            StavkaSelector.Interval = 1
            StavkaSelector.Start()
            Exit Sub
        End If

        'Расчет в темной
        If Round = 23 Or Round = 24 Or Round = 25 Then
            For plp As Integer = 2 To 4
                BidPlavers(plp) = Int(2 * Rnd())
            Next
            'В селектор ставок
            StavkaSelector.Interval = SpeedStavka
            StavkaSelector.Start()
            Exit Sub
        End If

        'Расчет ставок в лбах
        If Round = 17 Or Round = 18 Or Round = 19 Then
            If CardsPlaversPow(1, 1) >= GetLowPower() Or CardsPlaversPow(3, 1) >= GetLowPower() Or CardsPlaversPow(4, 1) >= GetLowPower() Then
            Else
                BidPlavers(2) = BidPlavers(2) + 1
            End If
            If CardsPlaversPow(1, 1) >= GetLowPower() Or CardsPlaversPow(2, 1) >= GetLowPower() Or CardsPlaversPow(4, 1) >= GetLowPower() Then
            Else
                BidPlavers(3) = BidPlavers(3) + 1
            End If
            If CardsPlaversPow(1, 1) >= GetLowPower() Or CardsPlaversPow(2, 1) >= GetLowPower() Or CardsPlaversPow(3, 1) >= GetLowPower() Then
            Else
                BidPlavers(4) = BidPlavers(4) + 1
            End If


            'В селектор ставок
            StavkaSelector.Interval = SpeedStavka
            StavkaSelector.Start()
            Exit Sub
        End If

        For plaver As Integer = 2 To 4
            For gg As Integer = 1 To NumberOfCards
                powerCard = CardsPlaversPow(plaver, gg)

                If plaver = RightToMove Then
                    isRightOfFirst = True
                Else
                    isRightOfFirst = False
                End If

                If powerCard >= GetLowPower() Then
                    BidPlavers(plaver) = BidPlavers(plaver) + 1
                End If
            Next gg
        Next plaver
        'Не давать пасовать компу в обязаловке
        If Round = 20 Or Round = 21 Or Round = 22 Then
            For plp As Integer = 2 To 4
                If BidPlavers(plp) = 0 Then
                    BidPlavers(plp) = 1
                End If
            Next
            'В селектор ставок
            StavkaSelector.Interval = SpeedStavka
            StavkaSelector.Start()
            Exit Sub
        End If
        'В селектор ставок

        StavkaSelector.Interval = SpeedStavka
        StavkaSelector.Start()

    End Sub

    Private Sub StavkaSelector_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StavkaSelector.Tick
        If Delta = 4 Then
            Delta = 0
            StavkaSelector.Stop()
            PutCardselector.Interval = SpeedRasclad
            PutCardselector.Start()
        End If
        'Запустить  PutCardselector в бескозырке сразу же так как там нет ставок
        If (Round > 5 And Round < 12) And isPlaverBid = True Then
            StavkaSelector.Stop()
            PutCardselector.Interval = SpeedRasclad
            PutCardselector.Start()
            Exit Sub
        End If
        'Запустить селектор ставок всех игроков
        If isPlaverBid = True Then
            RightOfBid = RightOfBid + 1
            Delta += 1
            Select Case RightOfBid
                Case 2
                    StavkaPic2.Visible = True
                    Select Case BidPlavers(2)
                        Case 0
                            StavkaPic2.Image = My.Resources.Пас
                        Case 1
                            StavkaPic2.Image = My.Resources._1
                        Case 2
                            StavkaPic2.Image = My.Resources._2
                        Case 3
                            StavkaPic2.Image = My.Resources._3
                        Case 4
                            StavkaPic2.Image = My.Resources._4
                        Case 5
                            StavkaPic2.Image = My.Resources._5
                        Case 6
                            StavkaPic2.Image = My.Resources._6
                    End Select

                Case 3
                    StavkaPic3.Visible = True
                    Select Case BidPlavers(3)
                        Case 0
                            StavkaPic3.Image = My.Resources._3_Пас
                        Case 1
                            StavkaPic3.Image = My.Resources._3_1
                        Case 2
                            StavkaPic3.Image = My.Resources._3_2
                        Case 3
                            StavkaPic3.Image = My.Resources._3_3
                        Case 4
                            StavkaPic3.Image = My.Resources._3_4
                        Case 5
                            StavkaPic3.Image = My.Resources._3_5
                        Case 6
                            StavkaPic3.Image = My.Resources._3_6
                    End Select
                Case 4
                    StavkaPic4.Visible = True
                    Select Case BidPlavers(4)
                        Case 0
                            StavkaPic4.Image = My.Resources._4_Пас
                        Case 1
                            StavkaPic4.Image = My.Resources._4_1
                        Case 2
                            StavkaPic4.Image = My.Resources._4_2
                        Case 3
                            StavkaPic4.Image = My.Resources._4_3
                        Case 4
                            StavkaPic4.Image = My.Resources._4_4
                        Case 5
                            StavkaPic4.Image = My.Resources._4_5
                        Case 6
                            StavkaPic4.Image = My.Resources._4_6
                    End Select


            End Select
            If Not (NumberOfCards = 6) Then 'Не проигрывать звук в бескозырке
                'Пройгрыш звука кнопки ставки
                If Sound Then
                    SoundStavka.Play()
                End If
            End If
        Else
            If isPlaverBid = False And RightOfBid <> 1 Then
                Delta += 1
                Select Case RightOfBid
                    Case 4
                        If Not (Round > 5 And Round < 12) Then StavkaPic4.Visible = True
                        Select Case BidPlavers(4)
                            Case 0
                                StavkaPic4.Image = My.Resources._4_Пас
                            Case 1
                                StavkaPic4.Image = My.Resources._4_1
                            Case 2
                                StavkaPic4.Image = My.Resources._4_2
                            Case 3
                                StavkaPic4.Image = My.Resources._4_3
                            Case 4
                                StavkaPic4.Image = My.Resources._4_4
                            Case 5
                                StavkaPic4.Image = My.Resources._4_5
                            Case 6
                                StavkaPic4.Image = My.Resources._4_6
                        End Select
                        RightOfBid = 1
                    Case 3
                        If Not (Round > 5 And Round < 12) Then StavkaPic3.Visible = True
                        Select Case BidPlavers(3)
                            Case 0
                                StavkaPic3.Image = My.Resources._3_Пас
                            Case 1
                                StavkaPic3.Image = My.Resources._3_1
                            Case 2
                                StavkaPic3.Image = My.Resources._3_2
                            Case 3
                                StavkaPic3.Image = My.Resources._3_3
                            Case 4
                                StavkaPic3.Image = My.Resources._3_4
                            Case 5
                                StavkaPic3.Image = My.Resources._3_5
                            Case 6
                                StavkaPic3.Image = My.Resources._3_6
                        End Select
                        RightOfBid = 4
                    Case 2
                        If Not (Round > 5 And Round < 12) Then StavkaPic2.Visible = True
                        Select Case BidPlavers(2)
                            Case 0
                                StavkaPic2.Image = My.Resources.Пас
                            Case 1
                                StavkaPic2.Image = My.Resources._1
                            Case 2
                                StavkaPic2.Image = My.Resources._2
                            Case 3
                                StavkaPic2.Image = My.Resources._3
                            Case 4
                                StavkaPic2.Image = My.Resources._4
                            Case 5
                                StavkaPic2.Image = My.Resources._5
                            Case 6
                                StavkaPic2.Image = My.Resources._6
                        End Select
                        RightOfBid = 3
                End Select
                If Not (NumberOfCards = 6) Then 'Не проигрывать звук в бескозырке
                    'Пройгрыш звука кнопки ставки
                    If Sound Then
                        SoundStavka.Play()
                    End If
                End If
            End If
        End If
        If RightOfBid = 5 Then
            RightOfBid = 1
            StavkaSelector.Stop()
            PutCardselector.Interval = SpeedRasclad
            PutCardselector.Start()
        End If
        If Delta = 4 Then
            Delta = 0
            StavkaSelector.Stop()
            PutCardselector.Interval = SpeedRasclad
            PutCardselector.Start()
        End If
    End Sub
    Private Sub PutCardSelector_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PutCardselector.Tick
        PlaversMoveShow() 'Показать право хода картинкой
        ''Блок поклажи выбранной карты компа
        If RightToMove = 4 Then
            BrainCalcMove()
            prot3(SelectedCard).Visible = False
            For yui As Integer = 1 To 6
                If CardsTable(RndTableLocation(yui)).Visible = False Then
                    CardsTable(RndTableLocation(yui)).Visible = True
                    CardsTable(RndTableLocation(yui)).Image = GetItem(CardsPlavers(4, SelectedCard))
                    CardsTable(RndTableLocation(yui)).BringToFront()
                    Exit For
                End If
            Next yui
            ShowActivCard()
            If RightToMove = 4 Then RightToMove = 1 : PlaversMoveShow() 'Показать право хода картинкой
            PutCardselector.Stop()
            If Sound Then
                SoundCards.Play()
            End If
        End If

        If RightToMove = 3 Then
            BrainCalcMove()
            prot2(SelectedCard).Visible = False
            For yui As Integer = 1 To 6
                If CardsTable(RndTableLocation(yui)).Visible = False Then
                    CardsTable(RndTableLocation(yui)).Visible = True
                    CardsTable(RndTableLocation(yui)).Image = GetItem(CardsPlavers(3, SelectedCard))
                    CardsTable(RndTableLocation(yui)).BringToFront()
                    Exit For
                End If
            Next yui
            ShowActivCard()
            RightToMove = RightToMove + 1
            If Sound Then
                SoundCards.Play()
            End If
        End If

        If RightToMove = 2 Then
            BrainCalcMove()
            prot1(SelectedCard).Visible = False
            For yui As Integer = 1 To 6
                If CardsTable(RndTableLocation(yui)).Visible = False Then
                    CardsTable(RndTableLocation(yui)).Visible = True
                    CardsTable(RndTableLocation(yui)).Image = GetItem(CardsPlavers(2, SelectedCard))
                    CardsTable(RndTableLocation(yui)).BringToFront()
                    Exit For
                End If
            Next yui
            ShowActivCard()
            RightToMove = RightToMove + 1
            If Sound Then
                SoundCards.Play()
            End If
        End If
    End Sub
    Private Sub Zaderjka_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zaderjka.Tick
        'Блок задержки между турами
        'If Dalee Then 'Переключение с кнопки
        Round = Round + 1
        Dalee = False
        Zaderjka.Stop()
        Main()
        'End If
    End Sub

    Sub PlaversVzatShow()
        'Подпрограмма показа выйгрынной взятки
        'Показ если взятки 1 штуки
        If PlaversScores(1, Round) = 1 Or PlaversScores(1, Round) = 10 Then
            Vzat1.Image = My.Resources._1_11
            Vzat1.Visible = True
        End If
        If PlaversScores(2, Round) = 1 Or PlaversScores(2, Round) = 10 Then
            Vzat2.Image = My.Resources._2_11
            Vzat2.Visible = True
        End If
        If PlaversScores(3, Round) = 1 Or PlaversScores(3, Round) = 10 Then
            Vzat3.Image = My.Resources._3_11
            Vzat3.Visible = True
        End If
        If PlaversScores(4, Round) = 1 Or PlaversScores(4, Round) = 10 Then
            Vzat4.Image = My.Resources._4_11
            Vzat4.Visible = True
        End If

        If NumberOfCards > 1 Then
            'Показ если взятки 2 штуки
            If PlaversScores(1, Round) = 2 Or PlaversScores(1, Round) = 20 Then
                Vzat1.Image = My.Resources._1_22
                Vzat1.Visible = True
            End If
            If PlaversScores(2, Round) = 2 Or PlaversScores(2, Round) = 20 Then
                Vzat2.Image = My.Resources._2_22
                Vzat2.Visible = True
            End If
            If PlaversScores(3, Round) = 2 Or PlaversScores(3, Round) = 20 Then
                Vzat3.Image = My.Resources._3_22
                Vzat3.Visible = True
            End If
            If PlaversScores(4, Round) = 2 Or PlaversScores(4, Round) = 20 Then
                Vzat4.Image = My.Resources._4_22
                Vzat4.Visible = True
            End If

        End If
        If NumberOfCards > 2 Then
            'Показ если взятки 3 штуки
            If PlaversScores(1, Round) = 3 Or PlaversScores(1, Round) = 30 Then
                Vzat1.Image = My.Resources._1_33
                Vzat1.Visible = True
            End If
            If PlaversScores(2, Round) = 3 Or PlaversScores(2, Round) = 30 Then
                Vzat2.Image = My.Resources._2_33
                Vzat2.Visible = True
            End If
            If PlaversScores(3, Round) = 3 Or PlaversScores(3, Round) = 30 Then
                Vzat3.Image = My.Resources._3_33
                Vzat3.Visible = True
            End If
            If PlaversScores(4, Round) = 3 Or PlaversScores(4, Round) = 30 Then
                Vzat4.Image = My.Resources._4_33
                Vzat4.Visible = True
            End If

        End If
        If NumberOfCards > 3 Then
            'Показ если взятки 4 штуки
            If PlaversScores(1, Round) = 4 Or PlaversScores(1, Round) = 40 Then
                Vzat1.Image = My.Resources._1_44
                Vzat1.Visible = True
            End If
            If PlaversScores(2, Round) = 4 Or PlaversScores(2, Round) = 40 Then
                Vzat2.Image = My.Resources._2_44
                Vzat2.Visible = True
            End If
            If PlaversScores(3, Round) = 4 Or PlaversScores(3, Round) = 40 Then
                Vzat3.Image = My.Resources._3_44
                Vzat3.Visible = True
            End If
            If PlaversScores(4, Round) = 4 Or PlaversScores(4, Round) = 40 Then
                Vzat4.Image = My.Resources._4_44
                Vzat4.Visible = True
            End If

        End If
        If NumberOfCards > 4 Then
            'Показ если взятки 5 штук
            If PlaversScores(1, Round) = 5 Or PlaversScores(1, Round) = 50 Then
                Vzat1.Image = My.Resources._1_55
                Vzat1.Visible = True
            End If
            If PlaversScores(2, Round) = 5 Or PlaversScores(2, Round) = 50 Then
                Vzat2.Image = My.Resources._2_55
                Vzat2.Visible = True
            End If
            If PlaversScores(3, Round) = 5 Or PlaversScores(3, Round) = 50 Then
                Vzat3.Image = My.Resources._3_55
                Vzat3.Visible = True
            End If
            If PlaversScores(4, Round) = 5 Or PlaversScores(4, Round) = 50 Then
                Vzat4.Image = My.Resources._4_55
                Vzat4.Visible = True
            End If

        End If
        If NumberOfCards > 5 Then
            'Показ если взятки 6 штук
            If PlaversScores(1, Round) = 6 Or PlaversScores(1, Round) = 60 Then
                Vzat1.Image = My.Resources._1_66
                Vzat1.Visible = True
            End If
            If PlaversScores(2, Round) = 6 Or PlaversScores(2, Round) = 60 Then
                Vzat2.Image = My.Resources._2_66
                Vzat2.Visible = True
            End If
            If PlaversScores(3, Round) = 6 Or PlaversScores(3, Round) = 60 Then
                Vzat3.Image = My.Resources._3_66
                Vzat3.Visible = True
            End If
            If PlaversScores(4, Round) = 6 Or PlaversScores(4, Round) = 60 Then
                Vzat4.Image = My.Resources._4_66
                Vzat4.Visible = True
            End If

        End If
        'Проигрыш звука взятия взятки
        If Sound Then
            My.Computer.Audio.Play(My.Resources.Взятие_взятки, AudioPlayMode.Background)
        End If
    End Sub


    Private Sub Detector_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detector.Tick
        'Таймер детектирования полного набора карт на столе(все 4)
        If CardsPlaversTablePow(1) <> 0 And CardsPlaversTablePow(2) <> 0 And CardsPlaversTablePow(3) <> 0 And CardsPlaversTablePow(4) <> 0 Then
            AllCardsCount = AllCardsCount - 4
            PicActivCard.Visible = False
            If AllCardsCount = 0 Then
                'Произвести окончательный расчет очков и показ
                CalcWiner()
                For Card As Integer = 1 To 4
                    PlaverScore(Card) = PlaverScore(Card) + PlaversScores(Card, Round)
                Next Card
                ShowScore()
                Zaderjka.Interval = SpeedChangeTur
                Zaderjka.Start()
                PutCardselector.Stop()
                Detector.Stop()
                Exit Sub
            Else
                'Промежуточный расчет
                CalcWinerMini()
                ZaderjkaMini.Interval = SpeedChangeMiniTur
                ZaderjkaMini.Start()
            End If
            PlaversVzatShow()

            PutCardselector.Stop()
            Detector.Stop()
        End If
    End Sub
    Sub CalcWinerMini()
        'Функция расчета очков в промежуточных играх(а также расчет кто заходит с карты при взятии ставки)
        Select Case NumberOfCards
            Case 2, 3, 4, 5, 6
                'Расчет очков 1 игрока
                CalcZdvig() 'Преобразование к удобному виду
                If CardsPlaversTablePow(1) > CardsPlaversTablePow(2) And CardsPlaversTablePow(1) > CardsPlaversTablePow(3) And
                      CardsPlaversTablePow(1) > CardsPlaversTablePow(4) Then
                    PlaversScores(1, Round) = PlaversScores(1, Round) + 1
                    RightToMove = 1
                    FirstRightMove = 1
                End If
                'Расчет очков 2 игрока
                If CardsPlaversTablePow(2) > CardsPlaversTablePow(1) And CardsPlaversTablePow(2) > CardsPlaversTablePow(3) And
             CardsPlaversTablePow(2) > CardsPlaversTablePow(4) Then
                    PlaversScores(2, Round) = PlaversScores(2, Round) + 1
                    RightToMove = 2
                    FirstRightMove = 2
                End If
                'Расчет очков 3 игрока
                If CardsPlaversTablePow(3) > CardsPlaversTablePow(1) And CardsPlaversTablePow(3) > CardsPlaversTablePow(2) And
         CardsPlaversTablePow(3) > CardsPlaversTablePow(4) Then
                    PlaversScores(3, Round) = PlaversScores(3, Round) + 1
                    RightToMove = 3
                    FirstRightMove = 3
                End If
                'Расчет очков 4 игрока
                If CardsPlaversTablePow(4) > CardsPlaversTablePow(1) And CardsPlaversTablePow(4) > CardsPlaversTablePow(2) And
    CardsPlaversTablePow(4) > CardsPlaversTablePow(3) Then
                    PlaversScores(4, Round) = PlaversScores(4, Round) + 1
                    RightToMove = 4
                    FirstRightMove = 4
                End If
        End Select
        SetRandomPlaceArray() 'Заполнить массив случайных мест карт на столе
        PlaversMoveShow() 'Показать право хода картинкой
    End Sub
    Sub CalcZdvig()
        'Преобразование массива CardsPlaversStolPow к виду удобному к вычислению очков(неудобства из за права хода)(делаем 1 элемент массива принадлежит 1 игроку и тд) 
        Dim Via, Via2 As Integer
        'If NachPravoXoda = 6 Then
        '    Via = CardsPlaversStolPow(1)
        '    CardsPlaversStolPow(1) = CardsPlaversStolPow(2)
        '    CardsPlaversStolPow(2) = CardsPlaversStolPow(3)
        '    CardsPlaversStolPow(3) = CardsPlaversStolPow(4)
        '    CardsPlaversStolPow(4) = CardsPlaversStolPow(5)
        '    CardsPlaversStolPow(5) = CardsPlaversStolPow(6)
        '    CardsPlaversStolPow(6) = Via
        'End If
        'If NachPravoXoda = 5 Then
        '    Via = CardsPlaversStolPow(5)
        '    Via2 = CardsPlaversStolPow(4)
        '    CardsPlaversStolPow(4) = CardsPlaversStolPow(6)
        '    CardsPlaversStolPow(5) = CardsPlaversStolPow(1)
        '    CardsPlaversStolPow(6) = CardsPlaversStolPow(2)
        '    CardsPlaversStolPow(1) = CardsPlaversStolPow(3)
        '    CardsPlaversStolPow(2) = Via2
        '    CardsPlaversStolPow(3) = Via
        'End If
        'If NachPravoXoda = 4 Then
        '    Via = CardsPlaversStolPow(3)
        '    Via2 = CardsPlaversStolPow(4)
        '    Via3 = CardsPlaversStolPow(5)
        '    CardsPlaversStolPow(3) = CardsPlaversStolPow(6)
        '    CardsPlaversStolPow(6) = Via
        '    CardsPlaversStolPow(4) = CardsPlaversStolPow(1)
        '    CardsPlaversStolPow(1) = Via2
        '    CardsPlaversStolPow(5) = CardsPlaversStolPow(2)
        '    CardsPlaversStolPow(2) = Via3
        'End If
        'If NachPravoXoda = 3 Then
        '    Via = CardsPlaversStolPow(1)
        '    Via2 = CardsPlaversStolPow(2)
        '    Via3 = CardsPlaversStolPow(3)
        '    CardsPlaversStolPow(1) = CardsPlaversStolPow(5)
        '    CardsPlaversStolPow(2) = CardsPlaversStolPow(6)
        '    CardsPlaversStolPow(3) = Via
        '    CardsPlaversStolPow(6) = CardsPlaversStolPow(4)
        '    CardsPlaversStolPow(4) = Via2
        '    CardsPlaversStolPow(5) = Via3
        'End If
        'If NachPravoXoda = 2 Then
        '    Via = CardsPlaversStolPow(6)
        '    CardsPlaversStolPow(6) = CardsPlaversStolPow(5)
        '    CardsPlaversStolPow(5) = CardsPlaversStolPow(4)
        '    CardsPlaversStolPow(4) = CardsPlaversStolPow(3)
        '    CardsPlaversStolPow(3) = CardsPlaversStolPow(2)
        '    CardsPlaversStolPow(2) = CardsPlaversStolPow(1)
        '    CardsPlaversStolPow(1) = Via
        'End If




        If FirstRightMove = 4 Then
            Via = CardsPlaversTablePow(1)
            CardsPlaversTablePow(1) = CardsPlaversTablePow(2)
            CardsPlaversTablePow(2) = CardsPlaversTablePow(3)
            CardsPlaversTablePow(3) = CardsPlaversTablePow(4)
            CardsPlaversTablePow(4) = Via
        End If
        If FirstRightMove = 3 Then
            Via = CardsPlaversTablePow(4)
            Via2 = CardsPlaversTablePow(1)
            CardsPlaversTablePow(4) = CardsPlaversTablePow(2)
            CardsPlaversTablePow(2) = Via
            CardsPlaversTablePow(1) = CardsPlaversTablePow(3)
            CardsPlaversTablePow(3) = Via2
        End If

        If FirstRightMove = 2 Then
            Via = CardsPlaversTablePow(4)
            CardsPlaversTablePow(4) = CardsPlaversTablePow(3)
            CardsPlaversTablePow(3) = CardsPlaversTablePow(2)
            CardsPlaversTablePow(2) = CardsPlaversTablePow(1)
            CardsPlaversTablePow(1) = Via
        End If

    End Sub
    Private Sub ZaderjkaMini_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZaderjkaMini.Tick
        'Задержка между промежуточными играми
        ZaderjkaMini.Enabled = False
        ZaderjkaMini.Stop()
        'Очистить стол
        StolKardsVis()
        'Обнулим массив карт на столе и счетчик массива CardsPlaversStolPow 
        CheckFule = 0
        Delta = 0
        Array.Clear(CardsPlaversTablePow, 1, 4)
        IsActiveCard = False
        PutCardselector.Interval = SpeedRasclad
        PutCardselector.Start()
        Detector.Start()
    End Sub
    Public Sub ShowScore()
        If Math.Sign(PlaverScore(1)) = -1 Then
            Opic0.Image = My.Resources.Минус
        Else
            Opic0.Image = My.Resources.Плюс
        End If

        Select Case Len(Str(Math.Abs(PlaverScore(1)))) - 1
            Case 1
                Select Case PlaverScore(1)
                    Case 0
                        Opic1.Image = My.Resources.Ноль
                    Case 1
                        Opic1.Image = My.Resources._11
                    Case 2
                        Opic1.Image = My.Resources._12
                    Case 3
                        Opic1.Image = My.Resources._13
                    Case 4
                        Opic1.Image = My.Resources._14
                    Case 5
                        Opic1.Image = My.Resources._15
                    Case 6
                        Opic1.Image = My.Resources._16
                    Case 7
                        Opic1.Image = My.Resources._17
                    Case 8
                        Opic1.Image = My.Resources._18
                    Case 9
                        Opic1.Image = My.Resources._19
                End Select
                Opic2.Image = My.Resources._2_отк
                Opic3.Image = My.Resources._3_отк
                Opic4.Image = My.Resources._4_отк
            Case 2
                Select Case Mid(Math.Abs(PlaverScore(1)), 1, 1)
                    Case 1
                        Opic1.Image = My.Resources._11
                    Case 2
                        Opic1.Image = My.Resources._12
                    Case 3
                        Opic1.Image = My.Resources._13
                    Case 4
                        Opic1.Image = My.Resources._14
                    Case 5
                        Opic1.Image = My.Resources._15
                    Case 6
                        Opic1.Image = My.Resources._16
                    Case 7
                        Opic1.Image = My.Resources._17
                    Case 8
                        Opic1.Image = My.Resources._18
                    Case 9
                        Opic1.Image = My.Resources._19
                End Select
                Select Case Mid(Math.Abs(PlaverScore(1)), 2, 1)
                    Case 0
                        Opic2.Image = My.Resources._20
                    Case 1
                        Opic2.Image = My.Resources._21
                    Case 2
                        Opic2.Image = My.Resources._22
                    Case 3
                        Opic2.Image = My.Resources._23
                    Case 4
                        Opic2.Image = My.Resources._24
                    Case 5
                        Opic2.Image = My.Resources._25
                    Case 6
                        Opic2.Image = My.Resources._26
                    Case 7
                        Opic2.Image = My.Resources._27
                    Case 8
                        Opic2.Image = My.Resources._28
                    Case 9
                        Opic2.Image = My.Resources._29
                End Select
                Opic3.Image = My.Resources._3_отк
                Opic4.Image = My.Resources._4_отк
            Case 3
                Select Case Mid(Math.Abs(PlaverScore(1)), 1, 1)
                    Case 1
                        Opic1.Image = My.Resources._11
                    Case 2
                        Opic1.Image = My.Resources._12
                    Case 3
                        Opic1.Image = My.Resources._13
                    Case 4
                        Opic1.Image = My.Resources._14
                    Case 5
                        Opic1.Image = My.Resources._15
                    Case 6
                        Opic1.Image = My.Resources._16
                    Case 7
                        Opic1.Image = My.Resources._17
                    Case 8
                        Opic1.Image = My.Resources._18
                    Case 9
                        Opic1.Image = My.Resources._19
                End Select
                Select Case Mid(Math.Abs(PlaverScore(1)), 2, 1)
                    Case 0
                        Opic2.Image = My.Resources._20
                    Case 1
                        Opic2.Image = My.Resources._21
                    Case 2
                        Opic2.Image = My.Resources._22
                    Case 3
                        Opic2.Image = My.Resources._23
                    Case 4
                        Opic2.Image = My.Resources._24
                    Case 5
                        Opic2.Image = My.Resources._25
                    Case 6
                        Opic2.Image = My.Resources._26
                    Case 7
                        Opic2.Image = My.Resources._27
                    Case 8
                        Opic2.Image = My.Resources._28
                    Case 9
                        Opic2.Image = My.Resources._29
                End Select
                Select Case Mid(Math.Abs(PlaverScore(1)), 3, 1)
                    Case 0
                        Opic3.Image = My.Resources._30
                    Case 1
                        Opic3.Image = My.Resources._31
                    Case 2
                        Opic3.Image = My.Resources._32
                    Case 3
                        Opic3.Image = My.Resources._33
                    Case 4
                        Opic3.Image = My.Resources._34
                    Case 5
                        Opic3.Image = My.Resources._35
                    Case 6
                        Opic3.Image = My.Resources._36
                    Case 7
                        Opic3.Image = My.Resources._37
                    Case 8
                        Opic3.Image = My.Resources._38
                    Case 9
                        Opic3.Image = My.Resources._39
                End Select
                Opic4.Image = My.Resources._4_отк
            Case 4
                Select Case Mid(Math.Abs(PlaverScore(1)), 1, 1)
                    Case 1
                        Opic1.Image = My.Resources._11
                    Case 2
                        Opic1.Image = My.Resources._12
                    Case 3
                        Opic1.Image = My.Resources._13
                    Case 4
                        Opic1.Image = My.Resources._14
                    Case 5
                        Opic1.Image = My.Resources._15
                    Case 6
                        Opic1.Image = My.Resources._16
                    Case 7
                        Opic1.Image = My.Resources._17
                    Case 8
                        Opic1.Image = My.Resources._18
                    Case 9
                        Opic1.Image = My.Resources._19
                End Select
                Select Case Mid(Math.Abs(PlaverScore(1)), 2, 1)
                    Case 0
                        Opic2.Image = My.Resources._20
                    Case 1
                        Opic2.Image = My.Resources._21
                    Case 2
                        Opic2.Image = My.Resources._22
                    Case 3
                        Opic2.Image = My.Resources._23
                    Case 4
                        Opic2.Image = My.Resources._24
                    Case 5
                        Opic2.Image = My.Resources._25
                    Case 6
                        Opic2.Image = My.Resources._26
                    Case 7
                        Opic2.Image = My.Resources._27
                    Case 8
                        Opic2.Image = My.Resources._28
                    Case 9
                        Opic2.Image = My.Resources._29
                End Select
                Select Case Mid(Math.Abs(PlaverScore(1)), 3, 1)
                    Case 0
                        Opic3.Image = My.Resources._30
                    Case 1
                        Opic3.Image = My.Resources._31
                    Case 2
                        Opic3.Image = My.Resources._32
                    Case 3
                        Opic3.Image = My.Resources._33
                    Case 4
                        Opic3.Image = My.Resources._34
                    Case 5
                        Opic3.Image = My.Resources._35
                    Case 6
                        Opic3.Image = My.Resources._36
                    Case 7
                        Opic3.Image = My.Resources._37
                    Case 8
                        Opic3.Image = My.Resources._38
                    Case 9
                        Opic3.Image = My.Resources._39
                End Select
                Select Case Mid(Math.Abs(PlaverScore(1)), 4, 1)
                    Case 0
                        Opic4.Image = My.Resources._40
                    Case 1
                        Opic4.Image = My.Resources._41
                    Case 2
                        Opic4.Image = My.Resources._42
                    Case 3
                        Opic4.Image = My.Resources._43
                    Case 4
                        Opic4.Image = My.Resources._44
                    Case 5
                        Opic4.Image = My.Resources._45
                    Case 6
                        Opic4.Image = My.Resources._46
                    Case 7
                        Opic4.Image = My.Resources._47
                    Case 8
                        Opic4.Image = My.Resources._48
                    Case 9
                        Opic4.Image = My.Resources._49
                End Select
        End Select
    End Sub
    Sub PlaversMoveShow()
        Select Case RightToMove
            Case 1
                PicPlaverName.Visible = True
                PicPravo1.Visible = True
                PicPravo2.Visible = False
                PicPravo3.Visible = False
                PicPravo4.Visible = False

            Case 2
                PicPlaverName.Visible = False
                PicPravo1.Visible = False
                PicPravo2.Visible = True
                PicPravo3.Visible = False
                PicPravo4.Visible = False

            Case 3
                PicPlaverName.Visible = False
                PicPravo1.Visible = False
                PicPravo2.Visible = False
                PicPravo3.Visible = True
                PicPravo4.Visible = False

            Case 4
                PicPlaverName.Visible = False
                PicPravo1.Visible = False
                PicPravo2.Visible = False
                PicPravo3.Visible = False
                PicPravo4.Visible = True

                'Case 5
                '    PicPlaverName.Visible = False
                '    PicPravo1.Visible = False
                '    PicPravo2.Visible = False
                '    PicPravo3.Visible = False
                '    PicPravo4.Visible = False
                '    PicPravo5.Visible = True
                '    PicPravo6.Visible = False
                'Case 6
                '    PicPlaverName.Visible = False
                '    PicPravo1.Visible = False
                '    PicPravo2.Visible = False
                '    PicPravo3.Visible = False
                '    PicPravo4.Visible = False
                '    PicPravo5.Visible = False
                '    PicPravo6.Visible = True
        End Select
    End Sub
    Private Sub ВклToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВклToolStripMenuItem.Click
        Sound = True
        ВклToolStripMenuItem.Checked = True
        ВыклToolStripMenuItem.Checked = False
    End Sub
    Private Sub ВыклToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВыклToolStripMenuItem.Click
        Sound = False
        ВыклToolStripMenuItem.Checked = True
        ВклToolStripMenuItem.Checked = False
    End Sub
    Private Sub АнализдляАдминаToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles АнализдляАдминаToolStripMenuItem.Click






    End Sub
    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    TextBox1.Text = PravoXoda
    '    TextBox2.Text = PravoStavki
    '    TextBox4.Text = CardsPlaversStolPow(1) & "_" & CardsPlaversStolPow(2) & "_" & CardsPlaversStolPow(3) & "_" & CardsPlaversStolPow(4) & "_" & CardsPlaversStolPow(5) & "_" & CardsPlaversStolPow(6) & " " & "CH=" & Ch & " " & Delta & vbCrLf
    '    TextBox4.Text = MSEAinfo
    'End Sub
    Private Sub ОчкиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОчкиToolStripMenuItem.Click
        Dialog1.Show()
    End Sub
    Private Sub DialogTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DialogTimer.Tick
        Dialog1.Show()
        DialogTimer.Stop()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dalee = True
    End Sub
    Private Sub ПоказатьКартыПротивникаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПоказатьКартыПротивникаToolStripMenuItem.Click

    End Sub
    Private Sub DfgToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DfgToolStripMenuItem.Click
        Dim Path As String
        Path = Application.StartupPath.ToString()
        Path = Path & "\Help.chm"
        Help.ShowHelp(Me, Path)
    End Sub
    Private Sub СоздательToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СоздательToolStripMenuItem.Click
        Creator.Show()
    End Sub
    Private Sub ОПрограммеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОПрограммеToolStripMenuItem.Click
        Dialog4.Show()
    End Sub
    Private Sub Fon_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Fon.MouseMove
        'Выставление изображения ставок без свечения
        Select Case Bid
            Case 0
                StavkaPic.Image = My.Resources.ПасБ
            Case 1
                StavkaPic.Image = My.Resources._1Б
            Case 2
                StavkaPic.Image = My.Resources._2Б
            Case 3
                StavkaPic.Image = My.Resources._3Б
            Case 4
                StavkaPic.Image = My.Resources._4Б
            Case 5
                StavkaPic.Image = My.Resources._5Б
            Case 6
                StavkaPic.Image = My.Resources._6Б
        End Select

        If StartPic.Enabled = True Then
            StartPic.Image = My.Resources.V1 'Установка картинки кнопки старта
        End If
        Picture1.Enabled = True
        Picture2.Enabled = True
        Picture3.Enabled = True
        Picture4.Enabled = True
        Picture5.Enabled = True
        Picture6.Enabled = True

        If e.Location.Y > 715 And e.Location.Y < 730 Then Exit Sub 'Фикса чтоб карта не мерцала при наведении на неё с низу

        'Движение карт
        If MoveCards1 = True Then
            Picture2.Enabled = False
            Picture3.Enabled = False
            Picture4.Enabled = False
            Picture5.Enabled = False
            Picture6.Enabled = False
            Picture1.Top = Picture1.Top + 15
            Picture1.Enabled = False
            MoveCards1 = False
        End If
        If MoveCards2 = True Then
            Picture1.Enabled = False
            Picture3.Enabled = False
            Picture4.Enabled = False
            Picture5.Enabled = False
            Picture6.Enabled = False
            Picture2.Top = Picture2.Top + 15
            Picture2.Enabled = False
            MoveCards2 = False
        End If
        If MoveCards3 = True Then
            Picture1.Enabled = False
            Picture2.Enabled = False
            Picture4.Enabled = False
            Picture5.Enabled = False
            Picture6.Enabled = False
            Picture3.Top = Picture3.Top + 15
            Picture3.Enabled = False
            MoveCards3 = False
        End If
        If MoveCards4 = True Then
            Picture1.Enabled = False
            Picture2.Enabled = False
            Picture3.Enabled = False
            Picture5.Enabled = False
            Picture6.Enabled = False
            Picture4.Top = Picture4.Top + 15
            Picture4.Enabled = False
            MoveCards4 = False
        End If
        If MoveCards5 = True Then
            Picture1.Enabled = False
            Picture2.Enabled = False
            Picture3.Enabled = False
            Picture4.Enabled = False
            Picture6.Enabled = False
            Picture5.Top = Picture5.Top + 15
            Picture5.Enabled = False
            MoveCards5 = False
        End If
        If MoveCards6 = True Then
            Picture1.Enabled = False
            Picture2.Enabled = False
            Picture3.Enabled = False
            Picture4.Enabled = False
            Picture5.Enabled = False
            Picture6.Top = Picture6.Top + 15
            Picture6.Enabled = False
            MoveCards6 = False
        End If
        'Показать меню игры учитывая координаты курсора
        If e.Location.Y < 560 Then
            MenuStrip1.Visible = True
            MenuStrip1.BringToFront()
        Else
            MenuStrip1.Visible = False
        End If
        NewGamePic.Image = My.Resources.Кнопка_новая_играТ
    End Sub

    Private Sub МедленноToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles МедленноToolStripMenuItem.Click
        МедленноToolStripMenuItem.Checked = True
        СредняяToolStripMenuItem.Checked = False
        БыстраяToolStripMenuItem.Checked = False
        ОченьБыстраяToolStripMenuItem.Checked = False
        SpeedRasclad = 1000
        SpeedStavka = 1000
    End Sub

    Private Sub СредняяToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СредняяToolStripMenuItem.Click
        МедленноToolStripMenuItem.Checked = False
        СредняяToolStripMenuItem.Checked = True
        БыстраяToolStripMenuItem.Checked = False
        ОченьБыстраяToolStripMenuItem.Checked = False
        SpeedRasclad = 500
        SpeedStavka = 500
    End Sub

    Private Sub БыстраяToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles БыстраяToolStripMenuItem.Click
        МедленноToolStripMenuItem.Checked = False
        СредняяToolStripMenuItem.Checked = False
        БыстраяToolStripMenuItem.Checked = True
        ОченьБыстраяToolStripMenuItem.Checked = False
        SpeedRasclad = 250
        SpeedStavka = 250
    End Sub

    Private Sub ОченьБыстраяToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОченьБыстраяToolStripMenuItem.Click
        МедленноToolStripMenuItem.Checked = False
        СредняяToolStripMenuItem.Checked = False
        БыстраяToolStripMenuItem.Checked = False
        ОченьБыстраяToolStripMenuItem.Checked = True
        SpeedRasclad = 100
        SpeedStavka = 100
        SpeedChangeMiniTur = 250
        SpeedChangeTur = 300
    End Sub

    Private Sub StartPic_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StartPic.MouseDown
        If Not (RightOfBid = 1) Then
            Exit Sub 'Блокиковать кнопку пока не ваше право ставки
        End If
        Delta += 1
        BidPlavers(1) = Bid
        isPlaverBid = True
        StavkaSelector.Interval = SpeedStavka
        StavkaSelector.Start()
        StartPic.Enabled = False
        StartPic.Image = My.Resources.V3
        StavkaPic.Enabled = False
        'Показать карту игроку при Лбах
        If Round = 17 Or Round = 18 Or Round = 19 Then
            Igrok(1).Image = GetItem(CardsPlavers(1, 1))
            Igrok(1).Visible = True
        End If
        'Показать карту игроку при Темной
        If Round = 23 Or Round = 24 Or Round = 25 Then
            For pl1 As Integer = 1 To 5
                Igrok(pl1).Image = GetItem(CardsPlavers(1, pl1))
                Igrok(pl1).Visible = True
            Next pl1
        End If
        'Оповешать после нажатия кнопки о наличии покера(в темной и лбах)
        If Round = 17 Or Round = 18 Or Round = 19 Or Round = 23 Or Round = 24 Or Round = 25 Then
            For ii = 1 To NumberOfCards
                If CardsPlavers(1, ii) = 24 Then
                    If Sound Then
                        SoundPokHave.PlaySync()
                    Else
                        MsgBox("У вас покер!")
                    End If
                End If
            Next ii
        End If
        'Пройгрыш звука
        If Sound Then
            SoundStart.Play()
        End If
    End Sub

    Private Sub StartPic_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StartPic.MouseMove
        StartPic.Image = My.Resources.V2
        'Выставление изображения ставок без свечения
        Select Case Bid
            Case 0
                StavkaPic.Image = My.Resources.ПасБ
            Case 1
                StavkaPic.Image = My.Resources._1Б
            Case 2
                StavkaPic.Image = My.Resources._2Б
            Case 3
                StavkaPic.Image = My.Resources._3Б
            Case 4
                StavkaPic.Image = My.Resources._4Б
            Case 5
                StavkaPic.Image = My.Resources._5Б
            Case 6
                StavkaPic.Image = My.Resources._6Б
        End Select
    End Sub
    Private Sub Plaver1Ochki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StartPic.Enabled = False
        StartPic.Image = My.Resources.V3
    End Sub
    Private Sub StavkaPic_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StavkaPic.MouseMove
        'Выставление изображения ставок
        Select Case Bid
            Case 0
                StavkaPic.Image = My.Resources.ПасС
            Case 1
                StavkaPic.Image = My.Resources._1С
            Case 2
                StavkaPic.Image = My.Resources._2С
            Case 3
                StavkaPic.Image = My.Resources._3С
            Case 4
                StavkaPic.Image = My.Resources._4С
            Case 5
                StavkaPic.Image = My.Resources._5С
            Case 6
                StavkaPic.Image = My.Resources._6С
        End Select
        If StartPic.Enabled = True Then
            StartPic.Image = My.Resources.V1
        Else
            StartPic.Image = My.Resources.V3
        End If
    End Sub



    Private Sub StavkaPic_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StavkaPic.MouseDown
        'Пройгрыш звука кнопки ставки
        If Sound Then
            SoundStavka.Play()
        End If
    End Sub

    Private Sub StavkaPic_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StavkaPic.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Select Case NumberOfCards
                Case 1
                    Bid = Bid + 1
                    If Bid = 2 Then
                        Bid = 0
                        StavkaPic.Image = My.Resources.ПасБ
                        Exit Sub
                    End If
                Case 2
                    Bid = Bid + 1
                    If Bid = 3 Then
                        Bid = 0
                        StavkaPic.Image = My.Resources.ПасБ
                        Exit Sub
                    End If
                Case 3
                    Bid = Bid + 1
                    If Bid = 4 Then
                        Bid = 0
                        StavkaPic.Image = My.Resources.ПасБ
                        Exit Sub
                    End If
                Case 4
                    Bid = Bid + 1
                    If Bid = 5 Then
                        Bid = 0
                        StavkaPic.Image = My.Resources.ПасБ
                        Exit Sub
                    End If
                Case 5
                    Bid = Bid + 1
                    If Bid = 6 Then
                        'Блокировка пасования в обязаловке
                        If Round = 20 Or Round = 21 Or Round = 22 Then
                            Bid = 1
                        Else
                            Bid = 0
                            StavkaPic.Image = My.Resources.ПасБ
                            Exit Sub
                        End If
                    End If
            End Select
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Select Case NumberOfCards
                Case 1
                    Bid = Math.Abs(Bid - 1)
                    If Bid = 0 Then
                        StavkaPic.Image = My.Resources.ПасБ
                        Exit Sub
                    End If
                Case 2
                    Bid = Bid - 1
                    If Bid = 0 Then
                        StavkaPic.Image = My.Resources.ПасБ
                        Exit Sub
                    End If
                    If Bid = -1 Then Bid = 2
                    If Bid = -2 Then Bid = 1
                Case 3
                    Bid = Bid - 1
                    If Bid = 0 Then
                        StavkaPic.Image = My.Resources.ПасБ
                        Exit Sub
                    End If
                    If Bid = -1 Then Bid = 3
                    If Bid = -2 Then Bid = 2
                    If Bid = -3 Then Bid = 1
                Case 4
                    Bid = Bid - 1
                    If Bid = 0 Then
                        StavkaPic.Image = My.Resources.ПасБ
                        Exit Sub
                    End If
                    If Bid = -1 Then Bid = 4
                    If Bid = -2 Then Bid = 3
                    If Bid = -3 Then Bid = 2
                    If Bid = -4 Then Bid = 1
                Case 5
                    Bid = Bid - 1
                    If Bid = 0 Then
                        If Round = 20 Or Round = 21 Or Round = 22 Then
                            Bid = 5
                        Else
                            StavkaPic.Image = My.Resources.ПасБ
                            Exit Sub
                        End If

                    End If
                    If Bid = -1 Then Bid = 5
                    If Bid = -2 Then Bid = 4
                    If Bid = -3 Then Bid = 3
                    If Bid = -4 Then Bid = 2
                    If Bid = -5 Then Bid = 1
            End Select
        End If
        'Выставление изображения ставок
        Select Case Bid
            Case 1
                StavkaPic.Image = My.Resources._1Б
            Case 2
                StavkaPic.Image = My.Resources._2Б
            Case 3
                StavkaPic.Image = My.Resources._3Б
            Case 4
                StavkaPic.Image = My.Resources._4Б
            Case 5
                StavkaPic.Image = My.Resources._5Б
            Case 6
                StavkaPic.Image = My.Resources._6Б
        End Select
    End Sub
    Sub ShowActivCard()
        'Блок показа активной карты
        PicActivCard.Visible = True
        PicActivCard.Image = GetItem(ActiveCard)
    End Sub
    Private Sub PlaverNameFromFile()
        'Проверка есть ли файл c именем 1 игрока
        Dim Path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Dim line As String
        If File.Exists(Path & "\" & "PlaverName.txt") Then
            'Фаил имеется
            Using sr As StreamReader = New StreamReader(Path & "\" & "PlaverName.txt", True)
                line = sr.ReadLine
                sr.Close()
            End Using
            PlaverName = line
        Else
            'Создать файл с именем по умолчанию
            Using sw As StreamWriter = New StreamWriter(Path & "\" & "PlaverName.txt", False)
                sw.Write("Игрок")
                sw.Close()
            End Using
            PlaverName = "Игрок"
        End If
    End Sub


    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.TextChanged
        Dim Path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        ToolStripTextBox2.Text = LTrim(ToolStripTextBox2.Text)
        PlaverName = ToolStripTextBox2.Text
        If PlaverName = "" Then PlaverName = "Игрок"
        If Len(PlaverName) > 5 Then ToolStripTextBox2.Text = ""
        PicPlaverName.Text = PlaverName
        'Записать в файл данное имя
        Using sw As StreamWriter = New StreamWriter(Path & "\" & "PlaverName.txt", False)
            sw.Write(PlaverName)
            sw.Close()
        End Using
    End Sub
    Private Sub СменаИмениToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles СменаИмениToolStripMenuItem.MouseMove
        ToolStripTextBox2.Text = PlaverName
    End Sub

    Private Sub РекордToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РекордToolStripMenuItem.Click
        Dim Path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Dim line, line1, line2 As String
        If File.Exists(Path & "\" & "Record.txt") Then
            'Фаил имеется
            Using sr2 As StreamReader = New StreamReader(Path & "\" & "Record.txt", True)
                line = sr2.ReadLine
                line1 = Mid(line, 1, Len(line) - 1) 'очки
                line2 = Mid(line, Len(line), 1) 'номер имени
                'В случае если занял 1 игрок
                If Val(line2) = 1 Then
                    If File.Exists(Path & "\" & "RecordNamePlaver.txt") Then
                        Using sr As StreamReader = New StreamReader(Path & "\" & "RecordNamePlaver.txt", True)
                            line2 = sr.ReadLine
                            sr.Close()
                        End Using
                    End If
                    line2 = PlaverName
                End If
                sr2.Close()
            End Using
            Select Case line2
                Case 2
                    line2 = "Спок"
                Case 3
                    line2 = "Мария"
                Case 4
                    line2 = "Алекс"
                    'Case 5
                    '    line2 = "Ирина"
                    'Case 6
                    '    line2 = "Джон"
            End Select
            MsgBox("Рекорд: " & line1 & " " & "очков, " & "достиг(ла) " & line2, MsgBoxStyle.OkOnly, "Рекорд")
        Else
            MsgBox("Еще ни кто не поставил рекорд", MsgBoxStyle.OkOnly, "Увы")
        End If
    End Sub

    Private Sub NewGamePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGamePic.Click

    End Sub
    Public Sub NewGame()
        StavkaPic.Visible = True
        StartPic.Visible = True
        StartPic.Image = My.Resources.V1
        PicActivCard.Visible = False
        Delta = 0
        ''Остановить все таймеры
        DialogTimer.Stop()
        StavkaSelector.Stop()
        PutCardselector.Stop()
        Zaderjka.Stop()
        Detector.Stop()
        ZaderjkaMini.Stop()
        'Обнулить счетчики очков
        MSEAinfo = ""
        For ttt As Integer = 1 To 4 : PlaverScore(ttt) = 0 : Next ttt
        Array.Clear(PlaversScores, 1, 144)        'Обнулить все взятки
        Clearing()
        Round = 1
        Round = ToolStripTextBox1.Text 'Убрать в полной версии!
        Opic0.Visible = True : Opic0.Image = My.Resources.Плюс
        Opic1.Visible = True : Opic1.Image = My.Resources.Ноль
        Opic2.Visible = True : Opic2.Image = My.Resources._2_отк
        Opic3.Visible = True : Opic3.Image = My.Resources._3_отк
        Opic4.Visible = True : Opic4.Image = My.Resources._4_отк
        TurPic.Visible = True
        Main()
    End Sub

    Private Sub NewGamePic_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NewGamePic.MouseDown
        'Пройгрыш звука
        If Sound Then
            SoundStart.Play()
        End If
        NewGame()
        NewGamePic.Visible = False
    End Sub



    Private Sub NewGamePic_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NewGamePic.MouseMove
        NewGamePic.Image = My.Resources.Кнопка_новая_играC
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub StartPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartPic.Click

    End Sub

    Private Sub DebugBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DebugBox_TextChanged_1(sender As Object, e As EventArgs) Handles DebugBox.TextChanged

    End Sub

    Private Sub TurPic_Click(sender As Object, e As EventArgs) Handles TurPic.Click
        DebugBox.Visible = True
        'Блок наблюдения значений__________________________________________________________________________________________
        DebugBox.Text = ""
        If NumberOfCards = 1 Then
            DebugBox.Text = DebugBox.Text & CardsPlavers(1, 1) & "_" & CardsPlavers(2, 1) & "_" & CardsPlavers(3, 1) & "_" & CardsPlavers(4, 1) & "_" & " Значение карт" & vbCrLf
            DebugBox.Text = DebugBox.Text & CardsPlaversPow(1, 1) & "_" & CardsPlaversPow(2, 1) & "_" & CardsPlaversPow(3, 1) & "_" & CardsPlaversPow(4, 1) & "_" & " Ценность карт" & vbCrLf
        Else

            For player As Integer = 1 To 4
                For playercard As Integer = 1 To NumberOfCards
                    DebugBox.Text = DebugBox.Text & "CardsPlavers(" & player & "," & playercard & ")=" & CardsPlavers(player, playercard) & vbCrLf

                Next playercard

            Next player


            For player As Integer = 1 To 4
                For playercard As Integer = 1 To NumberOfCards

                    DebugBox.Text = DebugBox.Text & "CardsPlaversPow(" & player & "," & playercard & ")=" & CardsPlavers(player, playercard) & vbCrLf
                Next playercard

            Next player

            DebugBox.Text = DebugBox.Text & "Trump =" & Trump & vbCrLf
        End If

        ShowDebag = True
        'Показ всех карт противника
        For prot As Integer = 1 To NumberOfCards
            If Not (prot1(prot).Visible = False) Then
                prot1(prot).Image = GetItem(CardsPlavers(2, prot))
                prot1(prot).Visible = True
            End If
            If Not (prot2(prot).Visible = False) Then
                prot2(prot).Image = GetItem(CardsPlavers(3, prot))
                prot2(prot).Visible = True
            End If
            If Not (prot3(prot).Visible = False) Then
                prot3(prot).Image = GetItem(CardsPlavers(4, prot))
                prot3(prot).Visible = True
            End If
        Next prot
    End Sub

    Private Sub PicActivCard_Click(sender As Object, e As EventArgs) Handles PicActivCard.Click

    End Sub


    Private Sub TurPic_DoubleClick(sender As Object, e As EventArgs) Handles TurPic.DoubleClick
        DebugBox.Visible = True
        'Блок наблюдения значений__________________________________________________________________________________________
        DebugBox.Text = ""
        If NumberOfCards = 1 Then
            DebugBox.Text = DebugBox.Text & CardsPlavers(1, 1) & "_" & CardsPlavers(2, 1) & "_" & CardsPlavers(3, 1) & "_" & CardsPlavers(4, 1) & "_" & " Значение карт" & vbCrLf
            DebugBox.Text = DebugBox.Text & CardsPlaversPow(1, 1) & "_" & CardsPlaversPow(2, 1) & "_" & CardsPlaversPow(3, 1) & "_" & CardsPlaversPow(4, 1) & "_" & " Ценность карт" & vbCrLf
        Else

            For player As Integer = 1 To 4
                For playercard As Integer = 1 To NumberOfCards
                    DebugBox.Text = DebugBox.Text & "CardsPlavers(" & player & "," & playercard & ")=" & CardsPlavers(player, playercard) & vbCrLf

                Next playercard

            Next player


            For player As Integer = 1 To 4
                For playercard As Integer = 1 To NumberOfCards

                    DebugBox.Text = DebugBox.Text & "CardsPlaversPow(" & player & "," & playercard & ")=" & CardsPlaversPow(player, playercard) & vbCrLf
                Next playercard

            Next player

            DebugBox.Text = DebugBox.Text & "Trump =" & Trump & vbCrLf
        End If

        ShowDebag = True
        'Показ всех карт противника
        For prot As Integer = 1 To NumberOfCards
            If Not (prot1(prot).Visible = False) Then
                prot1(prot).Image = GetItem(CardsPlavers(2, prot))
                prot1(prot).Visible = True
            End If
            If Not (prot2(prot).Visible = False) Then
                prot2(prot).Image = GetItem(CardsPlavers(3, prot))
                prot2(prot).Visible = True
            End If
            If Not (prot3(prot).Visible = False) Then
                prot3(prot).Image = GetItem(CardsPlavers(4, prot))
                prot3(prot).Visible = True
            End If
        Next prot
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Fon_Click(sender As Object, e As EventArgs) Handles Fon.Click

    End Sub
End Class