
function catAndMouse(x, y, z) {

    let xDistance = Math.abs(x - z);
    let yDistance = Math.abs(y - z);

    if(xDistance === yDistance)
    {
        return "Mouse C"
    }

    if(xDistance < yDistance)
        return "Cat A";
    else
        return "Cat B";

}

console.log(catAndMouse(1, 3, 2));