///VALIDACIÓNES DE DATOS DE CLIENTES
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
            errorMessage = "Por favor, ingresa un DNI válido de 8 dígitos.";
        } else if (!nombre || !/^[a-zA-Z]+$/.test(nombre)) {
            errorMessage = "Por favor, ingresa un nombre válido.";
        } else if (!apellido || !/^[a-zA-Z]+$/.test(apellido)) {
            errorMessage = "Por favor, ingresa un apellido válido.";
        } else if (!email || !/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)) {
            errorMessage = "Por favor, ingresa un email válido.";
        } else if (!direccion) {
            errorMessage = "Por favor, ingresa una dirección.";
        } else if (!cp || isNaN(cp)) {
            errorMessage = "Por favor, ingresa un código postal válido.";
        } else if (!terms) {
            errorMessage = "Debes aceptar los términos y condiciones.";
        }

        if (errorMessage) {
            event.preventDefault();
            document.getElementById("lblErrorDireccion").innerText = errorMessage;
        }
    });
});
///