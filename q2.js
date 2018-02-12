//Code has been written to fit the following criteria: Console.Write("*"), Console.Write(" "), Console.WriteLine()
//are used only once. To make this happen I created arrays of strings, each string being either " ", "*". or "**" to denote
//what should be what. If allowed to use unlimited Console.Writes I would write this differently but this is a solution.
logLines(6, false); //6 is # lines to write
logLines(6, false);
logLines(5, true);

function logLines(numLines, isRev) {
    var minStar = 0;
    var numFinalSpaces = 0;
    [...Array(numLines).keys()].forEach((line, i) => {
        let spaceString = [];
        let starString = ["*"];
        let finalString = [];
        
        if (isRev) {
            spaceString = [" "];
            [...Array(minStar).keys()].forEach(el => spaceString.push(" "));
            if (i != 0) {
                [...Array(numLines).keys()].forEach(el => starString.push("**"));
            }
            finalString = spaceString.concat(starString).concat(spaceString); 
            numFinalSpaces++; //here
            if (i != 0) {
                logLine(finalString);
            }
        } else {
            [...Array(numLines).keys()].forEach(el => spaceString.push(" "));
            if (i != 0) {
                [...Array(minStar).keys()].forEach(el => starString.push("**"));
            }
            finalString = spaceString.concat(starString).concat(spaceString);
            logLine(finalString);
        }
        numLines--;
        minStar++;
    })
    if (isRev) {
        var finalSpacesStr = [" "];
        [...Array(numFinalSpaces).keys()].forEach(el => finalSpacesStr.push(" "));
        finalString = finalSpacesStr;
        finalString.push("*");
        finalString = finalString.concat(finalSpacesStr)
        finalString.pop();
        logLine(finalString);
    }
}

function logLine(iterable) {
    for (let value of iterable) {
        if (value === " ") {
            process.stdout.write(" "); //Console.Write(" ");
        } else {
            var numStars = 0;
            if (value === "*") 
            {
                numStars = 1;
            }
             else {
                numStars = numStars + 2;
            }
            [...Array(numStars).keys()].forEach(key => {
                process.stdout.write("*"); //Console.Write("*");
            });
        }
    }
    console.log(""); //Console.WriteLine
}
