// в учительском интерфейсе приложение подсвечивает и подписывает вид воспрития у каждого ребенка


// ==UserScript==
// @name         education yandex
// @namespace    https://education.yandex.ru
// @version      0.1
// @description  try to take over the world!
// @author       You
// @match        https://education.yandex.ru/
// @match   *//education.yandex.ru/*
// @include	*://*.education.yandex.ru/*
// @include	*://education.yandex.ru/*
// ==/UserScript==

setTimeout(function() {
    var colors = {
    vis: "#e19bef",
    aud: "#95c8ed",
    kin: "#6cff59"
}

var lables = {
    vis: "ВИЗ",
    aud: "АУД",
    kin: "КИН"
}

var data = '{"вася" : "kin","петя" : "vis","коля" : "vis","сашa" : "kin","ира" : "aud","гена" : "aud"}'
var json = JSON.parse(data);
var keys = Object.keys(json)
var elems = document.getElementsByClassName("course-journal__table-body")[0];
var names = elems.getElementsByClassName("course-journal__table-cell_student");
var ind;
for (ind in names) {
    if (typeof(names[ind].innerText) != "undefined") {
        console.log(names[ind].innerText.length);
        console.log(names[ind].innerText.toLowerCase());
        for (var key in json) {
            var val = json[key]
            console.log(key, colors[val]);
            if (names[ind].innerText.toLowerCase().includes(key) == true) {
                names[ind].style.backgroundColor = colors[val];
				names[ind].style.backgroundColor = colors[val];
				names[ind].innerText = names[ind].innerText + ' ' + lables[val];
            }
        }
    }
}
}, 1000);




