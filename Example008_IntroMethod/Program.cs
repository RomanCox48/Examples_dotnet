using System.Runtime.Intrinsics.X86;

int a1 =234;
int b1 = 634563;
int c1 = 23452;
int a2 =98755;
int b2 = 1234;
int c2 = 98764;
int a3 =1234;
int b3 = 2135245;
int c3 = 8765;



int Max(int arg1, int agr2, int arg3)
{
    int result = arg1;
    if (agr2>result) result = agr2;
    if (arg3>result) result = arg3;
    return result;
}

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));


Console.WriteLine(max);