console.log('1.\n');
logLines(6, false); //6 is # lines to write

console.log('\n2.\n');
logLines(6, false);
logLines(5, true);

function logLines(numLines, isRev) {
    var minStar = 0;
    var numFinalSpaces = 0;
    [...Array(numLines).keys()].forEach((line, i) => {
        let spaceString = "";
        let starString = "*";
        let finalString = "";
        if (isRev) {
            spaceString = " ";
            [...Array(minStar).keys()].forEach(el => spaceString += " ");
            if (i != 0) {
                [...Array(numLines).keys()].forEach(el => starString += "**");
            }
            finalString = spaceString + starString + spaceString;
            numFinalSpaces++;
            if (i != 0) {
                console.log(finalString);
            }
        } else {
            [...Array(numLines).keys()].forEach(el => spaceString += " ");
            if (i != 0) {
                [...Array(minStar).keys()].forEach(el => starString += "**");
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

