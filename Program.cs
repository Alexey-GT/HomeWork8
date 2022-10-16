/*
//54
//
Console.Clear();
int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
FuncSortMatrix(matrix);
Console.WriteLine("");
PrintArray(matrix);

void FuncSortMatrix(int[,] array)
{
    for (int k=0; k<array.GetLength(0); k++)
    {   
        for (int i=0; i<array.GetLength(1); i++)
        {
           for (int j=0; j<array.GetLength(1); j++)
            {   
               if (array[k,i]<array[k,j])
               {
                    int number = array[k,i];
                    array[k,i] = array[k,j];
                    array[k,j] = number;
               }
            }
        }
    }
}

void FillArray(int[,] array)
{
    Random randGenerator = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = randGenerator.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine("");
    }
}
*/

/*
//56
//
Console.Clear();
int[,] matrix = new int[4, 2];
FillArray(matrix);
PrintArray(matrix);
Console.Write($"Строка с наименьшей суммой элементов: {FuncRowMin(matrix)}");

int FuncRowMin(int[,] array)
{
    int sumMin = int.MaxValue;
    int numberRow = 0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j=0; j<array.GetLength(1); j++)
        {   
            sum += array[i,j];
        }
        if (sum<sumMin)
        {
            sumMin = sum;
            numberRow = i;
        }
     }
     return ++numberRow;
}

void FillArray(int[,] array)
{
    Random randGenerator = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = randGenerator.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine("");
    }
}
*/

/*
//58
//
Console.Clear();
int[,] matrix_1 = new int[2, 3];
int[,] matrix_2 = new int[3, 1];
int[,] matrix = new int[matrix_1.GetLength(0), matrix_2.GetLength(1)];
FillArray(matrix_1);
FillArray(matrix_2);
PrintArray(matrix_1);
Console.WriteLine("");
PrintArray(matrix_2);
Console.WriteLine("");
if (matrix_1.GetLength(1) == matrix_2.GetLength(0))
{
    FuncMultiplication(matrix_1, matrix_2);
    PrintArray(matrix);
}
else
{
    Console.Write($"Умножение невозможно, т.к. количество столбцов первой матрицы не равно количеству строк второй матрицы.");
}

void FuncMultiplication(int[,] array_1, int[,] array_2)
{
    for (int i=0; i<array_1.GetLength(0); i++)
    {
        for (int j=0; j<array_2.GetLength(1); j++)
        {   
            matrix[i,j] = 0;
            for (int k=0; k<array_1.GetLength(1); k++)
            {   
                matrix[i,j] += array_1[i,k]*array_2[k,j];
            }
        }
     }
}

void FillArray(int[,] array)
{
    Random randGenerator = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = randGenerator.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine("");
    }
}
*/

/*
//60
//
Console.Clear();
int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);

void FillArray(int[,,] array)
{
    Random randGenerator = new Random();
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            for (int k=0; k<array.GetLength(2); k++)
            {           
                array[i,j,k] = randGenerator.Next(0, 100);
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int k=0; k<array.GetLength(2); k++)
    {
        for (int i=0; i<array.GetLength(0); i++)
        {
            for (int j=0; j<array.GetLength(1); j++)
            {
                Console.Write($" {array[i,j,k]}({i},{j},{k})");
            }
            Console.WriteLine("");
        }
    }
}
*/

/* //62
//
Console.Clear();
Console.WriteLine("Введите размерность квадратной матрицы: ");
int dim = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[dim, dim];
int number = 1;
int num_1R = 0;
int num_2R = matrix.GetLength(1)-1;
int num_3R = 0;
FuncRight(num_1R, num_2R, num_3R);
int num_1D = 0;
int num_2D = matrix.GetLength(0)-1;
int num_3D = matrix.GetLength(1)-1;
number--;
FuncDown(num_1D, num_2D, num_3D);
int num_1L = matrix.GetLength(1)-1;
int num_2L = 0;
int num_3L = matrix.GetLength(0)-1;
number--;
FuncLeft(num_1L, num_2L, num_3L);
int num_1U = matrix.GetLength(0)-1;
int num_2U = 1;
int num_3U = 0;
number--;
FuncUp(num_1U, num_2U, num_3U);
while (num_1R <= matrix.GetLength(0)/2)
{
    num_1R++;
    num_2R--;
    num_3R++;
    FuncRight(num_1R, num_2R, num_3R);
    num_1D++;
    num_2D--;
    num_3D--;
    number--;
    FuncDown(num_1D, num_2D, num_3D);
    num_1L--;
    num_2L++;
    num_3L--;
    number--;
    FuncLeft(num_1L, num_2L, num_3L);
    num_1U--;
    num_2U++;
    num_3U++;
    number--;
    FuncUp(num_1U, num_2U, num_3U);
}
PrintArray(matrix);


void FuncRight(int num1, int num2, int num3)
{
    for (int j=num1; j<=num2; j++)
    {
        matrix[num3,j] = number;
        number++;
    }
}

void FuncDown(int num1, int num2, int num3)
{
    for (int i=num1; i<=num2; i++)
    {
        matrix[i,num3] = number;
        number++;
    }
}

void FuncLeft(int num1, int num2, int num3)
{
    for (int j=num1; j>=num2; j--)
    {
        matrix[num3,j] = number;
        number++;
    }
}

void FuncUp(int num1, int num2, int num3)
{
    for (int i=num1; i>=num2; i--)
    {
        matrix[i,num3] = number;
        number++;
    }
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
            {
                Console.Write($" 0{array[i,j]}");
            }
            else
            {
                Console.Write($" {array[i,j]}");
            }
        }
        Console.WriteLine("");
    }
} */