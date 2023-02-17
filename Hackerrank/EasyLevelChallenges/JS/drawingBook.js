

function pageCount(n, p) {
    // Write your code here
    let noOfTurns = 0;
    let noOfTurnsFromEnd = 0;

    let numOfTurnsFromStartAndFromEnd = [];
    
    let maxNumDisplayed = 1;

    while(maxNumDisplayed <= n){
        
        if(maxNumDisplayed == p || (maxNumDisplayed - 1) == p){
            break;
        }
        else{
            maxNumDisplayed = maxNumDisplayed + 2;
            noOfTurns = noOfTurns + 1;
        }
    }


    maxNumDisplayed = n % 2 == 0 ? n + 1: n;

    

    while(maxNumDisplayed >= 1){
        
        if(maxNumDisplayed == p || (maxNumDisplayed - 1) == p){
            break;
        }
        else{
            maxNumDisplayed = maxNumDisplayed - 2;
            noOfTurnsFromEnd = noOfTurnsFromEnd + 1;
        }
    }

    if(noOfTurns < noOfTurnsFromEnd)
        return noOfTurns;
    else
        return noOfTurnsFromEnd;
}
function pageCount2(n, p){
    const lastPage = (n % 2 === 0) ? n+1 : n;
    let fromStart = Math.floor(p/2);
    let fromEnd = Math.floor((lastPage - p)/2);
    
    
    return Math.min(fromStart, fromEnd);
}

console.log(pageCount2(6, 5));
console.log(pageCount(6, 5))