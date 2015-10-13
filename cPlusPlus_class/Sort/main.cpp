#include <iostream>
#include "../LinuxHelperBot/Collection.h"
#include "../LinuxSuperHeroes/SuperHero.h"
#include <iomanip>
#include <string>
using namespace std;
void swap(int,int,int*);
void prettyPrint(int*,int);
void sort(int*, int);
void bubbleSort(int*, int);
int main()
{
    int numbers[] = {5, 13, 7, 3, 11};
   // int temp = numbers[0];
    //int a = 5;
    //int b = 3;

   // temp = a;
  //  a = b;
   // b = temp;
   Collection<SuperHero> s;
   s.Add(SuperHero("Batman", "brains, master martial artist", "Bruce Wayne", 32));


    prettyPrint(numbers, 5);
    cout << endl;
    sort(numbers, 5);
    prettyPrint(numbers, 5);
    cout << endl;
    int numbers1[] = {5, 13, 7, 3, 11};
    cout << endl;

    prettyPrint(numbers1, 5);
    bubbleSort(numbers1, 5);
    cout << endl;
    prettyPrint(numbers1, 5);

  //  cout << "a=" << a <<"b=" << b << endl;
    return 0;
}
void swap(int a, int b, int* numbers)
{
    int temp = numbers[a];
    numbers[a] = numbers[b];
    numbers[b] = temp;
}
void prettyPrint(int* numbers,int length)
{
    cout << "{";
    for (int i =0; i< length; i++)
    {
        if (i ==0)
        {
            cout << numbers[i];
        }
        else{
        cout << ", " << numbers[i];
        }
    }
    cout << "}";
}
void bubbleSort(int* numbers, int length)
{
    bool sorted = false;
    do
    {
        sorted = true;
        for (int i = 0; i < length - 1; i++)
        {
            if (numbers[i] > numbers[i+1])
            {
                swap(i, i + 1, numbers);
                sorted = false;

            }
        }

    }  while(!sorted);
}
void sort(int* numbers, int length)
{
    for (int i =0; i< length; i++)
    {

        int temp = numbers[i];
        for (int icnt =0; icnt< length; icnt++)
    {
            if(!(icnt == i))
            {
                if(temp < numbers[icnt])
                {
                    if(i > icnt)
                    {
                        swap(i, icnt, numbers);
                    }
                }
            }
        }

    }
}
void linearSort(int* numbers, int length)
{
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            if (numbers[i] < numbers[j])
            {
                swap(i,j, numbers);
            }
        }
        prettyPrint(numbers, length);
    }
}
