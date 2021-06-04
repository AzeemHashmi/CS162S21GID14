var abc = document.getElementById('hello');
var    post = '';
///////////////////////////////////////////////////
for(var i=1;i<12;i++)
{
    var like = "\"like"+i+"\"";
    var likeIcon =  "\"likeIcon"+i+"\"";
     post +=  '<div class="container" style="margin-top:  5%;" id="post"' +i+'>'
    + '<div class="row">'
    + '<div class="col-md">'
    + '</div>'
    + '<div class="col-md">'
    + '<div class="card">'
    + '<div class="bg-image hover-overlay ripple" data-mdb-ripple-color="light">'
    + '<img '
    +   'src="https://mdbootstrap.com/img/new/standard/nature/111.jpg"'
    +   'class="img-fluid"'
    + '/>'
    + '<a href="#!">'
    +   '<div class="mask" style="background-color: rgba(251, 251, 251, 0.15);"></div>'
    + '</a>'
    + '</div>'
    + '<div class="card-body">'
    + '<h5 class="card-title">Card title</h5>'
    + '<p class="card-text">'
    +            'Some quick example text to build on the card title and make up the bulk of the card\'s content.'
    + '</p>'
    +'<div class="actions">'
    +  '<a href="#!"  class="btn btn-primary btn-dark" id='+like+' onclick="liked(this);" >'
    +     '<i class="far fa-thumbs-up fa-lg" id='+likeIcon+'></i>'
    + '</a>'
    + '<a href="#!" class="btn btn-primary btn-black" id="comment"'+i+'>'
    +   '<i class="fas fa-comments fa-lg" id="commentIcon"></i>'
    + '</a>'
    + '<a href="#!" class="btn btn-primary id="share"'+i+'>'
    +   '<i class="fas fa-share fa-lg" id="shareIcon"></i>'
    + '</a>'
    +'</div>'
    + '</div>'
    + '</div>'
    + '</div>'
    + '<div class="col-md">'
    + '</div>'
    + '</div>'
    +'</div>';
    console.log(likeIcon);
}
// var str = ' <div class='container'>'+
//  '<div class='row'> <div class='col-md'>Hello</div> <div class='col-md'>Workd</div> <div class='col-md'>Mysterius</div></div></div> ';
// console.log(str); 
document.getElementById('postPut').innerHTML = post;
function liked(ele){
    var a = ele.id;
    var b = a.substring(4);
    var change = "likeIcon"+b;
    console.log("likeIcon"+b);
    if(document.getElementById(change).classList.contains('far'))
    {
    document.getElementById(change).classList.replace('far','fas');
    }
    else if(document.getElementById(change).classList.contains('fas'))
    {
        document.getElementById(change).classList.replace('fas','far');
    }
    // for(var i=0;i<10;i++)
    // {
    //     if(document.getElementById(this.id))
    //     {
    //         document.getElementById('likeIcon').classList.remove(0);
    //     document.getElementById('likeIcon').classList.replace('far','fas');
    //     console.log( document.getElementById('likeIcon').classList.toString());
    //     }
    // }
}