function sort(shufflesort) {
	var list = "1 2 3 4 5 6 7 8";
	var unit = list.split(" ");
	var outlist = [];
	while (unit.length > 0){
		outlist.push(unit.splice(Math.floor(Math.random()*unit.length), 1));
		console.log(outlist.join(" "));
		return outlist;
	}
};

function retry(){
	for (i = 0; i < 20; i++){
		sort();
		document.write(sort());
	}
}
sort();
retry();


document.getElementById('shuff')