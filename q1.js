[...Array(100).keys()].forEach(item => {
    const isMultipleThree = Number.isInteger(item / 3);
    const isMultipleFive = Number.isInteger(item / 5);
    if (isMultipleThree && isMultipleFive) {
        console.log('Explorica Tours');
    }
    else if (isMultipleThree) {
        console.log('Explorica');
    } else if (isMultipleFive) { 
        console.log('Tours');
    } else {
        console.log(item);
    }
});