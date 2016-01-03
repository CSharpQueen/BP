
    var count = 1;
function setColor(btn) {
    var property = document.getElementById(btn);
    if (count == 0) {
        property.style.backgroundColor = "lightgreen"
        count = 1;        
    }
    else {
        property.style.backgroundColor = "red"
        count = 0;
    }
}
