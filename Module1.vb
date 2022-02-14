'Imports DX = Microsoft.DirectX
'Imports Microsoft.DirectX.DirectSound
'Imports Buffer = Microsoft.DirectX.DirectSound.SecondaryBuffer
'Imports Device = Microsoft.DirectX.DirectSound.DeviceisPlaverBid
Module Module1
    'Public tt As Integer' Public Plaver1_stavka As Integer = 0'Public sound1, sound2, sound3, sound4, sound5, sound6 As Buffer Public Proverka As Integer  Public S1, S2, S3, S4, S5, S6 As Integer

    'Активная карта-это та карта которая зашла первая
    Public Igrok(6), cb(36), prot1(6), prot2(6), prot3(6), CardsTable(6) As PictureBox 'Массивы обьектов
    Public RndDeck(36) As Integer                'Массив колоды карт
    Public RndTableLocation(4) As Integer        'Массив для случайного размешения карт
    Public StartArray(9, 4) As Integer           'Начальный игровой массив всех карт 
    Public Round As Integer                      'Селектор раундов
    Public Trump As Integer                      'Номер козырной карты(Главный козырь валет бубновый=24)
    Public Bid As Integer = 0                    'Ставка первого игрока(человек)
    Public MoveCards1, MoveCards2, MoveCards3, MoveCards4, MoveCards5, MoveCards6 As Boolean 'Факт движения карт


    Public BidPlavers(4) As Integer             'Массив ставок всех игроков
    Public NumberOfCards As Integer             'Начальное колличество карт у игрока на руках(любого) (порт NumberOfGeoms )
    Public AllCardsCount As Integer             'Общее колличество карт у всех игроков на руках
    Public FirstRightMove As Integer            'Начальное значение права хода
    Public RightToMove As Integer               'Значение права хода(кому принадлежит текуший ход)
    Public RightOfBid As Integer                'Значение права ставки

    Public CardsPlavers(4, 6) As Integer        'Массив значений карт(Игрок,Номер карты)
    Public CardsPlaversPow(4, 6) As Integer     'Массив ценности карт(Игрок,Номер карты)
    Public PlaversScores(4, 28) As Integer      'Массив очков игроков(Игрок,Тур)
    Public SpentCards(4, 6) As Integer          'Массив контроля отработанных карт(Игрок,Номер карты)
    Public CurentSelectCard As Integer          'Номер выбранной карты человека
    Public ActiveCard As Integer                'Номер активной карты
    Public SelectedCard As Integer              'Выбранная карта игроков
    Public IsActiveCard As Boolean              'есть ли активная карта(когда ее нету значит игрок делает первый заход картой)

    Public isDiscard As Boolean = False         'разрешение сброса карты(также участвует в логике)
    Public isTrampOver As Integer = False       'был ли козырный валет побит/не побит(False не побит) для безкозырки
    Public isPlaverBid As Boolean = False       'Состояние фиксации ставки первого игрока(человека)
    Public isRightOfFirst As Boolean = False    'Право первого(когда true то логика ставки меняется на более смелые ставки)

    Public CardsPlaversTablePow(4) As Integer    'Массив ценности карт на столе(Игрок)
    Public CheckFull As Integer = 0              'счетчик массива CardsPlaversStolPow

    Public AnalizCards(6) As Integer            'Порядковый номер анализируемых карт
    Public AnalizCardsKoz(6) As Integer         'Порядковый номер анализируемых карт козырей
    Public Sound As Boolean                     'вкл и выкл звука
    Public ShowDebag As Boolean = False         'Дебаг(Показ всех карт противника)
    Public Const Speed As Integer = 50          'Скорость переключения очков в конце
    Public SpeedRasclad As Integer = 500        'Скорость игры(расклад карт)
    Public SpeedStavka As Integer = 500         'Интервал ставки   

    Public Delta As Short                       'Счетчик колличества выполнивших ставку
    Public PlaverName As String                 'Имя 1 игрока
    Public CleanPath(6) As Integer              'Массив бонуса чистый путь
    Public PlaverScore(4) As Integer            'Счетчик очков игроков(Игрок)
    Public MSEAinfo As String                   'Подсчет очков
    Public SpeedChangeMiniTur As Integer = 1500 'Скорость расклада в мини туре
    Public SpeedChangeTur As Integer = 2500     'Скорость при смене тура
    Public PlaverNameRecord As Integer          'Рекорд игрока



    Public Function GetItem(ByVal Karta As Integer) As System.Drawing.Image
        Dim Res As System.Drawing.Image = Nothing
        Select Case Karta
            Case 1 : Res = My.Resources._6_пик
            Case 2 : Res = My.Resources._6_крести
            Case 3 : Res = My.Resources._6_чирва
            Case 4 : Res = My.Resources._6_буби
            Case 5 : Res = My.Resources._7_пик
            Case 6 : Res = My.Resources._7_крести
            Case 7 : Res = My.Resources._7_чирва
            Case 8 : Res = My.Resources._7_буба
            Case 9 : Res = My.Resources._8_пик
            Case 10 : Res = My.Resources._8_крести
            Case 11 : Res = My.Resources._8_чирва
            Case 12 : Res = My.Resources._8_буба
            Case 13 : Res = My.Resources._9_пик
            Case 14 : Res = My.Resources._9_крести
            Case 15 : Res = My.Resources._9_чирва
            Case 16 : Res = My.Resources._9_буба
            Case 17 : Res = My.Resources._10_пик
            Case 18 : Res = My.Resources._10_крести
            Case 19 : Res = My.Resources._10_чирва
            Case 20 : Res = My.Resources._10_буби
            Case 21 : Res = My.Resources.Валет_пика
            Case 22 : Res = My.Resources.Валет_крести
            Case 23 : Res = My.Resources.Валет_чирва
            Case 24 : Res = My.Resources.Валет_бубны
            Case 25 : Res = My.Resources.Дама_пика
            Case 26 : Res = My.Resources.Дама_крести
            Case 27 : Res = My.Resources.Дама_чирва
            Case 28 : Res = My.Resources.Дама_бубны
            Case 29 : Res = My.Resources.Король_пик
            Case 30 : Res = My.Resources.Король_крести
            Case 31 : Res = My.Resources.Король_чирва
            Case 32 : Res = My.Resources.Король_бубны
            Case 33 : Res = My.Resources.Туз_пик
            Case 34 : Res = My.Resources.Туз_крести
            Case 35 : Res = My.Resources.Туз_чирва
            Case 36 : Res = My.Resources.Туз_буби
        End Select
        Return Res
    End Function
    'Раскладывает колоду
    Sub ShowDeck()
        For t As Integer = 1 To 36
            cb(t).Top = 4
            cb(t).Left = 15 + (t - 0.5)
            cb(t).Image = My.Resources.Рубашка_Биг
            cb(t).Visible = True
        Next t
    End Sub
    'Обьявление массива случайных чисел
    Sub InitDeckArray()
        Dim Random, F As Integer
        For w As Integer = 1 To 36

