INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('�������������� ����������');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('�������������� ����������');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('�������');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('������� ����������');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('�����������');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('��������');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('����������� ����������');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('������ ���� ����������');

INSERT INTO libass.dbo.Books(NAME, YEAR, PRINTYEAR, AUTHOR, Typography, LiterType)
  VALUES ('����� ������ � ����������� ������', 2001, 2002, '����� �������', '������', 1);
INSERT INTO libass.dbo.Books(NAME, YEAR, PRINTYEAR, AUTHOR, Typography, LiterType)
  VALUES ('��� ����� �����', 2002, 2016, '��. ���� ���������', '���', 7);
INSERT INTO libass.dbo.Books(NAME, YEAR, PRINTYEAR, AUTHOR, Typography, LiterType)
  VALUES ('������� ������ � ������', 2017, 2017, '�. �. �����', '�����', 6);
INSERT INTO libass.dbo.Books(NAME, YEAR, PRINTYEAR, AUTHOR, Typography, LiterType)
  VALUES ('����� �������� ������', 1834, 2007, '�. �. ������', '�����', 1);

INSERT INTO libass.dbo.Points(NAME, IsReadRoom) VALUES ('��������� �1', 0);
INSERT INTO libass.dbo.Points(NAME, IsReadRoom) VALUES ('��������� �2', 0);
INSERT INTO libass.dbo.Points(NAME, IsReadRoom) VALUES ('��������� ��� �1', 1);

INSERT INTO libass.dbo.Cards(BookId, VOLUME, SUPPLY, PRICE, PointId, LOST)
  VALUES (
  (SELECT Id FROM libass.dbo.Books WHERE name='������� ������ � ������'), 3, '19.08.2017', 150,
  (SELECT Id FROM libass.dbo.Books WHERE name='��������� ��� �1'), 1);

INSERT INTO libass.dbo.Cards(BookId, VOLUME, SUPPLY, PRICE, PointId, LOST)
  VALUES (
  (SELECT Id FROM libass.dbo.Books WHERE name='����� ������ � ����������� ������'), 3, '15.02.2005', 400,
  (SELECT Id FROM libass.dbo.Books WHERE name='��������� �1'), 0);

INSERT INTO libass.dbo.Cards(BookId, VOLUME, SUPPLY, PRICE, PointId, LOST)
  VALUES (
  (SELECT Id FROM libass.dbo.Books WHERE name='��� ����� �����'), 3, '25.01.2017', 600,
  (SELECT Id FROM libass.dbo.Books WHERE name='��������� �2'), 0);

INSERT INTO libass.dbo.Cards(BookId, VOLUME, SUPPLY, PRICE, PointId, LOST)
  VALUES (
  (SELECT Id FROM libass.dbo.Books WHERE name='����� �������� ������'), 7, '20.07.2017', 100,
  (SELECT Id FROM libass.dbo.Books WHERE name='��������� �1'), 0);

INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('�������', '���������', '���������', '26.08.2018');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('������', '���������', '������������', '26.08.2018');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG, QUIT)
  VALUES ('�����������', '������', '����������', '25.08.2014', '11.01.2017');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('�������', '������', '���������', '12.06.1991');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('������', '���������', '����������', '22.06.2000');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG, QUIT)
  VALUES ('���������', '�����', '����������', '25.06.2001', '09.08.2015');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('��������', '�������', '����������', '02.07.1990');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('������', '�����', '�����������', '12.06.2000');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG, QUIT)
  VALUES ('������', '���', '����������', '18.09.2015', '12.02.2020');

INSERT INTO libass.dbo.Records(ReaderId, CardId, GAVE, _RETURN, RETURNED) VALUES (
	(SELECT Id FROM libass.dbo.Readers WHERE SURNAME='������'), 3, '14.12.2017', '11.01.2018', '09.01.2017');
INSERT INTO libass.dbo.Records(ReaderId, CardId, GAVE, _RETURN, RETURNED) VALUES (
	(SELECT Id FROM libass.dbo.Readers WHERE SURNAME='�����������'), 2, '08.12.2016', '08.01.2016', '10.01.2016');
INSERT INTO libass.dbo.Records(ReaderId, CardId, GAVE, _RETURN) VALUES (
	(SELECT Id FROM libass.dbo.Readers WHERE SURNAME='������'), 1, '02.05.2019', '02.06.2019');
INSERT INTO libass.dbo.Records(ReaderId, CardId, GAVE, _RETURN, RETURNED) VALUES (
	(SELECT Id FROM libass.dbo.Readers WHERE SURNAME='������'), 2, '05.03.2020', '05.04.2020', '14.05.2021');
INSERT INTO libass.dbo.Records(ReaderId, CardId, GAVE, _RETURN, RETURNED) VALUES (
	(SELECT Id FROM libass.dbo.Readers WHERE SURNAME='�����������'), 4, '28.09.2021', '28.10.2021', '23.10.2021');
