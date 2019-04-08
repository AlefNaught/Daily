
function addZero(i){
    if (i < 10){
        i = "0" + i;
        return i;
    }
}


/* function indexActiveTime(bool){

    var getIndexTime = new Date();
    var callActiveHour = getIndexTime.getHours() > 12 ? getIndexTime.getHours() - 12 : (getIndexTime.getHours() < 10 ? "0" + getIndexTime.getHours() : getIndexTime.getHours());
    var callActiveMinutes = getIndexTime.getMinutes() < 10 ? "0" + getIndexTime.getMinutes() : getIndexTime.getMinutes();
    var callActiveSeconds = getIndexTime.getSeconds() < 10 ? "0" + getIndexTime.getSeconds() : getIndexTime.getSeconds();
    
    var activeToday = callActiveHour + ":" + callActiveMinutes + ":" + callActiveSeconds;

    while (true){
        console.log(activeToday);
    }

}

indexActiveTime();
*/
