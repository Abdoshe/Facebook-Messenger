var css = "#pagelet_bluebar,#pagelet_dock,#pagelet_sidebar,#rightCol,#pageFooter{display:none}.uiScrollableAreaWithTopShadow.contentBefore::before, .uiScrollableAreaWithShadow.contentAfter::after{background:none !important;}._1rs .emoticonsPanel ._5r8f .panelFlyoutArrow{left: auto !important;right: 5px !important;}.emoticonsPanel div._5r8f.panelFlyout{right:0 !important;}._24g{visibility:hidden}.fbx #globalContainer,.UIFullPage_Container{width:100%!important;padding 0 !important;}._ksg{border-width: 0 !important;}#globalContainer{width:auto!important;padding-right:0!important}body{overflow:hidden!important;}._6jw,._r6,._2ak,body{background-color:#f6f6f6!important;}div._2nb{right:0;position:absolute;left:298px;width:auto!important}.uiCloseButton{border: 1px solid #ccc;border-radius:999em}.uiCloseButton:hover{border: 1px solid #6484B5}#contentArea,.uiScrollableAreaBody,div.uiScrollableArea{width:100%!important}div.wmMasterView{width:298px!important}.MercuryThreadImage,._2w7{border-radius:999em;overflow:hidden}._1rw{border-color:#e0e0e0}._1rs{padding:10px !important; background-color: #f6f6f6;}._2pt{margin:0;border-color:#e0e0e0;}div._1s5{right: 10px !important;top: 10px !important; left: auto!important;}ul._281 {height: 40px;}._1n {line-height: 40px;}._283 {top: 18px;}._50p_._282{margin-top:7px;}div.uiContextualLayer.uiContextualLayerBelowRight{top:-12px;}._r6{padding-top: 7px;padding-bottom: 9px;}._2nd{padding-top:2px}._l3 .emoticon{text-indent:-999em;} @media (max-width: 649px) {._l4,._3b,ul.uiList._281._4ki,div._l7.rfloat._ohf,div._1rw{display:none;}div.wmMasterView {width:70px!important}._2nb{left:70px!important;}._k-{border-color:#f6f6f6!important;}._2tm{background:#F6F6F6!important;}button._42ft._4jy0._3mv._4jy3._517h._51sy{width:10px;}.sp_ad5ugN8jTSF.sx_dfa704{margin-right: 10px}button#u_0_1b._42ft._4jy0._2cna._p._4jy3._517h._51sy{width:11px;}.sp_0F0jkP9kmet.sx_666843{margin-right:10px;}}";
var lastNotification;
var lastNotificationTime;

(function(f,b){if(!b.__SV){var a,e,i,g;window.mixpanel=b;b._i=[];b.init=function(a,e,d){function f(b,h){var a=h.split(".");2==a.length&&(b=b[a[0]],h=a[1]);b[h]=function(){b.push([h].concat(Array.prototype.slice.call(arguments,0)))}}var c=b;"undefined"!==typeof d?c=b[d]=[]:d="mixpanel";c.people=c.people||[];c.toString=function(b){var a="mixpanel";"mixpanel"!==d&&(a+="."+d);b||(a+=" (stub)");return a};c.people.toString=function(){return c.toString(1)+".people (stub)"};i="disable track track_pageview track_links track_forms register register_once alias unregister identify name_tag set_config people.set people.set_once people.increment people.append people.track_charge people.clear_charges people.delete_user".split(" ");
for(g=0;g<i.length;g++)f(c,i[g]);b._i.push([a,e,d])};b.__SV=1.2;a=f.createElement("script");a.type="text/javascript";a.async=!0;a.src="//cdn.mxpnl.com/libs/mixpanel-2-latest.min.js";e=f.getElementsByTagName("script")[0];e.parentNode.insertBefore(a,e)}})(document,window.mixpanel||[]);
mixpanel.init("2245181dbc803998dedc5b07d840e672");

