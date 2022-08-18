// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

  
     if (number == 1)
    
      Console.WriteLine("Диапазон координат точек в 1 четверти X > 0 и Y > 0");
        
    else if (number == 2)
    {
      Console.WriteLine("Диапазон координат точек во 2 четверти X < 0 и Y > 0");
    }
    else if (number == 3)
    {
      Console.WriteLine("Диапазон координат точек в 3 четверти X < 0 и Y < 0");
    }
    else if (number == 4)
    {
      Console.WriteLine("Диапазон координат точек в 4 четверти X > 0 и Y < 0");
    }
else
 {
    Console.WriteLine("Ошибка. Нет такой четверти");
 } 
 