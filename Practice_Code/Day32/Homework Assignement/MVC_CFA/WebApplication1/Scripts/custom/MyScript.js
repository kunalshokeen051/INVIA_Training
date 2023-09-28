window.onload = displayClock();


function displayClock()
{
    var display = new Date().toLocaleTimeString("en-us");
    document.getElementById("Clock").innerHTML = display;
    setTimeout(displayClock, 1000);
}

