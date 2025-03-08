// Script para o menu responsivo
const mobileMenu = document.getElementById("mobile-menu");
const navLinks = document.getElementById("nav-links");
const dropdownLinks = document.querySelectorAll(".dropdown-link");

mobileMenu.addEventListener("click", () => {
  mobileMenu.classList.toggle("active"); // Alterna a classe "active" no ícone
  navLinks.classList.toggle("active"); // Alterna a classe "active" no menu
});

// Abrir/fechar os dropdowns no mobile
dropdownLinks.forEach((link) => {
  link.addEventListener("click", (e) => {
    if (window.innerWidth <= 768) {
      e.preventDefault(); // Evita que o link seja seguido
      const dropdown = link.closest(".dropdown");
      dropdown.classList.toggle("active");
    }
  });
});
