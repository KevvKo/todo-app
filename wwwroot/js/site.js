// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//index----------------------------------------------------------------------------------------------------------------------------

// adds for the add-button the possibility to show or hide the add-field for new to dos
document.querySelector('.addTask').addEventListener('click', function(){
    let form = document.querySelector('.form')
    let img = document.querySelector('.addTask img')

    if(form.style.height == ""){

        form.style.height = "50px"
        img.src = "/img/chevron.svg"
    }else{
        form.style.height = ""
        img.src = "/img/arrow.svg"
    }   
})

//add the markCompleted-fct to all created checkboxes
let checkboxes = document.querySelectorAll('.done-checkbox')

for(let i = 0, l = checkboxes.length; i < l; i++){
    let checkbox = checkboxes[i]
    checkbox.addEventListener('click', function(){
        markCompleted(this)
    })
}

//marking a checkbox as selected and submit a form
function markCompleted(checkbox) {
    checkbox.disabled = true;

    let row = checkbox.closest('tr');
    row.classList.add('done')

    let form = checkbox.closest('form');
    form.submit();
}

