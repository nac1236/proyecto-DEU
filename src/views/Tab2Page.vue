<template>
  <ion-page>
    <ion-header>
      <ion-toolbar>
        <ion-title>Tab 2</ion-title>
        <ion-buttons slot="start">
          <ion-back-button :default-href="pageDefaultBackLink"></ion-back-button>
        </ion-buttons>
      </ion-toolbar>
    </ion-header>
    <ion-content :fullscreen="true">
      <!-- <ion-header collapse="condense">
        <ion-toolbar>
          <ion-title size="large">Tab 2</ion-title>
        </ion-toolbar>
      </ion-header> -->
      
      <ListadoCursos />
    </ion-content>
  </ion-page>
</template>

<script>
//import { defineComponent } from 'vue';
import { IonPage, IonHeader, IonToolbar, IonTitle, IonContent, IonButtons, IonBackButton } from '@ionic/vue';
import ListadoCursos from '../components/ListadoCursos.vue';
//import ExploreContainer from '@/components/ExploreContainer.vue';

export default ({
  name: 'Tab2Page',
  components: { ListadoCursos, IonHeader, IonToolbar, IonTitle, IonContent, IonPage, IonButtons, IonBackButton }
});
</script>
