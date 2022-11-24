int [] array = {21,31,179,179};
int n = array.Length;
int index = 0;
int max = array[0];
while ( index < n)
    if ( array[index] > max )
    {
    max = array[index];
    index++;
    }
    else {
        index++;
    }

Console.WriteLine(max);