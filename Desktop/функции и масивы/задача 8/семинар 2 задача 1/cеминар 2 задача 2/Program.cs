//Напишите программу ,которая выводит случайное трехзначное число и удаляет вторую цифру этого чисал

int a = new Random().Next (100, 1000);
Console.WriteLine (a);

int result = deleteSecondNumber (a);
Console.WriteLine (result);

int deleteSecondNumber (int number)
{
    int digitOne = number / 100;
    int digitThird = number % 10;
    int resultDooble = digitOne * 10 + digitThird;
    return resultDooble;
}