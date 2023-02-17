


function divisibleSumPairs(n, k, ar) {
    // Write your code here

    let index = 0;
    let movingIndex = index + 1;
    let pairTotals = 0;

    while(index <= n - 2 ){

        while(movingIndex < n){

            if((ar[index] + ar[movingIndex]) % k == 0)
                pairTotals = pairTotals + 1;
            

            movingIndex = movingIndex + 1;
        }
        
        
        index = index + 1;
        movingIndex = index + 1;
    }

    return pairTotals;
}



console.log(divisibleSumPairs(6, 3, [1, 3, 2, 6, 1, 2]));