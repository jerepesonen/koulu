function haeNimet(str) {
  if (str.length == 0) {
    document.getElementById("livesearch").innerHTML = "";
    document.getElementById("livesearch").style.border="0px";
    return;
    } 
  else {
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
        document.getElementById("livesearch").innerHTML = this.responseText;
	document.getElementById("livesearch").style.border="1px solid #A5ACB2";
	//document.getElementById("txtHint").innerHTML = this.responseText;
    }
    };
    xmlhttp.open("GET", "ajax-suggest.php?q=" + str, true);
    xmlhttp.send();
  }
}
