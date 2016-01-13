

//********************Show View Port Size*******************************************************//

//Credit: https://benfrain.com/easily-display-the-viewport-size-of-your-page-for-responsive-designs/

$(document).ready(function (e)
{
    showViewportSize();
});


$(window).resize(function (e)
{
    showViewportSize();
});

function showViewportSize()
{
    var the_width = $(window).width();
    var the_height = $(window).height();
    $('#width').text(the_width);
    $('#height').text(the_height);
}

//*************************************************************************************************//