"use strict";(self["webpackChunkproyecto_deu"]=self["webpackChunkproyecto_deu"]||[]).push([[980],{980:function(e,t,n){n.d(t,{c:function(){return y}});var o=n(587);
/*!
 * (C) Ionic http://ionicframework.com - MIT License
 */let i;const a=e=>(e.forEach((e=>{for(const t in e)if(e.hasOwnProperty(t)){const n=e[t];if("easing"===t){const o="animation-timing-function";e[o]=n,delete e[t]}else{const o=r(t);o!==t&&(e[o]=n,delete e[t])}}})),e),r=e=>e.replace(/([a-z0-9])([A-Z])/g,"$1-$2").toLowerCase(),s=e=>{if(void 0===i){const t=void 0!==e.style.animationName,n=void 0!==e.style.webkitAnimationName;i=!t&&n?"-webkit-":""}return i},f=(e,t,n)=>{const o=t.startsWith("animation")?s(e):"";e.style.setProperty(o+t,n)},l=(e,t)=>{const n=t.startsWith("animation")?s(e):"";e.style.removeProperty(n+t)},c=(e,t)=>{let n;const o={passive:!0},i=()=>{n&&n()},a=n=>{e===n.target&&(i(),t(n))};return e&&(e.addEventListener("webkitAnimationEnd",a,o),e.addEventListener("animationend",a,o),n=()=>{e.removeEventListener("webkitAnimationEnd",a,o),e.removeEventListener("animationend",a,o)}),i},d=(e=[])=>e.map((e=>{const t=e.offset,n=[];for(const o in e)e.hasOwnProperty(o)&&"offset"!==o&&n.push(`${o}: ${e[o]};`);return`${100*t}% { ${n.join(" ")} }`})).join(" "),m=[],u=e=>{let t=m.indexOf(e);return t<0&&(t=m.push(e)-1),`ion-animation-${t}`},h=e=>{const t=e.getRootNode();return t.head||t},p=(e,t,n)=>{const o=h(n),i=s(n),a=o.querySelector("#"+e);if(a)return a;const r=(n.ownerDocument||document).createElement("style");return r.id=e,r.textContent=`@${i}keyframes ${e} { ${t} } @${i}keyframes ${e}-alt { ${t} }`,o.appendChild(r),r},g=(e=[],t)=>{if(void 0!==t){const n=Array.isArray(t)?t:[t];return[...e,...n]}return e},y=e=>{let t,n,i,r,s,m,h,y,v,E,$,A,b,C=[],w=[],k=[],T=!1,S={},D=[],L=[],P={},F=0,R=!1,N=!1,O=!0,W=!1,K=!0,x=!1;const I=e,j=[],M=[],_=[],q=[],z=[],Z=[],B=[],G=[],H=[],J=[],Q="function"===typeof AnimationEffect||"function"===typeof window.AnimationEffect,U="function"===typeof Element&&"function"===typeof Element.prototype.animate&&Q,V=100,X=()=>J,Y=e=>(q.forEach((t=>{t.destroy(e)})),ee(e),_.length=0,q.length=0,C.length=0,ie(),T=!1,K=!0,b),ee=e=>{ae(),e&&re()},te=()=>{R=!1,N=!1,K=!0,v=void 0,E=void 0,$=void 0,F=0,W=!1,O=!0,x=!1},ne=()=>0!==F&&!x,oe=(e,t)=>{const n=(null===t||void 0===t?void 0:t.oneTimeCallback)?M:j;return n.push({c:e,o:t}),b},ie=()=>(j.length=0,M.length=0,b),ae=()=>{if(U)J.forEach((e=>{e.cancel()})),J.length=0;else{const e=_.slice();(0,o.r)((()=>{e.forEach((e=>{l(e,"animation-name"),l(e,"animation-duration"),l(e,"animation-timing-function"),l(e,"animation-iteration-count"),l(e,"animation-delay"),l(e,"animation-play-state"),l(e,"animation-fill-mode"),l(e,"animation-direction")}))}))}},re=()=>{z.forEach((e=>{(null===e||void 0===e?void 0:e.parentNode)&&e.parentNode.removeChild(e)})),z.length=0},se=e=>(Z.push(e),b),fe=e=>(B.push(e),b),le=e=>(G.push(e),b),ce=e=>(H.push(e),b),de=e=>(w=g(w,e),b),me=e=>(k=g(k,e),b),ue=(e={})=>(S=e,b),he=(e=[])=>{for(const t of e)S[t]="";return b},pe=e=>(D=g(D,e),b),ge=e=>(L=g(L,e),b),ye=(e={})=>(P=e,b),ve=(e=[])=>{for(const t of e)P[t]="";return b},Ee=()=>void 0!==s?s:h?h.getFill():"both",$e=()=>void 0!==v?v:void 0!==m?m:h?h.getDirection():"normal",Ae=()=>R?"linear":void 0!==i?i:h?h.getEasing():"linear",be=()=>N?0:void 0!==E?E:void 0!==n?n:h?h.getDuration():0,Ce=()=>void 0!==r?r:h?h.getIterations():1,we=()=>void 0!==$?$:void 0!==t?t:h?h.getDelay():0,ke=()=>C,Te=e=>(m=e,Ge(!0),b),Se=e=>(s=e,Ge(!0),b),De=e=>(t=e,Ge(!0),b),Le=e=>(i=e,Ge(!0),b),Pe=e=>(U||0!==e||(e=1),n=e,Ge(!0),b),Fe=e=>(r=e,Ge(!0),b),Re=e=>(h=e,b),Ne=e=>{if(null!=e)if(1===e.nodeType)_.push(e);else if(e.length>=0)for(let t=0;t<e.length;t++)_.push(e[t]);else console.error("Invalid addElement value");return b},Oe=e=>{if(null!=e)if(Array.isArray(e))for(const t of e)t.parent(b),q.push(t);else e.parent(b),q.push(e);return b},We=e=>{const t=C!==e;return C=e,t&&Ke(C),b},Ke=e=>{U?X().forEach((t=>{if(t.effect.setKeyframes)t.effect.setKeyframes(e);else{const n=new KeyframeEffect(t.effect.target,e,t.effect.getTiming());t.effect=n}})):Me()},xe=()=>{Z.forEach((e=>e())),B.forEach((e=>e()));const e=w,t=k,n=S;_.forEach((o=>{const i=o.classList;e.forEach((e=>i.add(e))),t.forEach((e=>i.remove(e)));for(const e in n)n.hasOwnProperty(e)&&f(o,e,n[e])}))},Ie=()=>{Ye(),G.forEach((e=>e())),H.forEach((e=>e()));const e=O?1:0,t=D,n=L,o=P;_.forEach((e=>{const i=e.classList;t.forEach((e=>i.add(e))),n.forEach((e=>i.remove(e)));for(const t in o)o.hasOwnProperty(t)&&f(e,t,o[t])})),j.forEach((t=>t.c(e,b))),M.forEach((t=>t.c(e,b))),M.length=0,K=!0,O&&(W=!0),O=!0},je=()=>{0!==F&&(F--,0===F&&(Ie(),h&&h.animationFinish()))},Me=(t=!0)=>{re();const n=a(C);_.forEach((i=>{if(n.length>0){const a=d(n);A=void 0!==e?e:u(a);const r=p(A,a,i);z.push(r),f(i,"animation-duration",`${be()}ms`),f(i,"animation-timing-function",Ae()),f(i,"animation-delay",`${we()}ms`),f(i,"animation-fill-mode",Ee()),f(i,"animation-direction",$e());const s=Ce()===1/0?"infinite":Ce().toString();f(i,"animation-iteration-count",s),f(i,"animation-play-state","paused"),t&&f(i,"animation-name",`${r.id}-alt`),(0,o.r)((()=>{f(i,"animation-name",r.id||null)}))}}))},_e=()=>{_.forEach((e=>{const t=e.animate(C,{id:I,delay:we(),duration:be(),easing:Ae(),iterations:Ce(),fill:Ee(),direction:$e()});t.pause(),J.push(t)})),J.length>0&&(J[0].onfinish=()=>{je()})},qe=(e=!0)=>{xe(),C.length>0&&(U?_e():Me(e)),T=!0},ze=e=>{if(e=Math.min(Math.max(e,0),.9999),U)J.forEach((t=>{t.currentTime=t.effect.getComputedTiming().delay+be()*e,t.pause()}));else{const t=`-${be()*e}ms`;_.forEach((e=>{C.length>0&&(f(e,"animation-delay",t),f(e,"animation-play-state","paused"))}))}},Ze=e=>{J.forEach((e=>{e.effect.updateTiming({delay:we(),duration:be(),easing:Ae(),iterations:Ce(),fill:Ee(),direction:$e()})})),void 0!==e&&ze(e)},Be=(e=!0,t)=>{(0,o.r)((()=>{_.forEach((n=>{f(n,"animation-name",A||null),f(n,"animation-duration",`${be()}ms`),f(n,"animation-timing-function",Ae()),f(n,"animation-delay",void 0!==t?`-${t*be()}ms`:`${we()}ms`),f(n,"animation-fill-mode",Ee()||null),f(n,"animation-direction",$e()||null);const i=Ce()===1/0?"infinite":Ce().toString();f(n,"animation-iteration-count",i),e&&f(n,"animation-name",`${A}-alt`),(0,o.r)((()=>{f(n,"animation-name",A||null)}))}))}))},Ge=(e=!1,t=!0,n)=>(e&&q.forEach((o=>{o.update(e,t,n)})),U?Ze(n):Be(t,n),b),He=(e=!1,t)=>(q.forEach((n=>{n.progressStart(e,t)})),Ue(),R=e,T||qe(),Ge(!1,!0,t),b),Je=e=>(q.forEach((t=>{t.progressStep(e)})),ze(e),b),Qe=(e,t,n)=>(R=!1,q.forEach((o=>{o.progressEnd(e,t,n)})),void 0!==n&&(E=n),W=!1,O=!0,0===e?(v="reverse"===$e()?"normal":"reverse","reverse"===v&&(O=!1),U?(Ge(),ze(1-t)):($=(1-t)*be()*-1,Ge(!1,!1))):1===e&&(U?(Ge(),ze(t)):($=t*be()*-1,Ge(!1,!1))),void 0!==e&&(oe((()=>{E=void 0,v=void 0,$=void 0}),{oneTimeCallback:!0}),h||it()),b),Ue=()=>{T&&(U?J.forEach((e=>{e.pause()})):_.forEach((e=>{f(e,"animation-play-state","paused")})),x=!0)},Ve=()=>(q.forEach((e=>{e.pause()})),Ue(),b),Xe=()=>{y=void 0,je()},Ye=()=>{y&&clearTimeout(y)},et=()=>{if(Ye(),(0,o.r)((()=>{_.forEach((e=>{C.length>0&&f(e,"animation-play-state","running")}))})),0===C.length||0===_.length)je();else{const e=we()||0,t=be()||0,n=Ce()||1;isFinite(n)&&(y=setTimeout(Xe,e+t*n+V)),c(_[0],(()=>{Ye(),(0,o.r)((()=>{tt(),(0,o.r)(je)}))}))}},tt=()=>{_.forEach((e=>{l(e,"animation-duration"),l(e,"animation-delay"),l(e,"animation-play-state")}))},nt=()=>{J.forEach((e=>{e.play()})),0!==C.length&&0!==_.length||je()},ot=()=>{U?(ze(0),Ze()):Be()},it=e=>new Promise((t=>{(null===e||void 0===e?void 0:e.sync)&&(N=!0,oe((()=>N=!1),{oneTimeCallback:!0})),T||qe(),W&&(ot(),W=!1),K&&(F=q.length+1,K=!1),oe((()=>t()),{oneTimeCallback:!0}),q.forEach((e=>{e.play()})),U?nt():et(),x=!1})),at=()=>{q.forEach((e=>{e.stop()})),T&&(ae(),T=!1),te()},rt=(e,t)=>{const n=C[0];return void 0===n||void 0!==n.offset&&0!==n.offset?C=[{offset:0,[e]:t},...C]:n[e]=t,b},st=(e,t)=>{const n=C[C.length-1];return void 0===n||void 0!==n.offset&&1!==n.offset?C=[...C,{offset:1,[e]:t}]:n[e]=t,b},ft=(e,t,n)=>rt(e,t).to(e,n);return b={parentAnimation:h,elements:_,childAnimations:q,id:I,animationFinish:je,from:rt,to:st,fromTo:ft,parent:Re,play:it,pause:Ve,stop:at,destroy:Y,keyframes:We,addAnimation:Oe,addElement:Ne,update:Ge,fill:Se,direction:Te,iterations:Fe,duration:Pe,easing:Le,delay:De,getWebAnimations:X,getKeyframes:ke,getFill:Ee,getDirection:$e,getDelay:we,getIterations:Ce,getEasing:Ae,getDuration:be,afterAddRead:le,afterAddWrite:ce,afterClearStyles:ve,afterStyles:ye,afterRemoveClass:ge,afterAddClass:pe,beforeAddRead:se,beforeAddWrite:fe,beforeClearStyles:he,beforeStyles:ue,beforeRemoveClass:me,beforeAddClass:de,onFinish:oe,isRunning:ne,progressStart:He,progressStep:Je,progressEnd:Qe}}}}]);
//# sourceMappingURL=980.cf1b6485.js.map