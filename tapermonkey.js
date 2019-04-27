// в учительском интерфейсе приложение подсвечивает и подписывает вид воспрития у каждого ребенка

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
json = JSON.parse(data);
keys = Object.keys(json)
var elems = document.getElementsByClassName("course-journal__table-body")[0];
var names = elems.getElementsByClassName("course-journal__table-cell_student");
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
				names[ind].innerText = names[ind].innerText  + ' ' + lables[val];
            }
        }
    }
}
