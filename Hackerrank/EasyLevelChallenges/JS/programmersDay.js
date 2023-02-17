
function dayOfProgrammer(year) {
    // Write your code here

    let yearString = '.09.' + year.toString();

    let leapYearDateString = (256 - 244).toString() + yearString;
    let normalYearDateString = (256 - 243).toString() + yearString;

    if (year > 1918) {

        if ((year % 4 == 0 && !(year % 100 == 0)) || (year % 400 == 0))
            return leapYearDateString;

        else
            return normalYearDateString;
    }
    
    else if (year == 1918) {
        return (256 - 244 + 14).toString() + yearString;
    }

    else if (year < 1918) {
        
        if (year % 4 == 0) 
            return leapYearDateString;

        else
            return normalYearDateString;
    }
}


//13.09.1917
console.log(dayOfProgrammer(1917))

// 26.09.1918
console.log(dayOfProgrammer(1918));


console.log(dayOfProgrammer(1919))


console.log(dayOfProgrammer(1920));
