const toggleButton = document.getElementById('themeToggle')
const body = document.body

// Comprobar preferencia del usuario guardada
if (localStorage.getItem('theme') === 'dark') {
    body.classList.add('dark-mode')
    document.querySelector('nav').classList.add('dark-mode')
    document.querySelector('.footer').classList.add('dark-mode')
    document.querySelectorAll('.nav-link').forEach(l => l.classList.add('dark-mode'))
    toggleButton.innerHTML = '<i class="bi bi-sun-fill"></i>'
}

toggleButton.addEventListener('click', () => {
    const isDark = body.classList.toggle('dark-mode')
    document.querySelector('nav').classList.toggle('dark-mode')
    document.querySelector('footer').classList.toggle('dark-mode')
    document.querySelectorAll('.nav-link').forEach(l => l.classList.toggle('dark-mode'))

    localStorage.setItem('theme', isDark ? 'dark' : 'light')
    toggleButton.innerHTML = isDark ? '<i class="bi bi-sun-fill"></i>' : '<i class="bi bi-moon-fill"></i>'
})