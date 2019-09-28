function DOW() {
}

DOW.dayOfWeek = function (day) {
    let dow = ["Monday","Tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"];

    return dow[day-1]
    /*switch (day) {
        case 1:
            dow = "Monday";
            break;

        case 2:
            dow = "Tuesday";
            break;

        case 3:
            dow = "Wednesday";
            break;

        case 4:
            dow = "Thursday";
            break;

        case 5:
            dow = "Friday";
            break;

        case 6:
            dow = "Saturday";
            break;

        case 7:
            dow = "Sunday";
            break;
    }*/
    

    //return dow;
}

module.exports = {
    DOW
}