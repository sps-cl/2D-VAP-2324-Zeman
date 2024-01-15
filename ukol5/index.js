function vytvoritTabulku() {
    let radky = document.getElementById("pocet-radku").value;
    let sloupce = document.getElementById("pocet-sloupcu").value;

    let tabulka = document.createElement("table")
    for(let i = 1; i < radky; i++){
        let radek = tabulka.insertRow();
        for(let j = 1; i < sloupce; j++){
            let sloupec = radek.insertCell();
            sloupec.textContent = (i - 1) * sloupce + j;
        }
    }
    document.body.appendChild(tabulka);
}