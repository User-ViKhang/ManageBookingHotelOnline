// const carousel = document.querySelector(".slide-show-location-toptrending")
// const firtElement = document.querySelectorAll(".card-slide-show-item-location")[0]
// const arrowIcons = document.querySelectorAll(".card-location-top i")

// let isDragStart = false, prevPageX, prevScrollLeft

// const showHideIcon = () => {
//     let scrollWidth = carousel.scrollWidth - carousel.clientWidth
//     arrowIcons[0].style.display = carousel.scrollLeft == 0 ? "none" : "block"
//     arrowIcons[1].style.display = carousel.scrollLeft == scrollWidth ? "none" : "block"
// }

// arrowIcons.forEach(icon => {
//     icon.addEventListener("click", () => {
//         let firstElementWidth = firtElement.clientWidth + 15
//         carousel.scrollLeft += icon.id == "chevron-left-icon" ? -firstElementWidth : firstElementWidth
//         setTimeout(() => showHideIcon(), 60)
//     })
// });
// const dragging = (e) => {
//     if (!isDragStart) return;
//     e.preventDefault()
//     carousel.classList.add("dragging")
//     let positionDiff = e.pageX - prevPageX
//     carousel.scrollLeft = prevScrollLeft - positionDiff
// }

// const dragStart = (e) => {
//     isDragStart = true
//     prevPageX = e.pageX
//     prevScrollLeft = carousel.scrollLeft

// }

// const dragStop = () => {
//     isDragStart = false
//     carousel.classList.remove("dragging")
// }

// carousel.addEventListener("mousedown", dragStart);
// carousel.addEventListener("mousemove", dragging);
// carousel.addEventListener("mouseup", dragStop);







//var loader = function () {
//    setTimeout(function () {
//        $('#loader').css({ 'opacity': 0, 'visibility': 'hidden' });
//    }, 1000);
//};
//$(function () {
//    loader();
//});
window.onload = function () {
    setTimeout(function () {
        $('#loader').css({ 'opacity': 0, 'visibility': 'hidden' });
    }, 1000);
};











function showLogoutPopup() {
    document.getElementById("logoutPopup").style.display = "block";
}

function cancelLogout() {
    document.getElementById("logoutPopup").style.display = "none";
}

function logout() {
    var form = document.getElementById('form-logout'); // Thay 'yourFormId' bằng id thực của form
    form.submit();
}







// const carousel1 = document.querySelector(".carousel-1")
// const firtElement1 = document.querySelectorAll(".card-price")[0]
// const arrowIcons1 = document.querySelectorAll(".card-location-top-1 i")

// let isDragStart1 = false, prevPageX1, prevScrollLeft1

// const showHideIcon1 = () => {
//     let scrollWidth = carousel1.scrollWidth - carousel1.clientWidth
//     arrowIcons1[0].style.display = carousel1.scrollLeft == 0 ? "none" : "block"
//     arrowIcons1[1].style.display = carousel1.scrollLeft == scrollWidth ? "none" : "block"
// }

// arrowIcons1.forEach(icon => {
//     icon.addEventListener("click", () => {
//         let firstElementWidth = firtElement1.clientWidth + 15
//         carousel1.scrollLeft += icon.id == "chevron-left-icon" ? - firstElementWidth : firstElementWidth
//         setTimeout(() => showHideIcon1(), 60)
//     })
// });
// const dragging1 = (e) => {
//     if (!isDragStart) return;
//     e.preventDefault()
//     carousel1.classList.add("dragging")
//     let positionDiff = e.pageX - prevPageX
//     carousel1.scrollLeft = prevScrollLeft1 - positionDiff
// }

// const dragStart1 = (e) => {
//     isDragStart1 = true
//     prevPageX1 = e.pageX
//     prevScrollLeft1 = carousel.scrollLeft

// }

// const dragStop1 = () => {
//     isDragStart1 = false
//     carousel1.classList.remove("dragging")
// }

// carousel1.addEventListener("mousedown", dragStart);
// carousel1.addEventListener("mousemove", dragging);
// carousel1.addEventListener("mouseup", dragStop);




