//*****************************************************************************
//** 941. Valid Mountain Array leetcode                                      **
//** Loops and Arrays to solve -Dan                                          **
//*****************************************************************************


bool validMountainArray(int* arr, int arrSize){
    if (arrSize < 3) {
        return false;
    }
    
    int peak = arr[0];
    int peak_index = 0;
    
    for (int i = 1; i < arrSize; i++) {
        if (arr[i] > peak) {
            peak = arr[i];
            peak_index = i;
        }
    }
    
    if (peak_index == 0 || peak_index == arrSize - 1) {
        return false;
    }
    
    for (int i = 0; i < peak_index; i++) {
        if (arr[i] >= arr[i + 1]) {
            return false;
        }
    }
    
    for (int i = peak_index; i < arrSize - 1; i++) {
        if (arr[i] <= arr[i + 1]) {
            return false;
        }
    }
    
    return true;
}
