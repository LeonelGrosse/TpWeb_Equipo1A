///VALIDACI�NES DE DATOS DE CLIENTES
document.addEventListener("DOMContentLoaded", function () {
    document.getElementById("BtnParticipar").addEventListener("click", function (event) {
        let errorMessage = "";
        const dni = document.getElementById("txtBoxDNI").value.trim();
        const nombre = document.getElementById("txtBoxNombre").value.trim();
        const apellido = document.getElementById("txtBoxApellido").value.trim();
        const email = document.getElementById("txtBoxEmail").value.trim();
        const direccion = document.getElementById("txtBoxDireccion").value.trim();
        const cp = document.getElementById("txtBoxCP").value.trim();
        const terms = document.getElementById("chkBoxTerms").checked;

        if (!dni || dni.length !== 8 || isNaN(dni)) {
            errorMessage = "Por favor, ingresa un DNI v�lido de 8 d�gitos.";
        } else if (!nombre || !/^[a-zA-Z]+$/.test(nombre)) {
            errorMessage = "Por favor, ingresa un nombre v�lido.";
        } else if (!apellido || !/^[a-zA-Z]+$/.test(apellido)) {
            errorMessage = "Por favor, ingresa un apellido v�lido.";
        } else if (!email || !/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)) {
            errorMessage = "Por favor, ingresa un email v�lido.";
        } else if (!direccion) {
            errorMessage = "Por favor, ingresa una direcci�n.";
        } else if (!cp || isNaN(cp)) {
            errorMessage = "Por favor, ingresa un c�digo postal v�lido.";
        } else if (!terms) {
            errorMessage = "Debes aceptar los t�rminos y condiciones.";
        }

        if (errorMessage) {
            event.preventDefault();
            document.getElementById("lblErrorDireccion").innerText = errorMessage;
        }
    });
});
///