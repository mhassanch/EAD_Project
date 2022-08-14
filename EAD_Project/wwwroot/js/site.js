// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function(){
    $("#menuButton").click(function(){
        if(document.getElementById("menuContents").style.visibility == "hidden"){
            document.getElementById("menuContents").style.visibility = "visible"
        }
        else{
            document.getElementById("menuContents").style.visibility = "hidden"
        }
    });
});
