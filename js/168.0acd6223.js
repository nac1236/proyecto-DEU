"use strict";(self["webpackChunkproyecto_deu"]=self["webpackChunkproyecto_deu"]||[]).push([[168],{168:function(e,t,o){o.r(t),o.d(t,{startTapClick:function(){return s}});var n=o(587);
/*!
 * (C) Ionic http://ionicframework.com - MIT License
 */const s=e=>{let t,o,s,v=10*-l,f=0;const p=e.getBoolean("animated",!0)&&e.getBoolean("rippleEffect",!0),h=new WeakMap,m=e=>{v=(0,n.u)(e),b(e)},L=e=>{v=(0,n.u)(e),g(e)},w=e=>{const t=(0,n.u)(e)-l;v<t&&b(e)},E=e=>{const t=(0,n.u)(e)-l;v<t&&g(e)},k=e=>{g(e)},T=()=>{clearTimeout(s),s=void 0,t&&(q(!1),t=void 0)},b=e=>{t||y(i(e),e)},g=e=>{y(void 0,e)},y=(e,o)=>{if(e&&e===t)return;clearTimeout(s),s=void 0;const{x:i,y:c}=(0,n.q)(o);if(t){if(h.has(t))throw new Error("internal error");t.classList.contains(r)||R(t,i,c),q(!0)}if(e){const t=h.get(e);t&&(clearTimeout(t),h.delete(e));const o=a(e)?0:d;e.classList.remove(r),s=setTimeout((()=>{R(e,i,c),s=void 0}),o)}t=e},R=(e,t,n)=>{f=Date.now(),e.classList.add(r);const s=p&&c(e);s&&s.addRipple&&(C(),o=s.addRipple(t,n))},C=()=>{void 0!==o&&(o.then((e=>e())),o=void 0)},q=e=>{C();const o=t;if(!o)return;const n=u-Date.now()+f;if(e&&n>0&&!a(o)){const e=setTimeout((()=>{o.classList.remove(r),h.delete(o)}),u);h.set(o,e)}else o.classList.remove(r)},S=document;S.addEventListener("ionGestureCaptured",T),S.addEventListener("touchstart",m,!0),S.addEventListener("touchcancel",L,!0),S.addEventListener("touchend",L,!0),S.addEventListener("pointercancel",T,!0),S.addEventListener("mousedown",w,!0),S.addEventListener("mouseup",E,!0),S.addEventListener("contextmenu",k,!0)},i=e=>{if(!e.composedPath)return e.target.closest(".ion-activatable");{const t=e.composedPath();for(let e=0;e<t.length-2;e++){const o=t[e];if(!(o instanceof ShadowRoot)&&o.classList.contains("ion-activatable"))return o}}},a=e=>e.classList.contains("ion-activatable-instant"),c=e=>{if(e.shadowRoot){const t=e.shadowRoot.querySelector("ion-ripple-effect");if(t)return t}return e.querySelector("ion-ripple-effect")},r="ion-activated",d=200,u=200,l=2500}}]);
//# sourceMappingURL=168.0acd6223.js.map