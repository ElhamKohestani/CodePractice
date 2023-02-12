
function matchingStrings(strings, queries) {
    // Write your code here

    let result = [];

    queries.forEach(q => {
        let allQs = strings.filter(x => x == q);
        result.push(allQs.length);
    });

    return result;
}

console.log(matchingStrings(["aba",
    "baba",
    "aba",
    "xzxb"], ["aba",
        "xzxb",
        "ab"]));