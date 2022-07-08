<template>
    <ion-page>
        <ion-header>
            <ion-toolbar>
                <ion-buttons slot="start">
                    <ion-back-button default-href="/tabs/cursos"></ion-back-button>
                </ion-buttons>
                <ion-title tabindex="0">Detalle de curso</ion-title>
            </ion-toolbar>
        </ion-header>
        <ion-content>
            <h2>probando detalle curso {{ cursoId }}</h2>
            <h3 v-if="!loadedCurso">Ups, algo no anda</h3>
        </ion-content>
    </ion-page>
</template>

<script>
import { defineComponent } from 'vue';
import {  IonPage, IonHeader, IonToolbar, IonTitle, IonContent, IonButtons, IonBackButton } from '@ionic/vue';

export default defineComponent({
  name: 'DetalleCursos',
  components: { IonPage, IonHeader, IonToolbar, IonTitle, IonContent, IonButtons, IonBackButton },
  data () {
    return {
        cursoId: this.$route.params.id,
    };
  },
  computed: {
    loadedCurso() {
        return this.$store.getters.curso(this.cursitoId);
    },
  }
});
</script>