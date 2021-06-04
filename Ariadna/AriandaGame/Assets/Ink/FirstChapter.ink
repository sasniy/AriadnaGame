-> start

=== start ===

Ночь, ты лежишь в кровати. Мозг как обычно не дает уснуть, генерируя все больше и больше странных вопросов и идей.
Среди прочих мыслей, возникает еще одна, на первый взгляд, такая же глупая. Ты разгоняешь ее и уже представляешь, как презентовал свой проект инвесторам, они согласились вложиться в него.
Представляешь, как начинаешь жить, став успешным предпринимателем. Твоя компания дожила до IPO, и ты теперь настолько богат, что сам можешь искать стартапы для инвестиций в них.
# sprite1
+ [Интересная идея, запишу, чтобы не забыть.]
    -> FirstChoise
+ [Лень тянуться к телефону. Если идея годная, и так о ней вспомню.] -> SecondChoise

=== FirstChoise ===
“Чуткий сон”
- Ххмх…
- “- Поздравляем! Вы успешно прошли акселерацию и теперь имеете возможность презентовать свой проект инвесторам”

- “- Эй, слушай, ты хорошо держишься на публике. Хорошее выступление”

- “- В нас собираются вложиться сразу 2 инвестора! Сейчас подпишем договор, а там и до IPO рукой подать!”

Б-рр, какой сон. Почаще бы такие снились. А может он был не просто так?
Но нет времени мечтать, 
# sprite2
+ [пора на работу.] -> Work

=== SecondChoise===
Записывать идеи - хорошая привычка. Обрати внимание на ToDoist(приложение). Ты даже не представляешь, сколько хороших идей остаются нереализованными только потому что их забывают.  
# sprite3
+ [Ок, буду иметь ввиду] -> FirstChoise

=== Work==
День проходит как обычно, но впереди еще будет совсем необычный вечер. Ты встречаешься с друзьями, вы культурно отдыхаете и наступает время для историй. И вот ты вспоминаешь про ту свою идею и
# sprite4
+ [решаешь рассказать о ней всем] -> SayAll

===SayAll===
Хм, а ты точно уверен в людях, сидящих вокруг? В Гарварде в начале 00х учился один предприимчивый еврейский студент. Он показал, что бывает, когда безответственно подходишь рассказам о своем стартапе). Ну да ладно, сейчас не об этом.

Обсуждение подхватили все и накидали много инсайтов, которые ты 
#sprite5
+ [конечно же записал и позже примешь во внимание] -> TookNote
+ [просто принял к сведению] -> badChoise



=== badChoise ====
Просто принял к сведению и забыл большинство уже к концу вечера?

#sprite6
+ [Ок, ок, теперь точно буду записывать] ->  TookNote

===TookNote===
Хм, ты заметил, что Паша как-то странно задумался и что-то записал к себе в телефон, когда вы только начинали разгонять предолженную тобой тему. Хотя, скорее всего, просто показалось. Отвлекся и отвлекся.
#sprite7
+ [Продолжаешь просто отдыхать после тяжелой недели] -> Chill

===Chill===
Хороший был вечер. Перед сном ты еще раз вспоминаешь про ту свою идею. Хоть и друзья, но все же другие люди оценили ее, это радует. 
#sprite8
+ [довольный собой ложишься спать] -> Sleep


===Sleep===

На следующий день Паша пишет:
"Надо обкашлять пару вопросиков) свободен сегодня вечером?"
Договариваетесь о встрече вечером: Паша заедет за тобой в 20.00
Чуть позже он написал еще и попросил одеться поприличнее. Похоже, что вчера он не просто так задумался.
А пока идешь выбирать "приличные" вещи и 
#sprite9
+ [ждешь вечера] -> Wait

===Wait===
Паша забрал тебя, вы поехали в сторону центра. Вы немного обсудили ту саму идею, уже называя ее стартапом. Потом Паша рассказал о своем приятеле Олеге, который уже неоднократно имел опыт в развитии бизнеса. Еще пара минут и ты соглашаешься с тем, что с Олегом стоит познакомитсья и начать новое дело вместе.
Хм, тебя просили хорошо одеться, вы едете в цетр обкашлять пару вопросиков и Паша рассказал об Олеге. Кажется, тебя везут на деловую встречу. 
#sprite10
+ [Паша, конечено, свой парень, но пахнет разводом. Все таки откажусь] -> Deny
+ [Не стоит спешить. Сначала познакомимся, а уже потом решим, стоит ли работать вместе] -> Friend



===Deny===
Развод? Стоит задуматься, какие люди находятся в твоем окружении. Да и если откажешься сейчас, Паша сможет организовать все без тебя, он уже слишком много знает.  
#sprite11
+ [Что ж, тогда придумаю новую идею, а в Паше я разочаровался. Не думал, что он на такое способен] -> alone
+ [Не стану спешить с выводами, может ошибаюсь. Сначала поужинаем вместе, а потом что-нибудь придумаю] -> Friend


===alone===
В таком случае, не стоит распространяться о том, что пришло в голову. Конечно, можно попробовать все делать самому, но, как показывает практика, уровень, достигаемый одиночками, всегда ниже того, что выдает группа людей (рекомендация почитать "Инноваторы" Уолтера Айзексона)
#sprite12
+ [ок] -> endFirstChapter


===Friend===
Паша говорит, что для этого вы сейчас и едете в центр.
Машина останавливается, вы выходите. 
"-Мы, конечно, не за инвестициями приехали, но все же будет хорошо, если не будешь тупить"
#sprite13
+ ["Постараюсь"] -> endFirstChapter

===endFirstChapter===

Конец первой части.
#sprite14

-> END




