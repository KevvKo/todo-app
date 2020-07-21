// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//index----------------------------------------------------------------------------------------------------------------------------

// adds for the add-button the possibility to show or hide the add-field for new to dos
document.querySelector('.addTask').addEventListener('click', function(){
    let form = document.querySelector('.form')
    
    form.style.display == "" ? form.style.display = "block" : form.style.display = ""
    
})