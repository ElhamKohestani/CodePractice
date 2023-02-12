


function bonAppetit(bill, k, b) {
    // Write your code here
    let priceShouldBePaidByAnna = (bill.reduce((prev, next) => prev + next , 0) - bill[k]) / 2;

    if(priceShouldBePaidByAnna == b){
        console.log("Bon Appetit");
    }
    else if(b > priceShouldBePaidByAnna){
        console.log(b - priceShouldBePaidByAnna);
    }
}

bonAppetit([3, 10, 2, 9], 1, 7);