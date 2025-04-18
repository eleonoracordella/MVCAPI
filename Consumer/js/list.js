function Stampa(){
    $.ajax({
        url: "https://localhost:7012/api/Studenti",
        type: "GET",
        contentType: "application/json",

        success: function (dati)
        {
            console.log(dati)
        },
        error: function (errore)
        {
            console.log(errore)
        }


})
}