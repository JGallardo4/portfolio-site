var thumbnails = document.getElementsByClassName("thumbnail");
var modal = document.getElementById("imageModal");
var modalImg = document.getElementById("modal-content");

// Get the image and update the modal. Then show the modal
for (i = 0; i < thumbnails.length; i++)
{
	thumbnail = thumbnails[i];

	thumbnail.addEventListener(
		"click",
		function(){
			modalImg.src = this.src;
			modal.style.display = "grid";
		},
		false);
}

// When the user clicks on <span> (x), close the modal
var closeButton = document.getElementById("modal-close");

closeButton.onclick = function() {
	modal.style.display = "none";
}