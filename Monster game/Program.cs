/*
 * Игра начинается с того, что у нас имеются 2 игрока (playerOne, playerTwo) и монстр (monstr)
 * Игроку предоставляется возможность выбрать 2 атаки
 * Первая атака наносит n количество урона со 100% шансом
 * Вторая атака наносит n*2 количество урона с 17% шансом
 * Монстр же в свою очередь имеет от 100-150 ХП и также 2 типа атаки и пассивный навык (Моснтр бьет рандомного игрока)
 * Первая атака наносит n количество урона со 100% шансом
 * Вторая атака наносит n*2 по области с 17% шансом
 * Пассивный навык:Атака монстра с шансом 27% имеет эффект вампиризма равный 50% от нанесенного урона
 * Победить можно 2 способами
 * 1 способ: добить монстра
 * 2 способ: выжить
 */
//Вступительный экран
Console.WriteLine("                                          Добро пожаловать в Monster game!");
Console.WriteLine("Правила игры достаточно просты! Игра начинается с того, что у нас имеются 2 игрока и монстр!");
Console.WriteLine("Игроку предоставляется возможность выбрать одну из двух атак! ");
Console.WriteLine("Первая атака наносит от 17-27 количества урона со 100% шансом. ");
Console.WriteLine("Вторая атака наносит n*2 количество урона с 17% шансом");
Console.WriteLine("Монстр же в свою очередь имеет от 100-150 ХП и также 2 типа атаки и пассивный навык (Моснтр бьет рандомного игрока)");
Console.WriteLine("Первая атака наносит n количество урона со 100% шансом");
Console.WriteLine("Вторая атака наносит n*2 по области с 17% шансом");
Console.WriteLine("Пассивный навык:Атака монстра с шансом 27% имеет эффект вампиризма равный 50% от нанесенного урона");
Console.WriteLine("Победить можно 2 способами");
Console.WriteLine("1 способ: добить монстра");
Console.WriteLine("2 способ: выжить");
Console.WriteLine("Удачи и веселой игры!");
Console.WriteLine("");
Console.ReadKey();
Console.Clear();

int playerOneHealth = 100;
int playerTwoHealth = 100;


Random random = new Random();

int monsterHealth = random.Next(100, 150);



do
{
    //Выбираем тип атаки
    Console.WriteLine("Игрок номер 1, выберете тип атаки, которым хотите отпиздить монстра");
    int typeOfAtackFirstPlayer = Convert.ToInt32(Console.ReadLine());
    int firstTypeOfAtackPlayerOne = random.Next(17, 27);
    int firstTypeOfAtackPlayerTwo = random.Next(17, 27);
    if (typeOfAtackFirstPlayer == 1)
    {
        //Отнимаем хп монстру
        monsterHealth = monsterHealth - firstTypeOfAtackPlayerOne;
    }
    if (monsterHealth <= 0)
    {
        Console.WriteLine($"Стоп...");
        Console.WriteLine($"Монстр погибает!");
        Console.WriteLine($"Игрок номер 1 побеждает!!!");
        break;
    }
    Console.WriteLine($"Вы нанесли монстру {firstTypeOfAtackPlayerOne} урона");
    Console.WriteLine($"У монстра осталось {monsterHealth} ХП");
    Console.WriteLine("Нажмите любую клавишу для продолжения");
    Console.ReadKey();
    Console.Clear();
    //Добавляем тип атаки монстра   
    int firstTypeOfAtackMonster = random.Next(12, 22);
    int typeOfAtackMonster = 1;

    int selectedPlayer = random.Next(1, 3);
    Console.WriteLine("Монстр атакует!!!");
    Console.WriteLine("...");
    Console.WriteLine("Нажмите любую клавишу для продолжения");
    Console.ReadKey();
    Console.Clear();
    if (selectedPlayer == 1)
    {
        if (typeOfAtackMonster == 1)
        {
            playerOneHealth = playerOneHealth - firstTypeOfAtackMonster;
        }
        Console.WriteLine($"Игрок номер 1 получил {firstTypeOfAtackMonster} урона!!!");
        Console.WriteLine($"У него осталось {playerOneHealth} хп!") ;
        Console.WriteLine("Нажмите любую клавишу для продолжения");
        Console.ReadKey();
        Console.Clear();
    }
    else if (selectedPlayer == 2)
    {
        if (typeOfAtackMonster == 1)
        {
            playerTwoHealth = playerTwoHealth - firstTypeOfAtackMonster;
        }
        Console.WriteLine($"Игрок номер 2 получил {firstTypeOfAtackMonster} урона!!!");
        Console.WriteLine($"У него осталось {playerTwoHealth} хп!");
        Console.WriteLine("Нажмите любую клавишу для продолжения");
        Console.ReadKey();
        Console.Clear();
    }
    Console.WriteLine("Игрок номер 2, выберете тип атаки, которым хотите отпиздить монстра");
    int typeOfAtackSecondPlayer = Convert.ToInt32(Console.ReadLine());
    if (typeOfAtackSecondPlayer == 1)
    {
        //Отнимаем хп монстру
        monsterHealth = monsterHealth - firstTypeOfAtackPlayerTwo;
    }
    if (monsterHealth <= 0)
    {
        Console.WriteLine($"Стоп...");
        Console.WriteLine($"Монстр погибает!");
        Console.WriteLine($"Игрок номер 2 побеждает!!!");
        break;
    }
    Console.WriteLine($"Вы нанесли монстру {firstTypeOfAtackPlayerTwo} урона");
    Console.WriteLine($"У монстра осталось {monsterHealth} ХП");
    Console.WriteLine("Нажмите любую клавишу для продолжения");
    Console.ReadKey();
    Console.Clear();
} while (monsterHealth > 0);



