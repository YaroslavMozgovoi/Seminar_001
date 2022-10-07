int a1 = 3;
int b1 = 54;
int c1 = 43;
int a2 = 754;
int b2 = 54;
int c2 = 73;
int a3 = 4;
int b3 = 1;
int c3 = 2;
int a4 = 4;
int b4 = 444;
int c4 = 0;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max4 = Max(a4, b4, c4);
int max5 = Max(max1, max2, max3);
int max = Max(max5, max4, 0);

Console.WriteLine(max);