var emoticonMapping = {
	"emoticon_smile"			:"??",
	"emoticon_frown"			:"??",
	"emoticon_poop"			:"??",
	"emoticon_putnam"		:":putnam:",
	"emoticon_tongue"		:"??",
	"emoticon_grin"			:"??",
	"emoticon_gasp"			:"??",
	"emoticon_wink"			:"??",
	"emoticon_glasses"		:"8-)",
	"emoticon_sunglasses"	:"??",
	"emoticon_grumpy"		:">:(",
	"emoticon_unsure"		:":/",
	"emoticon_cry"			:"??",
	"emoticon_devil"			:"??",
	"emoticon_angel"			:"??",
	"emoticon_kiss"			:"??",
	"emoticon_heart"			:"?",
	"emoticon_kiki"			:"??",
	"emoticon_squint"		:"??",
	"emoticon_confused"		:"??",
	"emoticon_confused_rev"	:"??",
	"emoticon_upset"			:">:o",
	"emoticon_pacman"		:":v",
	"emoticon_robot"			:":|]",
	"emoticon_colonthree"	:":3",
	"emoticon_penguin"		:"??",
	"emoticon_shark"			:"(^^^)",
	"emoticon_like"			:"??"
};

csssetup = function() {
	head = document.head || document.getElementsByTagName( 'head' )[ 0 ];
	style = document.createElement( 'style' );
	style.type = 'text/css';
	if ( style.styleSheet ) {
			style.styleSheet.cssText = css;
	} else {
			style.appendChild( document.createTextNode( css ) );
	}
	head.appendChild( style );
};

function init() {

    csssetup();
    
    
	document.querySelector("._1n").addEventListener("DOMSubtreeModified", function() {
		dockCount();
	}, false );
	
	setInterval(function() {
		window.dispatchEvent(new Event('resize'));
		dockCount();
	}, 200);
	
	setTimeout(function() {
		mixpanel.track("loaded");
		window.webkit.messageHandlers.notification.postMessage({type: 'URL_CONFIG', backgroundURLs: ["facebook.com/xti.php","facebook.com/ai.php","fbcdn","spotilocal.com","facebook.com/ajax/music","facebook.com/sound_iframe"], inAppURLs: ["facebook.com/messages","facebook.com/login","facebook.com/checkpoint","spotilocal.com","facebook.com/ajax/music","facebook.com/sound_iframe"]});
	}, 3000);
	
	document.onkeydown = function () {
		var evtobj = window.event? event : e
		
		if (evtobj.metaKey && evtobj.keyCode==221) {
			//next
			document.querySelector('._kv').nextElementSibling.firstChild.childNodes[1].click();
			return false;
		}
		
		if (evtobj.metaKey && evtobj.keyCode==219) {
			//prev
			document.querySelector('._kv').previousElementSibling.firstChild.childNodes[1].click();
			return false;
		}
		
		if (evtobj.keyCode > 48 && evtobj.keyCode < 58 && evtobj.ctrlKey) {
			document.querySelector(".uiList._2tm._4kg li:nth-child("+(evtobj.keyCode-48)+") ._k_").click();
			return false;
		}
	};
    
}

function reactivation() {
	if (new Date().getTime() < lastNotificationTime + 1000*60*2) {
		document.querySelector('._kx ._l2').click();
	}
}

function dockCount() {
	var c = document.querySelector(".pls._1r.fwn");
	if (c.classList.contains('hidden_elem')) {
		window.webkit.messageHandlers.notification.postMessage({type: 'DOCK_COUNT', content: "0"});
	} else {
		
		[].forEach.call(document.querySelectorAll('._kx ._l3 .emoticon_text'), function(e) {e.textContent = "";});
		
		[].forEach.call(document.querySelectorAll('._kx ._l3 .emoticon'), function(e) {
			for (a in emoticonMapping) {
				if (e.classList.contains(a)) {
					console.log(emoticonMapping[a]);
					e.textContent = emoticonMapping[a];
					break;
				}
			}
		});
		
		var subtitle = document.querySelector('._kx ._l2 ._l1').textContent;
		var text = document.querySelector('._kx ._l3').textContent;
		if (lastNotification != subtitle+text) {
			window.webkit.messageHandlers.notification.postMessage({type: 'NOTIFICATION', title: subtitle, text: text});
			lastNotification = subtitle+text;
			lastNotificationTime = new Date().getTime();
		}
		
		window.webkit.messageHandlers.notification.postMessage({type: 'DOCK_COUNT', content: document.querySelector(".pls._1r.fwn").textContent.replace(/\D/g,'')});
	}
}

