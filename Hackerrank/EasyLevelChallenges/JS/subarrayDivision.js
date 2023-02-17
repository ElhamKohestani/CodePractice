
function birthday(s, d, m) {
    // Write your code here

    let firstIndex = 0;
    let lastIndex = m - 1;

    let subArrays = [];

    while(lastIndex < s.length){

        let sub = s.slice(firstIndex, lastIndex + 1);

        if(sub.reduce((pv, cv) =>  pv + cv, 0) === d){
            subArrays.push(sub);
        }

        firstIndex += 1;
        lastIndex +=  1;
    }

    return subArrays.length;
}


console.log(birthday([1, 2, 1, 3, 2], 3, 2));
console.log(birthday([1, 1, 1, 1, 1, 1], 3, 2));
console.log(birthday([4], 4, 1));

console.log(birthday([2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1], 18, 7));
