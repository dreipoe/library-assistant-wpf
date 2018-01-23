INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('Художественная литература');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('Документальная литература');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('Мемуары');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('Научная литература');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('Справочники');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('Учебники');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('Техническая литература');
INSERT INTO libass.dbo.LiterTypes(NAME) VALUES ('Другие типы литературы');

INSERT INTO libass.dbo.Books(NAME, YEAR, PRINTYEAR, AUTHOR, Typography, LiterType)
  VALUES ('Гарри Поттер и Философский камень', 2001, 2002, 'Джоан Роулинг', 'Росмэн', 1);
INSERT INTO libass.dbo.Books(NAME, YEAR, PRINTYEAR, AUTHOR, Typography, LiterType)
  VALUES ('Как пасти котов', 2002, 2016, 'Дж. Ханк Рейнвотер', 'АСТ', 7);
INSERT INTO libass.dbo.Books(NAME, YEAR, PRINTYEAR, AUTHOR, Typography, LiterType)
  VALUES ('История России в схемах', 2017, 2017, 'А. С. Орлов', 'Эксмо', 6);
INSERT INTO libass.dbo.Books(NAME, YEAR, PRINTYEAR, AUTHOR, Typography, LiterType)
  VALUES ('Песни западных славян', 1834, 2007, 'А. С. Пушкин', 'Эксмо', 1);

INSERT INTO libass.dbo.Points(NAME, IsReadRoom) VALUES ('Абонемент №1', 0);
INSERT INTO libass.dbo.Points(NAME, IsReadRoom) VALUES ('Абонемент №2', 0);
INSERT INTO libass.dbo.Points(NAME, IsReadRoom) VALUES ('Читальный зал №1', 1);

INSERT INTO libass.dbo.Cards(BookId, VOLUME, SUPPLY, PRICE, PointId, LOST)
  VALUES (
  (SELECT Id FROM libass.dbo.Books WHERE name='История России в схемах'), 3, '19.08.2017', 150,
  (SELECT Id FROM libass.dbo.Books WHERE name='Читальный зал №1'), 1);

INSERT INTO libass.dbo.Cards(BookId, VOLUME, SUPPLY, PRICE, PointId, LOST)
  VALUES (
  (SELECT Id FROM libass.dbo.Books WHERE name='Гарри Поттер и Философский камень'), 3, '15.02.2005', 400,
  (SELECT Id FROM libass.dbo.Books WHERE name='Абонемент №1'), 0);

INSERT INTO libass.dbo.Cards(BookId, VOLUME, SUPPLY, PRICE, PointId, LOST)
  VALUES (
  (SELECT Id FROM libass.dbo.Books WHERE name='Как пасти котов'), 3, '25.01.2017', 600,
  (SELECT Id FROM libass.dbo.Books WHERE name='Абонемент №2'), 0);

INSERT INTO libass.dbo.Cards(BookId, VOLUME, SUPPLY, PRICE, PointId, LOST)
  VALUES (
  (SELECT Id FROM libass.dbo.Books WHERE name='Песни западных славян'), 7, '20.07.2017', 100,
  (SELECT Id FROM libass.dbo.Books WHERE name='Абонемент №1'), 0);

INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('Орешкин', 'Александр', 'Андреевич', '26.08.2018');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('Батуев', 'Александр', 'Вячеславович', '26.08.2018');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG, QUIT)
  VALUES ('Домбровская', 'Полина', 'Михайловна', '25.08.2014', '11.01.2017');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('Цветков', 'Максим', 'Матвеевич', '12.06.1991');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('Быкова', 'Маргарита', 'Дмитрьевна', '22.06.2000');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG, QUIT)
  VALUES ('Харитонов', 'Игорь', 'Лукьянович', '25.06.2001', '09.08.2015');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('Камалова', 'Зинаида', 'Родионовна', '02.07.1990');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG)
  VALUES ('Маслов', 'Назар', 'Казимирович', '12.06.2000');
INSERT INTO libass.dbo.Readers(SURNAME, NAME, PATRONYM, REG, QUIT)
  VALUES ('Опокин', 'Лев', 'Самсонович', '18.09.2015', '12.02.2020');

INSERT INTO libass.dbo.Records(ReaderId, CardId, GAVE, _RETURN, RETURNED) VALUES (
	(SELECT Id FROM libass.dbo.Readers WHERE SURNAME='Быкова'), 3, '14.12.2017', '11.01.2018', '09.01.2017');
INSERT INTO libass.dbo.Records(ReaderId, CardId, GAVE, _RETURN, RETURNED) VALUES (
	(SELECT Id FROM libass.dbo.Readers WHERE SURNAME='Домбровская'), 2, '08.12.2016', '08.01.2016', '10.01.2016');
INSERT INTO libass.dbo.Records(ReaderId, CardId, GAVE, _RETURN) VALUES (
	(SELECT Id FROM libass.dbo.Readers WHERE SURNAME='Батуев'), 1, '02.05.2019', '02.06.2019');
INSERT INTO libass.dbo.Records(ReaderId, CardId, GAVE, _RETURN, RETURNED) VALUES (
	(SELECT Id FROM libass.dbo.Readers WHERE SURNAME='Батуев'), 2, '05.03.2020', '05.04.2020', '14.05.2021');
INSERT INTO libass.dbo.Records(ReaderId, CardId, GAVE, _RETURN, RETURNED) VALUES (
	(SELECT Id FROM libass.dbo.Readers WHERE SURNAME='Домбровская'), 4, '28.09.2021', '28.10.2021', '23.10.2021');
