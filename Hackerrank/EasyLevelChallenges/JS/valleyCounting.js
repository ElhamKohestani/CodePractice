

function countingValleys(steps, path) {
    // Write your code here
    let arrayOfUpAndDowns = Array.from(path);
    let noOfVallyes = 0;
    let valleyStarted = false;
    let altitude = 0;

    for (let i = 0; i <= arrayOfUpAndDowns.length - 1; i++) {

        if (arrayOfUpAndDowns[i] == "U") {
            altitude = altitude + 1;
        }
        else {
            altitude = altitude - 1;
        }

        if (altitude < 0) {
            valleyStarted = true;
        }
        else if (valleyStarted && altitude == 0) {
            valleyStarted = false;
            noOfVallyes = noOfVallyes + 1;
        }
    }

    return noOfVallyes;
}


console.log(countingValleys(8, "UDDDUDUU"));