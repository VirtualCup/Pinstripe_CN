player_move = (((Player_move)GameObject.Find("player").GetComponent(typeof(Player_move))) as Player_move);
string @string = player_move.saveData.GetString("Language");
if (!(@string == "English"))
{
	if (@string == "Russian")
	{
		Debug.Log("Russian Language Set!");
		trainDoorButton1 = new string[1]
		{
			"Кнопка..."
		};
		wifeIntro = new string[2]
		{
			"Тедди...",
			"Мне надо сказать тебе кое-что..."
		};
		bo1 = new string[6]
		{
			"Проснись, папа!",
			"Ты снова ходил во сне...",
			"Эй! Чуешь этот запах?",
			"Пойдем проверим.",
			"Ты будешь Шерлоком...",
			"Глупенький!"
		};
		bo1Choice1 = new string[5]
		{
			string.Empty,
			"Прости, милая.",
			string.Empty,
			string.Empty,
			"OK."
		};
		bo1Choice2 = new string[5]
		{
			"Ох... что?",
			"Нет, я не ходил.",
			"Да.",
			string.Empty,
			"Угадал, Ватсон!"
		};
		trainDoorButtonBo = new string[2]
		{
			"Шерлок!",
			"Думаю, я дотянусь до этой кнопки!"
		};
		trainDoorButtonBoChoice1 = new string[3]
		{
			"Ватсон?",
			string.Empty,
			string.Empty
		};
		trainDoorButtonBoChoice2 = new string[2]
		{
			string.Empty,
			"Хорошо... Побудь здесь!"
		};
		lockedTrainDoor = new string[1]
		{
			"Закрыто..."
		};
		sackSpitExplainer = new string[3]
		{
			"Что это, папа?",
			"Похоже на замерзшую каплю...",
			"Масла?"
		};
		mirror = new string[7]
		{
			"Это зеркало, Шерлок!",
			"Оно такое грязное, что я еле вижу твое лицо.",
			"Стра-а-а-шно...",
			"Ха! Посмотри на нас, пап, мы похожи на двух смешных приведений...",
			"Бум!",
			"А, точно...",
			"Бух!"
		};
		mirrorChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Пойдем."
		};
		mirrorChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Правильно «Бу», милая"
		};
		mirror2 = new string[6]
		{
			"Свет мой, зеркальце, скажи...",
			"Кто на свете всех милее, всех румяней и...",
			".......................",
			".......................",
			"Папа, какое слово рифмуется с «милее»?",
			"Кто на свете всех милее, всех румяней и белее!"
		};
		mirror2Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Пойдем."
		};
		mirror2Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"«Белее»."
		};
		boTrainBar = new string[5]
		{
			"Папа, мы можем выбраться отсюда?",
			"Здесь пахнет какашками...",
			"Прости...",
			"Здесь пахнет...",
			"Ка-ка..."
		};
		boTrainBarChoice1 = new string[4]
		{
			string.Empty,
			"Конечно.",
			string.Empty,
			string.Empty
		};
		boTrainBarChoice2 = new string[5]
		{
			string.Empty,
			"Не выражайся!",
			string.Empty,
			string.Empty,
			"Бо!"
		};
		boJumpingBean = new string[8]
		{
			"Ты похож на прыгающий боб, Шерлок.",
			"«Прыгай, прыгай, боб-прыгун, не хромец и не горбун.",
			"Прыг-прыг, прыг-скок.",
			"Крошка-попрыгун, топ-топ».",
			"Мне очень нравится этот мультик.",
			"Он такой глупый...",
			"Не знала, что тебе он тоже нравился, Шерлок!",
			"Я думала, что ты любишь только курить трубку и расследовать убийства!"
		};
		boJumpingBeanChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK"
		};
		boJumpingBeanChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Мне тоже!"
		};
		boTrainButtonSolution = new string[4]
		{
			"Не хочу показаться невежливой...",
			"Но... ты понимаешь, что делаешь?",
			"Я рада, что мы ведем расследование вместе, Шерлок!",
			"Просто нажми на кнопки, когда они обе загорятся желтым!"
		};
		boTrainButtonSolutionChoice1 = new string[4]
		{
			string.Empty,
			"Конечно!",
			string.Empty,
			string.Empty
		};
		boTrainButtonSolutionChoice2 = new string[4]
		{
			string.Empty,
			"Не очень...",
			string.Empty,
			"Отлично придумано, Ватсон!"
		};
		bo2 = new string[1]
		{
			"Папа, смотри, шарик!"
		};
		bo2Choice1 = new string[1]
		{
			string.Empty
		};
		bo2Choice2 = new string[1]
		{
			"Бо, стой!"
		};
		bo3 = new string[3]
		{
			"Бедный Джорджи...",
			".........................................................",
			"Он совсем заперт в своей коробке..."
		};
		bo3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bo3Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"ОК."
		};
		bo32 = new string[3]
		{
			"...................",
			"Он может учуять запах чипсов на твоей куртке...",
			"Не думаю, что нужно так его мучить..."
		};
		bo33 = new string[3]
		{
			".......................",
			"Джорджи любит чипсы «Львиное сердце» из лавки Мартина, с беконом...",
			"И если у тебя их нет, то тогда тебе стоит вернуться к заданию, мистер..."
		};
		pinstripeTrain1 = new string[7]
		{
			"Доброе утро, Тед...",
			"А это кто у нас тут?",
			"Привет, Бо...",
			"Ты любишь шарики?",
			"Как насчет красивого черного шарика?",
			"Просто друг...",
			"С красивым черным шариком..."
		};
		pinstripeTrain1Choice1 = new string[7]
		{
			"М-м...",
			string.Empty,
			string.Empty,
			string.Empty,
			"Хорошо...",
			string.Empty,
			string.Empty
		};
		pinstripeTrain1Choice2 = new string[7]
		{
			"Доброе утро?",
			"М-м... Это Бо.",
			string.Empty,
			string.Empty,
			"Кто вы?",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2 = new string[4]
		{
			"Да, и Бо...",
			"Чудесное платье...",
			"А-а... Это не очень вежливо...",
			"Бо, твой папа такой грубиян..."
		};
		pinstripeTrain2Choice1 = new string[4]
		{
			string.Empty,
			"Пойдем, Бо...",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2Choice2 = new string[4]
		{
			string.Empty,
			"Оставь нас в покое, мерзавец.",
			string.Empty,
			"Пойдем, Бо."
		};
		pinstripeHanglyPass = new string[10]
		{
			"Привет, Тед...",
			"А-а-а... Ты заручился помощью этого вонючего пройдохи Дики, чтобы он помог тебе найти Бо...",
			"Что-то подсказывает мне, что бедная старая спина Дики такая же сильная...",
			"...как у глупой деревянной куклы...",
			"Так что, полагаю, Бо проведет какое-то время в моем маленьком приходе...",
			"Да... Думаю, это именно то, что мы сделаем...",
			"У тебя толчок вместо головы!",
			"Прости, что?",
			"Прости, что, толчкоголовый?",
			"Неудивительно, что растяпа вроде тебя присоединяется к вонючим рядам проклятых..."
		};
		pinstripeHanglyPassChoice1 = new string[11]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"(Придержать язык).",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeHanglyPassChoice2 = new string[7]
		{
			"Отведи меня к Бо!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Что ты такое?"
		};
		pinstripeCave = new string[7]
		{
			"Привет, Тед...",
			"Должен сказать... Я сильно впечатлен...",
			"К сожалению, Бо провела какое-то время...",
			"...в моем приходе...",
			"Надеюсь увидеть твое мальчишеское личико на церемонии...",
			"Церемонии удочерения, ЖАЛКИЙ ТУПИЦА!",
			"Та-да, парнишка..."
		};
		pinstripeCaveChoice1 = new string[8]
		{
			string.Empty,
			"OK",
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveChoice2 = new string[8]
		{
			string.Empty,
			"Где Бо?",
			string.Empty,
			string.Empty,
			"На какой церемонии?",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExit = new string[10]
		{
			"Тебе понравились мои маленькие послания на стенах?",
			"Я просто ничего не мог с собой поделать, Тед.",
			"Бо моя, ГЛУПЫЙ ИНДЮК!",
			"«Папа, папа, спаси меня!»",
			"А-хо-хо-хо-хо... Прости, Бо!",
			"Твой папа бегает вокруг, как БЕСТОЛКОВЫЙ ДУРАК!",
			"А-ха-ха-ха-ха-ха...",
			"Я не могу ДОЖДАТЬСЯ ЦЕРЕМОНИИ!",
			"Твое маленькое бледное личико зальется слезами, Тед...",
			"А мое тело будет просто дрожать от удовольствия, когда я это увижу..."
		};
		pinstripeCaveExitChoice1 = new string[10]
		{
			"Нет.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExitChoice2 = new string[10]
		{
			"Да.",
			"Отведи меня к Бо!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill = new string[9]
		{
			"Ты пришел как раз к началу церемонии, Тед.",
			"Ох... не будь таким ЖАЛКИМ НЕУДАЧНИКОМ!",
			"Честно говоря, Бо будет намного счастливее со мной...",
			"Так что, останешься на церемонию?",
			"Часы тикают, Тед...",
			"ТУПОЙ МЕЛКИЙ ДУРАЧОК!",
			"Попробуй.",
			"Но если ты не сможешь вспомнить благословенный день, то умрешь...",
			"Боюсь, что Бо навсегда будет моей..."
		};
		pinstripeWindmillChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"(Придержать язык).",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmillChoice2 = new string[10]
		{
			"Отпусти Бо!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Ты заплатишь, свинья!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2 = new string[8]
		{
			"Ох... Ты только что пропустил церемонию, Тед...",
			"Только посмотри на это милое маленькое личико...",
			"Хочешь что-нибудь сказать, милая?",
			"Иди домой, Тед...",
			"У меня теперь новый папа...",
			"Он меня очень любит, и с ним я буду в безопасности...",
			"ВСЕ КОНЧЕНО, ТЕД!",
			"Жаль, что нет способа повернуть время вспять."
		};
		pinstripeWindmill2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2Choice2 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Бо, это я!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrain = new string[8]
		{
			"Хочешь поиграть со мной в поезда, Тед?",
			"Ты будешь машинистом...",
			"Безбашенным машинистом...",
			"Это твоя бедная маленькая детка наверху?",
			"Горит и умирает?",
			"Ты, маленький квакающий ДУРАК!",
			"Теперь здесь живу я, парень...",
			"С моим новым папой..."
		};
		boWithTrainChoice1 = new string[10]
		{
			"Конечно!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrainChoice2 = new string[3]
		{
			"Бо, пойдем!",
			"Пойдем, Бо!",
			string.Empty
		};
		hiveTrain = new string[3]
		{
			"..................... Жуть!",
			"Похоже на гигантский старый мешок...",
			"У меня от него кружится голова..."
		};
		hiveTrain2 = new string[2]
		{
			"Папа, мне кажется, тебе не стоит нюхать эту штуку...",
			"Кажется, это плохо для тебя..."
		};
		hiveTrain3 = new string[4]
		{
			"Что ты наделал, папа!",
			"Мама бы тебя не похвалила...",
			"Она всегда говорила мне не нюхать странные штуки...",
			"Вроде той коричневой, которую я нашла под холодильником..."
		};
		scarf = new string[3]
		{
			"Шарф Бо...",
			"Он пахнет дымом...",
			"...и виски..."
		};
		scarfChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		scarfChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Взять."
		};
		bigTree = new string[2]
		{
			"...Накорми...",
			"...Меня..."
		};
		bigTreeChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bigTreeChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Накормить"
		};
		oldManV2 = new string[12]
		{
			"Ох...",
			"Тед?",
			"Разве ты не узнаешь это милое лицо, дурачок? Это я... Мистер Дики...",
			"Просто убирайся отсюда, парень...",
			"Добро пожаловать в ад, парень. Теперь убирайся!",
			"......Пинстрайп......",
			"Думаю, я знаю, где она, Тед!",
			"... Голодный дом...",
			"Не представляю, как ты сможешь защитить свою дурацкую тушку без оружия...",
			"Пока ты не найдешь его, боюсь, я не смогу тебе помочь...",
			"Я не плакал, я...",
			"Смеялся..."
		};
		oldManV2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Спасибо вам, добрый господин!"
		};
		oldManV2Choice2 = new string[10]
		{
			"Помогите!",
			"Я вас знаю?",
			string.Empty,
			"Но мне нужна помощь!",
			"Мою девочку похитили!",
			"Кто?",
			string.Empty,
			string.Empty,
			string.Empty,
			"Что ж, тогда вы просто размазня..."
		};
		oldManV22 = new string[5]
		{
			"Что... на что ты уставился?",
			"На мои родинки? У меня есть свежие торчащие родинки на макушке. Но они генетические, клянусь!",
			"Мать всегда говорила, что это божий дар...",
			"А я всегда хотел, чтобы доктор Шренвельд их срезал, потому что всегда знал, что Герди была для меня слишком красива...",
			"Всегда был похож на уродливого клоуна, всю начальную школу..."
		};
		oldManV23 = new string[5]
		{
			"Эти родинки не цирковое представление!",
			"Они могут ездить на одноколесном велосипеде, дубина? Могут?",
			"Они могут укрощать четвероногих зверей? Нет! Нет!",
			"Разве твою дочь не похитили? А ты... созерцаешь...",
			"Будто мои родинки готовы сплясать канкан!"
		};
		hive = new string[2]
		{
			"Один из этих мешков...",
			"...с сенсационным ароматом."
		};
		hiveChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		hiveChoice2 = new string[2]
		{
			string.Empty,
			"Взять."
		};
		felix1 = new string[5]
		{
			".......................................................Эй!",
			"Наверху!",
			"Почему, черт возьми, ты одет как долбаный священник?",
			"....................................",
			"Ты пробовал эти мешочные штуки?"
		};
		felix1Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		felix1Choice2 = new string[5]
		{
			"Привет...",
			string.Empty,
			"М-м...",
			string.Empty,
			"Нет."
		};
		felixHurt = new string[3]
		{
			"................................",
			".................Ох............... Не круто, бро.",
			"......Ах......... Это так меня ранит..."
		};
		felixHurtChoice1 = new string[2]
		{
			string.Empty,
			"Извини!"
		};
		felixHurtChoice2 = new string[2]
		{
			string.Empty,
			"Спорю, что это больно, да?"
		};
		drunkMan3 = new string[5]
		{
			"................................",
			"Этот Пинстрайп хорош...",
			"Воистину хорош...",
			"..........................................................................................................................................",
			"Ты слышал?"
		};
		drunkMan3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Как скажешь, старик!"
		};
		drunkMan3Choice2 = new string[3]
		{
			"И снова привет.",
			string.Empty,
			"Ты порядком воняешь."
		};
		poolTableMan = new string[3]
		{
			"Уйти со стола, идиот.",
			"Я тут играю...",
			"Ты, конечно, отец, но это не делает тебя любимым папочкой. Говорю тебе, слазь со стола, хулиганье..."
		};
		poolTableManChoice1 = new string[4]
		{
			string.Empty,
			"Извини, пожалуйста.",
			string.Empty,
			string.Empty
		};
		poolTableManChoice2 = new string[4]
		{
			string.Empty,
			"Твое дыхание...",
			string.Empty,
			string.Empty
		};
		dog2 = new string[10]
		{
			"Спасибо, Тед!..",
			"Я уж не знал, выберусь ли когда-нибудь...",
			"Эй... Где Бо?",
			"Тьфу... Этого я и боялся...",
			"Ну, мы ее найдем, приятель...",
			"Может, я помогу разнюхать что-то...",
			"А кстати, Дики где-то поблизости?",
			"Ага... От его задницы за километр воняет...",
			"А этот Пинстрайп...",
			"Он просто негодяй!"
		};
		dog2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Ладно",
			string.Empty,
			"Извини!"
		};
		dog2Choice2 = new string[10]
		{
			"Ты разговариваешь!",
			string.Empty,
			"Пинстрайп ее похитил!",
			string.Empty,
			"Давай же!",
			string.Empty,
			"Да",
			"Почему тебя заперли?",
			string.Empty,
			"Ну ты и негодяй..."
		};
		dogBoSmell = new string[7]
		{
			"Эге!",
			"Чуешь этот запах, Тед?",
			"Пахнет... яблоками...",
			"Как-то не особо чую...",
			"Люблю сыр, пироги и все, что пахнет мясом...",
			"Ага... Извини.",
			"Пойдем."
		};
		dogBoSmellChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			"ОК.",
			string.Empty,
			string.Empty
		};
		dogBoSmellChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			"Бо любит яблоки.",
			"Хм-м.",
			string.Empty
		};
		dog3 = new string[2]
		{
			"Тед...",
			"Ищи Бо..."
		};
		dogPraise1 = new string[1]
		{
			"Правильный ход мысли, Тед!"
		};
		dogBalloonPop = new string[3]
		{
			"А! Дружок! Я дергаюсь всякий раз, когда ты взрываешь шар.",
			"Ты можешь больше... не... делать этого?",
			"Так вот как все должно быть, да?"
		};
		dogBalloonPopChoice1 = new string[2]
		{
			string.Empty,
			"Извини, Джордж!"
		};
		dogBalloonPopChoice2 = new string[2]
		{
			string.Empty,
			"Э... Нет."
		};
		dogBalloonPop2 = new string[3]
		{
			"АГА!",
			"Тед! Шары...",
			"Правда?"
		};
		dogBalloonPop2Choice1 = new string[2]
		{
			string.Empty,
			"Извини!"
		};
		dogBalloonPop2Choice2 = new string[2]
		{
			string.Empty,
			"Хе-хе."
		};
		recordPlayer1 = new string[3]
		{
			"Проигрыватель покрыт красными перьями...",
			"Пластинка под названием «Мисс Берди Бондетт: интермеццо и прочие раздумья».",
			"Эта песня называется «Последняя улыбка»."
		};
		recordPlayer1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer1Choice2 = new string[3]
		{
			string.Empty,
			"Играть",
			string.Empty
		};
		recordPlayer12 = new string[2]
		{
			"Какая красивая музыка...",
			"Кажется, я в собачьем раю..."
		};
		recordPlayer12Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer12Choice2 = new string[3]
		{
			string.Empty,
			"ОК.",
			string.Empty
		};
		recordPlayer2 = new string[3]
		{
			"Эй! Это одна из самых трогательных песен мисс Берди!",
			"Давай послушаем, Тед!",
			"«Последняя прогулка»... Какое грустное название..."
		};
		recordPlayer2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer2Choice2 = new string[3]
		{
			string.Empty,
			"Играть",
			string.Empty
		};
		recordPlayer22 = new string[2]
		{
			"М-м-м-м... Как красиво. Если бы музыка пахла...",
			"Но тут пахнет только бабушкой..."
		};
		recordPlayer22Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer22Choice2 = new string[3]
		{
			string.Empty,
			"ОК.",
			string.Empty
		};
		recordPlayer3 = new string[4]
		{
			"Еще одна из пластинок мисс Берди...",
			"К ней приколота записка...",
			"«Тедди, эту песню я написала для Бо. Я сожалею о твоей утрате. Мисс Берди»",
			"Она называется... «Последние объятия»."
		};
		recordPlayer3Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer3Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Проиграть",
			string.Empty
		};
		recordPlayer32 = new string[3]
		{
			"Она такая... печальная...",
			"Мы же еще можем спасти Бо... Правда?",
			"Все будет нормально, Тед..."
		};
		recordPlayer32Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer32Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dogRecordPlayer = new string[1]
		{
			"Жуткая песня..."
		};
		dogRecordPlayerChoice1 = new string[1]
		{
			string.Empty
		};
		dogRecordPlayerChoice2 = new string[1]
		{
			"Ага."
		};
		dogPoop = new string[4]
		{
			"Фу... Помет маленькой леди...",
			"Если она попадется на глаза... Обязательно нужно на нее запрыгнуть...",
			"Стоп-стоп-стоп...",
			"Я говорящая собака, а вас только мой акцент удивляет?"
		};
		dogPoopChoice1 = new string[2]
		{
			string.Empty,
			"Спасибо за подсказку!"
		};
		dogPoopChoice2 = new string[2]
		{
			string.Empty,
			"Куда девался твой акцент, дружок?"
		};
		dogMushroom = new string[5]
		{
			"Светящийся гриб...",
			"Этот пахнет совсем как керосин...",
			"Эй, Тед, помнишь, эти штуки тебе встречались в Эджвуде и на Голодном перевале?",
			"Не знаю... Может, нам удастся найти мерзлые капли, чтобы их поджечь или еще что-нибудь...",
			"Я только помочь хочу..."
		};
		dogMushroomChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Верно мыслишь, Джордж!"
		};
		dogMushroomChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Ага, и что?",
			"Э-э-э... Еще бы."
		};
		dogCaveJumpComment = new string[1]
		{
			"Получилось!"
		};
		dogCaveJumpCommentChoice1 = new string[1]
		{
			string.Empty
		};
		dogCaveJumpCommentChoice2 = new string[1]
		{
			"Спасибо!"
		};
		caves = new string[2]
		{
			"Вид у пещеры такой мрачный и зловещий...",
			"Тут совсем темно и ничего не видно..."
		};
		caves2 = new string[2]
		{
			"Из глубины доносится ужасный и чудовищный звук...",
			"..........................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................."
		};
		flashLightTalk = new string[3]
		{
			"Классный налобный фонарь!",
			"Изрисован чем-то вроде... цветочков...",
			"Выберите значок для включения и выключения."
		};
		flashLightTalkChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		flashLightTalkChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Взять."
		};
		lewis = new string[5]
		{
			"... У-у-у... О-о-о... О-о-о...",
			"Спина чертовски болит!",
			"Слушай, сопляк, у нас мало времени.",
			"У-у-у... Бо сейчас на вершине горы... В... Голодном доме...",
			"Посмотрел бы я, как этот доходяга на тонких ножках вскарабкается на гору, когда ему стукнет столько, сколько мне..."
		};
		lewisChoice1 = new string[5]
		{
			string.Empty,
			"Извини!",
			string.Empty,
			"Ладно.",
			string.Empty
		};
		lewisChoice2 = new string[5]
		{
			"Дики, ты как?",
			"Ты старый.",
			string.Empty,
			"Ты что, не пойдешь?",
			"Ладно."
		};
		lewis2 = new string[4]
		{
			"Носишься тут, как шут...",
			"В твоем возрасте я по 80 часов в неделю работал на отцовском сталелитейном заводе.",
			"Он меня каждый день лупил...",
			"Ш... Шрамы до сих пор остались..."
		};
		oldManStartWalking = new string[4]
		{
			"Чего так долго, глиста ты этакая?!",
			"Встретимся у Голодного дома...",
			"Я же тебе сказал! Голодный дом... На вершине горы...",
			"Уверен, именно там Пинстрайп держит Бо..."
		};
		oldManStartWalkingChoice1 = new string[4]
		{
			string.Empty,
			"ОК.",
			string.Empty,
			"Там и увидимся!"
		};
		oldManStartWalkingChoice2 = new string[4]
		{
			string.Empty,
			"Где?",
			string.Empty,
			"Ладно. Боже, старик..."
		};
		key = new string[2]
		{
			"Серебряный ключ...",
			"На ручке вытравлена крошечная буква «P»..."
		};
		keyChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		keyChoice2 = new string[2]
		{
			string.Empty,
			"Взять."
		};
		goldKeyTalk = new string[1]
		{
			"Золотой ключ..."
		};
		rifle = new string[4]
		{
			"Старая винтовка...",
			"Ха, классно...",
			"Название «Вечно поющая птица»... Вытравлено на ложе...",
			"Интересно, почему она так называется?"
		};
		rifleChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		rifleChoice2 = new string[4]
		{
			"Вот здорово!",
			string.Empty,
			string.Empty,
			"Бери!"
		};
		oldWomanPorch = new string[8]
		{
			"Да здравствуют мои сиськи...",
			"Душка Тедди? Это ты?",
			"Вот так встреча, Тедди!",
			"А где моя маленькая подруга Бо?",
			"Что, правда?",
			"Боюсь, Дики тебя обманул...",
			"Так... Ты меня из этой штуковины вытащишь или нет?",
			"Хи-хи-хи... Классно!"
		};
		oldWomanPorchChoice1 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Конечно же!"
		};
		oldWomanPorchChoice2 = new string[8]
		{
			string.Empty,
			"Да?",
			string.Empty,
			"Дики сказал, что она там...",
			string.Empty,
			"Ох...",
			"Нет, спасибо, голубиная попа.",
			string.Empty
		};
		dogBirdyCommentNice = new string[10]
		{
			"Надо понимать, ты это хотел сделать?",
			"Как бы там ни было, ты, возможно, ее убил...",
			"По крайней мере, ты был с ней мил перед тем, как она разбилась...",
			"Она в самом деле была милой старушкой.",
			"...Э-э-э...",
			"Мисс Берди...",
			"Да воспарит ее душа... На веки вечные...",
			"На небеса...",
			"А оттуда — в рай...",
			"Аминь..."
		};
		dogBirdyCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Она в самом деле была..."
		};
		dogBirdyCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Скажи пару слов, Джордж."
		};
		dogBirdyCommentMean = new string[6]
		{
			"Ну и ну... Ты ее убил!",
			"Сначала ее голубиной попой назвал, а теперь это?!",
			"Ага... В смысле, не пойми меня неправильно...",
			"От нее правда пахло, как из голубиной попы...",
			"Но это неважно!",
			"Ты взял и ее убил!"
		};
		dogBirdyCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			"Извини...",
			string.Empty,
			string.Empty
		};
		dogBirdyCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			"От нее воняло, как из попы.",
			string.Empty,
			"Ага..."
		};
		dogBarCommentMean = new string[6]
		{
			"Да уж, этот тип всерьез рассердился...",
			"Отныне просто... старайся не выделяться...",
			"Разве тебе не хочется в такой момент отрубиться, а?",
			"Выглядишь ты клево, модно. Типичный Тед...",
			"Но руки у тебя...",
			"...как у скелета..."
		};
		dogBarCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Твоя правда, пожалуй...",
			string.Empty
		};
		dogBarCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Я могу их взять!",
			string.Empty
		};
		dogBarCommentNice = new string[4]
		{
			"Э-э-э... Серьезно?",
			"Ты серьезно будешь гулять со всеми в такую ночь?",
			"Тед... А как же Бо?",
			"Да, нехорошо это, дружок..."
		};
		dogBarCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			"Конечно, нет!",
			string.Empty,
			string.Empty
		};
		dogBarCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			"Конечно!",
			"Ага...",
			string.Empty
		};
		floatingPeople = new string[18]
		{
			"Хо-хо-ха-ха-хи-хи-хи... Ох, Тедди, это безумие!",
			"Но Дики что-то хочет тебе сказать. Правда, Дики?",
			"Тьфу... Я соврал... Просто хотел, чтобы мне помогли найти мою крошку Берди...",
			"Пинстрайп живет в Красном русле...",
			"Это озеро в глубине ада.",
			"Боюсь, он запер твою милашку Бо в своем жутком приходском доме...",
			"Чтобы туда попасть, тебе понадобится свет...",
			"... Посмотрим, сгожусь ли я еще на что-то...",
			"... Ах, о да, вот...",
			"Как-то вечером мы с Бо играли в ее игрушки, и она дала мне этот странный кусок бумаги...",
			"Интересно, поможет ли он тебе найти свет...",
			"Подсказку можно рассмотреть позже, если вы о ней забудете...",
			"Видите, в нижней части экрана мигает ЗНАЧОК ПОДСКАЗКИ?",
			"С его помощью можно просмотреть все найденные вами ПОДСКАЗКИ...",
			"Обязательно рассмотрите все как следует...",
			"В любом случае...",
			"Встретимся в Красном русле...",
			"Мы точно найдем Бо, радость моя..."
		};
		floatingPeopleChoice1 = new string[14]
		{
			string.Empty,
			"Все нормально, Дики...",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		floatingPeopleChoice2 = new string[18]
		{
			"Угу.",
			"Говори, мерзавец...",
			"Но где Бо?",
			string.Empty,
			string.Empty,
			"ОК.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Спасибо.",
			string.Empty,
			"Да.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"ОК."
		};
		dogHintChest = new string[5]
		{
			"Тед! Помнишь тот ящик с игрушками в дереве в Эджвуде?",
			"Может, он связан с подсказками, которые оставила мисс Берди, чтобы мы нашли свет...",
			"Свет, который нужен, чтобы попасть к Красному руслу...",
			"Обязательно осматривай подсказки...",
			"Видишь значок подсказки в левом нижнем углу экрана?"
		};
		dogHintChestChoice1 = new string[3]
		{
			string.Empty,
			"ОК.",
			string.Empty
		};
		dogHintChestChoice2 = new string[3]
		{
			string.Empty,
			"Какой свет?",
			string.Empty
		};
		telephone = new string[3]
		{
			"............. Папа...",
			"Это ты?",
			"............................................. Папа, помоги!"
		};
		pinstripeManBoss = new string[3]
		{
			"АХ ТЫ ДРЯНЬ!",
			"Лезешь в наш идеальный изысканный союз!",
			"Гори, МАЛЬЧОНКА ТЕДДИ!!!"
		};
		houseLockedGold = new string[1]
		{
			"Дверь заперта на золотой висячий замок..."
		};
		houseLockedMechanism = new string[1]
		{
			"Дверь заперта при помощи какого-то механизма..."
		};
		houseLockedMechanismChoice1 = new string[1]
		{
			string.Empty
		};
		houseLockedMechanismChoice2 = new string[1]
		{
			"Осмотреть."
		};
		houseLockedSilver = new string[1]
		{
			"Дверь заперта на серебряный висячий замок..."
		};
		houseLocked2 = new string[1]
		{
			"Дверь заперта..."
		};
		sign1 = new string[2]
		{
			"Вверх: Голодный перевал",
			"Вниз: Красное русло"
		};
		sign2 = new string[1]
		{
			"К Красному руслу..."
		};
		signPissward = new string[2]
		{
			"«К Красному руслу»...",
			"«Купить билеты у Счастливчика»."
		};
		signBalloonShop = new string[4]
		{
			"«Употребление моих скоростных грибов строго запрещено».",
			"«Побочные эффекты: тошнота, понос, мысли о самоубийстве...»",
			"«Или +1 к СС (скорости стрельбы) игрока...»",
			"«Так что не надо! — Магазин воздушных шаров Принкла»"
		};
		liftPower = new string[3]
		{
			"Водяное колесо или типа того...",
			"Похоже, от него питается подъемник...",
			"Но... Где же вода?"
		};
		signPissward2 = new string[2]
		{
			"Похоже на газопровод...",
			"«Газопровод идет к Эджвуду, Голодному перевалу, Мешкоспуску, Описюкинску и Красному руслу...»"
		};
		signPissward2Choice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signPissward2Choice2 = new string[2]
		{
			string.Empty,
			"Осмотреть."
		};
		signHappySafe = new string[2]
		{
			"Гигантский сейф?",
			"«Даже не думай, глупое создание. — Счастливчик»"
		};
		signHappySafeChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signHappySafeChoice2 = new string[2]
		{
			string.Empty,
			"Осмотреть."
		};
		signTimsShop = new string[2]
		{
			"Нацарапанная записка...",
			"«Пытаюсь уснуть. В 20:10 не сплю...»"
		};
		signTimsShopChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signTimsShopChoice2 = new string[2]
		{
			"Осмотреть.",
			string.Empty
		};
		pisswardMan1 = new string[13]
		{
			"Здравствуйте, отец...",
			"Добро пожаловать в Описюкинск, где живет змеюка-описюка, которая любит все описывать...",
			"Билеты на подъемник к Красному руслу стоят 300 мерзлых капель...",
			"Спасибо за покупку, отец...",
			"А-а-а... Как здорово...",
			".............. О-о-о... Как здорово... О-о-о... Ух ты...",
			"Отнесу эти капли в Красное русло и постараюсь немного поспать...",
			"Я не сплю уже...",
			"Сколько?",
			"Не помню.",
			"... Разжевать мерзлые капли и наблюдать, как тебя уносит в страну грез... Бесподобно...",
			"Боже, благослови Пинстрайпа. Боже, благослови его добрую душу...",
			"Вот ваш билет на подъемник, отец..."
		};
		pisswardMan1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Нет, спасибо."
		};
		pisswardMan1Choice2 = new string[3]
		{
			"Здравствуйте.",
			string.Empty,
			"Купить билет (300)."
		};
		happyEdgeWood = new string[14]
		{
			"Здравствуйте, отец...",
			"Это я, Счастливчик...",
			"О, вы меня знаете, Тед!",
			"Друг Бо?",
			"Так или иначе, сейчас вы выглядите особенно беспокойно и мокро...",
			"Хотел бы я налить вам выпить, дружище, но за этим пришлось бы идти к Красному руслу...",
			"Но я могу вам продать кое-что получше и по хорошей цене...",
			"Купите этот запрещенный пистолет-пулемет Томпсона за 1 000 мерзлых капель...",
			"Спасибо за покупку, отец...",
			"Знакомьтесь, сэр: мистер Томпсон...",
			"С таким стволом вы будете смотреться невероятно сексуально...",
			"Эх, сюда бы фотоаппарат, чтобы сделать снимок для моей мамаши...",
			"Ладно... Теперь можете идти спасать свою маленькую прелесть, новоиспеченный и вымокший гангстер...",
			"Вперед, за дело..."
		};
		happyEdgeWoodChoice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Нет, спасибо."
		};
		happyEdgeWoodChoice2 = new string[8]
		{
			"Мы знакомы?",
			"Кто?",
			string.Empty,
			"Не-а.",
			"Что?",
			string.Empty,
			string.Empty,
			"Купить (1 000)."
		};
		happyHangly = new string[13]
		{
			"Здравствуйте, отец...",
			"Могу вам кое-чего продать по хорошей цене...",
			"Кстати, у вашей собачки пузо мерзнет.",
			"Гляньте, как дрожит и трясется!",
			"Купите собачке свитер за 400 мерзлых капель...",
			"Спасибо за покупку, отец...",
			"Какая прелесть! Смотрите, как этой попке тепло...",
			"Этот свитер моя мамаша собственноручно связала своими длинными спицами...",
			"Могу спорить, он вот-вот растечется от тепла и уюта...",
			"В любую минуту...",
			"Кстати, спасибо за мерзлые капли.",
			"Если вам еще что-то понадобится, ищите маленькую парикмахерскую...",
			"Она желтая и крутится..."
		};
		happyHanglyChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Нет, спасибо."
		};
		happyHanglyChoice2 = new string[5]
		{
			"Здравствуйте.",
			string.Empty,
			string.Empty,
			string.Empty,
			"Купить (400)."
		};
		happyCave = new string[10]
		{
			"Здравствуйте, отец...",
			"Что вы думаете об этой системе пещер?",
			"Думаю, у Пинстрайпа там кипит бурная деятельность...",
			"Все равно чертовски холодно...",
			"Готов мамой поклясться, что под землей было бы теплее...",
			"Кстати, господин Пинстрайп дал мне дополнительный костюм...",
			"Позвольте... Позвольте посмотреть... Э-э-э... Здесь ли он...",
			"Точно, точно. Вот, вот он. Я продам вам его запасной костюм за 500 мерзлых капель...",
			"Спасибо за покупку, отец...",
			"........ Тед, вы выглядите в точности как он!"
		};
		happyCaveChoice1 = new string[8]
		{
			string.Empty,
			"Классно.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Нет, спасибо."
		};
		happyCaveChoice2 = new string[8]
		{
			"Здравствуйте, Счастливчик.",
			"Меня не впечатляет.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Купить (500)."
		};
		timRedWash1 = new string[11]
		{
			"Здравствуйте, отец...",
			"Насчет мерзлых капель, которые вы мне дали под Описюкинском...",
			"Пожалуй, их оказалось недостаточно, чтобы меня усыпить...",
			"Так что слушайте. Я могу вам помочь забрать Бо у Пинстрайпа. Но окажите мне услугу...",
			"Если на этот раз вы мне достанете 10 мешков... Не мерзлых капель, а свежих мешков... ",
			"Я вам продам газету... Но не обычную...",
			"В ней есть пароль для входа в приходской дом Пинстрайпа...",
			"Ну, что скажете? Только эти мешки помогут мне уснуть сегодня ночью...",
			"Пинстрайп будет доставлять эти мешки в определенное время, отец...",
			"Вот маленькая подсказка насчет того, когда это будет...",
			"Когда найдете мешки, принесите их сюда, чтобы я мог их опустошить..."
		};
		timRedWash1Choice1 = new string[18]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash1Choice2 = new string[10]
		{
			"Здравствуйте, Счастливчик.",
			"Да?",
			"ОК.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Конечно!",
			string.Empty,
			"ОК!"
		};
		timRedWash2 = new string[10]
		{
			"Здравствуйте, отец...",
			"Купите газету за 10 мешков?",
			"Я покажу вам подсказку, которая поможет попасть в приходской дом Пинстрайпа...",
			"Спасибо...",
			"Уже поздно...",
			"Пожалуй, буду закрываться и пойду на боковую, знаете ли...",
			"Пересплю эту бурю в моем уютненьком магазине...",
			"Это безумие... Что вы сделали, отец?",
			"Как бы то ни было... пароль должен быть в этой газете...",
			"...................... Спокойной ночи, отец..."
		};
		timRedWash2Choice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			"Еще нет.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash2Choice2 = new string[10]
		{
			"Здравствуйте, Счастливчик.",
			string.Empty,
			"Купить (10 мешков).",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapArea = new string[4]
		{
			"Игрушечная рогатка Бо...",
			"На деревянной части вырезана надпись «С днем рождения, Бо»...",
			"Чтобы отпустить, щелкните или нажмите на спусковой крючок.",
			"Предметы вроде этой коробки можно ломать..."
		};
		blunderBustTapAreaChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapAreaChoice2 = new string[5]
		{
			"Осмотреть.",
			string.Empty,
			string.Empty,
			"Взять.",
			string.Empty
		};
		whiskey = new string[1]
		{
			"Бутылка виски..."
		};
		whiskeyChoice1 = new string[1]
		{
			string.Empty
		};
		whiskeyChoice2 = new string[1]
		{
			"Взять."
		};
		dan = new string[10]
		{
			"Благословенный вечер...",
			"Добро пожаловать в Красное русло...",
			"Курорт наивысших удовольствий Пинстрайпа.",
			"Пожалуйста, распишитесь в гостевой книге...",
			"Гм... Какая красивая подпись...",
			"Обратите внимание: сегодняшняя ночь особенная...",
			"Церемония начнется, когда взойдет полная луна...",
			"Не каждый день Пинстрайп находит свежего пухленького ребенка...",
			"И господин Пинстрайп попросил всех жителей засвидетельствовать...",
			"Удочерение навеки..."
		};
		danChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Спасибо.",
			string.Empty,
			string.Empty,
			string.Empty
		};
		danChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Какая церемония?"
		};
		dan2 = new string[7]
		{
			"Церемония...",
			"У меня от этой церемонии мурашки по коже...",
			"И молока выпить хочется.",
			"Вы вообще не... Что?",
			"Вы вообще не понимаете, что такое добрый стакан теплого молока?",
			"Теплое-теплое молоко и церемония удочерения, какой я еще никогда не видывал...",
			"Ну конечно, вы не понимаете..."
		};
		dan2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"ОК."
		};
		dan2Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Я вообще не..."
		};
		dan22 = new string[1]
		{
			"Даниэль хочет молочка."
		};
		dan22Choice1 = new string[1]
		{
			string.Empty
		};
		dan22Choice2 = new string[1]
		{
			"ОК."
		};
		dan23 = new string[1]
		{
			"Теплое молоко за удочерение."
		};
		dan23Choice1 = new string[1]
		{
			string.Empty
		};
		dan23Choice2 = new string[1]
		{
			"ОК."
		};
		dan24 = new string[1]
		{
			"Хотелось бы мне влить себе в рот целую реку молока."
		};
		dan24Choice1 = new string[1]
		{
			string.Empty
		};
		dan24Choice2 = new string[1]
		{
			"ОК."
		};
		dan25 = new string[1]
		{
			"Представляю озеро молока у себя во рту."
		};
		dan25Choice1 = new string[1]
		{
			string.Empty
		};
		dan25Choice2 = new string[1]
		{
			"ОК."
		};
		dan26 = new string[1]
		{
			"Молоко."
		};
		dan26Choice1 = new string[1]
		{
			string.Empty
		};
		dan26Choice2 = new string[1]
		{
			"ОК."
		};
		dan27 = new string[1]
		{
			"..............................................................."
		};
		dan27Choice1 = new string[1]
		{
			string.Empty
		};
		dan27Choice2 = new string[1]
		{
			"Чего?"
		};
		kitty2 = new string[4]
		{
			"Ой-ой-ой...",
			"Сварливая у вас девочка...",
			"Но не волнуйтесь, Тед.",
			"Скоро она будет называть меня «отец»."
		};
		kitty4 = new string[1]
		{
			"........."
		};
		signMegaGem = new string[7]
		{
			"................................ Большая черная мерзлая капля...",
			"«Шлак мешковидный из Лунного штата — крупнейшая зарегистрированная мерзлая капля Пинстрайпа...",
			"Добыта на глубине 323 м под Красным руслом в верхнем слое окаменелого мешка.",
			"Оценивается в 50 мерзлых капель».",
			"Пахнет свежим лаком для волос...",
			"Запах очень приятный...",
			"Спой мне перед сном, Ада..."
		};
		signMegaGemChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"ОК."
		};
		signMegaGemChoice2 = new string[4]
		{
			"Читать.",
			string.Empty,
			string.Empty,
			"Понюхать."
		};
		balloonMan1 = new string[11]
		{
			"У-у-ух... Я не говорил, что вы можете сюда прийти шататься...",
			"Но, знаете, я рад, что вы явились. Ведь теперь я могу похвастаться своими шарикомашинами...",
			"Здешние дети зовут меня Принкл. Я лучший в городе изготовитель воздушных шаров благодаря шарикоделательным машинам...",
			"Пинстрайп заказал целую партию шариков, и я выполнил этот заказ на ура...",
			"Ага... Секунд за десять...",
			"Гм-м-м... Готов поспорить на свою громадную мерзлую каплю, что вы не превзойдете мои проворные и скоростные машины...",
			"Вы излишне уверенны в себе, друг!",
			"Готовьтесь получать по своей бестолковке!",
			"На старт...",
			"Внимание...",
			"МАРШ!"
		};
		balloonMan1Choice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		balloonMan1Choice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Пари принимаю!"
		};
		balloonMan2 = new string[6]
		{
			"ВЫ ПРОИГРАЛИ!",
			"Хотите еще сыграть, отец?",
			"Батарейки свои как следует подзарядите!",
			"На старт...",
			"На шмарт...",
			"ШУРУЙТЕ!"
		};
		balloonMan2Choice1 = new string[2]
		{
			string.Empty,
			"Нет, спасибо."
		};
		balloonMan2Choice2 = new string[2]
		{
			string.Empty,
			"Давайте!"
		};
		balloonMan2b = new string[6]
		{
			"ОХ, КАПИТАН, КАПИТАН!",
			"Хотите еще сыграть, капитан?",
			"Мне не терпится увидеть эти на-а-а-вы-ы-ы-ки-и-и-и!",
			"На старт...",
			"На шмарт...",
			"ШУРУЙТЕ!"
		};
		balloonMan2bChoice1 = new string[2]
		{
			string.Empty,
			"Нет, спасибо."
		};
		balloonMan2bChoice2 = new string[2]
		{
			string.Empty,
			"Давайте!"
		};
		balloonMan3 = new string[5]
		{
			"ЧЕГО-О-О-О?!!",
			"Вы... Вы...",
			"Просто ПОТРЯСНЫЙ! Чтобы победить мои шарикоделательные машины, нужны...",
			"Беспрецедентные навыки! Просто немыслимо...",
			"Держите приз, отец... Давайте... Берите..."
		};
		balloonMan3Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Очень мило!"
		};
		balloonMan3Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Э-э-э... Вот так..."
		};
		savePortraitGronkh = new string[2]
		{
			"Очередной портрет... очень агрессивного мужика.",
			"..................................................Игра сохранена."
		};
		savePortraitGronkhChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkhChoice2 = new string[1]
		{
			"Сохранить игру."
		};
		savePortraitGronkh2 = new string[2]
		{
			"Все равно у портрета очень агрессивный вид...",
			"..................................................Игра сохранена."
		};
		savePortraitGronkh2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh2Choice2 = new string[1]
		{
			"Сохранить игру."
		};
		savePortraitGronkh3 = new string[2]
		{
			"Столько агрессии! Его агрессия переходит на холст!",
			"..................................................Игра сохранена."
		};
		savePortraitGronkh3Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh3Choice2 = new string[1]
		{
			"Сохранить игру."
		};
		savePortraitGronkh4 = new string[2]
		{
			"От этого холста как будто пышет агрессией. В основном из-за агрессивного мужика...",
			"..................................................Игра сохранена."
		};
		savePortraitGronkh4Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh4Choice2 = new string[1]
		{
			"Сохранить игру."
		};
		savePortraitDirk = new string[2]
		{
			"Портрет причесанного типчика...",
			"..................................................Игра сохранена."
		};
		savePortraitDirkChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitDirkChoice2 = new string[1]
		{
			"Сохранить игру."
		};
		savePortraitRMannion = new string[2]
		{
			"Портрет вычурного модника...",
			"..................................................Игра сохранена."
		};
		savePortraitRMannionChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitRMannionChoice2 = new string[1]
		{
			"Сохранить игру."
		};
		savePortraitJHandville = new string[2]
		{
			"Портрет классных усов с лицом мужчины.",
			"..................................................Игра сохранена."
		};
		savePortraitJHandvilleChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitJHandvilleChoice2 = new string[1]
		{
			"Сохранить игру."
		};
		savePortraitNathanKingston = new string[2]
		{
			"Портрет какого-то типа вроде на Иисуса, но не Иисуса. Гляньте, это какой-то Натан...",
			"..................................................Игра сохранена."
		};
		savePortraitNathanKingstonChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitNathanKingstonChoice2 = new string[1]
		{
			"Сохранить игру."
		};
		savePortraitOchoma = new string[2]
		{
			"Печальный, холодный портрет...",
			"..................................................Игра сохранена."
		};
		savePortraitOchomaChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitOchomaChoice2 = new string[1]
		{
			"Сохранить игру."
		};
		savePortraitBuddy = new string[2]
		{
			"Странный портрет мужчины...",
			"..................................................Игра сохранена."
		};
		savePortraitBuddyChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddyChoice2 = new string[1]
		{
			"Сохранить игру."
		};
		savePortraitBuddy2 = new string[2]
		{
			"Все еще странный портрет мужчины... Лысого, с усами...",
			"..................................................Игра сохранена."
		};
		savePortraitBuddy2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddy2Choice2 = new string[1]
		{
			"Сохранить игру."
		};
		creepyMan = new string[2]
		{
			"....... Он уже должен прийти... Так?",
			"Он должен еще фруктов принести..."
		};
		creepyMan2 = new string[2]
		{
			"Ванна?",
			"Тед... По-моему, там что-то есть..."
		};
		creepyMan3 = new string[5]
		{
			"Этот старик и милая леди прошли здесь всего минуту назад...",
			"Они сказали, что ты уничтожишь Пинстрайпа...",
			"Не делай этого, приятель!",
			"Только благодаря ему я тут бурной жизнью живу...",
			"Он должен прийти с минуты на минуту... Так? И мне еще мешков принести..."
		};
		jack = new string[8]
		{
			"У-у-х... Отец?",
			"Ай... Помоги!",
			"Эта демоническая штука ест меня живьем!",
			"Я не ем тебя... Я просто веду тебя к «Красному руслу».",
			"Не волнуйся, милая... Там очень весело... Можно пить густой сок из мешка днями и ночами...",
			"О... правда?..",
			"М-м... тогда хорошо!",
			"Скорее! Мы не можем ждать весь день!"
		};
		jackChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		jackChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkard = new string[9]
		{
			"Вы будете кутить после церемонии, отец?",
			"Вот, для разогрева хлебните сока из мешка господина Пинстрайпа... ",
			"О-о-о... М-м-м...",
			"Он хорош, да... Но не так хорош, как серьезное пойло...",
			"На церемонии Пинстрайп будет раздавать свежие мешки с этим напитком...",
			"Вы ведь вкусите запретный плод вместе с нами, а, отец?",
			"А хотите, я вас с ног собью?",
			"Нет ничего хуже, чем чужое осуждение...",
			"Особенно такого жалкого существа, как вы..."
		};
		drunkardChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Конечно, кутить я люблю!",
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkardChoice2 = new string[6]
		{
			string.Empty,
			"ОК.",
			string.Empty,
			string.Empty,
			string.Empty,
			"Нет, спасибо, забулдыга."
		};
		dickyBar = new string[11]
		{
			"...Эй...",
			"Тед... это я...",
			"Это я, мистер Дики...",
			"Тут надо быть поосторожнее...",
			"Если Пинстрайп меня обнаружит, то убьет...",
			"Особенно если застанет нас за тем, как мы помогаем вам найти Бо. Так что...",
			"Я маскируюсь...",
			".... Я клоун, Тед...",
			"Нос видите?",
			"Она прячется у Пинстрайпа в колодце...",
			"Она сказала, что у нее для вас сюрприз..."
		};
		dickyBarChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Угу.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarChoice2 = new string[22]
		{
			"Эй.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Где мисс Берди?",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2 = new string[6]
		{
			"Что?",
			"Вы же не на родинки на моей макушке смотрите, а?",
			"Хватит! Хватит!",
			"Я не клоу...",
			"...................",
			"Отстаньте от меня!"
		};
		dickyBar2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarNight = new string[6]
		{
			"Что вы сделали, Тед?",
			"У меня кости болят...",
			"Думаю...",
			"Тед...",
			"Прошу прощения, но, по-моему, все кончено...",
			"Я сказал все кончено."
		};
		dickyBarNightChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"ОК."
		};
		dickyBarNightChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Что?"
		};
		birdyBarrel = new string[9]
		{
			"Ш-ш-ш... Хи-хи-хи...",
			"Душка Тедди...",
			"Это снова я...",
			"Быстро! Бери эту настоящую ложку...",
			"Мне так нравится, как она блестит и пахнет...",
			"И, несомненно, на ощупь приятная?",
			"Вам потребуется победить Пинстрайпа и спасти бедную малышку Бо...",
			"Но никому не говорите, что я здесь...",
			"Не хочу, чтобы Пинстрайп меня опять в ту клетку запер..."
		};
		birdyBarrelChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"В самом деле!"
		};
		birdyBarrelChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Ой, спасибо...",
			string.Empty,
			"Какая глупость..."
		};
		tokenInvite1 = new string[1]
		{
			"Кусок бумаги..."
		};
		tokenInvite1Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite1Choice2 = new string[1]
		{
			"Взять."
		};
		tokenInvite2 = new string[1]
		{
			"Кусок бумаги..."
		};
		tokenInvite2Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite2Choice2 = new string[1]
		{
			"Взять."
		};
		tokenFilmStrip = new string[1]
		{
			"Секретная пленка..."
		};
		tokenFilmStripChoice1 = new string[1]
		{
			string.Empty
		};
		tokenFilmStripChoice2 = new string[1]
		{
			"Взять."
		};
		tokenBible = new string[1]
		{
			"Старая библия..."
		};
		tokenBibleChoice1 = new string[1]
		{
			string.Empty
		};
		tokenBibleChoice2 = new string[1]
		{
			"Взять."
		};
		tokenNotebook = new string[3]
		{
			"А это здесь откуда...",
			"Не смотри, папа...",
			"Это просто глупый рисунок..."
		};
		tokenNotebookChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		tokenNotebookChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Осмотреть."
		};
		tokenPills = new string[1]
		{
			"Пузырек из-под таблеток..."
		};
		tokenPillsChoice1 = new string[1]
		{
			string.Empty
		};
		tokenPillsChoice2 = new string[1]
		{
			"Взять."
		};
		tokenNewspaper = new string[1]
		{
			"Газета..."
		};
		tokenNewspaperChoice1 = new string[1]
		{
			string.Empty
		};
		tokenNewspaperChoice2 = new string[1]
		{
			"Взять."
		};
		tokenLocket = new string[3]
		{
			"Почему все твои вещи выбрасываются через ту дверь, папа?",
			"А это...",
			"...мамин медальон?"
		};
		tokenLocketChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		tokenLocketChoice2 = new string[3]
		{
			"Не знаю...",
			string.Empty,
			"Осмотреть."
		};
		blackAndWhiteModeTalk = new string[4]
		{
			"Ты и впрямь опять в эту игру играешь?",
			"Дурацкая игра...",
			"Как бы то ни было, хотите сыграть в суперрежиме «под старину» за 5 пленок?",
			"Поздравляем. Вы потратили 5 пленок и лишились прекрасных игровых цветов..."
		};
		blackAndWhiteModeTalkChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Нет.",
			string.Empty
		};
		blackAndWhiteModeTalkChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Да (5 пленок).",
			string.Empty
		};
		sackGeneratorExamine = new string[4]
		{
			"Похож на те мешки, которые мы скормили дереву в Эджвуде... Только огромный!",
			"Похоже, он спит или вроде того...",
			"И пахнет яйцами...",
			"Вот здорово..."
		};
		sackGeneratorExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGeneratorExamineChoice2 = new string[1]
		{
			"Осмотреть."
		};
		sackGenerator2Examine = new string[4]
		{
			"Еще один генератор мешков...",
			"Ой...",
			"Берегись зубов!",
			"Фу! А это пахнет неразбавленным молоком..."
		};
		sackGenerator2ExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGenerator2ExamineChoice2 = new string[1]
		{
			"Осмотреть."
		};
		sackGenerator3Examine = new string[5]
		{
			"Еще...",
			"Может, это вызывает брожение сока в мешке или вроде того...",
			"Не знаю...",
			"Но пахнет....................................................какашками.",
			"Ага... Извините, но такой уж запах..."
		};
		sackGenerator3ExamineChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Забавный ты, Джордж..."
		};
		sackGenerator3ExamineChoice2 = new string[5]
		{
			"Осмотреть.",
			string.Empty,
			string.Empty,
			"Хватит болтать...",
			string.Empty
		};
		characterSucked = new string[1]
		{
			"............."
		};
		characterSuckedFelix = new string[2]
		{
			"Тед...",
			"У меня на голове что-то есть?"
		};
		explainFire = new string[8]
		{
			"Привет, хрен...",
			"Не суди меня...",
			"Я себя хорошо вел, клянусь... Мне только пить хотелось...",
			"Нет ничего лучше глотка сока из мешка Пинстрайпа...",
			"От него возникает особое чуйство...",
			"Он сказал, что на праздновании удочерения Бо будет еще...",
			"А тебе какое дело, козел?",
			"Ты даже не знаешь, как машину остановить..."
		};
		explainFireChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"ОК.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		explainFireChoice2 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"А когда удочерение?",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		redWashNotice = new string[7]
		{
			"Объявление...",
			"«Жители Красного русла, пришедшие на церемонию удочерения Бо...",
			"...получат бесплатную партию мешков Пинстрайпа»?..",
			"«Всех жителей, которые не придут...",
			"Будут обзывать и... пороть, пока они не подчинятся»?..",
			"«Спасибо и хорошего дня!»",
			"...Мило..."
		};
		redWashNoticeChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Это ужасно..."
		};
		redWashNoticeChoice2 = new string[6]
		{
			"Читать.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Вроде как в моем вкусе."
		};
		potBellyMan = new string[7]
		{
			"Ш-ш-ш... Хи-хи-хи-хи-хи...",
			"Вы... Слышите, отец?",
			"Это суперчасы Пинстрайпа...",
			"Мне велено никому не позволять прикасаться к суперчасам...",
			"Ни при каких обстоятельствах никому не разрешается...",
			"...трогать эти чертовы часы!",
			"До тебя не доходит... Да, приятель?!"
		};
		potBellyManChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Понимаю!"
		};
		potBellyManChoice2 = new string[4]
		{
			string.Empty,
			"Что?",
			string.Empty,
			"Я к ним не только прикоснусь..."
		};
		potBellyMan2 = new string[6]
		{
			"..................",
			"Ты трогал суперчасы?",
			"ТЫ ЧТО, ПРАВИЛА НЕ ЗНАЕШЬ?",
			"Опять! Опять!",
			"Господин Пинстрайп меня затопчет...",
			"................................ Опять!"
		};
		potBellyMan2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Э-э-э... Пока..."
		};
		potBellyMan2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Что не так?"
		};
		potBellyMan22 = new string[3]
		{
			"............... У-у-у...",
			"В смысле...",
			"Затопчет — это одно. Но, надеюсь, он все равно даст мне мешок..."
		};
		potBellyMan22Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		potBellyMan22Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Ого.",
			string.Empty
		};
		fork = new string[3]
		{
			"Вилка.",
			"Ржавая и пахнет хреном...",
			"Обрызгана.......................................... лосьоном?"
		};
		forkChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		forkChoice2 = new string[3]
		{
			"Осмотреть.",
			string.Empty,
			"Взять."
		};
		boHeaven1 = new string[3]
		{
			"Папа!",
			"Я по тебе соскучилась!",
			"Хочешь на улице поиграть?"
		};
		boHeaven1Choice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boHeaven1Choice2 = new string[3]
		{
			"Бо!",
			"И я по тебе соскучился!",
			"Да!"
		};
		boHeaven2 = new string[2]
		{
			"Папа!",
			"Похоже, это мамино ожерелье с бабочкой!"
		};
		boHeaven2Choice1 = new string[1]
		{
			string.Empty
		};
		boHeaven2Choice2 = new string[1]
		{
			"Да?"
		};
		boHeavenGeorge = new string[1]
		{
			"О... Был бы здесь Джордж..."
		};
		boHeavenGeorgeChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenGeorgeChoice2 = new string[1]
		{
			"..."
		};
		boHeavenButterflies = new string[3]
		{
			"Ого! Смотри, пап!",
			"Видела бы это мама. Она любила бабочек...",
			"Эй! Спорим, вы их всех не поймаете!"
		};
		boHeavenButterfliesChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenButterfliesChoice2 = new string[2]
		{
			string.Empty,
			"Ага..."
		};
		secretRoomCaveSign = new string[8]
		{
			"Каменная скрижаль...",
			"«Сад архиепископа:",
			"Посвящается избранному архиепископу.",
			"Словно молния...",
			"И в мгновение ока избранные предоставили энергию...",
			"Чтобы сделать мир Пинстрайпа ярче и шире.",
			"Насладитесь огромными красными каплями стоимостью 200 капель за штуку.",
			"(Кстати, они пахнут, как Глен)»."
		};
		secretRoomCaveSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomCaveSignChoice2 = new string[1]
		{
			"Осмотреть."
		};
		secretRoomTreeSign = new string[7]
		{
			"«Каменная скрижаль...",
			"Сад архиепископа:",
			"Посвящается избранному архиепископу.",
			"Искренние и скромные дары, преподнесенные избранными...",
			"Были золотым семенем, из которого пророс этот величественный терновник...",
			"Угощайтесь лимонными каплями стоимостью 100 капель за штуку.",
			"(Кстати, они пахнут, как свежевыжатый лосьон от загара с лимонным ароматом)»."
		};
		secretRoomTreeSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomTreeSignChoice2 = new string[1]
		{
			"Осмотреть."
		};
	}
	else if (@string == "German")
	{
		Debug.Log("German");
		trainDoorButton1 = new string[1]
		{
			"Eine Taste …"
		};
		wifeIntro = new string[2]
		{
			"Teddy ...",
			"Ich muss dir etwas sagen ..."
		};
		bo1 = new string[6]
		{
			"Wach auf, Daddy!",
			"Du schlafwandelst wieder ...",
			"Hey! Kannst du Rauch riechen?",
			"Lass uns das untersuchen!",
			"Du kannst Sherlock sein ...",
			"Du bist blöd!"
		};
		bo1Choice1 = new string[5]
		{
			string.Empty,
			"Tut mir leid, Süße.",
			string.Empty,
			string.Empty,
			"Okay."
		};
		bo1Choice2 = new string[5]
		{
			"Arghhh ... was?",
			"Nein, tu ich nicht.",
			"Ja.",
			string.Empty,
			"Los geht’s, Watson!"
		};
		trainDoorButtonBo = new string[2]
		{
			"Sherlock!",
			"Ich glaube, ich kann diese Taste erreichen!"
		};
		trainDoorButtonBoChoice1 = new string[3]
		{
			"Watson?",
			string.Empty,
			string.Empty
		};
		trainDoorButtonBoChoice2 = new string[2]
		{
			string.Empty,
			"Okay ... Bleib da!"
		};
		lockedTrainDoor = new string[1]
		{
			"Abgeschlossen ..."
		};
		sackSpitExplainer = new string[3]
		{
			"Was ist das, Daddy?",
			"Es sieht aus, wie ein gefrorener Tropfen ...",
			"Öl?"
		};
		mirror = new string[7]
		{
			"Das ist ein Spiegel, Sherlock!",
			"Er ist so staubig, dass ich dein Gesicht kaum sehen kann.",
			"Uuuuunheimlich ...",
			"Heh! Sieh uns an, Daddy, wir sehen aus wie lustige Gespenster ...",
			"Bumm!",
			"Oh, stimmt ...",
			"Puuup!"
		};
		mirrorChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Gehen wir."
		};
		mirrorChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Es heißt „Buh“, Süße."
		};
		mirror2 = new string[6]
		{
			"Spieglein, Spieglein im Waggon ...",
			"Wer ist die allerbeste Prinzessin im ...",
			".......................",
			".......................",
			"Was reimt sich auf Waggon, Dad?",
			"Wer ist die allerbeste Prinzessin mit Ballon!"
		};
		mirror2Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Gehen wir."
		};
		mirror2Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Ballon."
		};
		boTrainBar = new string[5]
		{
			"Daddy, können wir hier raus?",
			"Es riecht nach Kacka ...",
			"Tut mir leid ...",
			"Es riecht nach ...",
			"Fäkalien ..."
		};
		boTrainBarChoice1 = new string[4]
		{
			string.Empty,
			"Sicher.",
			string.Empty,
			string.Empty
		};
		boTrainBarChoice2 = new string[5]
		{
			string.Empty,
			"Sowas sagt man nicht!",
			string.Empty,
			string.Empty,
			"Bo!"
		};
		boJumpingBean = new string[8]
		{
			"Du siehst aus wie eine Hüpfbohne, Sherlock.",
			"„Hüpf, hüpf, Hüpfbohne, ist nicht gemein, er ist so klein.“",
			"„Hüpf, hüpf, juchu, juchu, juche.“",
			"„Er ist ein kleiner Hüpfer mit einer Tuut, Tuut, Tuut.“",
			"Ich mag diese Show.",
			"Sie ist so komisch ...",
			"Ich wusste gar nicht, dass du diese Show magst, Sherlock!",
			"Ich dachte, du magst nur dein Rauchen und Täter ’mitteln!"
		};
		boJumpingBeanChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Okay ..."
		};
		boJumpingBeanChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Ich auch!"
		};
		boTrainButtonSolution = new string[4]
		{
			"Ich möchte nicht ... respektlos sein, oder so ...",
			"Aber ... weißt du, was du tust?",
			"Ich bin froh, dass wir ’Mittlungspartner sind, Sherlock!",
			"Drücke die Tasten, wenn beide gelb sind!"
		};
		boTrainButtonSolutionChoice1 = new string[4]
		{
			string.Empty,
			"Natürlich!",
			string.Empty,
			string.Empty
		};
		boTrainButtonSolutionChoice2 = new string[4]
		{
			string.Empty,
			"Nicht wirklich ...",
			string.Empty,
			"Gute Denkarbeit, Watson!"
		};
		bo2 = new string[1]
		{
			"Schau, ein Ballon, Daddy!"
		};
		bo2Choice1 = new string[1]
		{
			string.Empty
		};
		bo2Choice2 = new string[1]
		{
			"Halt, Bo!"
		};
		bo3 = new string[3]
		{
			"Armer Georgie ...",
			".........................................................",
			"Er ist in diese Kiste eingesperrt ..."
		};
		bo3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bo3Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Okay."
		};
		bo32 = new string[3]
		{
			"...................",
			"Er kann wahrscheinlich die Chipskrümel auf deiner Jacke riechen ...",
			"Es ist nicht sehr nett, ihn so zu triezen ..."
		};
		bo33 = new string[3]
		{
			".......................",
			"Georgie mag Löwenherz-Chips aus Martins Lebensmittelladen. Die mit Fleischgeschmack ...",
			"Und wenn du keine für ihn hast, solltest du dich vielleicht wieder deinen Aufgabe zuwenden, Mister ..."
		};
		pinstripeTrain1 = new string[7]
		{
			"Guten Morgen, Ted ...",
			"Und wer mag das sein?",
			"Hallo Bo ...",
			"Magst du Ballons?",
			"Wie wäre es mit einem glänzenden schwarzen?",
			"Nur ein freundlicher Mann ...",
			"Mit einem glänzenden schwarzen Ballon ..."
		};
		pinstripeTrain1Choice1 = new string[7]
		{
			"Ähm ...",
			string.Empty,
			string.Empty,
			string.Empty,
			"Nein, danke ...",
			string.Empty,
			string.Empty
		};
		pinstripeTrain1Choice2 = new string[7]
		{
			"Guten Morgen?",
			"Ähm ... das ist Bo.",
			string.Empty,
			string.Empty,
			"Wer bist du?",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2 = new string[4]
		{
			"Oh, und Bo ...",
			"Ich mag dein Kleid ...",
			"Ohhh ... das ist aber nicht sehr nett ...",
			"Bo, dein Daddy ist solch ein Rüpel ..."
		};
		pinstripeTrain2Choice1 = new string[4]
		{
			string.Empty,
			"Gehen wir, Bo ...",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2Choice2 = new string[4]
		{
			string.Empty,
			"Lass uns in Ruhe, Widerling.",
			string.Empty,
			"Komm, Bo."
		};
		pinstripeHanglyPass = new string[10]
		{
			"Hallo Ted ...",
			"Ohhhhh ... Du hast diese stinkende Mottenkugel Dicky gebeten, dir bei der Suche nach Bo zu helfen ...",
			"Mein Instinkt sagt mir, dass der Rücken des alten Dicky so stark ist wie ...",
			"... eine alberne Holzpuppe ...",
			"Also denke ich, dass Bo einfach etwas Zeit mit mir in meinem kleinen Pfarrhaus verbringen wird ...",
			"Ja ... Ich denke, genau das werden wir tun ...",
			"Du unfassbar dämlich aussehender Schwachkopf!",
			"Wie bitte?",
			"Wie bitte, Vollhorst?",
			"Kein Wunder, dass ein Versager wie du sich den stinkenden Reihen der Verdammten angeschlossen hat ..."
		};
		pinstripeHanglyPassChoice1 = new string[11]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"(Reiß dich zusammen.)",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeHanglyPassChoice2 = new string[7]
		{
			"Bring mich zu Bo!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Wie alt bist du, zehn?"
		};
		pinstripeCave = new string[7]
		{
			"Hallo Ted ...",
			"Ich muss sagen ... Ich bin ziemlich beeindruckt ...",
			"Leider hat Bo etwas Zeit damit verbracht ...",
			"... in meinem Pfarrhaus abzuhängen ...",
			"Ich freue mich darauf, deine schnieke Visage bei der Zeremonie zu sehen ...",
			"Der Adoptionszeremonie, KACKBRATZE!",
			"Tschüssi, mein Großer ..."
		};
		pinstripeCaveChoice1 = new string[8]
		{
			string.Empty,
			"Okay",
			string.Empty,
			string.Empty,
			"Okay.",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveChoice2 = new string[8]
		{
			string.Empty,
			"Wo ist Bo?",
			string.Empty,
			string.Empty,
			"Welche Zeremonie?",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExit = new string[10]
		{
			"Haben dir meine putzigen Nachrichten an den Wänden gefallen?",
			"Ich konnte es einfach nicht lassen, Ted.",
			"Bo gehört mir, du EITERBEULE!",
			"„Daddy, Daddy, rette mich!“",
			"Ahahahahaha ... Tut mir leid, Bo!",
			"Dein Daddy läuft herum wie ein BESCHEUERTER IDIOT!",
			"Ahahahahahahahaha ...",
			"Ich kann DIE ZEREMONIE KAUM ERWARTEN!",
			"An deinem kleinen blassen Pupsgesicht werden die Tränen herunterlaufen, Ted ...",
			"Und meine Haut wird vor Aufregung prickeln, wenn ich es sehe ..."
		};
		pinstripeCaveExitChoice1 = new string[10]
		{
			"Nein.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExitChoice2 = new string[10]
		{
			"Ja.",
			"Bring mich zu Bo!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill = new string[9]
		{
			"Du kommst gerade recht zur Zeremonie, Ted.",
			"Ohhh ... Sei doch nicht so ANGEPISST!",
			"Um ehrlich zu sein, Bo wird bei mir viel glücklicher sein ...",
			"Also, bleibst du zur Zeremonie?",
			"Die Uhr tickt, Ted ...",
			"DU DUMMER KLEINER PISSER!",
			"Versuch es.",
			"Aber wenn du dich nicht an den gesegneten Tag erinnern kannst, an dem du gestorben bist ...",
			"Wird Bo für immer mir gehören ..."
		};
		pinstripeWindmillChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"(Reiß dich zusammen.)",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmillChoice2 = new string[10]
		{
			"Lass Bo gehen!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Dafür wirst du bezahlen, Schwein!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2 = new string[8]
		{
			"Ohhh ... Du hast gerade die Zeremonie verpasst, Ted ...",
			"Sieh mal, wie niedlich ihr kleines Gesichtchen ist ...",
			"Hast du etwas zu sagen, Liebling?",
			"Geh nach Hause, Ted ...",
			"Ich habe jetzt einen neuen Daddy ...",
			"Er passt auf mich auf und liebt mich innig ...",
			"ES IST VORBEI, TED!",
			"Zu schade, dass es keine Möglichkeit gibt, die Zeit zurückzudrehen."
		};
		pinstripeWindmill2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Okay.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2Choice2 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Bo, ich bin es!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrain = new string[8]
		{
			"Möchtest du mit mir Zug spielen, Ted?",
			"Du kannst der Fahrer sein ...",
			"Der klitzekleine Fahrer ...",
			"Ist dein armes kleines Baby oben?",
			"Brennend und sterbend?",
			"Du krächzender kleiner PISSER!",
			"Ich wohne jetzt hier, Junge ...",
			"Mit meinem neuen Daddy ..."
		};
		boWithTrainChoice1 = new string[10]
		{
			"Sicher!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrainChoice2 = new string[3]
		{
			"Bo, gehen wir!",
			"Komm schon, Bo!",
			string.Empty
		};
		hiveTrain = new string[3]
		{
			"..................... Eklig!",
			"Es sieht aus wie ein riesiger alter Sack ...",
			"Mir wird ganz schwindelig ..."
		};
		hiveTrain2 = new string[2]
		{
			"Daddy, ich glaube, du solltest aufhören, daran zu riechen ...",
			"Es sieht nicht aus, als wäre es gut für dich."
		};
		hiveTrain3 = new string[4]
		{
			"Jetzt sieh dir an, was du gemacht hast, Daddy!",
			"Mommy wäre gar nicht zufrieden mit dir ...",
			"Sie hat mir immer gesagt, ich soll nicht an Dingen riechen, die komisch aussehen ...",
			"Wie dieses braune Ding, das ich unter dem Kühlschrank gefunden habe ..."
		};
		scarf = new string[3]
		{
			"Bos Schal ...",
			"Er riecht nach Rauch ...",
			"... und Whiskey ..."
		};
		scarfChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		scarfChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Nehmen."
		};
		bigTree = new string[2]
		{
			"... Füttereeee ...",
			"... miiiich ..."
		};
		bigTreeChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bigTreeChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Füttern"
		};
		oldManV2 = new string[12]
		{
			"... Eeh! ...",
			"Ted?",
			"Erkennst du dieses sexy Gesicht nicht, Schwein? Ich bin es ... Mr. Dicky ...",
			"Verschwinde einfach von hier, Junge ...",
			"Willkommen in der Hölle, Kleiner. Und jetzt hau ab!",
			"... Pinstripe ...",
			"Ich glaube, ich weiß, wo sie ist, Ted!",
			"... Das Hangly House ...",
			"Aber ich weiß nicht, wie du deinen lächerlichen Körper ohne Waffe verteidigen willst ...",
			"Bis du eine gefunden hast, kann ich dir leider nicht helfen ...",
			"Ich hab nicht geheult, ich habe ...",
			"Ähm ... gelacht ..."
		};
		oldManV2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vielen Dank, werter Herr!"
		};
		oldManV2Choice2 = new string[10]
		{
			"Hilfe!",
			"Kenne ich dich?",
			string.Empty,
			"Aber ich brauche Hilfe!",
			"Meine Tochter wurde entführt!",
			"Wer?",
			string.Empty,
			string.Empty,
			string.Empty,
			"Nun, dann bist du eine Heulsuse ..."
		};
		oldManV22 = new string[5]
		{
			"Was ... Was starrst du denn so?",
			"Sind es meine Muttermale? Ich habe frische, aufmüpfige Muttermale an meinem Haarkranz. Aber die sind genetisch vererbt, ich schwöre es!",
			"Meine Mutter hat mir immer gesagt, sie wären ein Geschenk Gottes ...",
			"Aber ich wollte sie von Dr. Shrenweld entfernen lassen, weil ich wusste, dass Birdy einfach zu schön für mich war ...",
			"Während der gesamten Schulzeit habe ich wie ein deformierter Clown ausgesehen ..."
		};
		oldManV23 = new string[5]
		{
			"Diese Muttermale sind keine Zirkusnummer!",
			"Können sie Einrad fahren, Narr? Können sie?",
			"Können sie eine vierbeinige Bestie dressieren? Nein! Nein!",
			"Wurde deine Tochter nicht entführt? Und du ... überlegst ...",
			"Meine Muttermale zu einer verdammten Zirkusnummer zu machen!"
		};
		hive = new string[2]
		{
			"Einer dieser Säcke ...",
			"... mit einem riech-tig tollen Geruch."
		};
		hiveChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		hiveChoice2 = new string[2]
		{
			string.Empty,
			"Nehmen."
		};
		felix1 = new string[5]
		{
			"....................................................... Hey!",
			"Hier oben!",
			"Warum bist du wie ein verdammter Priester angezogen?",
			"....................................",
			"Hast du diese Sackdinger ausprobiert?"
		};
		felix1Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		felix1Choice2 = new string[5]
		{
			"Hallo ...",
			string.Empty,
			"Ähm ...",
			string.Empty,
			"Nein."
		};
		felixHurt = new string[3]
		{
			"................................",
			"... Ähm ... Nicht cool, Bruder.",
			"... Ahh ... Das hat wirklich meine Gefühle verletzt ..."
		};
		felixHurtChoice1 = new string[2]
		{
			string.Empty,
			"Tut mir leid!"
		};
		felixHurtChoice2 = new string[2]
		{
			string.Empty,
			"Hat bestimmt wehgetan, oder?"
		};
		drunkMan3 = new string[5]
		{
			"............................",
			"Dieser Typ, Pinstripe, hat Klasse ...",
			"Diese aufrichtige Klasse ...",
			"..........................................................................................................................................",
			"Hast du das gehört?"
		};
		drunkMan3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Wenn du das sagst, Mann!"
		};
		drunkMan3Choice2 = new string[3]
		{
			"Hallo noch einmal.",
			string.Empty,
			"Du müffelst ein bisschen."
		};
		poolTableMan = new string[3]
		{
			"Runter vom Tisch, Drecksack.",
			"Ich bin mitten in einem Spiel ...",
			"Nur weil du ein Vater bist, bist du noch lange nicht mein Daddy. Ich sagte runter vom Tisch, Drecksack ..."
		};
		poolTableManChoice1 = new string[4]
		{
			string.Empty,
			"Tut mir so leid!",
			string.Empty,
			string.Empty
		};
		poolTableManChoice2 = new string[4]
		{
			string.Empty,
			"Dein Atem ...",
			string.Empty,
			string.Empty
		};
		dog2 = new string[10]
		{
			"Danke dafür, Ted! ...",
			"Ich hatte mich schon gefragt, ob ich da jemals rauskommen würde ...",
			"Hey ... Wo ist Bo?",
			"Arghhh ... Das hatte ich befürchtet ...",
			"Tja, wir müssen sie holen, Mann ...",
			"Ich frage mich, ob ich dabei helfen kann, einige Hinweise zu erschnüffeln oder so ...",
			"Da wir gerade darüber sprechen, ist Mr. Dicky hier irgendwo?",
			"Ja ... Ich könnte seinen Hintern aus einer Meile Entfernung riechen ...",
			"Dieser Typ, Pinstripe ...",
			"Er ist so ein Arsch!"
		};
		dog2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Okay",
			string.Empty,
			"Tut mir leid, Mann!"
		};
		dog2Choice2 = new string[10]
		{
			"Du kannst reden!",
			string.Empty,
			"Pinstripe hat sie entführt!",
			string.Empty,
			"Tun wir es!",
			string.Empty,
			"Ja",
			"Warum warst du eingesperrt?",
			string.Empty,
			"Du bist ein Idiot ..."
		};
		dogBoSmell = new string[7]
		{
			"Whoa!",
			"Riechst du das, Ted?",
			"Riecht nach ... Äpfeln ...",
			"Ich nicht so ...",
			"Ich mag gern Käse und Kuchen und alles, was nach Fleisch riecht ...",
			"Ja ... Tut mir leid.",
			"Gehen wir."
		};
		dogBoSmellChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			"Okay.",
			string.Empty,
			string.Empty
		};
		dogBoSmellChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			"Bo liebt Äpfel.",
			"Hmm.",
			string.Empty
		};
		dog3 = new string[2]
		{
			"Ted ...",
			"Los, finde Bo ..."
		};
		dogPraise1 = new string[1]
		{
			"Gute Denke, Ted!"
		};
		dogBalloonPop = new string[3]
		{
			"Ah! Alter! Ich erschrecke mich jedes Mal, wenn du diese Ballons platzen lässt.",
			"Würde es dich stören, das ... nicht ... zu machen?",
			"So wird es also sein, hm?"
		};
		dogBalloonPopChoice1 = new string[2]
		{
			string.Empty,
			"Tut mir leid, George!"
		};
		dogBalloonPopChoice2 = new string[2]
		{
			string.Empty,
			"Ähm ... Nein."
		};
		dogBalloonPop2 = new string[3]
		{
			"DAH!",
			"Ted! Die Ballons ...",
			"Ernsthaft?"
		};
		dogBalloonPop2Choice1 = new string[2]
		{
			string.Empty,
			"Tut mir leid!"
		};
		dogBalloonPop2Choice2 = new string[2]
		{
			string.Empty,
			"Lol."
		};
		recordPlayer1 = new string[3]
		{
			"Der Plattenspieler ist mit roten Federn bedeckt ...",
			"Die Platte heißt „Miss Birdy Bondette: Intermezzos & andere Erwägungen“.",
			"Dieses Lied heißt „Das Letzte Lächeln“."
		};
		recordPlayer1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer1Choice2 = new string[3]
		{
			string.Empty,
			"Abspielen",
			string.Empty
		};
		recordPlayer12 = new string[2]
		{
			"Wirklich wunderschöne Musik ...",
			"Ich fühle mich wie im Hundehimmel ..."
		};
		recordPlayer12Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer12Choice2 = new string[3]
		{
			string.Empty,
			"Okay.",
			string.Empty
		};
		recordPlayer2 = new string[3]
		{
			"Hey! Es ist eine von Miss Birdys wehmütigen Platten!",
			"Spielen wir sie ab, Ted!",
			"„Der Letzte Gang“ ... Das ist ein trauriger Titel ..."
		};
		recordPlayer2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer2Choice2 = new string[3]
		{
			string.Empty,
			"Abspielen",
			string.Empty
		};
		recordPlayer22 = new string[2]
		{
			"Mmmmmmmmmmmmmmmm ... So schön. Ich wünschte, es würde so riechen wie es klingt.",
			"Aber es riecht einfach nur nach Oma ..."
		};
		recordPlayer22Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer22Choice2 = new string[3]
		{
			string.Empty,
			"Okay.",
			string.Empty
		};
		recordPlayer3 = new string[4]
		{
			"Noch eine von Miss Birdys Platten ...",
			"An der Seite ist eine Notiz befestigt ...",
			"„Teddy, ich habe dieses Lied für Bo geschrieben. Ich bedaure deinen Verlust. – Miss Birdy“",
			"Es heißt ... „Die Letzte Umarmung“."
		};
		recordPlayer3Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer3Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Abspielen",
			string.Empty
		};
		recordPlayer32 = new string[3]
		{
			"Es ist so ... traurig ...",
			"Wir können Bo immer noch retten ... oder?",
			"Es wird alles gut werden, Ted ..."
		};
		recordPlayer32Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer32Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dogRecordPlayer = new string[1]
		{
			"Dieses Lied ist unheimlich ..."
		};
		dogRecordPlayerChoice1 = new string[1]
		{
			string.Empty
		};
		dogRecordPlayerChoice2 = new string[1]
		{
			"Jep."
		};
		dogPoop = new string[4]
		{
			"Argh ... Ein Haufen der Kleinen Dame ...",
			"Wenn du sie siehst ... musst du ihr auf den Hintern springen, Mann ...",
			"Moment, Moment, Moment ...",
			"Ich bin ein sprechender Hund und du machst die Gedanken über meinen Akzent?"
		};
		dogPoopChoice1 = new string[2]
		{
			string.Empty,
			"Danke für den Tipp!"
		};
		dogPoopChoice2 = new string[2]
		{
			string.Empty,
			"Was ist los mit deinem Akzent, Dummerchen?"
		};
		dogMushroom = new string[5]
		{
			"Ein glühender Pilz ...",
			"Dieser hier reicht besonders nach Kerosin ...",
			"Hey Ted, erinnerst du dich daran, diese Dinger überall in Edge Wood und am Hangly Pass gesehen zu haben?",
			"Ich weiß nicht ... Vielleicht können wir ein paar von diesen Gefrorenen Tropfendingern finden, indem wir sie entzünden oder so ...",
			"Ich versuche nur zu helfen ..."
		};
		dogMushroomChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Gute Denkarbeit, George!"
		};
		dogMushroomChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Ja, na und?",
			"Ähm ... Duh."
		};
		dogCaveJumpComment = new string[1]
		{
			"Geschafft!"
		};
		dogCaveJumpCommentChoice1 = new string[1]
		{
			string.Empty
		};
		dogCaveJumpCommentChoice2 = new string[1]
		{
			"Danke!"
		};
		caves = new string[2]
		{
			"Diese Höhle sieht dunkel und böse aus ...",
			"Es ist stockfinster und nichts ist zu sehen ..."
		};
		caves2 = new string[2]
		{
			"Ein ominöses, furchterregendes Geräusch ertönt aus der Tiefe ...",
			"..........................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................."
		};
		flashLightTalk = new string[3]
		{
			"Coole Stirnlampe!",
			"Sie ist gesäumt mit ... Blumenzeichnungen ...",
			"Wähle das Symbol, um sie an- und auszuschalten."
		};
		flashLightTalkChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		flashLightTalkChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Nehmen."
		};
		lewis = new string[5]
		{
			"... Arghhh ... Oooohh ... Oooooohhh ...",
			"Mein Rücken schmerzt wie die Hölle!",
			"Jetzt hör zu, Rotznase, wir haben nicht viel Zeit ...",
			"Ähhh ... Bo ist oben auf dem Berg ... im ... Hangly House ...",
			"Ich würde gerne sehen, wie diese zarten Streichholzbeinchen in meinem Alter diesen Berg hochklettern würden ..."
		};
		lewisChoice1 = new string[5]
		{
			string.Empty,
			"Tut mir leid!",
			string.Empty,
			"Okay.",
			string.Empty
		};
		lewisChoice2 = new string[5]
		{
			"Alles okay, Dicky?",
			"Du bist alt.",
			string.Empty,
			"Kommst du nicht?",
			"Okay."
		};
		lewis2 = new string[4]
		{
			"Du läufst herum wie ein Trottel ...",
			"Als ich in deinem Alter war, habe ich 80 Stunden pro Woche im Stahlwerk meines Vaters gearbeitet ...",
			"Jeden Tag schlug er mich mit der blanken Faust ...",
			"Ich ... Ich habe die Narben immer noch ..."
		};
		oldManStartWalking = new string[4]
		{
			"Warum hat das so lange gedauert, Hungerhaken!",
			"Wir treffen uns oben am Hangly House ...",
			"Ich hab es doch gesagt! Das Hangly House ... oben auf dem Berg ...",
			"Ich bin sicher, dass Pinstripe Bo dort gefangen hält ..."
		};
		oldManStartWalkingChoice1 = new string[4]
		{
			string.Empty,
			"Okay.",
			string.Empty,
			"Wir treffen uns da!"
		};
		oldManStartWalkingChoice2 = new string[4]
		{
			string.Empty,
			"Wo?",
			string.Empty,
			"Einverstanden. Boah, alter Mann ..."
		};
		key = new string[2]
		{
			"Ein silberner Schlüssel ...",
			"In den Griff ist ein winziges „P“ eingeritzt ..."
		};
		keyChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		keyChoice2 = new string[2]
		{
			string.Empty,
			"Nehmen."
		};
		goldKeyTalk = new string[1]
		{
			"Ein goldener Schlüssel ..."
		};
		rifle = new string[4]
		{
			"Ein altes Gewehr ...",
			"Ha, das ist cool ...",
			"Es heißt „Grenzenloser Singvogel“ ... Es ist im Schaft eingeritzt ...",
			"Ich frage mich, warum es so heißt?"
		};
		rifleChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		rifleChoice2 = new string[4]
		{
			"Nett!",
			string.Empty,
			string.Empty,
			"Nimm es!"
		};
		oldWomanPorch = new string[8]
		{
			"Ach du meine Güte ...",
			"Teddybär? Bist du das?",
			"Schön, dich zu sehen, Teddy!",
			"Wo ist meine kleine Freundin Bo?",
			"Oh, hat er das?",
			"Ich fürchte, Dicky hat dich übers Ohr gehauen ...",
			"Also ... holst du mich aus dieser Falle raus oder nicht?",
			"Hehehehe ... schön!"
		};
		oldWomanPorchChoice1 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Sicher!"
		};
		oldWomanPorchChoice2 = new string[8]
		{
			string.Empty,
			"Ja?",
			string.Empty,
			"Dicky hat gesagt, sie wäre hier ...",
			string.Empty,
			"Oh ...",
			"Nein danke, Taubenfurz.",
			string.Empty
		};
		dogBirdyCommentNice = new string[10]
		{
			"Ich nehme an, das war Absicht?",
			"Trotzdem, ich denke, du hast sie wahrscheinlich getötet ...",
			"Immerhin warst du nett zu ihr, bevor sie in ihren Tod gestürzt ist ...",
			"Sie war wirklich eine nette alte Dame.",
			"... Ähm ...",
			"Auf Miss Birdy ...",
			"Möge ihre Seele fliegen ... für immer und ewig ...",
			"Durch die Höhen ...",
			"Und in den Himmel ...",
			"Amen ..."
		};
		dogBirdyCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Das war sie ..."
		};
		dogBirdyCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Sag ein paar Worte, George."
		};
		dogBirdyCommentMean = new string[6]
		{
			"Alter ... du hast sie umgebracht!",
			"Erst nennst du sie einen Taubenfurz, und jetzt das?!",
			"Ja ... Ich meine, versteh mich nicht falsch ...",
			"Sie hat wirklich gerochen wie ein Taubenfurz ...",
			"Aber egal!",
			"Du hast sie gerade umgebracht!"
		};
		dogBirdyCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			"Tut mir leid ...",
			string.Empty,
			string.Empty
		};
		dogBirdyCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			"Sie hat nach Furz gerochen.",
			string.Empty,
			"Ja ..."
		};
		dogBarCommentMean = new string[6]
		{
			"Mann, du hast diesen Typen wirklich verärgert ...",
			"Von nun an ... verhalte dich einfach so, als würdest du zur Gruppe gehören ...",
			"In Zeiten wie diesen willst du dich doch nicht umhauen lassen, oder?",
			"Du siehst trendy und hip und so aus, Ted ...",
			"Aber deine Arme sind ...",
			"... knochig ..."
		};
		dogBarCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Ich glaube, du hast recht ...",
			string.Empty
		};
		dogBarCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Ich komm schon klar!",
			string.Empty
		};
		dogBarCommentNice = new string[4]
		{
			"Ähm ... meinst du das ernst?",
			"Du willst in einer Nacht wie dieser wirklich mit allen feiern?",
			"Ted ... was ist mit Bo?",
			"Ja, das ist nicht cool, Mann ..."
		};
		dogBarCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			"Natürlich nicht!",
			string.Empty,
			string.Empty
		};
		dogBarCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			"Sicher!",
			"Ja ...",
			string.Empty
		};
		floatingPeople = new string[18]
		{
			"Hahahahehehe ... Oh Teddy, das war der Wahnsinn!",
			"Aber Dicky hat dir etwas zu sagen, nicht wahr, Dicky?",
			"Arghhh ... Ich habe gelogen ... ich wollte doch nur Hilfe dabei haben, meine kleine Birdy zu finden ...",
			"Pinstripe wohnt unten in Red Wash ...",
			"... Ein See, tief im Inneren der Hölle.",
			"Ich befürchte, er hat deine süße Bo in seinem gruseligen Pfarrhaus eingesperrt ...",
			"Um dorthin zu gelangen, brauchst du Licht ...",
			"... Sehen wir mal, ob ich es noch habe ...",
			"... Ah, oh, ja, hier ist es ...",
			"Eines Abends, nachdem Bo und ich mit ihren Spielzeugen gespielt hatten, gab sie mir dieses seltsame Stück Papier ...",
			"Ich frage mich, ob es dir dabei helfen könnte, Licht zu finden ...",
			"Du kannst den Hinweis später untersuchen, wenn du ihn vergisst ...",
			"Siehst du das HINWEISSYMBOL unten auf dem Bildschirm blinken?",
			"Dort kannst du dir alle HINWEISE ansehen, die du auf deiner Reise gefunden hast ...",
			"Untersuche sie genau ...",
			"Wie auch immer ...",
			"Wir treffen uns unten in Red Wash ...",
			"Ich bin sicher, dass wir Bo finden werden, Liebling ..."
		};
		floatingPeopleChoice1 = new string[14]
		{
			string.Empty,
			"Es ist in Ordnung, Dicky ...",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		floatingPeopleChoice2 = new string[18]
		{
			"Jep.",
			"Lass hören, Bastard ...",
			"Aber wo ist Bo?",
			string.Empty,
			string.Empty,
			"Okay.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Danke.",
			string.Empty,
			"Ja.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Okay."
		};
		dogHintChest = new string[5]
		{
			"Ted! Erinnerst du dich an die Spielzeugtruhe in dem Baum in Edge Wood?",
			"Vielleicht hat sie etwas mit Miss Birdys Hinweisen auf das Licht zu tun ...",
			"Das Licht, das du benötigst, um nach Red Wash zu gelangen ...",
			"Vergiss nicht, deine Hinweise zu überprüfen, Mann ...",
			"Siehst du das Hinweissymbol unten links auf dem Bildschirm?"
		};
		dogHintChestChoice1 = new string[3]
		{
			string.Empty,
			"Okay.",
			string.Empty
		};
		dogHintChestChoice2 = new string[3]
		{
			string.Empty,
			"Welches Licht?",
			string.Empty
		};
		telephone = new string[3]
		{
			"... Daddy ...",
			"Bist du das?",
			"... Hilf mir, Daddy!"
		};
		pinstripeManBoss = new string[3]
		{
			"DU STÜCK DRECK!",
			"Du hast unsere perfekte und geschätzte Vereinigung gestört!",
			"Zeit zu brennen, TEDDYLEIN!!!!!"
		};
		houseLockedGold = new string[1]
		{
			"Die Tür ist mit einem goldenen Schloss verschlossen ..."
		};
		houseLockedMechanism = new string[1]
		{
			"Die Tür ist mit irgendeinem Mechanismus verschlossen ..."
		};
		houseLockedMechanismChoice1 = new string[1]
		{
			string.Empty
		};
		houseLockedMechanismChoice2 = new string[1]
		{
			"Untersuchen."
		};
		houseLockedSilver = new string[1]
		{
			"Die Tür ist mit einem silbernen Schloss verschlossen ..."
		};
		houseLocked2 = new string[1]
		{
			"Die Tür ist verschlossen ..."
		};
		sign1 = new string[2]
		{
			"Oben: Der Hangly Pass",
			"Unten: Red Wash"
		};
		sign2 = new string[1]
		{
			"Nach Red Wash ..."
		};
		signPissward = new string[2]
		{
			"„Nach Red Wash ...“",
			"„Kaufe Tickets von Happy’s.“"
		};
		signBalloonShop = new string[4]
		{
			"„Der Verzehr meiner Tempopilze ist streng verboten.“",
			"„Nebenwirkungen umfassen: Übelkeit, Durchfall, Selbstmordgedanken ...“",
			"„Oder eine +1 Aufwertung der SG (Schussgeschwindigkeit) des Spielers ...“",
			"„Also tu es nicht! – Princles Ballonladen“"
		};
		liftPower = new string[3]
		{
			"Ein Wasserrad oder sowas ...",
			"Sieht aus, als könnte es den Lift antreiben ...",
			"Aber ... wo ist das Wasser?"
		};
		signPissward2 = new string[2]
		{
			"Sieht aus wie eine Gasleitung ...",
			"„Gasleitung erreicht Edge Woods, Hangly Pass, Sack Chute, Pissward Falls und Red Wash ...“"
		};
		signPissward2Choice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signPissward2Choice2 = new string[2]
		{
			string.Empty,
			"Untersuchen."
		};
		signHappySafe = new string[2]
		{
			"Ein riesiger Safe?",
			"„Denk nicht einmal daran, Narr. – Happy“"
		};
		signHappySafeChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signHappySafeChoice2 = new string[2]
		{
			string.Empty,
			"Untersuchen."
		};
		signTimsShop = new string[2]
		{
			"Eine gekritzelte Notiz ...",
			"„Versuche zu schlafen. Wach um 20:10 Uhr ...“"
		};
		signTimsShopChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signTimsShopChoice2 = new string[2]
		{
			"Untersuchen.",
			string.Empty
		};
		pisswardMan1 = new string[13]
		{
			"Hallo Pater ...",
			"Willkommen in Pissward Falls, Heimat von Pissy, der Pissschlange ...",
			"Lifttickets nach Red Wash kosten 300 Gefrorene Tropfen ...",
			"Vielen Dank für deinen Kauf, Pater ...",
			"Ohhhh ... Schön ...",
			".............. Oooh ... Das ist schön ... Oooh, wow ...",
			"Ich werde diese Tropfen nach Red Wash mitnehmen und versuchen zu schlafen ...",
			"Ich habe nicht geschlafen seit ...",
			"Wie lange ist es her?",
			"Ich kann mich nicht erinnern ...",
			"... Gibt doch nichts besseres, als diese Gefrorenen Tropfen zu zerbröseln und wegzudösen ...",
			"Gott segne Pinstripe. Gott segne seine aufrichtige Seele ...",
			"Hier ist dein Liftticket, Pater ..."
		};
		pisswardMan1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Nein danke."
		};
		pisswardMan1Choice2 = new string[3]
		{
			"Hallo.",
			string.Empty,
			"Ticket kaufen (300)."
		};
		happyEdgeWood = new string[14]
		{
			"Hallo Pater ...",
			"Ich bin es, Happy ...",
			"Oh, du kennst mich, Ted!",
			"Bos Freund?",
			"Nun, wie auch immer, du siehst gerade ziemlich besorgt aus ...",
			"Ich wünschte, ich könnte dir ein Getränk einschenken, Kumpel, aber dafür müsstest du nach Red Wash gehen ...",
			"Aber für den richtigen Preis könnte ich dir etwas noch Besseres verkaufen ...",
			"Du solltest diese illegale Tommy-Wumme für 1.000 Gefrorene Tropfen kaufen ...",
			"Danke für deinen Kauf, Pater ...",
			"Sag hallo zu Mr. Tommy ...",
			"So eine Waffe lässt dich supersexy aussehen ...",
			"Ich wünschte, ich hätte eine Kamera dabei, um schnell ein Foto für meine Mutter zu machen ...",
			"Wie auch immer ... Jetzt kannst du deinen süßen Schatz retten wie ein echter Gangsta ...",
			"Hau rein, Kollege ..."
		};
		happyEdgeWoodChoice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Nein danke."
		};
		happyEdgeWoodChoice2 = new string[8]
		{
			"Kenne ich dich?",
			"Wer?",
			string.Empty,
			"Nö.",
			"Was?",
			string.Empty,
			string.Empty,
			"Kaufen (1.000)."
		};
		happyHangly = new string[13]
		{
			"Hallo Pater ...",
			"Für den richtigen Preis kann ich dir ein paar tolle Sachen verkaufen ...",
			"Da wir gerade davon sprechen, dein Hündchen friert sich den Popo ab ...",
			"Guck mal, wie er zittert!",
			"Du solltest diesen Hundepulli für 400 Gefrorene Tropfen kaufen ...",
			"Vielen Dank für deinen Kauf, Pater ...",
			"So ein Süßer! Sieh ihn dir an, kuschelig und warm ...",
			"Den Pulli hat meine Mutter selbst gestrickt ...",
			"Ich wette, ihm wird schon ganz warm, schön gemütlich ...",
			"... jeden Augenblick ...",
			"Danke für die Gefrorenen Tropfen übrigens ...",
			"Wenn du noch irgendetwas brauchst, such einfach nach dem kleinen Friseursalon-Dings ...",
			"Es ist gelb und dreht sich ..."
		};
		happyHanglyChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Nein danke."
		};
		happyHanglyChoice2 = new string[5]
		{
			"Hallo.",
			string.Empty,
			string.Empty,
			string.Empty,
			"Kaufen (400)."
		};
		happyCave = new string[10]
		{
			"Hallo Pater ...",
			"Also, was hältst du von diesem Höhlensystem?",
			"Nun, ich denke, Pinstripe war hier unten ganz schön fleißig ...",
			"Aber es ist auch verdammt kalt ...",
			"Hätte auf den Atem meiner Mutter schwören können, dass es unter der Erde wärmer ist ...",
			"Da wir gerade davon reden, Mr. Pinstripe hat mir einen zusätzlichen Anzug gegeben ...",
			"Lass mich, lass mich mal sehen, ob ich ... äh ... ob ich ihn hier drin finden kann ...",
			"Ah, ja, richtig. Hier, das ist er. Ich verkaufe dir seinen Anzug für 500 Gefrorene Tropfen ...",
			"Danke für deinen Kauf, Pater ...",
			"........ Du siehst genauso aus wie er, Ted! ..."
		};
		happyCaveChoice1 = new string[8]
		{
			string.Empty,
			"Alles cool.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Nein danke."
		};
		happyCaveChoice2 = new string[8]
		{
			"Hallo Happy.",
			"Ich bin nicht beeindruckt.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Kaufen (500)."
		};
		timRedWash1 = new string[11]
		{
			"Hallo Pater ...",
			"Also, wegen der Gefrorenen Tropfen, die du mir in Pissward gegeben hast ...",
			"Nun ... anscheinend waren es nicht genug, um mich schlafen zu lassen, so wie ich dachte ...",
			"Also, hör zu. Ich kann dir helfen, Bo vor Pinstripe zu retten ... aber du musst mir einen Gefallen tun ...",
			"Wenn du mir 10 Säcke besorgst ... keine Gefrorenen Tropfen diesmal, sondern die frischen Säcke ... das echte Zeug ...",
			"Dann verkaufe ich dir eine Zeitung ... Aber nicht irgendeine Zeitung ...",
			"Auf ihr steht das Passwort zu Pinstripes Pfarrhaus ...",
			"Also, was sagst du? Diese Säcke sind das einzige Mittel, um mich heute Nacht schlafen zu lassen ...",
			"Pinstripe liefert diese Säcke zu einer bestimmten Zeit aus, Pater ...",
			"Also, hier ist ein kleiner Hinweis darauf, wann das sein wird ...",
			"Sobald du die Säcke gefunden hast, bring sie hierher, damit ich sie auslutschen kann ..."
		};
		timRedWash1Choice1 = new string[18]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash1Choice2 = new string[10]
		{
			"Hallo Happy.",
			"Ja?",
			"Okay.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Sicher!",
			string.Empty,
			"Okay!"
		};
		timRedWash2 = new string[10]
		{
			"Hallo Pater ...",
			"Du kaufst eine Zeitschrift für 10 Säcke? ...",
			"Sie zeigt dir den Hinweis, um in Pinstripes Pfarrhaus zu gelangen ...",
			"Vielen Dank ...",
			"Es ist schon spät ...",
			"Ich schätze mal, ich werde den Laden schließen und mich in den Sack hauen, wenn du verstehst, was ich meine ...",
			"Ich verschlafe den Sturm warm und gemütlich in meinem Laden ...",
			"Das ist Wahnsinn ... Was hast du getan, Pater?",
			"Wie auch immer ... Das Passwort sollte in der Zeitung sein ...",
			"...................... Gute Nacht, Pater ..."
		};
		timRedWash2Choice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			"Noch nicht.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash2Choice2 = new string[10]
		{
			"Hallo Happy.",
			string.Empty,
			"Kaufen (10 Säcke).",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapArea = new string[4]
		{
			"Bos Spielzeugschleuder ...",
			"In das Holz ist „Herzlichen Glückwunsch, Bo“ eingeritzt ...",
			"Klicke oder drücke den Auslöser zum Loslassen.",
			"Du kannst Dinge, z. B. diese Kiste, zerschießen ..."
		};
		blunderBustTapAreaChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapAreaChoice2 = new string[5]
		{
			"Untersuchen.",
			string.Empty,
			string.Empty,
			"Nehmen.",
			string.Empty
		};
		whiskey = new string[1]
		{
			"Eine Whiskeyflasche ..."
		};
		whiskeyChoice1 = new string[1]
		{
			string.Empty
		};
		whiskeyChoice2 = new string[1]
		{
			"Nehmen."
		};
		dan = new string[10]
		{
			"Gesegneten Abend ...",
			"Willkommen in Red Wash ...",
			"Pinstripes Zuflucht des ultimativen Vergnügens.",
			"Bitte trage dich in das Gästeregister ein ...",
			"Hmmmm ... Was für eine schöne Unterschrift ...",
			"Bitte beachte, dass der heutige Abend besonders außergewöhnlich ist ...",
			"Die Zeremonie wird abgehalten, wenn der Mond voll ist ...",
			"Pinstripe findet nicht jeden Tag ein frisches und gut genährtes Kind ...",
			"Also hat Mr. Pinstripe erbeten, dass alle Einwohner ...",
			"der ewiglichen Adoption des Kindes beiwohnen ..."
		};
		danChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Danke!",
			string.Empty,
			string.Empty,
			string.Empty
		};
		danChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Welche Zeremonie?"
		};
		dan2 = new string[7]
		{
			"Die Zeremonie ...",
			"Die Zeremonie jagt mir Schauer über den Rücken ...",
			"Und bringt mich dazu, Milch trinken zu wollen.",
			"Was kapierst du nicht?",
			"Du verstehst nicht einmal die Kapazität eines schönen, warmen Glases Milch?",
			"Warme, warme Milch und eine Adoptionszeremonie, wie ich sie noch nie gesehen habe ...",
			"Das verstehst du natürlich nicht ..."
		};
		dan2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Okay."
		};
		dan2Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Kapier ich nicht ..."
		};
		dan22 = new string[1]
		{
			"Daniel will Milch."
		};
		dan22Choice1 = new string[1]
		{
			string.Empty
		};
		dan22Choice2 = new string[1]
		{
			"Okay."
		};
		dan23 = new string[1]
		{
			"Warme Milch für die Adoption."
		};
		dan23Choice1 = new string[1]
		{
			string.Empty
		};
		dan23Choice2 = new string[1]
		{
			"Okay."
		};
		dan24 = new string[1]
		{
			"Ich wünschte, ich könnte einen Schwall Milch in meinen Mund gießen."
		};
		dan24Choice1 = new string[1]
		{
			string.Empty
		};
		dan24Choice2 = new string[1]
		{
			"Okay."
		};
		dan25 = new string[1]
		{
			"Stell dir eine Pfütze Milch vor, die in meinem Mund ruht."
		};
		dan25Choice1 = new string[1]
		{
			string.Empty
		};
		dan25Choice2 = new string[1]
		{
			"Okay."
		};
		dan26 = new string[1]
		{
			"Milch."
		};
		dan26Choice1 = new string[1]
		{
			string.Empty
		};
		dan26Choice2 = new string[1]
		{
			"Okay."
		};
		dan27 = new string[1]
		{
			"..............................................................."
		};
		dan27Choice1 = new string[1]
		{
			string.Empty
		};
		dan27Choice2 = new string[1]
		{
			"Ähm?"
		};
		kitty2 = new string[4]
		{
			"Oh je, oh je ...",
			"Dein kleines Mädchen ist lebhaft ...",
			"Aber keine Sorge, Ted ...",
			"Sie wird mich bald „Vater“ nennen ..."
		};
		kitty4 = new string[1]
		{
			"........."
		};
		signMegaGem = new string[7]
		{
			"................................ Ein massiver, schwarzer Gefrorener Tropfen ...",
			"„Scoria Sackus von Moonstate: Pinstripes größter verzeichneter Gefrorener Tropfen ...“",
			"„Ausgegraben 323 Meter unter dem Brunnen von Red Wash, in der Außenhaut eines versteinerten Sackes.“",
			"„Wert: 50 Gefrorene Tropfen.“",
			"Riecht nach frischem Haarspray ...",
			"Er ist wirklich sehr schön ...",
			"Sing mich in den Schlaf, Ada ..."
		};
		signMegaGemChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Okay."
		};
		signMegaGemChoice2 = new string[4]
		{
			"Lesen.",
			string.Empty,
			string.Empty,
			"Riechen."
		};
		balloonMan1 = new string[11]
		{
			"Ahhhnngg ... Ich habe nicht gesagt, dass du einfach hier hereinspazieren kannst ...",
			"Aber weißt du was, ich bin froh, dass du es getan hast. Denn jetzt kann ich mit meinen Ballonmaschinen angeben ...",
			"Die Kinder hier nennen mich Princle und ich bin der beste Ballonmacher der Stadt, dank dieser Ballonmaschinen ...",
			"Pinstripe hat einen ganzen Haufen Ballons bestellt und ich habe die Bestellung erfüllt wie ein Prinz ...",
			"Ja ... In zehn Sekunden oder so ...",
			"Hmmmm ... Ich wette auf meinen riesigen Gefrorenen Tropfen, dass du meine Maschinen in Sachen Geschwindigkeit und Geschicklichkeit nicht schlagen kannst ...",
			"Dein Selbstvertrauen vermehrt sich exzessiv, mein Freund!",
			"Mach dich auf eine Tracht Prügel gefasst!",
			"Auf die Plätze ...",
			"Fertig ...",
			"LOS!"
		};
		balloonMan1Choice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		balloonMan1Choice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Ich nehme die Wette an!"
		};
		balloonMan2 = new string[6]
		{
			"VERLIERER!",
			"Willst du nochmal spielen, Pater?",
			"Mach dich darauf gefasst, eingestampft zu werden, du Schlaftablette!",
			"Auf die Plätze ...",
			"Ferrrrtig ...",
			"LOS!"
		};
		balloonMan2Choice1 = new string[2]
		{
			string.Empty,
			"Nein danke."
		};
		balloonMan2Choice2 = new string[2]
		{
			string.Empty,
			"Tun wir es!"
		};
		balloonMan2b = new string[6]
		{
			"OH CAPTAIN, MEIN CAPTAIN!",
			"Willst du nochmal spielen, Captain?",
			"Ich kann es kaum erwarten, diese Skiiiiiiiillllllllllllzzzzzzzzzz zu sehen!",
			"Auf die Plätze ...",
			"Ferrrrtig ...",
			"LOS!"
		};
		balloonMan2bChoice1 = new string[2]
		{
			string.Empty,
			"Nein danke."
		};
		balloonMan2bChoice2 = new string[2]
		{
			string.Empty,
			"Tun wir es!"
		};
		balloonMan3 = new string[5]
		{
			"ÄHHHHWWAAASSS????!!!!!!",
			"Du bist ... du bist ...",
			"Du bist ERSTAUNLICH! Die notwendigen Qualifikationen, um meine Ballonmaschinen zu schlagen, sind ...",
			"beispiellos! Es ist einfach unmöglich ...",
			"Nimm den Preis, Pater ... Los ... Nimm ihn ..."
		};
		balloonMan3Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Das ist sehr nett!"
		};
		balloonMan3Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Ähm ... duh ..."
		};
		savePortraitGronkh = new string[2]
		{
			"Noch ein Portrait ... eines sehr aggressiv aussehenden Mannes.",
			".................................................. Spiel gespeichert."
		};
		savePortraitGronkhChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkhChoice2 = new string[1]
		{
			"Spiel speichern."
		};
		savePortraitGronkh2 = new string[2]
		{
			"Das Portrait sieht immer noch sehr aggressiv aus ...",
			".................................................. Spiel gespeichert."
		};
		savePortraitGronkh2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh2Choice2 = new string[1]
		{
			"Spiel speichern."
		};
		savePortraitGronkh3 = new string[2]
		{
			"So viel Aggression! Seine Aggression füllt die komplette Leinwand aus!",
			".................................................. Spiel gespeichert."
		};
		savePortraitGronkh3Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh3Choice2 = new string[1]
		{
			"Spiel speichern."
		};
		savePortraitGronkh4 = new string[2]
		{
			"Die Leinwand verströmt ein Gefühl von massiver Aggression. Hauptsächlich wegen des aggressiven Mannes ...",
			".................................................. Spiel gespeichert."
		};
		savePortraitGronkh4Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh4Choice2 = new string[1]
		{
			"Spiel speichern."
		};
		savePortraitDirk = new string[2]
		{
			"Ein Portrait eines gut frisierten Typen ...",
			".................................................. Spiel gespeichert."
		};
		savePortraitDirkChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitDirkChoice2 = new string[1]
		{
			"Spiel speichern."
		};
		savePortraitRMannion = new string[2]
		{
			"Ein Portrait eines trendigen Künstlertypen ...",
			".................................................. Spiel gespeichert."
		};
		savePortraitRMannionChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitRMannionChoice2 = new string[1]
		{
			"Spiel speichern."
		};
		savePortraitJHandville = new string[2]
		{
			"Das Portrait eines Schnurrbarts, der ein Gesicht trägt ...",
			".................................................. Spiel gespeichert."
		};
		savePortraitJHandvilleChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitJHandvilleChoice2 = new string[1]
		{
			"Spiel speichern."
		};
		savePortraitNathanKingston = new string[2]
		{
			"Ein Portrait irgendeines Typen, der wie Jesus aussieht, aber nicht Jesus ist. Schau, sein Name ist nur Nathan ...",
			".................................................. Spiel gespeichert."
		};
		savePortraitNathanKingstonChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitNathanKingstonChoice2 = new string[1]
		{
			"Spiel speichern."
		};
		savePortraitOchoma = new string[2]
		{
			"Ein trauriges, kaltes Portrait ...",
			".................................................. Spiel gespeichert."
		};
		savePortraitOchomaChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitOchomaChoice2 = new string[1]
		{
			"Spiel speichern."
		};
		savePortraitBuddy = new string[2]
		{
			"Ein seltsames Portrait eines Mannes ...",
			".................................................. Spiel gespeichert."
		};
		savePortraitBuddyChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddyChoice2 = new string[1]
		{
			"Spiel speichern."
		};
		savePortraitBuddy2 = new string[2]
		{
			"Immer noch ein seltsames Portrait eines Mannes ... er ist der Glatzen- und Schnurrbarttyp ...",
			".................................................. Spiel gespeichert."
		};
		savePortraitBuddy2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddy2Choice2 = new string[1]
		{
			"Spiel speichern."
		};
		creepyMan = new string[2]
		{
			"....... Er sollte inzwischen hier sein ... richtig?",
			"Er sollte mit mehr Früchten hier sein ..."
		};
		creepyMan2 = new string[2]
		{
			"Ein Bad?",
			"Ted ... Ich glaube, etwas ist da drin ..."
		};
		creepyMan3 = new string[5]
		{
			"Dieser alte Mann und die nette Dame sind erst vor einer Minute hier vorbeigekommen ...",
			"Sie sagen, du wirst Pinstripe zerstören ...",
			"Tu es nicht, Kumpel!",
			"Er ist der einzige Grund dafür, dass ich mich hier unten ausleben konnte ...",
			"Er sollte jeden Augenblick hier sein ... richtig? Um mir mehr Säcke zu geben ..."
		};
		jack = new string[8]
		{
			"... argh ... Pater?",
			"... aah ... Hilfe!",
			"Dieses Dämonending frisst mich lebendig auf!",
			"Ich fresse dich nicht auf ... Ich bringe dich nur nach Red Wash.",
			"Keine Sorge ... da unten kann man eine Menge Spaß haben ... und Tag und Nacht schmierigen Sacksaft trinken ...",
			"Oh ... wirklich ...?",
			"Ääh ... na dann!",
			"Beeilung! Wir haben nicht den ganzen Tag Zeit!"
		};
		jackChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		jackChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkard = new string[9]
		{
			"Gehst du nach der Zeremonie richtig hart abfeiern, Pater?",
			"Hier, trink zur Vorbereitung etwas von Mr. Pinstripes Sacksaft ... ",
			"Ohhh ... Mmmm ...",
			"Ist gut, ja ... Aber nicht so gut wie das echte Zeug ...",
			"Pinstripe verteilt während der Zeremonie frische Säcke mit diesem Zeug ...",
			"Du isst mit uns einen Bissen von der verbotenen Frucht, richtig, Pater?",
			"Wie wäre es, wenn ich dich einfach umhaue?",
			"Es gibt nichts Schlimmeres, als sich beurteilt zu fühlen ...",
			"Besonders von jemandem, der so armselig ist wie du ..."
		};
		drunkardChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Sicher, ich liebe Partys!",
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkardChoice2 = new string[6]
		{
			string.Empty,
			"Okay.",
			string.Empty,
			string.Empty,
			string.Empty,
			"Nein danke, Schluckspecht."
		};
		dickyBar = new string[11]
		{
			"... Pssst ...",
			"Ted ... Ich bin es ...",
			"Ich bin es, Mr. Dicky ...",
			"Ich muss hier unten vorsichtig sein ...",
			"Pinstripe würde mich töten, wenn er mich findet ...",
			"Besonders, wenn er uns schnappt, während wir dir dabei helfen, Bo zu finden ...",
			"Ich bin verkleidet ...",
			".... Ich bin ein Clown, Ted ...",
			"Siehst du die Nase?",
			"Sie versteckt sich in Pinstripes Brunnen ...",
			"Sie sagte, sie hätte eine Überraschung für dich ..."
		};
		dickyBarChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Jep.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarChoice2 = new string[22]
		{
			"Hey.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Wo ist Miss Birdy?",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2 = new string[6]
		{
			"Was?",
			"Du starrst nicht die Muttermale an meinem Haarkranz an, oder?",
			"Hör auf! Hör auf!",
			"Ich bin kein Clow-",
			"...................",
			"Lass mich in Ruhe!"
		};
		dickyBar2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarNight = new string[6]
		{
			"Was hast du getan, Ted?",
			"Meine Knochen tun weh ...",
			"Ich denke ...",
			"Ted ...",
			"Es tut mir leid, aber ich glaube, es ist vorbei ...",
			"Ich sagte, es ist vorbei."
		};
		dickyBarNightChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Okay."
		};
		dickyBarNightChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Was?"
		};
		birdyBarrel = new string[9]
		{
			"Shhhhh ... Hehehe ...",
			"Teddybär ...",
			"Ich bin es wieder ...",
			"Schnell! Nimm diesen Löffel ...",
			"Sein Glanz und Geruch sagen mir zu ...",
			"Und zweifellos fühlt er sich gut an, nicht wahr?",
			"Du wirst ihn brauchen, um Pinstripe zu besiegen und die arme kleine Bo zu retten ...",
			"Aber sag niemandem, dass ich hier bin ...",
			"Ich möchte nicht, dass Pinstripe mich noch einmal einsperrt ..."
		};
		birdyBarrelChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Das tut er wirklich!"
		};
		birdyBarrelChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Oh, danke ... ",
			string.Empty,
			"Sowas Dummes ..."
		};
		tokenInvite1 = new string[1]
		{
			"Ein Stück Paper ..."
		};
		tokenInvite1Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite1Choice2 = new string[1]
		{
			"Nehmen."
		};
		tokenInvite2 = new string[1]
		{
			"Ein Stück Paper ..."
		};
		tokenInvite2Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite2Choice2 = new string[1]
		{
			"Nehmen."
		};
		tokenFilmStrip = new string[1]
		{
			"Ein geheimer Filmstreifen ..."
		};
		tokenFilmStripChoice1 = new string[1]
		{
			string.Empty
		};
		tokenFilmStripChoice2 = new string[1]
		{
			"Nehmen."
		};
		tokenBible = new string[1]
		{
			"Eine alte Bibel ..."
		};
		tokenBibleChoice1 = new string[1]
		{
			string.Empty
		};
		tokenBibleChoice2 = new string[1]
		{
			"Nehmen."
		};
		tokenNotebook = new string[3]
		{
			"Wie ist das hierher gekommen ...",
			"Sieh es dir nicht an, Daddy ...",
			"Es ist nur eine doofe Zeichnung ..."
		};
		tokenNotebookChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		tokenNotebookChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Untersuchen."
		};
		tokenPills = new string[1]
		{
			"Eine leere Pillenflasche ..."
		};
		tokenPillsChoice1 = new string[1]
		{
			string.Empty
		};
		tokenPillsChoice2 = new string[1]
		{
			"Nehmen."
		};
		tokenNewspaper = new string[1]
		{
			"Eine Zeitung ..."
		};
		tokenNewspaperChoice1 = new string[1]
		{
			string.Empty
		};
		tokenNewspaperChoice2 = new string[1]
		{
			"Nehmen."
		};
		tokenLocket = new string[3]
		{
			"Warum wurden all deine Sachen aus der Tür geworfen, Daddy?",
			"Und ist das ...",
			"... ist das Mommys Medaillon?"
		};
		tokenLocketChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		tokenLocketChoice2 = new string[3]
		{
			"Ich bin nicht sicher ...",
			string.Empty,
			"Untersuchen."
		};
		blackAndWhiteModeTalk = new string[4]
		{
			"Spielst du wirklich wieder dieses Spiel?",
			"Dieses Spiel ist mies ...",
			"Wie auch immer, möchtest du für den Preis von 5 Filmstreifen im Super Vintage-Modus spielen?",
			"Glückwunsch. Du hast gerade 5 Filmstreifen dafür bezahlt, all die wunderschönen Farben aus dem Spiel zu entfernen ..."
		};
		blackAndWhiteModeTalkChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Nein.",
			string.Empty
		};
		blackAndWhiteModeTalkChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Ja (5 Filmstreifen).",
			string.Empty
		};
		sackGeneratorExamine = new string[4]
		{
			"Sieht aus wie diese Sackdinger, mit denen wir den Baum in Edge Wood gefüttert haben ... Aber in gigantisch!",
			"Scheint fast so, als würde er schlafen oder so ...",
			"Und er riecht nach Eiern ...",
			"Schön ..."
		};
		sackGeneratorExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGeneratorExamineChoice2 = new string[1]
		{
			"Untersuchen."
		};
		sackGenerator2Examine = new string[4]
		{
			"Noch einer von diesen Sack-Generatoren ...",
			"Iihh ...",
			"Sieh dir diese Zähne an!",
			"Argh! Und dieser hier riecht nach Milchatem ..."
		};
		sackGenerator2ExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGenerator2ExamineChoice2 = new string[1]
		{
			"Untersuchen."
		};
		sackGenerator3Examine = new string[5]
		{
			"Noch einer ...",
			"Vielleicht fermentiert der den Saft aus den Säcken oder so ...",
			"Ich weiß nicht ...",
			"Aber dieser hier riecht nach ... Kacke.",
			"Ja ... Tut mir leid, aber so riecht es, Mann ..."
		};
		sackGenerator3ExamineChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Du bist komisch, George ..."
		};
		sackGenerator3ExamineChoice2 = new string[5]
		{
			"Untersuchen.",
			string.Empty,
			string.Empty,
			"Hör auf zu reden ...",
			string.Empty
		};
		characterSucked = new string[1]
		{
			"..."
		};
		characterSuckedFelix = new string[2]
		{
			"Ted ...",
			"Ist irgendwas auf meinem Kopf?"
		};
		explainFire = new string[8]
		{
			"Hallo, Pissnelke ...",
			"Beurteile mich nicht ...",
			"Ich war brav, ich schwöre es ... Ich hatte nur Durst ...",
			"Geht doch nichts über einen großen Schluck von Pinstripes Sacksaft ...",
			"Dadurch fühle ich mich ganz außergewöhnlich ...",
			"Er sagt, es wird noch mehr geben, um Bos Adoption zu feiern ...",
			"Was geht dich das an, Drecksack?",
			"Du weißt nicht einmal, wie man ein Auto anhält ..."
		};
		explainFireChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Okay.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		explainFireChoice2 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Wann ist die Adoption?",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		redWashNotice = new string[7]
		{
			"Eine Notiz ...",
			"„Red Wash-Einheimische, die der Adoption von Bo beiwohnen ...“",
			"„... erhalten eine kostenlose Lieferung von Pinstripes Säcken ...“?",
			"... Alle Einwohner, die nicht beiwohnen ...“",
			"„werden beleidigt und ... energisch zum Gehorsam gepeitscht ...“?",
			"„Vielen Dank und einen schönen Tag!“",
			"... Nett ..."
		};
		redWashNoticeChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Das ist furchtbar ..."
		};
		redWashNoticeChoice2 = new string[6]
		{
			"Lesen.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Eine Party nach meinem Geschmack."
		};
		potBellyMan = new string[7]
		{
			"Shhhhh ... Hehehehehe ...",
			"Hörst ... du das, Pater?",
			"Das ist Pinstripes Riesenuhr ...",
			"Ich wurde angewiesen, niemanden die Riesenuhr anfassen zu lassen ...",
			"Unter keinen Umständen ist es niemandem gestattet ...",
			"... an der verdammten Uhr herumzuwerkeln!",
			"Du verstehst es nicht ... oder, Kumpel?"
		};
		potBellyManChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Ich verstehe!"
		};
		potBellyManChoice2 = new string[4]
		{
			string.Empty,
			"Was?",
			string.Empty,
			"Ich werde mehr tun, als sie nur anzufassen ..."
		};
		potBellyMan2 = new string[6]
		{
			"..................",
			"Du hast an der Riesenuhr herumgewerkelt?",
			"HAST DU DIE REGELN NICHT GEHÖRT?",
			"Nicht schon wieder! Nicht schon wieder!",
			"Mr. Pinstripe wird mich den Bordstein fressen lassen ...",
			"................................ Schon wieder!"
		};
		potBellyMan2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Ähm ... Tschüss ..."
		};
		potBellyMan2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Was ist los?"
		};
		potBellyMan22 = new string[3]
		{
			"............... Arghhh ...",
			"Ich meine ...",
			"Den Bordstein zu fressen ist eine Sache. Ich hoffe einfach nur, dass er mir trotzdem einen Sack gibt ..."
		};
		potBellyMan22Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		potBellyMan22Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Wow.",
			string.Empty
		};
		fork = new string[3]
		{
			"Eine Gabel.",
			"Sie ist irgendwie rostig und riecht nach Pennies ...",
			"Sie wurde mit ... Lotion besprüht?"
		};
		forkChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		forkChoice2 = new string[3]
		{
			"Untersuchen.",
			string.Empty,
			"Nehmen."
		};
		boHeaven1 = new string[3]
		{
			"Daddy!",
			"Ich habe dich vermisst!",
			"Möchtest du draußen spielen?"
		};
		boHeaven1Choice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boHeaven1Choice2 = new string[3]
		{
			"Bo!",
			"Ich habe dich auch vermisst!",
			"Ja!"
		};
		boHeaven2 = new string[2]
		{
			"Daddy!",
			"Das sieht aus wie Mommys Schmetterlingskette!"
		};
		boHeaven2Choice1 = new string[1]
		{
			string.Empty
		};
		boHeaven2Choice2 = new string[1]
		{
			"Jep?"
		};
		boHeavenGeorge = new string[1]
		{
			"Oh ... Ich wünschte Georgie wäre hier ..."
		};
		boHeavenGeorgeChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenGeorgeChoice2 = new string[1]
		{
			"..."
		};
		boHeavenButterflies = new string[3]
		{
			"Wow! Schau, Dad!",
			"Ich wünschte, Mom wäre hier, um das zu sehen. Sie hat Schmetterlinge geliebt ...",
			"Hey! Ich wette, du kannst nicht alle fangen!"
		};
		boHeavenButterfliesChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenButterfliesChoice2 = new string[2]
		{
			string.Empty,
			"Ja ..."
		};
		secretRoomCaveSign = new string[8]
		{
			"Eine Steintafel ...",
			"„Archbishop’s Chamber:“",
			"„Dem ernannten Erzbischof gewidmet.“",
			"„Wie ein Blitz ...“",
			"„und in einem Augenblick stellte die Elite die Energie bereit ...“",
			"„um Pinstripes Welt zu erleuchten und zu erweitern.“",
			"„Genießt die Purpurnen Magnustropfen, mit einem Wert von jeweils 200 Tropfen.“",
			"„(Sie riechen übrigens nach Glen.)“"
		};
		secretRoomCaveSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomCaveSignChoice2 = new string[1]
		{
			"Untersuchen."
		};
		secretRoomTreeSign = new string[7]
		{
			"„Eine Steintafel ...“",
			"„Archbishop’s Garden“",
			"„Dem ernannten Erzbischof gewidmet.“",
			"„Das aufrichtige und bescheidene Geschenk der Elite ...“",
			"„war ein goldener Samen, der zu diesem prachtvollen Dorn heranwuchs ...“",
			"„Bitte nimm dir Zitronenbaum-Statton-Tropfen, mit einem Wert von jeweils 100 Tropfen.“",
			"„(Sie riechen übrigens wie frisch ausgequetschte Sonnencreme mit Zitronenduft.)“"
		};
		secretRoomTreeSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomTreeSignChoice2 = new string[1]
		{
			"Untersuchen."
		};
	}
	else if (@string == "Portuguese")
	{
		Debug.Log("Portuguese");
		trainDoorButton1 = new string[1]
		{
			"Um botão..."
		};
		wifeIntro = new string[2]
		{
			"Teddy...",
			"Preciso te falar uma coisa..."
		};
		bo1 = new string[6]
		{
			"Acorda, papai!",
			"Você tá sonâmbulo de novo...",
			"Ei! Tá sentindo cheiro de fumaça?",
			"Vamos investigar!",
			"Você pode ser o Sherlock...",
			"Seu bobo!"
		};
		bo1Choice1 = new string[5]
		{
			string.Empty,
			"Desculpe, filha.",
			string.Empty,
			string.Empty,
			"OK."
		};
		bo1Choice2 = new string[5]
		{
			"Hã... como?",
			"Não estava, não.",
			"Sim.",
			string.Empty,
			"Deixa comigo, Watson!"
		};
		trainDoorButtonBo = new string[2]
		{
			"Sherlock!",
			"Acho que alcanço aquele botão!"
		};
		trainDoorButtonBoChoice1 = new string[3]
		{
			"Watson?",
			string.Empty,
			string.Empty
		};
		trainDoorButtonBoChoice2 = new string[2]
		{
			string.Empty,
			"OK... Fique aí!"
		};
		lockedTrainDoor = new string[1]
		{
			"Trancado..."
		};
		sackSpitExplainer = new string[3]
		{
			"O que é isso, papai?",
			"Parece uma gota congelada de...",
			"Óleo?"
		};
		mirror = new string[7]
		{
			"É um espelho, Sherlock!",
			"Está tão sujo que mal dá pra ver sua cara.",
			"Que meeeeeedo....",
			"Heh! Olha só, pai, a gente parece dois fantasmas engraçados...",
			"Bum!",
			"Ah é...",
			"Pum!"
		};
		mirrorChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vamos."
		};
		mirrorChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"É “Bu”, filhinha."
		};
		mirror2 = new string[6]
		{
			"Espelho, espelho do trem...",
			"Diga quem é a melhor princesa....",
			".......................",
			".......................",
			"O que rima com trem, pai?",
			"Diga quem é a melhor princesa: eu ou outro alguém?"
		};
		mirror2Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vamos."
		};
		mirror2Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Alguém."
		};
		boTrainBar = new string[5]
		{
			"Papai, podemos sair daqui?",
			"Tem cheiro de caca...",
			"Desculpa...",
			"Tem cheiro de...",
			"Fezes..."
		};
		boTrainBarChoice1 = new string[4]
		{
			string.Empty,
			"Tem mesmo.",
			string.Empty,
			string.Empty
		};
		boTrainBarChoice2 = new string[5]
		{
			string.Empty,
			"Olha a boca!",
			string.Empty,
			string.Empty,
			"Bo!"
		};
		boJumpingBean = new string[8]
		{
			"Você pula igual a uma pulga, Sherlock.",
			"“Pula, pula, pulguinha, pra mim, bem assim sem cair em mim.”",
			"“Saltita, saltita, pula, pula, pula.”",
			"“Ela gosta de pular fazendo upa, upa, upa.”",
			"Gosto muito desse desenho.",
			"É tão engraçadinho...",
			"Não sabia que você gostava desse desenho, Sherlock!",
			"Achei que você só gostava de fumar cachimbo e investigar homicídios!"
		};
		boJumpingBeanChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK"
		};
		boJumpingBeanChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Eu também gosto!"
		};
		boTrainButtonSolution = new string[4]
		{
			"Não quero ser... mal-educada nem nada...",
			"Mas... você sabe o que tá fazendo?",
			"Então fico feliz que somos parceiros de investigação, Sherlock!",
			"É só apertar os botões na hora que eles ficarem amarelos!"
		};
		boTrainButtonSolutionChoice1 = new string[4]
		{
			string.Empty,
			"Claro!",
			string.Empty,
			string.Empty
		};
		boTrainButtonSolutionChoice2 = new string[4]
		{
			string.Empty,
			"Na verdade, não...",
			string.Empty,
			"Bem pensado, Watson!"
		};
		bo2 = new string[1]
		{
			"Olha, um balão, papai!"
		};
		bo2Choice1 = new string[1]
		{
			string.Empty
		};
		bo2Choice2 = new string[1]
		{
			"Espera, Bo!"
		};
		bo3 = new string[3]
		{
			"Tadinho do Georgie...",
			".........................................................",
			"Ele tá apertado nessa gaiola..."
		};
		bo3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bo3Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"OK."
		};
		bo32 = new string[3]
		{
			"...................",
			"Ele deve sentir o cheiro dos restos de salgadinho na sua jaqueta...",
			"Não é legal ficar atormentando ele assim..."
		};
		bo33 = new string[3]
		{
			".......................",
			"O Georgie gosta de batatinha Lion’s Heart da mercearia do Martin, sabor carne...",
			"Se você não vai dar nenhuma para ele, devia voltar ao que tava fazendo, senhor..."
		};
		pinstripeTrain1 = new string[7]
		{
			"Bom dia, Ted...",
			"E quem seria essa?",
			"Olá, Bo...",
			"Você gosta de balões?",
			"Gostaria de ganhar um preto e brilhante?",
			"Só um homem simpático...",
			"Com um balão preto e brilhante..."
		};
		pinstripeTrain1Choice1 = new string[7]
		{
			"Ahm...",
			string.Empty,
			string.Empty,
			string.Empty,
			"Não precisa...",
			string.Empty,
			string.Empty
		};
		pinstripeTrain1Choice2 = new string[7]
		{
			"Bom dia?",
			"Ahm... esta é a Bo.",
			string.Empty,
			string.Empty,
			"Quem é você?",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2 = new string[4]
		{
			"Ah, e Bo...",
			"Gostei do seu vestido...",
			"Ahhhh.... que grosseria...",
			"Bo, seu papai é muito malcriado..."
		};
		pinstripeTrain2Choice1 = new string[4]
		{
			string.Empty,
			"Vamos, Bo...",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2Choice2 = new string[4]
		{
			string.Empty,
			"Deixe a gente em paz, esquisito.",
			string.Empty,
			"Vamos, Bo."
		};
		pinstripeHanglyPass = new string[10]
		{
			"Olá, Ted...",
			"Ahhhh... você chamou aquele bafo-de-onça do Dicky para te ajudar a achar a Bo...",
			"Algo me diz que o velho Dicky já não é tão forte quanto antes...",
			"... uma marionete boba de madeira...",
			"Bem, acho que a Bo prefere passar um tempo comigo no meu pequeno presbitério...",
			"Isso... É isso mesmo que vamos fazer...",
			"Seu babaca esquisito!",
			"Como é que é?",
			"Como é que é, seu cara amassada?",
			"Não me surpreende que um mau caráter como você esteja junto dos amaldiçoados nojentos..."
		};
		pinstripeHanglyPassChoice1 = new string[11]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"(Não dizer nada.)",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeHanglyPassChoice2 = new string[7]
		{
			"Me leva até a Bo!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Quantos anos você tem, infantiloide?"
		};
		pinstripeCave = new string[7]
		{
			"Olá, Ted...",
			"Devo dizer... Estou impressionado...",
			"Infelizmente a Bo tem passado um tempo...",
			"... em meu presbitério...",
			"Espero ver sua cara de bom moço na cerimônia...",
			"Na cerimônia de adoção, seu VERME!",
			"Tchauzinho, meninão..."
		};
		pinstripeCaveChoice1 = new string[8]
		{
			string.Empty,
			"OK",
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveChoice2 = new string[8]
		{
			string.Empty,
			"Cadê a Bo?",
			string.Empty,
			string.Empty,
			"Que cerimônia?",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExit = new string[10]
		{
			"Você gostou dos meus recadinhos nas paredes?",
			"Não pude evitar, Ted.",
			"A Bo é minha, seu RANHENTO!",
			"“Papai, papai, socorro!”",
			"Ahohohohohoh.......... Sinto muito, Bo!",
			"Seu papai está correndo por aí como um IDIOTA ESTÚPIDO!",
			"Ahahahahahahahaha...........................",
			"Mal posso ESPERAR PELA CERIMÔNIA!",
			"Quero ver as lágrimas escorrendo de sua carinha branquela, Ted...",
			"E vou me arrepiar de alegria quando vir isso..."
		};
		pinstripeCaveExitChoice1 = new string[10]
		{
			"Não.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExitChoice2 = new string[10]
		{
			"Sim.",
			"Me leve até a Bo!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill = new string[9]
		{
			"Você chegou bem na hora da cerimônia, Ted.",
			"Ahhh... não seja um BEBÊ CHORÃO!",
			"Francamente, a Bo será bem mais feliz comigo...",
			"Bem, você vai ficar para a cerimônia?",
			"O tempo está passando, Ted...",
			"SEU PIVETE IRRITANTE IMBECIL!",
			"Experimente.",
			"Mas se você não se lembra nem do dia abençoado em que você morreu...",
			"Receio que a Bo será minha para sempre..."
		};
		pinstripeWindmillChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"(Não dizer nada).",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmillChoice2 = new string[10]
		{
			"Deixe a Bo em paz!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Você vai pagar por isso, seu imundo!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2 = new string[8]
		{
			"Ahhh... você perdeu a cerimônia, Ted...",
			"Olha só que bonitinha a carinha dela...",
			"Quer falar alguma coisa, meu bem?",
			"Vai embora, Ted...",
			"Eu tenho um papai novo agora...",
			"Ele me protege e me ama de verdade...",
			"ACABOU, TED!",
			"Pena que não exista um jeito de voltar no tempo."
		};
		pinstripeWindmill2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2Choice2 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Bo, sou eu!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrain = new string[8]
		{
			"Quer brincar de trenzinho comigo, Ted?",
			"Você pode ser o maquinista...",
			"O maquinista desastrado...",
			"Sua pobre garotinha está lá em cima?",
			"Queimando e morrendo?",
			"Sua PESTE nojenta!",
			"Eu moro aqui agora, garoto...",
			"Com meu novo papai..."
		};
		boWithTrainChoice1 = new string[10]
		{
			"Claro!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrainChoice2 = new string[3]
		{
			"Bo, vamos!",
			"Venha, Bo!",
			string.Empty
		};
		hiveTrain = new string[3]
		{
			"..................... Nojento!",
			"Parece um saco velho e gigante...",
			"Está me deixando tonta..."
		};
		hiveTrain2 = new string[2]
		{
			"Papai, é melhor você parar de cheirar essa coisa...",
			"Isso não te faz bem..."
		};
		hiveTrain3 = new string[4]
		{
			"Olha o que você fez, papai!",
			"A mamãe não ia gostar disso...",
			"Ela sempre mandava eu parar de cheirar coisas esquisitas...",
			"Igual aquela coisa marrom que achei embaixo da geladeira..."
		};
		scarf = new string[3]
		{
			"O cachecol da Bo...",
			"Tem cheiro de fumaça...",
			"... e uísque..."
		};
		scarfChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		scarfChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Pegue."
		};
		bigTree = new string[2]
		{
			"...... Queeerooo.......",
			"...... comiiiidaaaa......."
		};
		bigTreeChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bigTreeChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Alimentar"
		};
		oldManV2 = new string[12]
		{
			".....egh!....",
			"Ted?",
			"Não reconhece este rosto sexy, seu porco? Sou eu... Sr. Dicky...",
			"Vai embora, garoto...",
			"Bem-vindo ao Inferno, garoto. Agora, sai fora!",
			"......Pinstripe......",
			"Acho que sei onde ela deve estar, Ted!",
			"... Na The Hangly House...",
			"Só não sei como um magricela igual você vai se defender sem nenhuma arma...",
			"Enquanto não achar uma, acho que não vou poder te ajudar...",
			"Eu não estava chorando, eu estava...",
			"Hã... rindo......"
		};
		oldManV2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Muito obrigado, senhor!"
		};
		oldManV2Choice2 = new string[10]
		{
			"Socorro!",
			"Eu te conheço?",
			string.Empty,
			"Mas preciso de ajuda!",
			"Minha filha foi sequestrada!",
			"Quem?",
			string.Empty,
			string.Empty,
			string.Empty,
			"É, você é mesmo um bebê chorão..."
		};
		oldManV22 = new string[5]
		{
			"O que... o que você está olhando?",
			"São minhas verrugas? Eu tenho umas verrugas bem salientes na testa. Elas são hereditárias, eu juro!",
			"Minha mãe sempre me disse que elas eram um presente de Deus...",
			"Mas eu queria que o Dr. Shrenweld as tirasse porque eu sempre soube que era feio demais para a Birdy...",
			"Eu sempre tive cara de palhaço deformado, desde a época da escola..."
		};
		oldManV23 = new string[5]
		{
			"Essas verrugas não são atração de circo!",
			"Elas andam de monociclo, seu tolo? Andam?",
			"Elas domam uma fera de quatro patas? Não! Não!",
			"Sua filha não foi raptada? E você está... contemplando...",
			"Colocando minhas verrugas numa atração de circo!"
		};
		hive = new string[2]
		{
			"Um daqueles sacos...",
			"... com um cheiro “aromavilhoso”."
		};
		hiveChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		hiveChoice2 = new string[2]
		{
			string.Empty,
			"Pegar."
		};
		felix1 = new string[5]
		{
			".......................................................Ei!",
			"Aqui em cima!",
			"Por que você tá usando uma roupa de padre?",
			"....................................",
			"Já experimentou um daqueles sacos?"
		};
		felix1Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		felix1Choice2 = new string[5]
		{
			"Oi...",
			string.Empty,
			"Ahm...",
			string.Empty,
			"Não."
		};
		felixHurt = new string[3]
		{
			"................................",
			".................Ugh............... isso não foi legal, cara.",
			"......Arh......... assim você me magoa..."
		};
		felixHurtChoice1 = new string[2]
		{
			string.Empty,
			"Desculpa!"
		};
		felixHurtChoice2 = new string[2]
		{
			string.Empty,
			"Essa doeu, hein?"
		};
		drunkMan3 = new string[5]
		{
			"............................",
			"Esse Pinstripe é tão...",
			"Tão benevolente...",
			"..........................................................................................................................................",
			"Ouviu isso?"
		};
		drunkMan3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Se você tá falando, cara!"
		};
		drunkMan3Choice2 = new string[3]
		{
			"Olá.",
			string.Empty,
			"Você fede um pouco."
		};
		poolTableMan = new string[3]
		{
			"Sai da mesa, moleque.",
			"Estou no meio de um jogo...",
			"Você é padre, e não pai. Falei para sair da mesa, pivete..."
		};
		poolTableManChoice1 = new string[4]
		{
			string.Empty,
			"Sinto muito.",
			string.Empty,
			string.Empty
		};
		poolTableManChoice2 = new string[4]
		{
			string.Empty,
			"Seu bafo...",
			string.Empty,
			string.Empty
		};
		dog2 = new string[10]
		{
			"Agradeço por isso, Ted!....",
			"Pensei que nunca mais fosse sair daquela coisa...",
			"Ei... Cadê a Bo?",
			"Ughhh... Era o que eu temia...",
			"Bem, temos que achá-la, cara...",
			"Acho que posso te ajudar a farejar umas pistas, sei lá...",
			"Falando nisso, você viu o Sr. Dicky?",
			"É....... Dá para sentir o cheiro daquele cara a quilômetros...",
			"Aquele Pinstripe...",
			"Ele é um babaca!"
		};
		dog2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK",
			string.Empty,
			"Desculpa, cara!"
		};
		dog2Choice2 = new string[10]
		{
			"Você fala!",
			string.Empty,
			"Pinstripe raptou ela!",
			string.Empty,
			"Vamos nessa!",
			string.Empty,
			"Sim",
			"Por que você estava preso?",
			string.Empty,
			"Você é um babaca..."
		};
		dogBoSmell = new string[7]
		{
			"Opa!",
			"Sente esse cheiro, Ted?",
			"Tem cheiro de... maçã...",
			"Eu não gosto muito...",
			"Adoro queijo, torta e qualquer coisa com cheiro de carne...",
			"É....................................... desculpa.",
			"Anda."
		};
		dogBoSmellChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty
		};
		dogBoSmellChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			"A Bo adora maçã.",
			"Hmm.",
			string.Empty
		};
		dog3 = new string[2]
		{
			"Ted...",
			"Vai achar a Bo..."
		};
		dogPraise1 = new string[1]
		{
			"Bem pensado, Ted!"
		};
		dogBalloonPop = new string[3]
		{
			"Ah! Cara! Me assusto toda vez que você estoura os balões.",
			"Será que você... poderia... parar com isso?",
			"Então, vai ser assim, é?"
		};
		dogBalloonPopChoice1 = new string[2]
		{
			string.Empty,
			"Desculpa, George!"
		};
		dogBalloonPopChoice2 = new string[2]
		{
			string.Empty,
			"Ahm... não."
		};
		dogBalloonPop2 = new string[3]
		{
			"AH!",
			"Ted! Os balões...",
			"Sério mesmo?"
		};
		dogBalloonPop2Choice1 = new string[2]
		{
			string.Empty,
			"Desculpa!"
		};
		dogBalloonPop2Choice2 = new string[2]
		{
			string.Empty,
			"Risos."
		};
		recordPlayer1 = new string[3]
		{
			"A vitrola está coberta de penas vermelhas...",
			"O disco se chama “Miss Birdy Bondette: intermezzos e outras reflexões”.",
			"Essa música se chama “O último sorriso”."
		};
		recordPlayer1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer1Choice2 = new string[3]
		{
			string.Empty,
			"Tocar",
			string.Empty
		};
		recordPlayer12 = new string[2]
		{
			"Que música bonita...",
			"Sinto que estou no paraíso canino..."
		};
		recordPlayer12Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer12Choice2 = new string[3]
		{
			string.Empty,
			"OK.",
			string.Empty
		};
		recordPlayer2 = new string[3]
		{
			"Ei! É um dos discos da Miss Birdy!",
			"Vamos ouvir, Ted!",
			"“A última caminhada”... é um título um pouco triste..."
		};
		recordPlayer2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer2Choice2 = new string[3]
		{
			string.Empty,
			"Tocar",
			string.Empty
		};
		recordPlayer22 = new string[2]
		{
			"Mmmmmmmmmmmmmmmm........................ Tão bonita. Queria que ela cheirasse tão bem quanto soa.",
			"Mas tudo aqui tem cheiro de velhinha..."
		};
		recordPlayer22Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer22Choice2 = new string[3]
		{
			string.Empty,
			"OK.",
			string.Empty
		};
		recordPlayer3 = new string[4]
		{
			"Outro disco da Miss Birdy...",
			"Tem um bilhete junto com ele...",
			"“Teddy, compus essa música para a Bo. Sinto muito pela sua perda. — Miss Birdy”",
			"Ela se chama..................... “O último abraço”."
		};
		recordPlayer3Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer3Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Tocar",
			string.Empty
		};
		recordPlayer32 = new string[3]
		{
			"É tão... triste...",
			"Ainda podemos salvar a Bo... certo?",
			"Vai ficar tudo bem, Ted..."
		};
		recordPlayer32Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer32Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dogRecordPlayer = new string[1]
		{
			"Essa música é assustadora..."
		};
		dogRecordPlayerChoice1 = new string[1]
		{
			string.Empty
		};
		dogRecordPlayerChoice2 = new string[1]
		{
			"É."
		};
		dogPoop = new string[4]
		{
			"Ugh......... Cocô da Senhorinha...",
			"Se você a encontrar... tem que pular na bunda dela, cara...",
			"Pera, pera, pera...",
			"Eu sou um cão falante e você tá preocupado com meu sotaque?"
		};
		dogPoopChoice1 = new string[2]
		{
			string.Empty,
			"Valeu pela dica!"
		};
		dogPoopChoice2 = new string[2]
		{
			string.Empty,
			"Cadê seu sotaque, cara?"
		};
		dogMushroom = new string[5]
		{
			"Um cogumelo brilhante...",
			"Esse aqui tem cheiro de querosene...",
			"Ei, Ted, você não encontrou essas coisas em Edge Wood e em The Hangly Pass?",
			"Não sei... talvez a gente ache mais daquelas gotas congeladas se queimar eles ou algo do tipo...",
			"Só estou tentando ajudar..."
		};
		dogMushroomChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Bem pensado, George!"
		};
		dogMushroomChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"É, e daí?",
			"É... dãã."
		};
		dogCaveJumpComment = new string[1]
		{
			"Na mosca!"
		};
		dogCaveJumpCommentChoice1 = new string[1]
		{
			string.Empty
		};
		dogCaveJumpCommentChoice2 = new string[1]
		{
			"Valeu!"
		};
		caves = new string[2]
		{
			"Essa caverna parece ser escura e tenebrosa...",
			"Está uma escuridão total e não dá para ver nada..."
		};
		caves2 = new string[2]
		{
			"Um som horrível e ameaçador emana das profundezas...",
			"..........................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................."
		};
		flashLightTalk = new string[3]
		{
			"Que lanterna de cabeça legal!",
			"Ela está cheia de... flores desenhadas...",
			"Selecione o ícone para ligar e desligar."
		};
		flashLightTalkChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		flashLightTalkChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Pegar."
		};
		lewis = new string[5]
		{
			"......Ughhh....oooohh......oooooohhh....",
			"Que dor nas costas do inferno!",
			"Agora ouça, moleque: não temos muito tempo...",
			"Ahmm........ Bo está no topo da montanha... na... Hangly House...",
			"Queria muito ver essas minhas perninhas de saracura subirem essa montanha..."
		};
		lewisChoice1 = new string[5]
		{
			string.Empty,
			"Desculpe!",
			string.Empty,
			"OK.",
			string.Empty
		};
		lewisChoice2 = new string[5]
		{
			"Você está bem, Dicky?",
			"Você está velho.",
			string.Empty,
			"Você não vem?",
			"OK."
		};
		lewis2 = new string[4]
		{
			"Você fica andando por aí como um bobo da corte...",
			"Quando eu tinha sua idade, eu trabalhava 80 horas por semana na metalúrgica do meu pai...",
			"Ele me dava uma surra todos os dias...",
			"Eu... Ainda tenho as cicatrizes..."
		};
		oldManStartWalking = new string[4]
		{
			"Por que demorou tanto, sua lesma?",
			"Te encontro lá em cima, na The Hangly House...",
			"Eu falei! A The Hangly House... fica no topo da montanha...",
			"Tenho certeza de que foi para lá que Pinstripe levou a Bo..."
		};
		oldManStartWalkingChoice1 = new string[4]
		{
			string.Empty,
			"OK.",
			string.Empty,
			"Te encontro lá!"
		};
		oldManStartWalkingChoice2 = new string[4]
		{
			string.Empty,
			"Onde?",
			string.Empty,
			"Tudo bem. Poxa vida, velho..."
		};
		key = new string[2]
		{
			"Uma chave de prata...",
			"Tem um “P” gravado nela..."
		};
		keyChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		keyChoice2 = new string[2]
		{
			string.Empty,
			"Pegar."
		};
		goldKeyTalk = new string[1]
		{
			"Uma chave dourada..."
		};
		rifle = new string[4]
		{
			"Um rifle velho...",
			"Ha, que legal...",
			"Chamam ela de “Pássaro cantante”... está gravado em toda a parte...",
			"Por que será que ela tem esse nome?"
		};
		rifleChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		rifleChoice2 = new string[4]
		{
			"Boa!",
			string.Empty,
			string.Empty,
			"Pega!"
		};
		oldWomanPorch = new string[8]
		{
			"Macacos me mordam...",
			"Teddyzinho... É você?",
			"Bom te ver, Teddy!",
			"Cadê minha amiguinha, Bo?",
			"Ah, foi ele então?",
			"Acho que o Dicky mentiu para você...",
			"Bom... você vai me tirar dessa coisa ou não?",
			"Heheheh...... muito bem!"
		};
		oldWomanPorchChoice1 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Pode deixar!"
		};
		oldWomanPorchChoice2 = new string[8]
		{
			string.Empty,
			"É?",
			string.Empty,
			"Dicky falou que ela estava aqui...",
			string.Empty,
			"Oh...",
			"Não, obrigado, sua pomba velha.",
			string.Empty
		};
		dogBirdyCommentNice = new string[10]
		{
			"Você fez isso de propósito, né?",
			"Mesmo assim, acho que ela acabou morrendo...",
			"Pelo menos você foi gentil antes de jogá-la do precipício...",
			"Ela era uma velhinha bem gentil.",
			".........Ahm.........",
			"Para Miss Birdy...",
			"Que a alma dela voe... por toda a eternidade...",
			"Pelos céus...",
			"E chegue ao paraíso...",
			"Amém..."
		};
		dogBirdyCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Ela era..."
		};
		dogBirdyCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Diga algo sobre ela, George."
		};
		dogBirdyCommentMean = new string[6]
		{
			"Cara... você matou ela!",
			"Primeiro, você chama ela de pomba velha e depois faz isso?!",
			"É... Quer dizer, não me leve a mal...",
			"Ela fedia mesmo como uma pomba...",
			"Mas, quem se importa!",
			"Você acabou de matá-la!"
		};
		dogBirdyCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			"Desculpe...",
			string.Empty,
			string.Empty
		};
		dogBirdyCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			"Ela fedia como uma pomba.",
			string.Empty,
			"É..."
		};
		dogBarCommentMean = new string[6]
		{
			"Cara, você irritou mesmo aquele cara...",
			"De agora em diante... aja sem chamar a atenção...",
			"Você não quer acabar nocauteado numa hora dessas, né?",
			"Você tem um visual todo descolado e tal, Ted...",
			"Mas seus braços são...",
			"... esqueléticos..."
		};
		dogBarCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Acho que você tem razão...",
			string.Empty
		};
		dogBarCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Eu dou conta deles!",
			string.Empty
		};
		dogBarCommentNice = new string[4]
		{
			"É... tem certeza?",
			"Vai mesmo comemorar com todo mundo numa noite como essa?",
			"Ted... e a Bo?",
			"Isso não é legal, cara..."
		};
		dogBarCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			"Claro que não!",
			string.Empty,
			string.Empty
		};
		dogBarCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			"Claro!",
			"É...",
			string.Empty
		};
		floatingPeople = new string[18]
		{
			"Hohahahehehe... Ah, Teddy, que loucura!",
			"Mas Dicky quer te falar uma coisa, não é Dicky?",
			"Ughhh... Eu menti... mas só porque queria achar minha Birdy...",
			"Pinstripe vive em Red Wash...",
			"... um lago nas entranhas do inferno.",
			"Receio que ele tenha prendido a Bo em seu presbitério assustador...",
			"Para chegar lá, você vai precisar de luz...",
			"... Deixa eu ver se ainda está comigo...",
			"... Ah, sim, está aqui...",
			"Uma noite, depois que eu e a Bo brincamos com os brinquedos dela, ela me deu esse papel estranho...",
			"Talvez ele te ajude a achar uma luz...",
			"Você pode examinar a pista depois se esquecer dela...",
			"Tá vendo o ÍCONE DE LUPA piscando na parte de baixo da tela?",
			"É ali que você pode ver todas as PISTAS que encontrar em sua jornada...",
			"Examine-as com atenção...",
			"Enfim...",
			"A gente se vê em Red Wash...",
			"Sei que vamos encontrar a Bo, querido..."
		};
		floatingPeopleChoice1 = new string[14]
		{
			string.Empty,
			"Tudo bem, Dicky...",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		floatingPeopleChoice2 = new string[18]
		{
			"Sei.",
			"Desembucha, seu lixo...",
			"Mas cadê a Bo?",
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Obrigado.",
			string.Empty,
			"Sim.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK."
		};
		dogHintChest = new string[5]
		{
			"Ted! Lembra daquele baú de brinquedos na árvore em Edge Wood?",
			"Talvez ele tenha algo a ver com as dicas da Miss Birdy para encontrar a luz...",
			"A luz para você entrar em Red Wash...",
			"Dê uma olhada nas suas pistas, cara...",
			"Tá vendo o ícone de lupa à esquerda na parte de baixo da tela?"
		};
		dogHintChestChoice1 = new string[3]
		{
			string.Empty,
			"OK.",
			string.Empty
		};
		dogHintChestChoice2 = new string[3]
		{
			string.Empty,
			"Que luz?",
			string.Empty
		};
		telephone = new string[3]
		{
			"............. Papai...",
			"É você?",
			"............................................. Socorro, papai!"
		};
		pinstripeManBoss = new string[3]
		{
			"SEU LIXO!",
			"Você interrompeu nossa preciosa união perfeita!",
			"Hora de queimar, TEDDYZINHO!"
		};
		houseLockedGold = new string[1]
		{
			"A porta está trancada com um cadeado dourado..."
		};
		houseLockedMechanism = new string[1]
		{
			"A porta está trancada com um tipo de mecanismo..."
		};
		houseLockedMechanismChoice1 = new string[1]
		{
			string.Empty
		};
		houseLockedMechanismChoice2 = new string[1]
		{
			"Examinar."
		};
		houseLockedSilver = new string[1]
		{
			"A porta está trancada com um cadeado prateado..."
		};
		houseLocked2 = new string[1]
		{
			"A porta está trancada..."
		};
		sign1 = new string[2]
		{
			"Para cima: The Hangly Pass",
			"Para baixo: Red Wash"
		};
		sign2 = new string[1]
		{
			"Para Red Wash..."
		};
		signPissward = new string[2]
		{
			"“Para Red Wash...”",
			"“Compre bilhetes no Happy’s”."
		};
		signBalloonShop = new string[4]
		{
			"“O consumo dos meus Cogumelos Rápidos está estritamente proibido”.",
			"“Efeitos colaterais: náusea, diarreia, pensamentos suicidas...”",
			"“Ou um aumento de +1 na VT (velocidade de tiro) do jogador...”",
			"“Por isso, fique longe deles! — Loja de Balões do Princle”"
		};
		liftPower = new string[3]
		{
			"Uma roda d’água ou algo parecido...",
			"Parece que ela aciona o elevador...",
			"Mas... cadê a água?"
		};
		signPissward2 = new string[2]
		{
			"Parece uma tubulação de gás...",
			"“A tubulação de gás passa por Edge Wood, The Hangly Pass, The Sack Chute, Pissward Falls e Red Wash...”"
		};
		signPissward2Choice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signPissward2Choice2 = new string[2]
		{
			string.Empty,
			"Examinar."
		};
		signHappySafe = new string[2]
		{
			"Um cofre gigante?",
			"“Nem pense nisso, tolo. — Happy”"
		};
		signHappySafeChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signHappySafeChoice2 = new string[2]
		{
			string.Empty,
			"Examinar."
		};
		signTimsShop = new string[2]
		{
			"Um recado escrito à mão...",
			"“Tentando dormir. Acordado às 20h10...”"
		};
		signTimsShopChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signTimsShopChoice2 = new string[2]
		{
			"Examinar.",
			string.Empty
		};
		pisswardMan1 = new string[13]
		{
			"Olá, padre...",
			"Bem-vindo a Pissward Falls, lar de Pissy, a cobra Piss...",
			"Os tíquetes para Red Wash custam 300 Gotas Congeladas...",
			"Agradeço a compra, padre...",
			"Ahhhh... ótimo...",
			".............. Ahhh... isso é bom... aaah, caramba......",
			"Vou levar essas gotas para Red Wash e tentar dormir um pouco...",
			"Não durmo já faz...",
			"Quanto tempo mesmo?",
			"Não me lembro...",
			"... Nada como tomar essas Gotas Congeladas e deixar elas te levarem para a terra dos sonhos...",
			"Deus abençoe Pinstripe. Deus abençoe sua alma benevolente...",
			"Aqui está seu bilhete de elevador, padre..."
		};
		pisswardMan1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Não, obrigado."
		};
		pisswardMan1Choice2 = new string[3]
		{
			"Olá.",
			string.Empty,
			"Comprar bilhete (300)."
		};
		happyEdgeWood = new string[14]
		{
			"Olá, padre...",
			"Sou eu, Happy...",
			"Ah, você me conhece, Ted!",
			"Amigo da Bo?",
			"Enfim, você parece estar muito ansioso e molhado...",
			"Gostaria de ter uma bebida para te servir, mas você só vai encontrar em Red Wash...",
			"Só que eu posso te vender algo muito melhor pelo preço certo...",
			"Compre essa submetralhadora Thompson ilegal por 1.000 Gotas Congeladas...",
			"Agradeço a compra, padre...",
			"Apresento-lhe o Sr. Tommy, senhor...",
			"Essa arma te deixa muito sexy...",
			"Queria ter uma câmera para tirar uma foto para minha mãe...",
			"Enfim... agora você pode resgatar sua preciosa filhinha como um gângster arrumado e molhado...",
			"Vai fundo, campeão..."
		};
		happyEdgeWoodChoice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Não, obrigado."
		};
		happyEdgeWoodChoice2 = new string[8]
		{
			"Eu te conheço?",
			"Quem?",
			string.Empty,
			"Não.",
			"Como?",
			string.Empty,
			string.Empty,
			"Comprar (1.000)."
		};
		happyHangly = new string[13]
		{
			"Olá, padre...",
			"Posso vender algumas coisas pelo preço certo...",
			"Falando nisso, seu cãozinho está congelando...",
			"Veja só, está se tremendo todo!",
			"Compre este suéter de cachorrinho por 400 Gotas Congeladas...",
			"Agradeço a compra, padre...",
			"Que bonitinho! Veja só ele, todo quentinho e confortável...",
			"Esse suéter foi feito à mão pela minha mãe...",
			"Aposto que ele tá começando a suar... ",
			"... a qualquer momento...",
			"A propósito, graças às Gotas Congeladas...",
			"Se precisar de alguma coisa, procure a coisinha de barbearia...",
			"Que fica girando e é amarelo..."
		};
		happyHanglyChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Não, obrigado."
		};
		happyHanglyChoice2 = new string[5]
		{
			"Olá.",
			string.Empty,
			string.Empty,
			string.Empty,
			"Comprar (400)."
		};
		happyCave = new string[10]
		{
			"Olá, padre...",
			"Então, o que você acha desse sistema de cavernas?",
			"Eu acho que o Pinstripe montou uma bela operação aqui...",
			"Mas ainda é muito frio...",
			"Eu podia jurar pelos olhos da minha mãezinha que seria mais quente no subsolo...",
			"Falando nisso, o Sr. Pinstripe me deu um terno extra...",
			"Deixa ver se eu... ahm... se eu acho ele aqui...",
			"Certo, certo. Aqui, aqui está. Vendo o terno extra dele por 500 Gotas Congeladas...",
			"Agradeço a compra, padre...",
			"........ Você ficou igualzinho a ele, Ted!........"
		};
		happyCaveChoice1 = new string[8]
		{
			string.Empty,
			"Ele é legal.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Não, obrigado."
		};
		happyCaveChoice2 = new string[8]
		{
			"Oi, Happy.",
			"Não achei nada de mais.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Comprar (500)."
		};
		timRedWash1 = new string[11]
		{
			"Olá, padre...",
			"Então, sobre aquelas Gotas Congeladas que você me deu em Pissward...",
			"Bom... parece que elas não foram suficientes para me fazer dormir...",
			"Por isso, ouça. Posso te ajudar a salvar a Bo do Pinstripe... mas você terá que me fazer um favor...",
			"Se você me trouxer 10 Sacos... não de Gotas Congeladas, mas os sacos frescos mesmo... os de verdade...",
			"Vou te vender um jornal... mas não um jornal comum...",
			"Ele tem a senha para entrar no presbitério do Pinstripe...",
			"Então, o que me diz? Esses Sacos são a única coisa que me farão dormir hoje à noite...",
			"Pinstripe fará a entrega desses Sacos em um horário específico, Padre...",
			"Então, aqui vai uma pequena pista sobre esse horário..",
			"Depois que você encontrar os Sacos, traga-os aqui para que eu tome eles todos..."
		};
		timRedWash1Choice1 = new string[18]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash1Choice2 = new string[10]
		{
			"Oi, Happy.",
			"Sim?",
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Claro!",
			string.Empty,
			"OK!"
		};
		timRedWash2 = new string[10]
		{
			"Olá, padre...",
			"Quer comprar o jornal por 10 sacos?...",
			"Vou te mostrar a pista para entrar no presbitério de Pinstripe...",
			"Agradeço...",
			"Está ficando tarde...",
			"Logo vou fechar a loja e pegar um saco de dormir — se é que você me entende...",
			"Dormir bem e confortável na minha loja durante a tempestade...",
			"Que loucura... o que você fez, padre?",
			"Enfim... a senha deve estar naquele jornal...",
			"...................... Boa noite, padre..."
		};
		timRedWash2Choice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			"Ainda não.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash2Choice2 = new string[10]
		{
			"Oi, Happy.",
			string.Empty,
			"Comprar (10 Sacos).",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapArea = new string[4]
		{
			"O estilingue de brinquedo da Bo...",
			"Na madeira está gravado “Feliz aniversário, Bo”...",
			"Clique ou pressione o gatilho para soltar.",
			"Você pode quebrar coisas, como aquela caixa..."
		};
		blunderBustTapAreaChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapAreaChoice2 = new string[5]
		{
			"Examinar.",
			string.Empty,
			string.Empty,
			"Pegar.",
			string.Empty
		};
		whiskey = new string[1]
		{
			"Uma garrafa de uísque..."
		};
		whiskeyChoice1 = new string[1]
		{
			string.Empty
		};
		whiskeyChoice2 = new string[1]
		{
			"Pegar."
		};
		dan = new string[10]
		{
			"Boa noite...",
			"Bem-vindo a Red Wash...",
			"A estância de prazer definitiva de Pinstripe.",
			"Assine o registro de hóspedes...",
			"Hmmm... que assinatura bonita...",
			"Aviso que hoje é uma noite especial...",
			"A cerimônia acontecerá quando a lua estiver cheia...",
			"Não é sempre que Pinstripe encontra uma criança saudável e cheinha...",
			"Por isso, o Sr. Pinstripe pediu que todos os hóspedes testemunhassem...",
			"A adoção eterna da criança..."
		};
		danChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Obrigado.",
			string.Empty,
			string.Empty,
			string.Empty
		};
		danChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Que cerimônia?"
		};
		dan2 = new string[7]
		{
			"A cerimônia...",
			"A cerimônia me dá calafrios...",
			"E me dá vontade de tomar leite.",
			"Não faz sentido o quê?",
			"Você não compreende a capacidade de um belo copo de leite morno?",
			"Leite morno, morninho, e uma cerimônia de adoção diferente de todas que já vi...",
			"É claro que você não entende..."
		};
		dan2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"OK."
		};
		dan2Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Não faz sentido..."
		};
		dan22 = new string[1]
		{
			"Daniel quer leite."
		};
		dan22Choice1 = new string[1]
		{
			string.Empty
		};
		dan22Choice2 = new string[1]
		{
			"OK."
		};
		dan23 = new string[1]
		{
			"Leite morno para a adoção."
		};
		dan23Choice1 = new string[1]
		{
			string.Empty
		};
		dan23Choice2 = new string[1]
		{
			"OK."
		};
		dan24 = new string[1]
		{
			"Queria um gole de leite molhado."
		};
		dan24Choice1 = new string[1]
		{
			string.Empty
		};
		dan24Choice2 = new string[1]
		{
			"OK."
		};
		dan25 = new string[1]
		{
			"Imagine um gole de leite na minha boca."
		};
		dan25Choice1 = new string[1]
		{
			string.Empty
		};
		dan25Choice2 = new string[1]
		{
			"OK."
		};
		dan26 = new string[1]
		{
			"Leite."
		};
		dan26Choice1 = new string[1]
		{
			string.Empty
		};
		dan26Choice2 = new string[1]
		{
			"OK."
		};
		dan27 = new string[1]
		{
			"..............................................................."
		};
		dan27Choice1 = new string[1]
		{
			string.Empty
		};
		dan27Choice2 = new string[1]
		{
			"Hã?"
		};
		kitty2 = new string[4]
		{
			"Ah, ora, ora, ora....",
			"Sua filhinha é agressiva...",
			"Mas, não se preocupe, Ted...",
			"Em breve, ela vai me chamar de “pai”..."
		};
		kitty4 = new string[1]
		{
			"........."
		};
		signMegaGem = new string[7]
		{
			"................................ Uma Gota Congelada preta e enorme...",
			"“Scoria Sackus de Moonstate: A maior Gota Congelada de Pinstripe já registrada...”",
			"“Escavada a 323 metros abaixo de Red Wash bem na epiderme de um Saco fossilizado”.",
			"“Avaliada em 50 Gotas Congeladas”.",
			"Tem cheiro de spray para cabelo...",
			"Até que é bom...",
			"Cante para eu dormir, Ada..."
		};
		signMegaGemChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"OK."
		};
		signMegaGemChoice2 = new string[4]
		{
			"Ler.",
			string.Empty,
			string.Empty,
			"Cheirar."
		};
		balloonMan1 = new string[11]
		{
			"Uhhhnngg... Eu não dei permissão para você ficar zanzando aqui...",
			"Mas, quer saber? Ainda bem que você fez isso. Porque agora eu tenho a quem me gabar sobre minhas máquinas de balões...",
			"O pessoal daqui me chama de Princle e eu sou o melhor criador de balões da cidade por conta dessas máquinas de balões...",
			"Pinstripe encomendou um lote inteiro de balões e eu atendi esse pedido como um príncipe...",
			"Isso... em, tipo, dez segundos...",
			"Hmmmm... Estou disposto a apostar minha mega Gota Congelada que você não consegue vencer a agilidade e velocidade das minhas máquinas...",
			"Sua confiança é exagerada demais, amigo!",
			"Prepare-se para ser derrotado!",
			"Em suas marcas...",
			"Preparar...",
			"JÁ!"
		};
		balloonMan1Choice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		balloonMan1Choice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Aceito a aposta!"
		};
		balloonMan2 = new string[6]
		{
			"PERDEDOR!",
			"Quer jogar de novo, padre?",
			"Você vai perder tão rápido que nem vai ver a cor do balão!",
			"Em suas marcas...",
			"Preparar...",
			"PRINCLE!"
		};
		balloonMan2Choice1 = new string[2]
		{
			string.Empty,
			"Não, obrigado."
		};
		balloonMan2Choice2 = new string[2]
		{
			string.Empty,
			"Vamos nessa!"
		};
		balloonMan2b = new string[6]
		{
			"OH CAPITÃO, MEU CAPITÃO!",
			"Quer jogar de novo, capitão?",
			"Mal posso esperar para ver essas habilidades!",
			"Em suas marcas...",
			"Preparar...",
			"PRINCLE!"
		};
		balloonMan2bChoice1 = new string[2]
		{
			string.Empty,
			"Não, obrigado."
		};
		balloonMan2bChoice2 = new string[2]
		{
			string.Empty,
			"Vamos nessa!"
		};
		balloonMan3 = new string[5]
		{
			"O QUÊÊÊÊÊÊÊ???!!!",
			"Você... você...",
			"Você é INCRÍVEL! Sua habilidade conseguiu vencer minhas máquinas de balões, isso é...",
			"Inacreditável! Não é possível...",
			"Pegue o prêmio, padre... Vá lá... pegue..."
		};
		balloonMan3Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"É muita gentileza!"
		};
		balloonMan3Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Ahm... dã..."
		};
		savePortraitGronkh = new string[2]
		{
			"Outro retrato... de um homem muito agressivo.",
			"..................................................Jogo salvo."
		};
		savePortraitGronkhChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkhChoice2 = new string[1]
		{
			"Salvar jogo."
		};
		savePortraitGronkh2 = new string[2]
		{
			"O retrato ainda parece muito agressivo...",
			"..................................................Jogo salvo."
		};
		savePortraitGronkh2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh2Choice2 = new string[1]
		{
			"Salvar jogo."
		};
		savePortraitGronkh3 = new string[2]
		{
			"Quanta agressividade! A agressividade dele domina a tela toda!",
			"..................................................Jogo salvo."
		};
		savePortraitGronkh3Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh3Choice2 = new string[1]
		{
			"Salvar jogo."
		};
		savePortraitGronkh4 = new string[2]
		{
			"A tela transmite uma sensação de muita agressividade. Provavelmente por causa do homem agressivo...",
			"..................................................Jogo salvo."
		};
		savePortraitGronkh4Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh4Choice2 = new string[1]
		{
			"Salvar jogo."
		};
		savePortraitDirk = new string[2]
		{
			"Um retrato de um sujeito bem penteado...",
			"..................................................Jogo salvo."
		};
		savePortraitDirkChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitDirkChoice2 = new string[1]
		{
			"Salvar jogo."
		};
		savePortraitRMannion = new string[2]
		{
			"Um retrato de um cara com pinta de artista moderno...",
			"..................................................Jogo salvo."
		};
		savePortraitRMannionChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitRMannionChoice2 = new string[1]
		{
			"Salvar jogo."
		};
		savePortraitJHandville = new string[2]
		{
			"Um retrato de um homem com um belo bigode...",
			"..................................................Jogo salvo."
		};
		savePortraitJHandvilleChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitJHandvilleChoice2 = new string[1]
		{
			"Salvar jogo."
		};
		savePortraitNathanKingston = new string[2]
		{
			"Um retrato de um cara que parece Jesus, mas que não é Jesus: o nome dele é Nathan...",
			"..................................................Jogo salvo."
		};
		savePortraitNathanKingstonChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitNathanKingstonChoice2 = new string[1]
		{
			"Salvar jogo."
		};
		savePortraitOchoma = new string[2]
		{
			"Um retrato triste e frio...",
			"..................................................Jogo salvo."
		};
		savePortraitOchomaChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitOchomaChoice2 = new string[1]
		{
			"Salvar jogo."
		};
		savePortraitBuddy = new string[2]
		{
			"Um retrato estranho de um homem...",
			"..................................................Jogo salvo."
		};
		savePortraitBuddyChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddyChoice2 = new string[1]
		{
			"Salvar jogo."
		};
		savePortraitBuddy2 = new string[2]
		{
			"Ainda é um retrato estranho de um homem... ele é careca e tem bigode...",
			"..................................................Jogo salvo."
		};
		savePortraitBuddy2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddy2Choice2 = new string[1]
		{
			"Salvar jogo."
		};
		creepyMan = new string[2]
		{
			"....... Ele já devia ter chegado.... não é?",
			"Ele já devia ter chegado com mais frutas..."
		};
		creepyMan2 = new string[2]
		{
			"Uma banheira?",
			"Ted... Acho que tem alguma coisa dentro..."
		};
		creepyMan3 = new string[5]
		{
			"Aquele idoso e uma senhora gentil acabaram de passar por aqui...",
			"Eles disseram que você vai destruir o Pinstripe...",
			"Não faz isso, cara!",
			"Ele é o único motivo de eu estar vivo aqui em baixo...",
			"Ele vai chegar a qualquer momento.... não é? Para me dar mais Sacos..."
		};
		jack = new string[8]
		{
			"......ugh....................... Padre?",
			"......egh....................... Socorro!",
			"Esse demônio está me devorando!",
			"Não estou te devorando......... Só estou te entregando em Red Wash.",
			"Não se preocupe, docinho.... é bem divertido lá em baixo... tem suco viscoso para beber todo dia e toda hora.",
			"Ah... sério?...",
			"Ahhhmn... então tá!",
			"Depressa! Não temos o dia todo!"
		};
		jackChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		jackChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkard = new string[9]
		{
			"Você vai festejar bastante depois da cerimônia, padre?",
			"Aqui, tome um pouco do suco do Sr. Pinstripe para se preparar... ",
			"Ahhh... mmmm....",
			"É bom, sim... mas não tanto quanto o verdadeiro...",
			"Pinstripe vai dar Sacos cheios dessa coisa durante a cerimônia...",
			"Você vai comer um pouco do fruto proibido junto com a gente, não vai, padre?",
			"Que tal se eu te nocautear de vez?",
			"Não tem nada pior do que se sentir julgado...",
			"Principalmente por alguém patético como você..."
		};
		drunkardChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Claro, adoro festas!",
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkardChoice2 = new string[6]
		{
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			"Não, obrigado, seu bêbado."
		};
		dickyBar = new string[11]
		{
			"...pssst...",
			"Ted... sou eu...",
			"Sr. Dicky...",
			"Tome cuidado aqui embaixo...",
			"O Pinstripe me mata se me achar...",
			"Principalmente se ele pegar a gente ajudando você a encontrar a Bo, por isso...",
			"Estou disfarçado...",
			".... Sou um palhaço, Ted...",
			"Tá vendo o nariz?",
			"Ela está escondida no poço do Pinstripe...",
			"Ela disse que tem uma surpresa para você..."
		};
		dickyBarChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"É.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarChoice2 = new string[22]
		{
			"Ei.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Cadê a Miss Birdy?",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2 = new string[6]
		{
			"O quê?",
			"Você não está encarando as verrugas na minha testa, está?",
			"Pare com isso! Pare com isso!",
			"Não sou nenhum palh...",
			"...................",
			"Me deixa em paz!"
		};
		dickyBar2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarNight = new string[6]
		{
			"O que você fez, Ted?",
			"Meus ossos estão doloridos...",
			"Acho que...",
			"Ted...",
			"Desculpe, mas acho que é o fim...",
			"Eu disse que é o fim."
		};
		dickyBarNightChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK."
		};
		dickyBarNightChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"O quê?"
		};
		birdyBarrel = new string[9]
		{
			"Shhhhh... heheheh...",
			"Teddyzinho...",
			"Sou eu de novo...",
			"Rápido! Pegue essa colher de verdade...",
			"Ela é brilhante e tem um cheiro que me agrada muito...",
			"E é agradável ao toque, não é?",
			"Vai precisar dela para derrotar Pinstripe e resgatar a pobrezinha da Bo...",
			"Mas não conte para ninguém que estou aqui...",
			"Não quero que Pinstripe me tranque naquela gaiola de novo..."
		};
		birdyBarrelChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Ela é mesmo!"
		};
		birdyBarrelChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Tá, valeu, hein...",
			string.Empty,
			"Quanta besteira..."
		};
		tokenInvite1 = new string[1]
		{
			"Um pedaço de papel..."
		};
		tokenInvite1Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite1Choice2 = new string[1]
		{
			"Pegar."
		};
		tokenInvite2 = new string[1]
		{
			"Um pedaço de papel..."
		};
		tokenInvite2Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite2Choice2 = new string[1]
		{
			"Pegar."
		};
		tokenFilmStrip = new string[1]
		{
			"Uma tira de filme secreta..."
		};
		tokenFilmStripChoice1 = new string[1]
		{
			string.Empty
		};
		tokenFilmStripChoice2 = new string[1]
		{
			"Pegar."
		};
		tokenBible = new string[1]
		{
			"Uma bíblia velha..."
		};
		tokenBibleChoice1 = new string[1]
		{
			string.Empty
		};
		tokenBibleChoice2 = new string[1]
		{
			"Pegar."
		};
		tokenNotebook = new string[3]
		{
			"Como isso veio parar aqui...",
			"Não olhe, papai...",
			"É só um desenho bobo..."
		};
		tokenNotebookChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		tokenNotebookChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Examinar."
		};
		tokenPills = new string[1]
		{
			"Um frasco de remédio vazio..."
		};
		tokenPillsChoice1 = new string[1]
		{
			string.Empty
		};
		tokenPillsChoice2 = new string[1]
		{
			"Pegar."
		};
		tokenNewspaper = new string[1]
		{
			"Um jornal..."
		};
		tokenNewspaperChoice1 = new string[1]
		{
			string.Empty
		};
		tokenNewspaperChoice2 = new string[1]
		{
			"Pegar."
		};
		tokenLocket = new string[3]
		{
			"Por que jogaram suas coisas pela porta, papai?",
			"Esse...",
			"... é o medalhão da mamãe?"
		};
		tokenLocketChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		tokenLocketChoice2 = new string[3]
		{
			"Não sei dizer...",
			string.Empty,
			"Examinar."
		};
		blackAndWhiteModeTalk = new string[4]
		{
			"Quer mesmo jogar tudo de novo?",
			"Este jogo é horrível...",
			"Enfim, quer jogar no Modo Retrô por 5 Tiras de Filme?",
			"Parabéns. Você gastou 5 Tiras de Filme para tirar todas as belas cores desse jogo..."
		};
		blackAndWhiteModeTalkChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Não.",
			string.Empty
		};
		blackAndWhiteModeTalkChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Sim (5 Tiras de Filme).",
			string.Empty
		};
		sackGeneratorExamine = new string[4]
		{
			"Parece com um daqueles sacos que demos para a árvore em Edge Wood... só que gigante!",
			"Parece que está dormindo ou sei lá...",
			"E tem cheiro de ovo...",
			"Legal..."
		};
		sackGeneratorExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGeneratorExamineChoice2 = new string[1]
		{
			"Examinar."
		};
		sackGenerator2Examine = new string[4]
		{
			"Mais um daqueles geradores de Saco...",
			"Credo...",
			"Olha esses dentes!",
			"Ugh! E esse tem cheiro de leite podre..."
		};
		sackGenerator2ExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGenerator2ExamineChoice2 = new string[1]
		{
			"Examinar."
		};
		sackGenerator3Examine = new string[5]
		{
			"Mais um...",
			"Talvez esse aqui fermente o saco ou algo do tipo...",
			"Não sei...",
			"Esse aqui tem cheiro de....................................................cocô.",
			"É... desculpa, mas é o cheiro que tem, cara..."
		};
		sackGenerator3ExamineChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Você é engraçado, George..."
		};
		sackGenerator3ExamineChoice2 = new string[5]
		{
			"Examinar.",
			string.Empty,
			string.Empty,
			"Chega de falar...",
			string.Empty
		};
		characterSucked = new string[1]
		{
			"............."
		};
		characterSuckedFelix = new string[2]
		{
			"Ted...",
			"Tem algo na minha cabeça?"
		};
		explainFire = new string[8]
		{
			"Olá, insignificante...",
			"Não me julgue...",
			"Não me comportei mal, eu juro... Só estava com sede...",
			"Nada como um bom gole do suco do Pinstripe...",
			"Faz eu me sentir muito especial...",
			"Ele disse que vai dar mais para comemorar a adoção da Bo...",
			"Qual é o seu problema, imbecil?",
			"Você não sabe nem parar um carro..."
		};
		explainFireChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		explainFireChoice2 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Quando vai acontecer a adoção?",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		redWashNotice = new string[7]
		{
			"Um aviso...",
			"“Os moradores de Red Wash que participarem da adoção de Bo...”",
			"“... ganharão uma entrega gratuita dos Sacos do Pinstripe...?”",
			"“Os moradores que não participarem...”",
			"“Levarão uma bronca e..... serão chicoteados impiedosamente até se arrependerem...”?",
			"“Obrigado e tenham um bom dia!”",
			"........ legal........"
		};
		redWashNoticeChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Que horrível..."
		};
		redWashNoticeChoice2 = new string[6]
		{
			"Ler.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"É o tipo de festa que eu gosto."
		};
		potBellyMan = new string[7]
		{
			"Shhhhh... heheheh...",
			"Você... ouviu isso, padre?",
			"Aquele relógio enorme do Pinstripe...",
			"Recebi ordens para não deixar ninguém tocar nele...",
			"Sob nenhuma circunstância ninguém poderá...",
			"... mexer naquela droga de relógio!",
			"Você não entende................... não é mesmo, cara?!"
		};
		potBellyManChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Entendi!"
		};
		potBellyManChoice2 = new string[4]
		{
			string.Empty,
			"O quê?",
			string.Empty,
			"Não vou só tocar nele..."
		};
		potBellyMan2 = new string[6]
		{
			"..................",
			"Você mexeu no relógio enorme?",
			"VOCÊ NÃO OUVIU AS REGRAS?",
			"De novo não! De novo não!",
			"O Sr. Pinstripe vai arrancar meus dentes...",
			"................................ De novo!"
		};
		potBellyMan2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Ahm... tchau..."
		};
		potBellyMan2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"O que foi?"
		};
		potBellyMan22 = new string[3]
		{
			"............... Ughhh....",
			"Quero dizer...",
			"Ter os dentes arrancados é uma coisa. Mas eu espero que ele ainda me dê meu Saco..."
		};
		potBellyMan22Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		potBellyMan22Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Nossa.",
			string.Empty
		};
		fork = new string[3]
		{
			"Um garfo.",
			"Está um pouco enferrujado e cheira a dinheiro...",
			"Coberto de.......................................... perfume?"
		};
		forkChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		forkChoice2 = new string[3]
		{
			"Examinar.",
			string.Empty,
			"Pegar."
		};
		boHeaven1 = new string[3]
		{
			"Papai!",
			"Fiquei com saudade!",
			"Quer brincar lá fora?"
		};
		boHeaven1Choice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boHeaven1Choice2 = new string[3]
		{
			"Bo!",
			"Também estava com saudade!",
			"Sim!"
		};
		boHeaven2 = new string[2]
		{
			"Papai!",
			"Parece com o colar de borboleta da mamãe!"
		};
		boHeaven2Choice1 = new string[1]
		{
			string.Empty
		};
		boHeaven2Choice2 = new string[1]
		{
			"É?"
		};
		boHeavenGeorge = new string[1]
		{
			"Ah.............. Queria que o Georgie estivesse aqui..."
		};
		boHeavenGeorgeChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenGeorgeChoice2 = new string[1]
		{
			"..."
		};
		boHeavenButterflies = new string[3]
		{
			"Caramba! Olha, pai!",
			"Queria que a mamãe estivesse aqui para ver isso. Ela adorava borboletas...",
			"Ei! Aposto que você não consegue pegar todas!"
		};
		boHeavenButterfliesChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenButterfliesChoice2 = new string[2]
		{
			string.Empty,
			"É..."
		};
		secretRoomCaveSign = new string[8]
		{
			"Uma tabuleta de pedra...",
			"“A Câmara do Arcebispo:”",
			"“dedicada ao arcebispo eleito.”",
			"“Como um raio...”",
			"“E num piscar de olhos, a elite forneceu a energia...”",
			"“Para iluminar e expandir o mundo de Pinstripe.”",
			"“Aproveite as Gotas Carmesim de Magnus, avaliadas em 200 gotas cada.”",
			"“(A propósito, elas têm cheiro de desinfetante.)”"
		};
		secretRoomCaveSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomCaveSignChoice2 = new string[1]
		{
			"Examinar."
		};
		secretRoomTreeSign = new string[7]
		{
			"“Uma tábua de pedra...”",
			"“O Jardim do Arcebispo:”",
			"“dedicada ao arcebispo eleito.”",
			"“Os presentes sinceros e humildes dados pela elite...”",
			"“Foram uma semente dourada, que formaram esse espinho magnífico...”",
			"“Fique à vontade para se servir das Gotas de Lemonree Statton, avaliadas em 100 gotas cada”.",
			"“(A propósito, elas têm cheiro de protetor solar com aroma de limão recém-espremido.)”"
		};
		secretRoomTreeSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomTreeSignChoice2 = new string[1]
		{
			"Examinar."
		};
	}
	else if (@string == "French")
	{
		Debug.Log("French");
		trainDoorButton1 = new string[1]
		{
			"Un bouton..."
		};
		wifeIntro = new string[2]
		{
			"Teddy...",
			"Je dois te dire quelque chose..."
		};
		bo1 = new string[6]
		{
			"Papa, réveille-toi !",
			"Tu as encore fait une crise de somnambulisme...",
			"Hé ! Tu sens cette fumée ?",
			"Allons voir !",
			"Tu seras Sherlock...",
			"Ne dis pas de bêtises !"
		};
		bo1Choice1 = new string[5]
		{
			string.Empty,
			"Pardon, ma puce.",
			string.Empty,
			string.Empty,
			"OK."
		};
		bo1Choice2 = new string[5]
		{
			"Euuuh... Quoi ?",
			"Non, c'est faux.",
			"Oui.",
			string.Empty,
			"D'accord, Watson !"
		};
		trainDoorButtonBo = new string[2]
		{
			"Sherlock !",
			"Je pense pouvoir atteindre ce bouton !"
		};
		trainDoorButtonBoChoice1 = new string[3]
		{
			"Watson ?",
			string.Empty,
			string.Empty
		};
		trainDoorButtonBoChoice2 = new string[2]
		{
			string.Empty,
			"D'accord... Reste là !"
		};
		lockedTrainDoor = new string[1]
		{
			"C'est fermé..."
		};
		sackSpitExplainer = new string[3]
		{
			"Papa, c'est quoi ça ?",
			"On dirait une goutte d'huile...",
			"gelée ?"
		};
		mirror = new string[7]
		{
			"C'est un miroir, Sherlock !",
			"Il est tellement poussiéreux que j'arrive à peine à voir ton visage.",
			"Ça fait peuuuuur...",
			"Hé ! Regarde, papa, c'est rigolo. On ressemble à des fantômes...",
			"Boom !",
			"Ah, oui...",
			"Boub !"
		};
		mirrorChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Allons-y."
		};
		mirrorChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"On dit « bouh », ma puce."
		};
		mirror2 = new string[6]
		{
			"Miroir, miroir...",
			"Dis-moi que je suis la plus meilleure princesse de...",
			".......................",
			".......................",
			"Papa, qu'est-ce qui rime avec miroir ?",
			"Dis-moi que je suis la plus meilleure princesse du terroir !"
		};
		mirror2Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Allons-y."
		};
		mirror2Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Terroir."
		};
		boTrainBar = new string[5]
		{
			"Papa, on peut sortir d'ici ?",
			"Ça sent le caca...",
			"Pardon...",
			"Ça sent...",
			"Les excréments..."
		};
		boTrainBarChoice1 = new string[4]
		{
			string.Empty,
			"Bien sûr.",
			string.Empty,
			string.Empty
		};
		boTrainBarChoice2 = new string[5]
		{
			string.Empty,
			"Surveille ton langage !",
			string.Empty,
			string.Empty,
			"Bo !"
		};
		boJumpingBean = new string[8]
		{
			"On dirait un pois sauteur, Sherlock.",
			"« Pois, pois, pois sauteur, il est pas radin, il est si fin. »",
			"« Saute, saute, hop, hop, hop. »",
			"« C'est un petit sauteur qui fait tut, tut, tut. »",
			"J'aime beaucoup cette émission.",
			"Cette émission est tellement bête...",
			"Je ne savais pas que tu aimais cette émission, Sherlock !",
			"Je croyais que tu n'aimais que ta pipe et enquêter sur les homicides !"
		};
		boJumpingBeanChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK"
		};
		boJumpingBeanChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Moi aussi !"
		};
		boTrainButtonSolution = new string[4]
		{
			"Je ne voudrais pas être... irrespectueux ou quoi...",
			"Mais... Est-ce que tu sais ce que tu fais ?",
			"Alors, ravie d'être ta partenaire, Sherlock !",
			"Appuie sur les boutons quand ils sont tous les deux jaunes !"
		};
		boTrainButtonSolutionChoice1 = new string[4]
		{
			string.Empty,
			"Mais c'est bien sûr !",
			string.Empty,
			string.Empty
		};
		boTrainButtonSolutionChoice2 = new string[4]
		{
			string.Empty,
			"Pas vraiment...",
			string.Empty,
			"Bien vu, Watson !"
		};
		bo2 = new string[1]
		{
			"Regarde papa, un ballon !"
		};
		bo2Choice1 = new string[1]
		{
			string.Empty
		};
		bo2Choice2 = new string[1]
		{
			"Bo, arrête !"
		};
		bo3 = new string[3]
		{
			"Pauvre Georgie...",
			".........................................................",
			"Il est coincé dans sa caisse..."
		};
		bo3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bo3Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"OK."
		};
		bo32 = new string[3]
		{
			"...................",
			"Il doit probablement sentir les miettes de chips sur ta veste...",
			"Ce n'est pas très gentil de le tourmenter comme ça..."
		};
		bo33 = new string[3]
		{
			".......................",
			"Georgie aime bien les chips au poulet grillé de chez Martin...",
			"Et si tu n'en as pas à lui donner, tu ferais mieux de te remettre au travail, monsieur..."
		};
		pinstripeTrain1 = new string[7]
		{
			"Bonjour, Ted...",
			"À qui ai-je l'honneur ?",
			"Bonjour, Bo...",
			"Tu aimes les ballons ?",
			"Que dirais-tu d'un ballon noir qui brille ?",
			"Je ne suis qu'un gentil monsieur...",
			"Avec un ballon noir qui brille..."
		};
		pinstripeTrain1Choice1 = new string[7]
		{
			"Hmm...",
			string.Empty,
			string.Empty,
			string.Empty,
			"Non, merci...",
			string.Empty,
			string.Empty
		};
		pinstripeTrain1Choice2 = new string[7]
		{
			"Bonjour ?",
			"Euh... Voici Bo.",
			string.Empty,
			string.Empty,
			"Qui es-tu ?",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2 = new string[4]
		{
			"Oh, et Bo...",
			"Tu as une jolie robe...",
			"Oooh... Ce n'est pas très gentil...",
			"Bo, ton papa n'est qu'une brute..."
		};
		pinstripeTrain2Choice1 = new string[4]
		{
			string.Empty,
			"Allons-y, Bo...",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2Choice2 = new string[4]
		{
			string.Empty,
			"Laisse-nous tranquilles, espèce de malade.",
			string.Empty,
			"Viens, Bo."
		};
		pinstripeHanglyPass = new string[10]
		{
			"Bonjour, Ted...",
			"Ooooh.... Tu as fait appel à cet antimite puant de Dicky pour retrouver Bo...",
			"Mon petit doigt me dit que le dos de ce vieux Dicky est aussi résistant que celui d'une...",
			"... pauvre marionnette en bois...",
			"Alors, je pense que Bo passera du temps avec moi dans mon petit presbytère...",
			"Oui... C'est précisément ce que nous allons faire...",
			"Tu n'es qu'un pauvre crétin !",
			"Pardon ?",
			"Pardon, tête d'œuf ?",
			"Pas étonnant qu'un raté dans ton genre ait rejoint les rangs de ces sales damnés..."
		};
		pinstripeHanglyPassChoice1 = new string[11]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"(Retiens-toi.)",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeHanglyPassChoice2 = new string[7]
		{
			"Amène-moi jusqu'à Bo !",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Tu as quel âge, dix ans ?"
		};
		pinstripeCave = new string[7]
		{
			"Bonjour, Ted...",
			"Je dois l'admettre... Je suis impressionné...",
			"Malheureusement, Bo passe son temps...",
			"... dans mon presbytère...",
			"J'ai hâte de voir ta jolie petite tête lors de la cérémonie...",
			"La cérémonie d'adoption, pauvre NASE !",
			"Ciao, mon grand..."
		};
		pinstripeCaveChoice1 = new string[8]
		{
			string.Empty,
			"OK",
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveChoice2 = new string[8]
		{
			string.Empty,
			"Où est Bo ?",
			string.Empty,
			string.Empty,
			"Quelle cérémonie ?",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExit = new string[10]
		{
			"Tu as aimé mes petits messages sur les murs ?",
			"Je n'ai pas pu m'en empêcher, Ted.",
			"Bo m'appartient, sale RAT !",
			"« Papa, papa, sauve-moi ! »",
			"Ahohohohohoh.......... Pardon, Bo !",
			"Ton père tourne en rond comme un DÉBILE !",
			"Ahahahahahahahaha...........................",
			"J'ai tellement hâte à la CÉRÉMONIE !",
			"Les larmes envahiront ton joli petit visage pâle, Ted...",
			"Et je trépignerai de joie en te regardant..."
		};
		pinstripeCaveExitChoice1 = new string[10]
		{
			"Non.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExitChoice2 = new string[10]
		{
			"Oui.",
			"Amène-moi jusqu'à Bo !",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill = new string[9]
		{
			"Te voilà pile à l'heure pour la cérémonie, Ted.",
			"Oooh... Arrête de pleurnicher comme une FILLETTE !",
			"Et puis, pour être honnête, Bo sera bien plus heureuse avec moi...",
			"Alors, tu assisteras à la cérémonie ?",
			"L'heure tourne, Ted...",
			"SALE VERMINE !",
			"Essaie un peu.",
			"Mais si tu ne te souviens pas du jour sacré de ta mort...",
			"J'ai bien peur que Bo ne m'appartienne à jamais..."
		};
		pinstripeWindmillChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"(Retiens-toi).",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmillChoice2 = new string[10]
		{
			"Laisse Bo tranquille !",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Tu vas me le payer, espèce de porc !",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2 = new string[8]
		{
			"Ooooh... Ted, tu viens de louper la cérémonie...",
			"Regarde comme elle est mignonne...",
			"Tu veux dire quelque chose, ma chérie ?",
			"Rentre chez toi, Ted...",
			"J'ai un nouveau papa, à présent...",
			"Il me protégera et m'aimera de tout son cœur...",
			"C'EST TERMINÉ, TED !",
			"Dommage que tu ne puisses pas remonter le temps."
		};
		pinstripeWindmill2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2Choice2 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Bo, c'est moi !",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrain = new string[8]
		{
			"Tu veux jouer aux petits trains avec moi, Ted ?",
			"Tu seras le conducteur...",
			"Le conducteur écervelé...",
			"Serait-ce ton pauvre petit bébé, là-haut ?",
			"Qui périt dans les flammes ?",
			"Espèce de MINABLE !",
			"C'est ici que j'habite maintenant...",
			"Avec mon nouveau papa..."
		};
		boWithTrainChoice1 = new string[10]
		{
			"Bien sûr !",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrainChoice2 = new string[3]
		{
			"Bo, allons-y !",
			"Allez, Bo !",
			string.Empty
		};
		hiveTrain = new string[3]
		{
			"..................... Beurk !",
			"On dirait un vieux sac géant...",
			"Ça me donne le tournis..."
		};
		hiveTrain2 = new string[2]
		{
			"Papa, tu devrais arrêter de renifler ce truc...",
			"Ce n'est pas bon pour toi..."
		};
		hiveTrain3 = new string[4]
		{
			"Regarde ce que tu as fait, papa !",
			"Maman serait en colère après toi...",
			"Elle m'a toujours dit de ne pas renifler les choses qui ont une drôle d'apparence...",
			"Comme le truc marron que j'ai trouvé sous le réfrigérateur..."
		};
		scarf = new string[3]
		{
			"L'écharpe de Bo...",
			"Elle sent la fumée...",
			"... et le whisky..."
		};
		scarfChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		scarfChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Prendre."
		};
		bigTree = new string[2]
		{
			"......Nourriiiiiiiis.......",
			"......moiiiii......."
		};
		bigTreeChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bigTreeChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Nourrir."
		};
		oldManV2 = new string[12]
		{
			"..... Argh !....",
			"Ted ?",
			"Reconnais-tu ce beau visage, mon vieux ? C'est moi... M. Dicky...",
			"Va-t'en de là, mon garçon...",
			"Bienvenue en enfer, petit. Maintenant, dégage !",
			"...... Pinstripe......",
			"Je pense savoir où elle se trouve, Ted !",
			"... Hangly House...",
			"Mais vu ta carrure, je ne sais pas comment tu arriveras à te défendre sans arme...",
			"Je crains de ne pas pouvoir t'aider, à moins que tu en trouves une...",
			"Je ne pleure pas, je...",
			"Euh... riais......"
		};
		oldManV2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Merci, mon bon monsieur !"
		};
		oldManV2Choice2 = new string[10]
		{
			"À l'aide !",
			"On se connaît ?",
			string.Empty,
			"Mais j'ai besoin d'aide !",
			"Ma fille s'est fait kidnapper !",
			"Qui ?",
			string.Empty,
			string.Empty,
			string.Empty,
			"Quel pleurnicheur..."
		};
		oldManV22 = new string[5]
		{
			"Que... Qu'est-ce que tu regardes comme ça ?",
			"Mes grains de beauté ? J'ai des grains de beauté sur le visage. Mais c'est génétique, je le jure !",
			"Ma mère m'a toujours dit que c'était un don de Dieu...",
			"J'ai toujours pensé que je ne méritais pas Birdy, alors je voulais que le Dr Shrenweld me les retire...",
			"J'avais le visage d'un clown déformé en primaire..."
		};
		oldManV23 = new string[5]
		{
			"Ces grains de beauté ne sont pas un numéro de cirque !",
			"Est-ce qu'ils peuvent conduire un monocycle, imbécile ? Hein ?",
			"Est-ce qu'ils peuvent dompter une bête à quatre pattes ? No ! No !",
			"N'est-ce pas ta fille qui a été kidnappée ? Et tu restes là à... m'observer...",
			"En prenant mes grains de beauté pour des numéros de cirque !"
		};
		hive = new string[2]
		{
			"L'un de ces sacs...",
			"... avec une odeur sensationnelle."
		};
		hiveChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		hiveChoice2 = new string[2]
		{
			string.Empty,
			"Prendre."
		};
		felix1 = new string[5]
		{
			"....................................................... Hé !",
			"Là-haut !",
			"Mais pourquoi es-tu habillé comme un satané pasteur ?",
			"....................................",
			"As-tu essayé ces sacs ?"
		};
		felix1Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		felix1Choice2 = new string[5]
		{
			"Bonjour...",
			string.Empty,
			"Hmm...",
			string.Empty,
			"Non."
		};
		felixHurt = new string[3]
		{
			"................................",
			"................. Euh............... C'est pas cool, mon pote.",
			"...... Argh......... Ça m'a vraiment blessé..."
		};
		felixHurtChoice1 = new string[2]
		{
			string.Empty,
			"Désolé !"
		};
		felixHurtChoice2 = new string[2]
		{
			string.Empty,
			"Ça fait mal, hein ?"
		};
		drunkMan3 = new string[5]
		{
			"............................",
			"Ce Pinstripe a vraiment beaucoup de classe...",
			"Une classe incontestable...",
			"..........................................................................................................................................",
			"Tu as entendu ça ?"
		};
		drunkMan3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Si tu le dis, mon gars !"
		};
		drunkMan3Choice2 = new string[3]
		{
			"Rebonjour.",
			string.Empty,
			"Tu sens fort."
		};
		poolTableMan = new string[3]
		{
			"Descends de là, voyou.",
			"Je suis au beau milieu d'une partie...",
			"Ce n'est pas parce que tu es père que ça fait de toi mon papa. Je t'ai dit de descendre de là, voyou..."
		};
		poolTableManChoice1 = new string[4]
		{
			string.Empty,
			"Je suis vraiment désolé.",
			string.Empty,
			string.Empty
		};
		poolTableManChoice2 = new string[4]
		{
			string.Empty,
			"Ton haleine...",
			string.Empty,
			string.Empty
		};
		dog2 = new string[10]
		{
			"Merci, Ted... !",
			"Je pensais ne jamais pouvoir me sortir de là...",
			"Hé... Où est Bo ?",
			"Aaargh... Je le craignais...",
			"Eh bien, va falloir la retrouver, mon gars...",
			"Je peux peut-être t'aider en reniflant des indices ou quelque chose comme ça...",
			"En parlant de ça, est-ce que M. Dicky est dans les parages ?",
			"Ouais....... Je pourrai sentir le derrière de ce type à un kilomètre...",
			"Ce Pinstripe...",
			"Quel abruti !"
		};
		dog2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK",
			string.Empty,
			"Je suis désolé !"
		};
		dog2Choice2 = new string[10]
		{
			"Tu parles !",
			string.Empty,
			"Pinstripe l'a kidnappée !",
			string.Empty,
			"Allons-y !",
			string.Empty,
			"Oui",
			"Pourquoi étais-tu enfermé ?",
			string.Empty,
			"Tu n'es qu'un abruti..."
		};
		dogBoSmell = new string[7]
		{
			"Ouah !",
			"Tu sens ça, Ted ?",
			"Ça sent... les pommes...",
			"Moi, pas trop...",
			"J'aime le fromage et les tartes, et à peu près tout ce qui sent le bœuf...",
			"Ouais....................................... désolé.",
			"Allons-y."
		};
		dogBoSmellChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty
		};
		dogBoSmellChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			"Bo adore les pommes.",
			"Hmm.",
			string.Empty
		};
		dog3 = new string[2]
		{
			"Ted...",
			"Retrouve Bo..."
		};
		dogPraise1 = new string[1]
		{
			"Bien vu, Ted !"
		};
		dogBalloonPop = new string[3]
		{
			"Ah ! Mec ! Je fais un bond à chaque fois que tu éclates des ballons.",
			"Pourrais-tu... arrêter ?",
			"Alors c'est comme ça que ça se passe, hein ?"
		};
		dogBalloonPopChoice1 = new string[2]
		{
			string.Empty,
			"Pardon, George !"
		};
		dogBalloonPopChoice2 = new string[2]
		{
			string.Empty,
			"Euh... non."
		};
		dogBalloonPop2 = new string[3]
		{
			"DAH !",
			"Ted ! Les ballons...",
			"Sérieusement ?"
		};
		dogBalloonPop2Choice1 = new string[2]
		{
			string.Empty,
			"Je suis désolé !"
		};
		dogBalloonPop2Choice2 = new string[2]
		{
			string.Empty,
			"Lol."
		};
		recordPlayer1 = new string[3]
		{
			"Le tourne-disque est recouvert de plumes rouges...",
			"Ce disque s'appelle « Miss Birdy Bondette : Intermezzos & autres contemplations ».",
			"Cette chanson s'appelle « Le dernier sourire »."
		};
		recordPlayer1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer1Choice2 = new string[3]
		{
			string.Empty,
			"Jouer",
			string.Empty
		};
		recordPlayer12 = new string[2]
		{
			"Quelle belle musique...",
			"J'ai l'impression d'être au paradis des chiens..."
		};
		recordPlayer12Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer12Choice2 = new string[3]
		{
			string.Empty,
			"OK.",
			string.Empty
		};
		recordPlayer2 = new string[3]
		{
			"Hé ! C'est l'un des albums de Miss Birdy, il fait chaud au cœur !",
			"Écoutons-le, Ted !",
			"« La dernière balade »........... C'est bien triste, comme titre..."
		};
		recordPlayer2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer2Choice2 = new string[3]
		{
			string.Empty,
			"Jouer",
			string.Empty
		};
		recordPlayer22 = new string[2]
		{
			"Mmmmmmmmmmmmmmmm........................ Trop beau. J'aimerais qu'il sente aussi bon que sa musique...",
			"Mais ça sent juste la grand-mère..."
		};
		recordPlayer22Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer22Choice2 = new string[3]
		{
			string.Empty,
			"OK.",
			string.Empty
		};
		recordPlayer3 = new string[4]
		{
			"Un autre album de Miss Birdy...",
			"Il y a un mot collé dessus...",
			"« Teddy, j'ai écrit cette chanson pour Bo. Toutes mes condoléances. — Miss Birdy »",
			"Ça s'appelle..................... « La dernière étreinte »."
		};
		recordPlayer3Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer3Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Jouer",
			string.Empty
		};
		recordPlayer32 = new string[3]
		{
			"C'est si... triste...",
			"On peut encore sauver Bo... n'est-ce pas ?",
			"Tout va bien se passer, Ted..."
		};
		recordPlayer32Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer32Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dogRecordPlayer = new string[1]
		{
			"Cette chanson est glauque..."
		};
		dogRecordPlayerChoice1 = new string[1]
		{
			string.Empty
		};
		dogRecordPlayerChoice2 = new string[1]
		{
			"Ouaip."
		};
		dogPoop = new string[4]
		{
			"Argh......... Des crottes de Petite Dame...",
			"Si tu la vois... Il faut que tu sautes sur ses fesses...",
			"Attends, attends, attends...",
			"Je suis un chien qui parle et tu me questionnes sur mon accent ?"
		};
		dogPoopChoice1 = new string[2]
		{
			string.Empty,
			"Merci du conseil !"
		};
		dogPoopChoice2 = new string[2]
		{
			string.Empty,
			"Tu n'as pas d'accent, empoté ?"
		};
		dogMushroom = new string[5]
		{
			"Un champignon reluisant...",
			"Celui-ci sent surtout le kérosène...",
			"Hé Ted, tu te souviens avoir vu ces trucs partout dans Edge Wood et Hangly Pass ?",
			"Je ne sais pas... On pourrait peut-être trouver des gouttes glacées en les enflammant ou je ne sais quoi...",
			"J'essaie simplement d'aider..."
		};
		dogMushroomChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Bien vu, George !"
		};
		dogMushroomChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Oui, et alors ?",
			"Euh... Sans blague."
		};
		dogCaveJumpComment = new string[1]
		{
			"Bien joué !"
		};
		dogCaveJumpCommentChoice1 = new string[1]
		{
			string.Empty
		};
		dogCaveJumpCommentChoice2 = new string[1]
		{
			"Merci !"
		};
		caves = new string[2]
		{
			"Cette grotte est sombre et maléfique...",
			"Il fait nuit noire, on n'y voit goutte..."
		};
		caves2 = new string[2]
		{
			"Un bruit terrifiant et menaçant se fait entendre dans les profondeurs...",
			"..........................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................."
		};
		flashLightTalk = new string[3]
		{
			"Jolie lampe frontale !",
			"Il y a comme des... fleurs dessinées à l'intérieur...",
			"Sélectionne l'icône pour l'allumer ou l'éteindre."
		};
		flashLightTalkChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		flashLightTalkChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Prendre."
		};
		lewis = new string[5]
		{
			"...... Aaargh.... Ooooh...... Ooooooh....",
			"Mon dos me fait terriblement souffrir !",
			"Écoute, morveux, on n'a pas beaucoup de temps...",
			"Uhhh........ Bo est au sommet de la montagne... dans... Hangly House...",
			"J'aimerais tellement voir mes petites jambes guindées grimper cette montagne..."
		};
		lewisChoice1 = new string[5]
		{
			string.Empty,
			"Je suis désolé !",
			string.Empty,
			"OK.",
			string.Empty
		};
		lewisChoice2 = new string[5]
		{
			"Ça va, Dicky ?",
			"Tu n'es plus tout jeune.",
			string.Empty,
			"Tu ne viens pas ?",
			"OK."
		};
		lewis2 = new string[4]
		{
			"Tu tournes en rond comme un bouffon...",
			"À ton âge, je travaillais 80 heures par semaine dans le moulin de mon père...",
			"Il me frappait quotidiennement avec ses poings...",
			"J'ai... J'en ai gardé les cicatrices..."
		};
		oldManStartWalking = new string[4]
		{
			"Pourquoi as-tu mis autant de temps, fesses de limace ?",
			"Nous nous reverrons à Hangly House...",
			"Je te l'ai dit ! Hangly House... en haut de la montagne...",
			"Je suis sûr que c'est ici que Pinstripe garde Bo..."
		};
		oldManStartWalkingChoice1 = new string[4]
		{
			string.Empty,
			"OK.",
			string.Empty,
			"Nous nous reverrons là-bas !"
		};
		oldManStartWalkingChoice2 = new string[4]
		{
			string.Empty,
			"Où ?",
			string.Empty,
			"Bien. Bon sang, vieillard..."
		};
		key = new string[2]
		{
			"Une clé en argent...",
			"Un minuscule « P » gravé sur le manche..."
		};
		keyChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		keyChoice2 = new string[2]
		{
			string.Empty,
			"Prendre."
		};
		goldKeyTalk = new string[1]
		{
			"Une clé en or..."
		};
		rifle = new string[4]
		{
			"Un vieux fusil...",
			"Ha, c'est génial...",
			"Il s'appelle « Infinite Songbird »... C'est gravé sur la crosse...",
			"Je me demande pourquoi il s'appelle comme ça ?"
		};
		rifleChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		rifleChoice2 = new string[4]
		{
			"Super !",
			string.Empty,
			string.Empty,
			"Prends ça !"
		};
		oldWomanPorch = new string[8]
		{
			"Que mes seins soient bénis...",
			"Mon Teddy ? C'est toi ?",
			"Je suis contente de te voir, Teddy !",
			"Où est ma petite Bo ?",
			"Oh, vraiment ?",
			"J'ai bien peur que tu te sois fait avoir par Dicky...",
			"Alors... Tu vas me sortir de ce machin ou bien ?",
			"Héhéhéhé...... Bien joué !"
		};
		oldWomanPorchChoice1 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Bien entendu !"
		};
		oldWomanPorchChoice2 = new string[8]
		{
			string.Empty,
			"Oui ?",
			string.Empty,
			"Dicky a dit qu'elle était ici...",
			string.Empty,
			"Oh...",
			"Non merci, pet de pigeon.",
			string.Empty
		};
		dogBirdyCommentNice = new string[10]
		{
			"Je suppose que tu l'as fait exprès ?",
			"Quoi qu'il en soit, tu l'as sûrement tuée...",
			"Au moins, tu as été sympa avec elle avant qu'elle ne meure...",
			"C'était vraiment une gentille vieille dame.",
			"......... Euh........",
			"À Miss Birdy...",
			"Que son âme voltige... à jamais...",
			"Dans les cieux...",
			"Et jusqu'au paradis...",
			"Amen..."
		};
		dogBirdyCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"En effet..."
		};
		dogBirdyCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Dis quelques mots, George."
		};
		dogBirdyCommentMean = new string[6]
		{
			"Mec... Tu l'as tuée !",
			"D'abord, tu la traites de pet de pigeon, et maintenant ça ?!",
			"Ouais... Enfin, ne le prends pas mal mais...",
			"Elle sentait vraiment le pet de pigeon...",
			"Mais on s'en moque !",
			"Tu l'as tuée !"
		};
		dogBirdyCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			"Désolé...",
			string.Empty,
			string.Empty
		};
		dogBirdyCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			"Elle sentait le pet.",
			string.Empty,
			"Ouais..."
		};
		dogBarCommentMean = new string[6]
		{
			"Bon sang, tu as vraiment énervé ce type...",
			"À partir de maintenant... Fonds-toi dans la masse...",
			"Tu n'as pas envie de te faire assommer dans un moment pareil, n'est-ce pas ?",
			"Tu es branché et tendance, Ted...",
			"Mais tes bras sont...",
			"... squelettiques..."
		};
		dogBarCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Je pense que tu as raison...",
			string.Empty
		};
		dogBarCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Je peux me les faire !",
			string.Empty
		};
		dogBarCommentNice = new string[4]
		{
			"Euh... Tu es sérieux ?",
			"Tu comptes vraiment faire la fête avec tout le monde, dans un moment pareil ?",
			"Mais Ted... Et Bo... ?",
			"Ouais, ça craint, mec..."
		};
		dogBarCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			"Bien sûr que non !",
			string.Empty,
			string.Empty
		};
		dogBarCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			"Évidemment !",
			"Ouais...",
			string.Empty
		};
		floatingPeople = new string[18]
		{
			"Hohahahehehe... Oh Teddy, c'était de la folie !",
			"Mais Dicky a quelque chose à te dire. N'est-ce pas, Dicky ?",
			"Aaargh... J'ai menti... Mais je voulais qu'on m'aide à retrouver ma petite Birdy...",
			"Pinstripe vit à Red Wash...",
			"... Un lac situé au fin fond des entrailles de l'enfer.",
			"J'ai bien peur qu'il n'ait enfermé ta chère petite Bo dans son affreux presbytère...",
			"Si tu t'y rends, il te faudra de la lumière...",
			"... Voyons voir si je l'ai toujours...",
			"... Ah, oui, le voilà...",
			"Un soir, j'ai joué avec Bo et ses jouets, et elle m'a donné cet étrange morceau de papier...",
			"Je me demande si cela pourrait t'aider à trouver de la lumière...",
			"Si tu l'oublies, tu peux toujours consulter l'indice plus tard...",
			"Tu vois l'ICÔNE INDICE qui clignote en bas de l'écran ?",
			"C'est ici que tu peux consulter tous les INDICES que tu as trouvés lors de ton périple...",
			"Étudie-les minutieusement...",
			"Bref...",
			"On se reverra à Red Wash...",
			"Nous allons retrouver Bo, mon poussin..."
		};
		floatingPeopleChoice1 = new string[14]
		{
			string.Empty,
			"Ça va, Dicky...",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		floatingPeopleChoice2 = new string[18]
		{
			"Ouais.",
			"On t'écoute, pourriture...",
			"Mais où est Bo ?",
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Merci.",
			string.Empty,
			"Oui.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK."
		};
		dogHintChest = new string[5]
		{
			"Ted ! Tu te souviens du coffre à jouets dans l'arbre, à Edge Wood ?",
			"Ça a peut-être un lien avec les indices de Miss Birdy pour trouver la lumière...",
			"La lumière dont tu as besoin pour aller à Red Wash...",
			"Regarde bien tous les indices, mec...",
			"Tu vois l'icône des indices qui clignote en bas à gauche de l'écran ?"
		};
		dogHintChestChoice1 = new string[3]
		{
			string.Empty,
			"OK.",
			string.Empty
		};
		dogHintChestChoice2 = new string[3]
		{
			string.Empty,
			"Quelle lumière ?",
			string.Empty
		};
		telephone = new string[3]
		{
			"............. Papa...",
			"C'est toi ?",
			"............................................. Aide-moi, papa !"
		};
		pinstripeManBoss = new string[3]
		{
			"SALE POURRITURE !",
			"Tu as perturbé notre union si parfaite et précieuse !",
			"Il est l'heure de rôtir, MON PETIT TEDDY !"
		};
		houseLockedGold = new string[1]
		{
			"La porte est fermée par un cadenas en or..."
		};
		houseLockedMechanism = new string[1]
		{
			"La porte est fermée par un espèce de mécanisme..."
		};
		houseLockedMechanismChoice1 = new string[1]
		{
			string.Empty
		};
		houseLockedMechanismChoice2 = new string[1]
		{
			"Examiner."
		};
		houseLockedSilver = new string[1]
		{
			"La porte est fermée par un cadenas en argent..."
		};
		houseLocked2 = new string[1]
		{
			"La porte est fermée..."
		};
		sign1 = new string[2]
		{
			"Haut : Hangly Pass",
			"Bas : Red Wash"
		};
		sign2 = new string[1]
		{
			"Direction Red Wash..."
		};
		signPissward = new string[2]
		{
			"« Direction Red Wash... »",
			"« Achetez des tickets à Happy. »"
		};
		signBalloonShop = new string[4]
		{
			"« Il est formellement interdit de manger mes champivites. »",
			"« Ils peuvent avoir des effets indésirables tels que la nausée, la diarrhée, les pensées suicidaires... »",
			"« Ou une amélioration +1 de la VT (vitesse de tir) du joueur... »",
			"« Alors abstenez-vous d'y toucher ! — Boutique de ballons de Princle »"
		};
		liftPower = new string[3]
		{
			"Une roue à aubes ou quelque chose dans le genre...",
			"Elle doit servir à alimenter le téléphérique...",
			"Mais... Où est l'eau ?"
		};
		signPissward2 = new string[2]
		{
			"On dirait un conduit pour le gaz...",
			"« Le conduit s'étend jusqu'à Edge Wood, Hangly Pass, Sack Chute, Pissward Falls et Red Wash... »"
		};
		signPissward2Choice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signPissward2Choice2 = new string[2]
		{
			string.Empty,
			"Examiner."
		};
		signHappySafe = new string[2]
		{
			"Un coffre géant ?",
			"« N'y pense même pas, imbécile. — Happy »"
		};
		signHappySafeChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signHappySafeChoice2 = new string[2]
		{
			string.Empty,
			"Examiner."
		};
		signTimsShop = new string[2]
		{
			"Un message gribouillé...",
			"« J'essaye de dormir. Je serai debout à 20 h 10... »"
		};
		signTimsShopChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signTimsShopChoice2 = new string[2]
		{
			"Examiner.",
			string.Empty
		};
		pisswardMan1 = new string[13]
		{
			"Bonjour, mon père...",
			"Bienvenue à Pissward Falls, résidence de Pissy le serpent pisseux...",
			"Les tickets du téléphérique pour Red Wash coûtent 300 gouttes glacées...",
			"Merci, mon père...",
			"Ahhhh.... Super....",
			".............. Oooh.... C'est super..... Oooh ouah.......",
			"Je vais amener ces gouttes à Red Wash pour essayer de dormir...",
			"Je n'ai pas dormi depuis...",
			"Ça fait combien de temps ?",
			"Je ne m'en souviens même plus...",
			"... Rien de tel que croquer ces gouttes glacées et se laisser aller dans le pays des rêves...",
			"Que Pinstripe soit béni. Que sa bonne âme soit bénie...",
			"Voici le ticket de téléphérique, mon père..."
		};
		pisswardMan1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Non, merci."
		};
		pisswardMan1Choice2 = new string[3]
		{
			"Bonjour.",
			string.Empty,
			"Acheter un ticket (300)."
		};
		happyEdgeWood = new string[14]
		{
			"Bonjour, mon père...",
			"C'est moi, Happy...",
			"Oh, tu me connais, Ted !",
			"Tu es un ami de Bo ?",
			"Enfin bref. Tu as l'air particulièrement anxieux et tout transpirant...",
			"J'aimerais te servir un verre, mon ami, mais pour ça tu devras aller jusqu'à Red Wash...",
			"Mais je pourrais te vendre quelque chose de bien plus intéressant si tu es prêt à mettre le prix...",
			"Tu devrais acheter ce pistolet-mitrailleur illégal pour 1 000 gouttes glacées...",
			"Merci, mon père...",
			"Di bonjour à M. Thompson...",
			"Avec un pistolet comme ça, tu seras irrésistible..",
			"J'aurais aimé avoir un appareil photo et prendre une petite photo pour ma maman...",
			"Bref... T peux maintenant aller sauver ta petite chérie comme un vrai bandit transpirant...",
			"Allez, capt'aine..."
		};
		happyEdgeWoodChoice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Non, merci."
		};
		happyEdgeWoodChoice2 = new string[8]
		{
			"On se connaît ?",
			"Qui ?",
			string.Empty,
			"Non.",
			"Quoi ?",
			string.Empty,
			string.Empty,
			"Acheter (1 000)."
		};
		happyHangly = new string[13]
		{
			"Bonjour, mon père...",
			"J'ai quelques objets à vendre si tu es prêt à y mettre le prix...",
			"D'ailleurs, ton p'tit chiot se gèle les pattes...",
			"Regarde comme il tremble de froid !",
			"Tu devrais lui acheter ce pull de chiot à 400 gouttes glacées...",
			"Merci, mon père...",
			"Quelle beauté ! Ses jolies p'tites fesses sont bien au chaud...",
			"Ce pull ici présent a été tricoté par les longues extrémités de ma mère...",
			"J'te parie que ses fesses commencent déjà bien à se réchauffer et à suer...",
			"... d'une minute à l'autre...",
			"Au fait, merci pour les gouttes glacées...",
			"Si tu as besoin de quoi que ce soit d'autre, cherche l'enseigne de barbier...",
			"Elle est jaune et elle tourne."
		};
		happyHanglyChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Non, merci."
		};
		happyHanglyChoice2 = new string[5]
		{
			"Bonjour.",
			string.Empty,
			string.Empty,
			string.Empty,
			"Acheter (400)."
		};
		happyCave = new string[10]
		{
			"Bonjour, mon père...",
			"Alors, que penses-tu de ce système de grotte ?",
			"Eh bien, c'est une sacrée exploitation...",
			"Il fait encore sacrément froid...",
			"Je pensais vraiment qu'il ferait plus chaud sous terre... J'en aurais mis la main de ma mère à couper...",
			"D'ailleurs, M. Pinstripe m'a donné un costume supplémentaire...",
			"Je vais essayer de... euh... le retrouver...",
			"Bien. Là, le voilà... Je peux vous vendre son costume de rechange pour 500 gouttes glacées...",
			"Merci, mon père...",
			"........ T'es son portrait tout craché, Ted.......... !"
		};
		happyCaveChoice1 = new string[8]
		{
			string.Empty,
			"Super.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Non, merci."
		};
		happyCaveChoice2 = new string[8]
		{
			"Bonjour, Happy.",
			"Rien de transcendant.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Acheter (500)."
		};
		timRedWash1 = new string[11]
		{
			"Bonjour, mon père...",
			"Au sujet de ces gouttes glacées que tu m'as données à Pissward...",
			"Eh bien... Cela n'a pas suffi à m'endormir, comme je l'espérais...",
			"Bon, écoute. Je peux t'aider à sauver Bo des griffes de Pinstripe... mais j'ai besoin que tu me rendes un service...",
			"Si tu me ramènes 10 sacs... Pas des gouttes glacées, des sacs bien frais... les vrais de vrais...",
			"Je te vendrai un journal... mais pas n'importe lequel...",
			"Il contient le mot de passe du presbytère de Pinstripe...",
			"Alors, qu'en dis-tu ? Ces sacs sont la seule chose qui m'aideront à dormir ce soir...",
			"Pinstripe livrera ces sacs à un moment précis, mon père...",
			"Pour le savoir, voici un indice...",
			"Une fois les sacs trouvés, ramène-les ici pour que je n'en fasse qu'une bouchée..."
		};
		timRedWash1Choice1 = new string[18]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash1Choice2 = new string[10]
		{
			"Bonjour, Happy.",
			"Oui ?",
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Bien sûr !",
			string.Empty,
			"OK !"
		};
		timRedWash2 = new string[10]
		{
			"Bonjour, mon père...",
			"Tu veux acheter un journal pour 10 sacs... ?",
			"Il t'aidera à atteindre le presbytère de Pinstripe...",
			"Merci...",
			"Il se fait tard...",
			"Je compte fermer la boutique et faire un petit somme...",
			"Rien de tel qu'une bonne sieste, confortablement installé dans ma boutique, en pleine tempête...",
			"C'est de la folie... Qu'as-tu fait, mon père ?",
			"Bref... Le mot de passe devrait se trouver dans ce journal...",
			"...................... Bonne nuit, mon père..."
		};
		timRedWash2Choice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			"Pas encore.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash2Choice2 = new string[10]
		{
			"Bonjour, Happy.",
			string.Empty,
			"Acheter (10 sacs).",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapArea = new string[4]
		{
			"Le lance-pierre de Bo...",
			"Il est gravé dans le bois « Joyeux anniversaire Bo »...",
			"Clique ou appuie sur la gâchette pour lâcher.",
			"Tu peux casser des objets comme cette boîte..."
		};
		blunderBustTapAreaChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapAreaChoice2 = new string[5]
		{
			"Examiner.",
			string.Empty,
			string.Empty,
			"Prendre.",
			string.Empty
		};
		whiskey = new string[1]
		{
			"Une bouteille de whisky..."
		};
		whiskeyChoice1 = new string[1]
		{
			string.Empty
		};
		whiskeyChoice2 = new string[1]
		{
			"Prendre."
		};
		dan = new string[10]
		{
			"Bénie soit cette soirée...",
			"Bienvenue à Red Wash...",
			"Le lieu du plaisir ultime de Pinstripe.",
			"Inscris-toi sur le registre des invités...",
			"Hmmmm... Quelle jolie signature...",
			"C'est une soirée très spéciale...",
			"La cérémonie aura lieu à la pleine lune...",
			"Ce n'est pas tous les jours que Pinstripe trouve un enfant bien en chair...",
			"Alors, M. Pinstripe a demandé à ce que tous les habitants y assistent...",
			"L'adoption éternelle de l'enfant..."
		};
		danChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Merci.",
			string.Empty,
			string.Empty,
			string.Empty
		};
		danChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Quelle cérémonie ?"
		};
		dan2 = new string[7]
		{
			"La cérémonie...",
			"La cérémonie me donne des frissons dans le dos...",
			"Et me donne envie de boire du lait.",
			"Tu ne comprends pas quoi ?",
			"Tu ne connais pas les bienfaits d'un bon verre de lait chaud ?",
			"Du lait, du lait chaud et une cérémonie d'adoption comme je n'en ai jamais vue avant...",
			"Mais bien sûr, tu ne comprends pas..."
		};
		dan2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"OK."
		};
		dan2Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Je ne comprends pas..."
		};
		dan22 = new string[1]
		{
			"Daniel veut du lait."
		};
		dan22Choice1 = new string[1]
		{
			string.Empty
		};
		dan22Choice2 = new string[1]
		{
			"OK."
		};
		dan23 = new string[1]
		{
			"Du lait chaud pour une adoption."
		};
		dan23Choice1 = new string[1]
		{
			string.Empty
		};
		dan23Choice2 = new string[1]
		{
			"OK."
		};
		dan24 = new string[1]
		{
			"J'aimerais sentir une vague de lait dans ma bouche."
		};
		dan24Choice1 = new string[1]
		{
			string.Empty
		};
		dan24Choice2 = new string[1]
		{
			"OK."
		};
		dan25 = new string[1]
		{
			"Imagine-toi une piscine de lait dans ta bouche."
		};
		dan25Choice1 = new string[1]
		{
			string.Empty
		};
		dan25Choice2 = new string[1]
		{
			"OK."
		};
		dan26 = new string[1]
		{
			"Du lait."
		};
		dan26Choice1 = new string[1]
		{
			string.Empty
		};
		dan26Choice2 = new string[1]
		{
			"OK."
		};
		dan27 = new string[1]
		{
			"..............................................................."
		};
		dan27Choice1 = new string[1]
		{
			string.Empty
		};
		dan27Choice2 = new string[1]
		{
			"Hm ?"
		};
		kitty2 = new string[4]
		{
			"Oh, bon sang...",
			"Ta petite fille est une battante...",
			"Mais ne t'en fais pas, Ted...",
			"Bientôt, elle m'appellera « père »..."
		};
		kitty4 = new string[1]
		{
			"........."
		};
		signMegaGem = new string[7]
		{
			"................................ Une énorme goutte glacée noire...",
			"« Scoria Sackus de Moonstate : la plus grosse goutte glacée officielle de Pinstripe... »",
			"« Trouvée dans un puits de Red Wash de 323 mètres de profondeur, dans l'épiderme d'un sac fossilisé. »",
			"« Valeur : 50 gouttes glacées. »",
			"Ça sent la laque fraîche...",
			"Ça sent vraiment bon, en fait...",
			"Chante-moi une chanson pour que je m'endorme, Ada..."
		};
		signMegaGemChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"OK."
		};
		signMegaGemChoice2 = new string[4]
		{
			"Lire.",
			string.Empty,
			string.Empty,
			"Sentir."
		};
		balloonMan1 = new string[11]
		{
			"Aaaaaargh... Je ne t'ai jamais dit que tu avais le droit de te balader par ici...",
			"Mais, tu sais, je suis content que tu l'aies fait. Parce que maintenant, je peux me vanter de mes machines à ballons...",
			"Ici, les enfants m'appellent Princle, et mes machines à ballons ont fait de moi le meilleur créateur de ballons de la ville...",
			"Pinstripe m'a commandé un bon paquet de ballons et je dois répondre à sa demande comme un vrai prince...",
			"Ouais... genre en dix secondes...",
			"Hmmmm... Je parie mon énorme goutte glacée que l'agilité et la rapidité de mes machines sont inégalables...",
			"Tu as bien trop d'assurance, mon ami !",
			"Prépare-toi à te faire ratatiner la tête !",
			"Prêt...",
			"Feu...",
			"PARTEZ !"
		};
		balloonMan1Choice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		balloonMan1Choice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Je prends les paris !"
		};
		balloonMan2 = new string[6]
		{
			"QUEL NASE !",
			"Tu veux encore jouer, mon père ?",
			"Prépare-toi à te faire passer un super savon !",
			"Prêt...",
			"Feu follet...",
			"PÉTEZ !"
		};
		balloonMan2Choice1 = new string[2]
		{
			string.Empty,
			"Non, merci."
		};
		balloonMan2Choice2 = new string[2]
		{
			string.Empty,
			"C'est parti !"
		};
		balloonMan2b = new string[6]
		{
			"OH CAPITAINE, MON CAPITAINE !",
			"Tu veux encore jouer, capitaine ?",
			"J'ai hâte de voir de quoi tu es capaaaaaable !",
			"Prêt...",
			"Feu follet...",
			"PÉTEZ !"
		};
		balloonMan2bChoice1 = new string[2]
		{
			string.Empty,
			"Non, merci."
		};
		balloonMan2bChoice2 = new string[2]
		{
			string.Empty,
			"C'est parti !"
		};
		balloonMan3 = new string[5]
		{
			"QUOIIIIIIII ?????!!!!",
			"Tu es... Tu es...",
			"Tu es ÉPATANT ! Les compétences requises pour éliminer mes machines à ballons sont...",
			"Sans précédent ! Ça n'a pas de prix...",
			"Prends la récompense, mon père... Allez... prends-la..."
		};
		balloonMan3Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"C'est trop aimable !"
		};
		balloonMan3Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Euh... Sans blague..."
		};
		savePortraitGronkh = new string[2]
		{
			"Un autre portrait... d'un homme violent.",
			".................................................. Partie sauvegardée."
		};
		savePortraitGronkhChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkhChoice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		savePortraitGronkh2 = new string[2]
		{
			"Le portrait est toujours aussi violent.",
			".................................................. Partie sauvegardée."
		};
		savePortraitGronkh2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh2Choice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		savePortraitGronkh3 = new string[2]
		{
			"Il y a tellement de violence ! Sa violence se ressent même sur la toile !",
			".................................................. Partie sauvegardée."
		};
		savePortraitGronkh3Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh3Choice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		savePortraitGronkh4 = new string[2]
		{
			"La toile est d'une violence rare. Principalement à cause de l'homme violent...",
			".................................................. Partie sauvegardée."
		};
		savePortraitGronkh4Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh4Choice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		savePortraitDirk = new string[2]
		{
			"Le portrait d'un homme bien peigné...",
			".................................................. Partie sauvegardée."
		};
		savePortraitDirkChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitDirkChoice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		savePortraitRMannion = new string[2]
		{
			"Le portrait d'un homme du genre artiste et branché...",
			".................................................. Partie sauvegardée."
		};
		savePortraitRMannionChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitRMannionChoice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		savePortraitJHandville = new string[2]
		{
			"Le portrait d'une jolie moustache qui porte un visage d'homme...",
			".................................................. Partie sauvegardée."
		};
		savePortraitJHandvilleChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitJHandvilleChoice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		savePortraitNathanKingston = new string[2]
		{
			"Le portrait d'un homme ressemblant à Jésus mais qui s'appelle Nathan, pas Jésus...",
			".................................................. Partie sauvegardée."
		};
		savePortraitNathanKingstonChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitNathanKingstonChoice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		savePortraitOchoma = new string[2]
		{
			"Un portrait froid et triste...",
			".................................................. Partie sauvegardée."
		};
		savePortraitOchomaChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitOchomaChoice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		savePortraitBuddy = new string[2]
		{
			"Le portrait d'un homme étrange...",
			".................................................. Partie sauvegardée."
		};
		savePortraitBuddyChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddyChoice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		savePortraitBuddy2 = new string[2]
		{
			"Encore l'étrange portrait d'un homme... Il est chauve et moustachu...",
			".................................................. Partie sauvegardée."
		};
		savePortraitBuddy2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddy2Choice2 = new string[1]
		{
			"Sauvegarder la partie."
		};
		creepyMan = new string[2]
		{
			"....... Il devrait déjà être là...... n'est-ce pas ?",
			"Il devrait arriver avec plus de fruits..."
		};
		creepyMan2 = new string[2]
		{
			"Une baignoire ?",
			"Ted... Je crois qu'il y a quelque chose là-dedans..."
		};
		creepyMan3 = new string[5]
		{
			"Ce vieil homme et cette gentille dame sont passés il y a une minute...",
			"Ils ont dit que tu allais anéantir Pinstripe...",
			"Ne le fais pas !",
			"C'est grâce à lui que je vis comme un prince ici...",
			"Il devrait arriver d'une minute à l'autre... n'est-ce pas ? Pour me donner plus de sacs..."
		};
		jack = new string[8]
		{
			"......argh....................... Mon père ?",
			"......ergh....................... À l'aide !",
			"Ce démon me dévore !",
			"Je ne te dévore pas......... Je te conduis seulement à Red Wash.",
			"Ne t'inquiète pas ma puce... On s'amuse bien là-bas... Le jus de sac visqueux coule à flots...",
			"Oh... vraiment... ?",
			"Mmmh... Alors d'accord !",
			"Dépêche-toi ! On n'a pas toute la journée !"
		};
		jackChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		jackChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkard = new string[9]
		{
			"Tu vas faire une grande fête après la cérémonie, mon père ?",
			"Tiens, prends une petite gorgée de jus de sac de M. Pinstripe pour te mettre en condition... ",
			"Ooooh... Miam....",
			"C'est bon, c'est vrai... mais pas autant que les vrais de vrais...",
			"Pinstripe va distribuer des sacs frais remplis de ce truc lors de la cérémonie...",
			"Tu vas croquer un bout du fruit défendu avec nous, pas vrai, mon père ?",
			"Et si je te faisait ravaler tes paroles ?",
			"Il n'y a rien de pire que de se sentir jugé...",
			"Surtout venant d'un individu aussi pathétique que toi..."
		};
		drunkardChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Bien sûr, j'adore faire la fête !",
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkardChoice2 = new string[6]
		{
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			"Non merci, pochetron."
		};
		dickyBar = new string[11]
		{
			"... Pssst...",
			"Ted... C'est moi...",
			"C'est moi, M. Dicky...",
			"Fais attention là-bas...",
			"Si Pinstripe me trouve, il me tuera...",
			"Surtout s'il nous attrape en train de t'aider à retrouver Bo...",
			"Je suis déguisé...",
			".... Je suis un clown, Ted...",
			"Tu vois ce nez ?",
			"Elle se cache dans le puits de Pinstripe...",
			"Elle a dit qu'elle avait une surprise pour toi..."
		};
		dickyBarChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Ouais.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarChoice2 = new string[22]
		{
			"Hé.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Où est Miss Birdy ?",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2 = new string[6]
		{
			"Quoi ?",
			"Tu fixes mes grains de beauté, n'est-ce pas ?",
			"Arrête ça ! Arrête ça !",
			"Je ne suis pas un clow...",
			"...................",
			"Laisse-moi tranquille !"
		};
		dickyBar2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarNight = new string[6]
		{
			"Qu'as-tu fait, Ted ?",
			"Mes os me font souffrir...",
			"Je crois...",
			"Ted...",
			"Je suis désolé, c'est terminé...",
			"J'ai dit, c'est terminé."
		};
		dickyBarNightChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK."
		};
		dickyBarNightChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Quoi ?"
		};
		birdyBarrel = new string[9]
		{
			"Chuuuuut... Héhéhéhé...",
			"Mon Teddy...",
			"C'est encore moi...",
			"C'était rapide ! Prends cette véritable cuillère...",
			"J'aime beaucoup son éclat et son odeur...",
			"Et elle est très agréable au toucher, sois-en certain !",
			"Tu en auras besoin pour éliminer Pinstripe et sauver ta petite Bo...",
			"Mais ne dis à personne où je suis...",
			"Je ne veux pas que Pinstripe m'enferme encore dans une cage..."
		};
		birdyBarrelChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Mais tu as raison !"
		};
		birdyBarrelChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Ça alors, merci...",
			string.Empty,
			"Ce que tu dis est stupide..."
		};
		tokenInvite1 = new string[1]
		{
			"Un morceau de papier..."
		};
		tokenInvite1Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite1Choice2 = new string[1]
		{
			"Prendre."
		};
		tokenInvite2 = new string[1]
		{
			"Un morceau de papier..."
		};
		tokenInvite2Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite2Choice2 = new string[1]
		{
			"Prendre."
		};
		tokenFilmStrip = new string[1]
		{
			"Un bout de pellicule secret..."
		};
		tokenFilmStripChoice1 = new string[1]
		{
			string.Empty
		};
		tokenFilmStripChoice2 = new string[1]
		{
			"Prendre."
		};
		tokenBible = new string[1]
		{
			"Une vieille bible..."
		};
		tokenBibleChoice1 = new string[1]
		{
			string.Empty
		};
		tokenBibleChoice2 = new string[1]
		{
			"Prendre."
		};
		tokenNotebook = new string[3]
		{
			"Comment est-ce arrivé ici... ?",
			"Ne regarde pas, papa...",
			"Ce n'est qu'un dessin idiot..."
		};
		tokenNotebookChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		tokenNotebookChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Examiner."
		};
		tokenPills = new string[1]
		{
			"Un flacon de médicament vide..."
		};
		tokenPillsChoice1 = new string[1]
		{
			string.Empty
		};
		tokenPillsChoice2 = new string[1]
		{
			"Prendre."
		};
		tokenNewspaper = new string[1]
		{
			"Un journal..."
		};
		tokenNewspaperChoice1 = new string[1]
		{
			string.Empty
		};
		tokenNewspaperChoice2 = new string[1]
		{
			"Prendre."
		};
		tokenLocket = new string[3]
		{
			"Pourquoi est-ce que toutes tes affaires sont jetées là, papa ?",
			"Et est-ce que...",
			"... Est-ce que c'est le médaillon de maman ?"
		};
		tokenLocketChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		tokenLocketChoice2 = new string[3]
		{
			"Je n'en suis pas sûr...",
			string.Empty,
			"Examiner."
		};
		blackAndWhiteModeTalk = new string[4]
		{
			"C'est pas vrai, tu joues encore à ce jeu ?",
			"Ce jeu est nul...",
			"Bref, est-ce que tu préfères jouer au mode super vintage pour 5 bouts de pellicule ?",
			"Félicitations. Tu viens de dépenser 5 bouts de pellicule pour retirer toutes les somptueuses couleurs du jeu..."
		};
		blackAndWhiteModeTalkChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Non.",
			string.Empty
		};
		blackAndWhiteModeTalkChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Oui (5 bouts de pellicule).",
			string.Empty
		};
		sackGeneratorExamine = new string[4]
		{
			"Ça ressemble à ces espèces de sacs que nous avons donnés à l'arbre à Edge Wood... mais en géant !",
			"On dirait qu'il dort...",
			"Et qu'il sent les œufs...",
			"Bien..."
		};
		sackGeneratorExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGeneratorExamineChoice2 = new string[1]
		{
			"Examiner."
		};
		sackGenerator2Examine = new string[4]
		{
			"Encore un de ces générateurs de sacs...",
			"Houlà...",
			"Regarde-moi ces dents !",
			"Argh ! Et son haleine sent vraiment le lait..."
		};
		sackGenerator2ExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGenerator2ExamineChoice2 = new string[1]
		{
			"Examiner."
		};
		sackGenerator3Examine = new string[5]
		{
			"Encore un autre...",
			"Peut-être que celui-ci fermente le jus de sac ou je ne sais quoi...",
			"Je ne sais pas...",
			"Mais celui-ci sent.................................................... le caca.",
			"Ouais... désolé, mais c'est comme ça..."
		};
		sackGenerator3ExamineChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Tu es drôle, George..."
		};
		sackGenerator3ExamineChoice2 = new string[5]
		{
			"Examiner.",
			string.Empty,
			string.Empty,
			"Tais-toi...",
			string.Empty
		};
		characterSucked = new string[1]
		{
			"............."
		};
		characterSuckedFelix = new string[2]
		{
			"Ted...",
			"J'ai quelque chose sur la tête ?"
		};
		explainFire = new string[8]
		{
			"Salut, pisseux...",
			"Ne me juge pas...",
			"Je me suis bien comporté, je le jure... J'avais simplement soif...",
			"Rien de tel qu'une bonne lampée de jus de sac de Pinstripe...",
			"Avec ça, je me sens vraiment spécial...",
			"Il a dit que le meilleur était à venir avec la cérémonie d'adoption de Bo...",
			"Qu'est-ce que ça peut te faire, voyou ?",
			"Tu ne sais même pas arrêter une voiture..."
		};
		explainFireChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		explainFireChoice2 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Quand aura lieu l'adoption ?",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		redWashNotice = new string[7]
		{
			"Un avertissement...",
			"« Les habitants de Red Wash qui assistent à l'adoption de Bo... »",
			"« ... se verront offrir la livraison de sacs de Pinstripe... » ?",
			"« Les habitants qui n'y assisteront pas... »",
			"« seront abusés verbalement et............ fortement fouettés jusqu'à ce qu'ils se soumettent... » ?",
			"« Merci et bonne journée ! »",
			"........ Super........"
		};
		redWashNoticeChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"C'est affreux..."
		};
		redWashNoticeChoice2 = new string[6]
		{
			"Lire.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Ça ressemble à une fête."
		};
		potBellyMan = new string[7]
		{
			"Chuuuuut... Héhéhéhé...",
			"Tu... T'entends ça, mon père ?",
			"C'est l'énorme horloge de Pinstripe...",
			"On m'a ordonné de ne laisser personne toucher l'énorme horloge...",
			"Personne ne doit toucher à cette satanée horloge...",
			"... et sous aucun prétexte !",
			"Tu comprends................... n'est-ce pas, l'ami ?"
		};
		potBellyManChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"J'ai compris !"
		};
		potBellyManChoice2 = new string[4]
		{
			string.Empty,
			"Quoi ?",
			string.Empty,
			"Je ne vais pas faire que la toucher..."
		};
		potBellyMan2 = new string[6]
		{
			"..................",
			"Tu as touché l'énorme horloge ?",
			"N'AS-TU DONC PAS COMPRIS LES RÈGLES ?",
			"Pas encore ! Pas encore !",
			"M. Pinstripe va me piétiner...",
			"................................ Encore !"
		};
		potBellyMan2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Hm... Salut..."
		};
		potBellyMan2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Qu'est-ce qui ne va pas ?"
		};
		potBellyMan22 = new string[3]
		{
			"............... Aaargh...",
			"Je veux dire...",
			"C'est une chose de se faire piétiner... Mais j'espère qu'il me donnera quand même mon sac..."
		};
		potBellyMan22Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		potBellyMan22Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Ouah.",
			string.Empty
		};
		fork = new string[3]
		{
			"Une fourchette.",
			"Elle est un peu rouillée et sent le moisi...",
			"Vaporisée de.......................................... lotion ?"
		};
		forkChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		forkChoice2 = new string[3]
		{
			"Examiner.",
			string.Empty,
			"Prendre."
		};
		boHeaven1 = new string[3]
		{
			"Papa !",
			"Tu m'as manqué !",
			"Tu veux aller jouer dehors ?"
		};
		boHeaven1Choice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boHeaven1Choice2 = new string[3]
		{
			"Bo !",
			"Toi aussi tu m'as manqué !",
			"Oui !"
		};
		boHeaven2 = new string[2]
		{
			"Papa !",
			"On dirait le collier papillon de maman !"
		};
		boHeaven2Choice1 = new string[1]
		{
			string.Empty
		};
		boHeaven2Choice2 = new string[1]
		{
			"Ah oui ?"
		};
		boHeavenGeorge = new string[1]
		{
			"Oh.............. J'aimerais que Georgie soit là..."
		};
		boHeavenGeorgeChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenGeorgeChoice2 = new string[1]
		{
			"..."
		};
		boHeavenButterflies = new string[3]
		{
			"Ouah ! Regarde, papa !",
			"J'aurais aimé que maman voit ça. Elle adorait les papillons...",
			"Hé ! Je parie que tu peux pas tous les attraper !"
		};
		boHeavenButterfliesChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenButterfliesChoice2 = new string[2]
		{
			string.Empty,
			"Oui..."
		};
		secretRoomCaveSign = new string[8]
		{
			"Un bloc de pierre...",
			"« La chambre de l'archevêque : »",
			"« En l'honneur de l'élection de l'archevêque. »",
			"« Telle la foudre... »",
			"« Et en un battement de cils, l'élite a procuré de l'énergie... »",
			"« Pour aviver et étendre le monde de Pinstripe. »",
			"« Profitez des gouttes pourpres de Magnus, évaluées à 200 gouttes chacune. »",
			"« (Et elles sentent comme Glen.) »"
		};
		secretRoomCaveSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomCaveSignChoice2 = new string[1]
		{
			"Examiner."
		};
		secretRoomTreeSign = new string[7]
		{
			"« Un bloc de pierre... »",
			"« Le jardin de l'archevêque : »",
			"« En l'honneur de l'élection de l'archevêque. »",
			"« Les présents sincères et modestes offerts par l'élite... »",
			"« Une graine en or révèle une magnifique épine... »",
			"« Prenez des gouttes de citronnier de Statton, évaluées à 100 gouttes chacune. »",
			"« (Et elles sentent comme les crèmes solaires au citron fraîchement pressé.) »"
		};
		secretRoomTreeSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomTreeSignChoice2 = new string[1]
		{
			"Examiner."
		};
	}
	else if (@string == "Chinese")
	{
		Debug.Log("Chinese");
		trainDoorButton1 = new string[1]
		{
			"有个按钮……"
		};
		wifeIntro = new string[2]
		{
			"泰迪……",
			"我有事要告诉你……"
		};
		bo1 = new string[6]
		{
			"醒醒，爸比！",
			"你又在梦游啦……",
			"嘿！你有闻到一股烟味吗？",
			"我们去调查一下吧！",
			"你能化身为夏洛克……",
			"你好傻啊！"
		};
		bo1Choice1 = new string[5]
		{
			string.Empty,
			"对不起，宝贝。",
			string.Empty,
			string.Empty,
			"哦。"
		};
		bo1Choice2 = new string[5]
		{
			"呃啊……什么？",
			"我才没梦游。",
			"闻到了。",
			string.Empty,
			"是啊，华生！"
		};
		trainDoorButtonBo = new string[2]
		{
			"夏洛克！",
			"我觉得我能够到那个按妞！"
		};
		trainDoorButtonBoChoice1 = new string[3]
		{
			"华生？",
			string.Empty,
			string.Empty
		};
		trainDoorButtonBoChoice2 = new string[2]
		{
			string.Empty,
			"好……你待在那！"
		};
		lockedTrainDoor = new string[1]
		{
			"锁住了……"
		};
		sackSpitExplainer = new string[3]
		{
			"那是什么，爸比？",
			"看上去像是一滴被冻住的……",
			"油？"
		};
		mirror = new string[7]
		{
			"这是镜子，夏洛克！",
			"它上面有好多灰尘，我都快看不清你的脸了。",
			"好~吓~人~啊……",
			"嘿！快看我们，爸比，我们看上去像搞笑鬼……",
			"砰！",
			"噢，没错……",
			"凶卟！"
		};
		mirrorChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"我们走吧。"
		};
		mirrorChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"是“卟”，宝贝。"
		};
		mirror2 = new string[6]
		{
			"魔镜，魔镜，在火车上……",
			"告诉我我是最美的公主……",
			"………………………………………………………………",
			"………………………………………………………………",
			"什么词跟火车（Train）押韵，爸比？",
			"告诉我我是最美的污点公主！"
		};
		mirror2Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"我们走吧。"
		};
		mirror2Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"污点（Stain）"
		};
		boTrainBar = new string[5]
		{
			"爸比，我们能离开这里吗？",
			"这里闻起来像便便……",
			"对不起……",
			"这里闻起来像……",
			"粪便……"
		};
		boTrainBarChoice1 = new string[4]
		{
			string.Empty,
			"好啊。",
			string.Empty,
			string.Empty
		};
		boTrainBarChoice2 = new string[5]
		{
			string.Empty,
			"注意你的言辞！",
			string.Empty,
			string.Empty,
			"小博！！"
		};
		boJumpingBean = new string[8]
		{
			"你看上去像跳豆，夏洛克。",
			"“跳啊，跳啊，小跳豆，他很宽厚，身材特瘦。”",
			"“跳来，跳去，唔，唔，唔。”",
			"“他是，跳豆，嘟，嘟，嘟。”",
			"我好喜欢这段表演。",
			"那表演太蠢了……",
			"我都不知道你喜欢那表演，夏洛克！",
			"我还以为你只喜欢抽烟和“查凶案”！"
		};
		boJumpingBeanChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"嗯。"
		};
		boJumpingBeanChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"我也喜欢！"
		};
		boTrainButtonSolution = new string[4]
		{
			"我不想……对你无礼……",
			"但是……你知道自己在做什么吗？",
			"真高兴我们是“探案搭档”，夏洛克！",
			"在两个按钮都变成黄色时按下它们就行了！"
		};
		boTrainButtonSolutionChoice1 = new string[4]
		{
			string.Empty,
			"当然知道！",
			string.Empty,
			string.Empty
		};
		boTrainButtonSolutionChoice2 = new string[4]
		{
			string.Empty,
			"不是很明白……",
			string.Empty,
			"好想法，华生！"
		};
		bo2 = new string[1]
		{
			"看啊，是气球，爸比！"
		};
		bo2Choice1 = new string[1]
		{
			string.Empty
		};
		bo2Choice2 = new string[1]
		{
			"停下，小博！"
		};
		bo3 = new string[3]
		{
			"可怜的乔治……",
			"…………………………………………………………………………………………………………………………………………………………",
			"他被装进了箱子里……"
		};
		bo3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bo3Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"嗯。"
		};
		bo32 = new string[3]
		{
			"……………………………………………………",
			"他可能是闻到了你夹克上的面包屑……",
			"我觉得这样折磨他不是很好……"
		};
		bo33 = new string[3]
		{
			"………………………………………………………………",
			"乔治喜欢马丁杂货铺的牛肉味狮心酥……",
			"如果你身上没有的话，那你应该赶紧去买，先生……"
		};
		pinstripeTrain1 = new string[7]
		{
			"早上好，泰迪……",
			"这小家伙是谁啊？",
			"你好啊，小博……",
			"喜欢气球吗？",
			"来个亮黑色的怎么样？",
			"我只是个好心人……",
			"带着亮黑色气球的好心人……"
		};
		pinstripeTrain1Choice1 = new string[7]
		{
			"嗯……",
			string.Empty,
			string.Empty,
			string.Empty,
			"不用……",
			string.Empty,
			string.Empty
		};
		pinstripeTrain1Choice2 = new string[7]
		{
			"早上好？",
			"嗯……她是小博。",
			string.Empty,
			string.Empty,
			"你是哪位？",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2 = new string[4]
		{
			"还有，小博……",
			"我喜欢你的打扮……",
			"喔哦……这可不太友善……",
			"小博，你爸比真是个大畜生……"
		};
		pinstripeTrain2Choice1 = new string[4]
		{
			string.Empty,
			"我们走，小博……",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2Choice2 = new string[4]
		{
			string.Empty,
			"离我们远点，变态。",
			string.Empty,
			"快走，小博。"
		};
		pinstripeHanglyPass = new string[10]
		{
			"你好啊，泰迪……",
			"喔哦……你让那个臭烘烘的迪奇来帮忙找小博……",
			"直觉告诉我，那个可怜老迪奇的腰背脆得就像……",
			"……烂掉的臭木偶一样……",
			"看来，小博要跟我在牧师小屋中待上一阵子了……",
			"没错……那就是我们具体要做的事……",
			"你个臭傻逼！",
			"你说什么？",
			"你说什么，驼峰脸？",
			"像你这样的人也难怪会跟那帮臭家伙混在一起……"
		};
		pinstripeHanglyPassChoice1 = new string[11]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"（保持缄默）",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeHanglyPassChoice2 = new string[7]
		{
			"带我去见小博！",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"你是十岁的小孩子吗？"
		};
		pinstripeCave = new string[7]
		{
			"你好啊，泰迪……",
			"我得承认……我确实很佩服你……",
			"很遗憾，小博已经在我的牧师房中……",
			"……待过一段时间了……",
			"我还期望着能在仪式上看到你那张俊脸呢……",
			"领养仪式，你个大傻帽！",
			"白白，大男孩……"
		};
		pinstripeCaveChoice1 = new string[8]
		{
			string.Empty,
			"嗯。",
			string.Empty,
			string.Empty,
			"嗯。",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveChoice2 = new string[8]
		{
			string.Empty,
			"小博在哪？",
			string.Empty,
			string.Empty,
			"什么仪式？",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExit = new string[10]
		{
			"你喜欢我在墙上给你留的短消息吗？",
			"我就是忍不住这么做，泰迪。",
			"小博是我的，你个大混球！",
			"“爸比，爸比，快救我！”",
			"哦吼吼吼吼吼……抱歉啊，小博！",
			"你爸比就像个白痴一样在到处乱跑！",
			"啊哈哈哈哈哈……",
			"我都快等不及那个仪式了！",
			"你那苍白的小脸很快就会眼泪横流，泰迪……",
			"而当我看到这场景时，我的肉体就会非常愉悦……"
		};
		pinstripeCaveExitChoice1 = new string[10]
		{
			"不喜欢。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExitChoice2 = new string[10]
		{
			"喜欢。",
			"带我去见小博！",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill = new string[9]
		{
			"泰迪，你来得正好，仪式马上就要开始了。",
			"喔哦……别像个小气鬼一样！",
			"坦白说，小博跟我在一起会更加幸福……",
			"那你要不要留下来参观仪式呀？",
			"时间不等人，泰迪……",
			"你个傻逼小废物！",
			"你尽管试试。",
			"不过要是你记不起自己死去的那个神圣之日……",
			"恐怕小博永远都会是我的了……"
		};
		pinstripeWindmillChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"（保持缄默）",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmillChoice2 = new string[10]
		{
			"放开小博！",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"你会付出代价的，你这头猪！",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2 = new string[8]
		{
			"喔哦……你正好错过了仪式，泰迪……",
			"看看她滴小脸朵可爱呀……",
			"你有什么要说的么，亲爱的？",
			"你回去吧，泰迪……",
			"我现在有新爸比了……",
			"他会保护我的安全，而且他很爱我……",
			"胜负已定，泰迪！",
			"很遗憾，你没办法让时光倒流。"
		};
		pinstripeWindmill2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"好。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2Choice2 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"小博，是我！",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrain = new string[8]
		{
			"你要和我一起玩火车吗，泰迪？",
			"你能化身为司机……",
			"晕头转向的司机……",
			"你可怜的小宝贝在楼上吗？",
			"被活活烧死了？",
			"你这个呱呱叫的小混蛋！",
			"我现在住在这了，男孩……",
			"我要跟新爸比在一起……"
		};
		boWithTrainChoice1 = new string[10]
		{
			"当然！",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrainChoice2 = new string[3]
		{
			"小博，我们走！",
			"快走，小博！",
			string.Empty
		};
		hiveTrain = new string[3]
		{
			"…………………………………………………………好恶心！",
			"它看起来像是巨大的旧麻袋……",
			"它弄得我头晕晕的……"
		};
		hiveTrain2 = new string[2]
		{
			"爸比，我觉得你不应该再吸那东西……",
			"它看起来对你不好……"
		};
		hiveTrain3 = new string[4]
		{
			"你看你都干了些什么，爸比！",
			"妈咪会生你气的……",
			"她一直跟我说不要吸那些看上去很奇怪的东西……",
			"就像我在冰箱底下找到的那个棕色东西……"
		};
		scarf = new string[3]
		{
			"小博的围巾……",
			"闻起来有股烟味……",
			"……以及威士忌的味道……"
		};
		scarfChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		scarfChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"带走"
		};
		bigTree = new string[2]
		{
			"……喂……喂……我……我……",
			"……吃……吃……的……的……"
		};
		bigTreeChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bigTreeChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"喂它吃的"
		};
		oldManV2 = new string[12]
		{
			"……呃？……",
			"泰迪？",
			"死鬼，你忘了我这张性感的脸？是我……迪奇先生……",
			"快点离开这里……我很痛苦……",
			"欢迎来到地狱……现在滚蛋！",
			"……条纹先生……",
			"我也许知道她在哪里，泰迪！",
			"……高悬之屋……",
			"不过你一把武器都没有，我都不知道你要怎么保护你自己。",
			"在你找到武器前，恐怕我是无法帮你了……",
			"我没在哭，我在，呃……",
			"……在笑……"
		};
		oldManV2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"谢谢你，好心先生！"
		};
		oldManV2Choice2 = new string[10]
		{
			"帮我！",
			"我认识你吗？",
			string.Empty,
			"但是我需要帮助！",
			"我的女儿被绑架了！",
			"谁？",
			string.Empty,
			string.Empty,
			string.Empty,
			"好吧，那你就是个爱哭鬼……"
		};
		oldManV22 = new string[5]
		{
			"你……你干嘛盯着我看？",
			"是因为我的痣吗？我头顶上隐隐出现了几颗新痣。不过我发誓它们是遗传的！",
			"我妈妈一直和我说，它们是上帝的礼物……",
			"但是我想让辛威医生割掉它们，因为我一直觉得贝蒂对我来说实在太美丽了……",
			"直到小学毕业，我看上去都像个畸形的小丑……"
		};
		oldManV23 = new string[5]
		{
			"这些痣可不是马戏表演！",
			"它们能用来骑单轮车吗，蠢货？能吗？",
			"它们能用来走钢索吗？不能！不能！",
			"你女儿不是被绑架了吗？你怎么还在这里……凝视……",
			"把我的痣当成可恶的马戏表演！"
		};
		hive = new string[2]
		{
			"那些麻袋果中的一个……",
			"……有股令人愉悦的香味。"
		};
		hiveChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		hiveChoice2 = new string[2]
		{
			string.Empty,
			"带走"
		};
		felix1 = new string[5]
		{
			"……………………………………………………………………………………………………………………………………………………嘿！",
			"上来这里！",
			"你为什么穿得跟臭教士一样？",
			"………………………………………………………………………………………………",
			"这些像麻袋一样的东西你有试过吗？"
		};
		felix1Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		felix1Choice2 = new string[5]
		{
			"你好……",
			string.Empty,
			"呃……",
			string.Empty,
			"没试过。"
		};
		felixHurt = new string[3]
		{
			"……………………………………………………………………………………",
			"………………………………………………呃…………………………………………老兄你搞毛线啊。",
			"………………啊…………………………那真伤了我的心……"
		};
		felixHurtChoice1 = new string[2]
		{
			string.Empty,
			"对不起！"
		};
		felixHurtChoice2 = new string[2]
		{
			string.Empty,
			"一定很疼，对吧？"
		};
		drunkMan3 = new string[5]
		{
			"…………………………………………………………………………",
			"这个叫条纹的家伙真有气质……",
			"非常有善意的气质……",
			"………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………",
			"你听到了吗？"
		};
		drunkMan3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"既然你都这么说了，兄弟！"
		};
		drunkMan3Choice2 = new string[3]
		{
			"再一次你好。",
			string.Empty,
			"你真难闻。"
		};
		poolTableMan = new string[3]
		{
			"小流氓，从桌子上下来。",
			"我正在参加比赛……",
			"你是神父不代表你真是我父亲。我说从桌子上下来，小流氓……"
		};
		poolTableManChoice1 = new string[4]
		{
			string.Empty,
			"实在对不起。",
			string.Empty,
			string.Empty
		};
		poolTableManChoice2 = new string[4]
		{
			string.Empty,
			"你的呼吸……",
			string.Empty,
			string.Empty
		};
		dog2 = new string[10]
		{
			"谢谢你，泰迪！……",
			"我还在想自己能不能从那里出来……",
			"嘿……小博在哪？",
			"啊……我就怕会那样……",
			"嗯，我们必须找到她的人……",
			"也许我能帮忙找到线索之类的东西……",
			"对了，迪奇先生在这附近吗？",
			"好吧……我大老远就闻到那家伙的屁股味……",
			"是那个叫条纹的家伙干的……",
			"他就是个大混蛋！"
		};
		dog2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"嗯。",
			string.Empty,
			"对不起，伙计！"
		};
		dog2Choice2 = new string[10]
		{
			"你会说话！",
			string.Empty,
			"条纹绑架了他！",
			string.Empty,
			"就这么办！",
			string.Empty,
			"是的。",
			"你为什么被关起来了？",
			string.Empty,
			"你也是个混蛋……"
		};
		dogBoSmell = new string[7]
		{
			"哇！",
			"你闻到了吗，泰迪？",
			"闻起来像是……苹果……",
			"我，不是很喜欢……",
			"我喜欢奶酪和馅饼，以及任何闻起来像牛肉的东西……",
			"是…………………………………………………………………………………………对不起。",
			"我们走吧。"
		};
		dogBoSmellChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			"嗯。",
			string.Empty,
			string.Empty
		};
		dogBoSmellChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			"小博喜欢苹果。",
			"嗯。",
			string.Empty
		};
		dog3 = new string[2]
		{
			"泰迪……",
			"去找小博……"
		};
		dogPraise1 = new string[1]
		{
			"好想法，泰迪！"
		};
		dogBalloonPop = new string[3]
		{
			"啊！老兄！你每次射破气球都把我吓坏了。",
			"你能不能……不要……这么做？",
			"那，就这么定了，哈？"
		};
		dogBalloonPopChoice1 = new string[2]
		{
			string.Empty,
			"对不起，乔治！"
		};
		dogBalloonPopChoice2 = new string[2]
		{
			string.Empty,
			"嗯……我拒绝。"
		};
		dogBalloonPop2 = new string[3]
		{
			"哒！",
			"泰迪！气球……",
			"你认真的？"
		};
		dogBalloonPop2Choice1 = new string[2]
		{
			string.Empty,
			"对不起！"
		};
		dogBalloonPop2Choice2 = new string[2]
		{
			string.Empty,
			"好好笑。"
		};
		recordPlayer1 = new string[3]
		{
			"留声机被红色羽毛覆盖着……",
			"唱片的名字是“贝蒂·邦德特女士：插曲及其它心声集”。",
			"这首歌叫做“最后的微笑”。"
		};
		recordPlayer1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer1Choice2 = new string[3]
		{
			string.Empty,
			"播放",
			string.Empty
		};
		recordPlayer12 = new string[2]
		{
			"音乐很优美，真的……",
			"我感觉自己来到了狗的天堂……"
		};
		recordPlayer12Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer12Choice2 = new string[3]
		{
			string.Empty,
			"嗯。",
			string.Empty
		};
		recordPlayer2 = new string[3]
		{
			"嘿！那是贝蒂女士令人心动的唱片之一！",
			"我们来播放它吧，泰迪！",
			"“最后的漫步”………………这名字有点悲伤……"
		};
		recordPlayer2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer2Choice2 = new string[3]
		{
			string.Empty,
			"播放",
			string.Empty
		};
		recordPlayer22 = new string[2]
		{
			"嗯嗯嗯嗯嗯嗯嗯嗯嗯嗯………………………………………………………………多美啊。我希望它闻起来和听起来一样好。",
			"不过它闻起来只有老奶奶的味道……"
		};
		recordPlayer22Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer22Choice2 = new string[3]
		{
			string.Empty,
			"嗯。",
			string.Empty
		};
		recordPlayer3 = new string[4]
		{
			"另一张贝蒂女士的唱片！",
			"有张便条贴在了边上……",
			"“泰迪，这首歌是我为小博写的。我对你的失去感到惋惜。——贝蒂女士”",
			"名字是……………………………………………………“最后的拥抱”。"
		};
		recordPlayer3Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer3Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"播放",
			string.Empty
		};
		recordPlayer32 = new string[3]
		{
			"这首歌太……悲伤了……",
			"我们还能拯救小博……对吧？",
			"一切都会顺利的，泰迪…"
		};
		recordPlayer32Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer32Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dogRecordPlayer = new string[1]
		{
			"这首歌太吓人了……"
		};
		dogRecordPlayerChoice1 = new string[1]
		{
			string.Empty
		};
		dogRecordPlayerChoice2 = new string[1]
		{
			"是啊。"
		};
		dogPoop = new string[4]
		{
			"啊……………………………………………………小女士的粪便……",
			"如果你看到她的话……你要狠狠地踢她的屁股，兄嘚……",
			"等下，等下，等下……",
			"我是会说话的狗，你要担心我的口音？"
		};
		dogPoopChoice1 = new string[2]
		{
			string.Empty,
			"谢谢你的提醒！"
		};
		dogPoopChoice2 = new string[2]
		{
			string.Empty,
			"笨蛋，你哪来的口音？"
		};
		dogMushroom = new string[5]
		{
			"一棵微微发光的蘑菇……",
			"闻起来特别像煤油……",
			"嘿，泰迪，你还记得在边缘森林和高悬通道到处都能看到这东西吗？",
			"我不知道……或许我们可以用火点亮它们，找到一些冻晶……",
			"我只是想帮忙而已……"
		};
		dogMushroomChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"好主意，乔治！"
		};
		dogMushroomChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"知道，那又怎样？",
			"嗯……不可靠。"
		};
		dogCaveJumpComment = new string[1]
		{
			"干得漂亮！"
		};
		dogCaveJumpCommentChoice1 = new string[1]
		{
			string.Empty
		};
		dogCaveJumpCommentChoice2 = new string[1]
		{
			"谢谢！"
		};
		caves = new string[2]
		{
			"这洞看上去既黑暗又邪恶……",
			"里面漆黑一片，什么都看不到……"
		};
		caves2 = new string[2]
		{
			"深处传来了不祥的恐怖之声……",
			"………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………………"
		};
		flashLightTalk = new string[3]
		{
			"好酷的头灯！",
			"上面衬有……花朵涂鸦……",
			"选择图标将它打开或关闭。"
		};
		flashLightTalkChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		flashLightTalkChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"带走"
		};
		lewis = new string[5]
		{
			"…………啊啊啊…………噢噢噢…………",
			"我的腰背要疼死了！",
			"听着，小崽子，我们的时间不多了……啊啊……",
			"小博就在……山顶上的……高悬之屋……",
			"我也希望我这个年龄的小细腿还能爬这座山……"
		};
		lewisChoice1 = new string[5]
		{
			string.Empty,
			"对不起！",
			string.Empty,
			"好。",
			string.Empty
		};
		lewisChoice2 = new string[5]
		{
			"你还好吗，迪奇？",
			"你已经老了。",
			string.Empty,
			"你不来吗？",
			"好吧。"
		};
		lewis2 = new string[4]
		{
			"你这傻瓜能不能不要跑来跑去……",
			"在你这个年纪，我每个星期要在父亲的炼钢厂里工作八十个小时……",
			"他……呃……每天都会用破的蒸汽管打我……",
			"我……我身上现在还有那时的伤疤……"
		};
		oldManStartWalking = new string[4]
		{
			"你怎么这么久才来，臭崽子！",
			"我在高悬之屋等你……",
			"我曾告诉过你！高悬之屋……就在山顶上……",
			"我敢肯定条纹先生藏匿小博的地方就在那里……"
		};
		oldManStartWalkingChoice1 = new string[4]
		{
			string.Empty,
			"好。",
			string.Empty,
			"我会去那见你的！"
		};
		oldManStartWalkingChoice2 = new string[4]
		{
			string.Empty,
			"哪里？",
			string.Empty,
			"好吧。老东西……"
		};
		key = new string[2]
		{
			"一把银钥匙……",
			"钥匙柄上刻着小小的“P”字……"
		};
		keyChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		keyChoice2 = new string[2]
		{
			string.Empty,
			"带走"
		};
		goldKeyTalk = new string[1]
		{
			"一把金钥匙……"
		};
		rifle = new string[4]
		{
			"一把老步枪……",
			"哈，这也太酷了……",
			"她叫“无限鸣鸟”……枪托上刻有它的名字……",
			"真想知道它为什么会叫那个名字？"
		};
		rifleChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		rifleChoice2 = new string[4]
		{
			"太好了！",
			string.Empty,
			string.Empty,
			"带走它！"
		};
		oldWomanPorch = new string[8]
		{
			"上帝保佑……",
			"泰迪熊？是你吗？",
			"很高兴见到你，泰迪！",
			"我的小朋友小博在哪啊？",
			"哦，是吗？",
			"我担心迪奇骗了你……",
			"那……你还把不把我从这个怪装置中弄出去？",
			"呵呵呵……笑话不错！"
		};
		oldWomanPorchChoice1 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"当然！"
		};
		oldWomanPorchChoice2 = new string[8]
		{
			string.Empty,
			"是？",
			string.Empty,
			"迪奇说她在这里……",
			string.Empty,
			"噢……",
			"不，谢谢，鸽子屁。",
			string.Empty
		};
		dogBirdyCommentNice = new string[10]
		{
			"我在想你是不是刻意这么做的？",
			"不管怎样，我觉得你或许已经杀了她……",
			"至少在她死前你对她还是挺好的……",
			"她真是个非常友善的老婆婆。",
			"……………………嗯……………………",
			"致贝蒂女士……",
			"愿她的灵魂……能永远飞翔……",
			"飞过天空……",
			"飞入天堂……",
			"阿门……"
		};
		dogBirdyCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"她确实是……"
		};
		dogBirdyCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"为她说几句话吧，乔治。"
		};
		dogBirdyCommentMean = new string[6]
		{
			"老兄……你杀死了她！",
			"你先是叫她鸽子屁，现在又这样做？！",
			"是的……我的意思是，别误解我的意思……",
			"她闻起来确实像鸽子屁……",
			"但是，谁在乎呢！",
			"你刚刚杀死了她！"
		};
		dogBirdyCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			"对不起……",
			string.Empty,
			string.Empty
		};
		dogBirdyCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			"她闻上去确实像屁。",
			string.Empty,
			"是啊……"
		};
		dogBarCommentMean = new string[6]
		{
			"天啊，你真的惹怒了那家伙……",
			"从现在起，只要……像个普通人一样就行了……",
			"你不会想在这个时间点上让自己被打晕吧？",
			"你这话说得确实很时髦，很有自己的范儿……",
			"但你的胳膊却……",
			"……细得像竹竿……"
		};
		dogBarCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"我觉得你说得对……",
			string.Empty
		};
		dogBarCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"我可以解决他们！",
			string.Empty
		};
		dogBarCommentNice = new string[4]
		{
			"嗯……你是认真的吗？",
			"你真的要跟大家一起在这样的夜晚举行派对？",
			"泰迪……那小博怎么办？",
			"是吗，那可不行……"
		};
		dogBarCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			"当然不！",
			string.Empty,
			string.Empty
		};
		dogBarCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			"当然要！",
			"算了吧……",
			string.Empty
		};
		floatingPeople = new string[18]
		{
			"吼哈哈呵呵呵……噢，泰迪，那太疯狂了！",
			"但是迪奇有话要跟你说，对吧，迪奇？",
			"呃……我骗了你……但我只是想让你帮我找到小贝蒂……",
			"条纹先生住在红洗……",
			"……红洗是地狱腹地深处的一片湖。",
			"我担心你可爱的小博被锁到了他那可怕的牧师房中……",
			"你要有灯才能去到那里……",
			"……让我看看那东西还在不在……",
			"……啊，太好了，它在这……",
			"有天夜晚，在我和小博一起玩耍之后，她给了我这张奇怪的纸……",
			"我在想它能不能帮你找到灯……",
			"即使忘了你也可以在以后查看那个线索……",
			"看到屏幕下方闪烁的『线索图标』了吗？",
			"你一路上找到的线索都可以在这里查看……",
			"不管怎样……",
			"一定要仔细调查它们……",
			"我们都会在红洗等你……",
			"我相信我们会找回小博，亲爱的……"
		};
		floatingPeopleChoice1 = new string[14]
		{
			string.Empty,
			"没关系的，迪奇……",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		floatingPeopleChoice2 = new string[18]
		{
			"是啊。",
			"让我们来听听，渣滓…",
			"但是小博在哪？",
			string.Empty,
			string.Empty,
			"知道了。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"谢谢。",
			string.Empty,
			"是的。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"嗯。"
		};
		dogHintChest = new string[5]
		{
			"泰迪！还记得边缘森林里那棵树上的玩具箱吗？",
			"或许它与贝蒂女士的找灯提示有关……",
			"就是去红洗你所需要的灯……",
			"别忘了调查你的线索，老兄……",
			"看到屏幕左下角的线索图标了吗？"
		};
		dogHintChestChoice1 = new string[3]
		{
			string.Empty,
			"知道了。",
			string.Empty
		};
		dogHintChestChoice2 = new string[3]
		{
			string.Empty,
			"什么灯？",
			string.Empty
		};
		telephone = new string[3]
		{
			"………………………………爸比……",
			"是你吗？",
			"……………………………………………………………………………………………………………………救我，爸比！"
		};
		pinstripeManBoss = new string[3]
		{
			"你个臭垃圾！",
			"你打扰了我们最完美、最珍贵的相聚！",
			"燃烧吧，泰迪小子！！！！！"
		};
		houseLockedGold = new string[1]
		{
			"门被金挂锁给锁住了……"
		};
		houseLockedMechanism = new string[1]
		{
			"门被某种机械装置给锁住了……"
		};
		houseLockedMechanismChoice1 = new string[1]
		{
			string.Empty
		};
		houseLockedMechanismChoice2 = new string[1]
		{
			"调查"
		};
		houseLockedSilver = new string[1]
		{
			"门被银挂锁给锁住了……"
		};
		houseLocked2 = new string[1]
		{
			"门被锁住了……"
		};
		sign1 = new string[2]
		{
			"上：高悬通道",
			"下：红洗"
		};
		sign2 = new string[1]
		{
			"去红洗……"
		};
		signPissward = new string[2]
		{
			"“通往红洗……”",
			"“需要在哈皮那买票。”"
		};
		signBalloonShop = new string[4]
		{
			"“严禁吸食我家的速度幻觉菇。”",
			"“副作用包括：作呕、腹泻、产生自杀念头……”",
			"“或是让玩家的打枪速度上升一级……”",
			"“所以不要吸食！——品客的气球店”"
		};
		liftPower = new string[3]
		{
			"像是水车之类的东西……",
			"它好像能给缆车供电……",
			"可是……水在哪呢？"
		};
		signPissward2 = new string[2]
		{
			"好像是燃气管道……",
			"“燃气管道联通至边缘森林、高悬通道、麻袋滑道、尿流瀑布和红洗……”"
		};
		signPissward2Choice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signPissward2Choice2 = new string[2]
		{
			string.Empty,
			"调查"
		};
		signHappySafe = new string[2]
		{
			"一个大保险箱？",
			"别对它动歪脑筋，傻瓜。——哈皮"
		};
		signHappySafeChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signHappySafeChoice2 = new string[2]
		{
			string.Empty,
			"调查"
		};
		signTimsShop = new string[2]
		{
			"一张潦草的便条……",
			"“想要睡觉。在傍晚八点十分醒来……”"
		};
		signTimsShopChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signTimsShopChoice2 = new string[2]
		{
			"调查",
			string.Empty
		};
		pisswardMan1 = new string[13]
		{
			"你好啊，神父……",
			"欢迎来到尿流瀑布，这里是尿尿蛇的臭尿家……",
			"去红洗的缆车票需要三百冻晶……",
			"感谢你的惠顾，神父……",
			"啊啊啊……太好了……",
			".………………………………噢噢噢……那太好了……噢噢噢哇……",
			"我要带上这些冻晶前往红洗，然后在试着睡一会……",
			"我好久没睡过觉了……",
			"有多久？",
			"我记不清了……",
			"……没什么比咬碎这些冻晶，让它们把你带到仙境更好的了……",
			"愿上帝保佑条纹先生。愿上帝保佑他真诚的灵魂……",
			"给你缆车票，神父……"
		};
		pisswardMan1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"不，谢谢。"
		};
		pisswardMan1Choice2 = new string[3]
		{
			"你好。",
			string.Empty,
			"买票（三百）"
		};
		happyEdgeWood = new string[14]
		{
			"你好，神父……",
			"是我，哈皮……",
			"噢，你认识我的，泰迪！",
			"你是小博的朋友？",
			"好吧，不管怎样，你现在看上去非常的忧虑和伤感……",
			"真希望和你畅饮一杯，不过你现在得去红洗，那里还有你要做的事……",
			"我能用好的价钱卖给你更好的东西……",
			"你应该买这把非法的汤姆枪，只需一千冻晶……",
			"感谢你的惠顾，神父……",
			"跟汤米先生问好吧，先生……",
			"带着一把枪会让你看上去更加性感……",
			"真希望我有一部照相机，这样我就能给我母亲拍张快照……",
			"总之……现在你可以像个新鲜出炉的黑帮一样去营救你心爱的宝贝了……",
			"一定要说到做到，船长…"
		};
		happyEdgeWoodChoice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"不，谢谢。"
		};
		happyEdgeWoodChoice2 = new string[8]
		{
			"我认识你吗？",
			"谁？",
			string.Empty,
			"不是。",
			"什么？",
			string.Empty,
			string.Empty,
			"购买（一千）"
		};
		happyHangly = new string[13]
		{
			"你好啊，神父……",
			"我有些东西可以用合理的价钱卖给你……",
			"说到这个，你小狗的奶头都要冻坏了……",
			"你看我正在~发~抖~！",
			"你应该花四百冻晶来买这件小狗毛衣……",
			"感谢你的惠顾，神父……",
			"太可爱了！看看他的衣服，漂亮又暖和……",
			"那件毛衣是在我母亲超长的提示下手织出来的……",
			"我敢说他的奶头很快就会变得……",
			"……滋润，新鲜又成熟……",
			"还有，谢谢你的冻晶……",
			"如果你想要其它东西，只要找到小理发店的转灯就行了……",
			"它是黄色会旋转的……"
		};
		happyHanglyChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"不，谢谢。"
		};
		happyHanglyChoice2 = new string[5]
		{
			"你好。",
			string.Empty,
			string.Empty,
			string.Empty,
			"购买（四百）"
		};
		happyCave = new string[10]
		{
			"你好，神父……",
			"你觉得这个洞穴系统怎么样？",
			"我觉得条纹先生正在这下面搞什么大动作……",
			"还是冷得要命……",
			"我拿我母亲的命发誓，地下会比这里更暖和……",
			"说到这个，条纹先生把他多余的一件衣服给了我……",
			"让我，让我看看能不能……呃……能不能在这找到……",
			"好，好。这里，在这里。我可以将他多出来的衣服以五百冻晶的价格卖给你……",
			"感谢你的惠顾，神父……",
			"……………………你看起来很像他，泰迪！……"
		};
		happyCaveChoice1 = new string[8]
		{
			string.Empty,
			"很酷。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"不用，谢谢。"
		};
		happyCaveChoice2 = new string[8]
		{
			"你好，哈皮。",
			"没有什么感想。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"购买（五百）。"
		};
		timRedWash1 = new string[11]
		{
			"你好啊，神父……",
			"那个，关于你在尿流瀑布给我的那些冻晶……",
			"呃……很明显，那些还不够我想要的睡法……",
			"所以，听着。我可以帮你从条纹先生手中救出小博……但是我需要你替我办件事……",
			"如果你这次给我十个麻袋果……听好，不是冻晶，是新鲜的麻袋果……要真货……",
			"我会卖给你一份报纸……不过那不是普通的报纸……",
			"在它上面有去条纹牧师房的密码……",
			"你觉得这交易怎样？那些麻袋果是唯一能让我今晚入睡的东西……",
			"条纹先生会在特定的时间送来那些麻袋果，神父……",
			"这里有条小线索能提示你何时送来……",
			"你一找到麻袋果，就把它们带来这里，这样我就可以吸干它们……"
		};
		timRedWash1Choice1 = new string[18]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash1Choice2 = new string[10]
		{
			"你好啊，哈皮。",
			"嗯？",
			"嗯。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"当然好啊！",
			string.Empty,
			"好！"
		};
		timRedWash2 = new string[10]
		{
			"你好啊，神父……",
			"你要用十个麻袋果买报纸吗？……",
			"它能告诉你进入条纹牧师房的线索……",
			"谢谢你……",
			"时间变晚了……",
			"我想我会关店睡觉去，你知道我打算干嘛的……",
			"我要在商店里美美地睡过这场风暴……",
			"太疯狂了……你做了什么，神父？",
			"总之……密码应该在那份报纸上……",
			"…………………………………………………………晚安，神父……"
		};
		timRedWash2Choice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			"还不买。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash2Choice2 = new string[10]
		{
			"你好，哈皮。",
			string.Empty,
			"购买（十个麻袋果）",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapArea = new string[4]
		{
			"小博的玩具弹弓……",
			"木柄上刻着“小博生日快乐”……",
			"点击或按下扳机键进行射击。",
			"你可以打破东西了，例如那边的箱子……"
		};
		blunderBustTapAreaChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapAreaChoice2 = new string[5]
		{
			"调查",
			string.Empty,
			string.Empty,
			"拿走",
			string.Empty
		};
		whiskey = new string[1]
		{
			"一支威士忌酒瓶……"
		};
		whiskeyChoice1 = new string[1]
		{
			string.Empty
		};
		whiskeyChoice2 = new string[1]
		{
			"拿走"
		};
		dan = new string[10]
		{
			"今晚是祝福之夜……",
			"欢迎来到红洗……",
			"这里是条纹先生的极乐度假胜地。",
			"请客人在登记表上签下自己的名字……",
			"嗯嗯嗯……多好看的签名……",
			"请注意今晚是非常特殊的夜晚……",
			"月圆之时会进行仪式……",
			"条纹先生并不是每天都能找到鲜活饱满的孩子……",
			"所以条纹先生要求所有居民都要来见证……",
			"见证孩子的永久收养仪式……"
		};
		danChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"谢谢。",
			string.Empty,
			string.Empty,
			string.Empty
		};
		danChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"什么仪式？"
		};
		dan2 = new string[7]
		{
			"那个仪式……",
			"那个仪式不仅让我后背发凉……",
			"还让我想要喝牛奶。",
			"你无法什么？",
			"你无法理解好的温牛奶是干什么用的？",
			"暖暖的牛奶搭上我从未见过的收养仪式……",
			"你当然理解不了……"
		};
		dan2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"嗯。"
		};
		dan2Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"我无法……"
		};
		dan22 = new string[1]
		{
			"丹尼尔想要牛奶。"
		};
		dan22Choice1 = new string[1]
		{
			string.Empty
		};
		dan22Choice2 = new string[1]
		{
			"知道了。"
		};
		dan23 = new string[1]
		{
			"温妞奶配收养仪式。"
		};
		dan23Choice1 = new string[1]
		{
			string.Empty
		};
		dan23Choice2 = new string[1]
		{
			"知道了。"
		};
		dan24 = new string[1]
		{
			"真希望我能将妞奶倒进我的嘴里。"
		};
		dan24Choice1 = new string[1]
		{
			string.Empty
		};
		dan24Choice2 = new string[1]
		{
			"知道了。"
		};
		dan25 = new string[1]
		{
			"想象一下一池的妞奶都停留在我嘴中。"
		};
		dan25Choice1 = new string[1]
		{
			string.Empty
		};
		dan25Choice2 = new string[1]
		{
			"知道了。"
		};
		dan26 = new string[1]
		{
			"妞奶。"
		};
		dan26Choice1 = new string[1]
		{
			string.Empty
		};
		dan26Choice2 = new string[1]
		{
			"知道了。"
		};
		dan27 = new string[1]
		{
			"……………………………………………………………………………………………………………………………………………………………………"
		};
		dan27Choice1 = new string[1]
		{
			string.Empty
		};
		dan27Choice2 = new string[1]
		{
			"嗯？"
		};
		kitty2 = new string[4]
		{
			"噢，我的，我的，我的……",
			"你的小女孩还真是活跃……",
			"但是别担心，泰迪……",
			"她很快就会叫我“爸爸”……"
		};
		kitty4 = new string[1]
		{
			"……………………"
		};
		signMegaGem = new string[7]
		{
			"…………………………………………………………………………………巨大的黑色冻晶……",
			"“月态火山渣麻袋果：条纹记录中最大的冻晶……”",
			"“挖掘于红洗井底323米深的麻袋果化石层。”",
			"“价值五十冻晶。”",
			"它闻上去有股清新发胶的气味……",
			"老实说挺好闻的……",
			"唱首歌让我入睡，阿达……"
		};
		signMegaGemChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"嗯。"
		};
		signMegaGemChoice2 = new string[4]
		{
			"阅读",
			string.Empty,
			string.Empty,
			"闻一下"
		};
		balloonMan1 = new string[11]
		{
			"呃啊啊……我可没说过你能在这里瞎晃悠……",
			"不过说实话，你能来我还是挺高兴的。因为这样我就有机会夸耀我的气球机器了……",
			"附近的孩子都叫我品客，而且因为这些气球，我也被称作镇子里最厉害的气球匠……",
			"条纹先生订购了一整批气球，我的订单就像品客薯片一样塞得满满的……",
			"是的……只用了，大概，十秒钟……",
			"嗯嗯……我想用我的大冻晶跟你赌，赌你无法打败我敏捷灵活的机器……",
			"你的过于自信了，朋友！",
			"准备好让你愚蠢的头脑挨打吧！",
			"预备……",
			"整备……",
			"开始！"
		};
		balloonMan1Choice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		balloonMan1Choice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"我跟你赌！"
		};
		balloonMan2 = new string[6]
		{
			"手下败将！",
			"想再玩一次吗，船长？",
			"准备好挨打吧！",
			"预备……",
			"戒备……",
			"品客！"
		};
		balloonMan2Choice1 = new string[2]
		{
			string.Empty,
			"不，谢谢。"
		};
		balloonMan2Choice2 = new string[2]
		{
			string.Empty,
			"来吧！"
		};
		balloonMan2b = new string[6]
		{
			"噢，船长，我的船长！",
			"想再玩一次吗，船长？",
			"我等不及想看那些技技技技巧巧巧巧了！",
			"预备……",
			"戒备……",
			"品客！"
		};
		balloonMan2bChoice1 = new string[2]
		{
			string.Empty,
			"不，谢谢。"
		};
		balloonMan2bChoice2 = new string[2]
		{
			string.Empty,
			"来吧！"
		};
		balloonMan3 = new string[5]
		{
			"啊啊啊啊什什什么么么？？？？！！！！",
			"你……你……",
			"你太了不起了！你打败气球机器所使用的组合技真是……",
			"品无前客！简直不可品客……",
			"神父，去领奖吧……过去……拿走它吧……"
		};
		balloonMan3Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"真是太好了！"
		};
		balloonMan3Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"嗯……废话……"
		};
		savePortraitGronkh = new string[2]
		{
			"另一张男士肖像画……面相看上去非常好斗。",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitGronkhChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkhChoice2 = new string[1]
		{
			"保存游戏"
		};
		savePortraitGronkh2 = new string[2]
		{
			"肖像画里的人看上去还是很好斗……",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitGronkh2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh2Choice2 = new string[1]
		{
			"保存游戏"
		};
		savePortraitGronkh3 = new string[2]
		{
			"好强烈的怒气！都从画像里溢出来了！",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitGronkh3Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh3Choice2 = new string[1]
		{
			"保存游戏"
		};
		savePortraitGronkh4 = new string[2]
		{
			"画像给人一种怒气满满的感觉。主要是因为那位好斗的男士……",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitGronkh4Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh4Choice2 = new string[1]
		{
			"保存游戏"
		};
		savePortraitDirk = new string[2]
		{
			"经过精心梳妆的人士的肖像画……",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitDirkChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitDirkChoice2 = new string[1]
		{
			"保存游戏"
		};
		savePortraitRMannion = new string[2]
		{
			"时尚文艺人士的肖像画……",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitRMannionChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitRMannionChoice2 = new string[1]
		{
			"保存游戏"
		};
		savePortraitJHandville = new string[2]
		{
			"拥有漂亮胡子的男士的肖像画…",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitJHandvilleChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitJHandvilleChoice2 = new string[1]
		{
			"保存游戏。"
		};
		savePortraitNathanKingston = new string[2]
		{
			"长得像耶稣，但不是耶稣的人的肖像画，看啊，他的名字叫内森……",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitNathanKingstonChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitNathanKingstonChoice2 = new string[1]
		{
			"保存游戏"
		};
		savePortraitOchoma = new string[2]
		{
			"一张悲伤、冷漠的肖像画……",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitOchomaChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitOchomaChoice2 = new string[1]
		{
			"保存游戏"
		};
		savePortraitBuddy = new string[2]
		{
			"一位男士的奇怪肖像画……",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitBuddyChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddyChoice2 = new string[1]
		{
			"保存游戏"
		};
		savePortraitBuddy2 = new string[2]
		{
			"依然是一位男士的奇怪肖像画……不过他是秃顶有胡子的类型……",
			"……………………………………………………………………………………游戏已保存。"
		};
		savePortraitBuddy2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddy2Choice2 = new string[1]
		{
			"保存游戏"
		};
		creepyMan = new string[2]
		{
			"……………………他现在应该在这里的……对吧？",
			"他应该带更多的水果来这里……"
		};
		creepyMan2 = new string[2]
		{
			"浴缸？",
			"泰迪……我觉得里面有什么东西……"
		};
		creepyMan3 = new string[5]
		{
			"那位老人和美女一分钟前才刚刚经过这里……",
			"他们说你要摧毁条纹先生……",
			"请别这么做，老兄！",
			"他是我一直生活在这下面的唯一理由……",
			"他很快就会来这里……对吧？来给我更多的麻袋果……"
		};
		jack = new string[8]
		{
			"………………啊…………………………………………………………神父？",
			"………………嗯…………………………………………………………救我！",
			"这个恶魔一样的东西要活吞我！",
			"我不是要吃你………………只是要送你到红洗。",
			"别担心，小乖乖……那下面可有意思了……每日每夜都有浓稠的麻袋果汁可以喝……",
			"哦……真的吗？……",
			"嗯……那好吧！",
			"快点！我们时间不多了！"
		};
		jackChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		jackChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkard = new string[9]
		{
			"神父……你……要在仪式后……参加派对吗？",
			"给你！先喝些条纹先生的……麻、麻、麻袋果汁……助助兴…… ",
			"……呣呣呣……",
			"它很好喝，没错……但是没有真货那么好喝……",
			"条纹先生……会在仪式上……派送这种装满果汁的……新鲜麻袋……",
			"你也会跟我们一起品尝禁果……对吧，神父？",
			"让我把你大翻在地怎么样啊？",
			"没有什么比被别人评头论足……更难受的了……",
			"尤其是出自像你这样的可怜人之口……"
		};
		drunkardChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"好啊，我喜欢派对！",
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkardChoice2 = new string[6]
		{
			string.Empty,
			"嗯。",
			string.Empty,
			string.Empty,
			string.Empty,
			"免了，谢谢，醉鬼。"
		};
		dickyBar = new string[11]
		{
			"……噗嘶……",
			"泰迪……是我……",
			"迪奇先生……",
			"来这下面要小心……",
			"如果让条纹那家伙发现我的话，他会杀了我的……",
			"尤其是我们帮你找小博这件事被他发现的话，所以……",
			"我进行了伪装……",
			"……我现在是个小丑，泰迪……",
			"看到这个鼻子了吗？",
			"她藏在了条纹的井里……",
			"她说她要给你个惊喜……"
		};
		dickyBarChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"看到了。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarChoice2 = new string[22]
		{
			"嗨。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"贝蒂女士在哪？",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2 = new string[6]
		{
			"什么？",
			"你没在取笑我头上的痣，对吧？",
			"别看！别看！",
			"我可不是小丑——",
			"………………………………………………",
			"你别管我！"
		};
		dickyBar2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarNight = new string[6]
		{
			"你做了什么，泰迪？",
			"我的骨头好痛……",
			"我以为……",
			"泰迪……",
			"对不起，不过我以为已经结束了……",
			"我说过它已经结束了。"
		};
		dickyBarNightChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"嗯。"
		};
		dickyBarNightChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"什么？"
		};
		birdyBarrel = new string[9]
		{
			"嘘嘘嘘嘘……呵呵呵呵……",
			"泰迪熊……",
			"又是我……",
			"快！拿走这根真勺子……",
			"我很喜欢它的光泽与气味……",
			"也很喜欢摸它，你也觉得是吧？",
			"你需要用它来打败条纹那家伙，然后救出可怜的小博……",
			"别告诉其它人我在这里……",
			"我不想再被条纹关进那笼子里……"
		};
		birdyBarrelChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"是的！"
		};
		birdyBarrelChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"诶，谢谢……",
			string.Empty,
			"别说蠢话了……"
		};
		tokenInvite1 = new string[1]
		{
			"一张纸……"
		};
		tokenInvite1Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite1Choice2 = new string[1]
		{
			"带走"
		};
		tokenInvite2 = new string[1]
		{
			"一张纸……"
		};
		tokenInvite2Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite2Choice2 = new string[1]
		{
			"带走"
		};
		tokenFilmStrip = new string[1]
		{
			"一卷秘密电影胶片……"
		};
		tokenFilmStripChoice1 = new string[1]
		{
			string.Empty
		};
		tokenFilmStripChoice2 = new string[1]
		{
			"带走"
		};
		tokenBible = new string[1]
		{
			"一本旧圣经……"
		};
		tokenBibleChoice1 = new string[1]
		{
			string.Empty
		};
		tokenBibleChoice2 = new string[1]
		{
			"带走"
		};
		tokenNotebook = new string[3]
		{
			"它是怎么到这的……",
			"别看它，爸比……",
			"它只是一张蠢画……"
		};
		tokenNotebookChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		tokenNotebookChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"带走"
		};
		tokenPills = new string[1]
		{
			"一罐空药瓶……"
		};
		tokenPillsChoice1 = new string[1]
		{
			string.Empty
		};
		tokenPillsChoice2 = new string[1]
		{
			"带走"
		};
		tokenNewspaper = new string[1]
		{
			"一份报纸……"
		};
		tokenNewspaperChoice1 = new string[1]
		{
			string.Empty
		};
		tokenNewspaperChoice2 = new string[1]
		{
			"带走"
		};
		tokenLocket = new string[3]
		{
			"为什么你的东西都被扔到了那门外，爸比？",
			"那是……",
			"……那是妈咪的盒式吊坠吗？"
		};
		tokenLocketChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		tokenLocketChoice2 = new string[3]
		{
			"我不清楚……",
			string.Empty,
			"调查"
		};
		blackAndWhiteModeTalk = new string[4]
		{
			"你当真要再玩一遍这游戏？",
			"这游戏烂爆了……",
			"总之，你要花五卷电影胶片来玩超级复古模式吗？",
			"恭喜。你刚花了五卷电影胶片来丢掉这游戏中的所有颜色……"
		};
		blackAndWhiteModeTalkChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"不玩。",
			string.Empty
		};
		blackAndWhiteModeTalkChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"玩。（五卷电影胶片）",
			string.Empty
		};
		sackGeneratorExamine = new string[4]
		{
			"很像我们在边缘深林里喂给那棵树的麻袋东西……不过这个超级大！",
			"它看起来像在休眠……",
			"而且闻起来很像鸡蛋……",
			"很好……"
		};
		sackGeneratorExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGeneratorExamineChoice2 = new string[1]
		{
			"调查"
		};
		sackGenerator2Examine = new string[4]
		{
			"另一个麻袋果生成器……",
			"呀……",
			"快看那些牙齿！",
			"啊！这个闻起来很像牛奶……"
		};
		sackGenerator2ExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGenerator2ExamineChoice2 = new string[1]
		{
			"调查"
		};
		sackGenerator3Examine = new string[5]
		{
			"另一个……",
			"也许这个能用来发酵麻袋果汁什么的……",
			"我不知道……",
			"但是它闻起来很像…………………………………………………………屎。",
			"好吧……我道歉，不过它闻起来就是那样的气味，兄弟……"
		};
		sackGenerator3ExamineChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"你真风趣，乔治……"
		};
		sackGenerator3ExamineChoice2 = new string[5]
		{
			"调查",
			string.Empty,
			string.Empty,
			"别说了……",
			string.Empty
		};
		characterSucked = new string[1]
		{
			"………………………………"
		};
		characterSuckedFelix = new string[2]
		{
			"泰迪……",
			"我头上有东西吗？"
		};
		explainFire = new string[8]
		{
			"你好啊，漏尿灯芯……",
			"别对我妄加指责……",
			"我发誓我一直都很乖……只是有点口渴而已……",
			"没有什么能比痛饮一口条纹先生的麻袋果汁更好的了……",
			"那给我一总很特别的感洁……",
			"他说小博的领养仪式上会有更多……",
			"关你什么事啊，废物？",
			"你连停车都不懂……"
		};
		explainFireChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"嗯。",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		explainFireChoice2 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"领养仪式啥时候开始？",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		redWashNotice = new string[7]
		{
			"通知……",
			"“参加小博领养仪式的所有红洗居民……”",
			"“……都能免费获得条纹先生的麻袋果……”？",
			"“不参加的居民……”",
			"“会被辱骂………………………………和大力鞭打至屈服……”？",
			"“谢谢，祝平安！”",
			"……………………很好……………………"
		};
		redWashNoticeChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"那太可怕了……"
		};
		redWashNoticeChoice2 = new string[6]
		{
			"阅读",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"听起来像我喜欢的派对。"
		};
		potBellyMan = new string[7]
		{
			"嘘嘘嘘嘘…………呵呵呵呵…………",
			"你……听到了吗，神父？",
			"那是条纹先生的巨钟……",
			"我收到指令，不能让任何人碰那座巨钟……",
			"无论何种情况，都不允许有人……",
			"……弄坏那该死的钟！",
			"你不会去弄坏它………………………………………………对吧，兄弟！？"
		};
		potBellyManChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"我明白！"
		};
		potBellyManChoice2 = new string[4]
		{
			string.Empty,
			"什么？",
			string.Empty,
			"我不仅要碰……"
		};
		potBellyMan2 = new string[6]
		{
			"………………………………………………",
			"你弄乱了那座巨钟？",
			"你不知道规矩吗？",
			"别再来了！别再来了！",
			"条纹先生又要对我使出……",
			"……………………………………………………………………………………战争践踏了！"
		};
		potBellyMan2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"嗯……再见……"
		};
		potBellyMan2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"怎么了？"
		};
		potBellyMan22 = new string[3]
		{
			"…………………………………………呃呃……",
			"我的意思是……",
			"被战争践踏是一回事。我只希望他还能给我麻袋果……"
		};
		potBellyMan22Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		potBellyMan22Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"哇。",
			string.Empty
		};
		fork = new string[3]
		{
			"一把叉子。",
			"它有点生锈，闻上去像硬币……",
			"上面喷洒了………………………………………………………………………………………………………………乳液？"
		};
		forkChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		forkChoice2 = new string[3]
		{
			"调查",
			string.Empty,
			"带走"
		};
		boHeaven1 = new string[3]
		{
			"爸比！",
			"我很想你！",
			"想出去玩吗？"
		};
		boHeaven1Choice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boHeaven1Choice2 = new string[3]
		{
			"小博！",
			"我也很想你！",
			"好啊！"
		};
		boHeaven2 = new string[2]
		{
			"爸比！",
			"那看上去像是妈咪的蝴蝶项链！"
		};
		boHeaven2Choice1 = new string[1]
		{
			string.Empty
		};
		boHeaven2Choice2 = new string[1]
		{
			"嗯？"
		};
		boHeavenGeorge = new string[1]
		{
			"喔……………………………………真希望乔治也在这里……"
		};
		boHeavenGeorgeChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenGeorgeChoice2 = new string[1]
		{
			"……"
		};
		boHeavenButterflies = new string[3]
		{
			"哇！快看，爸比！",
			"真希望妈咪也能在这里看看这个。她很喜欢蝴蝶……",
			"嘿！我打赌你肯定抓不完它们！"
		};
		boHeavenButterfliesChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenButterfliesChoice2 = new string[2]
		{
			string.Empty,
			"是啊……"
		};
		secretRoomCaveSign = new string[8]
		{
			"一座石碑……",
			"“大主教房间：”",
			"“献给候任大主教。”",
			"“如闪电球一样……”",
			"“在眨眼之间，天外之人便提供了能量……”",
			"“照亮并扩大条纹的世界。”",
			"“请享受深红马格努斯冰晶，每个价值二百冰晶。”",
			"“顺带一提，它们闻起来像格伦威士忌。”"
		};
		secretRoomCaveSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomCaveSignChoice2 = new string[1]
		{
			"调查"
		};
		secretRoomTreeSign = new string[7]
		{
			"一座石碑……",
			"“大主教花园：”",
			"“献给候任大主教。”",
			"“这些真诚且谦卑的礼物都是由天外之人提供的……”",
			"“是一粒金色的种子，长成为这株壮丽的荆棘……”",
			"“请随意带走这些柠檬树斯塔顿冰晶，每个价值一百冰晶。”",
			"“顺带一提，它们闻起来像刚挤出来的柠檬味防晒液。”"
		};
		secretRoomTreeSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomTreeSignChoice2 = new string[1]
		{
			"调查"
		};
	}
	else if (@string == "Spanish")
	{
		trainDoorButton1 = new string[1]
		{
			"Un botón..."
		};
		wifeIntro = new string[2]
		{
			"Teddy...",
			"Tengo algo que contarte..."
		};
		bo1 = new string[6]
		{
			"¡Despierta, papá!",
			"Estás sonámbulo de nuevo...",
			"¡Oye! ¿Te huele a humo?",
			"¡Vamos a investigar!",
			"Tú puedes ser Sherlock...",
			"¡Qué tonto!"
		};
		bo1Choice1 = new string[5]
		{
			string.Empty,
			"Perdona, cariño.",
			string.Empty,
			string.Empty,
			"Vale."
		};
		bo1Choice2 = new string[5]
		{
			"Eeehhh... ¿qué?",
			"No, para nada.",
			"Sí.",
			string.Empty,
			"¡Eso es, Watson!"
		};
		trainDoorButtonBo = new string[2]
		{
			"¡Sherlock!",
			"¡Creo que puedo llegar a ese botón!"
		};
		trainDoorButtonBoChoice1 = new string[3]
		{
			"¿Watson?",
			string.Empty,
			string.Empty
		};
		trainDoorButtonBoChoice2 = new string[2]
		{
			string.Empty,
			"Vale... ¡No te muevas de donde estás!"
		};
		lockedTrainDoor = new string[1]
		{
			"Cerrado..."
		};
		sackSpitExplainer = new string[3]
		{
			"¿Eso qué es, papá?",
			"Parece una gota congelada de...",
			"¿Aceite?"
		};
		mirror = new string[7]
		{
			"¡Es un espejo, Sherlock!",
			"Tiene tanto polvo que apenas se te ve la cara.",
			"Mieeedo...",
			"¡Je! Mira, papá, qué pinta tenemos de fantasmas raros...",
			"¡Buum!",
			"Ah, vale...",
			"¡Bluu!"
		};
		mirrorChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vamos."
		};
		mirrorChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Se dice 'buu', cariño."
		};
		mirror2 = new string[6]
		{
			"Espejito, espejito de escarcha...",
			"¿Quién es la princesa más bella del...?",
			".......................",
			".......................",
			"¿Qué rima con 'escarcha', papá?",
			"¡Dime que soy la princesa más bella con una mancha!"
		};
		mirror2Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vamos."
		};
		mirror2Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Mancha."
		};
		boTrainBar = new string[5]
		{
			"Papá, ¿podemos irnos de aquí?",
			"Huele a caca...",
			"Perdón...",
			"Huele a...",
			"Heces..."
		};
		boTrainBarChoice1 = new string[4]
		{
			string.Empty,
			"Claro.",
			string.Empty,
			string.Empty
		};
		boTrainBarChoice2 = new string[5]
		{
			string.Empty,
			"¡Habla bien!",
			string.Empty,
			string.Empty,
			"¡Bo!"
		};
		boJumpingBean = new string[8]
		{
			"Pareces un frijol saltarín, Sherlock.",
			"'Salta, salta, saltarín, aquí viene el frijolín'.",
			"'Boing, boing, din, don, din'.",
			"'Es un pequeñín con una bocina, con una bocina'.",
			"Me encanta ese programa.",
			"Es un programa malísimo...",
			"¡No sabía que te gustara, Sherlock!",
			"¡Pensaba que solo te gustaba el humo e investigar homicidios!"
		};
		boJumpingBeanChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vale"
		};
		boJumpingBeanChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Y a mí!"
		};
		boTrainButtonSolution = new string[4]
		{
			"No quiero... faltarte al respeto ni nada por el estilo...",
			"Pero... ¿sabes lo que te haces?",
			"¡Pues entonces me alegro de que seamos compañeros de investigación, Sherlock!",
			"¡Tú pulsa los botones cuando estén los dos en amarillo!"
		};
		boTrainButtonSolutionChoice1 = new string[4]
		{
			string.Empty,
			"¡Pues claro!",
			string.Empty,
			string.Empty
		};
		boTrainButtonSolutionChoice2 = new string[4]
		{
			string.Empty,
			"Pues no...",
			string.Empty,
			"¡Bien pensado, Watson!"
		};
		bo2 = new string[1]
		{
			"¡Mira, papá, un globo!"
		};
		bo2Choice1 = new string[1]
		{
			string.Empty
		};
		bo2Choice2 = new string[1]
		{
			"¡Para, Bo!"
		};
		bo3 = new string[3]
		{
			"Pobre Georgie...",
			".........................................................",
			"Tan guardadito en su caja..."
		};
		bo3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bo3Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Vale."
		};
		bo32 = new string[3]
		{
			"...................",
			"Seguramente pueda oler las migas crujientes de tu chaqueta...",
			"No me parece bien atormentarlo así..."
		};
		bo33 = new string[3]
		{
			".......................",
			"A Georgie le gustan los Crujientes Corazón de León, de la tienda de Martin, los de sabor a carne...",
			"Y no le has traído ninguno, así que quizás ya deberías estar volviendo..."
		};
		pinstripeTrain1 = new string[7]
		{
			"Buenos días, Ted...",
			"¿Y esta chica quién es?",
			"Hola, Bo...",
			"¿Te gustan los globos?",
			"¿Qué te parece uno negro brillante?",
			"Solo un hombre amable...",
			"Con un globo negro brillante..."
		};
		pinstripeTrain1Choice1 = new string[7]
		{
			"Eh...",
			string.Empty,
			string.Empty,
			string.Empty,
			"No, gracias...",
			string.Empty,
			string.Empty
		};
		pinstripeTrain1Choice2 = new string[7]
		{
			"¿Buenos días?",
			"Em... esta es Bo.",
			string.Empty,
			string.Empty,
			"¿Y tú quién eres?",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2 = new string[4]
		{
			"Ah, y Bo...",
			"Me gusta tu vestido...",
			"Aaay... eso no es nada amable...",
			"Bo, tienes un padre de lo más maleducado..."
		};
		pinstripeTrain2Choice1 = new string[4]
		{
			string.Empty,
			"Vamos, Bo...",
			string.Empty,
			string.Empty
		};
		pinstripeTrain2Choice2 = new string[4]
		{
			string.Empty,
			"Déjanos en paz, imbécil.",
			string.Empty,
			"Vamos, Bo."
		};
		pinstripeHanglyPass = new string[10]
		{
			"Hola, Ted...",
			"Aaay... te has juntado con esa bola de naftalina apestosa de Dicky para que te ayude a encontrar a Bo...",
			"Mi disposición me dice que la espalda del pobre Dicky es tan fuerte como...",
			"... una estúpida marioneta de madera...",
			"Por eso, creo que Bo pasará un poquito de tiempo conmigo en mi casita parroquial...",
			"Sí... Creo que eso es justamente lo que vamos a hacer...",
			"¡Maldito bicho raro de aspecto estúpido!",
			"¿Perdona?",
			"¿Perdona, cara joroba?",
			"Con lo idiota que eres, no me extraña que hayas acabado en las asquerosas filas de los malditos..."
		};
		pinstripeHanglyPassChoice1 = new string[11]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"(Contén la lengua.)",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeHanglyPassChoice2 = new string[7]
		{
			"¡Llévame con Bo!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¿Cuántos años tienes, diez?"
		};
		pinstripeCave = new string[7]
		{
			"Hola, Ted...",
			"Tengo que decir... Eso me ha impresionado...",
			"Por desgracia, Bo lleva un tiempo...",
			"... en mi casa parroquial...",
			"Me muero de ganas de ver esa cara tuya tan bonita en la ceremonia...",
			"¡La ceremonia de adopción, TONTO DEL HABA!",
			"Hasta luego, grandullón..."
		};
		pinstripeCaveChoice1 = new string[8]
		{
			string.Empty,
			"Vale",
			string.Empty,
			string.Empty,
			"Vale.",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveChoice2 = new string[8]
		{
			string.Empty,
			"¿Dónde está Bo?",
			string.Empty,
			string.Empty,
			"¿Qué ceremonia?",
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExit = new string[10]
		{
			"¿Te han gustado mis mensajes en las paredes?",
			"No pude evitarlo, Ted.",
			"¡Bo es mía, BOLA DE PUS!",
			"'¡Papá, papá, sálvame!'",
			"Jo, jo, jo, jo.......... ¡Lo siento, Bo!",
			"¡Tu papá está dando vueltas como un POLLO SIN CABEZA!",
			"Ja, ja, ja, ja...........................",
			"¡Me muero de ganas de que LLEGUE LA CEREMONIA!",
			"Tu pálida carita de niño blanquito se va a llenar de lágrimas, Ted...",
			"Y mi carne se llenará de alegría cuando lo vea..."
		};
		pinstripeCaveExitChoice1 = new string[10]
		{
			"No.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeCaveExitChoice2 = new string[10]
		{
			"Sí.",
			"¡Llévame junto a Bo!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill = new string[9]
		{
			"Llegas justo a tiempo para la ceremonia, Ted.",
			"Aaayyy... ¡no seas tan AGUAFIESTAS!",
			"Siendo sinceros, Bo será mucho más feliz conmigo...",
			"Así que, ¿te quedarás para la ceremonia?",
			"El tiempo corre, Ted...",
			"¡PEQUEÑO IDIOTA ESTÚPIDO!",
			"Inténtalo.",
			"Pero como no recuerdes el bendito día en que moriste...",
			"Me temo que Bo será mía para siempre..."
		};
		pinstripeWindmillChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			",(Contén la lengua).",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmillChoice2 = new string[10]
		{
			"¡Deja libre a Bo!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Vas a pagar por esto, cerdo!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2 = new string[8]
		{
			"Aaayyy... te acabas de perder la ceremonia, Ted...",
			"Mira qué carita tan dulce tiene...",
			"¿Hay algo que quieras decir, cariño?",
			"Vuelve a casa, Ted...",
			"Ahora tengo a un nuevo papá...",
			"Él cuidará de mí y me quiere mucho...",
			"¡SE ACABÓ, TED!",
			"Qué pena que no se pueda volver a atrás en el tiempo."
		};
		pinstripeWindmill2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vale.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		pinstripeWindmill2Choice2 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Bo, ¡soy yo!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrain = new string[8]
		{
			"¿Quieres jugar a los trenes conmigo, Ted?",
			"Tú puedes ser el maquinista...",
			"El maquinista chupilerendi...",
			"¿Tu niñita está arriba?",
			"¿Quemándose y muriéndose?",
			"¡Perro LADRADOR idiota!",
			"Ahora vivo aquí, chico...",
			"Con mi nuevo papá..."
		};
		boWithTrainChoice1 = new string[10]
		{
			"¡Claro!",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boWithTrainChoice2 = new string[3]
		{
			"¡Bo, vamos!",
			"¡Venga, Bo!",
			string.Empty
		};
		hiveTrain = new string[3]
		{
			"..................... ¡Qué asco!",
			"Parece un saco gigante...",
			"Se me revuelven las tripas..."
		};
		hiveTrain2 = new string[2]
		{
			"Papá, creo que deberías dejar de oler esa cosa...",
			"Parece que te sienta mal..."
		};
		hiveTrain3 = new string[4]
		{
			"¡Mira lo que has conseguido, papá!",
			"¡Mamá no estaría nada contenta contigo!",
			"Siempre me decía que no oliera cosas de olor extraño...",
			"Como esa cosa marrón que me encontré debajo del frigorífico..."
		};
		scarf = new string[3]
		{
			"La bufanda de Bo...",
			"Huele a humo...",
			"... y a güisqui..."
		};
		scarfChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		scarfChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Coger."
		};
		bigTree = new string[2]
		{
			"......Dameee.......",
			"......de comeeer......."
		};
		bigTreeChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		bigTreeChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Dar de comer"
		};
		oldManV2 = new string[12]
		{
			".....¡oh!....",
			"¿Ted?",
			"¿Es que no reconoces esta cara tan sexi, malnacido? Soy yo... El Sr. Dicky...",
			"Vete de aquí, chico...",
			"Bienvenido al infierno, chico. ¡Ahora, lárgate!",
			"......Pinstripe......",
			"¡Creo que ya sé dónde está, Ted!",
			"... Hangly House...",
			"No tengo muy claro cómo piensas defender ese cuerpo tan estúpido que tienes sin una buena arma...",
			"Hasta que consigas una, me temo que no puedo ayudarte...",
			"No estaba llorando, estaba...",
			"Eh... riéndome......"
		};
		oldManV2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Gracias, amable señor!"
		};
		oldManV2Choice2 = new string[10]
		{
			"¡Ayuda!",
			"¿Nos conocemos?",
			string.Empty,
			"Pero ¡necesito ayuda!",
			"¡Mi niña ha sido secuestrada!",
			"¿Quién?",
			string.Empty,
			string.Empty,
			string.Empty,
			"Bueno, pues entonces eres un llorón..."
		};
		oldManV22 = new string[5]
		{
			"¿Qué estás mirando?",
			"¿Mis verrugas? Tengo verrugas frescas y supurantes en la coronilla. ¡Pero son genéticas, te lo juro!",
			"Mi madre siempre me decía que eran un regalo de Dios...",
			"Pero yo quería que el Dr. Shrenweld me las quitara, porque siempre supe que Birdy era demasiado guapa para mí...",
			"Siempre tuve el aspecto de un payaso deforme, durante toda la primaria..."
		};
		oldManV23 = new string[5]
		{
			"¡Estas verrugas no forman parte de ningún circo!",
			"¿Acaso pueden montar en monociclo, idiota? ¿Eh?",
			"¿O pueden domar a fieras de cuatro patas? ¡No! ¡No!",
			"¿Tú hija no había sido secuestrada? Y tú te quedas... contemplando...",
			"¡Tratando a mis verrugas como si fueran una maldita función de circo!"
		};
		hive = new string[2]
		{
			"Uno de esos sacos...",
			"... con su maravillosa fragancia."
		};
		hiveChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		hiveChoice2 = new string[2]
		{
			string.Empty,
			",Coger."
		};
		felix1 = new string[5]
		{
			".......................................................¡Oye!",
			"¡Aquí arriba!",
			"¿Qué diablos haces vestido como un maldito predicador?",
			"....................................",
			"¿Has probado estos sacos?"
		};
		felix1Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		felix1Choice2 = new string[5]
		{
			"Hola...",
			string.Empty,
			"Um...",
			string.Empty,
			"No."
		};
		felixHurt = new string[3]
		{
			"................................",
			".................Ugh............... no mola, tío.",
			"......Arh......... eso ha herido mis sentimientos..."
		};
		felixHurtChoice1 = new string[2]
		{
			string.Empty,
			"¡Perdón!"
		};
		felixHurtChoice2 = new string[2]
		{
			string.Empty,
			"Supongo que te ha dolido, ¿no?"
		};
		drunkMan3 = new string[5]
		{
			"............................",
			"Este Pinstripe tiene clase...",
			"Tiene clase de verdad...",
			"..........................................................................................................................................",
			"¿Has oído eso?"
		};
		drunkMan3Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"¡Si tú lo dices, tío!"
		};
		drunkMan3Choice2 = new string[3]
		{
			"Hola de nuevo.",
			string.Empty,
			"Hueles un poco mal."
		};
		poolTableMan = new string[3]
		{
			"Sal de la mesa, imbécil.",
			"Estoy en medio de una partida...",
			"Que seas padre no te convierte en mi papá. Te he dicho que salgas de la mesa, imbécil..."
		};
		poolTableManChoice1 = new string[4]
		{
			string.Empty,
			"Lo siento mucho.",
			string.Empty,
			string.Empty
		};
		poolTableManChoice2 = new string[4]
		{
			string.Empty,
			"Tu aliento...",
			string.Empty,
			string.Empty
		};
		dog2 = new string[10]
		{
			"¡Gracias, Ted!",
			"Me preguntaba si alguna vez podría salir de ahí dentro...",
			"Eh... ¿Dónde está Bo?",
			"Ughhh... Eso es lo que me temía.",
			"Bueno, tenemos que encontrarla, tío...",
			"Quizás pueda olfatear más pistas, o algo...",
			"Hablando del tema, ¿el Sr. Dicky anda por aquí?",
			"Sí....... Podría oler el culo de ese tío a kilómetros...",
			"Ese Pinstripe...",
			"¡Es un gilipollas!"
		};
		dog2Choice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vale",
			string.Empty,
			"¡Lo siento, tío!"
		};
		dog2Choice2 = new string[10]
		{
			"¿Puedes hablar?",
			string.Empty,
			"¡Pinstripe la raptó!",
			string.Empty,
			"¡Vamos allá!",
			string.Empty,
			"Sí",
			"¿Por qué te habían encerrado?",
			string.Empty,
			"Tú eres gilipollas..."
		};
		dogBoSmell = new string[7]
		{
			"¡Hala!",
			"¿Hueles eso, Ted?",
			"Huele a... manzanas...",
			"A mí no tanto...",
			"Me encanta el queso, la tarta y cualquier cosa que huela a carne...",
			"Sí....................................... perdón.",
			"Vamos."
		};
		dogBoSmellChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			"Vale.",
			string.Empty,
			string.Empty
		};
		dogBoSmellChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			"A Bo le encantan las manzanas.",
			"Umm.",
			string.Empty
		};
		dog3 = new string[2]
		{
			"Ted...",
			"Ve a buscar a Bo..."
		};
		dogPraise1 = new string[1]
		{
			"¡Bien pensado, Ted!"
		};
		dogBalloonPop = new string[3]
		{
			"¡Ah! ¡Tío! Se me sale el corazón del pecho cada vez que explotas un globo.",
			"¿Te importaría... no... hacerlo?",
			"Así que así es cómo van a ser las cosas, ¿eh?"
		};
		dogBalloonPopChoice1 = new string[2]
		{
			string.Empty,
			"¡Lo siento, George!"
		};
		dogBalloonPopChoice2 = new string[2]
		{
			string.Empty,
			"Um... no."
		};
		dogBalloonPop2 = new string[3]
		{
			"¡UAH!",
			"¡Ted! Los globos...",
			"¿En serio?"
		};
		dogBalloonPop2Choice1 = new string[2]
		{
			string.Empty,
			"¡Lo siento!"
		};
		dogBalloonPop2Choice2 = new string[2]
		{
			string.Empty,
			"Juas."
		};
		recordPlayer1 = new string[3]
		{
			"Este tocadiscos está cubierto de plumas rojas...",
			"El disco se llama 'Miss Birdy Bondette: Intermezzos & otras contemplaciones'.",
			"Esta canción se llama 'La última sonrisa'."
		};
		recordPlayer1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer1Choice2 = new string[3]
		{
			string.Empty,
			"Reproducir",
			string.Empty
		};
		recordPlayer12 = new string[2]
		{
			"Una música preciosa...",
			"El cielo de los perros debe ser algo así..."
		};
		recordPlayer12Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer12Choice2 = new string[3]
		{
			string.Empty,
			"Vale.",
			string.Empty
		};
		recordPlayer2 = new string[3]
		{
			"¡Oye! ¡Es uno de esos discos de Miss Birdy que tanto ponen la piel de gallina!",
			"¡Vamos a escucharlo, Ted!",
			"'El último paseo'........... qué título más triste..."
		};
		recordPlayer2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer2Choice2 = new string[3]
		{
			string.Empty,
			"Reproducir",
			string.Empty
		};
		recordPlayer22 = new string[2]
		{
			"Ummmmmmmmmmmmmmm........................ Qué preciosidad. Ojalá oliera como suena.",
			"Pero solo huele a abuelas..."
		};
		recordPlayer22Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer22Choice2 = new string[3]
		{
			string.Empty,
			"Vale.",
			string.Empty
		};
		recordPlayer3 = new string[4]
		{
			"Otro de los discos de Miss Birdy...",
			"Le han clavado una nota...",
			"'Teddy, esta canción la compuse para Bo. Lamento mucho tu pérdida. — Miss Birdy'",
			"Se llama... 'The Last Hug'."
		};
		recordPlayer3Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer3Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Reproducir",
			string.Empty
		};
		recordPlayer32 = new string[3]
		{
			"Es tan... triste...",
			"Todavía podemos rescatar a Bo... ¿verdad?",
			"Todo va a salir bien, Ted..."
		};
		recordPlayer32Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		recordPlayer32Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dogRecordPlayer = new string[1]
		{
			"Esta canción da miedo..."
		};
		dogRecordPlayerChoice1 = new string[1]
		{
			string.Empty
		};
		dogRecordPlayerChoice2 = new string[1]
		{
			"Sí."
		};
		dogPoop = new string[4]
		{
			"Ugh......... Caca de Señorita...",
			"Si la ves... tienes que saltar sobre ella, tío...",
			"Un momento, un momento, un momento...",
			"¿Soy un perro que habla y lo que te preocupa es mi acento?"
		};
		dogPoopChoice1 = new string[2]
		{
			string.Empty,
			"¡Gracias por el consejo!"
		};
		dogPoopChoice2 = new string[2]
		{
			string.Empty,
			"¿Y qué pasa con tu acento, idiota?"
		};
		dogMushroom = new string[5]
		{
			"Una seta brillante...",
			"Esta huele especialmente a queroseno...",
			"Oye, Ted. ¿Te suena haber visto cosas de estas por todo Edge Wood y Hangly Pass?",
			"No sé... quizás podamos encontrar algunas gotas congeladas si les prendemos fuego o algo...",
			"Solo intento ayudar..."
		};
		dogMushroomChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Bien pensado, George!"
		};
		dogMushroomChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Sí, ¿y?",
			"Um... oh."
		};
		dogCaveJumpComment = new string[1]
		{
			"¡Lo has clavado!"
		};
		dogCaveJumpCommentChoice1 = new string[1]
		{
			string.Empty
		};
		dogCaveJumpCommentChoice2 = new string[1]
		{
			"¡Gracias!"
		};
		caves = new string[2]
		{
			"Esta cueva tiene un aspecto malvado y sombrío...",
			"Es negra como boca de lobo y no se ve nada..."
		};
		caves2 = new string[2]
		{
			"Se escucha un sonido horripilante procedente de las profundidades...",
			"..........................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................................."
		};
		flashLightTalk = new string[3]
		{
			"¡Bonito foco!",
			"Está llena de algo así como... flores pintarrajeadas...",
			"Selecciona el icono para encenderla y apagarla."
		};
		flashLightTalkChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		flashLightTalkChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Coger."
		};
		lewis = new string[5]
		{
			"......Ughhh....oooohh......oooooohhh....",
			"¡Me duele un montón la espalda!",
			"Escucha, mocoso, no tenemos mucho tiempo...",
			"Ehhh........ Bo está más arriba en la montaña... en la... Hangly House...",
			"Lo que me gustaría verte escalar esta montaña a mi edad con esas piernas remilgadas que tienes..."
		};
		lewisChoice1 = new string[5]
		{
			string.Empty,
			"¡Lo siento!",
			string.Empty,
			"Vale.",
			string.Empty
		};
		lewisChoice2 = new string[5]
		{
			"¿Estás bien, Dicky?",
			"Ya estás mayor.",
			string.Empty,
			"¿No vienes?",
			"Vale."
		};
		lewis2 = new string[4]
		{
			"Estás dando vueltas como un pollo sin cabeza...",
			"Cuando tenía tu edad, trabajaba unas 80 horas a la semana en la siderúrgica de mi padre...",
			"Me daba puñetazos todos los días...",
			"Yo... Todavía tengo cicatrices..."
		};
		oldManStartWalking = new string[4]
		{
			"¡¿Por qué has tardando tanto, pedazo de tortuga?!",
			"Nos vemos arriba, en Hangly House...",
			"¡Ya te lo he dicho! Hangly House... nada más subir la montaña...",
			"Seguro que es ahí donde Pinstripe tiene encerrada a Bo..."
		};
		oldManStartWalkingChoice1 = new string[4]
		{
			string.Empty,
			"Vale.",
			string.Empty,
			"¡Allí nos vemos!"
		};
		oldManStartWalkingChoice2 = new string[4]
		{
			string.Empty,
			"¿Dónde?",
			string.Empty,
			"Muy bien. Buf, viejo..."
		};
		key = new string[2]
		{
			"Una llave plateada...",
			"Tiene una 'P' pequeña tallada en el mango..."
		};
		keyChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		keyChoice2 = new string[2]
		{
			string.Empty,
			",Coger."
		};
		goldKeyTalk = new string[1]
		{
			"Una llave dorada..."
		};
		rifle = new string[4]
		{
			"Un viejo rifle...",
			"Ja, genial...",
			"Se llama 'el pájaro cantor infinito'... lo tiene grabado en la culata...",
			"¿Por qué se llamará así?"
		};
		rifleChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		rifleChoice2 = new string[4]
		{
			"¡Bien!",
			string.Empty,
			string.Empty,
			"¡Tómala!"
		};
		oldWomanPorch = new string[8]
		{
			"Madre mía...",
			"¿Osito Teddy? ¿Eres tú?",
			"¡Me alegro de verte, Teddy!",
			"¿Donde está mi amiguita Bo?",
			"Ay, ¿en serio?",
			"Dicky te la ha colado, me temo...",
			"En fin... ¿me vas a sacar de aquí o qué?",
			"Je, je, je... ¡muy buena!"
		};
		oldWomanPorchChoice1 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Claro!"
		};
		oldWomanPorchChoice2 = new string[8]
		{
			string.Empty,
			"¿Sí?",
			string.Empty,
			"Dicky dijo que estaba aquí...",
			string.Empty,
			"Oh...",
			"No, gracias, pedo de paloma.",
			string.Empty
		};
		dogBirdyCommentNice = new string[10]
		{
			"¿Imagino que lo has hecho a posta?",
			"Aun así, creo que la has matado...",
			"Al menos fuiste amable con ella antes de que se despeñara...",
			"Era una anciana muy dulce.",
			".........Um.........",
			"Para Miss Birdy...",
			"Que su alma vuele... por siempre jamás...",
			"Atravesando los cielos...",
			"Hasta las estrellas...",
			"Amén..."
		};
		dogBirdyCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Sí que lo era..."
		};
		dogBirdyCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Di unas palabras, George."
		};
		dogBirdyCommentMean = new string[6]
		{
			"Tío... ¡la has matado!",
			"¡Primero la llamas pedo de paloma, ¿y ahora esto?!",
			"Sí... A ver, no me entiendas mal...",
			"Sí que olía a pedo de paloma...",
			"Pero ¡qué más da!",
			"¡Acabas de cargártela!"
		};
		dogBirdyCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			"Lo siento...",
			string.Empty,
			string.Empty
		};
		dogBirdyCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			"Olía a pedo.",
			string.Empty,
			"Sí..."
		};
		dogBarCommentMean = new string[6]
		{
			"Macho, a ese tío lo has mosqueado de verdad...",
			"De ahora en adelante tú solo... actúa como si fueras uno más...",
			"No es el mejor momento para que te dejen inconsciente de un golpe, ¿verdad?",
			"Vas a la última, marcando tendencia, Ted...",
			"Pero tus brazos son...",
			"... esqueléticos..."
		};
		dogBarCommentMeanChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Creo que tienes razón...",
			string.Empty
		};
		dogBarCommentMeanChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"¡Puedo con ellos!",
			string.Empty
		};
		dogBarCommentNice = new string[4]
		{
			"Em... ¿lo dices en serio?",
			"¿De veras piensas salir de fiesta con todo el mundo en una noche como esta?",
			"Ted... ¿qué pasa con Bo?",
			"Sí, no mola nada, tío..."
		};
		dogBarCommentNiceChoice1 = new string[4]
		{
			string.Empty,
			"¡Pues claro que no!",
			string.Empty,
			string.Empty
		};
		dogBarCommentNiceChoice2 = new string[4]
		{
			string.Empty,
			"¡Claro!",
			"Sí...",
			string.Empty
		};
		floatingPeople = new string[18]
		{
			"Je, je, je, je... ¡Ay, Teddy! ¡Eso ha sido la caña!",
			"Pero Dicky quiere decirte algo, ¿verdad, Dicky?",
			"Ughhh... Te he mentido... pero ha sido porque necesitaba ayuda para encontrar a mi pequeña Birdy...",
			"Pinstripe vive en Red Wash...",
			"... un lago que se encuentra en el corazón del infierno.",
			"Seguramente haya encerrado a tu dulce Bo en su horrible casa parroquial...",
			"Para llegar hasta allí vas a necesitar luz...",
			"... A ver si todavía tengo...",
			"... Ah, sí, aquí está...",
			"Una noche Bo me dio este trozo de papel de lo más raro después de haber estado jugando con ella un rato...",
			"Me pregunto si te podría valer para encontrar luz...",
			"Puedes examinar la pista más tarde si se te olvida...",
			"¿Ves el ICONO DE PISTA que aparece iluminado en la parte inferior de la pantalla?",
			"Ahí puedes consultar todas las PISTAS que hayas encontrado...",
			"Examínalas cuidadosamente...",
			"En fin...",
			"Nos vemos en Red Wash...",
			"Seguro que encontraremos a Bo, cariño..."
		};
		floatingPeopleChoice1 = new string[14]
		{
			string.Empty,
			"No pasa nada, Dicky...",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		floatingPeopleChoice2 = new string[18]
		{
			"Sí.",
			"Desembucha, escoria...",
			"¿Y dónde está Bo?",
			string.Empty,
			string.Empty,
			"Vale.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Gracias.",
			string.Empty,
			"Sí.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vale."
		};
		dogHintChest = new string[5]
		{
			"¡Ted! ¿Te acuerdas de ese cofre de juguete que había en el árbol de Edge Wood?",
			"Quizás tenga algo que ver con las pistas de Miss Birdy para conseguir la luz...",
			"La luz que necesitas para llegar a Red Wash...",
			"Revisa bien todas las pistas, tío...",
			"¿Ves el icono de pista de la parte inferior de la pantalla?"
		};
		dogHintChestChoice1 = new string[3]
		{
			string.Empty,
			"Vale.",
			string.Empty
		};
		dogHintChestChoice2 = new string[3]
		{
			string.Empty,
			"¿Qué luz?",
			string.Empty
		};
		telephone = new string[3]
		{
			"............. Papá...",
			"¿Eres tú?",
			"............................................. ¡Ayúdame, papá!"
		};
		pinstripeManBoss = new string[3]
		{
			"¡MONTÓN DE MIERDA!",
			"¡Has interrumpido nuestra unión perfecta y preciosa!",
			"¡¡¡¡¡Arde, PEQUEÑO TEDDY!!!!!"
		};
		houseLockedGold = new string[1]
		{
			"La puerta está cerrada con un candado dorado..."
		};
		houseLockedMechanism = new string[1]
		{
			"La puerta está cerrada con un mecanismo..."
		};
		houseLockedMechanismChoice1 = new string[1]
		{
			string.Empty
		};
		houseLockedMechanismChoice2 = new string[1]
		{
			"Examinar."
		};
		houseLockedSilver = new string[1]
		{
			"La puerta está cerrada con un candado plateado..."
		};
		houseLocked2 = new string[1]
		{
			"La puerta está cerrada..."
		};
		sign1 = new string[2]
		{
			"Arriba: Hangly Pass",
			"Abajo: Red Wash"
		};
		sign2 = new string[1]
		{
			"Hacia Red Wash"
		};
		signPissward = new string[2]
		{
			"'Hacia Red Wash...'",
			"'Compra billetes a Happy'."
		};
		signBalloonShop = new string[4]
		{
			"'Queda estrictamente prohibido consumir mis setas de velocidad'.",
			"'Los efectos secundarios se componen de nauseas, diarrea, pensamientos suicidas...'",
			"'O una mejora de +1 de la VdD (velocidad de disparo) del jugador...'",
			"'¡Así que no lo hagas! — Tienda de globos de Princle'"
		};
		liftPower = new string[3]
		{
			"Un molino de agua o algo así...",
			"Parece que podría accionar el ascensor...",
			"Pero... ¿dónde está el agua?"
		};
		signPissward2 = new string[2]
		{
			"Parece una línea de gas...",
			"'La tubería de gas se extiende a Edge Wood, Hangly Pass, Sack Chute, Pissward Falls y Red Wash...'"
		};
		signPissward2Choice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signPissward2Choice2 = new string[2]
		{
			string.Empty,
			"Examinar."
		};
		signHappySafe = new string[2]
		{
			"¿Una caja fuerte gigante?",
			"'Ni se te ocurra, imbécil. — Happy'"
		};
		signHappySafeChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signHappySafeChoice2 = new string[2]
		{
			string.Empty,
			"Examinar."
		};
		signTimsShop = new string[2]
		{
			"Una nota garabateada...",
			"'Intentando dormir. Me despierto a las 8:10 p.m...'"
		};
		signTimsShopChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		signTimsShopChoice2 = new string[2]
		{
			"Examinar.",
			string.Empty
		};
		pisswardMan1 = new string[13]
		{
			"Hola, padre...",
			"Bienvenido a Pissward Falls, hogar de Pissy, la serpiente de Piss...",
			"Los billetes para el ascensor a Red Wash son 300 gotas congeladas...",
			"Gracias por la compra, padre...",
			"Ahhhh... qué bien...",
			".............. Oooh... esto mola... oooh, caray...",
			"Voy a llevar estas gotas a Red Wash y a ver si puedo planchar un poco la oreja...",
			"Llevo sin dormir...",
			"¿Cuánto hace ya?",
			"A saber...",
			"... Nada como darle un muerdo a estas gotas congeladas y dejar que te lleven al paraíso.",
			"Que dios bendiga a Pinstripe. Que dios bendiga su alma auténtica...",
			"Aquí tienes el billete, padre..."
		};
		pisswardMan1Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"No, gracias."
		};
		pisswardMan1Choice2 = new string[3]
		{
			"Hola.",
			string.Empty,
			"Comprar billete (300)."
		};
		happyEdgeWood = new string[14]
		{
			"Hola, padre...",
			"Soy yo, Happy...",
			"¡Ay, pero si me conoces, Ted!",
			"¿El amigo de Bo?",
			"Bueno, ahora mismo tienes una pinta particularmente húmeda y ansiosa...",
			"Me gustaría poder servirte algo, colega, pero para eso tendrás que ir a Red Wash...",
			"Pero podría venderte algo aun mejor al precio adecuado...",
			"Deberías comprar esta metralleta ilegal por 1000 gotas congeladas...",
			"Gracias por la compra, padre...",
			"Mira qué preciosidad...",
			"Una pipa como esta le vuelve a uno increíblemente sexi...",
			"Ojalá tuviera una cámara encima con la que sacar una foto para mi madre...",
			"En fin... que ya puedes ir a rescatar a tu niñita como todo un pandillero fresco y húmedo...",
			"A por ello, capitán..."
		};
		happyEdgeWoodChoice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"No, gracias."
		};
		happyEdgeWoodChoice2 = new string[8]
		{
			"¿Nos conocemos?",
			"¿Quién?",
			string.Empty,
			"No.",
			"¿Qué?",
			string.Empty,
			string.Empty,
			"Comprar (1000)."
		};
		happyHangly = new string[13]
		{
			"Hola, padre...",
			"Te puedo vender algunas cosillas al precio adecuado...",
			"Y ya que estamos, a tu cachorrín se le están congelando los pezones...",
			"¡Mira cómo tiembla!",
			"Deberías comprar este jersey para cachorros por 400 gotas congeladas...",
			"Gracias por la compra, padre...",
			"¡Qué monada! Mira qué culito, tan turgente y redondito...",
			"Ese jersey lo tejió a mano mi madre...",
			"Seguro que los pezones se le están empezando a humedecer ya, frescos y maduros...",
			"... en cualquier momento...",
			"Gracias por las gotas congeladas, a todo esto...",
			"Si vuelves a necesitar algo más, busca la cosita esa de la peluquería...",
			"Es amarilla y gira..."
		};
		happyHanglyChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"No, gracias."
		};
		happyHanglyChoice2 = new string[5]
		{
			"Hola.",
			string.Empty,
			string.Empty,
			string.Empty,
			"Comprar (400)."
		};
		happyCave = new string[10]
		{
			"Hola, padre...",
			"¿Qué te parece este sistema de cuevas?",
			"Bueno, parece que Pinstripe tiene algo montado aquí abajo...",
			"Sigue haciendo un frío de la hostia...",
			"Hubiera jurado por el aliento de mi madre que bajo tierra haría más calor...",
			"A todo esto, el Sr. Pinstripe me dio un traje de sobra...",
			"Un momento, a ver si puedo... eh... si puedo encontrarlo por aquí...",
			"Vale, vale. Ya, aquí está. Te vendo este traje de sobra por 500 gotas congeladas...",
			"Gracias por la compra, padre...",
			"........ ¡Eres clavadito a él, Ted!.........."
		};
		happyCaveChoice1 = new string[8]
		{
			string.Empty,
			"Da igual.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"No, gracias."
		};
		happyCaveChoice2 = new string[8]
		{
			"Hola, Happy.",
			"No me impresiona.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Comprar (500)."
		};
		timRedWash1 = new string[11]
		{
			"Hola, padre...",
			"Pues... en cuanto a esas gotas congeladas que me diste en Pissward...",
			"Bueno... parece que no llegaron a ponerme a dormir como pensaba...",
			"Así que escucha. Puedo ayudarte a recuperar a Bo de las garras de Pinstripe... pero necesito que me hagas un favor...",
			"Si me consigues 10 sacos... nada de gotas congeladas por esta vez, sino los sacos frescos, lo bueno de verdad...",
			"Te venderé un periódico... pero no un periódico cualquiera...",
			"Uno que contiene la contraseña de la casa parroquial de Pinstripe...",
			"En fin, ¿qué dices? Esos sacos son lo único que me servirá para dormir esta noche...",
			"Pinstripe va a entregar esos sacos a una hora preestablecida, padre...",
			"Así que aquí tienes una pequeña pista sobre cuándo ocurrirá...",
			"En cuanto encuentres los sacos, trámelos aquí para que no deje ni una gota de ellos..."
		};
		timRedWash1Choice1 = new string[18]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash1Choice2 = new string[10]
		{
			"Hola, Happy.",
			"¿Sí?",
			"Vale.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Claro!",
			string.Empty,
			"¡Vale!"
		};
		timRedWash2 = new string[10]
		{
			"Hola, padre...",
			"¿Quieres comprar un periódico por 10 sacos?",
			"Te mostrará la pista para poder acceder a la casa parroquial de Pinstripe...",
			"Gracias...",
			"Se hace tarde...",
			"Espero estar cerrando el chiringuito y planchando la oreja, si sabes lo que quiero decir...",
			"Dormir tranquilo y calentito en mi tienda mientras ruge esta tormenta...",
			"Es una locura... ¿qué has hecho, padre?",
			"En fin... la contraseña debería estar en ese periódico...",
			"...................... Buenas noches, padre..."
		};
		timRedWash2Choice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			"Aún no.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		timRedWash2Choice2 = new string[10]
		{
			"Hola, Happy.",
			string.Empty,
			"Comprar (10 sacos).",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapArea = new string[4]
		{
			"El tirachinas de juguete de Bo...",
			"En la madera lleva grabado 'Feliz cumpleaños, Bo'...",
			"Haz clic o mantén pulsado el gatillo para lanzar.",
			"Puedes romper cosas como esa caja..."
		};
		blunderBustTapAreaChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		blunderBustTapAreaChoice2 = new string[5]
		{
			"Examinar.",
			string.Empty,
			string.Empty,
			"Coger.",
			string.Empty
		};
		whiskey = new string[1]
		{
			"Una botella de güisqui..."
		};
		whiskeyChoice1 = new string[1]
		{
			string.Empty
		};
		whiskeyChoice2 = new string[1]
		{
			"Coger."
		};
		dan = new string[10]
		{
			"Propicias tardes...",
			"Bienvenido a Red Wash...",
			"Complejo vacacional del placer definitivo de Pinstripe.",
			"Firme el registro de invitados...",
			"Ummm... qué firma tan elegante...",
			"Recuerde que esta noche es especialmente especial...",
			"La ceremonia tendrá lugar cuando la luna esté llena...",
			"Pinstripe no encuentra un niño fresco y rollizo todos los días...",
			"Así que el Sr. Pinstripe ha solicitado que todos los lugareños sean testigos de...",
			"La adopción eterna del niño..."
		};
		danChoice1 = new string[10]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Gracias.",
			string.Empty,
			string.Empty,
			string.Empty
		};
		danChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¿Qué ceremonia?"
		};
		dan2 = new string[7]
		{
			"La ceremonia...",
			"La ceremonia me pone los circuitos como escarpias...",
			"Y hace que entren ganas de beber leche.",
			"¿Que tú ni siquiera qué?",
			"¿Que ni siquiera comprendes la capacidad de un buen vaso de leche calentita?",
			"Leche calentita, calentita y una ceremonia de adopción como nunca antes había visto...",
			"Evidentemente, tú no lo comprendes..."
		};
		dan2Choice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Vale."
		};
		dan2Choice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"A mí ni siquiera..."
		};
		dan22 = new string[1]
		{
			"Daniel quiere un poco de leche."
		};
		dan22Choice1 = new string[1]
		{
			string.Empty
		};
		dan22Choice2 = new string[1]
		{
			"Vale."
		};
		dan23 = new string[1]
		{
			"Calentar leche para la adopción."
		};
		dan23Choice1 = new string[1]
		{
			string.Empty
		};
		dan23Choice2 = new string[1]
		{
			"Vale."
		};
		dan24 = new string[1]
		{
			"Ojalá tuviera un chorro de leche calentita que echarme a la boca."
		};
		dan24Choice1 = new string[1]
		{
			string.Empty
		};
		dan24Choice2 = new string[1]
		{
			"Vale."
		};
		dan25 = new string[1]
		{
			"Imagina una piscina de leche en mi boca."
		};
		dan25Choice1 = new string[1]
		{
			string.Empty
		};
		dan25Choice2 = new string[1]
		{
			"Vale."
		};
		dan26 = new string[1]
		{
			"Leche."
		};
		dan26Choice1 = new string[1]
		{
			string.Empty
		};
		dan26Choice2 = new string[1]
		{
			"Vale."
		};
		dan27 = new string[1]
		{
			"..............................................................."
		};
		dan27Choice1 = new string[1]
		{
			string.Empty
		};
		dan27Choice2 = new string[1]
		{
			"¿Um?"
		};
		kitty2 = new string[4]
		{
			"Vaya, vaya...",
			"Tu pequeña tiene mucha energía...",
			"No te preocupes, Ted...",
			"Muy pronto me llamará 'padre'..."
		};
		kitty4 = new string[1]
		{
			"........."
		};
		signMegaGem = new string[7]
		{
			"................................ Una gota congelada negra y enorme...",
			"'Scoria Sackus de Moonstate: La mayor gota congelada registrada de Pinstripe...'",
			"'Excavada a 323 metros bajo el pozo de Red Wash, en la epidermis de un saco fosilizado'.",
			"'Valorada en 50 gotas congeladas'",
			"Huele a gomina fresca...",
			"Está muy bien, a decir verdad...",
			"Cántame una nana, Ada..."
		};
		signMegaGemChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Vale."
		};
		signMegaGemChoice2 = new string[4]
		{
			"Leer.",
			string.Empty,
			string.Empty,
			"Oler."
		};
		balloonMan1 = new string[11]
		{
			"Uhhhnngg... No te he dicho que pudieras entrar aquí a curiosear...",
			"Pero ¿sabes? Me alegra que lo hayas hecho. Porque ahora puedo fardar de mis máquinas de globos...",
			"Los críos de por aquí me llaman Princle, y soy el mejor creador de globos de la ciudad gracias a estas máquinas de globos...",
			"Pinstripe hizo un pedido de un lote completo de globos, y me ocupé de él en un santiamén...",
			"Sí... como en diez segundos...",
			"Ummmm... Estoy dispuesto a apostarte mi megagota congelada a que no consigues vencer a mis máquinas, que son demasiado rápidas y ágiles...",
			"¡Tu confianza se está multiplicando excesivamente, amigo mío!",
			"¡Prepárate para recibir la paliza del siglo!",
			"Preparados...",
			"Listos...",
			"¡YA!"
		};
		balloonMan1Choice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		balloonMan1Choice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Acepto la apuesta!"
		};
		balloonMan2 = new string[6]
		{
			"¡PERDEDOR!",
			"¿Quieres jugar de nuevo, padre?",
			"¡Más te vale tener bien a punto unas biodraminas!",
			"Preparados...",
			"Listooos...",
			"¡PRINCLE!"
		};
		balloonMan2Choice1 = new string[2]
		{
			string.Empty,
			"No, gracias."
		};
		balloonMan2Choice2 = new string[2]
		{
			string.Empty,
			"¡Vamos allá!"
		};
		balloonMan2b = new string[6]
		{
			"¡OH CAPITÁN, MI CAPITÁN!",
			"¿Quieres jugar de nuevo, capitán?",
			"¡Me muero de ganas de ver lo bien que lo haceeeees!",
			"Preparados...",
			"Listooos...",
			"¡PRINCLE!"
		};
		balloonMan2bChoice1 = new string[2]
		{
			string.Empty,
			"No, gracias."
		};
		balloonMan2bChoice2 = new string[2]
		{
			string.Empty,
			"¡Vamos allá!"
		};
		balloonMan3 = new string[5]
		{
			"¡¡¡¿¿¿CÓÓÓMOOO???!!!",
			"Eres... eres...",
			"¡Eres LA CAÑA! Las habilidades necesarias para derrotar a mis máquinas de globos...",
			"¡no tienen precedentes! No es posible...",
			"Toma el premio, padre... Vamos... tómalo..."
		};
		balloonMan3Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Qué amable por tu parte!"
		};
		balloonMan3Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Um... bah..."
		};
		savePortraitGronkh = new string[2]
		{
			"Otro retrato... de un varón de aspecto muy agresivo.",
			"..................................................Partida guardada."
		};
		savePortraitGronkhChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkhChoice2 = new string[1]
		{
			"Guardar partida."
		};
		savePortraitGronkh2 = new string[2]
		{
			"El retrato sigue teniendo un aspecto muy agresivo...",
			"..................................................Partida guardada."
		};
		savePortraitGronkh2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh2Choice2 = new string[1]
		{
			"Guardar partida."
		};
		savePortraitGronkh3 = new string[2]
		{
			"¡Cuánta agresividad! ¡Su agresividad traspasa el lienzo!",
			"..................................................Partida guardada."
		};
		savePortraitGronkh3Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh3Choice2 = new string[1]
		{
			"Guardar partida."
		};
		savePortraitGronkh4 = new string[2]
		{
			"El lienzo transmite una sensación de fiera agresividad. Quizás debido al varón agresivo...",
			"..................................................Partida guardada."
		};
		savePortraitGronkh4Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitGronkh4Choice2 = new string[1]
		{
			"Guardar partida."
		};
		savePortraitDirk = new string[2]
		{
			"Un retrato de un tipo bien peinado...",
			"..................................................Partida guardada."
		};
		savePortraitDirkChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitDirkChoice2 = new string[1]
		{
			"Guardar partida."
		};
		savePortraitRMannion = new string[2]
		{
			"Un retrato de alguien con aspecto de artista y a la moda...",
			"..................................................Partida guardada."
		};
		savePortraitRMannionChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitRMannionChoice2 = new string[1]
		{
			"Guardar partida."
		};
		savePortraitJHandville = new string[2]
		{
			"Un retrato de una cara de un hombre a un bigote pegado...",
			"..................................................Partida guardada."
		};
		savePortraitJHandvilleChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitJHandvilleChoice2 = new string[1]
		{
			"Guardar partida."
		};
		savePortraitNathanKingston = new string[2]
		{
			"Un retrato de un tío que se parece a Jesús, pero que no es Jesús. Mira, se llama Nathan.",
			"..................................................Partida guardada."
		};
		savePortraitNathanKingstonChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitNathanKingstonChoice2 = new string[1]
		{
			"Guardar partida."
		};
		savePortraitOchoma = new string[2]
		{
			"Un retrato frío y triste...",
			"..................................................Partida guardada."
		};
		savePortraitOchomaChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitOchomaChoice2 = new string[1]
		{
			"Guardar partida."
		};
		savePortraitBuddy = new string[2]
		{
			"Un extraño retrato de un hombre...",
			"..................................................Partida guardada."
		};
		savePortraitBuddyChoice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddyChoice2 = new string[1]
		{
			"Guardar partida."
		};
		savePortraitBuddy2 = new string[2]
		{
			"Sigue siendo un extraño retrato de un hombre... está calvo y tiene bigote...",
			"..................................................Partida guardada."
		};
		savePortraitBuddy2Choice1 = new string[1]
		{
			string.Empty
		};
		savePortraitBuddy2Choice2 = new string[1]
		{
			"Guardar partida."
		};
		creepyMan = new string[2]
		{
			"....... Ya debería estar aquí... ¿no?",
			"Ya debería estar aquí con más fruta..."
		};
		creepyMan2 = new string[2]
		{
			"¿Una bañera?",
			"Ted... Creo que aquí hay algo..."
		};
		creepyMan3 = new string[5]
		{
			"El viejo y la señora acaban de pasar por aquí hace un minuto...",
			"Dicen que vas a destruir a Pinstripe...",
			"¡No lo hagas!",
			"Es gracias a él que he podido disfrutar la vida aquí abajo...",
			"Debería de estar llegando ya... ¿no? Para darme más sacos..."
		};
		jack = new string[8]
		{
			"......ugh......... ¿Padre?",
			".....egh.... ¡Socorro!",
			"¡Este demonio me está devorando!",
			"No te estoy devorando......... Solo te estoy llevando a Red Wash.",
			"No te preocupes, cariño... Allí abajo no falta la diversión... Hay jugo de saco viscoso para beber día y noche...",
			"¿De verdad...?",
			"Eeeeh... ¡Entonces vale!",
			"¡Rápido! ¡Que no tenemos todo el día!"
		};
		jackChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		jackChoice2 = new string[7]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkard = new string[9]
		{
			"¿Vas a salir a celebrarlo después de la ceremonia, padre?",
			"Toma, bebe un poco del jugo de saco del Sr. Pinstripe para ir haciendo boca... ",
			"Ooohhh... Ummmm....",
			"Está bueno, sí... pero no tanto como el de verdad...",
			"Pinstripe va a ofrecer sacos frescos llenos de esto durante la ceremonia...",
			"Vas a darle un mordisco a la fruta prohibida con nosotros, ¿verdad, padre?",
			"¿Y si te abro la cabeza de un golpe?",
			"No hay nada peor que sentirse juzgado...",
			"Sobre todo por alguien tan patético como tú..."
		};
		drunkardChoice1 = new string[9]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Claro, me encantan las fiestas!",
			string.Empty,
			string.Empty,
			string.Empty
		};
		drunkardChoice2 = new string[6]
		{
			string.Empty,
			"OK.",
			string.Empty,
			string.Empty,
			string.Empty,
			"No, gracias, carita de ángel."
		};
		dickyBar = new string[11]
		{
			"Pssst...",
			"Ted... Soy yo...",
			"Soy yo, el Sr. Dicky...",
			"Aquí abajo hay que andarse con ojo...",
			"Pinstripe me mataría si me encontrara...",
			"Sobre todo si nos pilla ayudándote a encontrar a Bo, así que...",
			"Voy disfrazado...",
			".... Voy de payaso, Ted...",
			"¿No ves la nariz?",
			"Está escondida en el pozo de Pinstripe...",
			"Dijo que tenía una sorpresa para ti..."
		};
		dickyBarChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Sí.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarChoice2 = new string[22]
		{
			"Eh.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¿Dónde está Miss Birdy?",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2 = new string[6]
		{
			"¿Qué?",
			"No estarás viendo las verrugas que tengo en la coronilla, ¿verdad?",
			"¡Para! ¡Para!",
			"No soy ningún payaso...",
			"...................",
			"¡Déjame en paz!"
		};
		dickyBar2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBar2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		dickyBarNight = new string[6]
		{
			"¿Qué es lo que has hecho, Ted?",
			"Me duelen los huesos...",
			"Me parece que...",
			"Ted...",
			"Lo siento, pero me parece que se ha acabado...",
			"Que se ha acabado."
		};
		dickyBarNightChoice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vale."
		};
		dickyBarNightChoice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¿Qué?"
		};
		birdyBarrel = new string[9]
		{
			"Shhhhh... Je, je, je...",
			"Osito Teddy...",
			"Soy yo de nuevo...",
			"¡Rápido! Toma esta cuchara auténtica...",
			"Brilla y huele de una forma que me gusta bastante...",
			"Y es agradable al tacto, ¿a que sí?",
			"La necesitarás para derrotar a Pinstripe y rescatar a la pobre Bo...",
			"Pero no le digas a nadie que estoy aquí...",
			"No quiero que Pinstripe me vuelva a encerrar en aquella jaula..."
		};
		birdyBarrelChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Y tanto que sí!"
		};
		birdyBarrelChoice2 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Uf, gracias...",
			string.Empty,
			"Menuda estupidez..."
		};
		tokenInvite1 = new string[1]
		{
			"Un trozo de papel..."
		};
		tokenInvite1Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite1Choice2 = new string[1]
		{
			"Coger."
		};
		tokenInvite2 = new string[1]
		{
			"Un trozo de papel..."
		};
		tokenInvite2Choice1 = new string[1]
		{
			string.Empty
		};
		tokenInvite2Choice2 = new string[1]
		{
			"Coger."
		};
		tokenFilmStrip = new string[1]
		{
			"Un rollo de película secreto..."
		};
		tokenFilmStripChoice1 = new string[1]
		{
			string.Empty
		};
		tokenFilmStripChoice2 = new string[1]
		{
			"Coger."
		};
		tokenBible = new string[1]
		{
			"Una vieja biblia..."
		};
		tokenBibleChoice1 = new string[1]
		{
			string.Empty
		};
		tokenBibleChoice2 = new string[1]
		{
			"Coger."
		};
		tokenNotebook = new string[3]
		{
			"¿Cómo ha llegado esto aquí...?",
			"No lo mires, papá...",
			"Es solo un estúpido dibujo..."
		};
		tokenNotebookChoice1 = new string[2]
		{
			string.Empty,
			string.Empty
		};
		tokenNotebookChoice2 = new string[3]
		{
			string.Empty,
			string.Empty,
			"Examinar."
		};
		tokenPills = new string[1]
		{
			"Un tarro de pastillas vacío..."
		};
		tokenPillsChoice1 = new string[1]
		{
			string.Empty
		};
		tokenPillsChoice2 = new string[1]
		{
			"Coger."
		};
		tokenNewspaper = new string[1]
		{
			"Un periódico..."
		};
		tokenNewspaperChoice1 = new string[1]
		{
			string.Empty
		};
		tokenNewspaperChoice2 = new string[1]
		{
			"Coger."
		};
		tokenLocket = new string[3]
		{
			"¿Qué hacen todas tus cosas tiradas por esa puerta, papá?",
			"¿Y eso es...?",
			"¿Es el medallón de mamá?"
		};
		tokenLocketChoice1 = new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		};
		tokenLocketChoice2 = new string[3]
		{
			"No lo sé seguro...",
			string.Empty,
			"Examinar."
		};
		blackAndWhiteModeTalk = new string[4]
		{
			"¿En serio estás jugando a este juego otra vez?",
			"Este juego es un asco...",
			"En fin, ¿te gustaría jugar en modo supervintage al módico precio de 5 rollos de película?",
			"Enhorabuena. Acabas de pagar 5 rollos de película por perder todos los bellos colores de este juego..."
		};
		blackAndWhiteModeTalkChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			"No.",
			string.Empty
		};
		blackAndWhiteModeTalkChoice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			"Sí (5 rollos de película).",
			string.Empty
		};
		sackGeneratorExamine = new string[4]
		{
			"Se parece a los sacos esos con los alimentamos al árbol de Edge Wood... ¡pero en plan a lo bestia!",
			"Parece estar durmiendo o algo...",
			"Y huele a huevo...",
			"Bien..."
		};
		sackGeneratorExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGeneratorExamineChoice2 = new string[1]
		{
			"Examinar."
		};
		sackGenerator2Examine = new string[4]
		{
			"Otro de esos generadores de sacos...",
			"¡Uy!",
			"¡Madre mía, qué dientes!",
			"¡Ugh! Y este huele a eructo de alguien que ha tomado leche..."
		};
		sackGenerator2ExamineChoice1 = new string[1]
		{
			string.Empty
		};
		sackGenerator2ExamineChoice2 = new string[1]
		{
			"Examinar."
		};
		sackGenerator3Examine = new string[5]
		{
			"Otro...",
			"Quizás este fermente el jugo de saco o algo...",
			"No sé...",
			"Pero este huele a....................................................caca.",
			"Sí... ya lo siento, pero es a lo que huele, tío..."
		};
		sackGenerator3ExamineChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Tienes gracia, George..."
		};
		sackGenerator3ExamineChoice2 = new string[5]
		{
			"Examinar.",
			string.Empty,
			string.Empty,
			"Deja de hablar...",
			string.Empty
		};
		characterSucked = new string[1]
		{
			"............."
		};
		characterSuckedFelix = new string[2]
		{
			"Ted...",
			"¿Tengo algo en la cabeza?"
		};
		explainFire = new string[8]
		{
			"Hola, aguafiestas...",
			"No me juzgues...",
			"Me he portado bien, lo juro... Solo tenía un poco de sed...",
			"Nada como un trago de jugo de saco de Pinstripe...",
			"Me hace sentir especial de verdad...",
			"Dijo que habría más para celebrar la adopción de Bo...",
			"¿Y a ti qué te importa, idiota?",
			"Ni siquiera sabes cómo detener un coche..."
		};
		explainFireChoice1 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Vale.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		explainFireChoice2 = new string[22]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"¿Cuándo es la adopción?",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		redWashNotice = new string[7]
		{
			"Un aviso...",
			"'Los habitantes de Red Wash que asistan a la adopción de Bo...'",
			"¿'.. recibirán sacos de Pinstripe gratis...'?",
			"'Todos los habitantes que no asistan...'",
			"¿'recibirán insultos y............ latigazos enérgicos hasta que no puedan más...'?",
			"'¡Gracias y que pasen un buen día!'",
			"Qué bien........"
		};
		redWashNoticeChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Eso es terrible..."
		};
		redWashNoticeChoice2 = new string[6]
		{
			"Leer.",
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			"Este es el tipo de fiestas que me gusta."
		};
		potBellyMan = new string[7]
		{
			"Shhhhh... Je, je, je, je...",
			"¿O... oyes eso, padre?",
			"Es el megarreloj de Pinstripe...",
			"Tengo órdenes de no dejar que nadie lo toque...",
			"Nadie puede, bajo ninguna circunstancia...",
			"¡tocar el maldito reloj!",
			"No lo pillas................... ¿eh, colega?"
		};
		potBellyManChoice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"¡Lo entiendo!"
		};
		potBellyManChoice2 = new string[4]
		{
			string.Empty,
			"¿Cómo?",
			string.Empty,
			"Voy a hacer algo más que tocarlo..."
		};
		potBellyMan2 = new string[6]
		{
			"..................",
			"¿Has tocado el megarreloj?",
			"¿ES QUE NO HAS OÍDO LAS NORMAS?",
			"¡Otra vez no! ¡Otra vez no!",
			"El Sr. Pinstripe me va a dejar hecho un cromo...",
			"................................ ¡Otra vez!"
		};
		potBellyMan2Choice1 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Um... adiós..."
		};
		potBellyMan2Choice2 = new string[4]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"¿Qué ocurre?"
		};
		potBellyMan22 = new string[3]
		{
			"............... Ughhh...",
			"A ver...",
			"Que te dejen hecho un cromo es una cosa. Pero espero que aun así me dé mi saco..."
		};
		potBellyMan22Choice1 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		potBellyMan22Choice2 = new string[5]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			"Anda.",
			string.Empty
		};
		fork = new string[3]
		{
			"Un tenedor.",
			"Está oxidado y huele a monedas...",
			"Rociadas de.......................................... ¿loción?"
		};
		forkChoice1 = new string[6]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		forkChoice2 = new string[3]
		{
			"Examinar.",
			string.Empty,
			"Coger."
		};
		boHeaven1 = new string[3]
		{
			"¡Papá!",
			"¡Te he echado de menos!",
			"¿Quieres jugar fuera?"
		};
		boHeaven1Choice1 = new string[8]
		{
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty,
			string.Empty
		};
		boHeaven1Choice2 = new string[3]
		{
			"¡Bo!",
			"¡Yo a ti también!",
			"¡Sí!"
		};
		boHeaven2 = new string[2]
		{
			"¡Papá!",
			"¡Eso se parece al collar de mariposas de mamá!"
		};
		boHeaven2Choice1 = new string[1]
		{
			string.Empty
		};
		boHeaven2Choice2 = new string[1]
		{
			"¿Sí?"
		};
		boHeavenGeorge = new string[1]
		{
			"Ay.............. Ojalá estuviera Georgie aquí..."
		};
		boHeavenGeorgeChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenGeorgeChoice2 = new string[1]
		{
			"..."
		};
		boHeavenButterflies = new string[3]
		{
			"¡Anda! ¡Mira, papá!",
			"Ojalá mamá pudiera ver esto. Le encantaban las mariposas...",
			"¡Oye! ¡Seguro que no puedes cogerlas todas!"
		};
		boHeavenButterfliesChoice1 = new string[1]
		{
			string.Empty
		};
		boHeavenButterfliesChoice2 = new string[2]
		{
			string.Empty,
			"Sí..."
		};
		secretRoomCaveSign = new string[8]
		{
			"Una placa de piedra...",
			"'The Archbishop's Chamber:'",
			"'Dedicada al arzobispo electo.'",
			"'Como un relámpago...'",
			"'Y en un abrir y cerrar de ojos, la élite proporcionó la energía...'",
			"'Con la que iluminar y ampliar el mundo de Pinstripe.'",
			"'Disfruta de las gotas magnas carmesíes, valoradas en 200 gotas la unidad.'",
			"'(A todo esto, huelen como Glen).'"
		};
		secretRoomCaveSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomCaveSignChoice2 = new string[1]
		{
			"Examinar."
		};
		secretRoomTreeSign = new string[7]
		{
			"'Una placa de piedra..'",
			"'The Archbishop's Garden:'",
			"'Dedicada al arzobispo electo.'",
			"'Los humildes regalos de la élite...'",
			"'Eran una semilla de oro, que germinó en esta magnífica espina...'",
			"'Sírvete unas gotas Lemonree Statton, valoradas en 100 gotas cada una'.",
			"'(A todo esto, huelen a loción bronceadora aderezada con limones recién exprimidos).'"
		};
		secretRoomTreeSignChoice1 = new string[1]
		{
			string.Empty
		};
		secretRoomTreeSignChoice2 = new string[1]
		{
			"Examinar."
		};
	}
}