const carousel = document.querySelector(".slide-show-category-location")
const firtElement = document.querySelectorAll(".link-item-category")[0]
const arrowIcons = document.querySelectorAll(".category-location-area i")

let isDragStart = false, prevPageX, prevScrollLeft

const showHideIcon = () => {
    let scrollWidth = carousel.scrollWidth - carousel.clientWidth
    arrowIcons[0].style.display = carousel.scrollLeft == 0 ? "none" : "block"
    arrowIcons[1].style.display = carousel.scrollLeft == scrollWidth ? "none" : "block"
}

arrowIcons.forEach(icon => {
    icon.addEventListener("click", () => {
        let firstElementWidth = firtElement.clientWidth + 5
        carousel.scrollLeft += icon.id == "chevron-left-icon" ? -firstElementWidth : firstElementWidth
        setTimeout(() => showHideIcon(), 60)
    })
});
const dragging = (e) => {
    if (!isDragStart) return;
    e.preventDefault()
    carousel.classList.add("dragging")
    let positionDiff = e.pageX - prevPageX
    carousel.scrollLeft = prevScrollLeft - positionDiff
}

const dragStart = (e) => {
    isDragStart = true
    prevPageX = e.pageX
    prevScrollLeft = carousel.scrollLeft

}

const dragStop = () => {
    isDragStart = false
    carousel.classList.remove("dragging")
}

carousel.addEventListener("mousedown", dragStart);
carousel.addEventListener("mousemove", dragging);
carousel.addEventListener("mouseup", dragStop);



// Lấy ngày hiện tại
var today = new Date();

// Định dạng ngày tháng để gán vào input
var dd = String(today.getDate()).padStart(2, '0');
var mm = String(today.getMonth() + 1).padStart(2, '0'); //Tháng bắt đầu từ 0
var yyyy = today.getFullYear();

today = yyyy + '-' + mm + '-' + dd;

// Gán ngày hiện tại vào input
document.getElementById("date-checkout").value = today;
document.getElementById("date-checkin").value = today;

var days = ['Chủ nhật', 'Thứ hai', 'Thứ ba', 'Thứ tư', 'Thứ năm', 'Thứ sáu', 'Thứ bảy'];

var selectedDateCheckIn = document.getElementById("date-checkin").value;
var dateObjectIn = new Date(selectedDateCheckIn);
var dayOfWeekIn = days[dateObjectIn.getDay()];
document.getElementById("dayCheckIn").innerHTML = dayOfWeekIn;
document.getElementById("date-checkin").addEventListener("change", () => {
    var selectedDateCheckIn = document.getElementById("date-checkin").value;
    var dateObjectIn = new Date(selectedDateCheckIn);
    var dayOfWeekIn = days[dateObjectIn.getDay()];
    document.getElementById("dayCheckIn").innerHTML = dayOfWeekIn;
});

var selectedDateCheckOut = document.getElementById("date-checkout").value;
var dateObjectOut = new Date(selectedDateCheckOut);
var dayOfWeekOut = days[dateObjectOut.getDay()];
document.getElementById("dayCheckOut").innerHTML = dayOfWeekOut;
document.getElementById("date-checkout").addEventListener("change", () => {
    var selectedDateCheckOut = document.getElementById("date-checkout").value;
    var dateObjectOut = new Date(selectedDateCheckOut);
    var dayOfWeekOut = days[dateObjectOut.getDay()];
    document.getElementById("dayCheckOut").innerHTML = dayOfWeekOut;
});



function changeLanguage() {
    var selectedUrl = document.getElementById("languageSelect").value;
    window.location.href = selectedUrl; // Chuyển hướng đến URL được chọn
}

var searchBox = document.getElementById("input-address")
var suggestLocation = document.getElementById("suggest-location")
searchBox.addEventListener("click", function () {
    suggestLocation.style.display = "block"
})
window.addEventListener("click", function () {
    suggestLocation.style.display = "none"

})

function validateForm() {
    var inputField = document.getElementById("input-address").value;
    if (inputField === "") {
        alert("Vui lòng điền vào trường địa điểm.");
        return false; // Ngăn form được gửi đi
    }
    return true; // Cho phép form được gửi đi
}



