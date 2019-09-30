window.Modernizr=function(e,t,n){function r(e){g.cssText=e}function a(e,t){return r(x.join(e+";")+(t||""))}function o(e,t){return typeof e===t}function i(e,t){return!!~(""+e).indexOf(t)}function s(e,t){for(var r in e){var a=e[r];if(!i(a,"-")&&g[a]!==n)return"pfx"!=t||a}return!1}function c(e,t,r){for(var a in e){var i=t[e[a]];if(i!==n)return!1===r?e[a]:o(i,"function")?i.bind(r||t):i}return!1}function l(e,t,n){var r=e.charAt(0).toUpperCase()+e.slice(1),a=(e+" "+E.join(r+" ")+r).split(" ");return o(t,"string")||o(t,"undefined")?s(a,t):(a=(e+" "+w.join(r+" ")+r).split(" "),c(a,t,n))}var u,d,m={},f=t.documentElement,p="modernizr",h=t.createElement(p),g=h.style,v=t.createElement("input"),y=":)",b={}.toString,x=" -webkit- -moz- -o- -ms- ".split(" "),E="Webkit Moz O ms".split(" "),w="Webkit Moz O ms".toLowerCase().split(" "),S={svg:"http://www.w3.org/2000/svg"},C={},T={},k={},M=[],$=M.slice,z=function(e,n,r,a){var o,i,s,c,l=t.createElement("div"),u=t.body,d=u||t.createElement("body");if(parseInt(r,10))for(;r--;)(s=t.createElement("div")).id=a?a[r]:p+(r+1),l.appendChild(s);return o=["&#173;",'<style id="s',p,'">',e,"</style>"].join(""),l.id=p,(u?l:d).innerHTML+=o,d.appendChild(l),u||(d.style.background="",d.style.overflow="hidden",c=f.style.overflow,f.style.overflow="hidden",f.appendChild(d)),i=n(l,e),u?l.parentNode.removeChild(l):(d.parentNode.removeChild(d),f.style.overflow=c),!!i},N=function(){var e={select:"input",change:"input",submit:"form",reset:"form",error:"img",load:"img",abort:"img"};return function(r,a){a=a||t.createElement(e[r]||"div");var i=(r="on"+r)in a;return i||(a.setAttribute||(a=t.createElement("div")),a.setAttribute&&a.removeAttribute&&(a.setAttribute(r,""),i=o(a[r],"function"),o(a[r],"undefined")||(a[r]=n),a.removeAttribute(r))),a=null,i}}(),P={}.hasOwnProperty;d=o(P,"undefined")||o(P.call,"undefined")?function(e,t){return t in e&&o(e.constructor.prototype[t],"undefined")}:function(e,t){return P.call(e,t)},Function.prototype.bind||(Function.prototype.bind=function(e){var t=this;if("function"!=typeof t)throw new TypeError;var n=$.call(arguments,1),r=function(){if(this instanceof r){var a=function(){};a.prototype=t.prototype;var o=new a,i=t.apply(o,n.concat($.call(arguments)));return Object(i)===i?i:o}return t.apply(e,n.concat($.call(arguments)))};return r}),C.flexbox=function(){return l("flexWrap")},C.canvas=function(){var e=t.createElement("canvas");return!(!e.getContext||!e.getContext("2d"))},C.canvastext=function(){return!(!m.canvas||!o(t.createElement("canvas").getContext("2d").fillText,"function"))},C.webgl=function(){return!!e.WebGLRenderingContext},C.touch=function(){var n;return"ontouchstart"in e||e.DocumentTouch&&t instanceof DocumentTouch?n=!0:z(["@media (",x.join("touch-enabled),("),p,")","{#modernizr{top:9px;position:absolute}}"].join(""),function(e){n=9===e.offsetTop}),n},C.geolocation=function(){return"geolocation"in navigator},C.postmessage=function(){return!!e.postMessage},C.websqldatabase=function(){return!!e.openDatabase},C.indexedDB=function(){return!!l("indexedDB",e)},C.hashchange=function(){return N("hashchange",e)&&(t.documentMode===n||t.documentMode>7)},C.history=function(){return!(!e.history||!history.pushState)},C.draganddrop=function(){var e=t.createElement("div");return"draggable"in e||"ondragstart"in e&&"ondrop"in e},C.websockets=function(){return"WebSocket"in e||"MozWebSocket"in e},C.rgba=function(){return r("background-color:rgba(150,255,150,.5)"),i(g.backgroundColor,"rgba")},C.hsla=function(){return r("background-color:hsla(120,40%,100%,.5)"),i(g.backgroundColor,"rgba")||i(g.backgroundColor,"hsla")},C.multiplebgs=function(){return r("background:url(https://),url(https://),red url(https://)"),/(url\s*\(.*?){3}/.test(g.background)},C.backgroundsize=function(){return l("backgroundSize")},C.borderimage=function(){return l("borderImage")},C.borderradius=function(){return l("borderRadius")},C.boxshadow=function(){return l("boxShadow")},C.textshadow=function(){return""===t.createElement("div").style.textShadow},C.opacity=function(){return a("opacity:.55"),/^0.55$/.test(g.opacity)},C.cssanimations=function(){return l("animationName")},C.csscolumns=function(){return l("columnCount")},C.cssgradients=function(){var e="background-image:";return r((e+"-webkit- ".split(" ").join("gradient(linear,left top,right bottom,from(#9f9),to(white));"+e)+x.join("linear-gradient(left top,#9f9, white);"+e)).slice(0,-e.length)),i(g.backgroundImage,"gradient")},C.cssreflections=function(){return l("boxReflect")},C.csstransforms=function(){return!!l("transform")},C.csstransforms3d=function(){var e=!!l("perspective");return e&&"webkitPerspective"in f.style&&z("@media (transform-3d),(-webkit-transform-3d){#modernizr{left:9px;position:absolute;height:3px;}}",function(t,n){e=9===t.offsetLeft&&3===t.offsetHeight}),e},C.csstransitions=function(){return l("transition")},C.fontface=function(){var e;return z('@font-face {font-family:"font";src:url("https://")}',function(n,r){var a=t.getElementById("smodernizr"),o=a.sheet||a.styleSheet,i=o?o.cssRules&&o.cssRules[0]?o.cssRules[0].cssText:o.cssText||"":"";e=/src/i.test(i)&&0===i.indexOf(r.split(" ")[0])}),e},C.generatedcontent=function(){var e;return z(["#",p,"{font:0/0 a}#",p,':after{content:"',y,'";visibility:hidden;font:3px/1 a}'].join(""),function(t){e=t.offsetHeight>=3}),e},C.video=function(){var e=t.createElement("video"),n=!1;try{(n=!!e.canPlayType)&&((n=new Boolean(n)).ogg=e.canPlayType('video/ogg; codecs="theora"').replace(/^no$/,""),n.h264=e.canPlayType('video/mp4; codecs="avc1.42E01E"').replace(/^no$/,""),n.webm=e.canPlayType('video/webm; codecs="vp8, vorbis"').replace(/^no$/,""))}catch(e){}return n},C.audio=function(){var e=t.createElement("audio"),n=!1;try{(n=!!e.canPlayType)&&((n=new Boolean(n)).ogg=e.canPlayType('audio/ogg; codecs="vorbis"').replace(/^no$/,""),n.mp3=e.canPlayType("audio/mpeg;").replace(/^no$/,""),n.wav=e.canPlayType('audio/wav; codecs="1"').replace(/^no$/,""),n.m4a=(e.canPlayType("audio/x-m4a;")||e.canPlayType("audio/aac;")).replace(/^no$/,""))}catch(e){}return n},C.localstorage=function(){try{return localStorage.setItem(p,p),localStorage.removeItem(p),!0}catch(e){return!1}},C.sessionstorage=function(){try{return sessionStorage.setItem(p,p),sessionStorage.removeItem(p),!0}catch(e){return!1}},C.webworkers=function(){return!!e.Worker},C.applicationcache=function(){return!!e.applicationCache},C.svg=function(){return!!t.createElementNS&&!!t.createElementNS(S.svg,"svg").createSVGRect},C.inlinesvg=function(){var e=t.createElement("div");return e.innerHTML="<svg/>",(e.firstChild&&e.firstChild.namespaceURI)==S.svg},C.smil=function(){return!!t.createElementNS&&/SVGAnimate/.test(b.call(t.createElementNS(S.svg,"animate")))},C.svgclippaths=function(){return!!t.createElementNS&&/SVGClipPath/.test(b.call(t.createElementNS(S.svg,"clipPath")))};for(var j in C)d(C,j)&&(u=j.toLowerCase(),m[u]=C[j](),M.push((m[u]?"":"no-")+u));return m.input||(m.input=function(n){for(var r=0,a=n.length;r<a;r++)k[n[r]]=!!(n[r]in v);return k.list&&(k.list=!(!t.createElement("datalist")||!e.HTMLDataListElement)),k}("autocomplete autofocus list placeholder max min multiple pattern required step".split(" ")),m.inputtypes=function(e){for(var r,a,o,i=0,s=e.length;i<s;i++)v.setAttribute("type",a=e[i]),(r="text"!==v.type)&&(v.value=y,v.style.cssText="position:absolute;visibility:hidden;",/^range$/.test(a)&&v.style.WebkitAppearance!==n?(f.appendChild(v),r=(o=t.defaultView).getComputedStyle&&"textfield"!==o.getComputedStyle(v,null).WebkitAppearance&&0!==v.offsetHeight,f.removeChild(v)):/^(search|tel)$/.test(a)||(r=/^(url|email)$/.test(a)?v.checkValidity&&!1===v.checkValidity():v.value!=y)),T[e[i]]=!!r;return T}("search tel url email datetime date month week time datetime-local number range color".split(" "))),m.addTest=function(e,t){if("object"==typeof e)for(var r in e)d(e,r)&&m.addTest(r,e[r]);else{if(e=e.toLowerCase(),m[e]!==n)return m;t="function"==typeof t?t():t,f.className+=" "+(t?"":"no-")+e,m[e]=t}return m},r(""),h=v=null,function(e,t){function n(e,t){var n=e.createElement("p"),r=e.getElementsByTagName("head")[0]||e.documentElement;return n.innerHTML="x<style>"+t+"</style>",r.insertBefore(n.lastChild,r.firstChild)}function r(){var e=g.elements;return"string"==typeof e?e.split(" "):e}function a(e){var t=h[e[f]];return t||(t={},p++,e[f]=p,h[p]=t),t}function o(e,n,r){if(n||(n=t),l)return n.createElement(e);r||(r=a(n));var o;return!(o=r.cache[e]?r.cache[e].cloneNode():m.test(e)?(r.cache[e]=r.createElem(e)).cloneNode():r.createElem(e)).canHaveChildren||d.test(e)||o.tagUrn?o:r.frag.appendChild(o)}function i(e,t){t.cache||(t.cache={},t.createElem=e.createElement,t.createFrag=e.createDocumentFragment,t.frag=t.createFrag()),e.createElement=function(n){return g.shivMethods?o(n,e,t):t.createElem(n)},e.createDocumentFragment=Function("h,f","return function(){var n=f.cloneNode(),c=n.createElement;h.shivMethods&&("+r().join().replace(/[\w\-]+/g,function(e){return t.createElem(e),t.frag.createElement(e),'c("'+e+'")'})+");return n}")(g,t.frag)}function s(e){e||(e=t);var r=a(e);return!g.shivCSS||c||r.hasCSS||(r.hasCSS=!!n(e,"article,aside,dialog,figcaption,figure,footer,header,hgroup,main,nav,section{display:block}mark{background:#FF0;color:#000}template{display:none}")),l||i(e,r),e}var c,l,u=e.html5||{},d=/^<|^(?:button|map|select|textarea|object|iframe|option|optgroup)$/i,m=/^(?:a|b|code|div|fieldset|h1|h2|h3|h4|h5|h6|i|label|li|ol|p|q|span|strong|style|table|tbody|td|th|tr|ul)$/i,f="_html5shiv",p=0,h={};!function(){try{var e=t.createElement("a");e.innerHTML="<xyz></xyz>",c="hidden"in e,l=1==e.childNodes.length||function(){t.createElement("a");var e=t.createDocumentFragment();return void 0===e.cloneNode||void 0===e.createDocumentFragment||void 0===e.createElement}()}catch(e){c=!0,l=!0}}();var g={elements:u.elements||"abbr article aside audio bdi canvas data datalist details dialog figcaption figure footer header hgroup main mark meter nav output progress section summary template time video",version:"3.7.0",shivCSS:!1!==u.shivCSS,supportsUnknownElements:l,shivMethods:!1!==u.shivMethods,type:"default",shivDocument:s,createElement:o,createDocumentFragment:function(e,n){if(e||(e=t),l)return e.createDocumentFragment();for(var o=(n=n||a(e)).frag.cloneNode(),i=0,s=r(),c=s.length;i<c;i++)o.createElement(s[i]);return o}};e.html5=g,s(t)}(this,t),m._version="2.8.1",m._prefixes=x,m._domPrefixes=w,m._cssomPrefixes=E,m.mq=function(t){var n=e.matchMedia||e.msMatchMedia;if(n)return n(t)&&n(t).matches||!1;var r;return z("@media "+t+" { #"+p+" { position: absolute; } }",function(t){r="absolute"==(e.getComputedStyle?getComputedStyle(t,null):t.currentStyle).position}),r},m.hasEvent=N,m.testProp=function(e){return s([e])},m.testAllProps=l,m.testStyles=z,m.prefixed=function(e,t,n){return t?l(e,t,n):l(e,"pfx")},f.className=f.className.replace(/(^|\s)no-js(\s|$)/,"$1$2")+" js "+M.join(" "),m}(this,this.document),function(e){"use strict";e.matchMedia=e.matchMedia||function(e,t){var n,r=e.documentElement,a=r.firstElementChild||r.firstChild,o=e.createElement("body"),i=e.createElement("div");return i.id="mq-test-1",i.style.cssText="position:absolute;top:-100em",o.style.background="none",o.appendChild(i),function(e){return i.innerHTML='&shy;<style media="'+e+'"> #mq-test-1 { width: 42px; }</style>',r.insertBefore(o,a),n=42===i.offsetWidth,r.removeChild(o),{matches:n,media:e}}}(e.document)}(this),function(e){"use strict";function t(){x(!0)}var n={};e.respond=n,n.update=function(){};var r=[],a=function(){var t=!1;try{t=new e.XMLHttpRequest}catch(n){t=new e.ActiveXObject("Microsoft.XMLHTTP")}return function(){return t}}(),o=function(e,t){var n=a();n&&(n.open("GET",e,!0),n.onreadystatechange=function(){4!==n.readyState||200!==n.status&&304!==n.status||t(n.responseText)},4!==n.readyState&&n.send(null))},i=function(e){return e.replace(n.regex.minmaxwh,"").match(n.regex.other)};if(n.ajax=o,n.queue=r,n.unsupportedmq=i,n.regex={media:/@media[^\{]+\{([^\{\}]*\{[^\}\{]*\})+/gi,keyframes:/@(?:\-(?:o|moz|webkit)\-)?keyframes[^\{]+\{(?:[^\{\}]*\{[^\}\{]*\})+[^\}]*\}/gi,comments:/\/\*[^*]*\*+([^/][^*]*\*+)*\//gi,urls:/(url\()['"]?([^\/\)'"][^:\)'"]+)['"]?(\))/g,findStyles:/@media *([^\{]+)\{([\S\s]+?)$/,only:/(only\s+)?([a-zA-Z]+)\s?/,minw:/\(\s*min\-width\s*:\s*(\s*[0-9\.]+)(px|em)\s*\)/,maxw:/\(\s*max\-width\s*:\s*(\s*[0-9\.]+)(px|em)\s*\)/,minmaxwh:/\(\s*m(in|ax)\-(height|width)\s*:\s*(\s*[0-9\.]+)(px|em)\s*\)/gi,other:/\([^\)]*\)/g},n.mediaQueriesSupported=e.matchMedia&&null!==e.matchMedia("only all")&&e.matchMedia("only all").matches,!n.mediaQueriesSupported){var s,c,l,u=e.document,d=u.documentElement,m=[],f=[],p=[],h={},g=u.getElementsByTagName("head")[0]||d,v=u.getElementsByTagName("base")[0],y=g.getElementsByTagName("link"),b=function(){var e,t=u.createElement("div"),n=u.body,r=d.style.fontSize,a=n&&n.style.fontSize,o=!1;return t.style.cssText="position:absolute;font-size:1em;width:1em",n||((n=o=u.createElement("body")).style.background="none"),d.style.fontSize="100%",n.style.fontSize="100%",n.appendChild(t),o&&d.insertBefore(n,d.firstChild),e=t.offsetWidth,o?d.removeChild(n):n.removeChild(t),d.style.fontSize=r,a&&(n.style.fontSize=a),e=l=parseFloat(e)},x=function(t){var n=d.clientWidth,r="CSS1Compat"===u.compatMode&&n||u.body.clientWidth||n,a={},o=y[y.length-1],i=(new Date).getTime();if(t&&s&&i-s<30)return e.clearTimeout(c),void(c=e.setTimeout(x,30));s=i;for(var h in m)if(m.hasOwnProperty(h)){var v=m[h],E=v.minw,w=v.maxw,S=null===E,C=null===w;E&&(E=parseFloat(E)*(E.indexOf("em")>-1?l||b():1)),w&&(w=parseFloat(w)*(w.indexOf("em")>-1?l||b():1)),v.hasquery&&(S&&C||!(S||r>=E)||!(C||r<=w))||(a[v.media]||(a[v.media]=[]),a[v.media].push(f[v.rules]))}for(var T in p)p.hasOwnProperty(T)&&p[T]&&p[T].parentNode===g&&g.removeChild(p[T]);p.length=0;for(var k in a)if(a.hasOwnProperty(k)){var M=u.createElement("style"),$=a[k].join("\n");M.type="text/css",M.media=k,g.insertBefore(M,o.nextSibling),M.styleSheet?M.styleSheet.cssText=$:M.appendChild(u.createTextNode($)),p.push(M)}},E=function(e,t,r){var a=e.replace(n.regex.comments,"").replace(n.regex.keyframes,"").match(n.regex.media),o=a&&a.length||0;t=t.substring(0,t.lastIndexOf("/"));var s=function(e){return e.replace(n.regex.urls,"$1"+t+"$2$3")},c=!o&&r;t.length&&(t+="/"),c&&(o=1);for(var l=0;l<o;l++){var u,d,p,h;c?(u=r,f.push(s(e))):(u=a[l].match(n.regex.findStyles)&&RegExp.$1,f.push(RegExp.$2&&s(RegExp.$2))),h=(p=u.split(",")).length;for(var g=0;g<h;g++)d=p[g],i(d)||m.push({media:d.split("(")[0].match(n.regex.only)&&RegExp.$2||"all",rules:f.length-1,hasquery:d.indexOf("(")>-1,minw:d.match(n.regex.minw)&&parseFloat(RegExp.$1)+(RegExp.$2||""),maxw:d.match(n.regex.maxw)&&parseFloat(RegExp.$1)+(RegExp.$2||"")})}x()},w=function(){if(r.length){var t=r.shift();o(t.href,function(n){E(n,t.href,t.media),h[t.href]=!0,e.setTimeout(function(){w()},0)})}},S=function(){for(var t=0;t<y.length;t++){var n=y[t],a=n.href,o=n.media,i=n.rel&&"stylesheet"===n.rel.toLowerCase();a&&i&&!h[a]&&(n.styleSheet&&n.styleSheet.rawCssText?(E(n.styleSheet.rawCssText,a,o),h[a]=!0):(/^([a-zA-Z:]*\/\/)/.test(a)||v)&&a.replace(RegExp.$1,"").split("/")[0]!==e.location.host||("//"===a.substring(0,2)&&(a=e.location.protocol+a),r.push({href:a,media:o})))}w()};S(),n.update=S,n.getEmValue=b,e.addEventListener?e.addEventListener("resize",t,!1):e.attachEvent&&e.attachEvent("onresize",t)}}(this);