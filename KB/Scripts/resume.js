

/*Credits http://themes.jsonresume.org/theme/elegant */

	
$(function () {
  var toggleFloatingMenu = function() {
    $( '.js-floating-nav' ).toggleClass( 'is-visible' );
    $( '.js-floating-nav-trigger' ).toggleClass( 'is-open' );
  };

  $( ".background-card" ).css( "min-height", window.screen.availHeight + "px" );
  $( "[rel=tooltip]" ).tooltip();
  $( '.js-floating-nav-trigger' ).on( 'click', function(e) {
    e.preventDefault();
    toggleFloatingMenu();
  });
  $( '.js-floating-nav a' ).on( 'click', toggleFloatingMenu );

  $("#remaining-profiles").on('show.bs.collapse', function() {
    $( '.js-profiles-collapse > i' )
      .removeClass( 'icon-chevron-down' )
      .addClass( 'icon-chevron-up' );
  });

  $("#remaining-profiles").on('hidden.bs.collapse', function() {
    $( '.js-profiles-collapse > i' )
      .removeClass( 'icon-chevron-up' )
      .addClass( 'icon-chevron-down' );
  });
});



WebFontConfig = {
  google: { families: [ 'Lato:300,400,700:latin' ] }
};


(function() {
  var wf = document.createElement('script');
  wf.src = ('https:' == document.location.protocol ? 'https' : 'http') +
    '://ajax.googleapis.com/ajax/libs/webfont/1/webfont.js';
  wf.type = 'text/javascript';
  wf.async = 'true';
  var s = document.getElementsByTagName('script')[0];
  s.parentNode.insertBefore(wf, s);
})();

