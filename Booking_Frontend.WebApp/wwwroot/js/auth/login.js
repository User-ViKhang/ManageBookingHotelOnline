var passwordField = document.getElementById('passwordFieldId')
var togglePassword = document.getElementById('togglePasswordId')
togglePassword.addEventListener('click', function () {
    if (passwordField.type == 'text') {
        passwordField.type = 'password'
        togglePassword.className = 'eye-true fa-regular fa-eye-slash'
    }
    else {
        passwordField.type = 'text'
        togglePassword.className = 'eye-true fa-regular fa-eye'
    }
})