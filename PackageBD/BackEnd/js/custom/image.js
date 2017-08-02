/////multiple image preview 
//function previewImages() {

//    var preview = document.querySelector('.previewUpImg');

//    if (this.files) {
//        [].forEach.call(this.files, readAndPreview);
//    }

//    function readAndPreview(file) {

//        // Make sure `file.name` matches our extensions criteria
//        if (!/\.(jpe?g|png|gif)$/i.test(file.name)) {
//            return alert(file.name + " is not an image");
//        } // else...

//        var reader = new FileReader();

//        reader.addEventListener("load", function () {
//            var image = new Image();
//            image.height = 100;
//            image.title = file.name;
//            image.src = this.result;
//            preview.appendChild(image);
//        }, false);

//        reader.readAsDataURL(file);

//    }

//}

//document.querySelector('.file-up').addEventListener("change", previewImages, false);
/////multiple image preview 