//funcion jquery para evitar que copien datos de la pagina
$("body").bind('cut copy paste', function (e) {
    e.preventDefault();
})

//funcion jquery para evitar que usen el boton derecho del mouse
$("body").on("contextmenu", function (e) {
    return false;
})