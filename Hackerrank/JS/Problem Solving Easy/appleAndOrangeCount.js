



function countApplesAndOranges(s, t, a, b, apples, oranges) {
    // Write your code here


    apples = apples.map(e => e + a);
    oranges = oranges.map(e => e + b);

    let countApples = countOranges = 0;

    countApples = apples.filter(x => x >= s && x <= t).length;
    countOranges = oranges.filter(x => x >= s && x <= t).length;

    console.log(countApples);
    console.log(countOranges);

}




let s = 7, t = 11;
let appleTreeLocation = 5, orangeTreeLocation = 15;
let noOfApples = 3, noOfOranges = 2;
let appleDistances = [-2, 2, 1];
let orangeDistances = [5, -6];


countApplesAndOranges(s, t, appleTreeLocation, orangeTreeLocation, appleDistances, orangeDistances);