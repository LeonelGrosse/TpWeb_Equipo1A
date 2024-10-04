function updateDateTime() {
    const now = new Date();
    const dateTimeString = now.toLocaleString();
    document.getElementById('dateTime').textContent = dateTimeString;
}

function toggleTheme() {
    const htmlElement = document.documentElement;
    if (htmlElement.getAttribute('data-bs-theme') === 'dark') {
        htmlElement.setAttribute('data-bs-theme', 'light');
    } else {
        htmlElement.setAttribute('data-bs-theme', 'dark');
    }
}

document.getElementById('themeToggle').addEventListener('click', toggleTheme);

setInterval(updateDateTime, 1000);
updateDateTime();