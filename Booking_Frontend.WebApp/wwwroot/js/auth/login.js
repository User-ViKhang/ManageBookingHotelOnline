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

var confirmPasswordField = document.getElementById('comfirmPasswordFieldId')
var toggleConfirmPassword = document.getElementById('toggleComfirmPasswordId')
toggleConfirmPassword.addEventListener('click', function () {
    if (confirmPasswordField.type == 'text') {
        confirmPasswordField.type = 'password'
        confirmPasswordField.className = 'eye-true fa-regular fa-eye-slash'
    }
    else {
        confirmPasswordField.type = 'text'
        toggleConfirmPassword.className = 'eye-true fa-regular fa-eye'
    }
})

//document.getElementById("registerForm").addEventListener("submit", function (event) {

//    var password = document.getElementById("passwordFieldId").value;
//    var confirmPassword = document.getElementById("confirmPasswordFieldId").value;
//    var passwordMatchError = document.getElementById("passwordMatchError");

//    if (password != confirmPassword) {
//        alert("sdfdf")

//        passwordMatchError.style.display = "block";
//        event.preventDefault(); // Ngăn chặn việc submit form nếu mật khẩu không khớp
//    } else {
//        alert("sdfsdfsdfdsdf")

//        passwordMatchError.style.display = "none";
//        // Nếu mật khẩu khớp, cho phép form submit bình thường
//    }
//});