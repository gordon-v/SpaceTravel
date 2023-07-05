# SpaceTravel

## Генерален опис
Апликацијата “space travel” не служи за ништо освен како визуализација за како би изгледало да патуваш низ вселената.
„Играта“ - ако може да ја наречеме така, се игра со тоа што се избира дестинација со помош на стрелкките од левата страна на интерфејсот нa dashboard-от, се притиска зеленото копче старт, при возење/летање може да се менуваат брзини, со која брзина се движите километрите ќе се намалуваат побргу или побрзо, а прогрес-барот ќе се полни соодветно. 

Кога километрите ќе стигнат до 0 и прогрес-барот ќе се исполни сте пристигнале до вашата дестинација и можете да изберете друга. 
Можете и да изберете друга дестинација кога сте на половина пат кон првичната, меѓутоа не можете да менувате дестинација додека сте во движење.

Решението е реализирано со листа од објекти од класата Star која има одреден број на ѕвезди кои се рециклираат.
## Опис на класата „Star”:

Класата Star ги чува следните податоци:

- **Width **и** Height** – големина на прозорецот, служи за изцртување на ѕвездите во одредени рамки.
  
- **X, Y, Z** – самообјаснувачки, служат за позиција на ѕвездата во „светот“. 

- **pX, pY, pZ** – злужат за чување на претходната позиција на ѕвездата.

- **MOD** – мод променливата е modifier со кој се добиваат следните 2 променливи, во зависност од тоа која е вредноста на оваа променлива (има различна вредност за секоја брзина), движењето на ѕвездите при WASD ќе бидe по изразенo или повеќе суптилнo.

- **xModifier, yModifier** -  вредности кои се додаваат на X и Y соодветно, за да се промени позиција  на сите ѕвезди при притискање WASD

- **radius** – радиус на ѕвездите. Се добива со тоа што Z вредноста во ранг од Width до 0, го мапира во релативен вредност во ранг од 0 до 4. Односно како се намалува Z вредноста и ѕвездата се „доближува“ нејзиниот радиус се зголемува од 0, до 4.

- **speed** – брзина со која се движат ѕвездите. Се update-ира при секое изцртување на ѕвездата.

- **r** – злужи за генерирање на рандом стартна позиција.

Сега ќе ги поминеме функциите:

`Reset()` - кога ѕвездата ќе излезе од рамките на прозорецот и повеќе нема да е видлива, се повикува ресет методот, кој на истата ѕвезда и дава нова позиција. Наместо да се создава нова ѕвезда, претходната се рециклира.

`Update()` - метод за движење односно „доближување“ на ѕвездите. Се update-ира Z вредноста со тоа што од неа се одзима брзината на движење. Ако Z е 0 тогаш ѕвездата е надвор од екранот и таа треба да се рециклира.

`SetModifiers (int speed)` – соодветно со тоа која брзина ја имаме избрано, MOD променливата има различна вредност. Колку побргу зе движиме толку е поголема оваа вредност. Потоа се смета вредноста која би требало да се додаде/одземе од  X и Y при притискање на WASD.
 
`Draw(Graphics g, int Speed, bool started)` – методот служи за изцртување на ѕвездата на прозорецот. При секој повик првично се повикува SetModifiers методот и се update-ира speed променливата која се добива како аргумент при повикување на овој метод. Потоа се проверува дали START копчето е притиснато и движењето е започнато (исто така се добива како аргумент при повикување). Ако движењето е започнато, се повикува Update методот, ако не тогаш ѕвездата останува на иста позиција. Се калкулира следната позиција за X, Y, a се чуваат претходните вредности, се ажурира радиусот, и се изцртуваат „трагови“ на ѕвездата, односно линија од нејзината претходна позиција, и моменталната.
## Слики:
![sc 1](https://github.com/gordon-v/SpaceTravel/assets/131365317/c8a61567-83aa-4214-ac32-ec56776aeb50)


![sc 2](https://github.com/gordon-v/SpaceTravel/assets/131365317/6c5524bf-721a-4d82-a504-ba328f001caf)
