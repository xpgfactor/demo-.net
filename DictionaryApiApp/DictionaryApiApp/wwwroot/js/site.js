// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
let data = ["Ram", "Shyam", "Sita", "Gita"];
let list = document.getElementById("myList");
for (i = 0; i < data.length; ++i) {
    let li = document.createElement('li');
    li.innerText = data[i];
    list.appendChild(li);
}
