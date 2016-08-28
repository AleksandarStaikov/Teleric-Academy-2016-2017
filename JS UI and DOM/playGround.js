
function DoStuff(element, contents) {

    var item = document.getElementById('2');
    item.innerHTML = '';
    for(let i = 0; i < 10; i++){
        let element = document.createElement('div');
        element.innerText = "oshte malko trqq da ima";
        item.appendChild(element);
    }

    /*if(element == undefined || document.getElementById(element) == null || typeof(element) != "string") {
        throw new Error('element cannot be empty');
    }
    if(contents == null || contents == [] ){
        throw new Error('Contents cannot be empty');
    }
    for(let content in contents){
        if(isNaN(content * 1)){
            if(typeof(content) != "string"){
                throw new Error('Invalid contents')
            }else{
                ChangeContent(element, contents);
            }
        }else{
            ChangeContent(element, contents);
        }
    }

    function ChangeContent(element, contents) {
        var domElement = document.getElementById(element);
        domElement.innerHTML = '';
        var divItem;
        for(let i = 0; i < contents.length; i++){
            divItem = document.createElement('div')
            divItem.innerText = contents[i];
            domElement.appendChild(divItem);
        }
    }*/
};