START:
            Random = Int((36 * Rnd()) + 1)
            'Проверка:а нет ли такого же числа в массиве?
            For d = 1 To 36
                If RndDeck(d) = Random Then
                    GoTo START
                    Exit For
                End If


            Next d
            F = F + 1
            RndDeck(F) = Random
        Next w
        'Select Case Tur
        '    Case 1
        '        RndRad(30) = 24
        '    Case 2
        '        RndRad(24) = 24
        '    Case 3
        '        RndRad(18) = 24
        '    Case 4
        '        RndRad(12) = 24
        '    Case 5
        '        RndRad(6) = 24
        'End Select

    End Sub
    Sub MainMasiv()
        Dim i As Integer
        For a As Integer = 1 To 9
            For b As Integer = 1 To 4
                i = i + 1
                StartArray(a, b) = i
            Next b
        Next a
    End Sub
    Sub SetRandomPlaceArray()
        Dim Random2, F1 As Integer
        Array.Clear(RndTableLocation, 1, 4)
        For w2 As Integer = 1 To 4
START:
            Random2 = Int((4 * Rnd()) + 1)
            'Проверка:а нет ли такого же числа в массиве?
            For d2 = 1 To 4
                If RndTableLocation(d2) = Random2 Then GoTo START
            Next d2
            F1 = F1 + 1
            RndTableLocation(F1) = Random2
        Next w2
    End Sub
    Public Function GetTrumpColumn()
        result = Trump Mod 4
        If result = 0 Then result = 1
        Return result

    End Function

    Public Function GetActiveCardColumn()
        result = ActiveCard Mod 4
        If result = 0 Then result = 1
        Return result

    End Function

    'Функция отдачи нижнего порога ставки
    Public Function GetLowPower() As Integer

        If isRightOfFirst = True Then ' только для игрока с правом первого хода

            If Trump = 24 Or (Round >= 6 And Round <= 11) Then 'Ставка в безкозырке или когда козырный валет буби
                Select Case NumberOfCards
                    Case 1 : Return 7
                    Case 2 : Return 10
                    Case 3 : Return 10
                    Case 4 : Return 11
                    Case 5 : Return 13 'Ставка только с Короля и выше 
                    Case 6 : Return 13
                End Select
                Return 0
            Else 'Ставки в остальных играх
                Select Case NumberOfCards
                    Case 1 : Return 11  'Ставка только c Дамы и выше
                    Case 2 : Return 11
                    Case 3 : Return 11
                    Case 4 : Return 13
                    Case 5 : Return 13
                End Select
                Return 0
            End If

        Else 'При заходе с карт "без права первого хода"

            If Trump = 24 Or (Round >= 6 And Round <= 11) Then 'Ставка в безкозырке или когда козырный валет буби
                Select Case NumberOfCards
                    Case 1 : Return 7 'Ставка  с семерки
                    Case 2 : Return 11
                    Case 3 : Return 11 'Ставка с Вольта
                    Case 4 : Return 13
                    Case 5 : Return 13 'Ставка только с Короля и выше 
                    Case 6 : Return 13
                End Select
                Return 0
            Else 'Ставки в остальных играх
                Select Case NumberOfCards
                    Case 1 : Return 12  'Ставка только c Дамы и выше
                    Case 2 : Return 12
                    Case 3 : Return 12
                    Case 4 : Return 13
                    Case 5 : Return 13
                End Select
                Return 0
            End If

        End If


    End Function


    'Public Function RNDM(ByVal C1 As Integer, ByVal C2 As Integer, ByVal SH As Integer) As Boolean
    '    'Функция RNDM задает и выводит вероятность выпода SH
    '    Dim Mass(), ZCH As Integer
    '    ReDim Mass(C2)
    '    For ff As Integer = 1 To C2 - C1
    '        Mass(ff) = 0
    '    Next ff
    '    For ff2 As Integer = (C2 - C1) + 1 To UBound(Mass)
    '        Mass(ff2) = SH
    '    Next ff2
    '    ZCH = Int((C2 * Rnd) + 1)
    '    If Mass(ZCH) = SH Then
    '        RNDM = True
    '    Else
    '        RNDM = False
    '    End If
    'End Function

End Module
