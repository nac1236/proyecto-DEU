<template>
    <ion-page>
        <ion-header>
        </ion-header>
        <ion-content fullscreen="true">
            <div id="container">
                <h1> NombreDeLaApp </h1>
                <p> NombreDeLaApp te permite gestionar y acceder tus materiales educativos. 
                    Ádemas es una herramienta que permite enseñar y aprender de una manera distinta.
                </p>
                <ion-button router-link="login"> Comenzar </ion-button>
            </div>
        </ion-content>
    </ion-page>
</template>

<script>
import { IonPage, IonHeader, IonContent, IonButton } from "@ionic/vue";

export default {
    components:{
        IonPage,
        IonHeader,
        IonContent,
        IonButton
    }    
}
</script>

<style scoped>
#container {
  text-align: center;
  position: absolute;
  left: 0;
  right: 0;
}

</style>