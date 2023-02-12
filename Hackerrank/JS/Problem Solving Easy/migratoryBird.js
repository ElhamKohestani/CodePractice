


function migratoryBirds(arr) {
    // Write your code here
    var storage = {};

    arr.forEach(element => {
        if(storage[element.toString()]){
            storage[element.toString()] = storage[element.toString()] +1;
        }
        else{
            Object.defineProperty(storage, element.toString(), {
                value : 1,
                writable: true,
                enumerable : true,
                configurable : true
            });
        }
    });

    const storageArr = Object.entries(storage);

    const filtered = storageArr.filter(([key, value]) => {
        return value == Math.max(...Object.values(storage))
    });

    return parseInt(filtered[0][0]);
}


function max(arr){
    let max = arr[0];

    for(let i= 1; i<arr.length; i++){
        if(arr[i] > max)
            max = arr[i];
    }

    return max;
}

//console.log(max([1,2,3, 300,4,5]))

// migratoryBirds([4, 4 ,4, 1,1,1,  5,5, 3])

console.log(migratoryBirds([1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4]));
console.log(migratoryBirds([1, 4, 4, 4, 5, 3]));
