

function sockMerchant(n, ar) {
    // Write your code here

    let totalPairs = 0;
    let checkedElements = [];

    ar.forEach(a => {
        let arr = ar.filter(x => x == a && !checkedElements.includes(a));

        if (arr.length % 2 == 0) {
            totalPairs = totalPairs + (arr.length / 2);
        }
        else {
            if (arr.length > 1) {
                totalPairs = totalPairs + ((arr.length - 1) / 2)
            }
        }
        checkedElements.push(a);
    });

    return totalPairs;
}

console.log(sockMerchant(9, [10, 20, 20, 10, 10, 30, 50, 10, 20]));
