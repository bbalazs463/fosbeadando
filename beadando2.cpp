#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
    int n, k, *arr;
    cin >> n >> k;
    arr = new int[k];
    for (size_t i = 0; i < k; i++)
    {
        arr[i] = -50001;
    }
    for (size_t i = 0; i < n; i++)
    {
        cin >> arr[i % k];
        cout << *max_element(arr, arr + k) << endl;
    }
}


