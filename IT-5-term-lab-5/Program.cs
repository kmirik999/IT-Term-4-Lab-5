using IT_5_term_lab_5;



// - Положительное + Отрицательное
Console.WriteLine(new BigInteger("12") + new BigInteger("-386")); 
//     - Отрицательное + Положительное
Console.WriteLine(new BigInteger("-189") + new BigInteger("14"));  
//     - Положительное + Положительное
Console.WriteLine(new BigInteger("176") + new BigInteger("1089"));  
//     - Отрицательное + Отрицательное
Console.WriteLine(new BigInteger("-178") + new BigInteger("-178")); 
Console.WriteLine();


//     - Положительное - Отрицательное
Console.WriteLine(new BigInteger("14") - new BigInteger("-2")); 
//     - Отрицательное - Положительное
Console.WriteLine(new BigInteger("-14") - new BigInteger("12")); 
//     - Положительное - Положительное
Console.WriteLine(new BigInteger("14") - new BigInteger("12")); 
//     - Отрицательное - Отрицательное
Console.WriteLine(new BigInteger("-14") - new BigInteger("-12")); 
Console.WriteLine();
//     - Положительное - Отрицательное (первое больше)
Console.WriteLine(new BigInteger("14") - new BigInteger("-12")); 
//     - Отрицательное - Положительное (первое больше)
Console.WriteLine(new BigInteger("-14") - new BigInteger("12") ); 
//     - Положительное - Положительное (первое больше)
Console.WriteLine(new BigInteger("14") - new BigInteger("12")); 
//     - Отрицательное - Отрицательное (первое больше)
Console.WriteLine(new BigInteger("-14") - new BigInteger("-12")); 

Console.WriteLine();
//     - Положительное - Отрицательное (оба равны, разный знак)
Console.WriteLine(new BigInteger("14") - new BigInteger("-14"));  
//     - Отрицательное - Положительное (оба равны, разный знак)
Console.WriteLine(new BigInteger("-14") - new BigInteger("14")); 
//     - Положительное - Положительное (оба равны)
Console.WriteLine(new BigInteger("1400") - new BigInteger("1400")); 
//     - Отрицательное - Отрицательное (оба равны)
Console.WriteLine(new BigInteger("-1400") - new BigInteger("-1400")); 



