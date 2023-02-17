



function breakingRecords(scores) {
    // Write your code here
    let min = scores[0];
    let max = min;

    let totalMinBreaks = 0;
    let totalMaxBreaks = 0;

    let index = 0;

    while(index <= scores.length - 1){

        let score = scores[index];

        if(score > max ){
            max = score;
            totalMaxBreaks = totalMaxBreaks + 1;
        }

        if(score < min){
            min = score;
            totalMinBreaks = totalMinBreaks + 1;
        }
        index = index + 1;
    }

    return [totalMaxBreaks, totalMinBreaks];
}
//https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem?isFullScreen=true
console.log(breakingRecords([3, 4, 21, 36, 10, 28, 35, 5, 24, 42]));