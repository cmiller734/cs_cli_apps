logLines(6, false); //6 is # lines to write
logLines(6, false);
logLines(5, true);

function logLines(numLines, isRev) {
    var minStar = 0;
    var numFinalSpaces = 0;
    [...Array(numLines).keys()].forEach((line, i) => {
        let spaceString = [];
        let starString = ["*"];
        let finalString = "";
        if (isRev) {
            spaceString = [" "];
            [...Array(minStar).keys()].forEach(el => spaceString.push(" "));
            if (i != 0) {
                [...Array(numLines).keys()].forEach(el => starString.push("**"));
            }
            finalString = spaceString + starString + spaceString;
            numFinalSpaces++;
            if (i != 0) {
                logFinalString(spaceString, starString);
            }
        } else {
            [...Array(numLines).keys()].forEach(el => spaceString.push(" "));
            if (i != 0) {
                [...Array(minStar).keys()].forEach(el => starString.push("**"));
            }
            finalString = spaceString + starString + spaceString;
            console.log(finalString);
        }
        numLines--;
        minStar++;
    })
    if (isRev) {
        var finalSpacesStr = "";
        [...Array(numFinalSpaces).keys()].forEach(el => finalSpacesStr += " ");
        console.log(finalSpacesStr + " * " + finalSpacesStr);
    }
}

function logFinalString(spaceString, starString) {
    spaceString.forEach(space => {
        console.log(" ");
    })
    starString.forEach(star => {
        console.log("*");
    })
}
