Console.WriteLine("Введите число ");
float num = float.Parse(Console.ReadLine());
float Y = 1 ;
float ost ;
while ( Y <= num )
{  
    ost = Y % 2 ;
    if ( ost == 0 )
    {
       Console.Write( Y + " ");
    } 
        else if ( ost > 0 )
        {
        Console.Write("");
        }
        Y++;     
}
 Console.WriteLine( " - В промежутке от 1 до " + num + " находятся эти четные числа ");
