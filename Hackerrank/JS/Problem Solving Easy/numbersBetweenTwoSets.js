



function getTotalX(a, b) {
    // Write your code here
    let loop = Math.max(...a);
    let total = 0;
    
    for(; loop <= 100; loop++){

        if(a.filter(e => !(loop % e == 0)).length == 0 && b.filter(e => !(e % loop == 0)).length == 0){
            total += 1
            console.log(loop);
        }
    }

    return total;
}


console.log(getTotalX([2, 4], [16, 32, 96]));