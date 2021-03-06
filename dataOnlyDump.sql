USE [DBProject]
GO
INSERT [dbo].[StanyNapraw] ([stan]) VALUES (N'Gotowa')
INSERT [dbo].[StanyNapraw] ([stan]) VALUES (N'W trakcie')
INSERT [dbo].[StanyUsterek] ([stan]) VALUES (N'Realizowana')
INSERT [dbo].[StanyUsterek] ([stan]) VALUES (N'Rozpatrzona')
INSERT [dbo].[StanyUsterek] ([stan]) VALUES (N'Zakonczona')
INSERT [dbo].[StanyUsterek] ([stan]) VALUES (N'Zgloszona')
INSERT [dbo].[StanyUsterek] ([stan]) VALUES (N'Zlecona')
SET IDENTITY_INSERT [dbo].[Budynki] ON 

INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (1, N'Konarskiego 11')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (2, N'Konarskiego 12')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (3, N'Konarskiego 13')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (4, N'Wniebowstąpienia 23')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (5, N'Wniebowstąpienia 24')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (6, N'Armii Krajowej 2')
INSERT [dbo].[Budynki] ([id_budynku], [adres_budynku]) VALUES (7, N'Armii Krajowej 3')
SET IDENTITY_INSERT [dbo].[Budynki] OFF
SET IDENTITY_INSERT [dbo].[Mieszkania] ON 

INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (1, 1, 1, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (2, 1, 2, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (3, 1, 3, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (4, 1, 4, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (5, 1, 5, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (6, 1, 6, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (7, 1, 7, 24, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (8, 1, 8, 22, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (9, 1, 9, 26, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (10, 1, 10, 54, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (11, 1, 11, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (12, 1, 12, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (13, 1, 13, 55, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (14, 2, 14, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (15, 2, 15, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (16, 2, 16, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (17, 2, 17, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (18, 2, 18, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (19, 2, 19, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (20, 2, 20, 24, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (21, 2, 21, 22, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (22, 2, 22, 26, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (23, 2, 23, 54, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (24, 2, 24, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (25, 2, 25, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (26, 2, 26, 55, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (27, 3, 27, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (28, 3, 28, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (29, 3, 29, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (30, 3, 30, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (31, 3, 31, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (32, 3, 32, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (33, 3, 33, 24, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (34, 3, 34, 22, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (35, 3, 35, 26, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (36, 3, 36, 54, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (37, 3, 37, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (38, 3, 38, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (39, 3, 39, 55, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (40, 4, 1, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (41, 4, 2, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (42, 4, 3, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (43, 4, 4, 30, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (44, 4, 5, 30, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (45, 4, 6, 30, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (46, 5, 7, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (47, 5, 8, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (48, 5, 9, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (49, 5, 10, 30, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (50, 5, 11, 35, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (51, 5, 12, 35, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (52, 6, 1, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (53, 6, 2, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (54, 6, 3, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (55, 6, 4, 35, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (56, 6, 5, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (57, 6, 6, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (58, 7, 7, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (59, 7, 8, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (60, 7, 9, 25, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (61, 7, 10, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (62, 7, 11, 45, NULL)
INSERT [dbo].[Mieszkania] ([id_mieszkania], [id_budynku], [numer], [metraz], [opis]) VALUES (63, 7, 12, 45, NULL)
SET IDENTITY_INSERT [dbo].[Mieszkania] OFF
SET IDENTITY_INSERT [dbo].[Usterki] ON 

INSERT [dbo].[Usterki] ([id_usterki], [id_mieszkania], [opis], [stan]) VALUES (1, 56, N'Przebita rura kanalizacyjna', N'Zgloszona')
INSERT [dbo].[Usterki] ([id_usterki], [id_mieszkania], [opis], [stan]) VALUES (2, 58, N'Brak prądu', N'Realizowana')
INSERT [dbo].[Usterki] ([id_usterki], [id_mieszkania], [opis], [stan]) VALUES (3, 51, N'Nieszczelne okno', N'Zlecona')
INSERT [dbo].[Usterki] ([id_usterki], [id_mieszkania], [opis], [stan]) VALUES (4, 56, N'Urwała się lampa i  wisi 20 centymetrów nad ziemią, uniemożliwiając psu swobodne przemieszczanie się tam i ówdzie', N'Zlecona')
INSERT [dbo].[Usterki] ([id_usterki], [id_mieszkania], [opis], [stan]) VALUES (5, 57, N'Wyrwało toaletę z zamocowania', N'Rozpatrzona')
SET IDENTITY_INSERT [dbo].[Usterki] OFF
SET IDENTITY_INSERT [dbo].[Firmy] ON 

INSERT [dbo].[Firmy] ([id_firmy], [NIP], [nr_telefonu], [nazwa_firmy]) VALUES (1, N'0000000000', N'000000000', N'DIM')
INSERT [dbo].[Firmy] ([id_firmy], [NIP], [nr_telefonu], [nazwa_firmy]) VALUES (2, N'0000000001', N'000000001', N'DIMA')
INSERT [dbo].[Firmy] ([id_firmy], [NIP], [nr_telefonu], [nazwa_firmy]) VALUES (3, N'0000000002', N'000000002', N'ANIMA')
INSERT [dbo].[Firmy] ([id_firmy], [NIP], [nr_telefonu], [nazwa_firmy]) VALUES (4, N'0000000003', N'000000003', N'LIBERA')
SET IDENTITY_INSERT [dbo].[Firmy] OFF
SET IDENTITY_INSERT [dbo].[Naprawy] ON 

INSERT [dbo].[Naprawy] ([id_naprawy], [id_usterki], [id_firmy], [nr_telefonu], [stan], [data_zlecenia], [data_rozpoczecia], [data_ukonczenia]) VALUES (1, 2, 1, N'000000000', N'W trakcie', CAST(N'2019-05-01T14:09:29.350' AS DateTime), NULL, NULL)
INSERT [dbo].[Naprawy] ([id_naprawy], [id_usterki], [id_firmy], [nr_telefonu], [stan], [data_zlecenia], [data_rozpoczecia], [data_ukonczenia]) VALUES (2, 3, 2, N'000000001', N'W trakcie', CAST(N'2019-05-01T14:09:29.350' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Naprawy] OFF
SET IDENTITY_INSERT [dbo].[Dozorcy] ON 

INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (1, N'000000000', N'Jan', N'Kozuchowski', N'00000000000')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (2, N'000000001', N'Zbigniew', N'Matuskełkowski', N'00000000001')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (3, N'000000002', N'Janusz', N'Pietrkowski', N'00000000002')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (4, N'000000003', N'Bolesław', N'Jagódkowski', N'00000000003')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (5, N'000000004', N'Marian', N'Krzaczek', N'00000000004')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (6, N'000000005', N'Donald', N'Kfakowski', N'00000000005')
INSERT [dbo].[Dozorcy] ([id_dozorcy], [nr_telefonu], [Imie], [Nazwisko], [PESEL]) VALUES (7, N'000000006', N'Michał', N'Ledwoński', N'00000000006')
SET IDENTITY_INSERT [dbo].[Dozorcy] OFF
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 1, 1)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 2, 2)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 3, 3)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 4, 4)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 5, 5)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 6, 6)
INSERT [dbo].[Dozorowania] ([data_rozpoczecia], [data_zakonczenia], [id_dozorcy], [id_budynku]) VALUES (CAST(N'2019-05-01T14:09:29.287' AS DateTime), NULL, 7, 7)
SET IDENTITY_INSERT [dbo].[Najemcy] ON 

INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (1, N'000000010', N'Janina', N'Kozuchowska', N'00000000010')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (2, N'000000011', N'Zbigniewa', N'Matuskełkowska', N'00000000011')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (3, N'000000012', N'Janusza', N'Pietrkowska', N'00000000012')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (4, N'000000013', N'Bolesława', N'Jagódkowska', N'00000000013')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (5, N'000000014', N'Marianna', N'Krzaczek', N'00000000014')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (6, N'000000015', N'Donalda', N'Kfakowska', N'00000000015')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (7, N'000000016', N'Michalina', N'Ledwońska', N'00000000016')
INSERT [dbo].[Najemcy] ([id_najemcy], [nr_telefonu], [imie], [nazwisko], [PESEL]) VALUES (8, N'123456789', N'Kartofel', N'Ziemniak', N'12345678901')
SET IDENTITY_INSERT [dbo].[Najemcy] OFF
SET IDENTITY_INSERT [dbo].[Wynajmy] ON 

INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (1, 1, CAST(N'1913-05-01T14:09:29.357' AS DateTime), CAST(N'2077-05-01T14:09:29.357' AS DateTime), 1, 122)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (2, 2, NULL, NULL, 2, 110)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (3, 3, NULL, NULL, 3, 120)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (4, 4, NULL, NULL, 4, 130)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (5, 5, NULL, NULL, 5, 140)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (6, 6, NULL, NULL, 6, 150)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (7, 7, NULL, NULL, 7, 160)
INSERT [dbo].[Wynajmy] ([id_wynajmu], [id_mieszkania], [data_rozpoczecia], [data_zakonczenia], [id_najemcy], [cena_miesieczna]) VALUES (8, 10, NULL, NULL, 1, 130)
SET IDENTITY_INSERT [dbo].[Wynajmy] OFF
SET IDENTITY_INSERT [dbo].[FakturyNapraw] ON 

INSERT [dbo].[FakturyNapraw] ([id_faktury], [id_naprawy], [cena], [numer_faktury], [data_platnosci]) VALUES (1, 2, 2000, 321232123, CAST(N'2019-05-01T14:09:29.357' AS DateTime))
INSERT [dbo].[FakturyNapraw] ([id_faktury], [id_naprawy], [cena], [numer_faktury], [data_platnosci]) VALUES (2, 1, 2000, 321232124, CAST(N'2019-05-01T14:09:29.363' AS DateTime))
INSERT [dbo].[FakturyNapraw] ([id_faktury], [id_naprawy], [cena], [numer_faktury], [data_platnosci]) VALUES (3, 2, 2004, 321232125, CAST(N'2019-05-01T14:09:29.363' AS DateTime))
SET IDENTITY_INSERT [dbo].[FakturyNapraw] OFF
SET IDENTITY_INSERT [dbo].[FakturyWynajem] ON 

INSERT [dbo].[FakturyWynajem] ([id_faktury], [id_wynajem], [cena], [numer_faktury], [data_platnosci]) VALUES (2, 1, 12, 12, CAST(N'2019-02-04T03:13:03.000' AS DateTime))
INSERT [dbo].[FakturyWynajem] ([id_faktury], [id_wynajem], [cena], [numer_faktury], [data_platnosci]) VALUES (5, 7, 32, 1, CAST(N'1987-12-13T21:03:01.000' AS DateTime))
INSERT [dbo].[FakturyWynajem] ([id_faktury], [id_wynajem], [cena], [numer_faktury], [data_platnosci]) VALUES (1002, 1, 677, 3, CAST(N'1999-07-31T02:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[FakturyWynajem] OFF
SET IDENTITY_INSERT [dbo].[Platnosci] ON 

INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (1, 1, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 80, N'Marzec. Sorki, że tak mało, ale mnie nie stać')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (2, 2, CAST(N'2019-05-01T14:09:29.000' AS DateTime), 150, N'Marzec i zaległość za luty')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (3, 3, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 120, N'Marzec Yolo')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (4, 4, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 130, N'Płatność za luty, marzec lleci następnym przelewem')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (5, 5, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 140, N'Marzec elo')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (6, 6, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 150, N'Marzec elo')
INSERT [dbo].[Platnosci] ([id_platnosci], [id_wynajmu], [data_platnosci], [cena], [tytul]) VALUES (7, 7, CAST(N'2019-05-01T14:09:29.380' AS DateTime), 160, N'Marzec trolololo')
SET IDENTITY_INSERT [dbo].[Platnosci] OFF
