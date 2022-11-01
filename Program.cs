

int hasil = 1;
for (int i = 3; i > 1; i--)
{
    hasil*=i;
}
Console.WriteLine(hasil);

int eded = 12;
bool isExist = false;
for (int i = 2; i < eded; i++)
{
    if (eded % i == 0)
    {
        Console.WriteLine("eded murekkeb" + eded);
        isExist = true;
        break;
    }
}
if (!isExist)
{
    Console.WriteLine( "sade" + eded);
}



int reqem = 134;
int qaliq = 0;
int mertebe = 0;
while(reqem > 0)
{
    mertebe++;
    qaliq = reqem %10;
    reqem = (reqem - qaliq) /10;
}

Console.WriteLine(mertebe);