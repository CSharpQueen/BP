
var count = 1;
var sjediste;

function setColor(btn) {
    var property = document.getElementById(btn);
    if (count == 0) {
        property.style.backgroundColor = "lightgreen"
        count = 1;        
    }
    else {
        property.style.backgroundColor = "red"
        count = 0;
        sjediste = btn;
        document.getElementById('skriveni').value = sjediste;
        //return btn;
    }
    
}
function potvrdiSjed() {
    document.getElementById('skriveni').value = sjediste;
}

