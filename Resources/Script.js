window.dockBadge = '';
setTimeout(updateBadge, 1000);
setTimeout(updateBadge, 3000);
setInterval(updateBadge, 5000);

function updateBadge() {
	var newBadge = '';
	var regex = /\s*\((\d+)\)\s*/;
	var text = document.title;
	
	if (text.length) {
		//console.log('text: ' + text);
		var res = text.match(regex);
		//console.log('res: ' + res);
		if (res && res.length > 1) {
			newBadge = res[1];
			//console.log('newBadge: ' + newBadge);
		}
	}
	
	window.dockBadge = newBadge;
}