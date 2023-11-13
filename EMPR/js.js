document.addEventListener("DOMContentLoaded", function () {
    // Cuando la página se carga, realiza la petición fetch
    fetch("http://localhost:5027/api/Libros") // Reemplaza con la URL correcta
        .then(response => response.json())
        .then(libros => mostrarLibros(libros))
        .catch(error => console.error("Error al obtener los libros:", error));
});

function mostrarLibros(libros) {
    const librosContainer = document.getElementById("libros-container");

    // Limpia el contenedor
    librosContainer.innerHTML = "";

    // Itera sobre los libros y crea filas para la tabla
    libros.forEach(libro => {
        const fila = document.createElement("tr");
        fila.innerHTML = `
            <td>${libro.title}</td>
            <td>${libro.chapters}</td>
            <td>${libro.pages}</td>
            <td>${libro.price}</td>
        `;
        librosContainer.appendChild(fila);
    });
}
